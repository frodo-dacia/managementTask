//Autor:Sandu Diana-Elena
//Functionalitate: Aceasta clasa se ocupa de serializarea TCP, punand la dispozitie posibilitatea transmiterii
//                 a multiple pachete intre mai multe dispozitive diferite conectate in aceeasi retea
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ServerSQL.Command
{
    public class SerializeControl
    {
        static IFormatter formatter = new BinaryFormatter();

        static public Packet ReadObject(NetworkStream stream, string IP)   //folosind aceasta functie pot primi pachete la client utilizand TCP
        {
            try
            {
                Byte[] bytes = new Byte[9999];
                stream.Read(bytes, 0, bytes.Length);
                MemoryStream ms = new MemoryStream(bytes);
                BinaryFormatter bf1 = new BinaryFormatter();
                ms.Position = 0;
                object rawObj = bf1.Deserialize(ms);
                Packet packet = (Packet)rawObj;
                ms.Seek(0, SeekOrigin.Begin);
                return packet;
            }
            catch (Exception) { MessageBox.Show("INFO: " + IP + " closed the connection!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            return new Packet();
        }

        static public void WriteObject(NetworkStream stream, Packet packet, string IP)   //folosind aceasta functie pot trimite pachete la client utilizand TCP
        {
            if (packet != null)
            {
                try
                {
                    byte[] userDataBytes;
                    MemoryStream ms1 = new MemoryStream();
                    BinaryFormatter bf2 = new BinaryFormatter();
                    bf2.Serialize(ms1, packet);
                    userDataBytes = ms1.ToArray();
                    stream.Write(userDataBytes, 0, userDataBytes.Length);

                }
                catch (Exception)
                {
                    MessageBox.Show("INFO: " + IP + " closed the connection!");
                }

            }
        }
    }
}