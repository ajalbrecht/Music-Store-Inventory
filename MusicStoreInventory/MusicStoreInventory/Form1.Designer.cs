namespace MusicStoreInventory
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.instrument_DatabaseDataSet = new MusicStoreInventory.Instrument_DatabaseDataSet();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gBxSearchCriteria = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.rBtSerial = new System.Windows.Forms.RadioButton();
            this.rBtCustomerID = new System.Windows.Forms.RadioButton();
            this.rBtCustomerName = new System.Windows.Forms.RadioButton();
            this.rBtStatus = new System.Windows.Forms.RadioButton();
            this.rBtInstrument = new System.Windows.Forms.RadioButton();
            this.rBtBarcode = new System.Windows.Forms.RadioButton();
            this.rBtStock = new System.Windows.Forms.RadioButton();
            this.gBxAdEdDe = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.gBxSelectTable = new System.Windows.Forms.GroupBox();
            this.rBtTableTransactions = new System.Windows.Forms.RadioButton();
            this.rBtTableCustomers = new System.Windows.Forms.RadioButton();
            this.rBtTableInstruments = new System.Windows.Forms.RadioButton();
            this.gBxCustomerInfo = new System.Windows.Forms.GroupBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPaymentInfo = new System.Windows.Forms.TextBox();
            this.lblPamentInfo = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrument_DatabaseDataSet)).BeginInit();
            this.gBxSearchCriteria.SuspendLayout();
            this.gBxAdEdDe.SuspendLayout();
            this.gBxSelectTable.SuspendLayout();
            this.gBxCustomerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(12, 184);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.Size = new System.Drawing.Size(528, 239);
            this.dgvMain.TabIndex = 9;
            // 
            // instrument_DatabaseDataSet
            // 
            this.instrument_DatabaseDataSet.DataSetName = "Instrument_DatabaseDataSet";
            this.instrument_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(135, 20);
            this.txtSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(6, 43);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 30);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // gBxSearchCriteria
            // 
            this.gBxSearchCriteria.Controls.Add(this.btnExit);
            this.gBxSearchCriteria.Controls.Add(this.rBtSerial);
            this.gBxSearchCriteria.Controls.Add(this.rBtCustomerID);
            this.gBxSearchCriteria.Controls.Add(this.rBtCustomerName);
            this.gBxSearchCriteria.Controls.Add(this.rBtStatus);
            this.gBxSearchCriteria.Controls.Add(this.txtSearch);
            this.gBxSearchCriteria.Controls.Add(this.btnSearch);
            this.gBxSearchCriteria.Controls.Add(this.rBtInstrument);
            this.gBxSearchCriteria.Controls.Add(this.rBtBarcode);
            this.gBxSearchCriteria.Controls.Add(this.rBtStock);
            this.gBxSearchCriteria.Location = new System.Drawing.Point(12, 64);
            this.gBxSearchCriteria.Name = "gBxSearchCriteria";
            this.gBxSearchCriteria.Size = new System.Drawing.Size(362, 114);
            this.gBxSearchCriteria.TabIndex = 10;
            this.gBxSearchCriteria.TabStop = false;
            this.gBxSearchCriteria.Text = "Search:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(5, 79);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(135, 30);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // rBtSerial
            // 
            this.rBtSerial.AutoSize = true;
            this.rBtSerial.Location = new System.Drawing.Point(167, 87);
            this.rBtSerial.Name = "rBtSerial";
            this.rBtSerial.Size = new System.Drawing.Size(61, 17);
            this.rBtSerial.TabIndex = 6;
            this.rBtSerial.Text = "Serial #";
            this.rBtSerial.UseVisualStyleBackColor = true;
            // 
            // rBtCustomerID
            // 
            this.rBtCustomerID.AutoSize = true;
            this.rBtCustomerID.Location = new System.Drawing.Point(254, 41);
            this.rBtCustomerID.Name = "rBtCustomerID";
            this.rBtCustomerID.Size = new System.Drawing.Size(83, 17);
            this.rBtCustomerID.TabIndex = 5;
            this.rBtCustomerID.Text = "Customer ID";
            this.rBtCustomerID.UseVisualStyleBackColor = true;
            // 
            // rBtCustomerName
            // 
            this.rBtCustomerName.AutoSize = true;
            this.rBtCustomerName.Location = new System.Drawing.Point(254, 64);
            this.rBtCustomerName.Name = "rBtCustomerName";
            this.rBtCustomerName.Size = new System.Drawing.Size(100, 17);
            this.rBtCustomerName.TabIndex = 4;
            this.rBtCustomerName.Text = "Customer Name";
            this.rBtCustomerName.UseVisualStyleBackColor = true;
            // 
            // rBtStatus
            // 
            this.rBtStatus.AutoSize = true;
            this.rBtStatus.Location = new System.Drawing.Point(254, 18);
            this.rBtStatus.Name = "rBtStatus";
            this.rBtStatus.Size = new System.Drawing.Size(55, 17);
            this.rBtStatus.TabIndex = 3;
            this.rBtStatus.Text = "Status";
            this.rBtStatus.UseVisualStyleBackColor = true;
            // 
            // rBtInstrument
            // 
            this.rBtInstrument.AutoSize = true;
            this.rBtInstrument.Location = new System.Drawing.Point(167, 64);
            this.rBtInstrument.Name = "rBtInstrument";
            this.rBtInstrument.Size = new System.Drawing.Size(74, 17);
            this.rBtInstrument.TabIndex = 2;
            this.rBtInstrument.Text = "Instrument";
            this.rBtInstrument.UseVisualStyleBackColor = true;
            // 
            // rBtBarcode
            // 
            this.rBtBarcode.AutoSize = true;
            this.rBtBarcode.Location = new System.Drawing.Point(167, 41);
            this.rBtBarcode.Name = "rBtBarcode";
            this.rBtBarcode.Size = new System.Drawing.Size(65, 17);
            this.rBtBarcode.TabIndex = 1;
            this.rBtBarcode.Text = "Barcode";
            this.rBtBarcode.UseVisualStyleBackColor = true;
            // 
            // rBtStock
            // 
            this.rBtStock.AutoSize = true;
            this.rBtStock.Checked = true;
            this.rBtStock.Location = new System.Drawing.Point(167, 18);
            this.rBtStock.Name = "rBtStock";
            this.rBtStock.Size = new System.Drawing.Size(63, 17);
            this.rBtStock.TabIndex = 0;
            this.rBtStock.TabStop = true;
            this.rBtStock.Text = "Stock #";
            this.rBtStock.UseVisualStyleBackColor = true;
            // 
            // gBxAdEdDe
            // 
            this.gBxAdEdDe.Controls.Add(this.btnDelete);
            this.gBxAdEdDe.Controls.Add(this.btnEdit);
            this.gBxAdEdDe.Controls.Add(this.btnAdd);
            this.gBxAdEdDe.Location = new System.Drawing.Point(381, 64);
            this.gBxAdEdDe.Name = "gBxAdEdDe";
            this.gBxAdEdDe.Size = new System.Drawing.Size(159, 114);
            this.gBxAdEdDe.TabIndex = 11;
            this.gBxAdEdDe.TabStop = false;
            this.gBxAdEdDe.Text = "Edit Data:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(7, 79);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 27);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(7, 49);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(146, 27);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(146, 27);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(425, 25);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 20;
            this.btnTest.Text = "test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // gBxSelectTable
            // 
            this.gBxSelectTable.Controls.Add(this.rBtTableTransactions);
            this.gBxSelectTable.Controls.Add(this.rBtTableCustomers);
            this.gBxSelectTable.Controls.Add(this.rBtTableInstruments);
            this.gBxSelectTable.Location = new System.Drawing.Point(12, 12);
            this.gBxSelectTable.Name = "gBxSelectTable";
            this.gBxSelectTable.Size = new System.Drawing.Size(362, 46);
            this.gBxSelectTable.TabIndex = 21;
            this.gBxSelectTable.TabStop = false;
            this.gBxSelectTable.Text = "Select Table:";
            // 
            // rBtTableTransactions
            // 
            this.rBtTableTransactions.AutoSize = true;
            this.rBtTableTransactions.Location = new System.Drawing.Point(171, 19);
            this.rBtTableTransactions.Name = "rBtTableTransactions";
            this.rBtTableTransactions.Size = new System.Drawing.Size(86, 17);
            this.rBtTableTransactions.TabIndex = 6;
            this.rBtTableTransactions.Text = "Transactions";
            this.rBtTableTransactions.UseVisualStyleBackColor = true;
            this.rBtTableTransactions.Click += new System.EventHandler(this.RBtsTableSelect_Click);
            // 
            // rBtTableCustomers
            // 
            this.rBtTableCustomers.AutoSize = true;
            this.rBtTableCustomers.Location = new System.Drawing.Point(91, 19);
            this.rBtTableCustomers.Name = "rBtTableCustomers";
            this.rBtTableCustomers.Size = new System.Drawing.Size(74, 17);
            this.rBtTableCustomers.TabIndex = 5;
            this.rBtTableCustomers.Text = "Customers";
            this.rBtTableCustomers.UseVisualStyleBackColor = true;
            this.rBtTableCustomers.Click += new System.EventHandler(this.RBtsTableSelect_Click);
            // 
            // rBtTableInstruments
            // 
            this.rBtTableInstruments.AutoSize = true;
            this.rBtTableInstruments.Checked = true;
            this.rBtTableInstruments.Location = new System.Drawing.Point(6, 19);
            this.rBtTableInstruments.Name = "rBtTableInstruments";
            this.rBtTableInstruments.Size = new System.Drawing.Size(79, 17);
            this.rBtTableInstruments.TabIndex = 4;
            this.rBtTableInstruments.TabStop = true;
            this.rBtTableInstruments.Text = "Instruments";
            this.rBtTableInstruments.UseVisualStyleBackColor = true;
            this.rBtTableInstruments.Click += new System.EventHandler(this.RBtsTableSelect_Click);
            // 
            // gBxCustomerInfo
            // 
            this.gBxCustomerInfo.Controls.Add(this.lblCustomerID);
            this.gBxCustomerInfo.Controls.Add(this.lblName);
            this.gBxCustomerInfo.Controls.Add(this.lblAddress);
            this.gBxCustomerInfo.Controls.Add(this.txtPaymentInfo);
            this.gBxCustomerInfo.Controls.Add(this.lblPamentInfo);
            this.gBxCustomerInfo.Controls.Add(this.txtAddress);
            this.gBxCustomerInfo.Controls.Add(this.txtCustomerID);
            this.gBxCustomerInfo.Controls.Add(this.txtName);
            this.gBxCustomerInfo.Location = new System.Drawing.Point(546, 12);
            this.gBxCustomerInfo.Name = "gBxCustomerInfo";
            this.gBxCustomerInfo.Size = new System.Drawing.Size(209, 411);
            this.gBxCustomerInfo.TabIndex = 23;
            this.gBxCustomerInfo.TabStop = false;
            this.gBxCustomerInfo.Text = "Customer Info";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(10, 16);
            this.lblCustomerID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(65, 13);
            this.lblCustomerID.TabIndex = 12;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 61);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(10, 105);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Address";
            // 
            // txtPaymentInfo
            // 
            this.txtPaymentInfo.Location = new System.Drawing.Point(108, 148);
            this.txtPaymentInfo.Margin = new System.Windows.Forms.Padding(2);
            this.txtPaymentInfo.Name = "txtPaymentInfo";
            this.txtPaymentInfo.Size = new System.Drawing.Size(76, 20);
            this.txtPaymentInfo.TabIndex = 19;
            // 
            // lblPamentInfo
            // 
            this.lblPamentInfo.AutoSize = true;
            this.lblPamentInfo.Location = new System.Drawing.Point(10, 150);
            this.lblPamentInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPamentInfo.Name = "lblPamentInfo";
            this.lblPamentInfo.Size = new System.Drawing.Size(69, 13);
            this.lblPamentInfo.TabIndex = 15;
            this.lblPamentInfo.Text = "Payment Info";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(108, 103);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(76, 20);
            this.txtAddress.TabIndex = 18;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(108, 16);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(76, 20);
            this.txtCustomerID.TabIndex = 16;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(108, 61);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(76, 20);
            this.txtName.TabIndex = 17;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 436);
            this.Controls.Add(this.gBxCustomerInfo);
            this.Controls.Add(this.gBxSelectTable);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.gBxAdEdDe);
            this.Controls.Add(this.gBxSearchCriteria);
            this.Controls.Add(this.dgvMain);
            this.Name = "FormMain";
            this.Text = "Database Manager v1.5";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrument_DatabaseDataSet)).EndInit();
            this.gBxSearchCriteria.ResumeLayout(false);
            this.gBxSearchCriteria.PerformLayout();
            this.gBxAdEdDe.ResumeLayout(false);
            this.gBxSelectTable.ResumeLayout(false);
            this.gBxSelectTable.PerformLayout();
            this.gBxCustomerInfo.ResumeLayout(false);
            this.gBxCustomerInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gBxSearchCriteria;
        private System.Windows.Forms.RadioButton rBtBarcode;
        private System.Windows.Forms.RadioButton rBtStock;
        private System.Windows.Forms.RadioButton rBtStatus;
        private System.Windows.Forms.RadioButton rBtInstrument;
        private System.Windows.Forms.RadioButton rBtCustomerID;
        private System.Windows.Forms.RadioButton rBtCustomerName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rBtSerial;
        private System.Windows.Forms.GroupBox gBxAdEdDe;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnTest;
        private Instrument_DatabaseDataSet instrument_DatabaseDataSet;
        private System.Windows.Forms.GroupBox gBxSelectTable;
        private System.Windows.Forms.RadioButton rBtTableTransactions;
        private System.Windows.Forms.RadioButton rBtTableCustomers;
        private System.Windows.Forms.RadioButton rBtTableInstruments;
        private System.Windows.Forms.GroupBox gBxCustomerInfo;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPaymentInfo;
        private System.Windows.Forms.Label lblPamentInfo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtName;
    }
}

