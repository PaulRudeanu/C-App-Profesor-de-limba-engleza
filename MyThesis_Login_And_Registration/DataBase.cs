using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MyThesis_Login_And_Registration
{

    class DataBase
    {

        private MySqlConnection connection = new MySqlConnection("server = localhost;port=3306;username=root;password=;database=users_database");

        //deschiderea conexiunii

        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        //inchiderea conexiunii

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        //returnarea conexiunii

        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
