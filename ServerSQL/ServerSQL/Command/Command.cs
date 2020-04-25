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

        private readonly byte[] inputStream=null;
        private SqlCommand _sqlCommand=null;

        public Command(byte[] input)
        {
            inputStream = input;
            _sqlCommand = Parse(inputStream);
        }

        private SqlCommand Parse(byte[] input)
        {
            //implementare parser
            throw new NotImplementedException();
        }

        public List<string> Execute()
        {
            //implementare metoda Execute
            throw new NotImplementedException();
        }
    }
}
