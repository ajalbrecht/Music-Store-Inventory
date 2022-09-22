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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gBxSearchCriteria.SuspendLayout();
            this.gBxAdEdDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(7, 49);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(146, 27);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(146, 27);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 380);
            this.Controls.Add(this.gBxAdEdDe);
            this.Controls.Add(this.gBxSearchCriteria);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormMain";
            this.Text = "Database Manager";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gBxSearchCriteria.ResumeLayout(false);
            this.gBxSearchCriteria.PerformLayout();
            this.gBxAdEdDe.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}

