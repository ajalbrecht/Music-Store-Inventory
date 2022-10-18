using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicStoreInventory
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        SQL_Helper data;
        private void FormMain_Load(object sender, EventArgs e)
        {
            //string directory = AppDomain.CurrentDomain.BaseDirectory;
            //data = new SQL_Helper("Provider= Microsoft.Jet.OLEDB.4.0; Data Source = \"" + directory + "Instrument Database.mdb\"");
            data = new SQL_Helper("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"|DataDirectory|\\Instrument Database.mdb\"");
            data.search("Customers", "Customer_Name", "John Smith");
            this.customerTableAdapter.Fill(this.instrument_DatabaseDataSet.Customer);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            // Check for radio buttons with integer type
            bool isValid = false;
            string query = txtSearch.Text;
            if (rBtStock.Checked || rBtBarcode.Checked || rBtSerial.Checked || rBtCustomerID.Checked)
            {
                // Check if input is an integer
                int parseResult;
                int.TryParse(query, out parseResult);
                if (parseResult == 0)
                    MessageBox.Show("Error: Enter an Integer");
                else
                    isValid = true;
            }
            else if(rBtStatus.Checked)
            {
                //Test if valid status
                isValid = true;

                MessageBox.Show("Query: " + query);
            }
            else
            {
                isValid = true;
                MessageBox.Show("Query: " + query);
            }

            //////////////////////////////////////// Under Construction ////////////////////////////////////////
            if (isValid)
            {
                string table = "Customers";
                data.search("Customers", "Customer_Name", "");
            }
            //if (isValid)
            //{
            //    string table = "Instruments";
            //    if (rBtStock.Checked)
            //        data.Search(table, "Stock", query);
            //    else if (rBtBarcode.Checked)
            //        data.Search(table, "Barcode", query);
            //    else if (rBtInstrument.Checked)
            //        data.Search(table, "Instrument", query);
            //    else if (rBtSerial.Checked)
            //        data.Search(table, "Serial", query);
            //    else if (rBtStatus.Checked)
            //        data.Search(table, "Status", query);
            //    else if (rBtCustomerID.Checked)
            //        data.Search(table, "CustomerID", query);
            //    else if (rBtCustomerName.Checked)
            //        data.Search(table, "Customer_Name", query);
            //}
            this.customerTableAdapter.Fill(this.instrument_DatabaseDataSet.Customer);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string errorMessage = data.add("11", "The Dude", "123 Street", "Card");
            if(errorMessage != "")
                MessageBox.Show("Error: " + errorMessage);
            else
                this.customerTableAdapter.Fill(this.instrument_DatabaseDataSet.Customer);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                data.delete("11");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                throw;
            }
            this.customerTableAdapter.Fill(this.instrument_DatabaseDataSet.Customer);
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            //dataGridView1.
        }
    }
}
