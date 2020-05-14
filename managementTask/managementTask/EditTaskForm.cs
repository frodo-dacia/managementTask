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
        private Packet packet = new Packet();
        private Packet response = new Packet();



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
                    comboBox_Nota.Text = obj.Nota;
                    textBox_Timp.Text = obj.TimpEstimat.ToString();
                    textBox_Comentarii.Text = obj.Comment;
                    textBox_TotalOrePontate.Text = obj.LogTime.ToString();
                }
            }
        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            for(var i=0;i<_taskuri.Count();i++)
            {
                if(_taskuri[i].Task_ID == _taskID)
                {
                    int totalOre = 0;
                    if (textBox_PontareOre.Text != "")
                    {
                        totalOre = _taskuri[i].LogTime + Convert.ToInt32(textBox_PontareOre.Text);
                    }
                                    
                    _taskuri[i] = new Task(_taskuri[i].Task_ID, _taskuri[i].User_ID, textBox_Tip.Text, comboBox_Status.Text, textBox_Continut.Text, comboBox_Nota.Text, Convert.ToInt32(textBox_Timp.Text), totalOre, textBox_Comentarii.Text);

                    try
                    {

                        packet._data = "UpdateTable|TaskDB,Task,Tip," + textBox_Tip.Text + "," + _taskID;
                        UpdateData(packet);

                        packet._data = "UpdateTable|TaskDB,Task,Status," + comboBox_Status.Text + "," + _taskID;
                        UpdateData(packet);

                        packet._data = "UpdateTable|TaskDB,Task,Continut," + textBox_Continut.Text + "," + _taskID;
                        UpdateData(packet);

                        packet._data = "UpdateTable|TaskDB,Task,Nota," + comboBox_Nota.Text + "," + _taskID;
                        UpdateData(packet);

                        packet._data = "UpdateTable|TaskDB,Task,TimpEstimat," + textBox_Timp.Text + "," + _taskID;
                        UpdateData(packet);

                        packet._data = "UpdateTable|TaskDB,Task,LogTime," + totalOre + "," + _taskID;
                        UpdateData(packet);

                        packet._data = "UpdateTable|TaskDB,Task,Comment," + textBox_Comentarii.Text + "," + _taskID;
                        UpdateData(packet);
                    }
                    catch (Exception ee) { MessageBox.Show(ee.Message); };
                }
            }
            this.Close();

        }

        private void UpdateData(Packet packet)
        {
            client.WriteObject(packet);
            response = client.ReadObject();
        }

        private void DeleteTask_Clicked(object sender, EventArgs e)
        {
            string tip = textBox_Tip.Text;
            string status = comboBox_Status.Text;
            string continut = textBox_Continut.Text;
            string nota = comboBox_Nota.Text;
            string timpEstimat = textBox_Timp.Text;

            packet = new Packet();
            packet._data = "Delete|TaskDB,Task," + tip + "," + status + "," + continut + "," + nota + "," + timpEstimat;
            client.WriteObject(packet);
            response = client.ReadObject();
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            canceled = 1;
            this.Close();
        }
        private void numberValidation(KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr))
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid number");
            }
        }
        private void textBox_Nota_KeyPress(object sender, KeyPressEventArgs e)
        {
            numberValidation(e);
        }

        private void textBox_Timp_KeyPress(object sender, KeyPressEventArgs e)
        {
            numberValidation(e);
        }

        private void textBox_Continut_TextChanged(object sender, EventArgs e)
        {
            if(_accessLevel==1)
                textBox_Continut.Enabled = false;
        }

        private void textBox_PontareOre_KeyPress(object sender, KeyPressEventArgs e)
        {
            numberValidation(e);
        }
    }
}
