namespace CarServiceApp.UserControls
{
    partial class CustomerSearchAndEdit
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
            this.buttonUpdateCustomer = new System.Windows.Forms.Button();
            this.inputCustomerIsActive = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.inputCustomerID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.inputCompanyID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.inputCustomerSince = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.inputSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDeleteCustomer = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.inputCustomerEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inputCustomerContact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputCustomerOIB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputCustomerCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputCustomerAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputCustomerSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputCustomerName = new System.Windows.Forms.TextBox();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.buttonUpdateCustomer);
            this.panel1.Controls.Add(this.inputCustomerIsActive);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.inputCustomerID);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.inputCustomerEmail);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.inputCustomerContact);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.inputCustomerOIB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.inputCustomerCity);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.inputCustomerAddress);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.inputCustomerSurname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.inputCustomerName);
            this.panel1.Location = new System.Drawing.Point(72, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1306, 482);
            this.panel1.TabIndex = 1;
            // 
            // buttonUpdateCustomer
            // 
            this.buttonUpdateCustomer.Location = new System.Drawing.Point(1107, 375);
            this.buttonUpdateCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUpdateCustomer.Name = "buttonUpdateCustomer";
            this.buttonUpdateCustomer.Size = new System.Drawing.Size(111, 46);
            this.buttonUpdateCustomer.TabIndex = 16;
            this.buttonUpdateCustomer.Text = "Update";
            this.buttonUpdateCustomer.UseVisualStyleBackColor = true;
            this.buttonUpdateCustomer.Click += new System.EventHandler(this.buttonUpdateCustomer_Click);
            // 
            // inputCustomerIsActive
            // 
            this.inputCustomerIsActive.AutoSize = true;
            this.inputCustomerIsActive.Location = new System.Drawing.Point(662, 418);
            this.inputCustomerIsActive.Name = "inputCustomerIsActive";
            this.inputCustomerIsActive.Size = new System.Drawing.Size(22, 21);
            this.inputCustomerIsActive.TabIndex = 22;
            this.inputCustomerIsActive.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(598, 418);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Active";
            // 
            // inputCustomerID
            // 
            this.inputCustomerID.Enabled = false;
            this.inputCustomerID.Location = new System.Drawing.Point(256, 175);
            this.inputCustomerID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputCustomerID.Name = "inputCustomerID";
            this.inputCustomerID.Size = new System.Drawing.Size(66, 26);
            this.inputCustomerID.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panel3.Controls.Add(this.inputCompanyID);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.inputCustomerSince);
            this.panel3.Controls.Add(this.buttonSearch);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.inputSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 92);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1306, 57);
            this.panel3.TabIndex = 18;
            // 
            // inputCompanyID
            // 
            this.inputCompanyID.Enabled = false;
            this.inputCompanyID.Location = new System.Drawing.Point(1198, 15);
            this.inputCompanyID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputCompanyID.Name = "inputCompanyID";
            this.inputCompanyID.Size = new System.Drawing.Size(66, 26);
            this.inputCompanyID.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(896, 17);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Customer Since";
            // 
            // inputCustomerSince
            // 
            this.inputCustomerSince.Enabled = false;
            this.inputCustomerSince.Location = new System.Drawing.Point(1026, 15);
            this.inputCustomerSince.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputCustomerSince.Name = "inputCustomerSince";
            this.inputCustomerSince.Size = new System.Drawing.Size(162, 26);
            this.inputCustomerSince.TabIndex = 20;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(384, 11);
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
            this.panel2.Controls.Add(this.buttonDeleteCustomer);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1306, 92);
            this.panel2.TabIndex = 16;
            // 
            // buttonDeleteCustomer
            // 
            this.buttonDeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteCustomer.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonDeleteCustomer.Location = new System.Drawing.Point(1088, 26);
            this.buttonDeleteCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            this.buttonDeleteCustomer.Size = new System.Drawing.Size(164, 46);
            this.buttonDeleteCustomer.TabIndex = 23;
            this.buttonDeleteCustomer.Text = "DELETE";
            this.buttonDeleteCustomer.UseVisualStyleBackColor = true;
            this.buttonDeleteCustomer.Click += new System.EventHandler(this.buttonDeleteCustomer_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 29);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(370, 32);
            this.label8.TabIndex = 15;
            this.label8.Text = "Search and Edit Customer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(596, 343);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email";
            // 
            // inputCustomerEmail
            // 
            this.inputCustomerEmail.Location = new System.Drawing.Point(680, 337);
            this.inputCustomerEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputCustomerEmail.Name = "inputCustomerEmail";
            this.inputCustomerEmail.Size = new System.Drawing.Size(218, 26);
            this.inputCustomerEmail.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(596, 303);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Contact";
            // 
            // inputCustomerContact
            // 
            this.inputCustomerContact.Location = new System.Drawing.Point(680, 297);
            this.inputCustomerContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputCustomerContact.Name = "inputCustomerContact";
            this.inputCustomerContact.Size = new System.Drawing.Size(148, 26);
            this.inputCustomerContact.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(596, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "OIB";
            // 
            // inputCustomerOIB
            // 
            this.inputCustomerOIB.Location = new System.Drawing.Point(680, 242);
            this.inputCustomerOIB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputCustomerOIB.Name = "inputCustomerOIB";
            this.inputCustomerOIB.Size = new System.Drawing.Size(218, 26);
            this.inputCustomerOIB.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 388);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "City";
            // 
            // inputCustomerCity
            // 
            this.inputCustomerCity.Location = new System.Drawing.Point(256, 383);
            this.inputCustomerCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputCustomerCity.Name = "inputCustomerCity";
            this.inputCustomerCity.Size = new System.Drawing.Size(148, 26);
            this.inputCustomerCity.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 348);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address";
            // 
            // inputCustomerAddress
            // 
            this.inputCustomerAddress.Location = new System.Drawing.Point(256, 343);
            this.inputCustomerAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputCustomerAddress.Name = "inputCustomerAddress";
            this.inputCustomerAddress.Size = new System.Drawing.Size(218, 26);
            this.inputCustomerAddress.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 288);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname";
            // 
            // inputCustomerSurname
            // 
            this.inputCustomerSurname.Location = new System.Drawing.Point(256, 283);
            this.inputCustomerSurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputCustomerSurname.Name = "inputCustomerSurname";
            this.inputCustomerSurname.Size = new System.Drawing.Size(218, 26);
            this.inputCustomerSurname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 248);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // inputCustomerName
            // 
            this.inputCustomerName.Location = new System.Drawing.Point(256, 243);
            this.inputCustomerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputCustomerName.Name = "inputCustomerName";
            this.inputCustomerName.Size = new System.Drawing.Size(218, 26);
            this.inputCustomerName.TabIndex = 0;
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AllowUserToAddRows = false;
            this.dataGridViewCustomer.AllowUserToDeleteRows = false;
            this.dataGridViewCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(72, 613);
            this.dataGridViewCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.Size = new System.Drawing.Size(1306, 417);
            this.dataGridViewCustomer.TabIndex = 20;
            this.dataGridViewCustomer.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCustomer_RowHeaderMouseDoubleClick);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(72, 557);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(111, 46);
            this.buttonRefresh.TabIndex = 24;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // CustomerSearchAndEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewCustomer);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerSearchAndEdit";
            this.Size = new System.Drawing.Size(1446, 1094);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonUpdateCustomer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inputCustomerEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputCustomerContact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputCustomerOIB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputCustomerCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputCustomerAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputCustomerSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputCustomerName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox inputSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.TextBox inputCustomerID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox inputCustomerSince;
        private System.Windows.Forms.CheckBox inputCustomerIsActive;
        private System.Windows.Forms.Button buttonDeleteCustomer;
        private System.Windows.Forms.TextBox inputCompanyID;
        private System.Windows.Forms.Button buttonRefresh;
    }
}
