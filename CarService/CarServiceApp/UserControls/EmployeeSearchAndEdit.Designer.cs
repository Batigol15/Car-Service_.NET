namespace CarServiceApp.UserControls
{
    partial class EmployeeSearchAndEdit
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
            this.buttonUpdateEmployee = new System.Windows.Forms.Button();
            this.inputEmployeeIsActive = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.inputEmployeeID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.inputEmployeeSince = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.inputSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inputEmployeeContact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputEmployeeOIB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputEmployeePassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputEmployeeSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputEmployeeName = new System.Windows.Forms.TextBox();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.buttonUpdateEmployee);
            this.panel1.Controls.Add(this.inputEmployeeIsActive);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.inputEmployeeID);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.inputEmployeeContact);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.inputEmployeeOIB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.inputEmployeePassword);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.inputEmployeeSurname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.inputEmployeeName);
            this.panel1.Location = new System.Drawing.Point(70, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1307, 464);
            this.panel1.TabIndex = 23;
            // 
            // buttonUpdateEmployee
            // 
            this.buttonUpdateEmployee.Location = new System.Drawing.Point(1074, 349);
            this.buttonUpdateEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUpdateEmployee.Name = "buttonUpdateEmployee";
            this.buttonUpdateEmployee.Size = new System.Drawing.Size(111, 46);
            this.buttonUpdateEmployee.TabIndex = 16;
            this.buttonUpdateEmployee.Text = "Update";
            this.buttonUpdateEmployee.UseVisualStyleBackColor = true;
            this.buttonUpdateEmployee.Click += new System.EventHandler(this.buttonUpdateEmployee_Click);
            // 
            // inputEmployeeIsActive
            // 
            this.inputEmployeeIsActive.AutoSize = true;
            this.inputEmployeeIsActive.Location = new System.Drawing.Point(538, 374);
            this.inputEmployeeIsActive.Name = "inputEmployeeIsActive";
            this.inputEmployeeIsActive.Size = new System.Drawing.Size(22, 21);
            this.inputEmployeeIsActive.TabIndex = 22;
            this.inputEmployeeIsActive.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(475, 374);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Active";
            // 
            // inputEmployeeID
            // 
            this.inputEmployeeID.Enabled = false;
            this.inputEmployeeID.Location = new System.Drawing.Point(115, 177);
            this.inputEmployeeID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputEmployeeID.Name = "inputEmployeeID";
            this.inputEmployeeID.Size = new System.Drawing.Size(65, 26);
            this.inputEmployeeID.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.inputEmployeeSince);
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(944, 17);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Customer Since";
            // 
            // inputEmployeeSince
            // 
            this.inputEmployeeSince.Enabled = false;
            this.inputEmployeeSince.Location = new System.Drawing.Point(1074, 15);
            this.inputEmployeeSince.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputEmployeeSince.Name = "inputEmployeeSince";
            this.inputEmployeeSince.Size = new System.Drawing.Size(161, 26);
            this.inputEmployeeSince.TabIndex = 20;
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
            this.label8.Size = new System.Drawing.Size(375, 32);
            this.label8.TabIndex = 15;
            this.label8.Text = "Search and Edit Employee";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 304);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Contact";
            // 
            // inputEmployeeContact
            // 
            this.inputEmployeeContact.Location = new System.Drawing.Point(538, 299);
            this.inputEmployeeContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputEmployeeContact.Name = "inputEmployeeContact";
            this.inputEmployeeContact.Size = new System.Drawing.Size(148, 26);
            this.inputEmployeeContact.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 247);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "OIB";
            // 
            // inputEmployeeOIB
            // 
            this.inputEmployeeOIB.Location = new System.Drawing.Point(538, 243);
            this.inputEmployeeOIB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputEmployeeOIB.Name = "inputEmployeeOIB";
            this.inputEmployeeOIB.Size = new System.Drawing.Size(218, 26);
            this.inputEmployeeOIB.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 349);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // inputEmployeePassword
            // 
            this.inputEmployeePassword.Location = new System.Drawing.Point(115, 344);
            this.inputEmployeePassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputEmployeePassword.Name = "inputEmployeePassword";
            this.inputEmployeePassword.Size = new System.Drawing.Size(218, 26);
            this.inputEmployeePassword.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 289);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname";
            // 
            // inputEmployeeSurname
            // 
            this.inputEmployeeSurname.Location = new System.Drawing.Point(115, 284);
            this.inputEmployeeSurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputEmployeeSurname.Name = "inputEmployeeSurname";
            this.inputEmployeeSurname.Size = new System.Drawing.Size(218, 26);
            this.inputEmployeeSurname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 249);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // inputEmployeeName
            // 
            this.inputEmployeeName.Location = new System.Drawing.Point(115, 244);
            this.inputEmployeeName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputEmployeeName.Name = "inputEmployeeName";
            this.inputEmployeeName.Size = new System.Drawing.Size(218, 26);
            this.inputEmployeeName.TabIndex = 0;
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(70, 607);
            this.dataGridViewEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.RowHeadersWidth = 62;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(1307, 432);
            this.dataGridViewEmployee.TabIndex = 24;
            this.dataGridViewEmployee.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewEmployee_RowHeaderMouseDoubleClick);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(70, 551);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(111, 46);
            this.buttonRefresh.TabIndex = 23;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // EmployeeSearchAndEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewEmployee);
            this.Name = "EmployeeSearchAndEdit";
            this.Size = new System.Drawing.Size(1446, 1094);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonUpdateEmployee;
        private System.Windows.Forms.CheckBox inputEmployeeIsActive;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox inputEmployeeID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox inputEmployeeSince;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox inputSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputEmployeeContact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputEmployeeOIB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputEmployeePassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputEmployeeSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputEmployeeName;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.Button buttonRefresh;
    }
}
