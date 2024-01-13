
namespace IP_Project
{
    partial class customercomplaint_frm
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
            this.complaints = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.send = new CustomControls.RJControls.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoUserControl1 = new IP_Project.logoUserControl();
            this.complaints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // complaints
            // 
            this.complaints.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.complaints.Controls.Add(this.dataGridView1);
            this.complaints.Location = new System.Drawing.Point(62, 123);
            this.complaints.Name = "complaints";
            this.complaints.Size = new System.Drawing.Size(664, 286);
            this.complaints.TabIndex = 0;
            this.complaints.TabStop = false;
            this.complaints.Text = "Complaint";
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
            // send
            // 
            this.send.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.send.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.send.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.send.BorderRadius = 20;
            this.send.BorderSize = 0;
            this.send.FlatAppearance.BorderSize = 0;
            this.send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send.ForeColor = System.Drawing.Color.White;
            this.send.Location = new System.Drawing.Point(62, 415);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(150, 40);
            this.send.TabIndex = 1;
            this.send.Text = "Add Complaint";
            this.send.TextColor = System.Drawing.Color.White;
            this.send.UseVisualStyleBackColor = false;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logoUserControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 117);
            this.panel1.TabIndex = 35;
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
            // customercomplaint_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(150)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(790, 470);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.complaints);
            this.Controls.Add(this.send);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "customercomplaint_frm";
            this.Text = "user_complaint";
            this.Load += new System.EventHandler(this.customercomplaint_frm_Load);
            this.complaints.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox complaints;
        private CustomControls.RJControls.RJButton send;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private logoUserControl logoUserControl1;
    }
}