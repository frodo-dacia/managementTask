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

        List<Client> _clientPool = new List<Client>();
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
    }
}
