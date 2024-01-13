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
    public partial class addCustomerfrm : Form
    {
        public addCustomerfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //WebRequest request = WebRequest.Create("http://localhost:7882/ebill2/Api/addUser_.php");
            //request.Method = "POST";// the method to send data
            //request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)

            string Name = textBox1.Text;
            string Email = textBox2.Text;
            string Phone = textBox4.Text;
            string Password = textBox5.Text;
            string Address = textBox3.Text;
            string type = textBox6.Text;
            string meterType = metercomboBox.SelectedIndex.ToString();
            //MessageBox.Show(meterType);
            //string postData = "name=" + Name + "&email=" + Email + "&phone=" + Phone + "&password=" + Password + "&address=" + Address + "&types=" + type + "&meterType=" + meterType;

            //ASCIIEncoding enc = new ASCIIEncoding();
            //byte[] data = enc.GetBytes(postData);
            //Stream stream = request.GetRequestStream();
            //stream.Write(data, 0, data.Length);

            //WebResponse response = request.GetResponse();
            //Stream stream2 = response.GetResponseStream();
            //StreamReader sr = new StreamReader(stream2);
            //string result = sr.ReadLine();
            //MessageBox.Show(result);
            string result = Operations.Insert(URLs.Url["addUser"], Name, Email, Phone, Password, Address,type, meterType);
            if (result == "addUserSuccessfully")
            {
                MessageBox.Show("User Added Successfully");
            }
            else
            {
                MessageBox.Show(result);
                //textBox1.Text = result;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addCustomerfrm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
