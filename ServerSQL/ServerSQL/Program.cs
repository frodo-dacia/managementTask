
using System;
using ServerSQL;
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
