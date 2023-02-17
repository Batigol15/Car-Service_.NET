namespace CarServiceApp.UserControls
{
    partial class EmployeeAddNew
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resetSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSaveAddEmployee = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmployee.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(74, 573);
            this.dataGridViewEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.Size = new System.Drawing.Size(1299, 475);
            this.dataGridViewEmployee.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.resetSearch);
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
            this.panel1.Location = new System.Drawing.Point(74, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 500);
            this.panel1.TabIndex = 20;
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
            this.panel2.Controls.Add(this.buttonSaveAddEmployee);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 92);
            this.panel2.TabIndex = 16;
            // 
            // buttonSaveAddEmployee
            // 
            this.buttonSaveAddEmployee.Location = new System.Drawing.Point(513, 25);
            this.buttonSaveAddEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSaveAddEmployee.Name = "buttonSaveAddEmployee";
            this.buttonSaveAddEmployee.Size = new System.Drawing.Size(111, 46);
            this.buttonSaveAddEmployee.TabIndex = 16;
            this.buttonSaveAddEmployee.Text = "Save";
            this.buttonSaveAddEmployee.UseVisualStyleBackColor = true;
            this.buttonSaveAddEmployee.Click += new System.EventHandler(this.buttonSaveAddEmployee_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 29);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 32);
            this.label8.TabIndex = 15;
            this.label8.Text = "Add Employee";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 397);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Contact";
            // 
            // inputEmployeeContact
            // 
            this.inputEmployeeContact.Location = new System.Drawing.Point(124, 392);
            this.inputEmployeeContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputEmployeeContact.Name = "inputEmployeeContact";
            this.inputEmployeeContact.Size = new System.Drawing.Size(148, 26);
            this.inputEmployeeContact.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 340);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "OIB";
            // 
            // inputEmployeeOIB
            // 
            this.inputEmployeeOIB.Location = new System.Drawing.Point(124, 335);
            this.inputEmployeeOIB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputEmployeeOIB.Name = "inputEmployeeOIB";
            this.inputEmployeeOIB.Size = new System.Drawing.Size(218, 26);
            this.inputEmployeeOIB.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // inputEmployeePassword
            // 
            this.inputEmployeePassword.Location = new System.Drawing.Point(124, 237);
            this.inputEmployeePassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputEmployeePassword.Name = "inputEmployeePassword";
            this.inputEmployeePassword.Size = new System.Drawing.Size(218, 26);
            this.inputEmployeePassword.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname";
            // 
            // inputEmployeeSurname
            // 
            this.inputEmployeeSurname.Location = new System.Drawing.Point(124, 169);
            this.inputEmployeeSurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputEmployeeSurname.Name = "inputEmployeeSurname";
            this.inputEmployeeSurname.Size = new System.Drawing.Size(218, 26);
            this.inputEmployeeSurname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // inputEmployeeName
            // 
            this.inputEmployeeName.Location = new System.Drawing.Point(124, 129);
            this.inputEmployeeName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputEmployeeName.Name = "inputEmployeeName";
            this.inputEmployeeName.Size = new System.Drawing.Size(218, 26);
            this.inputEmployeeName.TabIndex = 0;
            // 
            // EmployeeAddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.dataGridViewEmployee);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeAddNew";
            this.Size = new System.Drawing.Size(1446, 1094);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button resetSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSaveAddEmployee;
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
    }
}
