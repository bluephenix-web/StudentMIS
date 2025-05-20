using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StudentMIS
{
    internal class DBconnection
    {
        //datasource;port;username;password;database;
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=db_studentmis;");
        
        public MySqlConnection getConnection
        {
            get { return conn; }
        }

        public void openConnection()
        {
            conn.Open();
        }
        public void closeConnection()
        {
            conn.Close();
        }

    }
}
