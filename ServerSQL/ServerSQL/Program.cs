using ServerSQL;
using System;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        Thread u = new Thread(delegate ()
        {
            ShellMenu menu = new ShellMenu();
        });
        u.Start();
    }
}
