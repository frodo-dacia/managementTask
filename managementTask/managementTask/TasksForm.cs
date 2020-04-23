using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace managementTask
{
    public partial class TasksPage : Form
    {
        int refreshPageIndx = 0;
        private Tasks _Tasks;
        private List<TextBox> tasksShown = new List<TextBox>();
        public TasksPage()
        {
            InitializeComponent();
            _Tasks = new Tasks();
            InitializeUsers();
        }

        private void InitializeComponent()
        {
            this.label_Kanban = new System.Windows.Forms.Label();
            this.table_StatusName = new System.Windows.Forms.TableLayoutPanel();
            this.label_Done = new System.Windows.Forms.Label();
            this.label_CodeReview = new System.Windows.Forms.Label();
            this.label_InProgress = new System.Windows.Forms.Label();
            this.label_ToDo = new System.Windows.Forms.Label();
            this.table_StatusName.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Kanban
            // 
            this.label_Kanban.AutoSize = true;
            this.label_Kanban.BackColor = System.Drawing.Color.Transparent;
            this.label_Kanban.Font = new System.Drawing.Font("MV Boli", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Kanban.ForeColor = System.Drawing.Color.Black;
            this.label_Kanban.Location = new System.Drawing.Point(34, 35);
            this.label_Kanban.Name = "label_Kanban";
            this.label_Kanban.Size = new System.Drawing.Size(277, 52);
            this.label_Kanban.TabIndex = 0;
            this.label_Kanban.Text = "Kanban Board";
            // 
            // table_StatusName
            // 
            this.table_StatusName.BackColor = System.Drawing.Color.Transparent;
            this.table_StatusName.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.table_StatusName.ColumnCount = 4;
            this.table_StatusName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_StatusName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_StatusName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_StatusName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_StatusName.Controls.Add(this.label_Done, 3, 0);
            this.table_StatusName.Controls.Add(this.label_CodeReview, 2, 0);
            this.table_StatusName.Controls.Add(this.label_InProgress, 1, 0);
            this.table_StatusName.Controls.Add(this.label_ToDo, 0, 0);
            this.table_StatusName.Location = new System.Drawing.Point(43, 179);
            this.table_StatusName.Name = "table_StatusName";
            this.table_StatusName.RowCount = 1;
            this.table_StatusName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_StatusName.Size = new System.Drawing.Size(1815, 41);
            this.table_StatusName.TabIndex = 1;
            // 
            // label_Done
            // 
            this.label_Done.AutoSize = true;
            this.label_Done.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Done.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Done.Location = new System.Drawing.Point(1365, 3);
            this.label_Done.Name = "label_Done";
            this.label_Done.Size = new System.Drawing.Size(444, 35);
            this.label_Done.TabIndex = 3;
            this.label_Done.Text = "DONE";
            this.label_Done.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_CodeReview
            // 
            this.label_CodeReview.AutoSize = true;
            this.label_CodeReview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_CodeReview.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CodeReview.Location = new System.Drawing.Point(912, 3);
            this.label_CodeReview.Name = "label_CodeReview";
            this.label_CodeReview.Size = new System.Drawing.Size(444, 35);
            this.label_CodeReview.TabIndex = 2;
            this.label_CodeReview.Text = "CODE REVIEW";
            this.label_CodeReview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_InProgress
            // 
            this.label_InProgress.AutoSize = true;
            this.label_InProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_InProgress.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InProgress.Location = new System.Drawing.Point(459, 3);
            this.label_InProgress.Name = "label_InProgress";
            this.label_InProgress.Size = new System.Drawing.Size(444, 35);
            this.label_InProgress.TabIndex = 1;
            this.label_InProgress.Text = "IN PROGRESS";
            this.label_InProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ToDo
            // 
            this.label_ToDo.AutoSize = true;
            this.label_ToDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_ToDo.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ToDo.Location = new System.Drawing.Point(6, 3);
            this.label_ToDo.Name = "label_ToDo";
            this.label_ToDo.Size = new System.Drawing.Size(444, 35);
            this.label_ToDo.TabIndex = 0;
            this.label_ToDo.Text = "TO DO";
            this.label_ToDo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TasksPage
            // 
            this.BackgroundImage = global::managementTask.Properties.Resources.taskManagementBackground;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.table_StatusName);
            this.Controls.Add(this.label_Kanban);
            this.Name = "TasksPage";
            this.Text = "Code";
            this.Load += new System.EventHandler(this.Tasks_Load);
            this.table_StatusName.ResumeLayout(false);
            this.table_StatusName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Tasks_Load(object sender, EventArgs e)
        {
            
        }

        private void InitializeUsers()
        {
            List<User> myUsers = new List<User>();
            myUsers = Users.MyUsers;
            int firstButtonX = 43;
            int firstButtonY = 110;
            foreach (var obj in myUsers)
            {
                Button dynamicButton = new Button();

                dynamicButton.Height = 33;
                dynamicButton.Width = 135;

                dynamicButton.BackColor = Color.SteelBlue;
                dynamicButton.ForeColor = Color.Black;
                dynamicButton.TabStop = false;
                dynamicButton.FlatStyle = FlatStyle.Flat;
                dynamicButton.FlatAppearance.BorderSize = 0;

                dynamicButton.Location = new Point(firstButtonX, firstButtonY);
                firstButtonX += 230;

                dynamicButton.Text = obj.Name;
                dynamicButton.Name = "button_" + obj.Name;
                dynamicButton.Font = new Font("Georgia", 16);

                dynamicButton.Click += (sender, e) => DynamicButton_Click(sender, e, obj.ID);

                Controls.Add(dynamicButton);

            }
        }

        private void DynamicButton_Click(object sender, EventArgs e, int ID)
        {
            TasksLoad(ID);
        }

        void TasksLoad(int ID)
        {
            if (tasksShown.Count != 0)
            {
                foreach (var element in tasksShown)
                {
                    element.Dispose();
                }
            }
            // tasksShown.Clear();

            
            int ValueX;
            int ValueYToDo = 73;
            int ValueYProg = 73;
            int ValueYRev = 73;
            int ValueYDone = 73;

            foreach (var obj in Tasks.MyTasks)
            {
                if (obj.User_ID == ID)
                {

                    int Task_ID = obj.Task_ID;
                    string Desc = obj.Continut;
                    int Timp = obj.TimpEstimat;
                    string Status = obj.Status;
                    string Tip = obj.Tip;
                    int Nota = obj.Nota;

                    TextBox task = new TextBox();

                    switch (obj.Status)
                    {
                        case "TO DO":
                            ValueX = 54;
                            ValueYToDo += 180;
                            task.Location = new Point(ValueX, ValueYToDo);
                            break;
                        case "IN PROGRESS":
                            ValueX = 54 + 453;
                            ValueYProg += 180;
                            task.Location = new Point(ValueX, ValueYProg);
                            break;
                        case "CODE REVIEW":
                            ValueX = 54 + 453 * 2;
                            ValueYRev += 180;
                            task.Location = new Point(ValueX, ValueYRev);
                            break;
                        case "DONE":
                            ValueX = 54 + 453 * 3;
                            ValueYDone += 180;
                            task.Location = new Point(ValueX, ValueYDone);
                            break;
                    }

                    task.AutoSize = false;
                    task.Width = 439;
                    task.Height = 150;

                    task.Multiline = true;
                    task.ScrollBars = ScrollBars.Vertical;
                    task.WordWrap = true;
                    task.ReadOnly = true;
                    task.Font = new Font("Calibri", 12);

                    
                    task.Text = "ID:  " + Task_ID.ToString() + Environment.NewLine +
                        "Tip:  " + Tip + Environment.NewLine +
                        "Descriere:  " + Desc + Environment.NewLine +
                        "Timp estimat:  " + Timp + Environment.NewLine +
                        "Nota:  " + Nota.ToString();

                   
                    task.Click += (sender, e) => taskClick(sender, e, Task_ID);
                    refreshPageIndx = ID;
                    
                    tasksShown.Add(task);
                    this.Controls.Add(task);
                    
                }

            }
          
        }
        private void taskClick(object sender, EventArgs e, int Task_ID)
        {
            
            EditTaskForm editTaskForm = new EditTaskForm(Task_ID);
            editTaskForm.ShowDialog();
            TasksLoad(refreshPageIndx);
            
        }


    }
}
