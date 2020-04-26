using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace managementTask
{
    public partial class EditTaskForm : Form
    {
        private int _taskID;
        private int _accessLevel;
        private List<Task> _taskuri = Tasks.MyTasks;
        public int canceled { get; set; }
        private Client client = null;

        public EditTaskForm(int taskID, int accessLevel, Client client)
        {
            _accessLevel = accessLevel;
            _taskID = taskID;
            InitializeComponent();
            this.client = client;
        }

        private void EditTaskForm_Load(object sender, EventArgs e)
        {
            if(_accessLevel == Access.Admin)
            {
                Button button = new Button();

                button.Height = 37;
                button.Width = 135;

                button.Location = new Point(455, 20);

                button.Text = "Delete Task";
                button.Name = "button_DeteleTask";

                button.Click += (Sender, E) => DeleteTask_Clicked(Sender, E);
                Controls.Add(button);
            }
            foreach (var obj in _taskuri)
            {
                if (obj.Task_ID == _taskID)
                {
                    textBox_Tip.Text = obj.Tip;
                    comboBox_Status.Text = obj.Status;
                    textBox_Continut.Text = obj.Continut;
                    textBox_Nota.Text = obj.Nota.ToString();
                    textBox_Timp.Text = obj.TimpEstimat.ToString();
                }
            }
        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            for(var i=0;i<_taskuri.Count();i++)
            {
                if(_taskuri[i].Task_ID == _taskID)
                {
                    _taskuri[i] = new Task(_taskuri[i].Task_ID, _taskuri[i].User_ID, textBox_Tip.Text, comboBox_Status.Text, textBox_Continut.Text, Convert.ToInt32(textBox_Nota.Text), Convert.ToInt32(textBox_Timp.Text));

                    client.SendMessage("UpdateTable|TaskDB,Task,Tip,"+ textBox_Tip.Text+","+_taskID);
                    client.ReceiveMessage();

                    client.SendMessage("UpdateTable|TaskDB,Task,Status," + comboBox_Status.Text + "," + _taskID);
                    client.ReceiveMessage();

                    client.SendMessage("UpdateTable|TaskDB,Task,Continut," + textBox_Continut.Text + "," + _taskID);
                    client.ReceiveMessage();
                    client.SendMessage("UpdateTable|TaskDB,Task,Nota," + textBox_Nota.Text + "," + _taskID);
                    client.ReceiveMessage();
                    client.SendMessage("UpdateTable|TaskDB,Task,TimpEstimat," + textBox_Timp.Text + "," + _taskID);
                    client.ReceiveMessage();
                   
                }
            }
            this.Close();

        }

        private void DeleteTask_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            canceled = 1;
            this.Close();
        }
    }
}
