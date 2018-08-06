using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp4
{
    class DbConnect
    {
        public MySqlConnection connectFunc()
        {
            String connection = "server = localhost; user id = root; database = sad_db; password=root;";
            MySqlConnection con = new MySqlConnection(connection);
            return con;
        }
    }
}
