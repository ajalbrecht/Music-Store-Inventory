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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gBxSearchCriteria = new System.Windows.Forms.GroupBox();
            this.rBtStock = new System.Windows.Forms.RadioButton();
            this.rBtBarcode = new System.Windows.Forms.RadioButton();
            this.rBtInstrument = new System.Windows.Forms.RadioButton();
            this.rBtStatus = new System.Windows.Forms.RadioButton();
            this.rBtCustomerName = new System.Windows.Forms.RadioButton();
            this.rBtCustomerID = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.rBtSerial = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gBxSearchCriteria.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(427, 239);
            this.dataGridView1.TabIndex = 9;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(13, 10);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(65, 13);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Search Box:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(16, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(135, 20);
            this.txtSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(16, 52);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 30);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // gBxSearchCriteria
            // 
            this.gBxSearchCriteria.Controls.Add(this.rBtSerial);
            this.gBxSearchCriteria.Controls.Add(this.rBtCustomerID);
            this.gBxSearchCriteria.Controls.Add(this.rBtCustomerName);
            this.gBxSearchCriteria.Controls.Add(this.rBtStatus);
            this.gBxSearchCriteria.Controls.Add(this.rBtInstrument);
            this.gBxSearchCriteria.Controls.Add(this.rBtBarcode);
            this.gBxSearchCriteria.Controls.Add(this.rBtStock);
            this.gBxSearchCriteria.Location = new System.Drawing.Point(156, 9);
            this.gBxSearchCriteria.Name = "gBxSearchCriteria";
            this.gBxSearchCriteria.Size = new System.Drawing.Size(283, 114);
            this.gBxSearchCriteria.TabIndex = 10;
            this.gBxSearchCriteria.TabStop = false;
            this.gBxSearchCriteria.Text = "Search Category:";
            // 
            // rBtStock
            // 
            this.rBtStock.AutoSize = true;
            this.rBtStock.Checked = true;
            this.rBtStock.Location = new System.Drawing.Point(7, 20);
            this.rBtStock.Name = "rBtStock";
            this.rBtStock.Size = new System.Drawing.Size(63, 17);
            this.rBtStock.TabIndex = 0;
            this.rBtStock.TabStop = true;
            this.rBtStock.Text = "Stock #";
            this.rBtStock.UseVisualStyleBackColor = true;
            // 
            // rBtBarcode
            // 
            this.rBtBarcode.AutoSize = true;
            this.rBtBarcode.Location = new System.Drawing.Point(7, 43);
            this.rBtBarcode.Name = "rBtBarcode";
            this.rBtBarcode.Size = new System.Drawing.Size(65, 17);
            this.rBtBarcode.TabIndex = 1;
            this.rBtBarcode.Text = "Barcode";
            this.rBtBarcode.UseVisualStyleBackColor = true;
            // 
            // rBtInstrument
            // 
            this.rBtInstrument.AutoSize = true;
            this.rBtInstrument.Location = new System.Drawing.Point(7, 66);
            this.rBtInstrument.Name = "rBtInstrument";
            this.rBtInstrument.Size = new System.Drawing.Size(74, 17);
            this.rBtInstrument.TabIndex = 2;
            this.rBtInstrument.Text = "Instrument";
            this.rBtInstrument.UseVisualStyleBackColor = true;
            // 
            // rBtStatus
            // 
            this.rBtStatus.AutoSize = true;
            this.rBtStatus.Location = new System.Drawing.Point(94, 20);
            this.rBtStatus.Name = "rBtStatus";
            this.rBtStatus.Size = new System.Drawing.Size(55, 17);
            this.rBtStatus.TabIndex = 3;
            this.rBtStatus.Text = "Status";
            this.rBtStatus.UseVisualStyleBackColor = true;
            // 
            // rBtCustomerName
            // 
            this.rBtCustomerName.AutoSize = true;
            this.rBtCustomerName.Location = new System.Drawing.Point(94, 66);
            this.rBtCustomerName.Name = "rBtCustomerName";
            this.rBtCustomerName.Size = new System.Drawing.Size(100, 17);
            this.rBtCustomerName.TabIndex = 4;
            this.rBtCustomerName.Text = "Customer Name";
            this.rBtCustomerName.UseVisualStyleBackColor = true;
            // 
            // rBtCustomerID
            // 
            this.rBtCustomerID.AutoSize = true;
            this.rBtCustomerID.Location = new System.Drawing.Point(94, 43);
            this.rBtCustomerID.Name = "rBtCustomerID";
            this.rBtCustomerID.Size = new System.Drawing.Size(83, 17);
            this.rBtCustomerID.TabIndex = 5;
            this.rBtCustomerID.Text = "Customer ID";
            this.rBtCustomerID.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(15, 88);
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
            this.rBtSerial.Location = new System.Drawing.Point(7, 89);
            this.rBtSerial.Name = "rBtSerial";
            this.rBtSerial.Size = new System.Drawing.Size(61, 17);
            this.rBtSerial.TabIndex = 6;
            this.rBtSerial.Text = "Serial #";
            this.rBtSerial.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 380);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gBxSearchCriteria);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Name = "FormMain";
            this.Text = "Database Manager";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gBxSearchCriteria.ResumeLayout(false);
            this.gBxSearchCriteria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSearch;
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
    }
}

