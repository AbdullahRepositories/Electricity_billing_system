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
    public partial class viewEmpUsercont : UserControl
    {
        private Log _Log;
        string employeeID;
        string postData;
        public viewEmpUsercont()
        {
            _Log = Log.GetInstance;
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text.ToString();
            string Email = textBox4.Text.ToString();
            string Phone = textBox3.Text.ToString();
            string Password = textBox5.Text.ToString();
            string Address = textBox2.Text.ToString();

           
            postData = "name=" + Name + "&email=" + Email + "&phone=" + Phone + "&password=" + Password + "&address=" + Address + "&id=" + employeeID;
            string result = Operations.Get(URLs.Url["updateUser"], postData);

            if (result == "Updated Successfully")
            {
                MessageBox.Show(result);
                _Log.LogginDetails("logging.txt", "update");

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
        private void viewEmpUsercont_Load(object sender, EventArgs e)
        {
            view_employees();
        }
       public void view_employees()
        {
           
            postData = "types=biller";
            string result = Operations.Get(URLs.Url["viewUser"], postData);

            if (result == string.Empty)
            {
                MessageBox.Show(result);
            }
            else
            {
                if (!result.Contains( "Sorry, No consumer ") && !result.Contains("No data enterd :("))
                {
                    StringReader SR = new StringReader(result);
                    DataSet ds = new DataSet();
                    ds.ReadXml(SR);
                    ds.Tables[0].TableName = "Billers";
                    dataGridView1.DataSource = ds.Tables["Billers"];
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
        }

        private void deletButton_Click(object sender, EventArgs e)
        {
            
            postData = "id=" + employeeID;
            string result = Operations.Get(URLs.Url["deleteUser"], postData);

            if (result == "Deleted Succefully")
            {
                MessageBox.Show(result);
                _Log.LogginDetails("logging.txt", "delete");

                view_employees();
            }
            else
                MessageBox.Show("oppse, something went wrong");

        }

        private void deleteButton1_Click(object sender, EventArgs e)
        {
           
            postData = "id=" + employeeID;
            string result = Operations.Get(URLs.Url["deleteUser"], postData);

            if (result == "Deleted Succefully")
            {
                MessageBox.Show(result);
                _Log.LogginDetails("logging.txt", "delete");

                view_employees();
            }
            else
                MessageBox.Show("oppse, something went wrong");


        }

        private void updateButton1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text.ToString();
            string Email = textBox4.Text.ToString();
            string Phone = textBox3.Text.ToString();
            string Password = textBox5.Text.ToString();
            string Address = textBox2.Text.ToString();

           
            postData = "name=" + Name + "&email=" + Email + "&phone=" + Phone + "&password=" + Password + "&address=" + Address + "&id=" + employeeID;
            string result = Operations.Get(URLs.Url["updateUser"], postData);

            if (result == "Updated Successfully")
            {
                MessageBox.Show(result);
                _Log.LogginDetails("logging.txt", "update");

                view_employees();
            }
            else
                MessageBox.Show(result);


        }
    }
}
