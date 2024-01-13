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
    public partial class history : Form
    {
        public history()
        {
            InitializeComponent();
        }
        
        private void bill_do_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            button3.Enabled = false;
            viewBills("1");
        }

        private void history_Load(object sender, EventArgs e)
        {

        }


        private void bill_history_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            button3.Enabled = false;
            viewBills("0");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
            button3.Enabled = true;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button3.Enabled = true;
        }
     
        private void button3_Click(object sender, EventArgs e)
        {
            string billId = dataGridView2.CurrentRow.Cells[0].Value.ToString();

            //WebRequest request = WebRequest.Create("http://localhost:7882/ebill2/payBill_.php");
            //request.Method = "POST";// the method to send data
            //request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)
           
           
           
            //string postData = "id=" + billId ;

            //ASCIIEncoding enc = new ASCIIEncoding();
            //byte[] data = enc.GetBytes(postData);
            //Stream stream = request.GetRequestStream();
            //stream.Write(data, 0, data.Length);

            //WebResponse response = request.GetResponse();
            //Stream stream2 = response.GetResponseStream();
            //StreamReader sr = new StreamReader(stream2);


            string menuBreak =Operations.Put(URLs.Url["payBills"],billId);
            //MessageBox.Show(menuBreak);
            if (menuBreak!=String.Empty)
            {
                MessageBox.Show(menuBreak);
            }
            else
            {
                MessageBox.Show(menuBreak);
            }

            viewBills("1");
        }
        void viewBills(string statuss)
        {
            //WebRequest request = WebRequest.Create("http://localhost:7882/ebill2/viewbills_.php");
            //request.Method = "POST";// the method to send data
            //request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)
            //string user_id =userInfo.userId;
            //string status = statuss;
            //string postData = "id=" + user_id + "&status=" + status;

            //ASCIIEncoding enc = new ASCIIEncoding();
            //byte[] data = enc.GetBytes(postData);
            //Stream stream = request.GetRequestStream();
            //stream.Write(data, 0, data.Length);

            //WebResponse response = request.GetResponse();
            //Stream stream2 = response.GetResponseStream();
            //StreamReader sr = new StreamReader(stream2);

            string menuBreak = Operations.Get(URLs.Url["viewBills"], userInfo.userId,statuss);
            //MessageBox.Show(menuBreak);
            if (menuBreak != "Sorry, No bills in this for you"&& menuBreak != "No data enterd :(")
            {
                
                StringReader SR = new StringReader(menuBreak);
                DataSet ds = new DataSet();
                ds.ReadXml(SR);
                ds.Tables[0].TableName = "Bills";
                dataGridView2.DataSource = ds.Tables["Bills"];
            }
            else
            {
                if (statuss == "1") {
                    button3.Enabled = false;
                }
                    
               MessageBox.Show(menuBreak);
            }
        }
    }
}
