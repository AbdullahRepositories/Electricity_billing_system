namespace IP_Project
{
    partial class customerMain_frm
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
            this.tsMyBills = new System.Windows.Forms.ToolStripButton();
            this.tsMyComplaints = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.rjButton3 = new CustomControls.RJControls.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.homeUsercont1 = new IP_Project.homeUsercont();
            this.historyUserCont1 = new IP_Project.historyUserCont();
            this.consumercomplaintUsercont1 = new IP_Project.consumercomplaintUsercont();
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
            this.label1.TabIndex = 19;
            this.label1.Text = "Customers";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(180)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 34);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMyBills,
            this.tsMyComplaints,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(69, 521);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsMyBills
            // 
            this.tsMyBills.Enabled = false;
            this.tsMyBills.Image = global::IP_Project.Properties.Resources.icons8_bill_64__1_;
            this.tsMyBills.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsMyBills.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMyBills.Name = "tsMyBills";
            this.tsMyBills.Size = new System.Drawing.Size(66, 83);
            this.tsMyBills.Text = "MyBills";
            this.tsMyBills.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsMyBills.Click += new System.EventHandler(this.tsPayroll_Click);
            // 
            // tsMyComplaints
            // 
            this.tsMyComplaints.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsMyComplaints.Enabled = false;
            this.tsMyComplaints.Image = global::IP_Project.Properties.Resources.icons8_complaint_48__1_;
            this.tsMyComplaints.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsMyComplaints.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMyComplaints.Name = "tsMyComplaints";
            this.tsMyComplaints.Size = new System.Drawing.Size(66, 52);
            this.tsMyComplaints.Text = "toolStripButton1";
            this.tsMyComplaints.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(66, 15);
            this.toolStripLabel2.Text = "Complaints";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.rjButton1);
            this.panel2.Controls.Add(this.rjButton2);
            this.panel2.Controls.Add(this.rjButton3);
            this.panel2.Location = new System.Drawing.Point(850, 545);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 82);
            this.panel2.TabIndex = 17;
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
            this.panel1.Controls.Add(this.historyUserCont1);
            this.panel1.Controls.Add(this.consumercomplaintUsercont1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(69, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 521);
            this.panel1.TabIndex = 20;
            // 
            // homeUsercont1
            // 
            this.homeUsercont1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.homeUsercont1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeUsercont1.Location = new System.Drawing.Point(0, 0);
            this.homeUsercont1.Name = "homeUsercont1";
            this.homeUsercont1.Size = new System.Drawing.Size(960, 521);
            this.homeUsercont1.TabIndex = 2;
            this.homeUsercont1.Load += new System.EventHandler(this.homeUsercont1_Load);
            // 
            // historyUserCont1
            // 
            this.historyUserCont1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyUserCont1.Location = new System.Drawing.Point(0, 0);
            this.historyUserCont1.Name = "historyUserCont1";
            this.historyUserCont1.Size = new System.Drawing.Size(960, 521);
            this.historyUserCont1.TabIndex = 1;
            // 
            // consumercomplaintUsercont1
            // 
            this.consumercomplaintUsercont1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.consumercomplaintUsercont1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consumercomplaintUsercont1.Location = new System.Drawing.Point(0, 0);
            this.consumercomplaintUsercont1.Name = "consumercomplaintUsercont1";
            this.consumercomplaintUsercont1.Size = new System.Drawing.Size(960, 521);
            this.consumercomplaintUsercont1.TabIndex = 0;
            // 
            // customerMain_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(150)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(1029, 521);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.Name = "customerMain_frm";
            this.Text = "customerMain_frm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.customerMain_frm_FormClosing);
            this.Load += new System.EventHandler(this.customerMain_frm_Load);
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
        private CustomControls.RJControls.RJButton rjButton2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsMyBills;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripButton tsMyComplaints;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Panel panel1;
        private consumercomplaintUsercont consumercomplaintUsercont1;
        private historyUserCont historyUserCont1;
        private homeUsercont homeUsercont1;
    }
}