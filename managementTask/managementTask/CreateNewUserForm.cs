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


                packet._data = "InsertRowIntoTable|UserDB,User," + userID + "," + userName + "," + password + "," + accessLevel;

                client.WriteObject(packet);
                response = client.ReadObject();

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
    }
}
