using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Configuration;

namespace Clinic_Management_Project.Data_DB
{
    public static class DbConnectionFactory
    {
        public static MySqlConnection GetOpenConnection()
        {
            // build configuration to read appsettings.json
            var config = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json")
              .Build();

            var cs = config.GetConnectionString("ClinicDb");
            var conn = new MySqlConnection(cs);
            conn.Open();
            return conn;
        }
    }
}
