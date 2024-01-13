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
    public partial class seachBillUserCont : UserControl
    {
        private Log _Log;
        public seachBillUserCont()
        {
            _Log = Log.GetInstance;
            InitializeComponent();
        }

        private void searchConsButton_Click(object sender, EventArgs e)
        {
            string user_id = searchConstxtbox.Text;
           
            string postData = "id=" + user_id;
            string result = Operations.Get(URLs.Url["searchBill"], postData);
            //MessageBox.Show(result);
            if (!result.Contains("Sorry, No user with this Id") && !result.Contains("No data enterd :(") && !result.Contains("sorry, invalide id format"))
            {
                StringReader SR = new StringReader(result);
                DataSet ds = new DataSet();
                ds.ReadXml(SR);
                ds.Tables[0].TableName = "Bills";
                dataGridView1.DataSource = ds.Tables["Bills"];
                _Log.LogginDetails("logging.txt", "select");

            }
            else
            {
                MessageBox.Show(result);
            }
            //logger_proxy.LogginDetails("logging.txt", "select");
        }

        private void searchConsButton1_Click(object sender, EventArgs e)
        {
            string user_id = searchConstxtbox.Text;
           
            string postData = "id=" + user_id;
            string result = Operations.Get(URLs.Url["searchBill"], postData);
            //MessageBox.Show(result);
            if (!result.Contains("Sorry, No user with this Id") && !result.Contains("No data enterd :(") && !result.Contains("sorry, invalide id format"))
            {
                StringReader SR = new StringReader(result);
                DataSet ds = new DataSet();
                ds.ReadXml(SR);
                ds.Tables[0].TableName = "Bills";
                dataGridView1.DataSource = ds.Tables["Bills"];

                _Log.LogginDetails("logging.txt", "select");

            }
            else
            {
                MessageBox.Show(result);
            }

        }

        private void seachBillUserCont_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
