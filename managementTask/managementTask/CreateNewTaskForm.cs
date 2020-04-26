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
        Tasks tasks = null;
        private Client client = null;
        private List<User> users = Users.MyUsers;
        public CreateNewTaskForm(Client client, Tasks tasks)
        {
            this.client = client;
            this.tasks = tasks;
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
                string taskId = textBox_TaskID.Text;
                string userName = comboBox_User.Text;
                int userId = -1;
                foreach (var obj in users)
                {
                    if (obj.Name == userName)
                    {
                        userId = obj.ID;
                    }
                }

                string tip = textBox_Tip.Text;
                string status = comboBox_Status.Text;
                string continut = textBox_Continut.Text;
                string nota = textBox_Nota.Text;
                string timpEstimat = textBox_Timp.Text;
                
                client.SendMessage("InsertRowIntoTable|TaskDB,Task," + taskId + "," + userId + "," + tip + "," + status + "," + continut + "," + nota + "," + timpEstimat);
                
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
    }
}
