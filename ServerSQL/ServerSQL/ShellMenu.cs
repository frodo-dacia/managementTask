using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerSQL
{
    sealed class ShellMenu
    {

        private static ShellMenu instance = null;
        private static readonly object padlock = new object();
        public static ShellMenu Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new ShellMenu();
                    }
                    return instance;
                }
            }
        }

        public ShellMenu()
        {
            this.Start();
        }

        public void Start()
        {
            
            Console.WriteLine("Server Console v1.0 by Frodo");
            Console.WriteLine("Type '> help' for available commands...");
            Console.Write("> ");
            while (true)
            {
                switch (Console.ReadLine())
                {
                    case "start":
                        StartServer();
                        break;
                    case "help":
                        ShowHelp();
                        break;
                    case "connections":
                        ShowConnections();
                        break;
                    case "stop":
                        StopServer();
                        break;
                    case "quit":
                        QuitApp();
                        break;
                    case "kill":
                        KillConnection();
                        break;
                    case "":
                        Console.Write("> ");
                        break;
                    default:
                        Console.Write("Invalid command. Type '> help' for available commands...\n> ");
                        break;
                }
            }
           
        }

        private void KillConnection()
        {
            throw new NotImplementedException();
        }

        private void QuitApp()
        {
            throw new NotImplementedException();
        }

        private void StopServer()
        {
            throw new NotImplementedException();
        }

        private void ShowConnections()
        {
            throw new NotImplementedException();
        }

        private void ShowHelp()
        {
            throw new NotImplementedException();
        }

        private void StartServer()
        {
            try
            {
                Thread t = new Thread(delegate ()
                {

                    Server myserver = new Server(13000);
                });
                t.Start();
                Console.WriteLine("Server Started");
                Console.Write("> ");
            }catch(Exception)
            {
                Console.WriteLine("Eroare la StartServer");
            }
        }

        static public void ShowError(string i)
        {
            Console.WriteLine(i);
            Console.Write("> ");
        }
    }
}
