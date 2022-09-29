using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace MusicStoreInventory
{
    class SQL_Helper
    {
        private OleDbConnection myConnection;

        // Default Constructor
        public SQL_Helper()
        {

        }

        // Constructor
        public SQL_Helper(string connectionString)
        {
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
            if (myConnection.State != System.Data.ConnectionState.Open)
                throw new Exception("Error: Connection Failed");
        }

        // Deconstructor
        ~SQL_Helper()
        {
            myConnection.Close();
        }

        public void Search(string table, string column, string searchTerm)
        {
            string commandString = "SELECT " + column + ";\n FROM " + table + ";\n WHERE " + searchTerm +';';
            OleDbCommand myCommand = new OleDbCommand(commandString);
        }
    }
}
