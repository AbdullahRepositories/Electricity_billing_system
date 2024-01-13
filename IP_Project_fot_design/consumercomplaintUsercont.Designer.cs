namespace IP_Project
{
    partial class consumercomplaintUsercont
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoUserControl1 = new IP_Project.logoUserControl();
            this.complaints = new System.Windows.Forms.GroupBox();
            this.addComplainButton = new CustomControls.RJControls.RJButton();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.complaints.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(658, 267);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logoUserControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 117);
            this.panel1.TabIndex = 38;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // logoUserControl1
            // 
            this.logoUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.logoUserControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoUserControl1.Location = new System.Drawing.Point(0, 0);
            this.logoUserControl1.Name = "logoUserControl1";
            this.logoUserControl1.Size = new System.Drawing.Size(165, 116);
            this.logoUserControl1.TabIndex = 0;
            // 
            // complaints
            // 
            this.complaints.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.complaints.Controls.Add(this.dataGridView1);
            this.complaints.Location = new System.Drawing.Point(62, 131);
            this.complaints.Name = "complaints";
            this.complaints.Size = new System.Drawing.Size(664, 286);
            this.complaints.TabIndex = 36;
            this.complaints.TabStop = false;
            this.complaints.Text = "Complaint";
            // 
            // addComplainButton
            // 
            this.addComplainButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.addComplainButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.addComplainButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addComplainButton.BorderRadius = 20;
            this.addComplainButton.BorderSize = 0;
            this.addComplainButton.FlatAppearance.BorderSize = 0;
            this.addComplainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addComplainButton.ForeColor = System.Drawing.Color.White;
            this.addComplainButton.Location = new System.Drawing.Point(62, 423);
            this.addComplainButton.Name = "addComplainButton";
            this.addComplainButton.Size = new System.Drawing.Size(150, 40);
            this.addComplainButton.TabIndex = 37;
            this.addComplainButton.Text = "Add Complaint";
            this.addComplainButton.TextColor = System.Drawing.Color.White;
            this.addComplainButton.UseVisualStyleBackColor = false;
            this.addComplainButton.Click += new System.EventHandler(this.addComplainButton_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(326, 423);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 40);
            this.rjButton1.TabIndex = 39;
            this.rjButton1.Text = "Show Complaints";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // consumercomplaintUsercont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.complaints);
            this.Controls.Add(this.addComplainButton);
            this.Name = "consumercomplaintUsercont";
            this.Size = new System.Drawing.Size(790, 470);
            this.Load += new System.EventHandler(this.consumercomplaintUsercont_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.complaints.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private logoUserControl logoUserControl1;
        private System.Windows.Forms.GroupBox complaints;
        private CustomControls.RJControls.RJButton addComplainButton;
        private CustomControls.RJControls.RJButton rjButton1;
    }
}
