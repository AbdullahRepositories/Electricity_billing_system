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
    public partial class viewEmployees_frm : Form
    {
        public viewEmployees_frm()
        {
            InitializeComponent();
        }
        string employeeID;
        private void viewEmployees_frm_Load(object sender, EventArgs e)
        {
            view_employees();
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

            //string postData = "name=" + Name + "&email=" + Email + "&phone=" + Phone + "&password=" + Password + "&address=" + Address + "&id=" + employeeID;



            //ASCIIEncoding enc = new ASCIIEncoding();
            //byte[] data = enc.GetBytes(postData);
            //Stream stream = request.GetRequestStream();
            //stream.Write(data, 0, data.Length);



            //WebResponse response = request.GetResponse();
            //Stream stream3 = response.GetResponseStream();
            //StreamReader sr = new StreamReader(stream3);
            //string result = sr.ReadLine();
            //MessageBox.Show(result);

            string result = Operations.Put(URLs.Url["updateUser"], Name, Email, Phone, Password, Address, employeeID);

            if (result == "Updated Successfully")
            {
                MessageBox.Show(result);
                view_employees();
            }
            else
                MessageBox.Show(result);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            employeeID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //WebRequest request = WebRequest.Create("http://localhost:7882/ebill2/deleteuser_.php");
            //request.Method = "POST";// the method to send data
            //request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)

            

            //string postData = "id=" + employeeID;



            //ASCIIEncoding enc = new ASCIIEncoding();
            //byte[] data = enc.GetBytes(postData);
            //Stream stream = request.GetRequestStream();
            //stream.Write(data, 0, data.Length);



            //WebResponse response = request.GetResponse();
            //Stream stream3 = response.GetResponseStream();
            //StreamReader sr = new StreamReader(stream3);
            
            string result = Operations.Delete(URLs.Url["deleteUser"], employeeID);

            if (result == "Deleted Succefully")
            {
                MessageBox.Show(result);
                view_employees();
            }
            else
                MessageBox.Show("oppse, something went wrong");

        }
        void view_employees()
        { 
        //    WebRequest request = WebRequest.Create("http://localhost:7882/ebill2/view_users_.php");
        //    request.Method = "POST";// the method to send data
        //    request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)

        //    string postData = "types=biller";

        //    ASCIIEncoding enc = new ASCIIEncoding();
        //    byte[] data = enc.GetBytes(postData);
        //    Stream stream = request.GetRequestStream();
        //    stream.Write(data, 0, data.Length);

        //    WebResponse response = request.GetResponse();
        //    Stream stream2 = response.GetResponseStream();
        //    StreamReader sr = new StreamReader(stream2);

        //    string menuBreak = sr.ReadToEnd();
            //MessageBox.Show(menuBreak);
            
           string menuBreak= Operations.Get(URLs.Url["viewUser"], "biller");
            if (menuBreak != "Sorry, you did not enter id ")
            {
                StringReader SR = new StringReader(menuBreak);
                DataSet ds = new DataSet();
                ds.ReadXml(SR);
                ds.Tables[0].TableName = "Billers";
                dataGridView1.DataSource = ds.Tables["Billers"];
                              
               
            }
            else
            {
               // MessageBox.Show(menuBreak);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
