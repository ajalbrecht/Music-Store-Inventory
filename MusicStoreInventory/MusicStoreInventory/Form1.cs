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
            //try
            //{
            //    data = new SQL_Helper("Server=localhost;Integrated security=SSPI;database=master");
            //}
            //catch (Exception exception)
            //{
            //    MessageBox.Show(exception.Message);
            //}
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            // Check for radio buttons with integer type
            if (rBtStock.Checked || rBtBarcode.Checked || rBtSerial.Checked || rBtCustomerID.Checked)
            {
                // Check if input is an integer
                int parseResult;
                int.TryParse(txtSearch.Text, out parseResult);
                if(parseResult == 0)
                    MessageBox.Show("Error: Enter an Integer");
                else
                {
                    string query = txtSearch.Text;
                    MessageBox.Show("Query: " + query);
                }
            }
            else if(rBtStatus.Checked)
            {
                //Test if valid status
                string query = txtSearch.Text;
                MessageBox.Show("Query: " + query);
            }
            else
            {
                string query = txtSearch.Text;
                MessageBox.Show("Query: " + query);
            }

            //////////////////////////////////////// Under Construction ////////////////////////////////////////
            return;

            string table = "Instruments";
            if (rBtStock.Checked)
                data.Search(table, "Stock");
            else if (rBtBarcode.Checked)
                data.Search(table, "Barcode");
            else if (rBtInstrument.Checked)
                data.Search(table, "Instrument");
            else if (rBtSerial.Checked)
                data.Search(table, "Serial");
            else if (rBtStatus.Checked)
                data.Search(table, "Status");
            else if (rBtCustomerID.Checked)
                data.Search(table, "CustomerID");
            else if (rBtCustomerName.Checked)
                data.Search(table, "Customer_Name");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
