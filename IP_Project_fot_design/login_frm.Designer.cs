
namespace IP_Project
{
    partial class login_frm
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
            this.user_email = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.user_email_login = new test.control.custom_txtbox();
            this.password_login = new test.control.custom_txtbox();
            this.login = new CustomControls.RJControls.RJButton();
            this.panel_login = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // user_email
            // 
            this.user_email.AutoSize = true;
            this.user_email.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_email.ForeColor = System.Drawing.Color.White;
            this.user_email.Location = new System.Drawing.Point(-4, 292);
            this.user_email.Name = "user_email";
            this.user_email.Size = new System.Drawing.Size(119, 21);
            this.user_email.TabIndex = 0;
            this.user_email.Text = "user_email";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Location = new System.Drawing.Point(12, 327);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(101, 21);
            this.password.TabIndex = 2;
            this.password.Text = "password";
            // 
            // user_email_login
            // 
            this.user_email_login.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.user_email_login.BorderFocusColor = System.Drawing.Color.SlateBlue;
            this.user_email_login.BorderSize = 2;
            this.user_email_login.Location = new System.Drawing.Point(111, 285);
            this.user_email_login.Multiline = false;
            this.user_email_login.Name = "user_email_login";
            this.user_email_login.Padding = new System.Windows.Forms.Padding(7);
            this.user_email_login.PasswordChar = false;
            this.user_email_login.Size = new System.Drawing.Size(250, 28);
            this.user_email_login.TabIndex = 7;
            this.user_email_login.Texts = "";
            this.user_email_login.UnderlinedStyle = true;
            // 
            // password_login
            // 
            this.password_login.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.password_login.BorderFocusColor = System.Drawing.Color.SlateBlue;
            this.password_login.BorderSize = 2;
            this.password_login.Location = new System.Drawing.Point(111, 319);
            this.password_login.Multiline = false;
            this.password_login.Name = "password_login";
            this.password_login.Padding = new System.Windows.Forms.Padding(7);
            this.password_login.PasswordChar = true;
            this.password_login.Size = new System.Drawing.Size(250, 28);
            this.password_login.TabIndex = 8;
            this.password_login.Texts = "";
            this.password_login.UnderlinedStyle = true;
            this.password_login.Load += new System.EventHandler(this.password_login_Load);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.login.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.login.BorderColor = System.Drawing.Color.SlateBlue;
            this.login.BorderRadius = 15;
            this.login.BorderSize = 2;
            this.login.FlatAppearance.BorderSize = 0;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Lucida Handwriting", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(114, 441);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(150, 40);
            this.login.TabIndex = 9;
            this.login.Text = "login";
            this.login.TextColor = System.Drawing.Color.White;
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click_1);
            // 
            // panel_login
            // 
            this.panel_login.BackgroundImage = global::IP_Project.Properties.Resources.images__2_;
            this.panel_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_login.Location = new System.Drawing.Point(0, 0);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(377, 279);
            this.panel_login.TabIndex = 5;
            this.panel_login.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_login_Paint);
            // 
            // login_frm
            // 
            this.AcceptButton = this.login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(150)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(376, 493);
            this.Controls.Add(this.login);
            this.Controls.Add(this.password_login);
            this.Controls.Add(this.user_email_login);
            this.Controls.Add(this.panel_login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user_email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "login_frm";
            this.Text = "login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user_email;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Panel panel_login;
        private test.control.custom_txtbox user_email_login;
        private test.control.custom_txtbox password_login;
        private CustomControls.RJControls.RJButton login;
    }
}

