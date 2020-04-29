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
        ClientPool clientPool = new ClientPool();
        readonly string ID = Logger.RandomString(4,true);
        private static DataController dataController = new DataController();
        TcpClient _client = null;
        Logger _log = null;


        public Client(TcpClient newClient)
        {
            

            _client = newClient;          
            Thread t = new Thread(new ParameterizedThreadStart(this.HandleDevice));

            t.Start(_client);
            _log = new Logger();
            _log.WriteLog("New connection: "+_client.Client.RemoteEndPoint.ToString());
        }

        public void CloseConnection(string log)
        {
            _log.WriteLog(log);
            _client.Close();
        }

        public void HandleDevice(Object obj)
        {
            TcpClient client = (TcpClient)obj;
            var stream = client.GetStream();

            Packet packet = new Packet();
            Packet responsePacket = new Packet();
            try
            {
                while (true)
                {
                    packet = SerializeControl.ReadObject(stream);
                    _log.WriteLog(Thread.CurrentThread.ManagedThreadId + ": Received: " + packet + "\n");
                    
                      Command.Command command = new Command.Command(dataController, packet);
                     responsePacket = command.Execute();

                    SerializeControl.WriteObject(stream, responsePacket);
                    _log.WriteLog(Thread.CurrentThread.ManagedThreadId + ": Sent: " + packet + "\n");
                }   
            }
            catch (Exception e)
            {    
                _log.WriteLog("Exception: " + e.ToString());
                client.Close();
            }
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
