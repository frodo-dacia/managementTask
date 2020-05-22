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

        public void Delete(string nameDatabase, string nameTable, string[] values, string type)
        {
            try
            {
                switch (type)
                {
                    case "task":
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM [" + nameDatabase + "].[dbo].[" + nameTable + "] WHERE Tip='" + values[0] + "' and Status='" + values[1] + "' and Continut='" + values[2] + "' and Nota=" + values[3] + " and TimpEstimat=" + values[4] + ";", connection))
                        {
                            cmd.ExecuteNonQuery();
                        }


                        break;
                    case "user":
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM [" + nameDatabase + "].[dbo].[" + nameTable + "] " + "WHERE Username='" + values[1] + "' and Password='" + values[2] + "' ;", connection))
                        {
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    default:
                        Console.Error.Write("Eroare la stergerea din tabela!");
                        break;

                }

            }
            catch (SqlException e)
            {
                Console.Error.Write(e.ToString());
            }
        }
        public void InsertRowIntoTable(string nameDatabase, string nameTable, string[] values, string type)
        {
            try
            {
                switch (type)
                {
                    case "task":
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO [" + nameDatabase + "].[dbo].[" + nameTable + "] (IdTask,IdUser,Tip,Status,Continut,Nota,TimpEstimat,LogTime,Comment) " + "VALUES (" + values[0] + "," + values[1] + ",'" + values[2] + "','" + values[3] + "','" + values[4] + "','" + values[5] + "'," + values[6] + "," + values[7] + ",'" + values[8] + "')", connection))
                        {
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "user":
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO [" + nameDatabase + "].[dbo].[" + nameTable + "] (IdUser,Username, Password, Rights) " + "VALUES (" + values[0] + ",'" + values[1] + "','" + values[2] + "'," + values[3] + ")", connection))
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

        public void UpdateTable(string nameTable, string nameDatabase, string element, string newValue, string IdTask)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE [" + nameDatabase + "].[dbo].[" + nameTable + "] SET " + element + "='" + newValue + "' WHERE IdTask='" + IdTask + "';", connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {
                Console.Error.Write(e.Message);
            }
        }




        public List<List<string>> GetTable(string nameDatabase, string nameTable, string type)
        {

            SqlDataReader rdr = null;

            switch (type)
            {
                case "task":
                    using (SqlCommand cmd = new SqlCommand("SELECT * from [" + nameDatabase + "].[dbo].[" + nameTable + "] ;", connection))
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
                                innerList.Add(rdr["LogTime"].ToString());
                                innerList.Add(rdr["Comment"].ToString());

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
                    using (SqlCommand cmd = new SqlCommand("SELECT * from [" + nameDatabase + "].[dbo].[" + nameTable + "];", connection))
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
