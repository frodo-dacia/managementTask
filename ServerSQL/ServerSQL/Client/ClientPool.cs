using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerSQL.Client
{
    sealed class ClientPool : IEnumerable
    {
        private static List<Client> _clientPool = new List<Client>();
        private static ClientPool instance = null;
        private static readonly object padlock = new object();
        public static ClientPool Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new ClientPool();
                    }
                    return instance;
                }
            }
        }
        public ClientPool()
        {
        }
        public IEnumerator GetEnumerator()
        {
            return _clientPool.GetEnumerator();
        }

        public void AddClient(TcpClient newClient)
        {
            try
            {
                _clientPool.Add(new Client(newClient));
            }
            catch (Exception)
            {
                ShellMenu.ShowError("eroare la adaugare client in clientPool");
            }
        }

        public void CloseAllConnections()
        {
            foreach (Client client in _clientPool)
                client.CloseConnection("Connection clossed by server.");
        }

        public override string ToString()
        {
            string s="";
            foreach(Client client in _clientPool)
            {
                s += client.ToString() + "\n";
            }
            return s;
        }
        public string GetIpClients()
        {
            string s = "";
            foreach (Client client in _clientPool)
            {
                s += client.GetIp() + ",";
            }
            return s;
        }
        public void KillClient(string s)
        {
            Client clientToRemove = null;
            foreach(Client client in _clientPool)
            {
                if (s.Equals(client.GetID()))
                {
                    client.CloseConnection("Connection clossed by server command line.");
                    clientToRemove = client;
                }
            }
            _clientPool.Remove(clientToRemove);
        }
       
    }
}
