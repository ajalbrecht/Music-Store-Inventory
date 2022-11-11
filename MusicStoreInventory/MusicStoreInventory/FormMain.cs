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
        // Constants
        const string DEFAULT_BUTTON_COLOR = "ControlLight";
        const string SELECTED_BUTTON_COLOR = "ControlDark";


        // Variables
        private SQL_Helper data;
        enum TableStates { DEFAULT, INSTRUMENTS, CUSTOMERS, TRANSACTIONS };
        private TableStates lastTable;
        enum infoBoxState { DEFAULT, ADD, EDIT, DELETE}
        private bool isAddMode;



        // Constructor
        public FormMain()
        {
            InitializeComponent();
        }
        


        // FormMain Events
        private void FormMain_Load(object sender, EventArgs e)
        {
            data = new SQL_Helper("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"|DataDirectory|\\Instrument Database.mdb\"");
            RBtTableInstruments_Click(new Button(), new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0));
            BtnAdd_Click(new Button(), new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0));
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //if (validateDataInput(txtSearch.Text))
            //    try
            //    {
            //        data.search("Customer", "Customer_Name", txtSearch.Text);
            //        refreshForm();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error: " + ex.Message);
            //        throw;
            //    }
            //else
            //    MessageBox.Show("Error: Wrong Data Type Entered");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!isAddMode)
                txtInfo1.Text = txtInfo2.Text = txtInfo3.Text = txtInfo4.Text = txtInfo5.Text = "";
            isAddMode = true;
            btnInfoEnter.Text = "Add";
            btnAdd.BackColor = Color.FromName(SELECTED_BUTTON_COLOR);
            btnEdit.BackColor = Color.FromName(DEFAULT_BUTTON_COLOR);
            btnDelete.BackColor = Color.FromName(DEFAULT_BUTTON_COLOR);
            //if (rBtTableInstruments.Checked)
            //    gBxRowInfo.Text += "Intrument:";
            //else if (rBtTableCustomers.Checked)
            //    gBxRowInfo.Text += "Customer:";
            //else
            //    gBxRowInfo.Text += "Transaction:";


            //try
            //{
            //    data.add("Customer", "11", "The Dude", "123 Street", "Card");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
            //refreshForm();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            isAddMode = false;
            btnInfoEnter.Text = "Edit";
            btnAdd.BackColor = Color.FromName(DEFAULT_BUTTON_COLOR);
            btnEdit.BackColor = Color.FromName(SELECTED_BUTTON_COLOR);
            btnDelete.BackColor = Color.FromName(DEFAULT_BUTTON_COLOR);


            DgvMain_CellClick(new DataGridView(), new DataGridViewCellEventArgs(dgvMain.SelectedCells[0].ColumnIndex, dgvMain.SelectedCells[0].RowIndex));

            //try
            //{
            //    //fillInfoForm(dgvMain.SelectedCells[0].RowIndex);
            //    //data.edit("11", "Dude", "321", "4321");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
            //refreshForm();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            isAddMode = false;
            btnInfoEnter.Text = "Delete";
            btnAdd.BackColor = Color.FromName(DEFAULT_BUTTON_COLOR);
            btnEdit.BackColor = Color.FromName(DEFAULT_BUTTON_COLOR);
            btnDelete.BackColor = Color.FromName(SELECTED_BUTTON_COLOR);

            DgvMain_CellClick(new DataGridView(), new DataGridViewCellEventArgs(dgvMain.SelectedCells[0].ColumnIndex, dgvMain.SelectedCells[0].RowIndex));
            //try
            //{
            //    data.delete("Customer", "11");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
            //refreshForm();
        }

        private void BtnInfoEnter_Click(object sender, EventArgs e)
        {
            //data.edit(lblID.Text, txtInfo1.Text, txtInfo2.Text, txtInfo3.Text);//, txtInfo4.Text, txtInfo5);
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {

        }

        private void RBtTableInstruments_Click(object sender, EventArgs e)
        {
            if (lastTable == TableStates.INSTRUMENTS)
                return;

            txtInfo1.Text = txtInfo2.Text = txtInfo3.Text = txtInfo4.Text = txtInfo5.Text = "";
            gBxRowInfo.Text = "Instrument Info:";
            rBtSearch1.Text = lblInfo1.Text = "Name";
            rBtSearch2.Text = lblInfo2.Text = "Make";
            rBtSearch3.Text = lblInfo3.Text = "Size";
            rBtSearch4.Text = lblInfo4.Text = "Price";
            rBtSearch5.Text = lblInfo5.Text = "Quality";

            rBtSearch6.Visible = false;
            rBtSearch7.Visible = false;
            rBtSearch8.Visible = false;

            lastTable = TableStates.INSTRUMENTS;
            refreshForm();
        }

        private void RBtTableCustomers_Click(object sender, EventArgs e)
        {
            if (lastTable == TableStates.CUSTOMERS)
                return;

            txtInfo1.Text = txtInfo2.Text = txtInfo3.Text = txtInfo4.Text = txtInfo5.Text = "";
            gBxRowInfo.Text = "Customer Info:";
            rBtSearch1.Text = lblInfo1.Text = "Name";
            rBtSearch2.Text = lblInfo2.Text = "City";
            rBtSearch3.Text = lblInfo3.Text = "State";
            rBtSearch4.Text = lblInfo4.Text = "Address";
            rBtSearch5.Text = lblInfo5.Text = "Zip Code";

            rBtSearch6.Visible = false;
            rBtSearch7.Visible = false;
            rBtSearch8.Visible = false;

            lastTable = TableStates.CUSTOMERS;
            refreshForm();
        }

        private void RBtTableTransactions_Click(object sender, EventArgs e)
        {
            if (lastTable == TableStates.TRANSACTIONS)
                return;

            txtInfo1.Text = txtInfo2.Text = txtInfo3.Text = txtInfo4.Text = txtInfo5.Text = "";

            txtInfo1.Text = txtInfo2.Text = txtInfo3.Text = txtInfo4.Text = txtInfo5.Text = "";
            gBxRowInfo.Text = "Transaction Info:";
            rBtSearch1.Text = lblInfo1.Text = "Instrument";
            rBtSearch2.Text = lblInfo2.Text = "Name";
            rBtSearch3.Text = lblInfo3.Text = "Num 3";
            rBtSearch4.Text = lblInfo4.Text = "Num 4";
            rBtSearch5.Text = lblInfo5.Text = "Num 5";

            rBtSearch6.Visible = false;
            rBtSearch7.Visible = false;
            rBtSearch8.Visible = false;

            lastTable = TableStates.TRANSACTIONS;
            refreshForm();
        }

        private void DgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(sender.GetType().ToString());
            if (!isAddMode)
            {
                int row = e.RowIndex;
                //int columns = dgvMain.Columns.Count - 1;

                txtInfo5.Text = dgvMain.Rows[row].Cells[5].Value.ToString();
                txtInfo4.Text = dgvMain.Rows[row].Cells[4].Value.ToString();
                txtInfo3.Text = dgvMain.Rows[row].Cells[3].Value.ToString();
                txtInfo2.Text = dgvMain.Rows[row].Cells[2].Value.ToString();
                txtInfo1.Text = dgvMain.Rows[row].Cells[1].Value.ToString();
                lblID.Text = dgvMain.Rows[row].Cells[0].Value.ToString();
            }
        }







        // FormMain Methods
        private void refreshForm()
        {
            if (rBtTableInstruments.Checked)
            {
                InstrumentTableAdapter adapter = new InstrumentTableAdapter();
                dgvMain.DataSource = instrument_DatabaseDataSet.Instrument;
                adapter.Fill(this.instrument_DatabaseDataSet.Instrument);
            }
            else if (rBtTableCustomers.Checked)
            {
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

        private bool validateDataInput()
        {
            if (rBtTableInstruments.Checked)
            {
                double number;
                return double.TryParse(txtInfo4.Text, out number);
            }
            else if (rBtTableCustomers.Checked)
            {
                int number;
                return int.TryParse(txtInfo5.Text, out number);
            }
            else
            {

                return true;
            }
        }
    }
}