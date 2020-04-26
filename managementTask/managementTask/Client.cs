using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;

namespace managementTask
{
    public class Client
    {
        TcpClient client = null;
        NetworkStream stream = null;
        

        public void Start(String serverIP)
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                Connect(serverIP);
            }).Start();
            Console.ReadLine();
        }
       public void Connect(String serverIP)
        {
            try
            {
                Int32 port = 13000;
                client = new TcpClient(serverIP, port);
          
                // Bytes Array to receive Server Response.
               
               
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e);
            }
            Console.Read();
        }
        public void SendMessage(String message)
        {
            stream = client.GetStream();
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(message.ToString());
            // Send the message to the connected TcpServer. 
            stream.Write(data, 0, data.Length);
        }

        public String ReceiveMessage()
        {
            Byte[] data = new Byte[1024];
            String response = String.Empty;
            // Read the Tcp Server Response Bytes.
            Int32 bytes = stream.Read(data, 0, data.Length);
            response = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
           
           // Thread.Sleep(2000);
            return response;

        }

        public void CloseConnection()
        {
            stream.Close();
            client.Close();
        }
    }
}
