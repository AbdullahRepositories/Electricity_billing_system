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
using IP_Project.forms_control;

namespace IP_Project
{

    public class proxy_login 
    {
       
        //public  string role = userInfo.userRole;
       //form_show_close fsh;

        public proxy_login()
        {
           //fsh = new form_show_close();
        }
        
       public void  admin_page(Form thiss)
        {
            managerMain_frm managerMain = new managerMain_frm();         
            managerMain.Show();
            thiss.Hide();
        }
        public void user_page(Form thiss)
        {
            customerMain_frm userMain = new customerMain_frm();         
            userMain.Show();
            thiss.Hide();
        }
        public void employee_page(Form thiss)
        {
            employeeMain_frm employeeMain = new employeeMain_frm();
            employeeMain.Show();
            thiss.Hide();
        }


        public void checkType(Form thisss)
        {
            if (userInfo.userRole =="admin")
            {
                admin_page(thisss);
            }
            else if (userInfo.userRole == "biller") {
                employee_page(thisss);
            }
            else if (userInfo.userRole == "consumer")
            {
                user_page(thisss);
            }
        }
        //public void user_page()
        //{
        //    closeChildForm();
        //    showFrm(new customerMain_frm());
        //}

        //public void employee_page()
        //{

        //    closeChildForm();
        //    showFrm(new employeeMain_frm());
        //}
    }
}

