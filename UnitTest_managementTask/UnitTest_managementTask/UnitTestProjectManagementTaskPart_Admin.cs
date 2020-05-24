using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using managementTask;

namespace UnitTest_managementTask
{
    /// <summary>
    /// Summary description for UnitTestProjectManagementTaskPart_Admin
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
        public void Test_Nr_1_Aplicatie()
        {
            //---------------------------------------------------------------------------------//
            //Verificare daca board ul se updateaza daca se introduce un nou user
            //Type-Positive Test Case
            //---------------------------------------------------------------------------------//


            Console.WriteLine("Test_Step_2: Creare User Nou");
            User Test_user = new User(100, "Nahas Arum", "Nahas", 1);


            Console.WriteLine("Test_Step_3: Inserare in baza de date ");
            packet._data = "InsertRowIntoTable|UserDB,User," + Test_user.ID + "," + Test_user.Name + "," + Test_user.PassHash + "," + Test_user.AccessLevel;
            UpdateData(packet);

            Users Test_users = new Users(client);
            for (int i = 0; i < Users.MyUsers.Count; ++i)
            {
                if (Users.MyUsers[i].ID == 100)
                {
                    //Tasks.MyTasks[i] = Test_task;
                    Assert.AreEqual("Nahas Arum", Users.MyUsers[i].Name);
                }
            }

        }


        /*
       [TestMethod]
       public void Test_Nr_1_Aplicatie()
       {
           //---------------------------------------------------------------------------------//
           //Verificare daca un user poate updata task urile de pe board
           //Type-Positive Test Case
           //---------------------------------------------------------------------------------//
           //  SqlConnection connection = null;
           //   DataController ciosys = new DataController;

           client.Start("127.0.0.1");
           _Users = new Users(client);
            Task Test_task = new Task(88822,2,"Bug","DONE","diana faceah","6",4,3,"-");


           packet._data = "InsertRowIntoTable|TaskDB,Task," + Test_task.Task_ID + "," + Test_task.User_ID + "," + Test_task.Tip + "," + Test_task.Status + "," + Test_task.Continut + "," + Test_task.Nota + "," + Test_task.TimpEstimat + "," + Test_task.LogTime + "," + Test_task.Comment;
           UpdateData(packet);
           /*
           packet._data = "UpdateTable|TaskDB,Task,Tip," + "Bug" + "," + 3;
           UpdateData(packet);

           packet._data = "UpdateTable|TaskDB,Task,Status," + "TO DO" + "," + 3;
           UpdateData(packet);

           packet._data = "UpdateTable|TaskDB,Task,Continut," + "Asta e un test" + "," + 3;
           UpdateData(packet);

           packet._data = "UpdateTable|TaskDB,Task,Nota," + "2IZI" + "," + 3;
           UpdateData(packet);

           packet._data = "UpdateTable|TaskDB,Task,TimpEstimat," + 0 + "," + 3;
           UpdateData(packet);

           packet._data = "UpdateTable|TaskDB,Task,LogTime," + 5 + "," + 3;
           UpdateData(packet);

           packet._data = "UpdateTable|TaskDB,Task,Comment," + "Am rulat un test" + "," + 3;
           UpdateData(packet);
           */
        //tasksForm.GetNewTasks();

        /*
        packet._data = "Delete|TaskDB,Task," + 2;
        UpdateData(packet);
        Tasks Test_tasks= new Tasks(client);
        for (int i=0; i<Tasks.MyTasks.Count;++i)
          {
            if(Tasks.MyTasks[i].Task_ID==888)
            {
                //Tasks.MyTasks[i] = Test_task;
                Assert.AreEqual(1, 1);
            }
           }
        //sert.Equals(1, 1);


        //Tasks Test_tasks = new Tasks(client);

    }
*/
        private void UpdateData(Packet packet)
        {
            client.WriteObject(packet);
            response = client.ReadObject();
        }
    }

}
