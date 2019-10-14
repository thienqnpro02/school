using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class DataProvider
    {
        
        private static DataProvider instance = null;
        public static DataProvider Instance
        {
            get
            {
                if (DataProvider.instance == null)
                {
                    DataProvider.instance = new DataProvider();
                }
                return DataProvider.instance;
            }
        }

        private string STRconnection = "Data Source=.;Initial Catalog=QLBH;Integrated Security=True";

        private DataProvider() { }

        public DataTable ExecuteQuery(string query, object[] parameters = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(this.STRconnection))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                
                if (parameters != null)
                {
                    char[] CharToTrim = { ',' };

                    string[] temp = query.Split(' ');
                    int i = 0;

                    foreach (string str in temp)
                    {
                        if (str.Contains('@'))
                        {
                            command.Parameters.Add(new SqlParameter
                            {
                                ParameterName = str.Trim(CharToTrim),
                                Value = parameters[i++],
                            });
                        }
                    }
                }


                adapter.Fill(data);

                command.Connection.Close();
            }

            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameters = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(this.STRconnection))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Connection.Open();
                
                
                if (parameters != null)
                {
                    char[] CharToTrim = { ',' };

                    string[] temp = query.Split(' ');
                    int i = 0;

                    foreach (string str in temp)
                    {
                        if (str.Contains('@'))
                        {
                            command.Parameters.Add(new SqlParameter
                            {
                                ParameterName = str.Trim(CharToTrim),
                                Value = parameters[i++],
                            });
                        }
                    }
                }


                data = command.ExecuteNonQuery();

                command.Connection.Close();
            }

            return data;
        }

        public object ExecuteScalar(string query, object[] parameters = null)
        {
            object data;

            using (SqlConnection connection = new SqlConnection(this.STRconnection))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Connection.Open();

                if (parameters != null)
                {
                    char[] CharToTrim = { ',' };

                    string[] temp = query.Split(' ');
                    int i = 0;

                    foreach (string str in temp)
                    {
                        if (str.Contains('@'))
                        {
                            command.Parameters.Add(new SqlParameter
                            {
                                ParameterName = str.Trim(CharToTrim),
                                Value = parameters[i++],
                            });
                        }
                    }
                }


                data = command.ExecuteScalar();

                command.Connection.Close();
            }

            return data;
        }
    }
}

