namespace CarServiceApp.UserControls
{
    partial class ServiceAddNew
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
            this.dataGridViewService = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.resetSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSaveAddService = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputServicePrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputServiceName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewService
            // 
            this.dataGridViewService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewService.Location = new System.Drawing.Point(74, 580);
            this.dataGridViewService.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewService.Name = "dataGridViewService";
            this.dataGridViewService.RowHeadersWidth = 62;
            this.dataGridViewService.Size = new System.Drawing.Size(1299, 475);
            this.dataGridViewService.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.resetSearch);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.inputServicePrice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.inputServiceName);
            this.panel1.Location = new System.Drawing.Point(74, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 500);
            this.panel1.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "€";
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
            this.panel2.Controls.Add(this.buttonSaveAddService);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 92);
            this.panel2.TabIndex = 16;
            // 
            // buttonSaveAddService
            // 
            this.buttonSaveAddService.Location = new System.Drawing.Point(513, 25);
            this.buttonSaveAddService.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSaveAddService.Name = "buttonSaveAddService";
            this.buttonSaveAddService.Size = new System.Drawing.Size(111, 46);
            this.buttonSaveAddService.TabIndex = 16;
            this.buttonSaveAddService.Text = "Save";
            this.buttonSaveAddService.UseVisualStyleBackColor = true;
            this.buttonSaveAddService.Click += new System.EventHandler(this.buttonSaveAddService_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 29);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 32);
            this.label8.TabIndex = 15;
            this.label8.Text = "Add Service";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price";
            // 
            // inputServicePrice
            // 
            this.inputServicePrice.Location = new System.Drawing.Point(145, 223);
            this.inputServicePrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputServicePrice.Name = "inputServicePrice";
            this.inputServicePrice.Size = new System.Drawing.Size(69, 26);
            this.inputServicePrice.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Service Name";
            // 
            // inputServiceName
            // 
            this.inputServiceName.Location = new System.Drawing.Point(145, 152);
            this.inputServiceName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputServiceName.Name = "inputServiceName";
            this.inputServiceName.Size = new System.Drawing.Size(218, 26);
            this.inputServiceName.TabIndex = 0;
            // 
            // ServiceAddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.dataGridViewService);
            this.Controls.Add(this.panel1);
            this.Name = "ServiceAddNew";
            this.Size = new System.Drawing.Size(1446, 1094);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewService;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button resetSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSaveAddService;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputServicePrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputServiceName;
        private System.Windows.Forms.Label label2;
    }
}
