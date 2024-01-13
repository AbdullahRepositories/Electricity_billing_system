namespace IP_Project
{
    partial class managerMain_frm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsReport = new System.Windows.Forms.ToolStripButton();
            this.tsUser = new System.Windows.Forms.ToolStripSplitButton();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEmployee = new System.Windows.Forms.ToolStripSplitButton();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPayroll = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.consumercomplaintUsercont1 = new IP_Project.consumercomplaintUsercont();
            this.homeUsercont1 = new IP_Project.homeUsercont();
            this.viewEmpUsercont1 = new IP_Project.viewEmpUsercont();
            this.viewConsuUsercont1 = new IP_Project.viewConsuUsercont();
            this.unitPriceUsercont1 = new IP_Project.unitPriceUsercont();
            this.billGenerate1 = new IP_Project.billGenerate();
            this.seachBillUserCont1 = new IP_Project.seachBillUserCont();
            this.addConsuUseControl1 = new IP_Project.addConsuUseControl();
            this.addEmpUsercont1 = new IP_Project.addEmpUsercont();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.rjButton3 = new CustomControls.RJControls.RJButton();
            this.homeUsercont2 = new IP_Project.homeUsercont();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.rjButton1);
            this.panel2.Controls.Add(this.rjButton2);
            this.panel2.Controls.Add(this.rjButton3);
            this.panel2.Location = new System.Drawing.Point(814, 660);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 82);
            this.panel2.TabIndex = 11;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 34);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsReport,
            this.tsUser,
            this.tsEmployee,
            this.tsPayroll,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(81, 536);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsReport
            // 
            this.tsReport.Enabled = false;
            this.tsReport.Image = global::IP_Project.Properties.Resources.icons8_view_64;
            this.tsReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsReport.Name = "tsReport";
            this.tsReport.Size = new System.Drawing.Size(78, 83);
            this.tsReport.Text = "Bill Search";
            this.tsReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsReport.Click += new System.EventHandler(this.tsReport_Click);
            // 
            // tsUser
            // 
            this.tsUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.viewCustomersToolStripMenuItem});
            this.tsUser.Image = global::IP_Project.Properties.Resources.usersIconc;
            this.tsUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUser.Margin = new System.Windows.Forms.Padding(0, 1, 0, 15);
            this.tsUser.Name = "tsUser";
            this.tsUser.Size = new System.Drawing.Size(78, 58);
            this.tsUser.Text = "Customers";
            this.tsUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsUser.ButtonClick += new System.EventHandler(this.tsUser_ButtonClick_1);
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // viewCustomersToolStripMenuItem
            // 
            this.viewCustomersToolStripMenuItem.Name = "viewCustomersToolStripMenuItem";
            this.viewCustomersToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.viewCustomersToolStripMenuItem.Text = "View Customers";
            this.viewCustomersToolStripMenuItem.Click += new System.EventHandler(this.viewCustomersToolStripMenuItem_Click);
            // 
            // tsEmployee
            // 
            this.tsEmployee.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEmployee.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.viewEmployeesToolStripMenuItem});
            this.tsEmployee.Enabled = false;
            this.tsEmployee.Image = global::IP_Project.Properties.Resources.empgroup;
            this.tsEmployee.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEmployee.Name = "tsEmployee";
            this.tsEmployee.Size = new System.Drawing.Size(78, 58);
            this.tsEmployee.Text = "toolStripSplitButton1";
            this.tsEmployee.ButtonClick += new System.EventHandler(this.tsEmployee_ButtonClick);
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // viewEmployeesToolStripMenuItem
            // 
            this.viewEmployeesToolStripMenuItem.Name = "viewEmployeesToolStripMenuItem";
            this.viewEmployeesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.viewEmployeesToolStripMenuItem.Text = "View Employees";
            this.viewEmployeesToolStripMenuItem.Click += new System.EventHandler(this.viewEmployeesToolStripMenuItem_Click);
            // 
            // tsPayroll
            // 
            this.tsPayroll.Enabled = false;
            this.tsPayroll.Image = global::IP_Project.Properties.Resources.icons8_invoice_64__1_;
            this.tsPayroll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsPayroll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPayroll.Name = "tsPayroll";
            this.tsPayroll.Size = new System.Drawing.Size(78, 83);
            this.tsPayroll.Text = "Generate Bill";
            this.tsPayroll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsPayroll.Click += new System.EventHandler(this.tsPayroll_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AccessibleDescription = "";
            this.toolStripButton1.AccessibleName = "";
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::IP_Project.Properties.Resources.icons8_tags_64;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(80, 80);
            this.toolStripButton1.Text = "Unit Prices";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::IP_Project.Properties.Resources.icons8_complaint_48__1_;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(78, 52);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(78, 15);
            this.toolStripLabel1.Text = "Complaints";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-274, -28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Customers";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.homeUsercont2);
            this.panel1.Controls.Add(this.consumercomplaintUsercont1);
            this.panel1.Controls.Add(this.homeUsercont1);
            this.panel1.Controls.Add(this.viewEmpUsercont1);
            this.panel1.Controls.Add(this.viewConsuUsercont1);
            this.panel1.Controls.Add(this.unitPriceUsercont1);
            this.panel1.Controls.Add(this.billGenerate1);
            this.panel1.Controls.Add(this.seachBillUserCont1);
            this.panel1.Controls.Add(this.addConsuUseControl1);
            this.panel1.Controls.Add(this.addEmpUsercont1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(81, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 536);
            this.panel1.TabIndex = 14;
            // 
            // consumercomplaintUsercont1
            // 
            this.consumercomplaintUsercont1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.consumercomplaintUsercont1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consumercomplaintUsercont1.Location = new System.Drawing.Point(0, 0);
            this.consumercomplaintUsercont1.Name = "consumercomplaintUsercont1";
            this.consumercomplaintUsercont1.Size = new System.Drawing.Size(996, 536);
            this.consumercomplaintUsercont1.TabIndex = 8;
            this.consumercomplaintUsercont1.Load += new System.EventHandler(this.consumercomplaintUsercont1_Load);
            // 
            // homeUsercont1
            // 
            this.homeUsercont1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(150)))), ((int)(((byte)(210)))));
            this.homeUsercont1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeUsercont1.Location = new System.Drawing.Point(0, 0);
            this.homeUsercont1.Name = "homeUsercont1";
            this.homeUsercont1.Size = new System.Drawing.Size(996, 536);
            this.homeUsercont1.TabIndex = 7;
            this.homeUsercont1.Load += new System.EventHandler(this.homeUsercont1_Load);
            // 
            // viewEmpUsercont1
            // 
            this.viewEmpUsercont1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.viewEmpUsercont1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewEmpUsercont1.Location = new System.Drawing.Point(0, 0);
            this.viewEmpUsercont1.Name = "viewEmpUsercont1";
            this.viewEmpUsercont1.Size = new System.Drawing.Size(996, 536);
            this.viewEmpUsercont1.TabIndex = 6;
            this.viewEmpUsercont1.Load += new System.EventHandler(this.viewEmpUsercont1_Load);
            // 
            // viewConsuUsercont1
            // 
            this.viewConsuUsercont1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewConsuUsercont1.Location = new System.Drawing.Point(0, 0);
            this.viewConsuUsercont1.Name = "viewConsuUsercont1";
            this.viewConsuUsercont1.Size = new System.Drawing.Size(996, 536);
            this.viewConsuUsercont1.TabIndex = 5;
            // 
            // unitPriceUsercont1
            // 
            this.unitPriceUsercont1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitPriceUsercont1.Location = new System.Drawing.Point(0, 0);
            this.unitPriceUsercont1.Name = "unitPriceUsercont1";
            this.unitPriceUsercont1.Size = new System.Drawing.Size(996, 536);
            this.unitPriceUsercont1.TabIndex = 4;
            // 
            // billGenerate1
            // 
            this.billGenerate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billGenerate1.Location = new System.Drawing.Point(0, 0);
            this.billGenerate1.Name = "billGenerate1";
            this.billGenerate1.present_reading = 0F;
            this.billGenerate1.Size = new System.Drawing.Size(996, 536);
            this.billGenerate1.TabIndex = 3;
            // 
            // seachBillUserCont1
            // 
            this.seachBillUserCont1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seachBillUserCont1.Location = new System.Drawing.Point(0, 0);
            this.seachBillUserCont1.Name = "seachBillUserCont1";
            this.seachBillUserCont1.Size = new System.Drawing.Size(996, 536);
            this.seachBillUserCont1.TabIndex = 2;
            // 
            // addConsuUseControl1
            // 
            this.addConsuUseControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addConsuUseControl1.Location = new System.Drawing.Point(0, 0);
            this.addConsuUseControl1.Name = "addConsuUseControl1";
            this.addConsuUseControl1.Size = new System.Drawing.Size(996, 536);
            this.addConsuUseControl1.TabIndex = 1;
            // 
            // addEmpUsercont1
            // 
            this.addEmpUsercont1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addEmpUsercont1.Location = new System.Drawing.Point(0, 0);
            this.addEmpUsercont1.Name = "addEmpUsercont1";
            this.addEmpUsercont1.Size = new System.Drawing.Size(996, 536);
            this.addEmpUsercont1.TabIndex = 0;
            this.addEmpUsercont1.Load += new System.EventHandler(this.addEmpUsercont1_Load);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.SlateBlue;
            this.rjButton1.BorderRadius = 15;
            this.rjButton1.BorderSize = 2;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(366, 15);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 40);
            this.rjButton1.TabIndex = 2;
            this.rjButton1.Text = "edit here";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BorderColor = System.Drawing.Color.SlateBlue;
            this.rjButton2.BorderRadius = 15;
            this.rjButton2.BorderSize = 2;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(210, 15);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(150, 40);
            this.rjButton2.TabIndex = 3;
            this.rjButton2.Text = "edit here";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton3.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton3.BorderColor = System.Drawing.Color.SlateBlue;
            this.rjButton3.BorderRadius = 15;
            this.rjButton3.BorderSize = 2;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(50, 15);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(150, 40);
            this.rjButton3.TabIndex = 4;
            this.rjButton3.Text = "edit here";
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            // 
            // homeUsercont2
            // 
            this.homeUsercont2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(150)))), ((int)(((byte)(210)))));
            this.homeUsercont2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeUsercont2.Location = new System.Drawing.Point(0, 0);
            this.homeUsercont2.Name = "homeUsercont2";
            this.homeUsercont2.Size = new System.Drawing.Size(996, 536);
            this.homeUsercont2.TabIndex = 9;
            // 
            // managerMain_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(150)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(1077, 536);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "managerMain_frm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "mainManager";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.managerMain_frm_FormClosing);
            this.Load += new System.EventHandler(this.managerMain_Load);
            this.panel2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton rjButton3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsReport;
        private System.Windows.Forms.ToolStripSplitButton tsUser;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsPayroll;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSplitButton tsEmployee;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Panel panel1;
        private addEmpUsercont addEmpUsercont1;
        private addConsuUseControl addConsuUseControl1;
        private seachBillUserCont seachBillUserCont1;
        private billGenerate billGenerate1;
        private unitPriceUsercont unitPriceUsercont1;
        private viewConsuUsercont viewConsuUsercont1;
        private viewEmpUsercont viewEmpUsercont1;
        private homeUsercont homeUsercont1;
        private consumercomplaintUsercont consumercomplaintUsercont1;
        private homeUsercont homeUsercont2;
    }
}