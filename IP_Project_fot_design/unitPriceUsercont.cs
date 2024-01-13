using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_Project
{
    public partial class unitPriceUsercont : UserControl
    {
        public unitPriceUsercont()
        {
            InitializeComponent();
        }

        private void unitPriceUsercont_Load(object sender, EventArgs e)
        {

        }
        private void submitUnitPrice_btn_Click(object sender, EventArgs e)
        {
            int i = 0;
            bool result = true;
            result=int.TryParse(unitPrice_textBox.Text, out i);
            if (unitPrice_textBox.Text != string.Empty && result!=false)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    prices.commercialPrice = Convert.ToInt32(unitPrice_textBox.Text);
                }
                else
                {
                    prices.govermentPrice = Convert.ToInt32(unitPrice_textBox.Text);
                }
                MessageBox.Show(prices.commercialPrice.ToString());
            }
            else
            {
                MessageBox.Show("please Enter value a proper value");
            }


        }
    }
}
