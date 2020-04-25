using ServerSQL.Client;
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
                        Console.Write("> ");
                        break;
                    case "help":
                        ShowHelp();
                        Console.Write("> ");
                        break;
                    case "connections":
                        ShowConnections();
                        Console.Write("> ");
                        break;
                    case "close":
                        QuitApp();
                        Console.Write("> ");
                        break;
                    case "kill":
                        KillConnection();
                        Console.Write("> ");
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
            Console.Write("Client ID to kill: ");
            string s = Console.ReadLine();
            ClientPool aux = new ClientPool();
            aux.KillClient(s);
            Console.WriteLine("Killed: " + s);
        }

        private void QuitApp()
        {
            StopServer();
            System.Environment.Exit(1);
        }

        private void StopServer()
        {
            Server t = new Server();
            t.Stop();
        }

        private void ShowConnections()
        {
            ClientPool aux = new ClientPool();
            Console.WriteLine("IP_ADDRESS             |    ID");
            Console.Write(aux.ToString());
        }

        private void ShowHelp()
        {

            Console.WriteLine("" +
                "\t> start => Starts the server.\n" +                
                "\t> connections => Shows active connections.\n" +
                "\t> kill => Kills a connections(prompts to input).\n" +
                "\t> close => Closes app.\n" +
                "\t> help => Shows help.");
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
            }catch(Exception)
            {
                Console.WriteLine("Eroare la StartServer");
            }
        }

        static public void ShowError(string i)
        {
            Console.WriteLine("\n"+i);
            Console.Write("> ");
        }
    }
}
