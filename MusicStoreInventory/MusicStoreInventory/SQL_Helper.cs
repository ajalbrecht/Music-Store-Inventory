using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MusicStoreInventory
{
    class SQL_Helper
    {
        private SqlConnection myConnect;

        // Default Constructor
        public SQL_Helper()
        {

        }

        // Constructor
        public SQL_Helper(string connectionString)
        {
            myConnect = new SqlConnection(connectionString);
            myConnect.Open();
            if (myConnect.State != System.Data.ConnectionState.Open)
                throw new Exception("Error: Connection Failed");
        }

        // Deconstructor
        ~SQL_Helper()
        {
            myConnect.Close();
        }

        public void Search(string table, string column)
        {
            string commandString = "SELECT " + column + " FROM " +table;
            SqlCommand myCommand = new SqlCommand(commandString);
        }
    }
}
