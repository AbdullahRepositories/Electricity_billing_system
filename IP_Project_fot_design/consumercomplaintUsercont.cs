using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_Project
{
    public partial class consumercomplaintUsercont : UserControl
    {
        public consumercomplaintUsercont()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void consumercomplaintUsercont_Load(object sender, EventArgs e)
        {
            

        }
        private void addComplainButton_Click(object sender, EventArgs e)
        {
            complaintText_frm ob = new complaintText_frm();
            ob.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void view_complaints()
        {
            string postData;
            string result = "";
            if (userInfo.userRole == "admin")
            {
                addComplainButton.Visible = false;
                rjButton1.Visible = false;
                postData = "id=-1";
                result = Operations.Get(URLs.Url["customerComplaint"], postData);

            }
            else
            {
                postData = "id=" + userInfo.userId;
                result = Operations.Get(URLs.Url["customerComplaint"], postData);
            }
            // MessageBox.Show(result);
            if (!result.Contains("Sorry, you have not add any complaints sir!") && !result.Contains("No data enterd :(") && !result.Contains("Sorry, The Id could not be figured"))
            {
                StringReader SR = new StringReader(result);
                DataSet ds = new DataSet();
                ds.ReadXml(SR);
                ds.Tables[0].TableName = "Bills";
                dataGridView1.DataSource = ds.Tables["Bills"];


            }
            else
            {
                MessageBox.Show(result);
            }
        }

        public void rjButton1_Click(object sender, EventArgs e)
        {
            
            view_complaints();
        }
    }
}
