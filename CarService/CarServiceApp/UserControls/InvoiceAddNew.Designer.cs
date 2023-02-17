namespace CarServiceApp.UserControls
{
    partial class InvoiceAddNew
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewInvoice = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resetSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSaveAddInvoice = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputTotalPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputWorkOrderID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewInvoice
            // 
            this.dataGridViewInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoice.Location = new System.Drawing.Point(74, 580);
            this.dataGridViewInvoice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewInvoice.Name = "dataGridViewInvoice";
            this.dataGridViewInvoice.RowHeadersWidth = 62;
            this.dataGridViewInvoice.Size = new System.Drawing.Size(1299, 475);
            this.dataGridViewInvoice.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.resetSearch);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.inputTotalPrice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.inputWorkOrderID);
            this.panel1.Location = new System.Drawing.Point(74, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 500);
            this.panel1.TabIndex = 27;
            // 
            // resetSearch
            // 
            this.resetSearch.Location = new System.Drawing.Point(531, 429);
            this.resetSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resetSearch.Name = "resetSearch";
            this.resetSearch.Size = new System.Drawing.Size(93, 35);
            this.resetSearch.TabIndex = 17;
            this.resetSearch.Text = "Reset";
            this.resetSearch.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.Controls.Add(this.buttonSaveAddInvoice);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 92);
            this.panel2.TabIndex = 16;
            // 
            // buttonSaveAddInvoice
            // 
            this.buttonSaveAddInvoice.Location = new System.Drawing.Point(513, 25);
            this.buttonSaveAddInvoice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSaveAddInvoice.Name = "buttonSaveAddInvoice";
            this.buttonSaveAddInvoice.Size = new System.Drawing.Size(111, 46);
            this.buttonSaveAddInvoice.TabIndex = 16;
            this.buttonSaveAddInvoice.Text = "Save";
            this.buttonSaveAddInvoice.UseVisualStyleBackColor = true;
            this.buttonSaveAddInvoice.Click += new System.EventHandler(this.buttonSaveAddInvoice_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 29);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 32);
            this.label8.TabIndex = 15;
            this.label8.Text = "Add Invoice";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total price";
            // 
            // inputTotalPrice
            // 
            this.inputTotalPrice.Location = new System.Drawing.Point(166, 200);
            this.inputTotalPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputTotalPrice.Name = "inputTotalPrice";
            this.inputTotalPrice.Size = new System.Drawing.Size(218, 26);
            this.inputTotalPrice.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Work order ID";
            // 
            // inputWorkOrderID
            // 
            this.inputWorkOrderID.Location = new System.Drawing.Point(166, 129);
            this.inputWorkOrderID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputWorkOrderID.Name = "inputWorkOrderID";
            this.inputWorkOrderID.Size = new System.Drawing.Size(218, 26);
            this.inputWorkOrderID.TabIndex = 0;
            // 
            // InvoiceAddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.dataGridViewInvoice);
            this.Controls.Add(this.panel1);
            this.Name = "InvoiceAddNew";
            this.Size = new System.Drawing.Size(1446, 1094);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInvoice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button resetSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSaveAddInvoice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputTotalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputWorkOrderID;
    }
}
