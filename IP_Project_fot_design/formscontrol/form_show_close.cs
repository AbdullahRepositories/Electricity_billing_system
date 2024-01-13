using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_Project.forms_control
{  public class form_show_close
     {

        public void closeChildForm(Form thiss)
        {
            foreach (Form frm in thiss.MdiChildren)
            {
                frm.Close();
            }
        }
        public void showFrm(Form frm, Form thiss)
        {
            thiss.IsMdiContainer = true;
            frm.MdiParent = thiss;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }
    }
  }

