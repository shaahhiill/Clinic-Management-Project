using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClinicManagementSystem
{
    public static class DatabaseConnection
    {
        private static string connStr = "server=127.0.0.1;user=root;database=clinic_management;port=3306;password=;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connStr);
        }
    }
}
