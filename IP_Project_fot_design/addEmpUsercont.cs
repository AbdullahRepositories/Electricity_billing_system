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
    public partial class addEmpUsercont : UserControl
    {
        private Log _Log;
        public addEmpUsercont()
        {
            _Log = Log.GetInstance;
            InitializeComponent();
        }

        private void addEmpUsercont_Load(object sender, EventArgs e)
        {

        }
        

        private void submitButton1_Click(object sender, EventArgs e)
        {
            string Name = empNameTxtbox.Text;
            string Email = empEmailTxtbox.Text;
            string Phone = empContactTxtbox.Text;
            string Password = empPassTxtbox.Text;
            string Address = empAddressTxtbox.Text;
            string type = empTypeTxtbox.Text;
          
            string postData = "name=" + Name + "&email=" + Email + "&phone=" + Phone + "&password=" + Password + "&address=" + Address + "&types=" + type;
            string result = Operations.Get(URLs.Url["addUser"], postData);
            //MessageBox.Show(result);

            if (result == "addUserSuccessfully")
            {
                MessageBox.Show("User Added Successfully");
                _Log.LogginDetails("logging.txt", "insert");

            }
            else
            {
                MessageBox.Show(result);

            }

            empNameTxtbox.Text="";
             empEmailTxtbox.Text="";
             empContactTxtbox.Text="";
            empPassTxtbox.Text="";
             empAddressTxtbox.Text="";
            
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            empNameTxtbox.Text = "";
            empEmailTxtbox.Text = "";
            empContactTxtbox.Text = "";
            empPassTxtbox.Text = "";
            empAddressTxtbox.Text = "";
        }
    }
}
