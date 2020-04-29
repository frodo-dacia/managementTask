using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Serializable]
public class Packet
{

    public Packet() { }
    //type va decide daca avem ack(0) sau data(1)
    public string _type { get; set; }

    //pentru id-ul clientului voi rezerva 6 caractere
    public string _idClient { get; set; }

    public string _data { get; set; }

    public Packet(string type, string idClient, string data)
    {
        _type = type;
        _data = data;
        _idClient = idClient;
        //cand o sa transmit verific daca (idClient<6)
        for (int i = 0; i < 6 - idClient.Length; ++i)
            _idClient = '0' + _idClient;
    }



    public override string ToString()
    {
        return "Packet: type=" + _type + ", idClient=" + _idClient + ", data=" + _data;
    }

}
