using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel;
using System.IO;

namespace managementTask
{
    public class Client
    {

        static IFormatter formatter = new BinaryFormatter();
        TcpClient client = null;
        public NetworkStream stream { get; set; }
       
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
            
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e);
            }
            Console.Read();
        }


        public void CloseConnection()
        {
            stream.Close();
            client.Close();
        }
  
         public Packet ReadObject()
        {
            try
            {
                stream = client.GetStream();
                Byte[] bytes = new Byte[9999];
                stream.Read(bytes, 0, bytes.Length);
                MemoryStream ms = new MemoryStream(bytes);
                BinaryFormatter bf1 = new BinaryFormatter();
                ms.Position = 0;
                object rawObj = bf1.Deserialize(ms);
                Packet packet = (Packet)rawObj;
                ms.Seek(0, SeekOrigin.Begin);
                return packet;
            }catch(Exception ) { MessageBox.Show("Cerere de date esuata!", "ERROR!!!",MessageBoxButtons.OK, MessageBoxIcon.Error); }
            return new Packet();
        }

        public void WriteObject(Packet packet)
        {
            try
            {
                if (packet != null)
                {
                    stream = client.GetStream();
                    byte[] userDataBytes;
                    MemoryStream ms1 = new MemoryStream();
                    BinaryFormatter bf2 = new BinaryFormatter();
                    bf2.Serialize(ms1, packet);
                    userDataBytes = ms1.ToArray();
                    stream.Write(userDataBytes, 0, userDataBytes.Length);
                }
            }
            catch(Exception )
            {
                MessageBox.Show("Trimitere de date esuata!", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
