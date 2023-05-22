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
    public partial class Acasa : Form
    {
        public Acasa()
        {
            InitializeComponent();
        }

        private void Acasa_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Rezervare();
            form.Show();
        }

        private void acasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Acasa();
            form.Show();
        }

        private void despreNoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Despre_noi();
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
    }
}
