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
        enum AddEditDeleteState { DEFAULT, ADD, EDIT, DELETE };
        private AddEditDeleteState lastInfoState;



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
            string searchTerm = txtSearch.Text;
            if (string.IsNullOrEmpty(searchTerm))
            {
                refreshForm();
                return;
            }

            ushort rBtNumber = ushort.MaxValue;
            if (rBtSearch1.Checked)
                rBtNumber = 1;
            else if (rBtSearch2.Checked)
                rBtNumber = 2;
            else if (rBtSearch3.Checked)
                rBtNumber = 3;
            else if (rBtSearch4.Checked)
                rBtNumber = 4;
            else
                rBtNumber = 5;



            string table;
            string column;
            if (lastTable == TableStates.INSTRUMENTS)
            {
                table = "Instruments";
                switch (rBtNumber)
                {
                    case 1:
                        column = "Instrument_Name";
                        break;
                    case 2:
                        column = "Make";
                        break;
                    case 3:
                        column = "Size";
                        break;
                    case 4:
                        column = "Price";
                        break;
                    default:
                        column = "Quality";
                        break;
                }
            }
            else if (lastTable == TableStates.CUSTOMERS)
            {
                table = "Customers";
                switch (rBtNumber)
                {
                    case 1:
                        column = "Customer_Name";
                        break;
                    case 2:
                        column = "Address";
                        break;
                    case 3:
                        column = "City";
                        break;
                    case 4:
                        column = "State";
                        break;
                    default:
                        column = "Zip_Code";
                        break;
                }
            }
            else
            {
                table = "Transactions";
                switch (rBtNumber)
                {
                    case 1:
                        column = "Customer";
                        break;
                    case 2:
                        column = "Instrument";
                        break;
                    case 3:
                        column = "Sale_Price";
                        break;
                    case 4:
                        column = "Listed_Price";
                        break;
                    default:
                        column = "Payment_Type";
                        break;
                }
            }



            try
            {
                dgvMain.DataSource = data.search(table, column, searchTerm);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (lastInfoState == AddEditDeleteState.ADD)
                return;

            lblID.Text = "#";
            txtInfo1.Text = txtInfo2.Text = txtInfo3.Text = txtInfo4.Text = txtInfo5.Text = "";
            lastInfoState = AddEditDeleteState.ADD;
            btnInfoEnter.Text = "Add";
            btnAdd.BackColor = Color.FromName(SELECTED_BUTTON_COLOR);
            btnEdit.BackColor = Color.FromName(DEFAULT_BUTTON_COLOR);
            btnDelete.BackColor = Color.FromName(DEFAULT_BUTTON_COLOR);

            refreshForm();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (lastInfoState == AddEditDeleteState.EDIT)
                return;

            lastInfoState = AddEditDeleteState.EDIT;
            btnInfoEnter.Text = "Edit";
            btnAdd.BackColor = Color.FromName(DEFAULT_BUTTON_COLOR);
            btnEdit.BackColor = Color.FromName(SELECTED_BUTTON_COLOR);
            btnDelete.BackColor = Color.FromName(DEFAULT_BUTTON_COLOR);

            DgvMain_CellClick(new DataGridView(), new DataGridViewCellEventArgs(dgvMain.SelectedCells[0].ColumnIndex, dgvMain.SelectedCells[0].RowIndex));
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (lastInfoState == AddEditDeleteState.DELETE)
                return;

            lastInfoState = AddEditDeleteState.DELETE;
            btnInfoEnter.Text = "Delete";
            btnAdd.BackColor = Color.FromName(DEFAULT_BUTTON_COLOR);
            btnEdit.BackColor = Color.FromName(DEFAULT_BUTTON_COLOR);
            btnDelete.BackColor = Color.FromName(SELECTED_BUTTON_COLOR);

            DgvMain_CellClick(new DataGridView(), new DataGridViewCellEventArgs(dgvMain.SelectedCells[0].ColumnIndex, dgvMain.SelectedCells[0].RowIndex));
        }

        private void BtnInfoEnter_Click(object sender, EventArgs e)
        {
            string table;
            if (lastTable == TableStates.INSTRUMENTS)
                table = "Instruments";
            else if (lastTable == TableStates.CUSTOMERS)
                table = "Customers";
            else
                table = "Transactions";

            try
            {
                if (lastInfoState == AddEditDeleteState.ADD)
                {
                    data.add(table, txtInfo1.Text, txtInfo2.Text, txtInfo3.Text, txtInfo4.Text, txtInfo5.Text);
                }
                else if (lastInfoState == AddEditDeleteState.EDIT)
                {
                    data.edit(table, lblID.Text, txtInfo1.Text, txtInfo2.Text, txtInfo3.Text, txtInfo4.Text, txtInfo5.Text);
                }
                else
                {
                    data.delete(table, lblID.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            if (lastInfoState == AddEditDeleteState.EDIT)
            {
                int row = dgvMain.SelectedCells[0].RowIndex;
                int column = dgvMain.SelectedCells[0].ColumnIndex;
                refreshForm();
                DgvMain_CellClick(new DataGridView(), new DataGridViewCellEventArgs(column, row));
            }
            else
                refreshForm();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            string input = "";
            double temp = 0;
            //MessageBox.Show("Converted: " + double.TryParse(input, out temp).ToString() + " " + temp.ToString());
            // input = temp.ToString("C");
            //MessageBox.Show("Formated: " + input);
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
            rBtSearch2.Text = lblInfo2.Text = "Address";
            rBtSearch3.Text = lblInfo3.Text = "City";
            rBtSearch4.Text = lblInfo4.Text = "State";
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
            rBtSearch1.Text = lblInfo1.Text = "Customer";
            rBtSearch2.Text = lblInfo2.Text = "Instrument";
            rBtSearch3.Text = lblInfo3.Text = "Sale Price";
            rBtSearch4.Text = lblInfo4.Text = "Listed Price";
            rBtSearch5.Text = lblInfo5.Text = "Payment Type";

            rBtSearch6.Visible = false;
            rBtSearch7.Visible = false;
            rBtSearch8.Visible = false;

            lastTable = TableStates.TRANSACTIONS;
            refreshForm();
        }

        private void DgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lastInfoState != AddEditDeleteState.ADD)
            {
                int row = e.RowIndex;
                //int maxColumn = dgvMain.Columns.Count - 1;

                lblID.Text = dgvMain.Rows[row].Cells[0].Value.ToString();
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
                InstrumentsTableAdapter adapter = new InstrumentsTableAdapter();
                dgvMain.DataSource = instrument_DatabaseDataSet.Instruments;
                adapter.Fill(this.instrument_DatabaseDataSet.Instruments);
            }
            else if (rBtTableCustomers.Checked)
            {
                CustomersTableAdapter adapter = new CustomersTableAdapter();
                dgvMain.DataSource = instrument_DatabaseDataSet.Customers;
                adapter.Fill(this.instrument_DatabaseDataSet.Customers);
            }
            else
            {
                TransactionsTableAdapter adapter = new TransactionsTableAdapter();
                dgvMain.DataSource = instrument_DatabaseDataSet.Transactions;
                adapter.Fill(this.instrument_DatabaseDataSet.Transactions);
            }
        }
    }
}