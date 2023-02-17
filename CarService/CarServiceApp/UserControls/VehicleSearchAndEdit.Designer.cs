namespace CarServiceApp.UserControls
{
    partial class VehicleSearchAndEdit
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
            this.dataGridViewVehicle = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.inputCustomerSurname = new System.Windows.Forms.TextBox();
            this.inputCustomerName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.inputCustomerID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonUpdateVehicle = new System.Windows.Forms.Button();
            this.inputVehicleIsActive = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.inputVehicleID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.inputCompanyID = new System.Windows.Forms.TextBox();
            this.inputCustomerSince = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.inputSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputVehicleColour = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputVehicleModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputVehicleMake = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputVehiclePlate = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicle)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewVehicle
            // 
            this.dataGridViewVehicle.AllowUserToAddRows = false;
            this.dataGridViewVehicle.AllowUserToDeleteRows = false;
            this.dataGridViewVehicle.AllowUserToOrderColumns = true;
            this.dataGridViewVehicle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehicle.Location = new System.Drawing.Point(72, 613);
            this.dataGridViewVehicle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewVehicle.Name = "dataGridViewVehicle";
            this.dataGridViewVehicle.Size = new System.Drawing.Size(1306, 427);
            this.dataGridViewVehicle.TabIndex = 22;
            this.dataGridViewVehicle.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewVehicle_RowHeaderMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.inputCustomerSurname);
            this.panel1.Controls.Add(this.inputCustomerName);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.inputCustomerID);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.buttonUpdateVehicle);
            this.panel1.Controls.Add(this.inputVehicleIsActive);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.inputVehicleID);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.inputVehicleColour);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.inputVehicleModel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.inputVehicleMake);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.inputVehiclePlate);
            this.panel1.Location = new System.Drawing.Point(72, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1306, 503);
            this.panel1.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(706, 235);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(705, 275);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Surname";
            // 
            // inputCustomerSurname
            // 
            this.inputCustomerSurname.Enabled = false;
            this.inputCustomerSurname.Location = new System.Drawing.Point(788, 271);
            this.inputCustomerSurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputCustomerSurname.Name = "inputCustomerSurname";
            this.inputCustomerSurname.Size = new System.Drawing.Size(218, 26);
            this.inputCustomerSurname.TabIndex = 28;
            // 
            // inputCustomerName
            // 
            this.inputCustomerName.Enabled = false;
            this.inputCustomerName.Location = new System.Drawing.Point(788, 231);
            this.inputCustomerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputCustomerName.Name = "inputCustomerName";
            this.inputCustomerName.Size = new System.Drawing.Size(218, 26);
            this.inputCustomerName.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(675, 180);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Customer ID";
            // 
            // inputCustomerID
            // 
            this.inputCustomerID.Enabled = false;
            this.inputCustomerID.Location = new System.Drawing.Point(788, 177);
            this.inputCustomerID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputCustomerID.Name = "inputCustomerID";
            this.inputCustomerID.Size = new System.Drawing.Size(66, 26);
            this.inputCustomerID.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(152, 180);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Vehicle ID";
            // 
            // buttonUpdateVehicle
            // 
            this.buttonUpdateVehicle.Location = new System.Drawing.Point(1124, 409);
            this.buttonUpdateVehicle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUpdateVehicle.Name = "buttonUpdateVehicle";
            this.buttonUpdateVehicle.Size = new System.Drawing.Size(111, 46);
            this.buttonUpdateVehicle.TabIndex = 16;
            this.buttonUpdateVehicle.Text = "Update";
            this.buttonUpdateVehicle.UseVisualStyleBackColor = true;
            this.buttonUpdateVehicle.Click += new System.EventHandler(this.buttonUpdateVehicle_Click);
            // 
            // inputVehicleIsActive
            // 
            this.inputVehicleIsActive.AutoSize = true;
            this.inputVehicleIsActive.Location = new System.Drawing.Point(266, 423);
            this.inputVehicleIsActive.Name = "inputVehicleIsActive";
            this.inputVehicleIsActive.Size = new System.Drawing.Size(22, 21);
            this.inputVehicleIsActive.TabIndex = 22;
            this.inputVehicleIsActive.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(294, 422);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Active";
            // 
            // inputVehicleID
            // 
            this.inputVehicleID.Enabled = false;
            this.inputVehicleID.Location = new System.Drawing.Point(266, 177);
            this.inputVehicleID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputVehicleID.Name = "inputVehicleID";
            this.inputVehicleID.Size = new System.Drawing.Size(66, 26);
            this.inputVehicleID.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panel3.Controls.Add(this.buttonSearch);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.inputCompanyID);
            this.panel3.Controls.Add(this.inputCustomerSince);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.inputSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 92);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1306, 57);
            this.panel3.TabIndex = 18;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(384, 12);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(93, 35);
            this.buttonSearch.TabIndex = 20;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(894, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Customer Since";
            // 
            // inputCompanyID
            // 
            this.inputCompanyID.Enabled = false;
            this.inputCompanyID.Location = new System.Drawing.Point(1197, 15);
            this.inputCompanyID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputCompanyID.Name = "inputCompanyID";
            this.inputCompanyID.Size = new System.Drawing.Size(66, 26);
            this.inputCompanyID.TabIndex = 33;
            // 
            // inputCustomerSince
            // 
            this.inputCustomerSince.Enabled = false;
            this.inputCustomerSince.Location = new System.Drawing.Point(1024, 15);
            this.inputCustomerSince.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputCustomerSince.Name = "inputCustomerSince";
            this.inputCustomerSince.Size = new System.Drawing.Size(162, 26);
            this.inputCustomerSince.TabIndex = 30;
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
            this.panel2.Size = new System.Drawing.Size(1306, 92);
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
            this.label8.Text = "Search and Edit Vehicle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 374);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Colour";
            // 
            // inputVehicleColour
            // 
            this.inputVehicleColour.Location = new System.Drawing.Point(266, 369);
            this.inputVehicleColour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputVehicleColour.Name = "inputVehicleColour";
            this.inputVehicleColour.Size = new System.Drawing.Size(148, 26);
            this.inputVehicleColour.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 311);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Model";
            // 
            // inputVehicleModel
            // 
            this.inputVehicleModel.Location = new System.Drawing.Point(266, 305);
            this.inputVehicleModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputVehicleModel.Name = "inputVehicleModel";
            this.inputVehicleModel.Size = new System.Drawing.Size(218, 26);
            this.inputVehicleModel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 274);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Make";
            // 
            // inputVehicleMake
            // 
            this.inputVehicleMake.Location = new System.Drawing.Point(266, 269);
            this.inputVehicleMake.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputVehicleMake.Name = "inputVehicleMake";
            this.inputVehicleMake.Size = new System.Drawing.Size(218, 26);
            this.inputVehicleMake.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 234);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plate";
            // 
            // inputVehiclePlate
            // 
            this.inputVehiclePlate.Location = new System.Drawing.Point(266, 229);
            this.inputVehiclePlate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputVehiclePlate.Name = "inputVehiclePlate";
            this.inputVehiclePlate.Size = new System.Drawing.Size(218, 26);
            this.inputVehiclePlate.TabIndex = 0;
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
            // VehicleSearchAndEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewVehicle);
            this.Controls.Add(this.panel1);
            this.Name = "VehicleSearchAndEdit";
            this.Size = new System.Drawing.Size(1446, 1094);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVehicle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonUpdateVehicle;
        private System.Windows.Forms.CheckBox inputVehicleIsActive;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox inputVehicleID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox inputSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputVehicleColour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputVehicleModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputVehicleMake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputVehiclePlate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox inputCustomerID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputCustomerSince;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inputCustomerSurname;
        private System.Windows.Forms.TextBox inputCustomerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputCompanyID;
        private System.Windows.Forms.Button buttonRefresh;
    }
}
