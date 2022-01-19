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
    public partial class washerForm : Form
    {
        public washerForm()
        {
            InitializeComponent();
        }

        private void washerForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WasherModel wm = new WasherModel();
            wm.outsideD = Convert.ToDouble(outsidetxt.Text) / 1000;
            wm.insideD = Convert.ToDouble(insidetxt.Text) / 1000;
            wm.thickness = Convert.ToDouble(thicknesstxt.Text) / 1000;

            wm.CreatePart();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void outsidetxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
