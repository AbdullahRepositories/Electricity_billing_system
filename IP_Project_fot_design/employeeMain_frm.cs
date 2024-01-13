using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IP_Project.forms_control;
namespace IP_Project
{
    public partial class employeeMain_frm : Form
    {
        form_show_close frm;
        public employeeMain_frm()
        {
            InitializeComponent();
            frm = new form_show_close();
        }
        private void employeeMian_frm_Load(object sender, EventArgs e)
        {
            tsPayroll.Enabled = true;
            tsUser.Enabled = true;
        }

        private void tsEmployee_ButtonClick(object sender, EventArgs e)
        {

        }

        private void tsUser_ButtonClick(object sender, EventArgs e)
        {

        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addConsuUseControl1.BringToFront();
            //frm.closeChildForm(this);
            //frm.showFrm(new addCustomerfrm(), this);
        }

        private void viewCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewConsuUsercont1.BringToFront();
            //frm.closeChildForm(this);
            //frm.showFrm(new viewCustomers_frm(), this);
        }

        

        private void tsPayroll_Click(object sender, EventArgs e)
        {
            billGenerate1.BringToFront();
            //frm.closeChildForm(this);
            //frm.showFrm(new billGenerate_frm(), this);
        }

        private void employeeMain_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();

        }

        private void viewConsuUsercont1_Load(object sender, EventArgs e)
        {

        }
    }
}
