namespace IP_Project
{
    partial class seachBillUserCont
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
            this.searchConstxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchConsButton1 = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(783, 229);
            this.dataGridView1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logoUserControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 125);
            this.panel1.TabIndex = 13;
            // 
            // logoUserControl1
            // 
            this.logoUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.logoUserControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoUserControl1.Location = new System.Drawing.Point(0, 0);
            this.logoUserControl1.Name = "logoUserControl1";
            this.logoUserControl1.Size = new System.Drawing.Size(163, 122);
            this.logoUserControl1.TabIndex = 0;
            // 
            // searchConstxtbox
            // 
            this.searchConstxtbox.Location = new System.Drawing.Point(127, 171);
            this.searchConstxtbox.Name = "searchConstxtbox";
            this.searchConstxtbox.Size = new System.Drawing.Size(100, 20);
            this.searchConstxtbox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Customer Id";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 262);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consumer Infomation";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // searchConsButton1
            // 
            this.searchConsButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.searchConsButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.searchConsButton1.BorderColor = System.Drawing.Color.SlateBlue;
            this.searchConsButton1.BorderRadius = 15;
            this.searchConsButton1.BorderSize = 2;
            this.searchConsButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.searchConsButton1.FlatAppearance.BorderSize = 0;
            this.searchConsButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchConsButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchConsButton1.ForeColor = System.Drawing.Color.White;
            this.searchConsButton1.Location = new System.Drawing.Point(249, 162);
            this.searchConsButton1.Name = "searchConsButton1";
            this.searchConsButton1.Size = new System.Drawing.Size(130, 31);
            this.searchConsButton1.TabIndex = 50;
            this.searchConsButton1.Text = "Search";
            this.searchConsButton1.TextColor = System.Drawing.Color.White;
            this.searchConsButton1.UseVisualStyleBackColor = false;
            this.searchConsButton1.Click += new System.EventHandler(this.searchConsButton1_Click);
            // 
            // seachBillUserCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchConsButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchConstxtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "seachBillUserCont";
            this.Size = new System.Drawing.Size(846, 496);
            this.Load += new System.EventHandler(this.seachBillUserCont_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private logoUserControl logoUserControl1;
        private System.Windows.Forms.TextBox searchConstxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private CustomControls.RJControls.RJButton searchConsButton1;
    }
}
