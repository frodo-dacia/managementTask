//Autor: Sandu Diana-Elena
//Functionalitate: In aceasta clasa am codificat cererea catre server si am procesat raspunsul primit de catre acesta pt a primi datele userilor existente in baza de date aferenta
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace managementTask
{

    static class Access
    {
        public const int Admin = 0;
        public const int User = 1;
    }
    public struct User
    {
        public readonly int ID;
        public readonly string Name;
        public readonly string PassHash;
        public readonly int AccessLevel;

        public User(int id, string name, string passHash, int accessLevel)
        {
            ID = id;
            Name = name;
            PassHash = passHash;
            AccessLevel = accessLevel;
        }
    }
    public class Users
    {
        private static List<User> _users;
        private User _currentUser;
        private Client client = null;
        private Packet packet = new Packet();
        private Packet response = new Packet();
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Packet));
       
           
    public static List<User> MyUsers {
            get
            {
                return _users;
            } 
        }

        public Users(Client client)
        {
           
            this.client = client;
            var networkStream = client.stream;
            try
            {     
                _users = new List<User>();
                GetTable(client);
 
            }
            catch (Exception)
            {
                MessageBox.Show("Va rugam incercati mai tarziu!");
            }
        }

        private void GetTable(Client client)   //trimit comanda la server
        {
            packet._data = "GetTable|UserDB,User,user";
            do
            {

                client.WriteObject(packet);
                response = client.ReadObject();
                ParseResponse(response);   //parsez raspunsul primit de la server

            } while ( (response != null) && (!response._type.Equals("user")));
            

        }

        private void ParseResponse(Packet response)
        {
            string[] values = response._data.Split(';').ToArray();
            foreach (string str in values)
            {
                string[] toks = str.Split(',').ToArray();

                if (!str.Equals(""))
                {
                    User user = new User(Convert.ToInt32(toks[0]), toks[1], toks[2], Convert.ToInt32(toks[3]));
                    _users.Add(user);
                }
            }
        }

        public int GetAccessLevel(string userName, string password)
        {
            int accessLevel = -1;

            foreach (User user in _users)
            {
                if (user.Name == userName && user.PassHash == Crypto.HashString(password))
                {
                    accessLevel = user.AccessLevel;
                }
            }
            return accessLevel;
        }

        public int GetId(string userName, string password)
        {
            int id = -1;

            foreach (User user in _users)
            {
                if (user.Name == userName && user.PassHash == Crypto.HashString(password))
                {
                   id = user.ID;
                }
            }
            return id;
        }

        public bool Login(string userName, string password)
        {
            password = Crypto.HashString(password);
            foreach (var user in _users)
            {
                if ((user.Name == userName) && (user.PassHash == password))
                {
                    _currentUser = user;
                    return true;

                }
            }
            return false;
        }

    }
}
