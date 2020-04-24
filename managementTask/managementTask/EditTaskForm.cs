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
        private List<Task> _taskuri = Tasks.MyTasks;
        public EditTaskForm(int taskID)
        {
            _taskID = taskID;
            InitializeComponent();
        }

        private void EditTaskForm_Load(object sender, EventArgs e)
        {
            foreach (var obj in _taskuri)
            {
                if (obj.Task_ID == _taskID)
                {
                    textBox_Tip.Text = obj.Tip;
                    textBox_Status.Text = obj.Status;
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
                    _taskuri[i] = new Task(_taskuri[i].Task_ID, _taskuri[i].User_ID, textBox_Tip.Text, textBox_Status.Text, textBox_Continut.Text, Convert.ToInt32(textBox_Nota.Text), Convert.ToInt32(textBox_Timp.Text));
                    
                    string newLine = _taskuri[i].Task_ID.ToString() + '\t' + _taskuri[i].User_ID.ToString() + '\t' + textBox_Tip.Text + '\t' + textBox_Status.Text + '\t' + textBox_Continut.Text + '\t' + textBox_Nota.Text + '\t' + textBox_Timp.Text;

                    string[] arrLine = File.ReadAllLines("taskuri.txt");
                    arrLine[i] = newLine;
                    File.WriteAllLines("taskuri.txt", arrLine);
                    
                }
            }
            this.Close();

        }
    }
}
