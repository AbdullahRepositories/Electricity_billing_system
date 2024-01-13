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
using IP_Project.LogSingleton;

namespace IP_Project
{
    public partial class login_frm : Form
    {
        //proxy_login login_proxy;
        private Log _Log;
        public login_frm()
        {
            _Log = Log.GetInstance;
            InitializeComponent();
           // login_proxy=new proxy_login();
        }
       
   

        private void login_Click_1(object sender, EventArgs e)
        {
            proxy_login check = new proxy_login();
            string userEmail = user_email_login.Texts;
            string userPassword = password_login.Texts;
           
           string  postData = "email=" + userEmail + "&pass=" + userPassword;

            string result = Operations.Get(URLs.Url["logIn"], postData);
            //MessageBox.Show(result);
            if (!result.Contains("sorry, no data entered sir") && !result.Contains("Invalid email format") && !result.Contains("sorry, Fields must be full") && !result.Contains("sorry, user not found"))
            {
                string[] userInformation= result.Split(':');
                userInfo.userId = userInformation[0];
                userInfo.userName = userInformation[1];
                userInfo.userPassword = userInformation[2];
                userInfo.userEmail = userInformation[3];
                userInfo.userAddress = userInformation[4];
                userInfo.userPhone = userInformation[5];
                userInfo.userRole = userInformation[6];
                //chech proxy determine which user to show 
                _Log.LogginDetails("logging.txt", "loged in");

                check.checkType(this);
                            
            }
            else
            {
                MessageBox.Show(result);
            }
            //logger_proxy.LogginDetails("logging.txt","login");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void panel_login_Paint(object sender, PaintEventArgs e)
        {

        }

        private void password_login_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
