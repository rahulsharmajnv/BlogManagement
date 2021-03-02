using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Services
{
    public class DataReader
    {
        static string connectionString;
        static DataReader()
        {
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BlogDB;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
        public static DataTable ExecuteReader(string query)
        {
            DataTable dataTable = null;

            if (!string.IsNullOrWhiteSpace(query))
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (var command = new SqlCommand(query, connection))
                    {
                        SqlDataReader dataReader = command.ExecuteReader();
                        dataTable = new DataTable();
                        dataTable.Load(dataReader);
                    }
                }
            }
            return dataTable;
        }


        public static void ExecuteNonQuery(string query)
        {
            if (!string.IsNullOrWhiteSpace(query))
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
