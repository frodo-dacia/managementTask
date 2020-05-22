using ServerSQL;
using ServerSQL.Client;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using managementTask;
sealed class Server
{
    private static Server instance;
    private static readonly object padlock = new object();
    private static TcpListener server;
    private static ClientPool _clientPool;
  

    public static Server Instance
    {
        get
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new Server(1300);
                }
                return instance;
            }
        }
    }
    public Server()
    {
         }

    public Server( int port)
    {
        if (server == null)
        {            
            server = new TcpListener(IPAddress.Any, port);
            _clientPool = new ClientPool();
            server.Start();
            StartListener();
        }
        else
        {
            Console.WriteLine("Server already started.\n");
        }
    }
    public void StartListener()
    {
        try
        {
            while (true)
            {            
               
                if (server.Pending())
                {
                    _clientPool.AddClient(server.AcceptTcpClient());
                }         
            }
        }
        catch (SocketException e)
        {
            ShellMenu.ShowError("SocketException: "+ e);
            server.Stop();
        }
    }
    
    public void Stop()
    {
        _clientPool.CloseAllConnections();
    }
}