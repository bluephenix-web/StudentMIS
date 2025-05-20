using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StudentMIS
{
    internal class User
    {
        DBconnection connect = new DBconnection();

        public bool login(string username, string password, string role) {
            // USERNAME AND PASSWORD AND ROLE
            string sql = "SELECT * FROM tbl_user WHERE username='"+username+"' AND password='"+password+"' AND role='"+ role +"' ";

            //query,connection
            MySqlCommand select = new MySqlCommand(sql,connect.getConnection);
            connect.openConnection();
            MySqlDataReader reader = select.ExecuteReader();

            if (reader.HasRows)
            {
                connect.closeConnection();
                return true;
            }
            else
            {
                connect.closeConnection();
                return false;
            }
        }
        public bool createUser(string username, string password) {
            string sql = "INSERT INTO tbl_user(username,password) VALUES (@uname,@upass)";
            MySqlCommand create = new MySqlCommand(sql,connect.getConnection);

            create.Parameters.Add("@uname",MySqlDbType.VarChar).Value = username;
            create.Parameters.Add("@upass", MySqlDbType.VarChar).Value = password;

            connect.openConnection();

            if (create.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else {
                return false;
            }
        }


    }
}
