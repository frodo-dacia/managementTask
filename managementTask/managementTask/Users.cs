using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace managementTask
{
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

        public static List<User> MyUsers {
            get
            {
                return _users;
            } 
        }

        public Users()
        {
            try
            {
                _users = new List<User>();
                StreamReader sr = new StreamReader("utilizatori.txt");
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] toks = line.Split('\t');
                    User user = new User(Convert.ToInt32(toks[0]), toks[1], toks[2], Convert.ToInt32(toks[3]));
                    _users.Add(user);
                }
                sr.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
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
