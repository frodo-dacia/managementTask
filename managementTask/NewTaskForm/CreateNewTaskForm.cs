//Autor1: Sandu Diana-Elena
//Functionalitate: In aceasta clasa am codificat cererea catre server si am procesat raspunsul primit de catre acesta pt a crea un nou task in baza de date aferenta.
//Autor2: Stefan Andrei
//Functionalitate: In aceasta clasa am creat un form cu ajutorul caruia cream un nou task. Totodata facem si verificarile ca datele introduse da fie in formatul in care trebuie
//                  pentru field-ul respectiv si mai verificam ca id-ul task-ului sa fie unic in baza de date si sa nu existe 2 task-uri cu id-uri diferite dar cu field-uri identice.

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
        private Packet packet = new Packet();
        private Packet response = new Packet();

        public CreateNewTaskForm(Client client, Tasks tasks)
        {
            this.client = client;
            this.tasks = tasks;
            InitializeComponent();
        }

        private void CreateNewTaskForm_Load(object sender, EventArgs e)
        {

            foreach (var obj in users)
            {
                comboBox_User.Items.Add(obj.Name);
            }
        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            bool approved = true;
            try
            {
                List<Task> currentTasks = Tasks.MyTasks;
                string taskId = textBox_TaskID.Text;
                foreach (var obj in currentTasks)
                {
                    if (obj.Task_ID == Convert.ToInt32(taskId))
                    {
                        MessageBox.Show("This ID task already exists");
                        approved = false;
                        break;
                    }
                }

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
                string nota = comboBox_Nota.Text;
                string timpEstimat = textBox_Timp.Text;
                int logTime = 0;
                string comment = "-";

                foreach (var obj in currentTasks)
                {
                    if (obj.User_ID == userId && obj.Tip == tip && obj.Continut == continut && obj.Nota == nota && obj.TimpEstimat == Convert.ToInt32(timpEstimat))
                    {
                        MessageBox.Show("This task exists with another ID");
                        approved = false;
                        break;
                    }
                }

                if (approved == true)
                {

                    packet._data = "InsertRowIntoTable|TaskDB,Task," + taskId + "," + userId + "," + tip + "," + status + "," + continut + "," + nota + "," + timpEstimat + "," + logTime + "," + comment;

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

        private void numberValidation(KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if ((!Char.IsDigit(chr)) && (chr !=(char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid number");
            }
        }

        private void textBox_TaskID_KeyPress(object sender, KeyPressEventArgs e)
        {
            numberValidation(e);
        }

        private void textBox_Nota_KeyPress(object sender, KeyPressEventArgs e)
        {
            numberValidation(e);
        }

        private void textBox_Timp_KeyPress(object sender, KeyPressEventArgs e)
        {
            numberValidation(e);
        }

        private void textBox_TaskID_Leave(object sender, EventArgs e)
        {
            List<Task> currentTasks = Tasks.MyTasks;
            string taskId = textBox_TaskID.Text;
            foreach (var obj in currentTasks)
            {
                if (obj.Task_ID == Convert.ToInt32(taskId))
                {
                    MessageBox.Show("This task id is already used.");
                    textBox_TaskID.Text = "";
                }
            }
        }

        private void textBox_Timp_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Nota_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
