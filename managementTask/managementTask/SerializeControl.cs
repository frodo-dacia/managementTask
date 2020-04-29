using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


class SerializeControl
{

    static Packet ReadObject(NetworkStream stream)
    {
        var xmlSerializer = new XmlSerializer(typeof(Packet));

        Packet packet = (Packet)xmlSerializer.Deserialize(stream);

        return packet;
    }

    static void WriteObject(NetworkStream stream, Packet packet)
    {
        var xmlSerializer = new XmlSerializer(typeof(Packet));
        var networkStream = stream;
        if (networkStream.CanWrite)
        {
            xmlSerializer.Serialize(networkStream, packet);
        }
    }
}