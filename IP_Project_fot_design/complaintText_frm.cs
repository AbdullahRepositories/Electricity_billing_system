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
using IP_Project.LogSingleton;

namespace IP_Project
{
    public partial class complaintText_frm : Form
    {
        private Log _Log;
        public complaintText_frm()
        {
            _Log = Log.GetInstance;
            InitializeComponent();
        }

        private void confirm_password_box_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signup_Click(object sender, EventArgs e)
        {

        }

        private void full_name_account_Load(object sender, EventArgs e)
        {

        }

        private void email_account_Load(object sender, EventArgs e)
        {

        }

        private void user_name_account_Load(object sender, EventArgs e)
        {

        }

        private void confirm_account_Load(object sender, EventArgs e)
        {

        }

        private void password_account_Load(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void confirm_password_Click(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void full_name_Click(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            string complain = richTextBox1.Text;
            //string Id = userInfo.userId;

            //WebRequest request = WebRequest.Create(URLs.Url["complaintText"]);
            //request.Method = "POST";// the method to send data
            //request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)

            //string complain = richTextBox1.Text;
            //string Id = userInfo.userId;

            //string postData = "id=" + Id + "&complain=" + complain;

            //ASCIIEncoding enc = new ASCIIEncoding();
            //byte[] data = enc.GetBytes(postData);
            //Stream stream = request.GetRequestStream();
            //stream.Write(data, 0, data.Length);

            //WebResponse response = request.GetResponse();
            //Stream stream2 = response.GetResponseStream();
            //StreamReader sr = new StreamReader(stream2);
            //string result = sr.ReadLine();
            string postData = "id=" + userInfo.userId + "&complain=" + complain;
            string result = Operations.Get(URLs.Url["complaintText"],postData);
            if (result.Contains("you must write you complain sir"))
            {
                MessageBox.Show(result);
                _Log.LogginDetails("logging.txt", "insert");

            }
            else
            {
                MessageBox.Show(result);
                this.Close();
            }

            //this.Close();

            // if()
            //logger_proxy.LogginDetails("logging.txt", "insert");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
