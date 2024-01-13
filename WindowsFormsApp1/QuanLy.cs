using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class QuanLy
    {
        public static string connect = "server = MSI ; database = QLBH ;integrated security = true";
        public bool AuthenticateUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                string query = "SELECT COUNT(*) FROM Accout dn WHERE dn.username = @username AND dn.passwords = @password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
        // tìm kiếm kiểu tài khoản
        public int typeacc(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                string sql = "SELECT dn.typee FROM Accout dn WHERE dn.username = @username AND dn.passwords = @password";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                int type = (int)command.ExecuteScalar();
                return type;
            }
        }

    }
}
