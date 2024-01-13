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
    public partial class viewCustomers_frm : Form
    {
        public viewCustomers_frm()
        {
            InitializeComponent();
        }
        string consumerID;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void viewCustomers_Load(object sender, EventArgs e)
        {
            view_consumers();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                consumerID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }
        void view_consumers()
        {
            //WebRequest request = WebRequest.Create("http://localhost:7882/ebill2/view_users_.php");
            //request.Method = "POST";// the method to send data
            //request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)

            //string postData = "types=consumer";

            //ASCIIEncoding enc = new ASCIIEncoding();
            //byte[] data = enc.GetBytes(postData);
            //Stream stream = request.GetRequestStream();
            //stream.Write(data, 0, data.Length);

            //WebResponse response = request.GetResponse();
            //Stream stream2 = response.GetResponseStream();
            //StreamReader sr = new StreamReader(stream2);

            //string menuBreak = sr.ReadToEnd();
            //MessageBox.Show(menuBreak);
            string menuBreak = Operations.Get(URLs.Url["viewUser"],"consumer");
            if (menuBreak != "Sorry, you did not enter id ")
            {
                StringReader SR = new StringReader(menuBreak);
                DataSet ds = new DataSet();
                ds.ReadXml(SR);
                ds.Tables[0].TableName = "Consumers";
                dataGridView1.DataSource = ds.Tables["Consumers"];



            }
            else
            {
                MessageBox.Show(menuBreak);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //WebRequest request = WebRequest.Create("http://localhost:7882/ebill2/deleteuser_.php");
            //request.Method = "POST";// the method to send data
            //request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)



            //string postData = "id=" + consumerID;



            //ASCIIEncoding enc = new ASCIIEncoding();
            //byte[] data = enc.GetBytes(postData);
            //Stream stream = request.GetRequestStream();
            //stream.Write(data, 0, data.Length);



            //WebResponse response = request.GetResponse();
            //Stream stream3 = response.GetResponseStream();
            //StreamReader sr = new StreamReader(stream3);
            //string result = sr.ReadLine();
            string result = Operations.Delete(URLs.Url["deleteUser"], consumerID);
            MessageBox.Show(result);
            if (result == "Deleted Succefully")
            {
                MessageBox.Show(result);
                view_consumers();
            }
            else
                MessageBox.Show("opsss, something woring happend");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text.ToString();
            string Email = textBox4.Text.ToString();
            string Phone = textBox3.Text.ToString();
            string Password = textBox5.Text.ToString();
            string Address = textBox2.Text.ToString();

            //WebRequest request = WebRequest.Create("http://localhost:8080/ebill2/updateuser_.php");
            //request.Method = "POST";// the method to send data
            //request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)

            //string Name = textBox1.Text.ToString();
            //string Email = textBox4.Text.ToString();
            //string Phone = textBox3.Text.ToString();
            //string Password = textBox5.Text.ToString();
            //string Address = textBox2.Text.ToString();

            //string postData = "name=" + Name + "&email=" + Email + "&phone=" + Phone + "&password=" + Password + "&address=" + Address + "&id=" + consumerID;

            //MessageBox.Show(consumerID);

            //ASCIIEncoding enc = new ASCIIEncoding();
            //byte[] data = enc.GetBytes(postData);
            //Stream stream = request.GetRequestStream();
            //stream.Write(data, 0, data.Length);


            //WebResponse response = request.GetResponse();
            //Stream stream3 = response.GetResponseStream();
            //StreamReader sr = new StreamReader(stream3);
            //string result = sr.ReadLine();
            //MessageBox.Show(result);

            string result = Operations.Put(URLs.Url["updateUser"],Name,Email,Phone,Password,Address,consumerID);
            if (result == "Updated Successfully")
            {
                MessageBox.Show(result);
                view_consumers();
            }
            else
                MessageBox.Show(result);


        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
