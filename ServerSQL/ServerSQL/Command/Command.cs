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

        private string input = "";
        private DataController dataController = null;
       
        public Command(DataController dataController, string input)
        {
            this.input = input;
            this.dataController = dataController;
          
        }

        public string Execute()
        {
            String response = "";

            string[] val = input.Split('|').ToArray();
            string[] args = val[1].Split(',').ToArray();

            // 1. GetTable
            if (CheckSubstring(input, "GetTable") && args.Length ==3)
            {      
                    List<List<string>> data = dataController.GetTable(args[0], args[1], args[2]);
                    foreach(List<string> list in data)
                    {
                        string str = string.Join(",", list);
                        response += str+";";
                    }    
            }
            // 2. UpdateTable 
            if (CheckSubstring(input, "UpdateTable") && args.Length == 5)
            {
                Console.Write(input);

                dataController.UpdateTable(args[1], args[0], args[2], args[3], args[4]);
                response = "1";

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
                response = "1";
            }
            if (CheckSubstring(input, "InsertRowIntoTable") && args.Length == 6)
            {
                string[] values = new string[4];

                values[0] = args[2];
                values[1] = args[3];
                values[2] = args[4];
                values[3] = args[5];
               
                dataController.InsertRowIntoTable(args[0], args[1], values, "user");
                response = "1";
            }
            return response;

        }
             

        public bool CheckSubstring( string s, string substring)
        {
            bool value = false;

            if (s.Length > substring.Length && s.Substring(0, substring.Length).Equals(substring))
            {
                value = true;
                             
            }

            return value;
        }
    }
}
