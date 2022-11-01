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
            this.rBtSearch8 = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.rBtSearch4 = new System.Windows.Forms.RadioButton();
            this.rBtSearch6 = new System.Windows.Forms.RadioButton();
            this.rBtSearch7 = new System.Windows.Forms.RadioButton();
            this.rBtSearch5 = new System.Windows.Forms.RadioButton();
            this.rBtSearch3 = new System.Windows.Forms.RadioButton();
            this.rBtSearch2 = new System.Windows.Forms.RadioButton();
            this.rBtSearch1 = new System.Windows.Forms.RadioButton();
            this.gBxAdEdDe = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.gBxSelectTable = new System.Windows.Forms.GroupBox();
            this.rBtTableTransactions = new System.Windows.Forms.RadioButton();
            this.rBtTableCustomers = new System.Windows.Forms.RadioButton();
            this.rBtTableInstruments = new System.Windows.Forms.RadioButton();
            this.gBxRowInfo = new System.Windows.Forms.GroupBox();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.lblInfo3 = new System.Windows.Forms.Label();
            this.txtInfo4 = new System.Windows.Forms.TextBox();
            this.lblInfo4 = new System.Windows.Forms.Label();
            this.txtInfo3 = new System.Windows.Forms.TextBox();
            this.txtInfo1 = new System.Windows.Forms.TextBox();
            this.txtInfo2 = new System.Windows.Forms.TextBox();
            this.btnInfoEnter = new System.Windows.Forms.Button();
            this.txtInfo5 = new System.Windows.Forms.TextBox();
            this.lblInfo5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrument_DatabaseDataSet)).BeginInit();
            this.gBxSearchCriteria.SuspendLayout();
            this.gBxAdEdDe.SuspendLayout();
            this.gBxSelectTable.SuspendLayout();
            this.gBxRowInfo.SuspendLayout();
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
            this.gBxSearchCriteria.Controls.Add(this.rBtSearch8);
            this.gBxSearchCriteria.Controls.Add(this.btnExit);
            this.gBxSearchCriteria.Controls.Add(this.rBtSearch4);
            this.gBxSearchCriteria.Controls.Add(this.rBtSearch6);
            this.gBxSearchCriteria.Controls.Add(this.rBtSearch7);
            this.gBxSearchCriteria.Controls.Add(this.rBtSearch5);
            this.gBxSearchCriteria.Controls.Add(this.txtSearch);
            this.gBxSearchCriteria.Controls.Add(this.btnSearch);
            this.gBxSearchCriteria.Controls.Add(this.rBtSearch3);
            this.gBxSearchCriteria.Controls.Add(this.rBtSearch2);
            this.gBxSearchCriteria.Controls.Add(this.rBtSearch1);
            this.gBxSearchCriteria.Location = new System.Drawing.Point(12, 64);
            this.gBxSearchCriteria.Name = "gBxSearchCriteria";
            this.gBxSearchCriteria.Size = new System.Drawing.Size(362, 114);
            this.gBxSearchCriteria.TabIndex = 10;
            this.gBxSearchCriteria.TabStop = false;
            this.gBxSearchCriteria.Text = "Search:";
            // 
            // rBtSearch8
            // 
            this.rBtSearch8.AutoSize = true;
            this.rBtSearch8.Location = new System.Drawing.Point(254, 86);
            this.rBtSearch8.Name = "rBtSearch8";
            this.rBtSearch8.Size = new System.Drawing.Size(78, 17);
            this.rBtSearch8.TabIndex = 12;
            this.rBtSearch8.Text = "rBtSearch8";
            this.rBtSearch8.UseVisualStyleBackColor = true;
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
            // rBtSearch4
            // 
            this.rBtSearch4.AutoSize = true;
            this.rBtSearch4.Location = new System.Drawing.Point(167, 87);
            this.rBtSearch4.Name = "rBtSearch4";
            this.rBtSearch4.Size = new System.Drawing.Size(78, 17);
            this.rBtSearch4.TabIndex = 6;
            this.rBtSearch4.Text = "rBtSearch4";
            this.rBtSearch4.UseVisualStyleBackColor = true;
            // 
            // rBtSearch6
            // 
            this.rBtSearch6.AutoSize = true;
            this.rBtSearch6.Location = new System.Drawing.Point(254, 41);
            this.rBtSearch6.Name = "rBtSearch6";
            this.rBtSearch6.Size = new System.Drawing.Size(78, 17);
            this.rBtSearch6.TabIndex = 5;
            this.rBtSearch6.Text = "rBtSearch6";
            this.rBtSearch6.UseVisualStyleBackColor = true;
            // 
            // rBtSearch7
            // 
            this.rBtSearch7.AutoSize = true;
            this.rBtSearch7.Location = new System.Drawing.Point(254, 64);
            this.rBtSearch7.Name = "rBtSearch7";
            this.rBtSearch7.Size = new System.Drawing.Size(78, 17);
            this.rBtSearch7.TabIndex = 4;
            this.rBtSearch7.Text = "rBtSearch7";
            this.rBtSearch7.UseVisualStyleBackColor = true;
            // 
            // rBtSearch5
            // 
            this.rBtSearch5.AutoSize = true;
            this.rBtSearch5.Location = new System.Drawing.Point(254, 18);
            this.rBtSearch5.Name = "rBtSearch5";
            this.rBtSearch5.Size = new System.Drawing.Size(78, 17);
            this.rBtSearch5.TabIndex = 3;
            this.rBtSearch5.Text = "rBtSearch5";
            this.rBtSearch5.UseVisualStyleBackColor = true;
            // 
            // rBtSearch3
            // 
            this.rBtSearch3.AutoSize = true;
            this.rBtSearch3.Location = new System.Drawing.Point(167, 64);
            this.rBtSearch3.Name = "rBtSearch3";
            this.rBtSearch3.Size = new System.Drawing.Size(78, 17);
            this.rBtSearch3.TabIndex = 2;
            this.rBtSearch3.Text = "rBtSearch3";
            this.rBtSearch3.UseVisualStyleBackColor = true;
            // 
            // rBtSearch2
            // 
            this.rBtSearch2.AutoSize = true;
            this.rBtSearch2.Location = new System.Drawing.Point(167, 41);
            this.rBtSearch2.Name = "rBtSearch2";
            this.rBtSearch2.Size = new System.Drawing.Size(78, 17);
            this.rBtSearch2.TabIndex = 1;
            this.rBtSearch2.Text = "rBtSearch2";
            this.rBtSearch2.UseVisualStyleBackColor = true;
            // 
            // rBtSearch1
            // 
            this.rBtSearch1.AutoSize = true;
            this.rBtSearch1.Checked = true;
            this.rBtSearch1.Location = new System.Drawing.Point(167, 18);
            this.rBtSearch1.Name = "rBtSearch1";
            this.rBtSearch1.Size = new System.Drawing.Size(78, 17);
            this.rBtSearch1.TabIndex = 0;
            this.rBtSearch1.TabStop = true;
            this.rBtSearch1.Text = "rBtSearch1";
            this.rBtSearch1.UseVisualStyleBackColor = true;
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
            // gBxRowInfo
            // 
            this.gBxRowInfo.Controls.Add(this.txtInfo5);
            this.gBxRowInfo.Controls.Add(this.lblInfo5);
            this.gBxRowInfo.Controls.Add(this.btnInfoEnter);
            this.gBxRowInfo.Controls.Add(this.lblInfo1);
            this.gBxRowInfo.Controls.Add(this.lblInfo2);
            this.gBxRowInfo.Controls.Add(this.lblInfo3);
            this.gBxRowInfo.Controls.Add(this.txtInfo4);
            this.gBxRowInfo.Controls.Add(this.lblInfo4);
            this.gBxRowInfo.Controls.Add(this.txtInfo3);
            this.gBxRowInfo.Controls.Add(this.txtInfo1);
            this.gBxRowInfo.Controls.Add(this.txtInfo2);
            this.gBxRowInfo.Location = new System.Drawing.Point(546, 12);
            this.gBxRowInfo.Name = "gBxRowInfo";
            this.gBxRowInfo.Size = new System.Drawing.Size(209, 411);
            this.gBxRowInfo.TabIndex = 23;
            this.gBxRowInfo.TabStop = false;
            this.gBxRowInfo.Text = "gBxRowInfo";
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Location = new System.Drawing.Point(10, 21);
            this.lblInfo1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(41, 13);
            this.lblInfo1.TabIndex = 12;
            this.lblInfo1.Text = "lblInfo1";
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Location = new System.Drawing.Point(10, 61);
            this.lblInfo2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(41, 13);
            this.lblInfo2.TabIndex = 13;
            this.lblInfo2.Text = "lblInfo2";
            // 
            // lblInfo3
            // 
            this.lblInfo3.AutoSize = true;
            this.lblInfo3.Location = new System.Drawing.Point(10, 105);
            this.lblInfo3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo3.Name = "lblInfo3";
            this.lblInfo3.Size = new System.Drawing.Size(41, 13);
            this.lblInfo3.TabIndex = 14;
            this.lblInfo3.Text = "lblInfo3";
            // 
            // txtInfo4
            // 
            this.txtInfo4.Location = new System.Drawing.Point(108, 148);
            this.txtInfo4.Margin = new System.Windows.Forms.Padding(2);
            this.txtInfo4.Name = "txtInfo4";
            this.txtInfo4.Size = new System.Drawing.Size(76, 20);
            this.txtInfo4.TabIndex = 19;
            this.txtInfo4.Text = "txtInfo4";
            // 
            // lblInfo4
            // 
            this.lblInfo4.AutoSize = true;
            this.lblInfo4.Location = new System.Drawing.Point(10, 150);
            this.lblInfo4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo4.Name = "lblInfo4";
            this.lblInfo4.Size = new System.Drawing.Size(41, 13);
            this.lblInfo4.TabIndex = 15;
            this.lblInfo4.Text = "lblInfo4";
            // 
            // txtInfo3
            // 
            this.txtInfo3.Location = new System.Drawing.Point(108, 103);
            this.txtInfo3.Margin = new System.Windows.Forms.Padding(2);
            this.txtInfo3.Name = "txtInfo3";
            this.txtInfo3.Size = new System.Drawing.Size(76, 20);
            this.txtInfo3.TabIndex = 18;
            this.txtInfo3.Text = "txtInfo3";
            // 
            // txtInfo1
            // 
            this.txtInfo1.Location = new System.Drawing.Point(108, 18);
            this.txtInfo1.Margin = new System.Windows.Forms.Padding(2);
            this.txtInfo1.Name = "txtInfo1";
            this.txtInfo1.Size = new System.Drawing.Size(76, 20);
            this.txtInfo1.TabIndex = 16;
            this.txtInfo1.Text = "txtInfo1";
            // 
            // txtInfo2
            // 
            this.txtInfo2.Location = new System.Drawing.Point(108, 61);
            this.txtInfo2.Margin = new System.Windows.Forms.Padding(2);
            this.txtInfo2.Name = "txtInfo2";
            this.txtInfo2.Size = new System.Drawing.Size(76, 20);
            this.txtInfo2.TabIndex = 17;
            this.txtInfo2.Text = "txtInfo2";
            // 
            // btnInfoEnter
            // 
            this.btnInfoEnter.Location = new System.Drawing.Point(13, 360);
            this.btnInfoEnter.Name = "btnInfoEnter";
            this.btnInfoEnter.Size = new System.Drawing.Size(179, 35);
            this.btnInfoEnter.TabIndex = 20;
            this.btnInfoEnter.Text = "btnInfoEnter";
            this.btnInfoEnter.UseVisualStyleBackColor = true;
            this.btnInfoEnter.Click += new System.EventHandler(this.BtnInfoEnter_Click);
            // 
            // txtInfo5
            // 
            this.txtInfo5.Location = new System.Drawing.Point(108, 185);
            this.txtInfo5.Margin = new System.Windows.Forms.Padding(2);
            this.txtInfo5.Name = "txtInfo5";
            this.txtInfo5.Size = new System.Drawing.Size(76, 20);
            this.txtInfo5.TabIndex = 22;
            this.txtInfo5.Text = "txtInfo5";
            // 
            // lblInfo5
            // 
            this.lblInfo5.AutoSize = true;
            this.lblInfo5.Location = new System.Drawing.Point(10, 187);
            this.lblInfo5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo5.Name = "lblInfo5";
            this.lblInfo5.Size = new System.Drawing.Size(41, 13);
            this.lblInfo5.TabIndex = 21;
            this.lblInfo5.Text = "lblInfo5";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 436);
            this.Controls.Add(this.gBxRowInfo);
            this.Controls.Add(this.gBxSelectTable);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.gBxAdEdDe);
            this.Controls.Add(this.gBxSearchCriteria);
            this.Controls.Add(this.dgvMain);
            this.Name = "FormMain";
            this.Text = "Database Manager v1.7";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrument_DatabaseDataSet)).EndInit();
            this.gBxSearchCriteria.ResumeLayout(false);
            this.gBxSearchCriteria.PerformLayout();
            this.gBxAdEdDe.ResumeLayout(false);
            this.gBxSelectTable.ResumeLayout(false);
            this.gBxSelectTable.PerformLayout();
            this.gBxRowInfo.ResumeLayout(false);
            this.gBxRowInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gBxSearchCriteria;
        private System.Windows.Forms.RadioButton rBtSearch2;
        private System.Windows.Forms.RadioButton rBtSearch1;
        private System.Windows.Forms.RadioButton rBtSearch5;
        private System.Windows.Forms.RadioButton rBtSearch3;
        private System.Windows.Forms.RadioButton rBtSearch6;
        private System.Windows.Forms.RadioButton rBtSearch7;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rBtSearch4;
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
        private System.Windows.Forms.GroupBox gBxRowInfo;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Label lblInfo3;
        private System.Windows.Forms.TextBox txtInfo4;
        private System.Windows.Forms.Label lblInfo4;
        private System.Windows.Forms.TextBox txtInfo3;
        private System.Windows.Forms.TextBox txtInfo1;
        private System.Windows.Forms.TextBox txtInfo2;
        private System.Windows.Forms.RadioButton rBtSearch8;
        private System.Windows.Forms.Button btnInfoEnter;
        private System.Windows.Forms.TextBox txtInfo5;
        private System.Windows.Forms.Label lblInfo5;
    }
}

