using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace MusicStoreInventory
{
    class Sandbox
    {
        public Sandbox(string connectionString)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // The insertSQL string contains a SQL statement that
                // inserts a new row in the source table.
                //OleDbCommand command = new OleDbCommand(insertSQL);

                // Set the Connection to the new OleDbConnection.
                //command.Connection = connection;

                // Open the connection and execute the insert command.
                try
                {
                    connection.Open();
                    //command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                // The connection is automatically closed when the
                // code exits the using block.
            }
        }
    }
}
