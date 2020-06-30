using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStatusPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 저징ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 정우오빠ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("정우오빠");
        }

        private void 끝내긔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void 배고파ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "배고파ㅜㅜ";
            toolStripProgressBar1.Value = 10;
        }

        private void 보통ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "그냥저냥";
            toolStripProgressBar1.Value = 60;

        }

        private void 배불러ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "배불로";
            toolStripProgressBar1.Value = 100;
        }
    }
}
