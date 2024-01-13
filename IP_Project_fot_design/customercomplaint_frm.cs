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
    public partial class customercomplaint_frm : Form
    {
        public customercomplaint_frm()
        {
            InitializeComponent();
        }

        private void send_Click(object sender, EventArgs e)
        {
            complaintText_frm ob = new complaintText_frm();
            ob.Show();
        }

        private void customercomplaint_frm_Load(object sender, EventArgs e)
        {

            //WebRequest request = WebRequest.Create("http://localhost:7882/ebill2/consumercomplain_.php");
            //request.Method = "POST";// the method to send data
            //request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)
            //string user_id = userInfo.userId;
            //string postData = "id=" + user_id;

            //ASCIIEncoding enc = new ASCIIEncoding();
            //byte[] data = enc.GetBytes(postData);
            //Stream stream = request.GetRequestStream();
            //stream.Write(data, 0, data.Length);

            //WebResponse response = request.GetResponse();
            //Stream stream2 = response.GetResponseStream();
            //StreamReader sr = new StreamReader(stream2);
            string menuBreak="";
            if (userInfo.userRole == "admin")
            {
                send.Visible = false;
                menuBreak = Operations.Get(URLs.Url["customerComplaint"], "-1");

            }
            else
            { menuBreak = Operations.Get(URLs.Url["customerComplaint"], userInfo.userId); }
           // MessageBox.Show(menuBreak);
            if (menuBreak != "Sorry, you have not add any complaints sir!" && menuBreak != "No data enterd :("&& menuBreak != "Sorry, The Id could not be figured")
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
