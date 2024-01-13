using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IP_Project.LogSingleton;

namespace IP_Project
{
    public partial class addConsuUseControl : UserControl
    {
        private Log _Log;
        public addConsuUseControl()
        {
            _Log = Log.GetInstance;
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
           

            string Name = consumerNametxtbox.Text;
            string Email = consEmailtxtbox.Text;
            string Phone = consContacttxtbox.Text;
            string Password = consPasstxtbox.Text;
            string Address = consAddresstxtbox.Text;
            string type = consTypetxtbox.Text;
            string meterType = meterTypcomboBox.SelectedIndex.ToString();
            

            string postData = "name=" + Name + "&email=" + Email + "&phone=" + Phone + "&password=" + Password + "&address=" + Address + "&types=" + type + "&meterType=" + meterType;
            string result = Operations.Get(URLs.Url["addUser"], postData);
            if (result == "addUserSuccessfully")
            {
                MessageBox.Show("User Added Successfully");
                _Log.LogginDetails("logging.txt", "insert");
            }
            else
            {
                MessageBox.Show(result);
                //textBox1.Text = result;

            }
            //logger_proxy.LogginDetails("logging.txt", "insert");
        }

        private void addConsuUseControl_Load(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {

        }

        private void submitButton1_Click(object sender, EventArgs e)
        {
            

            string Name = consumerNametxtbox.Text;
            string Email = consEmailtxtbox.Text;
            string Phone = consContacttxtbox.Text;
            string Password = consPasstxtbox.Text;
            string Address = consAddresstxtbox.Text;
            string type = consTypetxtbox.Text;
            string meterType = meterTypcomboBox.SelectedIndex.ToString();
            

            string postData = "name=" + Name + "&email=" + Email + "&phone=" + Phone + "&password=" + Password + "&address=" + Address + "&types=" + type + "&meterType=" + meterType;
            string result = Operations.Get(URLs.Url["addUser"], postData);
            if (result == "addUserSuccessfully")
            {
                MessageBox.Show("User Added Successfully");
                _Log.LogginDetails("logging.txt", "insert");
            }
            else
            {
                MessageBox.Show(result);
                //textBox1.Text = result;

            }
            //logger_proxy.LogginDetails("logging.txt", "insert");

            //consumerNametxtbox.Text = "";
            //consAddresstxtbox.Text = "";
            //consContacttxtbox.Text = "";
            //consPasstxtbox.Text = "";
            //consEmailtxtbox.Text = "";
        }

        private void ClearButton_Click_1(object sender, EventArgs e)
        {
            consumerNametxtbox.Text = "";
            consAddresstxtbox.Text = "";
            consContacttxtbox.Text = "";
            consPasstxtbox.Text = "";
            consEmailtxtbox.Text = "";
        }
    }
}