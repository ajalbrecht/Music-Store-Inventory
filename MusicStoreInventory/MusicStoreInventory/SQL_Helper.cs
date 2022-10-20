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

        // returns error as string
        // No errors returns ""
        public string add(string ID, string name, string address, string payment)
        {
            myConnection.Open();
            // WIP
            if (myConnection.State != System.Data.ConnectionState.Open)
            {
                myConnection.Close();
                return "Connection Failed to Connect";
            }

            OleDbCommand myCommand = new OleDbCommand("Insert into Customer ([ID],[Customer_Name],[Address],[Payment_Info]) " +
                    "values('" 
                    + ID + "','"
                    + name + "','" 
                    + address + "','" 
                    + payment + "')", myConnection);

            try
            {
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                myConnection.Close();
                return e.Message;
            }

            myConnection.Close();
            return "";
        }

        public string update(string name, string address, string payment)
        {
            myConnection.Open();
            OleDbCommand myCommand = new OleDbCommand("Update Customer set " +
                "Customer_Name='" + name +
                "Address='" + address +
                "'Payment_Info='" + payment, myConnection);

            try
            {
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                myConnection.Close();
                return e.Message;
            }

            myConnection.Close();
            return "";
        }

        public void delete(string customerID)
        {
            myConnection.Open();
            OleDbCommand myCommand = new OleDbCommand("delete from Customer where ID = " + customerID, myConnection);

            try
            {
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                myConnection.Close();
                throw e;
            }

            myConnection.Close();
        }
    }
}
