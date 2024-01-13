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
    public partial class managerMain_frm : Form 
    {

        form_show_close frm;
        
        public managerMain_frm()
        {
            InitializeComponent();
            frm = new form_show_close();
        }


        private void managerMain_Load(object sender, EventArgs e)
        {
            homeUsercont1.BringToFront();
            tsEmployee.Enabled = true;
            tsPayroll.Enabled = true;
            tsUser.Enabled = true;
            tsReport.Enabled = true;
                
        }
        //private void closeChildForm()
        //{
        //    foreach (Form frm in this.MdiChildren)
        //    {
        //        frm.Close();
        //    }
        //}

        //private void showFrm(Form frm)
        //{
        //    this.IsMdiContainer = true;
        //    frm.MdiParent = this;
        //    frm.Show();
        //    frm.WindowState = FormWindowState.Maximized;
        //}

        private void tsEmployee_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            unitPriceUsercont1.BringToFront();
            //frm.closeChildForm(this);
            //frm.showFrm(new unitPrice_frm(),this) ;
        }

        private void tsUser_Click(object sender, EventArgs e)
        {

        }

        private void tsReport_Click(object sender, EventArgs e)
        {
            seachBillUserCont1.BringToFront();
            //frm.closeChildForm(this);
            //frm.showFrm(new searchBill_frm(), this);
        }

        private void tsPayroll_Click(object sender, EventArgs e)
        {
           
            billGenerate1.BringToFront();
            //frm.closeChildForm(this);
            //frm.showFrm(new billGenerate_frm(), this);
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addConsuUseControl1.BringToFront();
            //frm.closeChildForm(this);
            //frm.showFrm(new addCustomerfrm(),this) ;
        }

        private void viewCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewConsuUsercont1.view_consumers();
            viewConsuUsercont1.BringToFront();
            //frm.closeChildForm(this);
            //frm.showFrm(new viewCustomers_frm(), this);
        }

        private void tsUser_ButtonClick(object sender, EventArgs e)
        {

        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addEmpUsercont1.BringToFront();
            //frm.closeChildForm(this);
            //frm.showFrm(new addEmployee_frm(), this);
        }

        private void viewEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewEmpUsercont1.view_employees();
            viewEmpUsercont1.BringToFront();
            //frm.closeChildForm(this);
            //frm.showFrm(new viewEmployees_frm(), this);
        }

        private void updateOrDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewEmpUsercont1.BringToFront();
            //frm.closeChildForm(this);
            //frm.showFrm(new viewEmployees_frm(), this);
        }

        private void tsUser_ButtonClick_1(object sender, EventArgs e)
        {

        }

        private void tsEmployee_ButtonClick(object sender, EventArgs e)
        {
            
        }

        private void updateOrDeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //frm.closeChildForm(this);
            //frm.showFrm(new viewCustomers_frm(), this);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
            consumercomplaintUsercont1.view_complaints();
            consumercomplaintUsercont1.BringToFront();
           
            
        //    frm.closeChildForm(this);
        //    frm.showFrm(new customercomplaint_frm(), this);

        }

        private void managerMain_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void addEmpUsercont1_Load(object sender, EventArgs e)
        {

        }

        private void viewEmpUsercont1_Load(object sender, EventArgs e)
        {

        }

        private void homeUsercont1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void consumercomplaintUsercont1_Load(object sender, EventArgs e)
        {

        }
    }
}
