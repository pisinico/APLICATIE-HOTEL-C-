using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOC
{
    public partial class Interfata : Form
    {
        public Interfata()
        {
            InitializeComponent();
        }

        private void acasaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void acasaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var form = new Acasa();
            form.Show();
        }

        private void despreNoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Despre_noi();
            form.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            var form = new camerecatei();
            form.Show();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            var form = new camerepisici();
            form.Show();
        }

        private void cateiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new camerecatei();
            form.Show();
        }

        private void pisiciToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new camerepisici();
            form.Show();
        }

        private void intrebariToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cateiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new intrebaricatei();
            form.Show();

        }

        private void pisiciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new intrebaripisici();
            form.Show();

        }

        private void cazareToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
