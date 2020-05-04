using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Serializable]
public class Packet
{

    public Packet() { }

    public string _data { get; set; }
    public string _type { get; set; }

    public Packet(string type, string data)
    {
        _type = type;
        _data = data;  
    }

    public override string ToString()
    {
        return "Packet: data=" + _data;
    }

}
