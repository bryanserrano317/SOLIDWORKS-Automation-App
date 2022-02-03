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
            // Start Washer Build Process
            WasherModel wm = new WasherModel(); // Start Washer Script

            // Pass the dimensions from text boxes to the script
            // FYI Double means decimal in programming (0.0 = double, 0 = int (integer))
            // Divide by 1000 because the standard API unit is M (meters) (Convert to mm)
            // Method Syntax: Convert.ToDouble("user input")
            wm.outsideD = Convert.ToDouble(outsidetxt.Text) / 1000;
            wm.insideD = Convert.ToDouble(insidetxt.Text) / 1000;
            wm.thickness = Convert.ToDouble(thicknesstxt.Text) / 1000;

            // Calls the CreatePart method from WasherModel.cs
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
