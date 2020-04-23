using System;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        Thread t = new Thread(delegate ()
        {

            Server myserver = new Server("192.168.56.1", 13000);
        });
        t.Start();

        Console.WriteLine("Server Started...!");

    }
}
