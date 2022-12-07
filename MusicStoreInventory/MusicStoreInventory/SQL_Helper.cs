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
        private char[] illegalChars = { ',', '\'', ';' };


        
        
        // Default Constructor
        public SQL_Helper()
        {

        }

        // Constructor
        public SQL_Helper(string connectionString)
        {
            myConnection = new OleDbConnection(connectionString);
        }



        // Private Methods
        private string getNewPK(string table)
        {
            OleDbCommand myCommand = new OleDbCommand("SELECT MAX(ID) FROM " + table, myConnection);
            try
            {
                int newPK = (int)myCommand.ExecuteScalar() + 1;
                return newPK.ToString();
            }
            catch (Exception)
            {
                return "1";
            }
        }

        private string check(string input)
        {
            HashSet<char> characters = new HashSet<char>(); ;
            foreach (char c in input)
                characters.Add(c);

            foreach (char illegal in illegalChars)
                if (characters.Contains(illegal))
                    throw new Exception("Invalid Character ( " + illegal + " ) Was Used");
            return input;
        }

        private string isInt(string input)
        {
            int num;
            if (!int.TryParse(input, out num))
                throw new Exception("Invalid Input, '" + input + "' is Not an Integer");
            return input;
        }
        
        private string isPrice(string input)
        {
            float num;
            if (input.Length != 0 && input[0] == '$')
                input = input.Substring(1, input.Length - 1);
            if (!float.TryParse(input, out num))
                throw new Exception("Invalid Input, '" + input + "' is Not an Float");
            input = num.ToString("C");
            return input;
        }



        // Public Methods
        public System.Data.DataTable search(string table, string column, string searchTerm)
        {
            System.Data.DataTable dataTable = new System.Data.DataTable();
            System.Data.OleDb.OleDbDataAdapter dataAdapter = new System.Data.OleDb.OleDbDataAdapter
                ("SELECT * FROM " + check(table) + " WHERE [" + check(column) + "]= '" + check(searchTerm) + "'", myConnection);

            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        public void add(string table, string in1, string in2 = "", string in3 = "", string in4 = "", string in5 = "")
        {
            myConnection.Open();

            try
            {
                OleDbCommand myCommand;
                if (table == "Instruments")
                    myCommand = new OleDbCommand("INSERT INTO Instruments ([ID],[Instrument_Name],[Make],[Size],[Price],[Quality]) " +
                        "VALUES('"
                        + getNewPK(table) + "','"
                        + check(in1) +    "','"
                        + check(in2) +      "','"
                        + check(in3) +      "','"
                        + isPrice(in4) +      "','"
                        + check(in5) +      "')", myConnection);
                else if (table == "Customers")
                    myCommand = new OleDbCommand("INSERT INTO Customers ([ID],[Customer_Name],[Address],[City],[State],[Zip_Code]) " +
                    "VALUES('"
                        + getNewPK(table) + "','"
                        + check(in1) +      "','"
                        + check(in2) +      "','"
                        + check(in3) +      "','"
                        + check(in4) +      "','"
                        + isInt(in5) +      "')", myConnection);
                else if (table == "Transactions")
                    myCommand = new OleDbCommand("INSERT INTO Transactions ([ID],[Customer],[Instrument],[Sale_Price],[Listed_Price],[Payment_Type]) " +
                        "VALUES('"
                        + getNewPK(table) + "','"
                        + check(in1) +      "','"
                        + check(in2) +      "','"
                        + isPrice(in3) +    "','"
                        + isPrice(in4) +    "','"
                        + check(in5) +      "')", myConnection);
                else
                    throw new Exception("Table '" + table + "' Not Found");            

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

            try
            {
                OleDbCommand myCommand;
                if (table == "Instruments")
                    myCommand = new OleDbCommand("UPDATE Instruments SET "
                        + "Instrument_Name='" + check(in1)
                        + "', Make='" +         check(in2)
                        + "', [Size]='" +       check(in3)
                        + "', Price='" +        isPrice(in4)
                        + "', Quality='" +      check(in5)
                        + "' WHERE ID= " +      isInt(ID), myConnection);
                else if (table == "Customers")
                    myCommand = new OleDbCommand("UPDATE Customers SET "
                        + "Customer_Name='" +   check(in1)
                        + "', Address='" +      check(in2)
                        + "', City='" +         check(in3)
                        + "', State='" +        check(in4)
                        + "', Zip_Code='" +     isInt(in5)
                        + "' WHERE ID= " +      isInt(ID), myConnection);
                else if (table == "Transactions")
                    myCommand = new OleDbCommand("UPDATE Transactions SET "
                        + "Customer='" +        check(in1)
                        + "', Instrument='" +   check(in2)
                        + "', Sale_Price='" +   isPrice(in3)
                        + "', Listed_Price='" + isPrice(in4)
                        + "', Payment_Type='" + check(in5)
                        + "' WHERE ID= " +      isInt(ID), myConnection);
                else
                    throw new Exception("Table '" + table + "' not Found");

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
            OleDbCommand myCommand = new OleDbCommand("DELETE FROM " + check(table) + " WHERE ID= " + isInt(ID), myConnection);

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
