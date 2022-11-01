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
        // Variables
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



        // Methods
        public void search(string table, string column, string searchTerm)
        {
            myConnection.Open();
            OleDbCommand myCommand = new OleDbCommand("SELECT " + column + " FROM " + table + " WHERE " + column, myConnection);// + " = " + searchTerm, myConnection);

            try
            {
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                myConnection.Close();
                throw ex;
            }

            myConnection.Close();
        }

        public void add(string table, string in1, string in2 = "", string in3 = "", string in4 = "", string in5 = "", string in6 = "")
        {
            myConnection.Open();

            OleDbCommand myCommand;
            if (table == "Instrument")
                myCommand = new OleDbCommand("INSERT INTO INSTRUMENT ([ID],[Price],[Instrument_Name],[Make],[Size],[Quality]) " +
                    "VALUES('"
                    + in1 + "','"
                    + in2 + "','"
                    + in3 + "','"
                    + in4 + "','"
                    + in5 + "','"
                    + in6 + "')", myConnection);
            else if (table == "Customer")
                myCommand = new OleDbCommand("INSERT INTO CUSTOMER ([ID],[Customer_Name],[Address],[Payment_Info]) " +
                    "VALUES('"
                    + in1 + "','"
                    + in2 + "','"
                    + in3 + "','"
                    + in4 + "')", myConnection);
            else
                throw new Exception("Table '" + table + "' not Found");            

            try
            {
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                myConnection.Close();
                throw ex;
            }

            myConnection.Close();
        }

        public void edit(string name, string address, string payment)
        {
            myConnection.Open();
            OleDbCommand myCommand = new OleDbCommand("UPDATE CUSTOMER SET " +
                "Customer_Name='" + name +
                "Address='" + address +
                "'Payment_Info='" + payment, myConnection);

            try
            {
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                myConnection.Close();
                throw ex;
            }

                myConnection.Close();
        }

        public void delete(string table, string ID)
        {
            myConnection.Open();
            OleDbCommand myCommand = new OleDbCommand("DELETE FROM " + table + " WHERE ID = " + ID, myConnection);

            try
            {
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                myConnection.Close();
                throw ex;
            }

            myConnection.Close();
        }
    }
}
