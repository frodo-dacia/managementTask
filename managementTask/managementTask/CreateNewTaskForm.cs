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
    public partial class CreateNewTaskForm : Form
    {
        private List<User> users = Users.MyUsers;
        public CreateNewTaskForm()
        {
            InitializeComponent();
        }

        private void CreateNewTaskForm_Load(object sender, EventArgs e)
        {
            
            foreach(var obj in users)
            {
                comboBox_User.Items.Add(obj.Name);
            }
        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            try
            {
                int taskId = Convert.ToInt32(textBox_TaskID.Text);
                string userName = comboBox_User.Text;
                int userId;
                foreach (var obj in users)
                {
                    if (obj.Name == userName)
                    {
                        userId = obj.ID;
                    }
                }
                string tip = textBox_Tip.Text;
                string stastus = comboBox_Status.Text;
                string continut = textBox_Continut.Text;
                int nota = Convert.ToInt32(textBox_Nota.Text);
                int timpEstimat = Convert.ToInt32(textBox_Timp);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            /*TODO de adaugat task-ul nou*/


        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
