﻿//Autor1: Sandu Diana-Elena
//Functionalitate: In aceasta clasa am realizat conexiunea dintre client si server
//Autor2: Stefan Andrei
//Functionalitate: In aceasta clasa am creat form-ul unde introducem datele de logare si ip-ul serverului la care ne conectam.
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
    public partial class Login : Form
    {
        private Users _Users;
        Client client = new Client();
     
        public Login()
        { 
            InitializeComponent();  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            
            string userName = textBox_UserName.Text;
            string password = textBox_Password.Text;
            string serverIP = textBox_serverIP.Text;
            
            client.Start(serverIP);

            _Users = new Users(client);

            bool loginStatus = _Users.Login(userName, password);
            if( loginStatus == true)
            {
                this.Hide();
                int accessLevel = _Users.GetAccessLevel(userName, password);
                int id = _Users.GetId(userName, password);
                User currentUser = new User(id, userName, Crypto.HashString(password), accessLevel);
                TasksPage tasksForm = new TasksPage(currentUser, client);
                tasksForm.ShowDialog();
                this.Close();
                 
            }
            else
            {
                MessageBox.Show("Login failed.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_UserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
