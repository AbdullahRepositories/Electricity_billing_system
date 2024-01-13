using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_Project
{
    public partial class searchBill_frm : Form
    {
        public searchBill_frm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user_id = textBox1.Text;
            //WebRequest request = WebRequest.Create("http://localhost:7882/ebill2/searchBill_(2).php");
            //request.Method = "POST";// the method to send data
            //request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)
            //string user_id = textBox1.Text;
            ////string status = "0";
            //string postData = "id=" + user_id;//+ "&status=" + status;

            //ASCIIEncoding enc = new ASCIIEncoding();
            //byte[] data = enc.GetBytes(postData);
            //Stream stream = request.GetRequestStream();
            //stream.Write(data, 0, data.Length);

            //WebResponse response = request.GetResponse();
            //Stream stream2 = response.GetResponseStream();
            //StreamReader sr = new StreamReader(stream2);

            string menuBreak =Operations.Get(URLs.Url["searchBill"],user_id) ;
            //MessageBox.Show(menuBreak);
            if (menuBreak != "Sorry, No user with this Id" && menuBreak != "No data enterd :(" && menuBreak != "sorry, invalide id format")
            {
                StringReader SR = new StringReader(menuBreak);
                DataSet ds = new DataSet();
                ds.ReadXml(SR);
                ds.Tables[0].TableName = "Bills";
                dataGridView1.DataSource = ds.Tables["Bills"];


            }
            else
            {
                MessageBox.Show(menuBreak);
            }
        }

        private void searchBill_frm_Load(object sender, EventArgs e)
        {
            //this.BackColor = Color.FromArgb(100,101,102);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
