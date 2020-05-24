using System;
using System.Diagnostics;
using managementTask;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace UnitTest_managementTask
{
    /// <summary>
    /// Autor:Iovu Vali Cristian
    /// Functionalitate: Adaugare test case uri pt verificarea functionalitatii de Login
    /// Add testcases for UniTesting in  UnitTestProjectManagementTask_Login by VaIo
    /// </summary>

    [TestClass]
    public class UnitTestProjectManagementTask_Login
    {
        
        private static Users _Users;
        static Client client = new Client();
     
        [ClassInitialize]  //run just once for all the tests in that class. 
        public static void Init(TestContext  context)
        {
            Console.WriteLine("Test_Step_1: Conectare drept client");
            client.Start("127.0.0.1");
            _Users = new Users(client);
           
        }
       
        [TestMethod]
        public void Test_Nr_1_Login()
        {
            //---------------------------------------------------------------------------------//
            //Verificare daca un user se poate conecta cu un username valid si parola valida
            //Type-Positive Test Case
            //---------------------------------------------------------------------------------//
   
            Console.WriteLine("Test_Step_2: Foloseste  un user existent.");
            string userName = "Vali";
            string password = "Vali";

            Console.WriteLine("Test_Step_3: Verifica daca userul exista in baza de date.");
           
            bool loginStatus = _Users.Login(userName, password);
            Assert.AreEqual(true, loginStatus);
            client.CloseConnection();
        
        }
        [TestMethod]
        public void Test_Nr_2_Login()
        {
            //---------------------------------------------------------------------------------//
            //Verificare daca un user se poate conecta cu un username valid si parola invalida
            //Type-Negative Test Case
            //---------------------------------------------------------------------------------//
          
            Console.WriteLine("Test_Step_2: Foloseste  un user existent cu parola invalida.");
            string userName = "Vali";
            string password = "Invalid";

            Console.WriteLine("Test_Step_3: Verifica daca userul exista in baza de date.");
            
            bool loginStatus = _Users.Login(userName, password);
            Assert.AreEqual(false, loginStatus);
           
            client.CloseConnection();
        }

        [TestMethod]
        public void Test_Nr_3_Login()
        {
            //---------------------------------------------------------------------------------//
            //Verificare daca un user se poate conecta cu un username blank si parola blank
            //Type-Negative Test Case
            //---------------------------------------------------------------------------------//
          
             Console.WriteLine("Test_Step_2: Blank fields .");
             string userName = "";
            string password = "";

            Console.WriteLine("Test_Step_3: Verifica daca userul se poate conecta.");
           
            bool loginStatus = _Users.Login(userName, password);
            Assert.AreEqual(false, loginStatus);

            client.CloseConnection();
     
        }

        [TestMethod]
        public void Test_Nr_4_GetAccessLevel()
        {
            //---------------------------------------------------------------------------------//
            //Verificare daca un user este identificat corect drept admin
            //Type-Positive Test Case
            //---------------------------------------------------------------------------------//

            Console.WriteLine("Test_Step_2: ompletam field urile cu datele unui admin .");
            string userName = "Diana";
            string password = "Diana";

            Console.WriteLine("Test_Step_3: Verifica daca userul este admin.");
            
            int adminStatus = _Users.GetAccessLevel(userName, password);
            Assert.AreEqual(0, adminStatus);

            client.CloseConnection();

        }

        [TestMethod]
        public void Test_Nr_5_GetAccessLevel()
        {
            //---------------------------------------------------------------------------------//
            //Verificare daca un user  este identificat corect 
            //Type-Positive Test Case
            //---------------------------------------------------------------------------------//

            Console.WriteLine("Test_Step_2: Completam field urile cu datele unui user normal .");
            string userName = "Frodo";
            string password = "Frodo";

            Console.WriteLine("Test_Step_3: Verifica daca userul este este unul normal.");

            int userStatus = _Users.GetAccessLevel(userName, password);
            Assert.AreEqual(1, userStatus);

            client.CloseConnection();

        }

        [TestMethod]
        public void Test_Nr_6_GetId()
        {
            //---------------------------------------------------------------------------------//
            //Verificare daca unui User ii este identificat corect ID ul
            //Type-Positive Test Case
            //---------------------------------------------------------------------------------//

            Console.WriteLine("Test_Step_2: Completam field urile cu datele unui user normal .");
            string userName = "Andrei";
            string password = "Andrei";

            Console.WriteLine("Test_Step_3: Verifica id ul userului.");

            int userStatus = _Users.GetId(userName, password);
            Assert.AreEqual(3, userStatus);

            client.CloseConnection();

        }
    }
    
}
