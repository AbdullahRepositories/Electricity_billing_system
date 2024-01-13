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
    
  

    public partial class unitPrice_frm : Form
    {

        public unitPrice_frm()
        {
            InitializeComponent();
        }

        private void unitPrice_frm_Load(object sender, EventArgs e)
        {

        }

        private void submitUnitPrice_btn_Click(object sender, EventArgs e)
        {
            if (unitPrice_textBox.Text != string.Empty)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    prices.commercialPrice = Convert.ToInt32(unitPrice_textBox.Text);
                }
                else
                {
                    prices.govermentPrice = Convert.ToInt32(unitPrice_textBox.Text);
                }
                MessageBox.Show(prices.commercialPrice.ToString());
            }
            else
            {
                MessageBox.Show("please Enter value");
            }

            //WebRequest request = WebRequest.Create("http://localhost:7882/login2.php");
            //request.Method = "POST";
            //request.ContentType = "application/x-www-form-urlencoded";

            ////int id = int.Parse(text_id);
            //string name = text_name.Text;
            //string password = text_password.Text;
            //string postData = "name=" + name + "&password=" + password;

            //ASCIIEncoding enc = new ASCIIEncoding();
            //byte[] data = enc.GetBytes(postData);
            //Stream stream = request.GetRequestStream();
            //stream.Write(data, 0, data.Length);


            //WebResponse response = request.GetResponse();
            //Stream stream2 = response.GetResponseStream();
            //StreamReader sr = new StreamReader(stream2);
            //string result = sr.ReadLine();

            //text_name.Text = "";
            //text_password.Text = "";
        }

        private void unitType_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

        private void unitPrice_textBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}