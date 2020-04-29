using managementTask;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerSQL.Command
{
    class Command
    {

        private Packet receivedPacket = new Packet();
        private DataController dataController = null;
       
        public Command(DataController dataController, Packet receivedPacket)
        {
          ;
            this.receivedPacket = receivedPacket;
            this.dataController = dataController;
          
        }

        public Packet Execute()
        {
            String dataPacket = "";
            String input = receivedPacket._data;

            string[] val = input.Split('|').ToArray();
            string[] args = val[1].Split(',').ToArray();

            Packet responsePacket = new Packet();
            responsePacket._idClient = receivedPacket._idClient;
          
            // 1. GetTable
            if (CheckSubstring(input, "GetTable") && args.Length == 3)
            {
                List<List<string>> data = dataController.GetTable(args[0], args[1], args[2]);
                foreach (List<string> list in data)
                {
                    string str = string.Join(",", list);
                    dataPacket += str + ";";
                }
                responsePacket._type = "1";
            }


            // 2. UpdateTable 
            if (CheckSubstring(input, "UpdateTable") && args.Length == 5)
            {
                dataController.UpdateTable(args[1], args[0], args[2], args[3], args[4]);
                responsePacket._type = "1";
            }


            // 3. InsertRowIntoTable
            if(CheckSubstring(input, "InsertRowIntoTable") && args.Length == 9)
            {
                string[] values = new string[7];

                values[0] = args[2];
                values[1] = args[3];
                values[2] = args[4];
                values[3] = args[5];
                values[4] = args[6];
                values[5] = args[7];
                values[6] = args[8];

                dataController.InsertRowIntoTable(args[0], args[1],values,"task");
                responsePacket._type = "0";
            }
            if (CheckSubstring(input, "InsertRowIntoTable") && args.Length == 6)
            {
                string[] values = new string[4];

                values[0] = args[2];
                values[1] = args[3];
                values[2] = args[4];
                values[3] = args[5];
               
                dataController.InsertRowIntoTable(args[0], args[1], values, "user");
                responsePacket._type = "0";
            }

            responsePacket._data = dataPacket;
            return responsePacket;
        }
             

        public bool CheckSubstring( string s, string substring)
        {
            bool value = false;

            if (s.Length > substring.Length && s.Substring(0, substring.Length).Equals(substring))
                value = true;
  
            return value;
        }
    }
}
