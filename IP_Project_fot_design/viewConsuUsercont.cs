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
    public partial class viewConsuUsercont : UserControl
    {
        private Log _Log;
        public viewConsuUsercont()
        {
            _Log = Log.GetInstance;
            InitializeComponent();
        }
        string consumerID;
        string postData;
        private void viewConsuUsercont_Load(object sender, EventArgs e)
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
       public void view_consumers()
        {
            
            postData = "types=consumer";
            string result = Operations.Get(URLs.Url["viewUser"], postData);
            if (result == string.Empty)
            {
                MessageBox.Show(result);
            }
            else
            {
                if (!result.Contains("Sorry, No consumer ") && !result.Contains( "No data enterd :("))
                {
                    StringReader SR = new StringReader(result);
                    DataSet ds = new DataSet();
                    ds.ReadXml(SR);
                    ds.Tables[0].TableName = "Consumers";
                    dataGridView1.DataSource = ds.Tables["Consumers"];
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
        
            postData = "id=" + consumerID;
            string result = Operations.Get(URLs.Url["deleteUser"], postData);
            MessageBox.Show(result);
            if (result == "Deleted Succefully")
            {
                MessageBox.Show(result);
                _Log.LogginDetails("logging.txt", "delete");

                view_consumers();
            }
            else
                MessageBox.Show("opsss, something woring happend");

            //logger_proxy.LogginDetails("logging.txt", "delete");
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text.ToString();
            string Email = textBox4.Text.ToString();
            string Phone = textBox3.Text.ToString();
            string Password = textBox5.Text.ToString();
            string Address = textBox2.Text.ToString();

           
            postData = "name=" + Name + "&email=" + Email + "&phone=" + Phone + "&password=" + Password + "&address=" + Address + "&id=" + consumerID;
            string result = Operations.Get(URLs.Url["updateUser"], postData);
            if (result == "Updated Successfully")
            {
                MessageBox.Show(result);
                _Log.LogginDetails("logging.txt", "update");

                view_consumers();
            }
            else
                MessageBox.Show(result);

        }

        private void deleteButton1_Click(object sender, EventArgs e)
        {
           
            postData = "id=" + consumerID;
            string result = Operations.Get(URLs.Url["deleteUser"], postData);
            MessageBox.Show(result);
            if (result == "Deleted Succefully")
            {
                MessageBox.Show(result);
                _Log.LogginDetails("logging.txt", "delete");

                view_consumers();
            }
            else
                MessageBox.Show("opsss, something woring happend");

            //logger_proxy.LogginDetails("logging.txt", "delete");

        }

        private void updateButton1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text.ToString();
            string Email = textBox4.Text.ToString();
            string Phone = textBox3.Text.ToString();
            string Password = textBox5.Text.ToString();
            string Address = textBox2.Text.ToString();

            
            postData = "name=" + Name + "&email=" + Email + "&phone=" + Phone + "&password=" + Password + "&address=" + Address + "&id=" + consumerID;
            string result = Operations.Get(URLs.Url["updateUser"], postData);
            if (result == "Updated Successfully")
            {
                MessageBox.Show(result);
                _Log.LogginDetails("logging.txt", "update");

                view_consumers();
            }
            else
                MessageBox.Show(result);


        }
    }
}
