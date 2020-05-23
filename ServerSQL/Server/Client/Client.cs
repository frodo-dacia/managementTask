//Autor: Sandu Diana-Elena
//Functionalitate: In aceasta clasa am realizat serializarea raspunsului serverului fata de client si deserializarea cererii clientului fata de server
//                 folosindu-ma de clasele DataController(manipularea bazei de date) si Command (procesarea cererii)



using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using managementTask;
using ServerSQL.Command;

namespace ServerSQL.Client
{
    class Client
    {

        readonly string ID = Logger.RandomString(4, true);
        private static DataController dataController = new DataController();
        private TcpClient _client = null;
        private Logger _log = null;
        private NetworkStream stream = null;
        private ClientPool clientPool = null;

        public Client(TcpClient newClient, ClientPool clientPool)
        {

            this.clientPool = clientPool;
            this._client = newClient;
            Thread t = new Thread(new ParameterizedThreadStart(this.HandleDevice));
            t.Start(_client);
            this._log = new Logger();
            this._log.WriteLog("New connection: " + _client.Client.RemoteEndPoint.ToString());
        }

        public void CloseConnection(string log)
        {
            _log.WriteLog(log);
            _client.Close();
        }

        public void HandleDevice(Object obj)
        {
            TcpClient client = (TcpClient)obj;
            stream = client.GetStream();
            Packet packet = new Packet();   //pachetul primit de la client
            Packet responsePacket = new Packet();   //pachetul pe care il vom trimite in urma cerererii clientului

            try
            {
                while (Running())
                {
                    packet = SerializeControl.ReadObject(stream, _client.Client.RemoteEndPoint.ToString());   //citesc pachetul primit de la client folosind serializare TCP
                    _log.WriteLog(Thread.CurrentThread.ManagedThreadId + ": Received: " + packet._data + "\n");

                    Command.Command command = new Command.Command(dataController, packet);
                    responsePacket = command.Execute();  // am pregatit raspunsul

                    _log.WriteLog(Thread.CurrentThread.ManagedThreadId + ": Sent: " + responsePacket._data + "\n");
                    SerializeControl.WriteObject(stream, responsePacket, _client.Client.RemoteEndPoint.ToString());   //trimit raspunsul clientului folosind serializare TCP
                }
            }
            catch (Exception e)
            {
                _log.WriteLog("Exception: " + e.ToString());
                client.Close();
            }
        }
    
        bool Running()
        {
            return true;
        }

        public override string ToString()
        {
            return _client.Client.RemoteEndPoint.ToString()+"         "+this.ID;
        }

        public string GetIp()
        {
            return _client.Client.RemoteEndPoint.ToString();
        }

        public string GetID()
        {
            return ID;
        }
    }
}
