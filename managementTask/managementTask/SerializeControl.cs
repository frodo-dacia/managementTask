using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;


class SerializeControl
{
    //serializare TCP   

    static Packet ReadObject(NetworkStream stream)
    {
        try
        {
            var xmlSerializer = new XmlSerializer(typeof(Packet));

            Packet packet = (Packet)xmlSerializer.Deserialize(stream);

            return packet;
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
            return null;
        }
    }

    static void WriteObject(NetworkStream stream, Packet packet)
    {
        try
        {
            var xmlSerializer = new XmlSerializer(typeof(Packet));
            var networkStream = stream;
            if (networkStream.CanWrite)
            {
                xmlSerializer.Serialize(networkStream, packet);
            }
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
            return;
        }
    }

    //serializare XML utilizand fisiere

    static public Packet XMLDeserialize(string filename) {
        try
        {
            Packet packet = new Packet();
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(filename);
            string xmlString = xmlDocument.OuterXml;

            using (StringReader read = new StringReader(xmlString))
            {
                Type outType = typeof(Packet);

                XmlSerializer serializer = new XmlSerializer(outType);
                using (XmlReader reader = new XmlTextReader(read))
                {
                    packet = (Packet)serializer.Deserialize(reader);
                    return packet;
                }
            }
        }
        catch (Exception ex)
        {

            MessageBox.Show(ex.Message);
            return null;
        }
    }


    static public void XmlSerializer(Packet packet, string filename) {
        try
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlSerializer serializer = new XmlSerializer(packet.GetType());
            using (MemoryStream stream = new MemoryStream())
            {
                serializer.Serialize(stream, packet);
                stream.Position = 0;
                xmlDocument.Load(stream);
                xmlDocument.Save(filename);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}