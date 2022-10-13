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
        }

        // Deconstructor
        ~SQL_Helper()
        {
            // Fix later
            //myConnection.Close();
        }

        public string show()
        {
            return myConnection.Database.GetType().ToString();
        }

        public void search(string table, string column, string searchTerm)
        {
            //myConnection.Open();
            //if (myConnection.State != System.Data.ConnectionState.Open)
            //    throw new Exception("Error: Connection Failed");
            string commandString = "SELECT " + column + ";\n FROM " + table + ";\n WHERE " + searchTerm +';';
            OleDbCommand myCommand = new OleDbCommand(commandString);
        }

        // return integer based on end state
        // returning 0 is means success
        // returning 1 is a connection error
        // returning 2 is an issue with the query (duplicate primary key most likely)
        public int add(string ID, string name, string address, string payment)
        {
            myConnection.Open();
            if (myConnection.State != System.Data.ConnectionState.Open)
            {
                myConnection.Close();
                return 1;
            }
            OleDbCommand myCommand = new OleDbCommand("Insert into Customer ([ID],[Customer_Name],[Address],[Payment_Info]) " +
                    "values('" 
                    + ID + "','"
                    + name + "','" 
                    + address + "','" 
                    + payment + "')", myConnection);

            myCommand.ExecuteNonQuery();
            try
            {

            }
            catch (Exception e)
            {
                myConnection.Close();
                return 2;
            }

            myConnection.Close();
            return 0;
        }
    }
}
