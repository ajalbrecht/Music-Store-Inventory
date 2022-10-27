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
            myConnection.Open();
            OleDbCommand myCommand = new OleDbCommand("SELECT " + column + " FROM " + table + " WHERE " + column, myConnection);// + " = " + searchTerm, myConnection);

            try
            {
                myCommand.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                myConnection.Close();
                throw exc;
            }

            myConnection.Close();
        }

        public void add(string table, string in1, string in2 = "", string in3 = "", string in4 = "", string in5 = "", string in6 = "")
        {
            myConnection.Open();

            OleDbCommand myCommand;
            if (table == "Instrument")
                myCommand = new OleDbCommand("Insert into Instrument ([ID],[Customer_Name],[Address],[Payment_Info]) " +
                    "values('"
                    + in1 + "','"
                    + in2 + "','"
                    + in3 + "','"
                    + in4 + "')", myConnection);
            else if (table == "Customer")
                myCommand = new OleDbCommand("Insert into Customer ([ID],[Price],[Instrument_Name],[Make],[Size],[Quality]) " +
                    "values('"
                    + in1 + "','"
                    + in2 + "','"
                    + in3 + "','"
                    + in4 + "','"
                    + in5 + "','"
                    + in6 + "')", myConnection);
            else
                throw new Exception("Table '" + table + "' not Found");            

            try
            {
                myCommand.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                myConnection.Close();
                throw exc;
            }

            myConnection.Close();
        }

        public void update(string name, string address, string payment)
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
            catch (Exception exc)
            {
                myConnection.Close();
                throw exc;
            }

                myConnection.Close();
        }

        public void delete(string table, string ID)
        {
            myConnection.Open();
            OleDbCommand myCommand = new OleDbCommand("Delete from " + table + " where ID = " + ID, myConnection);

            try
            {
                myCommand.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                myConnection.Close();
                throw exc;
            }

            myConnection.Close();
        }
    }
}
