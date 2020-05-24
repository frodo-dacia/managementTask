//Autor1: Sandu Diana-Elena
//Functionalitate: In aceasta clasa am codificat cererea catre server si am procesat raspunsul primit de catre acesta pt a crea un nou user in baza de date aferenta
//Autor2: Stefan Andrei
//Functionalitate:  In aceasta clasa am creat un form cu ajutorul caruia cream un nou user. Totodata facem si verificarile ca datele introduse da fie in formatul in care trebuie
//                  pentru field-ul respectiv si mai verificam ca id-ul si user name-ul sa fie unice in baza de date.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace managementTask
{
    public partial class CreateNewUserForm : Form
    {
        private Packet packet = new Packet();
        private Packet response = new Packet();

        private Client client = null;

        public CreateNewUserForm(Client client)
        {
            this.client = client;
            InitializeComponent();
        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            bool approved = true;
            List<User> currentUsers = Users.MyUsers;
            try
            {
                string userID = textBox_UserID.Text;
                string userName = textBox_UserName.Text;
                string password = textBox_Pass.Text;
                password = Crypto.HashString(password);
                string access = comboBox_AccessLevel.Text;
                int accessLevel = 1;
                switch (access)
                {
                    case "ADMIN":
                        accessLevel = 0;
                        break;
                    case "USER":
                        accessLevel = 1;
                        break;
                }

                foreach(var obj in currentUsers)
                {
                    if(obj.ID == Convert.ToInt32(userID))
                    {
                        MessageBox.Show("Users with this userId already exists.");
                        approved = false;
                        break;
                    }
                    else if(obj.Name == userName)
                    {
                        MessageBox.Show("Users with this userName already exists.");
                        approved = false;
                        break;
                    }

                }


                if(approved == true)
                {
                    packet._data = "InsertRowIntoTable|UserDB,User," + userID + "," + userName + "," + password + "," + accessLevel;

                    client.WriteObject(packet);
                    response = client.ReadObject();
                }
                

                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
           
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateNewUserForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox_UserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if ((!Char.IsDigit(chr) && (chr != (char)Keys.Back)))
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid number");
            }
        }
    }
}
