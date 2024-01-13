namespace IP_Project
{
    partial class unitPriceUsercont
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.unitPrice_textBox = new System.Windows.Forms.TextBox();
            this.submitUnitPrice_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoUserControl1 = new IP_Project.logoUserControl();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.unitPrice_textBox);
            this.groupBox1.Controls.Add(this.submitUnitPrice_btn);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(133, 195);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(335, 131);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unit Price Configration";
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleName = "Unit Type";
            this.comboBox1.AllowDrop = true;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Commercial",
            "Government"});
            this.comboBox1.Location = new System.Drawing.Point(164, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // unitPrice_textBox
            // 
            this.unitPrice_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPrice_textBox.Location = new System.Drawing.Point(67, 42);
            this.unitPrice_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.unitPrice_textBox.Name = "unitPrice_textBox";
            this.unitPrice_textBox.Size = new System.Drawing.Size(92, 23);
            this.unitPrice_textBox.TabIndex = 4;
            // 
            // submitUnitPrice_btn
            // 
            this.submitUnitPrice_btn.Location = new System.Drawing.Point(136, 70);
            this.submitUnitPrice_btn.Margin = new System.Windows.Forms.Padding(2);
            this.submitUnitPrice_btn.Name = "submitUnitPrice_btn";
            this.submitUnitPrice_btn.Size = new System.Drawing.Size(56, 19);
            this.submitUnitPrice_btn.TabIndex = 3;
            this.submitUnitPrice_btn.Text = "Edit";
            this.submitUnitPrice_btn.UseVisualStyleBackColor = true;
            this.submitUnitPrice_btn.Click += new System.EventHandler(this.submitUnitPrice_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logoUserControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 117);
            this.panel1.TabIndex = 25;
            // 
            // logoUserControl1
            // 
            this.logoUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.logoUserControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoUserControl1.Location = new System.Drawing.Point(0, 0);
            this.logoUserControl1.Name = "logoUserControl1";
            this.logoUserControl1.Size = new System.Drawing.Size(162, 117);
            this.logoUserControl1.TabIndex = 0;
            // 
            // unitPriceUsercont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "unitPriceUsercont";
            this.Size = new System.Drawing.Size(600, 366);
            this.Load += new System.EventHandler(this.unitPriceUsercont_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox unitPrice_textBox;
        private System.Windows.Forms.Button submitUnitPrice_btn;
        private System.Windows.Forms.Panel panel1;
        private logoUserControl logoUserControl1;
    }
}
