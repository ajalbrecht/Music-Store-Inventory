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
        private string check(string input)
        {
            for (int i = 0; i < input.Length; ++i)
                if (input[i] == ',' && input[i] == '\'')
                    throw new Exception("Invalid Character (" + input[i] + ") Was Used");
            return input;
        }

        private string isInt(string input)
        {
            int num;
            if (int.TryParse(input, out num))
                throw new Exception("Invalid Input, '" + input + "' is Not an Integer");
            return input;
        }

        private string isFloat(string input)
        {
            float num;
            if (float.TryParse(input, out num))
                throw new Exception("Invalid Input, '" + input + "' is Not an Float");
            return input;
        }

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
                    + check(in1) + "','"
                    + check(in2) + "','"
                    + check(in3) + "','"
                    + check(in4) + "','"
                    + check(in5) + "','"
                    + check(in6) + "')", myConnection);
            else if (table == "Customer")
                myCommand = new OleDbCommand("INSERT INTO CUSTOMER ([ID],[Customer_Name],[Address],[Payment_Info]) " +
                    "VALUES('"
                    + check(in1) + "','"
                    + check(in2) + "','"
                    + check(in3) + "','"
                    + check(in4) + "')", myConnection);
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

        public void edit(string table, string ID, string in1, string in2 = "", string in3 = "", string in4 = "", string in5 = "", string in6 = "")
        {
            //myConnection.Open();
            //OleDbCommand myCommand = new OleDbCommand("UPDATE Customer SET "
            //    + "Customer_Name='" + name
            //    + "', Address='" + address
            //    + "', Payment_Info='" + payment
            //    + "' WHERE ID= " + ID, myConnection);
            ////OleDbCommand myCommand = new OleDbCommand("UPDATE CUSTOMER SET Customer_Name='" + "test" + "' WHERE ID= 11", myConnection);
            myConnection.Open();

            OleDbCommand myCommand;
            if (table == "Instrument")
                myCommand = new OleDbCommand("UPDATE Instrument SET "
                    + check(in1) + "','"
                    + check(in2) + "','"
                    + check(in3) + "','"
                    + check(in4) + "','"
                    + check(in5) + "','"
                    + check(in6) + "')", myConnection);
            else if (table == "Customer")
                myCommand = new OleDbCommand("UPDATE Customer SET "
                    + "Customer_Name='" + check(in1)
                    + "Customer_Name='" + check(in2)
                    + "', Address='" + check(in3)
                    + "', Payment_Info='" + check(in4)
                    + "' WHERE ID= " + ID, myConnection);
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

        public void delete(string table, string ID)
        {
            myConnection.Open();
            OleDbCommand myCommand = new OleDbCommand("DELETE FROM " + table + " WHERE ID= " + ID, myConnection);

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
