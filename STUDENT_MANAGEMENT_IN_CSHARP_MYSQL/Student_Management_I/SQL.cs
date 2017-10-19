using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Student_Management_I
{
    class SQL
    {
        string host, user, database, password;
        MySqlConnection conn;
        public SQL(string host,string user,string password,string database)
        {
            this.host = host;
            this.user = user;
            this.database = database;
            this.password = password;
            conn = new MySqlConnection("SERVER = ;DATABASE =;UID=;PASSWORD=;");
        }
        public bool connect()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool dispose()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
