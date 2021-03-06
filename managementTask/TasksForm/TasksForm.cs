﻿//Autor1: Sandu Diana-Elena
//Functionalitate: In aceasta clasa am lucrat cu un BackgroundWorker care ma va ajuta ca la un anume interval de timp prestabilit sa verific daca userului 
//                 s-au efectuat schimbari in cadrul sectiunii personale de taskuri de catre admin(update, adaugare)
//                 Am implementat un buton de help pentru a oferi userului posibilitatea de a intelege cat mai bine functionalitatea interfetei in cauza.  
//Autor2: Stefan Andrei
//Functionalitate: In aceasta clasa am creat form-ul principal unde este tabela kanban. Aici putem vedea task-urile tuturor userilor, fiecare user isi poate modifica 
//                  task-urile lui iar adminul pe langa ca poate modifica task-urile tuturor poate sa si creeze task-uri noi sau sa stearga task-uri
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace managementTask
{
    public partial class TasksPage : Form
    {

        Client client = null;
        private int refreshPageIndx = 0;
        private Tasks _Tasks;
        private List<TextBox> tasksShown = new List<TextBox>();
        private User currentUser;
        private BackgroundWorker _worker = new BackgroundWorker();
        private List<Task> currentUser_tasks = new List<Task>();
 

        public TasksPage(User currentUser, Client client)
        {

            this.currentUser = currentUser;
            this.client = client;
            InitializeComponent();
            this._Tasks = new Tasks(client);
            InitializeUsers();
            if (currentUser.AccessLevel == Access.Admin)
            {
                AdminExtraButtons();
            }
            this._worker.DoWork += DoBackgroundWork;
            this._worker.RunWorkerAsync();

        }

        private List<Task> GetNewTasks() {   //functie care preia taskurile actuale

            new Tasks(client);
            List<Task> myTasks = Tasks.MyTasks.ToList();
            List<Task> newTasks = new List<Task>();
            foreach (Task t in myTasks)
            {
                if (currentUser.ID == t.User_ID)
                {
                    newTasks.Add(t);
                }
            }
            return newTasks;
        }
       

        private bool IsUpdateRequired()   //functie care compara taskurile curente cu cele actualizate de catre un alt client
        {
            List<Task> newTasks = GetNewTasks();

            if(newTasks.Count == currentUser_tasks.Count)
            {
                string newTasksString = "";
                string oldTasksString = "";
                foreach (Task t in newTasks)
                    newTasksString += t.ToString();
                foreach (Task t in currentUser_tasks)
                    oldTasksString += t.ToString();
                if (oldTasksString.Equals(""))
                    return false;
                currentUser_tasks = newTasks;
                 //MessageBox.Show("Curente:" + oldTasksString +"\nNOOOi:"+newTasksString);
                return (!newTasksString.Equals(oldTasksString));           
            }

            
            if (currentUser_tasks.Count == 0)
            {
                return false;
            }
            else
            {
                //intra n cazul in care am adaugat un task 
                currentUser_tasks = newTasks;
                return true;
            }         
        }
        private void DoBackgroundWork(object sender, DoWorkEventArgs e)   //workerul verifica periodic daca ar trebui sau nu sa fie actualizate taskurile pe interfata
        {
            try
            {
                while (!_worker.CancellationPending)
                {
                    if (IsUpdateRequired() == true)
                    { 
                        MessageBox.Show("Refresh is required! Your task section has been updated!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    Thread.Sleep(5000);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

       
     
        private void InitializeComponent()
        {
            this.label_Kanban = new System.Windows.Forms.Label();
            this.table_StatusName = new System.Windows.Forms.TableLayoutPanel();
            this.label_Done = new System.Windows.Forms.Label();
            this.label_CodeReview = new System.Windows.Forms.Label();
            this.label_InProgress = new System.Windows.Forms.Label();
            this.label_ToDo = new System.Windows.Forms.Label();
            this.HelpButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.table_StatusName.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Kanban
            // 
            this.label_Kanban.AutoSize = true;
            this.label_Kanban.BackColor = System.Drawing.Color.Transparent;
            this.label_Kanban.Font = new System.Drawing.Font("MV Boli", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Kanban.ForeColor = System.Drawing.Color.Black;
            this.label_Kanban.Location = new System.Drawing.Point(34, 27);
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
            this.label_ToDo.Click += new System.EventHandler(this.label_ToDo_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.BackColor = System.Drawing.Color.SteelBlue;
            this.HelpButton.FlatAppearance.BorderSize = 0;
            this.HelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpButton.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton.ForeColor = System.Drawing.Color.Black;
            this.HelpButton.Location = new System.Drawing.Point(1647, 36);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(75, 40);
            this.HelpButton.TabIndex = 2;
            this.HelpButton.TabStop = false;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = false;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.SteelBlue;
            this.LogoutButton.FlatAppearance.BorderSize = 0;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.Location = new System.Drawing.Point(1762, 36);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(118, 40);
            this.LogoutButton.TabIndex = 3;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // TasksPage
            // 
            this.AutoScroll = true;
            this.BackgroundImage = global::TasksForm.Properties.Resources.taskManagementBackground;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.HelpButton);
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
            currentUser_tasks = new List<Task>();
            try
            {
                if (tasksShown.Count != 0)
                {
                    foreach (var element in tasksShown)
                    {
                        element.Dispose();
                    }
                }
               
                int ValueX;
                int ValueYToDo = 73;
                int ValueYProg = 73;
                int ValueYRev = 73;
                int ValueYDone = 73;

                new Tasks(client);

                foreach (var obj in Tasks.MyTasks.ToList())
                {
                    if (obj.User_ID == ID)
                    {

                        int Task_ID = obj.Task_ID;
                        string Desc = obj.Continut;
                        int Timp = obj.TimpEstimat;
                        string Status = obj.Status;
                        string Tip = obj.Tip;
                        string Nota = obj.Nota;
                        int LogTime = obj.LogTime;
                        string Comment = obj.Comment;

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
                            "Nota:  " + Nota.ToString() + Environment.NewLine +
                            "Comentarii:  " + Comment;

                        task.Click += (sender, e) => taskClick(sender, e, Task_ID);
                        refreshPageIndx = ID;

                        tasksShown.Add(task);
                        this.Controls.Add(task);

                        if (ID == currentUser.ID)
                        {
                            Task t = new Task(Task_ID, ID, Tip, Status, Desc, Nota,Timp,LogTime,Comment);
                            currentUser_tasks.Add(t);
                        }
                    }

                }
            }catch(Exception e) { MessageBox.Show(e.Message); }
          
        }
        private void taskClick(object sender, EventArgs e, int Task_ID)
        {
           
            if (refreshPageIndx == currentUser.ID || currentUser.AccessLevel == Access.Admin)
            {
              
                EditTaskForm editTaskForm = new EditTaskForm(Task_ID,currentUser.AccessLevel,client);
                editTaskForm.ShowDialog();
                if (editTaskForm.canceled == 0)
                {
                    TasksLoad(refreshPageIndx);  
                }
            }
        }

        private void AdminExtraButtons()
        {
            /****************CREATE NEW TASK BUTTON**********************/
            Button NewTaskButon = new Button();

            NewTaskButon.Height = 40;
            NewTaskButon.Width = 204;

            NewTaskButon.BackColor = Color.SteelBlue;
            NewTaskButon.ForeColor = Color.Black;
            NewTaskButon.TabStop = false;
            NewTaskButon.FlatStyle = FlatStyle.Flat;
            NewTaskButon.FlatAppearance.BorderSize = 0;

            NewTaskButon.Location = new Point(372, 36);

            NewTaskButon.Text = "Create New Task";
            NewTaskButon.Name = "button_CreateNewTask";
            NewTaskButon.Font = new Font("Georgia", 16);

            NewTaskButon.Click += (sender, e) => CreateNewTask_Clicked(sender, e);
            Controls.Add(NewTaskButon);

            /****************CREATE NEW USER BUTTON**********************/

            Button NewUserButon = new Button();

            NewUserButon.Height = 40;
            NewUserButon.Width = 204;

            NewUserButon.BackColor = Color.SteelBlue;
            NewUserButon.ForeColor = Color.Black;
            NewUserButon.TabStop = false;
            NewUserButon.FlatStyle = FlatStyle.Flat;
            NewUserButon.FlatAppearance.BorderSize = 0;

            NewUserButon.Location = new Point(620, 36);

            NewUserButon.Text = "Create New User";
            NewUserButon.Name = "button_CreateNewUser";
            NewUserButon.Font = new Font("Georgia", 16);

            NewUserButon.Click += (sender, e) => CreateNewUser_Clicked(sender, e);
            Controls.Add(NewUserButon);

        }

        private void CreateNewTask_Clicked(object sender, EventArgs e)
        {
            CreateNewTaskForm createNewTask = new CreateNewTaskForm(client,_Tasks);
            createNewTask.ShowDialog();
            _Tasks = new Tasks(client);
            TasksLoad(refreshPageIndx);
        }
        
        private void CreateNewUser_Clicked(object sender, EventArgs e)
        {

            CreateNewUserForm createNewUser = new CreateNewUserForm(client);
            createNewUser.ShowDialog();
            new Users(client);
            InitializeUsers();
        }

        private void label_ToDo_Click(object sender, EventArgs e)
        {

        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            if (currentUser.AccessLevel == 0)
            {
                string text = System.IO.File.ReadAllText("HelpAdmin.txt");
                MessageBox.Show(text, "HELP" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string text = System.IO.File.ReadAllText("HelpUser.txt");
                MessageBox.Show(text,"HELP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            client.CloseConnection();
        }
    }
}
