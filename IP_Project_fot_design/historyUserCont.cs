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
using IP_Project.LogSingleton;

namespace IP_Project
{
    public partial class historyUserCont : UserControl
    {
        private Log _Log;
        public historyUserCont()
        {
            _Log = Log.GetInstance;
            InitializeComponent();
        }
        string postData;
        private void historyUserCont_Load(object sender, EventArgs e)
        {
            payButton1.Visible = false;
            payButton1.Enabled = false;
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            payButton1.Enabled = true;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            payButton1.Enabled = true;
        }
        private void payedButton_Click(object sender, EventArgs e)
        {
            payButton1.Visible = false;
            payButton1.Enabled = false;
            viewBills("0");
            // logger_proxy.LogginDetails("logging.txt", "select");
            _Log.LogginDetails("logging.txt", "select");

        }

        private void unpayedButton_Click(object sender, EventArgs e)
        {
            payButton1.Visible = true;
            payButton1.Enabled = true;
            viewBills("1");
            //logger_proxy.LogginDetails("logging.txt", "select");
        }

        private void payButton_Click(object sender, EventArgs e)
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

            postData = "id=" + billId;

            string result = Operations.Get(URLs.Url["payBills"], postData);
            //MessageBox.Show(result);
            if (result != String.Empty)
            {
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show(result); 
                _Log.LogginDetails("logging.txt", "update");

            }

            viewBills("1");
            //logger_proxy.LogginDetails("logging.txt", "update");
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
            postData = "id=" + userInfo.userId + "&status=" + statuss;
            string result = Operations.Get(URLs.Url["viewBills"], postData);
            //MessageBox.Show(result);
            if (!result.Contains("Sorry, No bills in this for you") && !result.Contains("No data enterd :(") && result!=String.Empty)
            {

                StringReader SR = new StringReader(result);
                DataSet ds = new DataSet();
                ds.ReadXml(SR);
                ds.Tables[0].TableName = "Bills";
                dataGridView2.DataSource = ds.Tables["Bills"];
            }
            else
            {
                if (statuss == "1")
                {
                    payButton1.Enabled = false;
                }

                MessageBox.Show(result);
            }
        }

        private void generateButton1_Click(object sender, EventArgs e)
        {
            payButton1.Visible = true;
            payButton1.Enabled = true;
            viewBills("1");
            _Log.LogginDetails("logging.txt", "select");

            //logger_proxy.LogginDetails("logging.txt", "select");
        }

        private void payedButton1_Click(object sender, EventArgs e)
        {
            payButton1.Visible = false;
            payButton1.Enabled = false;
            viewBills("0");
            _Log.LogginDetails("logging.txt", "select");

            //logger_proxy.LogginDetails("logging.txt", "select");
        }

        private void payButton1_Click(object sender, EventArgs e)
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

            postData = "id=" + billId;

            string result = Operations.Get(URLs.Url["payBills"], postData);
            //MessageBox.Show(result);
            if (result != String.Empty)
            {
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show(result);
            }

            viewBills("1");
            //logger_proxy.LogginDetails("logging.txt", "update");

        }
    }
}
