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

        static public Packet ReadObject(NetworkStream stream)
        {
            IFormatter formatter = new BinaryFormatter();
            Packet packet = (Packet)formatter.Deserialize(stream); // you have to cast the deserialized object
            return packet;
        }

        static public void WriteObject(NetworkStream stream, Packet packet)
        {
            if (packet != null)
            {
                IFormatter formatter = new BinaryFormatter(); // the formatter that will serialize my object on my stream
                formatter.Serialize(stream, packet);
            }
        }
    }
}
