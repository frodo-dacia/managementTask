using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ServerSQL.Command
{
    class SerializeControl
    {
        static IFormatter formatter = new BinaryFormatter();

        static public Packet ReadObject(NetworkStream stream)   //folosind aceasta functie pot primi pachete la client utilizand TCP
        {
            Packet packet = (Packet)formatter.Deserialize(stream);
            stream.Flush();
            return packet;
        }

        static public void WriteObject(NetworkStream stream, Packet packet)   //folosind aceasta functie pot trimite pachete la client utilizand TCP
        {
            if (packet != null)
            {
                formatter.Serialize(stream, packet);
                stream.Flush();
            }
        }
    }
}
