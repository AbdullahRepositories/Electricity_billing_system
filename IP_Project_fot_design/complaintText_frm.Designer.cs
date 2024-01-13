
namespace IP_Project
{
    partial class complaintText_frm
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
            this.send = new CustomControls.RJControls.RJButton();
            this.cancel = new CustomControls.RJControls.RJButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.send.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.send.BorderColor = System.Drawing.Color.SlateBlue;
            this.send.BorderRadius = 15;
            this.send.BorderSize = 2;
            this.send.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.send.FlatAppearance.BorderSize = 0;
            this.send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send.ForeColor = System.Drawing.Color.White;
            this.send.Location = new System.Drawing.Point(12, 291);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(120, 45);
            this.send.TabIndex = 13;
            this.send.Text = "Send";
            this.send.TextColor = System.Drawing.Color.White;
            this.send.UseVisualStyleBackColor = false;
            this.send.Click += new System.EventHandler(this.reset_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cancel.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.cancel.BorderColor = System.Drawing.Color.SlateBlue;
            this.cancel.BorderRadius = 15;
            this.cancel.BorderSize = 2;
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(264, 291);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(120, 45);
            this.cancel.TabIndex = 15;
            this.cancel.Text = "cancel";
            this.cancel.TextColor = System.Drawing.Color.White;
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(364, 255);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // complaintText_frm
            // 
            this.AcceptButton = this.send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(150)))), ((int)(((byte)(210)))));
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(396, 367);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.send);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "complaintText_frm";
            this.Text = "signup";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.RJControls.RJButton send;
        private CustomControls.RJControls.RJButton cancel;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}