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
    public partial class billGenerate_frm : Form
    {
        public billGenerate_frm()
        {
            InitializeComponent();
        }

        private void billGenerate_frm_Load(object sender, EventArgs e)
        {
            presenttextBox.Enabled = false;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        public string unitPrice;
       public  string meterId;
        private void button1_Click(object sender, EventArgs e)
        {//

            string id = textBox1.Text;
            // float total = float.Parse(preTextBox.Text+presenttextBox.Text);
            //WebRequest request = WebRequest.Create("http://localhost:7882/ebill2/consumerlist__.php");
            //request.Method = "POST";
            //request.ContentType = "application/x-www-form-urlencoded";

            //string id = textBox1.Text;
            //string postData = "id=" + id;

            //ASCIIEncoding enc = new ASCIIEncoding();
            //byte[] data = enc.GetBytes(postData);
            //Stream stream = request.GetRequestStream();
            //stream.Write(data, 0, data.Length);


            //WebResponse response = request.GetResponse();
            //Stream stream2 = response.GetResponseStream();
            //StreamReader sr = new StreamReader(stream2);
            //string result = sr.ReadLine();

            string result = Operations.Get(URLs.Url["searchConsumer"],id);
            if (!result.Contains("this id dose not belong to a consumer")  && !result.Contains("No data enterd :(") && !result.Contains("Sorry, you did not enter id ")) {
                string[] words = result.Split(':');
                string uName = words[0];
                string uAddress = words[1];
                string uPhone = words[2];
                string previousReading = words[3];
                string meterType = words[4];
                meterId = words[5];
                if (meterType == "0")
                {
                    unitPrice = prices.govermentPrice.ToString();
                }else 
                {
                    unitPrice = prices.commercialPrice.ToString();

                }

                nameTextBox.Text = uName;
                addressTextBox.Text = uAddress;
                phoneTextBox.Text = uPhone;
                preTextBox.Text = previousReading;
                unit_PriceTextBox.Text = unitPrice;
                isSearched = true;
                presenttextBox.Enabled = true;
            }
            else
            {
                MessageBox.Show(result);
            }
            

            //MessageBox.Show(result);
        }
        public float present_reading { get; set; }
        

        private void button2_Click(object sender, EventArgs e)
        {

        }
        bool isSearched;
        private void button4_Click(object sender, EventArgs e)
        {
          // - float.Parse(preTextBox.Text);
          
            if (presenttextBox.Text == String.Empty || !isSearched)
            {
                MessageBox.Show("please enter a present reading");
                return;
            }
            float previousReading = float.Parse(preTextBox.Text);

            if (float.Parse(presenttextBox.Text) < previousReading || presenttextBox.Text==String.Empty)
            {
                MessageBox.Show("pesent reading can not br less than previous reading");
                presenttextBox.Clear();
                return;

            }
            
           // WebRequest request = WebRequest.Create("http://localhost:7882/ebill2/generate.php");
           // request.Method = "POST";
           // request.ContentType = "application/x-www-form-urlencoded";
            float total_unit =  float.Parse(presenttextBox.Text) - float.Parse(preTextBox.Text);
            previousReading = float.Parse(presenttextBox.Text);// - float.Parse(preTextBox.Text);
           //float previousReading = float.Parse(presenttextBox.Text) + float.Parse(preTextBox.Text);
          float total_bill = total_unit * float.Parse(unitPrice);
            //    string postData = "meter_id=" + meterId + "&total_unit=" + total_unit + "&total_bill=" + total_bill + "&unit_price=" + unitPrice + "&previous_reading=" + previousReading;

            //ASCIIEncoding enc = new ASCIIEncoding();
            // byte[] data = enc.GetBytes(postData);
            // Stream stream = request.GetRequestStream();
            // stream.Write(data, 0, data.Length);


            // WebResponse response = request.GetResponse();
            // Stream stream2 = response.GetResponseStream();
            // StreamReader sr = new StreamReader(stream2);
            // string result = sr.ReadLine();
           string result= Operations.Insert(URLs.Url["generateBill"], meterId, total_unit, total_bill, unitPrice, previousReading);
            if (result.Contains("entered successfully"))
            {
                MessageBox.Show(" the bill generated successfully");
            }
            else
            {
                MessageBox.Show(" sorry,the bill was not generated");

            }

            TotalUnitTextBox.Text = total_unit.ToString();
            unitpricetextBox.Text = unitPrice;
            totalbilltextBox.Text = total_bill.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void presenttextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            //bilAmountTextBox.Text=presenttextBox.Text+preTextBox.Text;
        }

        public void clear()
        {
            textBox1.Clear();
            nameTextBox.Clear();
            addressTextBox.Clear();
            phoneTextBox.Clear();
            preTextBox.Clear();
            presenttextBox.Text = "0";
            unit_PriceTextBox.Clear();
            totalbilltextBox.Clear();
            unitpricetextBox.Clear();
            TotalUnitTextBox.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            clear();
            presenttextBox.Enabled = false;
            isSearched = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
