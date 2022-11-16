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
        private int getPK(string table)
        {
            OleDbCommand myCommand = new OleDbCommand("SELECT MAX(ID) FROM " + table, myConnection);
            try
            {
                return (int)myCommand.ExecuteScalar();
            }
            catch (Exception)
            {
                return 1;
            }
        }

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

        public void add(string table, string in1, string in2 = "", string in3 = "", string in4 = "", string in5 = "")//, string in6 = "")
        {
            myConnection.Open();

            OleDbCommand myCommand;
            if (table == "Instruments")
                myCommand = new OleDbCommand("INSERT INTO Instruments ([ID],[Instrument_Name],[Make],[Size],[Price],[Quality]) " +
                    "VALUES('"
                    + (getPK(table) + 1).ToString() + "','"
                    + check(in1) + "','"
                    + check(in2) + "','"
                    + check(in3) + "','"
                    + check(in4) + "','"
                    + check(in5) + "')", myConnection);
            else if (table == "Customers")
                myCommand = new OleDbCommand("INSERT INTO Customers ([ID],[Customer_Name],[City],[State],[Address],[Zip_Code]) " +
                    "VALUES('"
                    + (getPK(table) + 1).ToString() + "','"
                    + check(in1) + "','"
                    + check(in2) + "','"
                    + check(in3) + "','"
                    + check(in4) + "','"
                    + check(in5) + "')", myConnection);
            else if (table == "Transactions")
                myCommand = new OleDbCommand("INSERT INTO Transactions ([ID],[Customer],[Instrument],[Sale_Price],[Listed_Price],[Payment_Type]) " +
                    "VALUES('"
                    + (getPK(table) + 1).ToString() + "','"
                    + check(in1) + "','"
                    + check(in2) + "','"
                    + check(in3) + "','"
                    + check(in4) + "','"
                    + check(in5) + "')", myConnection);
            else
                throw new Exception("Table '" + table + "' Not Found");            

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

        public void edit(string table, string ID, string in1, string in2 = "", string in3 = "", string in4 = "", string in5 = "")
        {
            myConnection.Open();

            OleDbCommand myCommand;
            if (table == "Instruments")
                myCommand = new OleDbCommand("UPDATE Instruments SET "
                    + "Instrument_Name='" + check(in1)
                    + "', Make='" + check(in2)
                    + "', Size='" + check(in3)
                    + "', Price='" + check(in4)
                    + "', Quality='" + check(in5)
                    + "' WHERE ID= " + ID, myConnection);
            else if (table == "Customers")
                myCommand = new OleDbCommand("UPDATE Customers SET "
                    + "Customer_Name='" + check(in1)
                    + "', City='" + check(in2)
                    + "', State='" + check(in3)
                    + "', Address='" + check(in4)
                    + "', Zip_Code='" + check(in5)
                    + "' WHERE ID= " + ID, myConnection);
            else if (table == "Transactions")
                myCommand = new OleDbCommand("UPDATE Transactions SET "
                    + "Customer='" + check(in1)
                    + "', Instrument='" + check(in2)
                    + "', Sale_Price='" + check(in3)
                    + "', Listed_Price='" + check(in4)
                    + "', Payment_Type='" + check(in5)
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
