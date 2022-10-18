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

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //Integer rBt check
            if (rBtStock.Checked || rBtBarcode.Checked || rBtSerial.Checked || rBtCustomerID.Checked)
            {
                //Validate Input
                int parseResult;
                int.TryParse(txtSearch.Text, out parseResult);
                if(parseResult == 0)
                    MessageBox.Show("Error: Enter an Integer");
                else
                {
                    string query = txtSearch.Text;
                    MessageBox.Show("Query: " + query);
                }
                //Query
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
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
