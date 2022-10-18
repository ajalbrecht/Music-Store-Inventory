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
            this.rBtSerial = new System.Windows.Forms.RadioButton();
            this.rBtCustomerID = new System.Windows.Forms.RadioButton();
            this.rBtCustomerName = new System.Windows.Forms.RadioButton();
            this.rBtStatus = new System.Windows.Forms.RadioButton();
            this.rBtInstrument = new System.Windows.Forms.RadioButton();
            this.rBtBarcode = new System.Windows.Forms.RadioButton();
            this.rBtStock = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gBxSearchCriteria.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 159);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(569, 294);
            this.dataGridView1.TabIndex = 9;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(17, 12);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(79, 16);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Search Box:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(21, 32);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(179, 22);
            this.txtSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(21, 64);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(180, 37);
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
            this.gBxSearchCriteria.Location = new System.Drawing.Point(208, 11);
            this.gBxSearchCriteria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBxSearchCriteria.Name = "gBxSearchCriteria";
            this.gBxSearchCriteria.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBxSearchCriteria.Size = new System.Drawing.Size(377, 140);
            this.gBxSearchCriteria.TabIndex = 10;
            this.gBxSearchCriteria.TabStop = false;
            this.gBxSearchCriteria.Text = "Search Category:";
            // 
            // rBtSerial
            // 
            this.rBtSerial.AutoSize = true;
            this.rBtSerial.Location = new System.Drawing.Point(9, 110);
            this.rBtSerial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBtSerial.Name = "rBtSerial";
            this.rBtSerial.Size = new System.Drawing.Size(73, 20);
            this.rBtSerial.TabIndex = 6;
            this.rBtSerial.Text = "Serial #";
            this.rBtSerial.UseVisualStyleBackColor = true;
            // 
            // rBtCustomerID
            // 
            this.rBtCustomerID.AutoSize = true;
            this.rBtCustomerID.Location = new System.Drawing.Point(125, 53);
            this.rBtCustomerID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBtCustomerID.Name = "rBtCustomerID";
            this.rBtCustomerID.Size = new System.Drawing.Size(101, 20);
            this.rBtCustomerID.TabIndex = 5;
            this.rBtCustomerID.Text = "Customer ID";
            this.rBtCustomerID.UseVisualStyleBackColor = true;
            // 
            // rBtCustomerName
            // 
            this.rBtCustomerName.AutoSize = true;
            this.rBtCustomerName.Location = new System.Drawing.Point(125, 81);
            this.rBtCustomerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBtCustomerName.Name = "rBtCustomerName";
            this.rBtCustomerName.Size = new System.Drawing.Size(125, 20);
            this.rBtCustomerName.TabIndex = 4;
            this.rBtCustomerName.Text = "Customer Name";
            this.rBtCustomerName.UseVisualStyleBackColor = true;
            // 
            // rBtStatus
            // 
            this.rBtStatus.AutoSize = true;
            this.rBtStatus.Location = new System.Drawing.Point(125, 25);
            this.rBtStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBtStatus.Name = "rBtStatus";
            this.rBtStatus.Size = new System.Drawing.Size(65, 20);
            this.rBtStatus.TabIndex = 3;
            this.rBtStatus.Text = "Status";
            this.rBtStatus.UseVisualStyleBackColor = true;
            // 
            // rBtInstrument
            // 
            this.rBtInstrument.AutoSize = true;
            this.rBtInstrument.Location = new System.Drawing.Point(9, 81);
            this.rBtInstrument.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBtInstrument.Name = "rBtInstrument";
            this.rBtInstrument.Size = new System.Drawing.Size(88, 20);
            this.rBtInstrument.TabIndex = 2;
            this.rBtInstrument.Text = "Instrument";
            this.rBtInstrument.UseVisualStyleBackColor = true;
            // 
            // rBtBarcode
            // 
            this.rBtBarcode.AutoSize = true;
            this.rBtBarcode.Location = new System.Drawing.Point(9, 53);
            this.rBtBarcode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBtBarcode.Name = "rBtBarcode";
            this.rBtBarcode.Size = new System.Drawing.Size(80, 20);
            this.rBtBarcode.TabIndex = 1;
            this.rBtBarcode.Text = "Barcode";
            this.rBtBarcode.UseVisualStyleBackColor = true;
            // 
            // rBtStock
            // 
            this.rBtStock.AutoSize = true;
            this.rBtStock.Checked = true;
            this.rBtStock.Location = new System.Drawing.Point(9, 25);
            this.rBtStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBtStock.Name = "rBtStock";
            this.rBtStock.Size = new System.Drawing.Size(72, 20);
            this.rBtStock.TabIndex = 0;
            this.rBtStock.TabStop = true;
            this.rBtStock.Text = "Stock #";
            this.rBtStock.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(20, 108);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 37);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 468);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gBxSearchCriteria);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

