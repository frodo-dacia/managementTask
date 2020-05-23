//Autor: Sandu Diana-Elena
//Functionalitate: In aceasta clasa am codificat cererea catre server si am procesat raspunsul primit de catre acesta pt a primi toate taskurile existente in baza de date aferenta
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace managementTask
{
    public struct Task
    {
        public int Task_ID { get; set; }
        public int User_ID { get; set; }
        public string Tip { get; set; }
        public string Status { get; set; }
        public string Continut { get; set; }
        public string Nota { get; set; }
        public int TimpEstimat { get; set; }
        public int LogTime { get; set; }
        public string Comment { get; set; }

        public Task(int task_ID, int user_ID, string tip, string status, string continut, string nota, int timpEstimat, int logTime, string comment)
        {
            Task_ID = task_ID;
            User_ID = user_ID;
            Tip = tip;
            Status = status;
            Continut = continut;
            Nota = nota;
            TimpEstimat = timpEstimat;
            LogTime = logTime;
            Comment = comment;
        }
        public override string ToString()
        {
            return Task_ID + User_ID + Tip + Status + Continut + Nota + TimpEstimat + LogTime + Comment;
        }
    }
    public class Tasks
    {
        private static List<Task> _tasks;
        private Packet packet = new Packet();
        private Packet response = new Packet();

        public static List<Task> MyTasks
        {
            get
            {
                return _tasks;
            }
        }
        public Tasks(Client client)
        {
            try
            {
              
                _tasks = new List<Task>();
                GetTable(client);

                
            }
            catch (Exception exc)
            {
                GetTable(client);
                MessageBox.Show("Table Exc:"+exc.Message);
            }
        }

        private void GetTable(Client client)
        {
            packet._data = "GetTable|TaskDB,Task,task";

            do
            {
                client.WriteObject(packet);
                response = client.ReadObject();
            } while (!response._type.Equals("task"));
            ParseResponse(response);
        }

        private void ParseResponse(Packet response)
        {
            string[] values = response._data.Split(';').ToArray();
            foreach (string str in values)
            {
                string[] toks = str.Split(',').ToArray();

                if (!str.Equals(""))
                {
                    
                    Task task = new Task(Convert.ToInt32(toks[0]), Convert.ToInt32(toks[1]), toks[2], toks[3], toks[4], toks[5], Convert.ToInt32(toks[6]), Convert.ToInt32(toks[7]),toks[8]);
                    _tasks.Add(task);
                }
            }
        }
    }
}
