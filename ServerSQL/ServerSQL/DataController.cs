using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Configuration;
using ServerSQL;

namespace managementTask
{    
    class DataController
    {
        SqlConnection connection = null;

        public DataController()
        {
            //ma conectez la serverul SQL
            this.connection = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
            try
            {
                connection.Open();
            }
            catch (SqlException e)
            {
                ShellMenu.ShowError(e.ToString());
            }
        }

        public void CreateDatabase(string nameDatabase)
        {
            //sterg baza de date in caz de exista si o creez la loc
            String sql = "DROP DATABASE  IF EXISTS [" + nameDatabase + "]; CREATE DATABASE [" + nameDatabase + "]";
            using (SqlCommand command = new SqlCommand(sql, connection))
                command.ExecuteNonQuery();
        }

        public void CreateTable(string nameDatabase, string nameTable, string type)
        {
            //creez tabela task in baza de date TasksDB
            //Tip -> identific astfel obiectul ca sa stim sa il asignam factory-ului
            //(IdTask,IdUser)->PK
            switch (type)
            {
                case "task":
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("USE " + nameDatabase + "; CREATE TABLE ['" + nameTable + "']("
                                        + "[IdTask]      [int]  NOT NULL ,"
                                        + "[IdUser]      [int]  NOT NULL,"
                                        + "[Tip]         [nvarchar](max) NOT NULL,"
                                        + "[Status]      [nvarchar](max) NOT NULL,"
                                        + "[Continut]    [nvarchar](max) NOT NULL,"
                                        + "[Nota]        [int]  NOT NULL,"
                                        + "[TimpEstimat] [int]  NOT NULL,"
                                        + "[CalePoza]    [nvarchar](max) NOT NULL CONSTRAINT CompKey_ID_NAME PRIMARY KEY (IdTask, IdUser));"
                                         , connection))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException e)
                    {
                        Console.Error.Write(e.ToString());
                    }
                    break;
                case "user":
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("USE " + nameDatabase + "; CREATE TABLE ['" + nameTable + "']("
                                            + "[IdUser]      [int]  NOT NULL PRIMARY KEY,"
                                            + "[Username]         [nvarchar](max) NOT NULL,"
                                            + "[Password]      [nvarchar](max) NOT NULL,"
                                            + "[Rights]        [int]  NOT NULL);"
                                             , connection))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException e)
                    {
                        Console.Error.Write(e.ToString());
                    }
                    break;
                default:
                    Console.Error.Write("Eroare la crearea tabelei!");
                    break;
            }
        }



        public void InsertRowIntoTable(string nameDatabase, string nameTable, string[] values, string type)
        {

            try
            {
                switch (type)
                {
                    case "task":
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO [" + nameDatabase + "].[dbo].['" + nameTable + "'] (IdTask,IdUser,Tip,Status,Continut,Nota,TimpEstimat,CalePoza) " + "VALUES (" + values[0] + "," + values[1] + ",'" + values[2] + "','" + values[3] + "','" + values[4] + "'," + values[5] + "," + values[6] + ",'" + values[7] + "')", connection))
                        {
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "user":
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO [" + nameDatabase + "].[dbo].['" + nameTable + "'] (IdUser,Username, Password, Rights) " + "VALUES (" + values[0] + ",'" + values[1] + "','" + values[2] + "'," + values[3] + ")", connection))
                        {
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    default:
                        Console.Error.Write("Eroare la inserarea in tabela!");
                        break;


                }

            }
            catch (SqlException e)
            {
                Console.Error.Write(e.ToString());
            }

        }

        public void UpdateTable(string nameTable, string nameDatabase, string element, string newValue, string whereElem, string whereElemVal)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE [" + nameDatabase + "].[dbo].['" + nameTable + "'] SET " + element + "='" + newValue + "' WHERE " + whereElem + "='" + whereElemVal + "';", connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {
                Console.Error.Write(e.ToString()); 
            }
        }


        public List<string> GetRow(string nameTable, string nameDatabase, string IdUser, string type, string IdTask = "")
        {
            List<string> result = new List<string>();

            SqlDataReader rdr = null;

            switch (type)
            {
                case "task":
                    using (SqlCommand cmd = new SqlCommand("SELECT * from [" + nameDatabase + "].[dbo].['" + nameTable + "'] where IdUser='" + IdUser + "' and IdTask='" + IdTask + "';", connection))
                    {
                        try
                        {
                            rdr = cmd.ExecuteReader();
                            while (rdr.Read())
                            {
                                result.Add((string)rdr["Tip"]);
                                result.Add((string)rdr["Status"]);
                                result.Add((string)rdr["Continut"]);
                                result.Add(rdr["Nota"].ToString());
                                result.Add(rdr["TimpEstimat"].ToString());
                                result.Add((string)rdr["CalePoza"]);

                            }
                        }
                        catch (SqlException e)
                        {
                            Console.Error.Write(e.ToString());
                        }
                        finally
                        {
                            if (rdr != null)
                            {
                                rdr.Close();
                            }
                        }

                        return result;
                    }

                case "user":
                    using (SqlCommand cmd = new SqlCommand("SELECT * from [" + nameDatabase + "].[dbo].['" + nameTable + "'] where IdUser='" + IdUser + "';", connection))
                    {
                        try
                        {
                            rdr = cmd.ExecuteReader();
                            while (rdr.Read())
                            {
                                result.Add((string)rdr["Username"]);
                                result.Add((string)rdr["Password"]);
                                result.Add(rdr["Rights"].ToString());
                            }
                        }
                        catch (SqlException e)
                        {
                            Console.Error.Write(e.ToString());
                        }
                        finally
                        {
                            if (rdr != null)
                            {
                                rdr.Close();
                            }
                        }

                        return result;
                    }

                default:
                    Console.Error.Write("Eroare la extragerea datelor din tabela!!!");
                    return result;
            }

        }

        public List<List<string>> GetTable(string nameDatabase, string nameTable, string type)
        {

            SqlDataReader rdr = null;

            switch (type)
            {
                case "task":
                    using (SqlCommand cmd = new SqlCommand("SELECT * from [" + nameDatabase + "].[dbo].['" + nameTable + "'] ;", connection))
                    {
                        List<List<string>> result = new List<List<string>>();
                        try
                        {
                            rdr = cmd.ExecuteReader();
                            while (rdr.Read())
                            {
                                List<string> innerList = new List<string>();
                                innerList.Add(rdr["IdTask"].ToString());
                                innerList.Add(rdr["IdUser"].ToString());
                                innerList.Add((string)rdr["Tip"]);
                                innerList.Add((string)rdr["Status"]);
                                innerList.Add((string)rdr["Continut"]);
                                innerList.Add(rdr["Nota"].ToString());
                                innerList.Add(rdr["TimpEstimat"].ToString());
                                innerList.Add((string)rdr["CalePoza"]);
                                result.Add(innerList);

                            }
                        }
                        catch (SqlException e)
                        {
                            Console.Error.Write(e.ToString());
                        }
                        finally
                        {
                            if (rdr != null)
                            {
                                rdr.Close();
                            }
                        }

                        return result;
                    }

                case "user":
                    using (SqlCommand cmd = new SqlCommand("SELECT * from [" + nameDatabase + "].[dbo].['" + nameTable + "'];", connection))
                    {
                        List<List<string>> result = new List<List<string>>();
                        try
                        {
                            rdr = cmd.ExecuteReader();
                            while (rdr.Read())
                            {
                                List<string> innerList = new List<string>();
                                innerList.Add(rdr["IdUser"].ToString());
                                innerList.Add((string)rdr["Username"]);
                                innerList.Add((string)rdr["Password"]);
                                innerList.Add(rdr["Rights"].ToString());
                                result.Add(innerList);

                            }
                        }
                        catch (SqlException e)
                        {
                            Console.Error.Write(e.ToString());
                        }
                        finally
                        {
                            if (rdr != null)
                            {
                                rdr.Close();
                            }
                        }

                        return result;
                    }

                default:
                    Console.Error.Write("Eroare la extragerea datelor din tabela!!!");
                    return null;


            }
        }


    }
}
