using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicStoreInventory.Instrument_DatabaseDataSetTableAdapters;

namespace MusicStoreInventory
{
    public partial class FormMain : Form
    {
        enum tableEnum { INSTRUMENTS, CUSTOMERS, TRANSACTIONS };
        private tableEnum currentTable;
        private SQL_Helper data;

        public FormMain()
        {
            InitializeComponent();
        }
        
        private void FormMain_Load(object sender, EventArgs e)
        {
            data = new SQL_Helper("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"|DataDirectory|\\Instrument Database.mdb\"");
            //data.search("Customer", "Customer_Name", "John Smith");
            refreshForm();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                data.search("Customer", "Customer_Name", txtSearch.Text);
            }
            catch (Exception errorMessage)
            {
                MessageBox.Show("Error: " + errorMessage);
                throw;
            }
            refreshForm();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                data.add("Customer", "11", "The Dude", "123 Street", "Card");
            }
            catch (Exception errorMessage)
            {
                MessageBox.Show("Error: " + errorMessage);
                throw;
            }
            refreshForm();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                data.delete("Customer", "11");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                throw;
            }
            refreshForm();
        }

        private void RBtsTableSelect_Click(object sender, EventArgs e)
        {
            refreshForm();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {

        }






        private void refreshForm()
        {
            if (rBtTableInstruments.Checked)
            {
                rBtSearch1.Text = "Instrument";
                rBtSearch2.Text = "Make";
                rBtSearch3.Text = "Size";
                rBtSearch4.Text = "Price";
                rBtSearch5.Text = "Quality";
                rBtSearch6.Visible = false;
                rBtSearch7.Visible = false;
                rBtSearch8.Visible = false;
                InstrumentTableAdapter adapter = new InstrumentTableAdapter();
                dgvMain.DataSource = instrument_DatabaseDataSet.Instrument;
                adapter.Fill(this.instrument_DatabaseDataSet.Instrument);
            }
            else if (rBtTableCustomers.Checked)
            {
                rBtSearch1.Text = "Customer";
                rBtSearch2.Text = "City";
                rBtSearch3.Text = "State";
                rBtSearch4.Text = "Address";
                rBtSearch5.Text = "Zip Code";
                rBtSearch6.Visible = false;
                rBtSearch7.Visible = false;
                rBtSearch8.Visible = false;
                CustomerTableAdapter adapter = new CustomerTableAdapter();
                dgvMain.DataSource = instrument_DatabaseDataSet.Customer;
                adapter.Fill(this.instrument_DatabaseDataSet.Customer);
            }
            else
            {

            }
        }

        private bool validateSearchInput(string input)
        {
            if (rBtTableInstruments.Checked)
            {
                if (rBtSearch4.Checked)
                {
                    double number;
                    return double.TryParse(txtSearch.Text, out number);
                }
                else
                    return true;
            }
            else if (rBtTableCustomers.Checked)
            {
                if (rBtSearch5.Checked)
                {
                    int number;
                    return int.TryParse(txtSearch.Text, out number);
                }
                else
                    return true;
            }
            else
            {

                return true;
            }
        }

        private bool validateDataInput(string input)
        {

            return false;
        }
    }
}
