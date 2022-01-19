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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var washerFormA = new washerForm();

            washerFormA.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var legoFormA = new LegoForm();

            legoFormA.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var minecraftFormA = new minecraftForm();

            minecraftFormA.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var screwFormA = new screwForm();

            screwFormA.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToLongTimeString();
            Date.Text = DateTime.Now.ToLongDateString();
        }

        private void Date_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
