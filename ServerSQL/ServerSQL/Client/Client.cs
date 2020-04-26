﻿using System;
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
            string imei = String.Empty;
            string data = null;
            Byte[] bytes = new Byte[1024];
            string str = "";
            int i;
            try
            {
                while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                {
                    string hex = BitConverter.ToString(bytes);
                    data = Encoding.ASCII.GetString(bytes, 0, i);
                    _log.WriteLog(Thread.CurrentThread.ManagedThreadId + ": Received: " + data + "\n");
                    Command.Command command = new Command.Command(dataController,data);
                    str = command.Execute();
                    Console.Write(clientPool.GetIpClients());
                    Byte[] reply = System.Text.Encoding.ASCII.GetBytes(str);
                    stream.Write(reply, 0, reply.Length);
                    _log.WriteLog(Thread.CurrentThread.ManagedThreadId + ": Sent: " + str + "\n");
                }
            }
            catch (Exception e)
            {
                //Console.WriteLine("Exception: {0}", e.ToString());
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