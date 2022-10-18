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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.txtPaymentInfo = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.instrument_DatabaseDataSet = new MusicStoreInventory.Instrument_DatabaseDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new MusicStoreInventory.Instrument_DatabaseDataSetTableAdapters.CustomerTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentinfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gBxSearchCriteria.SuspendLayout();
            this.gBxAdEdDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instrument_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.paymentinfoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(528, 239);
            this.dataGridView1.TabIndex = 9;
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
            this.gBxSearchCriteria.Location = new System.Drawing.Point(12, 9);
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
            this.gBxAdEdDe.Location = new System.Drawing.Point(381, 9);
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
            // txtPaymentInfo
            // 
            this.txtPaymentInfo.Location = new System.Drawing.Point(663, 158);
            this.txtPaymentInfo.Margin = new System.Windows.Forms.Padding(2);
            this.txtPaymentInfo.Name = "txtPaymentInfo";
            this.txtPaymentInfo.Size = new System.Drawing.Size(76, 20);
            this.txtPaymentInfo.TabIndex = 19;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(663, 113);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(76, 20);
            this.txtAddress.TabIndex = 18;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(663, 71);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(76, 20);
            this.txtName.TabIndex = 17;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(663, 26);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(76, 20);
            this.txtCustomerID.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(565, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Payment Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(565, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Customer ID";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(568, 211);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 20;
            this.btnTest.Text = "test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // instrument_DatabaseDataSet
            // 
            this.instrument_DatabaseDataSet.DataSetName = "Instrument_DatabaseDataSet";
            this.instrument_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.instrument_DatabaseDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "Customer_Name";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Customer_Name";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // paymentinfoDataGridViewTextBoxColumn
            // 
            this.paymentinfoDataGridViewTextBoxColumn.DataPropertyName = "Payment_info";
            this.paymentinfoDataGridViewTextBoxColumn.HeaderText = "Payment_info";
            this.paymentinfoDataGridViewTextBoxColumn.Name = "paymentinfoDataGridViewTextBoxColumn";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 380);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtPaymentInfo);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gBxAdEdDe);
            this.Controls.Add(this.gBxSearchCriteria);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormMain";
            this.Text = "Database Manager v1.3";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gBxSearchCriteria.ResumeLayout(false);
            this.gBxSearchCriteria.PerformLayout();
            this.gBxAdEdDe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.instrument_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.TextBox txtPaymentInfo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTest;
        private Instrument_DatabaseDataSet instrument_DatabaseDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Instrument_DatabaseDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentinfoDataGridViewTextBoxColumn;
    }
}

