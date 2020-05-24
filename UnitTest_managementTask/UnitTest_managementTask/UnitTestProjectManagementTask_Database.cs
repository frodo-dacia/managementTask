using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using managementTask;

namespace UnitTest_managementTask
{
    /// <summary>
    /// Summary description for UnitTestProjectManagementTask_Database
    /// </summary>
    [TestClass]
    public class UnitTestProjectManagementTask_Database
    {
        private static Users _Users;
        static Client client = new Client();
        private Packet packet = new Packet();
        private Packet response = new Packet();

        /*
        [TestInitialize]
        public void TestInitialize()
        {
            Console.WriteLine("Test_Step_1: Conectare drept client");
            client.Start("127.0.0.1");
            _Users = new Users(client);
        }
        [TestCleanup]
        public void TestCleanup()
        {
            Console.WriteLine("Test_Step_Final: Inchidere Client ");
            client.CloseConnection();
        }
        */

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
            //Verificare daca board ul se updateaza daca se introduce un nou task in rubrica TO DO
            //Type-Positive Test Case
            //---------------------------------------------------------------------------------//


            Console.WriteLine("Test_Step_2: Creare Task");
            Task Test_task = new Task(88822, 2, "Task de Testare", "TO DO", "Acesta este primul test case", "6", 4, 3, "-");

            Console.WriteLine("Test_Step_3: Inserare in baza de date ");
            packet._data = "InsertRowIntoTable|TaskDB,Task," + Test_task.Task_ID + "," + Test_task.User_ID + "," + Test_task.Tip + "," + Test_task.Status + "," + Test_task.Continut + "," + Test_task.Nota + "," + Test_task.TimpEstimat + "," + Test_task.LogTime + "," + Test_task.Comment;
            UpdateData(packet);

            Tasks Test_tasks = new Tasks(client);
            for (int i = 0; i < Tasks.MyTasks.Count; ++i)
            {
                if (Tasks.MyTasks[i].Task_ID == 88822)
                {
                    //Tasks.MyTasks[i] = Test_task;
                    Assert.AreEqual("TO DO", Tasks.MyTasks[i].Status);
                }
            }

        }
        [TestMethod]
        public void Test_Nr_2_Aplicatie()
        {
            //---------------------------------------------------------------------------------//
            //Verificare daca board ul se updateaza daca se introduce un nou task in rubrica IN PROGRESS
            //Type-Positive Test Case
            //---------------------------------------------------------------------------------//
            Console.WriteLine("Test_Step_2: Creare Task");
            Task Test_task = new Task(77722, 2, "Task de Testare", "IN PROGRESS", "Acesta este al doilea test case", "6", 4, 3, "-");

            Console.WriteLine("Test_Step_3: Inserare in baza de date ");
            packet._data = "InsertRowIntoTable|TaskDB,Task," + Test_task.Task_ID + "," + Test_task.User_ID + "," + Test_task.Tip + "," + Test_task.Status + "," + Test_task.Continut + "," + Test_task.Nota + "," + Test_task.TimpEstimat + "," + Test_task.LogTime + "," + Test_task.Comment;
            UpdateData(packet);

            Tasks Test_tasks = new Tasks(client);
            for (int i = 0; i < Tasks.MyTasks.Count; ++i)
            {
                if (Tasks.MyTasks[i].Task_ID == 77722)
                {
                    //Tasks.MyTasks[i] = Test_task;
                    Assert.AreEqual("IN PROGRESS", Tasks.MyTasks[i].Status);
                }
            }
        }

        [TestMethod]
        public void Test_Nr_3_Aplicatie()
        {
            //---------------------------------------------------------------------------------//
            //Verificare daca board ul se updateaza daca se introduce un nou task in rubrica CODE REVIEW
            //Type-Positive Test Case
            //---------------------------------------------------------------------------------//
            Console.WriteLine("Test_Step_2: Creare Task");
            Task Test_task = new Task(66622, 2, "Task de Testare", "CODE REVIEW", "Acesta este al treilea test case", "6", 4, 3, "-");

            Console.WriteLine("Test_Step_3: Inserare in baza de date ");
            packet._data = "InsertRowIntoTable|TaskDB,Task," + Test_task.Task_ID + "," + Test_task.User_ID + "," + Test_task.Tip + "," + Test_task.Status + "," + Test_task.Continut + "," + Test_task.Nota + "," + Test_task.TimpEstimat + "," + Test_task.LogTime + "," + Test_task.Comment;
            UpdateData(packet);

            Tasks Test_tasks = new Tasks(client);
            for (int i = 0; i < Tasks.MyTasks.Count; ++i)
            {
                if (Tasks.MyTasks[i].Task_ID == 66622)
                {
                    //Tasks.MyTasks[i] = Test_task;
                    Assert.AreEqual("CODE REVIEW", Tasks.MyTasks[i].Status);
                }
            }
        }

        [TestMethod]
        public void Test_Nr_4_Aplicatie()
        {
            //---------------------------------------------------------------------------------//
            //Verificare daca board ul se updateaza daca se introduce un nou task in rubrica CODE REVIEW
            //Type-Positive Test Case
            //---------------------------------------------------------------------------------//
            Console.WriteLine("Test_Step_2: Creare Task");
            Task Test_task = new Task(55522, 2, "Task de Testare", "DONE", "Acesta este al patrulea test case", "6", 4, 3, "-");

            Console.WriteLine("Test_Step_3: Inserare in baza de date ");
            packet._data = "InsertRowIntoTable|TaskDB,Task," + Test_task.Task_ID + "," + Test_task.User_ID + "," + Test_task.Tip + "," + Test_task.Status + "," + Test_task.Continut + "," + Test_task.Nota + "," + Test_task.TimpEstimat + "," + Test_task.LogTime + "," + Test_task.Comment;
            UpdateData(packet);

            Tasks Test_tasks = new Tasks(client);
            for (int i = 0; i < Tasks.MyTasks.Count; ++i)
            {
                if (Tasks.MyTasks[i].Task_ID == 55522)
                {
                    //Tasks.MyTasks[i] = Test_task;
                    Assert.AreEqual("DONE", Tasks.MyTasks[i].Status);
                }
            }
        }

        [TestMethod]
        public void Test_Nr_5_Aplicatie()
        {
            //---------------------------------------------------------------------------------//
            //Verificare daca board ul se updateaza daca se  trece un  task din rubrica TO DO in  IN PROGRESS
            //Type-Positive Test Case
            //---------------------------------------------------------------------------------//
            Console.WriteLine("Test_Step_2: Creare Task");
            Task Test_task = new Task(44422, 2, "Task de Testare", "DONE", "Acesta este al 5lea test case", "6", 4, 3, "-");

            Console.WriteLine("Test_Step_3: Inserare in baza de date ");
            packet._data = "InsertRowIntoTable|TaskDB,Task," + Test_task.Task_ID + "," + Test_task.User_ID + "," + Test_task.Tip + "," + Test_task.Status + "," + Test_task.Continut + "," + Test_task.Nota + "," + Test_task.TimpEstimat + "," + Test_task.LogTime + "," + Test_task.Comment;
            UpdateData(packet);

            Console.WriteLine("Test_Step_4: Modificare Status ");
            packet._data = "UpdateTable|TaskDB,Task,Status," + "IN PROGRESS" + "," + Test_task.Task_ID;
            UpdateData(packet);

            Tasks Test_tasks = new Tasks(client);
            for (int i = 0; i < Tasks.MyTasks.Count; ++i)
            {
                if (Tasks.MyTasks[i].Task_ID == 44422)
                {
                    //Tasks.MyTasks[i] = Test_task;
                    Assert.AreEqual("IN PROGRESS", Tasks.MyTasks[i].Status);
                }
            }
        }

        [TestMethod]
        public void Test_Nr_6_Aplicatie()
        {
            //---------------------------------------------------------------------------------//
            //Verificare daca board ul se updateaza daca se  trece un  task din rubrica TO DO in  CODE REVIEW
            //Type-Positive Test Case
            //---------------------------------------------------------------------------------//
            Console.WriteLine("Test_Step_2: Creare Task");
            Task Test_task = new Task(33322, 2, "Task de Testare", "DONE", "Acesta este al 6lea test case", "6", 4, 3, "-");

            Console.WriteLine("Test_Step_3: Inserare in baza de date ");
            packet._data = "InsertRowIntoTable|TaskDB,Task," + Test_task.Task_ID + "," + Test_task.User_ID + "," + Test_task.Tip + "," + Test_task.Status + "," + Test_task.Continut + "," + Test_task.Nota + "," + Test_task.TimpEstimat + "," + Test_task.LogTime + "," + Test_task.Comment;
            UpdateData(packet);

            Console.WriteLine("Test_Step_4: Modificare Status ");
            packet._data = "UpdateTable|TaskDB,Task,Status," + "CODE REVIEW" + "," + Test_task.Task_ID;
            UpdateData(packet);

            Tasks Test_tasks = new Tasks(client);
            for (int i = 0; i < Tasks.MyTasks.Count; ++i)
            {
                if (Tasks.MyTasks[i].Task_ID == 33322)
                {
                    //Tasks.MyTasks[i] = Test_task;
                    Assert.AreEqual("CODE REVIEW", Tasks.MyTasks[i].Status);
                }
            }
        }

        [TestMethod]
        public void Test_Nr_7_Aplicatie()
        {
            //---------------------------------------------------------------------------------//
            //Verificare daca board ul se updateaza daca se  trece un  task din rubrica TO DO in DONE
            //Type-Positive Test Case
            //---------------------------------------------------------------------------------//
            Console.WriteLine("Test_Step_2: Creare Task");
            Task Test_task = new Task(22222, 2, "Task de Testare", "DONE", "Acesta este al 7lea test case", "6", 4, 3, "-");

            Console.WriteLine("Test_Step_3: Inserare in baza de date ");
            packet._data = "InsertRowIntoTable|TaskDB,Task," + Test_task.Task_ID + "," + Test_task.User_ID + "," + Test_task.Tip + "," + Test_task.Status + "," + Test_task.Continut + "," + Test_task.Nota + "," + Test_task.TimpEstimat + "," + Test_task.LogTime + "," + Test_task.Comment;
            UpdateData(packet);

            Console.WriteLine("Test_Step_4: Modificare Status ");
            packet._data = "UpdateTable|TaskDB,Task,Status," + "DONE" + "," + Test_task.Task_ID;
            UpdateData(packet);

            Tasks Test_tasks = new Tasks(client);
            for (int i = 0; i < Tasks.MyTasks.Count; ++i)
            {
                if (Tasks.MyTasks[i].Task_ID == 22222)
                {
                    //Tasks.MyTasks[i] = Test_task;
                    Assert.AreEqual("DONE", Tasks.MyTasks[i].Status);
                }
            }
        }

        [TestMethod]
        public void Test_Nr_8_Aplicatie()
        {
            //---------------------------------------------------------------------------------//
            //Verificare daca board ul se updateaza daca se  trece un  task din rubrica IN PROGRESS in DONE
            //Type-Positive Test Case
            //---------------------------------------------------------------------------------//
            Console.WriteLine("Test_Step_2: Creare Task");
            Task Test_task = new Task(99933, 3, "Task de Testare", "IN PROGRESS", "Acesta este al 8lea test case", "8", 4, 3, "-");

            Console.WriteLine("Test_Step_3: Inserare in baza de date ");
            packet._data = "InsertRowIntoTable|TaskDB,Task," + Test_task.Task_ID + "," + Test_task.User_ID + "," + Test_task.Tip + "," + Test_task.Status + "," + Test_task.Continut + "," + Test_task.Nota + "," + Test_task.TimpEstimat + "," + Test_task.LogTime + "," + Test_task.Comment;
            UpdateData(packet);

            Console.WriteLine("Test_Step_4: Modificare Status ");
            packet._data = "UpdateTable|TaskDB,Task,Status," + "DONE" + "," + Test_task.Task_ID;
            UpdateData(packet);

            Tasks Test_tasks = new Tasks(client);
            for (int i = 0; i < Tasks.MyTasks.Count; ++i)
            {
                if (Tasks.MyTasks[i].Task_ID == 99933)
                {
                    //Tasks.MyTasks[i] = Test_task;
                    Assert.AreEqual("DONE", Tasks.MyTasks[i].Status);
                }
            }
        }

        [TestMethod]
        public void Test_Nr_9_Aplicatie()
        {
            //---------------------------------------------------------------------------------//
            //Verificare daca board ul se updateaza daca se  trece un  task din rubrica CODE REVIEW in DONE
            //Type-Positive Test Case
            //---------------------------------------------------------------------------------//
            Console.WriteLine("Test_Step_2: Creare Task");
            Task Test_task = new Task(88833, 3, "Task de Testare", "CODE REVIEW", "Acesta este al 9lea test case", "8", 4, 3, "-");

            Console.WriteLine("Test_Step_3: Inserare in baza de date ");
            packet._data = "InsertRowIntoTable|TaskDB,Task," + Test_task.Task_ID + "," + Test_task.User_ID + "," + Test_task.Tip + "," + Test_task.Status + "," + Test_task.Continut + "," + Test_task.Nota + "," + Test_task.TimpEstimat + "," + Test_task.LogTime + "," + Test_task.Comment;
            UpdateData(packet);

            Console.WriteLine("Test_Step_4: Modificare Status ");
            packet._data = "UpdateTable|TaskDB,Task,Status," + "DONE" + "," + Test_task.Task_ID;
            UpdateData(packet);

            Tasks Test_tasks = new Tasks(client);
            for (int i = 0; i < Tasks.MyTasks.Count; ++i)
            {
                if (Tasks.MyTasks[i].Task_ID == 88833)
                {
                    //Tasks.MyTasks[i] = Test_task;
                    Assert.AreEqual("DONE", Tasks.MyTasks[i].Status);
                }
            }
        }

        [TestMethod]
        public void Test_Nr_10_Aplicatie()
        {
            //---------------------------------------------------------------------------------//
            //Verificare daca  un  task din rubrica TO DO se poate sterge
            //Type-Positive Test Case
            //---------------------------------------------------------------------------------//
            Console.WriteLine("Test_Step_2: Creare Task");
            Task Test_task = new Task(10022, 2, "Task de Testare Delete", "DONE", "Acesta este al 10lea test case", "6", 4, 3, "-");

            Console.WriteLine("Test_Step_3: Inserare in baza de date ");
            packet._data = "InsertRowIntoTable|TaskDB,Task," + Test_task.Task_ID + "," + Test_task.User_ID + "," + Test_task.Tip + "," + Test_task.Status + "," + Test_task.Continut + "," + Test_task.Nota + "," + Test_task.TimpEstimat + "," + Test_task.LogTime + "," + Test_task.Comment;
            UpdateData(packet);

            Console.WriteLine("Test_Step_4: Stergere Task din BOARD");
            packet._data = "Delete|TaskDB,Task," + Test_task.Task_ID;
            UpdateData(packet);

            Console.WriteLine("Test_Step_5: Verificare stergere task");
            Tasks Test_tasks = new Tasks(client);
            for (int i = 0; i < Tasks.MyTasks.Count; ++i)
            {
                if (Tasks.MyTasks[i].Task_ID == 10022)
                {
                    //Tasks.MyTasks[i] = Test_task;
                    Assert.Fail();
                }
            }
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void Test_Nr_11_Aplicatie()
        {
            //---------------------------------------------------------------------------------//
            //Verificare daca  un  task din rubrica IN PROGRESS se poate sterge
            //Type-Positive Test Case
            //---------------------------------------------------------------------------------//
            Console.WriteLine("Test_Step_2: Creare Task");
            Task Test_task = new Task(9922, 2, "Task de Testare Delete", "IN PROGRESS", "Acesta este al 11lea test case", "6", 4, 3, "-");

            Console.WriteLine("Test_Step_3: Inserare in baza de date ");
            packet._data = "InsertRowIntoTable|TaskDB,Task," + Test_task.Task_ID + "," + Test_task.User_ID + "," + Test_task.Tip + "," + Test_task.Status + "," + Test_task.Continut + "," + Test_task.Nota + "," + Test_task.TimpEstimat + "," + Test_task.LogTime + "," + Test_task.Comment;
            UpdateData(packet);

            Console.WriteLine("Test_Step_4: Stergere Task din BOARD");
            packet._data = "Delete|TaskDB,Task," + Test_task.Task_ID;
            UpdateData(packet);

            Console.WriteLine("Test_Step_5: Verificare stergere task");
            Tasks Test_tasks = new Tasks(client);
            for (int i = 0; i < Tasks.MyTasks.Count; ++i)
            {
                if (Tasks.MyTasks[i].Task_ID == 9922)
                {
                    {
                        //Tasks.MyTasks[i] = Test_task;
                        Assert.Fail();
                    }
                }
                Assert.AreEqual(1, 1);
            }
        }

        [TestMethod]
        public void Test_Nr_12_Aplicatie()
        {
            //---------------------------------------------------------------------------------//
            //Verificare daca  un  task din rubrica CODE REVIEW se poate sterge
            //Type-Positive Test Case
            //---------------------------------------------------------------------------------//
            Console.WriteLine("Test_Step_2: Creare Task");
            Task Test_task = new Task(9822, 2, "Task de Testare Delete", "CODE REVIEW", "Acesta este al 12lea test case", "4", 6, 3, "-");

            Console.WriteLine("Test_Step_3: Inserare in baza de date ");
            packet._data = "InsertRowIntoTable|TaskDB,Task," + Test_task.Task_ID + "," + Test_task.User_ID + "," + Test_task.Tip + "," + Test_task.Status + "," + Test_task.Continut + "," + Test_task.Nota + "," + Test_task.TimpEstimat + "," + Test_task.LogTime + "," + Test_task.Comment;
            UpdateData(packet);

            Console.WriteLine("Test_Step_4: Stergere Task din BOARD");
            packet._data = "Delete|TaskDB,Task," + Test_task.Task_ID;
            UpdateData(packet);

            Console.WriteLine("Test_Step_5: Verificare stergere task");
            Tasks Test_tasks = new Tasks(client);
            for (int i = 0; i < Tasks.MyTasks.Count; ++i)
            {
                if (Tasks.MyTasks[i].Task_ID == 9822)
                {
                    {
                        //Tasks.MyTasks[i] = Test_task;
                        Assert.Fail();
                    }
                }
                Assert.AreEqual(1, 1);
            }
        }

        [TestMethod]
        public void Test_Nr_13_Aplicatie()
        {
            //---------------------------------------------------------------------------------//
            //Verificare daca  un  task din rubrica DONE se poate sterge
            //Type-Positive Test Case
            //---------------------------------------------------------------------------------//
            Console.WriteLine("Test_Step_2: Creare Task");
            Task Test_task = new Task(9722, 2, "Task de Testare Delete", "DONE", "Acesta este al 13lea test case", "4", 6, 3, "-");

            Console.WriteLine("Test_Step_3: Inserare in baza de date ");
            packet._data = "InsertRowIntoTable|TaskDB,Task," + Test_task.Task_ID + "," + Test_task.User_ID + "," + Test_task.Tip + "," + Test_task.Status + "," + Test_task.Continut + "," + Test_task.Nota + "," + Test_task.TimpEstimat + "," + Test_task.LogTime + "," + Test_task.Comment;
            UpdateData(packet);

            Console.WriteLine("Test_Step_4: Stergere Task din BOARD");
            packet._data = "Delete|TaskDB,Task," + Test_task.Task_ID;
            UpdateData(packet);

            Console.WriteLine("Test_Step_5: Verificare stergere task");
            Tasks Test_tasks = new Tasks(client);
            for (int i = 0; i < Tasks.MyTasks.Count; ++i)
            {
                if (Tasks.MyTasks[i].Task_ID == 9722)
                {
                    {
                        //Tasks.MyTasks[i] = Test_task;
                        Assert.Fail();
                    }
                }
                Assert.AreEqual(1, 1);
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
