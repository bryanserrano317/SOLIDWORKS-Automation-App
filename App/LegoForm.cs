using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace automationapp
{
    public partial class LegoForm : Form
    {
        public LegoForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void staticIntroText_TextChanged(object sender, EventArgs e)
        {

        }

        private void outsidetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                LegoModel pm = new LegoModel();
                pm.Dim_A = Convert.ToDouble(Atxt.Text) / 1000;
                pm.Dim_B = Convert.ToDouble(Btxt.Text) / 1000;
                pm.Dim_D3 = Convert.ToDouble(D3txt.Text) / 1000;
                pm.Dim_H1 = Convert.ToDouble(H1txt.Text) / 1000;
                pm.Dim_H2 = Convert.ToDouble(H2txt.Text) / 1000;


                pm.CreatePart();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");

            }
        }

        private void D2txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void D1txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
