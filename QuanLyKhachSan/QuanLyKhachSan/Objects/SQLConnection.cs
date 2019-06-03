using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Objects
{
    class SQLConnection
    {
        private static SQLConnection instance;
        public static SQLConnection Instance
        {
            get { if (instance == null) instance = new SQLConnection(); return instance; }
            set { instance = value; }
        }

        public SQLConnection() { }

        public static string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";

        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connect.Close();
            }

            return data;
        }

        public int ExcuseNonQuery(string query)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }
    }
}
