using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerSQL.Client
{
    class Logger
    {
        string _path=null;
        public Logger()
        {
            try
            {
                string name = RandomString(8, true) + ".log";
                _path = System.IO.Directory.GetCurrentDirectory();
                _path = System.IO.Path.Combine(_path, "logs");
                System.IO.Directory.CreateDirectory(_path);
                _path = System.IO.Path.Combine(_path, name);
            }catch(Exception e)
            {
                ShellMenu.ShowError(e.ToString());
            }
        }

        public void WriteLog(string s)
        {
            try
            {
                File.AppendAllText(_path, s + Environment.NewLine);
            }
            catch(Exception e)
            {
                ShellMenu.ShowError(e.ToString());
            }
        }

        public static string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
    }
}
