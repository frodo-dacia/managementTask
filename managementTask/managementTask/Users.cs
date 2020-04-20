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
        public readonly string Name;
        public readonly string PassHash;
        public readonly int AccessLevel;

        public User(string name, string passHash, int accessLevel)
        {
            Name = name;
            PassHash = passHash;
            AccessLevel = accessLevel;
        }
    }
    public class Users
    {
        private List<User> _users;
        private User _currentUser;

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
                    User user = new User(toks[0], toks[1], Convert.ToInt32(toks[2]));
                    _users.Add(user);
                }
                sr.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
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
