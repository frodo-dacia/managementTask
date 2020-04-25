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
        public CreateNewUserForm()
        {
            InitializeComponent();
        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            try
            {
                int userID = Convert.ToInt32(textBox_UserID);
                string userName = textBox_UserName.Text;
                string password = textBox_Pass.Text;
                password = Crypto.HashString(password);
                string access = comboBox_AccessLevel.Text;
                int accessLevel;
                switch (access)
                {
                    case "ADMIN":
                        accessLevel = 0;
                        break;
                    case "USER":
                        accessLevel = 1;
                        break;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            /*TODO de trimis la server*/
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
