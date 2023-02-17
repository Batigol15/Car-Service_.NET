namespace CarServiceApp.UserControls
{
    partial class WorkOrderAddNew
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonResetWorkOrder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCreateWorkOrder = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputVehicleID = new System.Windows.Forms.TextBox();
            this.inputVehicleKm = new System.Windows.Forms.TextBox();
            this.dataGridViewWorkOrder = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.inputEmployeeID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonResetServices = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonAddService = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inputServiceID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.inputWorkOrderID = new System.Windows.Forms.TextBox();
            this.dataGridViewWorkOrderDetailed = new System.Windows.Forms.DataGridView();
            this.buttonRefreshWorkOrder = new System.Windows.Forms.Button();
            this.buttonRefreshWorkOrderDetailed = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkOrder)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkOrderDetailed)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonResetWorkOrder
            // 
            this.buttonResetWorkOrder.Location = new System.Drawing.Point(342, 147);
            this.buttonResetWorkOrder.Name = "buttonResetWorkOrder";
            this.buttonResetWorkOrder.Size = new System.Drawing.Size(62, 23);
            this.buttonResetWorkOrder.TabIndex = 17;
            this.buttonResetWorkOrder.Text = "Reset";
            this.buttonResetWorkOrder.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.Controls.Add(this.buttonCreateWorkOrder);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 60);
            this.panel2.TabIndex = 16;
            // 
            // buttonCreateWorkOrder
            // 
            this.buttonCreateWorkOrder.Location = new System.Drawing.Point(342, 16);
            this.buttonCreateWorkOrder.Name = "buttonCreateWorkOrder";
            this.buttonCreateWorkOrder.Size = new System.Drawing.Size(74, 30);
            this.buttonCreateWorkOrder.TabIndex = 16;
            this.buttonCreateWorkOrder.Text = "Create";
            this.buttonCreateWorkOrder.UseVisualStyleBackColor = true;
            this.buttonCreateWorkOrder.Click += new System.EventHandler(this.buttonCreateWorkOrder_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Add New Work Order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vehicle Km";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vehicle ID";
            // 
            // inputVehicleID
            // 
            this.inputVehicleID.Location = new System.Drawing.Point(101, 110);
            this.inputVehicleID.Name = "inputVehicleID";
            this.inputVehicleID.Size = new System.Drawing.Size(59, 20);
            this.inputVehicleID.TabIndex = 2;
            // 
            // inputVehicleKm
            // 
            this.inputVehicleKm.Location = new System.Drawing.Point(101, 154);
            this.inputVehicleKm.Name = "inputVehicleKm";
            this.inputVehicleKm.Size = new System.Drawing.Size(82, 20);
            this.inputVehicleKm.TabIndex = 4;
            // 
            // dataGridViewWorkOrder
            // 
            this.dataGridViewWorkOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWorkOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewWorkOrder.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewWorkOrder.Location = new System.Drawing.Point(49, 280);
            this.dataGridViewWorkOrder.Name = "dataGridViewWorkOrder";
            this.dataGridViewWorkOrder.Size = new System.Drawing.Size(866, 163);
            this.dataGridViewWorkOrder.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee ID";
            // 
            // inputEmployeeID
            // 
            this.inputEmployeeID.Location = new System.Drawing.Point(101, 84);
            this.inputEmployeeID.Name = "inputEmployeeID";
            this.inputEmployeeID.Size = new System.Drawing.Size(59, 20);
            this.inputEmployeeID.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.buttonResetWorkOrder);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.inputVehicleKm);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.inputVehicleID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.inputEmployeeID);
            this.panel1.Location = new System.Drawing.Point(49, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 200);
            this.panel1.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.panel3.Controls.Add(this.buttonResetServices);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.inputQuantity);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.inputServiceID);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.inputWorkOrderID);
            this.panel3.Location = new System.Drawing.Point(489, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(434, 200);
            this.panel3.TabIndex = 21;
            // 
            // buttonResetServices
            // 
            this.buttonResetServices.Location = new System.Drawing.Point(342, 147);
            this.buttonResetServices.Name = "buttonResetServices";
            this.buttonResetServices.Size = new System.Drawing.Size(62, 23);
            this.buttonResetServices.TabIndex = 17;
            this.buttonResetServices.Text = "Reset";
            this.buttonResetServices.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SandyBrown;
            this.panel4.Controls.Add(this.buttonAddService);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(434, 60);
            this.panel4.TabIndex = 16;
            // 
            // buttonAddService
            // 
            this.buttonAddService.Location = new System.Drawing.Point(342, 16);
            this.buttonAddService.Name = "buttonAddService";
            this.buttonAddService.Size = new System.Drawing.Size(74, 30);
            this.buttonAddService.TabIndex = 16;
            this.buttonAddService.Text = "Add";
            this.buttonAddService.UseVisualStyleBackColor = true;
            this.buttonAddService.Click += new System.EventHandler(this.buttonAddService_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Work Order Services";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quantity";
            // 
            // inputQuantity
            // 
            this.inputQuantity.Location = new System.Drawing.Point(110, 149);
            this.inputQuantity.Name = "inputQuantity";
            this.inputQuantity.Size = new System.Drawing.Size(59, 20);
            this.inputQuantity.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Service ID";
            // 
            // inputServiceID
            // 
            this.inputServiceID.Location = new System.Drawing.Point(110, 110);
            this.inputServiceID.Name = "inputServiceID";
            this.inputServiceID.Size = new System.Drawing.Size(59, 20);
            this.inputServiceID.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Work Order ID";
            // 
            // inputWorkOrderID
            // 
            this.inputWorkOrderID.Location = new System.Drawing.Point(110, 84);
            this.inputWorkOrderID.Name = "inputWorkOrderID";
            this.inputWorkOrderID.Size = new System.Drawing.Size(59, 20);
            this.inputWorkOrderID.TabIndex = 0;
            // 
            // dataGridViewWorkOrderDetailed
            // 
            this.dataGridViewWorkOrderDetailed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWorkOrderDetailed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewWorkOrderDetailed.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewWorkOrderDetailed.Location = new System.Drawing.Point(49, 488);
            this.dataGridViewWorkOrderDetailed.Name = "dataGridViewWorkOrderDetailed";
            this.dataGridViewWorkOrderDetailed.Size = new System.Drawing.Size(866, 190);
            this.dataGridViewWorkOrderDetailed.TabIndex = 23;
            // 
            // buttonRefreshWorkOrder
            // 
            this.buttonRefreshWorkOrder.Location = new System.Drawing.Point(49, 244);
            this.buttonRefreshWorkOrder.Name = "buttonRefreshWorkOrder";
            this.buttonRefreshWorkOrder.Size = new System.Drawing.Size(74, 30);
            this.buttonRefreshWorkOrder.TabIndex = 24;
            this.buttonRefreshWorkOrder.Text = "Refresh";
            this.buttonRefreshWorkOrder.UseVisualStyleBackColor = true;
            this.buttonRefreshWorkOrder.Click += new System.EventHandler(this.buttonRefreshWorkOrder_Click);
            // 
            // buttonRefreshWorkOrderDetailed
            // 
            this.buttonRefreshWorkOrderDetailed.Location = new System.Drawing.Point(49, 452);
            this.buttonRefreshWorkOrderDetailed.Name = "buttonRefreshWorkOrderDetailed";
            this.buttonRefreshWorkOrderDetailed.Size = new System.Drawing.Size(74, 30);
            this.buttonRefreshWorkOrderDetailed.TabIndex = 25;
            this.buttonRefreshWorkOrderDetailed.Text = "Refresh";
            this.buttonRefreshWorkOrderDetailed.UseVisualStyleBackColor = true;
            this.buttonRefreshWorkOrderDetailed.Click += new System.EventHandler(this.buttonRefreshWorkOrderDetailed_Click);
            // 
            // WorkOrderAddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.buttonRefreshWorkOrderDetailed);
            this.Controls.Add(this.buttonRefreshWorkOrder);
            this.Controls.Add(this.dataGridViewWorkOrderDetailed);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridViewWorkOrder);
            this.Controls.Add(this.panel1);
            this.Name = "WorkOrderAddNew";
            this.Size = new System.Drawing.Size(964, 711);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkOrder)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkOrderDetailed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonResetWorkOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonCreateWorkOrder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputVehicleID;
        private System.Windows.Forms.TextBox inputVehicleKm;
        private System.Windows.Forms.DataGridView dataGridViewWorkOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputEmployeeID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonResetServices;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonAddService;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputServiceID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inputWorkOrderID;
        private System.Windows.Forms.DataGridView dataGridViewWorkOrderDetailed;
        private System.Windows.Forms.Button buttonRefreshWorkOrder;
        private System.Windows.Forms.Button buttonRefreshWorkOrderDetailed;
    }
}
