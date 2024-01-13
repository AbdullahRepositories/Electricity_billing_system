namespace IP_Project
{
    partial class historyUserCont
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.unpayedButton1 = new CustomControls.RJControls.RJButton();
            this.payedButton1 = new CustomControls.RJControls.RJButton();
            this.payButton1 = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(31, 169);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Red;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(839, 224);
            this.dataGridView2.TabIndex = 5;
            // 
            // unpayedButton1
            // 
            this.unpayedButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.unpayedButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.unpayedButton1.BorderColor = System.Drawing.Color.SlateBlue;
            this.unpayedButton1.BorderRadius = 15;
            this.unpayedButton1.BorderSize = 2;
            this.unpayedButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.unpayedButton1.FlatAppearance.BorderSize = 0;
            this.unpayedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unpayedButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unpayedButton1.ForeColor = System.Drawing.Color.White;
            this.unpayedButton1.Location = new System.Drawing.Point(605, 80);
            this.unpayedButton1.Name = "unpayedButton1";
            this.unpayedButton1.Size = new System.Drawing.Size(177, 70);
            this.unpayedButton1.TabIndex = 47;
            this.unpayedButton1.Text = "Unpayed Bills";
            this.unpayedButton1.TextColor = System.Drawing.Color.White;
            this.unpayedButton1.UseVisualStyleBackColor = false;
            this.unpayedButton1.Click += new System.EventHandler(this.generateButton1_Click);
            // 
            // payedButton1
            // 
            this.payedButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.payedButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.payedButton1.BorderColor = System.Drawing.Color.SlateBlue;
            this.payedButton1.BorderRadius = 15;
            this.payedButton1.BorderSize = 2;
            this.payedButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.payedButton1.FlatAppearance.BorderSize = 0;
            this.payedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payedButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payedButton1.ForeColor = System.Drawing.Color.White;
            this.payedButton1.Location = new System.Drawing.Point(120, 80);
            this.payedButton1.Name = "payedButton1";
            this.payedButton1.Size = new System.Drawing.Size(177, 70);
            this.payedButton1.TabIndex = 48;
            this.payedButton1.Text = "Payed Bills";
            this.payedButton1.TextColor = System.Drawing.Color.White;
            this.payedButton1.UseVisualStyleBackColor = false;
            this.payedButton1.Click += new System.EventHandler(this.payedButton1_Click);
            // 
            // payButton1
            // 
            this.payButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.payButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.payButton1.BorderColor = System.Drawing.Color.SlateBlue;
            this.payButton1.BorderRadius = 15;
            this.payButton1.BorderSize = 2;
            this.payButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.payButton1.FlatAppearance.BorderSize = 0;
            this.payButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payButton1.ForeColor = System.Drawing.Color.White;
            this.payButton1.Location = new System.Drawing.Point(360, 416);
            this.payButton1.Name = "payButton1";
            this.payButton1.Size = new System.Drawing.Size(177, 70);
            this.payButton1.TabIndex = 49;
            this.payButton1.Text = "Pay";
            this.payButton1.TextColor = System.Drawing.Color.White;
            this.payButton1.UseVisualStyleBackColor = false;
            this.payButton1.Click += new System.EventHandler(this.payButton1_Click);
            // 
            // historyUserCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.payButton1);
            this.Controls.Add(this.payedButton1);
            this.Controls.Add(this.unpayedButton1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "historyUserCont";
            this.Size = new System.Drawing.Size(900, 549);
            this.Load += new System.EventHandler(this.historyUserCont_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private CustomControls.RJControls.RJButton unpayedButton1;
        private CustomControls.RJControls.RJButton payedButton1;
        private CustomControls.RJControls.RJButton payButton1;
    }
}
