using managementTask;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ServerSQL.Command
{
    class Command
    {

        private Packet receivedPacket = new Packet();
        private DataController dataController = null;   //transmit ca parametru pentru ca conexiunea necesita sa fie deschisa o singura data 
        
        public Command(DataController dataController, Packet receivedPacket)
        {   
            this.receivedPacket = receivedPacket;
            this.dataController = dataController;
        }

        public Packet Execute()
        {
            String dataPacket = "";   
            String input = receivedPacket._data;  //_data este de forma nume_functie | argumentele functiei

            string[] val = input.Split('|').ToArray();   //numele functiei din DataController
            string[] args = null;   //argumentele functiilor din DataController

            if(val.Length>1)   //verific daca functia necesita argumente
                args = val[1].Split(',').ToArray();

            Packet responsePacket = new Packet();   //pregatesc raspunsul pentru cererea clientului
            //Pot avea urmatoarele cereri:

            //1.
            if (CheckSubstring(input, "GetTable") && args.Length == 3)   //nume_functie = GetTable && arg.Length = 3
            {
                List<List<string>> data = dataController.GetTable(args[0], args[1], args[2]);

                //pregatesc _data raspunsului sub forma: extrag linie cu linie din tabela din BD. Intre elemente liniei extrase introduc "," iar la final de linie introduc ";"
                foreach (List<string> list in data)
                {
                    string str = string.Join(",", list);
                    dataPacket += str + ";";
                }

                //setez asta pentru retransmitere in cazul in care atunci cand cer tabela primesc un alt mesaj
                if (args[2].Equals("task")) responsePacket._type = "task";
				if (args[2].Equals("user")) responsePacket._type = "user";
            }

            // 2. 
            if (CheckSubstring(input, "UpdateTable") && args.Length == 5)   //nume_functie = UpdateTable && arg.Length = 5
            {
                dataController.UpdateTable(args[1], args[0], args[2], args[3], args[4]);          
            }

            // 3.1
            if(CheckSubstring(input, "InsertRowIntoTable") && args.Length == 9)    //nume_functie = InsertRowIntoTable && arg.Length = 9 in cazul tipului task
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
            }

            // 3.2
            if (CheckSubstring(input, "InsertRowIntoTable") && args.Length == 6)   //nume_functie = InsertRowIntoTable && arg.Length = 6 in cazul tipului user
            {
                string[] values = new string[4];

                values[0] = args[2];
                values[1] = args[3];
                values[2] = args[4];
                values[3] = args[5];
               
                dataController.InsertRowIntoTable(args[0], args[1], values, "user");     
            }

            // 4.1
            if (CheckSubstring(input, "Delete") && args.Length == 7)   //nume_functie = Delete && arg.Length = 7 in cazul tipului task
            {
                string[] values = new string[7];

                values[0] = args[2];
                values[1] = args[3];
                values[2] = args[4];
                values[3] = args[5];
                values[4] = args[6];

                dataController.Delete(args[0], args[1], values, "task");
            }

            // 4.2
            if (CheckSubstring(input, "Delete") && args.Length == 4)   //nume_functie = Delete && arg.Length = 4 in cazul tipului task
            {
                string[] values = new string[7];

                values[0] = args[2];
                values[1] = args[3];

                dataController.Delete(args[0], args[1], values, "user");
            }

            responsePacket._data = dataPacket;
            return responsePacket;
        }

        public string[] SubArray( string[] data, int index)
        {
            string[] result = new string[data.Length];
            Array.Copy(data, index, result, 0, data.Length);
            return result;
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
