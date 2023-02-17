namespace CarServiceApp.UserControls
{
    partial class ServiceSearchAndEdit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUpdateService = new System.Windows.Forms.Button();
            this.inputServiceID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.inputCompanyID = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.inputSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputServicePrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputServiceName = new System.Windows.Forms.TextBox();
            this.dataGridViewService = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonUpdateService);
            this.panel1.Controls.Add(this.inputServiceID);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.inputServicePrice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.inputServiceName);
            this.panel1.Location = new System.Drawing.Point(70, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1307, 464);
            this.panel1.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 347);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "€";
            // 
            // buttonUpdateService
            // 
            this.buttonUpdateService.Location = new System.Drawing.Point(1078, 349);
            this.buttonUpdateService.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUpdateService.Name = "buttonUpdateService";
            this.buttonUpdateService.Size = new System.Drawing.Size(111, 46);
            this.buttonUpdateService.TabIndex = 16;
            this.buttonUpdateService.Text = "Update";
            this.buttonUpdateService.UseVisualStyleBackColor = true;
            this.buttonUpdateService.Click += new System.EventHandler(this.buttonUpdateService_Click);
            // 
            // inputServiceID
            // 
            this.inputServiceID.Enabled = false;
            this.inputServiceID.Location = new System.Drawing.Point(115, 177);
            this.inputServiceID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputServiceID.Name = "inputServiceID";
            this.inputServiceID.Size = new System.Drawing.Size(65, 26);
            this.inputServiceID.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panel3.Controls.Add(this.inputCompanyID);
            this.panel3.Controls.Add(this.buttonSearch);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.inputSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 92);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1307, 57);
            this.panel3.TabIndex = 18;
            // 
            // inputCompanyID
            // 
            this.inputCompanyID.Enabled = false;
            this.inputCompanyID.Location = new System.Drawing.Point(1209, 15);
            this.inputCompanyID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputCompanyID.Name = "inputCompanyID";
            this.inputCompanyID.Size = new System.Drawing.Size(65, 26);
            this.inputCompanyID.TabIndex = 21;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(391, 10);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(93, 35);
            this.buttonSearch.TabIndex = 20;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Search By ID";
            // 
            // inputSearch
            // 
            this.inputSearch.Location = new System.Drawing.Point(172, 14);
            this.inputSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Size = new System.Drawing.Size(200, 26);
            this.inputSearch.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1307, 92);
            this.panel2.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 29);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(342, 32);
            this.label8.TabIndex = 15;
            this.label8.Text = "Search and Edit Service";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 347);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            // 
            // inputServicePrice
            // 
            this.inputServicePrice.Location = new System.Drawing.Point(115, 344);
            this.inputServicePrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputServicePrice.Name = "inputServicePrice";
            this.inputServicePrice.Size = new System.Drawing.Size(65, 26);
            this.inputServicePrice.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 247);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // inputServiceName
            // 
            this.inputServiceName.Location = new System.Drawing.Point(115, 244);
            this.inputServiceName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputServiceName.Name = "inputServiceName";
            this.inputServiceName.Size = new System.Drawing.Size(218, 26);
            this.inputServiceName.TabIndex = 0;
            // 
            // dataGridViewService
            // 
            this.dataGridViewService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewService.Location = new System.Drawing.Point(70, 610);
            this.dataGridViewService.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewService.Name = "dataGridViewService";
            this.dataGridViewService.RowHeadersWidth = 62;
            this.dataGridViewService.Size = new System.Drawing.Size(1307, 429);
            this.dataGridViewService.TabIndex = 26;
            this.dataGridViewService.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewService_RowHeaderMouseDoubleClick);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(70, 554);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(111, 46);
            this.buttonRefresh.TabIndex = 27;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // ServiceSearchAndEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewService);
            this.Name = "ServiceSearchAndEdit";
            this.Size = new System.Drawing.Size(1446, 1094);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonUpdateService;
        private System.Windows.Forms.TextBox inputServiceID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox inputSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputServicePrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputServiceName;
        private System.Windows.Forms.DataGridView dataGridViewService;
        private System.Windows.Forms.TextBox inputCompanyID;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label label2;
    }
}
