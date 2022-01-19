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
    public partial class minecraftForm : Form
    {
        public minecraftForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            minecraftModel cube = new minecraftModel();

            cube.CreatePart();
        }

        private void minecraftForm_Load(object sender, EventArgs e)
        {

        }
    }
}
