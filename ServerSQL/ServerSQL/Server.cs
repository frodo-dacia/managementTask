using ServerSQL;
using ServerSQL.Client;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
sealed class Server
{

    private static Server instance = null;
    private static readonly object padlock = new object();
    TcpListener server = null;
    ClientPool _clientPool = null;

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
        
    public Server( int port)
    {
        
        server = new TcpListener(IPAddress.Any, port);
        _clientPool = new ClientPool();
        server.Start();
        StartListener();
    }
    public void StartListener()
    {
        try
        {
            while (true)
            {            
                //Console.WriteLine("Waiting for a connection...");
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
    public void HandleDevice(Object obj)
    {
        TcpClient client = (TcpClient)obj;
        var stream = client.GetStream();
        string imei = String.Empty;
        string data = null;
        Byte[] bytes = new Byte[256];
        int i;
        try
        {
            while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
            {
                string hex = BitConverter.ToString(bytes);
                data = Encoding.ASCII.GetString(bytes, 0, i);
                Console.WriteLine("{1}: Received: {0}", data, Thread.CurrentThread.ManagedThreadId);
                //aici ii trimitem datele pe care le vrea el
                string str = "Hey Device!";
                Byte[] reply = System.Text.Encoding.ASCII.GetBytes(str);
                stream.Write(reply, 0, reply.Length);
                Console.WriteLine("{1}: Sent: {0}", str, Thread.CurrentThread.ManagedThreadId);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: {0}", e.ToString());
            client.Close();
        }
    }
}