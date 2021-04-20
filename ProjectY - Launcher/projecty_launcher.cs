using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectY___Launcher
{
    public partial class AlterEGO : Form
    {
        public AlterEGO()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("fivem://connect/45.146.255.136:30120");
        }

        private void py_tokovoip_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ts3server://92.42.44.150/?port=9028&password=lunny1337");
        }

        private void py_patreon_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.patreon.com/carpediemrp");
        }
    }
}
