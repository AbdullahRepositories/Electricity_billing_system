
namespace IP_Project
{
    partial class EmployeeMain
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
            this.side_panel = new System.Windows.Forms.Panel();
            this.complaints = new System.Windows.Forms.Button();
            this.payment = new System.Windows.Forms.Button();
            this.billManagement = new System.Windows.Forms.Button();
            this.userAccount = new System.Windows.Forms.Button();
            this.top_side_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.side_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // side_panel
            // 
            this.side_panel.BackColor = System.Drawing.Color.DimGray;
            this.side_panel.Controls.Add(this.complaints);
            this.side_panel.Controls.Add(this.payment);
            this.side_panel.Controls.Add(this.billManagement);
            this.side_panel.Controls.Add(this.userAccount);
            this.side_panel.Controls.Add(this.top_side_panel);
            this.side_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.side_panel.Location = new System.Drawing.Point(0, 0);
            this.side_panel.Margin = new System.Windows.Forms.Padding(4);
            this.side_panel.Name = "side_panel";
            this.side_panel.Size = new System.Drawing.Size(234, 716);
            this.side_panel.TabIndex = 0;
            // 
            // complaints
            // 
            this.complaints.BackColor = System.Drawing.Color.DimGray;
            this.complaints.FlatAppearance.BorderSize = 0;
            this.complaints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.complaints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complaints.Location = new System.Drawing.Point(0, 352);
            this.complaints.Margin = new System.Windows.Forms.Padding(4);
            this.complaints.Name = "complaints";
            this.complaints.Size = new System.Drawing.Size(234, 68);
            this.complaints.TabIndex = 5;
            this.complaints.Text = "Complaints";
            this.complaints.UseVisualStyleBackColor = false;
            // 
            // payment
            // 
            this.payment.BackColor = System.Drawing.Color.DimGray;
            this.payment.FlatAppearance.BorderSize = 0;
            this.payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment.Location = new System.Drawing.Point(0, 276);
            this.payment.Margin = new System.Windows.Forms.Padding(4);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(234, 68);
            this.payment.TabIndex = 4;
            this.payment.Text = "Pay Off";
            this.payment.UseVisualStyleBackColor = false;
            // 
            // billManagement
            // 
            this.billManagement.BackColor = System.Drawing.Color.DimGray;
            this.billManagement.FlatAppearance.BorderSize = 0;
            this.billManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billManagement.Location = new System.Drawing.Point(0, 199);
            this.billManagement.Margin = new System.Windows.Forms.Padding(4);
            this.billManagement.Name = "billManagement";
            this.billManagement.Size = new System.Drawing.Size(234, 68);
            this.billManagement.TabIndex = 3;
            this.billManagement.Text = "Bill Managemet";
            this.billManagement.UseVisualStyleBackColor = false;
            this.billManagement.Click += new System.EventHandler(this.billManagement_Click);
            // 
            // userAccount
            // 
            this.userAccount.BackColor = System.Drawing.Color.DimGray;
            this.userAccount.FlatAppearance.BorderSize = 0;
            this.userAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAccount.Location = new System.Drawing.Point(0, 123);
            this.userAccount.Margin = new System.Windows.Forms.Padding(4);
            this.userAccount.Name = "userAccount";
            this.userAccount.Size = new System.Drawing.Size(234, 68);
            this.userAccount.TabIndex = 2;
            this.userAccount.Text = "create user account";
            this.userAccount.UseVisualStyleBackColor = false;
            this.userAccount.Click += new System.EventHandler(this.account_Click);
            // 
            // top_side_panel
            // 
            this.top_side_panel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.top_side_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_side_panel.Location = new System.Drawing.Point(0, 0);
            this.top_side_panel.Margin = new System.Windows.Forms.Padding(4);
            this.top_side_panel.Name = "top_side_panel";
            this.top_side_panel.Size = new System.Drawing.Size(234, 115);
            this.top_side_panel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(234, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 111);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // EmployeeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1064, 716);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.side_panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeMain";
            this.Text = "employeeMain";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.side_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel side_panel;
        private System.Windows.Forms.Panel top_side_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button userAccount;
        private System.Windows.Forms.Button complaints;
        private System.Windows.Forms.Button payment;
        private System.Windows.Forms.Button billManagement;
    }
}