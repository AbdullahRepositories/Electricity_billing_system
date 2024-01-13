namespace IP_Project
{
    partial class employeeMain_frm
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
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsUser = new System.Windows.Forms.ToolStripSplitButton();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPayroll = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.rjButton3 = new CustomControls.RJControls.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.viewConsuUsercont1 = new IP_Project.viewConsuUsercont();
            this.addConsuUseControl1 = new IP_Project.addConsuUseControl();
            this.billGenerate1 = new IP_Project.billGenerate();
            this.homeUsercont1 = new IP_Project.homeUsercont();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-358, -106);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Customers";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(180)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 34);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsUser,
            this.tsPayroll});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(78, 521);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsUser
            // 
            this.tsUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.viewCustomersToolStripMenuItem});
            this.tsUser.Enabled = false;
            this.tsUser.Image = global::IP_Project.Properties.Resources.usersIconc;
            this.tsUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUser.Margin = new System.Windows.Forms.Padding(0, 1, 0, 15);
            this.tsUser.Name = "tsUser";
            this.tsUser.Size = new System.Drawing.Size(75, 58);
            this.tsUser.Text = "Customers";
            this.tsUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsUser.ButtonClick += new System.EventHandler(this.tsUser_ButtonClick);
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
            // tsPayroll
            // 
            this.tsPayroll.Enabled = false;
            this.tsPayroll.Image = global::IP_Project.Properties.Resources.icons8_invoice_64__1_;
            this.tsPayroll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsPayroll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPayroll.Name = "tsPayroll";
            this.tsPayroll.Size = new System.Drawing.Size(75, 83);
            this.tsPayroll.Text = "Generate Bill";
            this.tsPayroll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsPayroll.Click += new System.EventHandler(this.tsPayroll_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.rjButton1);
            this.panel2.Controls.Add(this.rjButton2);
            this.panel2.Controls.Add(this.rjButton3);
            this.panel2.Location = new System.Drawing.Point(849, 545);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 82);
            this.panel2.TabIndex = 14;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.homeUsercont1);
            this.panel1.Controls.Add(this.viewConsuUsercont1);
            this.panel1.Controls.Add(this.addConsuUseControl1);
            this.panel1.Controls.Add(this.billGenerate1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(78, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 521);
            this.panel1.TabIndex = 17;
            // 
            // viewConsuUsercont1
            // 
            this.viewConsuUsercont1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewConsuUsercont1.Location = new System.Drawing.Point(0, 0);
            this.viewConsuUsercont1.Name = "viewConsuUsercont1";
            this.viewConsuUsercont1.Size = new System.Drawing.Size(951, 521);
            this.viewConsuUsercont1.TabIndex = 2;
            this.viewConsuUsercont1.Load += new System.EventHandler(this.viewConsuUsercont1_Load);
            // 
            // addConsuUseControl1
            // 
            this.addConsuUseControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addConsuUseControl1.Location = new System.Drawing.Point(0, 0);
            this.addConsuUseControl1.Name = "addConsuUseControl1";
            this.addConsuUseControl1.Size = new System.Drawing.Size(951, 521);
            this.addConsuUseControl1.TabIndex = 1;
            // 
            // billGenerate1
            // 
            this.billGenerate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billGenerate1.Location = new System.Drawing.Point(0, 0);
            this.billGenerate1.Name = "billGenerate1";
            this.billGenerate1.present_reading = 0F;
            this.billGenerate1.Size = new System.Drawing.Size(951, 521);
            this.billGenerate1.TabIndex = 0;
            // 
            // homeUsercont1
            // 
            this.homeUsercont1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(150)))), ((int)(((byte)(210)))));
            this.homeUsercont1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeUsercont1.Location = new System.Drawing.Point(0, 0);
            this.homeUsercont1.Name = "homeUsercont1";
            this.homeUsercont1.Size = new System.Drawing.Size(951, 521);
            this.homeUsercont1.TabIndex = 3;
            // 
            // employeeMain_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(150)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(1029, 521);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.Name = "employeeMain_frm";
            this.Text = "employeeMian_frm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.employeeMain_frm_FormClosing);
            this.Load += new System.EventHandler(this.employeeMian_frm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton rjButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton tsPayroll;
        private CustomControls.RJControls.RJButton rjButton2;
        private System.Windows.Forms.ToolStripMenuItem viewCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton tsUser;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private billGenerate billGenerate1;
        private addConsuUseControl addConsuUseControl1;
        private viewConsuUsercont viewConsuUsercont1;
        private homeUsercont homeUsercont1;
    }
}