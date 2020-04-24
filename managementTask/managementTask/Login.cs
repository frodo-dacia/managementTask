﻿using System;
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
    public partial class Login : Form
    {
        private Users _Users;
        public Login()
        {
            InitializeComponent();
            _Users = new Users();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            string userName = textBox_UserName.Text;
            string password = textBox_Password.Text;
            bool loginStatus = _Users.Login(userName, password);
            if(loginStatus == true)
            {
                this.Hide();
                TasksForm tasksForm = new TasksForm();
                tasksForm.ShowDialog();
                this.Close();
                

               
            }
            else
            {
                MessageBox.Show("Login failed.");
            }
        }
    }
}