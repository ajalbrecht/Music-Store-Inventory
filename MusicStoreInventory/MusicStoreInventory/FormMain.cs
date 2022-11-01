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
        // Variables
        private SQL_Helper data;



        // Constructor
        public FormMain()
        {
            InitializeComponent();
        }
        


        // FormMain Events
        private void FormMain_Load(object sender, EventArgs e)
        {
            data = new SQL_Helper("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"|DataDirectory|\\Instrument Database.mdb\"");
            btnInfoEnter.Text = "Enter";
            refreshForm();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (validateDataInput(txtSearch.Text))
                try
                {
                    data.search("Customer", "Customer_Name", txtSearch.Text);
                    refreshForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    throw;
                }
            else
                MessageBox.Show("Error: Wrong Data Type Entered");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                data.add("Customer", "11", "The Dude", "123 Street", "Card");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            refreshForm();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int row;
            try
            {
                int.TryParse(dgvMain.SelectedCells[0].OwningRow.Index.ToString(), out row);
                fillInfoForm(row);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
            }
            refreshForm();
        }

        private void RBtsTableSelect_Click(object sender, EventArgs e)
        {
            refreshForm();
        }

        private void BtnInfoEnter_Click(object sender, EventArgs e)
        {

        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            
        }



        // FormMain Methods
        private void refreshForm()
        {
            txtInfo1.Text = txtInfo2.Text = txtInfo3.Text = txtInfo4.Text = txtInfo5.Text = "";
            if (rBtTableInstruments.Checked)
            {
                gBxRowInfo.Text = "Instrument Info:";
                rBtSearch1.Text = lblInfo1.Text = "Name";
                rBtSearch2.Text = lblInfo2.Text = "Make";
                rBtSearch3.Text = lblInfo3.Text = "Size";
                rBtSearch4.Text = lblInfo4.Text = "Price";
                rBtSearch5.Text = lblInfo5.Text = "Quality";

                rBtSearch6.Visible = false;
                rBtSearch7.Visible = false;
                rBtSearch8.Visible = false;

                InstrumentTableAdapter adapter = new InstrumentTableAdapter();
                dgvMain.DataSource = instrument_DatabaseDataSet.Instrument;
                adapter.Fill(this.instrument_DatabaseDataSet.Instrument);
            }
            else if (rBtTableCustomers.Checked)
            {
                gBxRowInfo.Text = "Customer Info:";
                rBtSearch1.Text = lblInfo1.Text = "Name";
                rBtSearch2.Text = lblInfo2.Text = "City";
                rBtSearch3.Text = lblInfo3.Text = "State";
                rBtSearch4.Text = lblInfo4.Text = "Address";
                rBtSearch5.Text = lblInfo5.Text = "Zip Code";

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

        private void fillInfoForm(int row)
        {
            int columns;
            if (rBtTableInstruments.Checked)
                columns = 5;
            else if (rBtTableCustomers.Checked)
                columns = 3;
            else
                columns = 0;

            switch (columns)
            {
                case 5:
                    txtInfo5.Text = dgvMain.Rows[row].Cells[5].Value.ToString();
                    goto case 4;
                case 4:
                    txtInfo4.Text = dgvMain.Rows[row].Cells[4].Value.ToString();
                    goto case 3;
                case 3:
                    txtInfo3.Text = dgvMain.Rows[row].Cells[3].Value.ToString();
                    txtInfo2.Text = dgvMain.Rows[row].Cells[2].Value.ToString();
                    txtInfo1.Text = dgvMain.Rows[row].Cells[1].Value.ToString();
                    break;
                default:
                    break;
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
