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
    public partial class Despre_noi : Form
    {
        public Despre_noi()
        {
            InitializeComponent();
        }

        private void despreNoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Despre_noi();
            form.Show();
        }

        private void acasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Acasa();
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
