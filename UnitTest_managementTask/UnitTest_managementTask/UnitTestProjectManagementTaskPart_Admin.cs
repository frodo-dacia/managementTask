using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using managementTask;

namespace UnitTest_managementTask
{
    /// <summary>
    /// Autor:Iovu Vali Cristian
    /// Functionalitate: Adaugare test case uri pt verificarea functionalitatii adaugarii unui nou user
    /// Add testcases for UniTesting in  UnitTestProjectManagementTask_Admin by VaIo
    /// </summary>
    [TestClass]
    public class UnitTestProjectManagementTaskPart_Admin
    {
        private static Users _Users;
        static Client client = new Client();
        private Packet packet = new Packet();
        private Packet response = new Packet();

        

        [ClassInitialize]  //run just once for all the tests in that class. 
        public static void Init(TestContext context)
        {
            Console.WriteLine("Test_Step_1: Conectare drept client");
            client.Start("127.0.0.1");
            _Users = new Users(client);

        }
        [TestMethod]
        public void Test_Nr_1_Adaugare_User()
        {
            //---------------------------------------------------------------------------------//
            //Verificare daca board ul se updateaza daca se introduce un nou user
            //Type-Positive Test Case
            //---------------------------------------------------------------------------------//


            Console.WriteLine("Test_Step_2: Creare User Nou");
            User Test_user = new User(99, "Jessie", "Jessie", 1);


            Console.WriteLine("Test_Step_3: Inserare in baza de date ");
            packet._data = "InsertRowIntoTable|UserDB,User," + Test_user.ID + "," + Test_user.Name + "," + Test_user.PassHash + "," + Test_user.AccessLevel;
            UpdateData(packet);

            Users Test_users = new Users(client);
            for (int i = 0; i < Users.MyUsers.Count; ++i)
            {
                if (Users.MyUsers[i].ID == 99)
                {
                    //Tasks.MyTasks[i] = Test_task;
                    Assert.AreEqual("Jessie", Users.MyUsers[i].Name);
                }
            }

        }

        [TestMethod]
        public void Test_Nr_2_Adaugare_Task_User()
        {
            //---------------------------------------------------------------------------------//
            //Verificare daca board ul se updateaza daca se introduce un task in rubrica "TO DO" pt  user ul creat
            //Type-Positive Test Case
            //---------------------------------------------------------------------------------//


            Console.WriteLine("Test_Step_2: Creare Task");
            Task Test_task = new Task(11199, 99, "Task de Testare Jessie", "TO DO", "Acesta este un test case pt Jessie", "6", 4, 3, "-");

            Console.WriteLine("Test_Step_3: Inserare in baza de date ");
            packet._data = "InsertRowIntoTable|TaskDB,Task," + Test_task.Task_ID + "," + Test_task.User_ID + "," + Test_task.Tip + "," + Test_task.Status + "," + Test_task.Continut + "," + Test_task.Nota + "," + Test_task.TimpEstimat + "," + Test_task.LogTime + "," + Test_task.Comment;
            UpdateData(packet);

            Tasks Test_tasks = new Tasks(client);
            for (int i = 0; i < Tasks.MyTasks.Count; ++i)
            {
                if (Tasks.MyTasks[i].Task_ID == 11199)
                {
                    //Tasks.MyTasks[i] = Test_task;
                    Assert.AreEqual("TO DO", Tasks.MyTasks[i].Status);
                }
            }
        }
        [TestMethod]
        public void Test_Nr_3_Adaugare_Task_User()
        {
            //---------------------------------------------------------------------------------//
            //Verificare daca board ul se updateaza daca se introduce un task in rubrica "IN PROGRESS" pt  user ul creat
            //Type-Positive Test Case
            //---------------------------------------------------------------------------------//


            Console.WriteLine("Test_Step_2: Creare Task");
            Task Test_task = new Task(22299, 99, "Task de Testare Jessie", "IN PROGRESS", "Acesta este un test case  de IN PROGRESS pt Jessie", "6", 4, 3, "-");

            Console.WriteLine("Test_Step_3: Inserare in baza de date ");
            packet._data = "InsertRowIntoTable|TaskDB,Task," + Test_task.Task_ID + "," + Test_task.User_ID + "," + Test_task.Tip + "," + Test_task.Status + "," + Test_task.Continut + "," + Test_task.Nota + "," + Test_task.TimpEstimat + "," + Test_task.LogTime + "," + Test_task.Comment;
            UpdateData(packet);

            Tasks Test_tasks = new Tasks(client);
            for (int i = 0; i < Tasks.MyTasks.Count; ++i)
            {
                if (Tasks.MyTasks[i].Task_ID == 22299)
                {
                    //Tasks.MyTasks[i] = Test_task;
                    Assert.AreEqual("IN PROGRESS", Tasks.MyTasks[i].Status);
                }
            }

        }

        [TestMethod]
        public void Test_Nr_4_Adaugare_Task_User()
        {
            //---------------------------------------------------------------------------------//
            //Verificare daca board ul se updateaza daca se introduce un task in rubrica "CODE REVIEW" pt  user ul creat
            //Type-Positive Test Case
            //---------------------------------------------------------------------------------//


            Console.WriteLine("Test_Step_2: Creare Task");
            Task Test_task = new Task(33399, 99, "Task de Testare Jessie", "CODE REVIEW", "Acesta este un test case  de CODE REVIEW pt Jessie", "6", 4, 3, "-");

            Console.WriteLine("Test_Step_3: Inserare in baza de date ");
            packet._data = "InsertRowIntoTable|TaskDB,Task," + Test_task.Task_ID + "," + Test_task.User_ID + "," + Test_task.Tip + "," + Test_task.Status + "," + Test_task.Continut + "," + Test_task.Nota + "," + Test_task.TimpEstimat + "," + Test_task.LogTime + "," + Test_task.Comment;
            UpdateData(packet);

            Tasks Test_tasks = new Tasks(client);
            for (int i = 0; i < Tasks.MyTasks.Count; ++i)
            {
                if (Tasks.MyTasks[i].Task_ID == 33399)
                {
                    //Tasks.MyTasks[i] = Test_task;
                    Assert.AreEqual("CODE REVIEW", Tasks.MyTasks[i].Status);
                }
            }

        }

        [TestMethod]
        public void Test_Nr_5_Adaugare_Task_User()
        {
            //---------------------------------------------------------------------------------//
            //Verificare daca board ul se updateaza daca se introduce un task in rubrica "DONE" pt  user ul creat
            //Type-Positive Test Case
            //---------------------------------------------------------------------------------//


            Console.WriteLine("Test_Step_2: Creare Task");
            Task Test_task = new Task(44499, 99, "Task de Testare Jessie", "DONE", "Acesta este un test case  de DONE pt Jessie", "6", 4, 3, "-");

            Console.WriteLine("Test_Step_3: Inserare in baza de date ");
            packet._data = "InsertRowIntoTable|TaskDB,Task," + Test_task.Task_ID + "," + Test_task.User_ID + "," + Test_task.Tip + "," + Test_task.Status + "," + Test_task.Continut + "," + Test_task.Nota + "," + Test_task.TimpEstimat + "," + Test_task.LogTime + "," + Test_task.Comment;
            UpdateData(packet);

            Tasks Test_tasks = new Tasks(client);
            for (int i = 0; i < Tasks.MyTasks.Count; ++i)
            {
                if (Tasks.MyTasks[i].Task_ID == 44499)
                {
                    //Tasks.MyTasks[i] = Test_task;
                    Assert.AreEqual("DONE", Tasks.MyTasks[i].Status);
                }
            }

        }

        
        /*
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Test_Nr_2_Adaugare_User_Existent()
        {
            //---------------------------------------------------------------------------------//
            //Verificare daca board ul se updateaza daca se introduce un user existent
            //Type-Positive Test Case
            //---------------------------------------------------------------------------------//


            Console.WriteLine("Test_Step_2: Creare User Nou");
            User Test_user = new User(100, "Nahas Arum", "Nahas", 1);


            Console.WriteLine("Test_Step_3: Inserare in baza de date ");
            packet._data = "InsertRowIntoTable|UserDB,User," + Test_user.ID + "," + Test_user.Name + "," + Test_user.PassHash + "," + Test_user.AccessLevel;
            UpdateData(packet);
          

        }
        */

        private void UpdateData(Packet packet)
        {
            client.WriteObject(packet);
            response = client.ReadObject();
        }
    }

}
