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
    public partial class boltForm : Form
    {
        public boltForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void screwForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BoltModel NAS = new BoltModel();

            NAS.CreatePart();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BoltModel Bolt = new BoltModel();
            Bolt.lengthDim = Convert.ToDouble(lengthDim.Text) / 1000;
            Bolt.thicknessDim = Convert.ToDouble(thicknessDim.Text) / 1000;
            Bolt.CreatePart();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
