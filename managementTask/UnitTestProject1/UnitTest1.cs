using System;
using System.Diagnostics;
using managementTask;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectManagementTask
{
    [TestClass]
    public class UnitTest1
    {
        //User Nume_de_test = new User(23,"Nume_De_test","unhash",1);
        private Users _Users;
       
        private TestContext testContextInstance;

        /// <summary>
        ///  Gets or sets the test context which provides
        ///  information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestMethod]
        public void Test_Nr_1_Login()
        {


        Users _Users;
        Client client = new Client();
        string userName = "Vali";
            string password = "Vali";
            string serverIP = "127.0.0.1";

            client.Start(serverIP);

            _Users = new Users(client);

            bool loginStatus = _Users.Login(userName, password);
            if (loginStatus == true)
            {
                Console.Write("plm");
                

            }
            else
            {
                Console.Write("plm");
            }


        }
        /* [TestMethod]
       /*  public void GetAcces()
         {
             client.Start("127.0.0.1
");
            
             Users babu = new Users(client);
             Assert.AreEqual(1, babu.GetAccessLevel("Vali", "xjDwrgj8FeaAAQxsd68XtJHdflQ="));
         }
         */
    }
}