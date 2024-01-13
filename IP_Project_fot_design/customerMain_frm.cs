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
    public partial class customerMain_frm : Form
    {
        form_show_close frm;
        public customerMain_frm()
        {
            frm = new form_show_close();
            InitializeComponent();
        }
        private void customerMain_frm_Load(object sender, EventArgs e)
        {
            tsMyBills.Enabled = true;
            tsMyComplaints.Enabled = true;
            //tsMyTransactions.Enabled = true;

        }
       

        private void tsPayroll_Click(object sender, EventArgs e)
        {
            historyUserCont1.BringToFront();
            //frm.closeChildForm(this);
            //frm.showFrm(new history(), this);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           // frm.closeChildForm(this);
            //frm.showFrm(new transaction(), this);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            consumercomplaintUsercont1.BringToFront();
            //frm.closeChildForm(this);
            //frm.showFrm(new customercomplaint_frm(), this);
        }

        private void customerMain_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void homeUsercont1_Load(object sender, EventArgs e)
        {

        }
    }
}
