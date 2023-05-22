using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOC
{
    public partial class Rezervare : Form
    {
        public Rezervare()
        {
            InitializeComponent();
           
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\rezervaredate.mdf;Integrated Security=True;Connect Timeout=30");
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string nume, prenume;
            int telefon;
            int tipcamera, durata;
            nume = textBox1.Text;
            prenume = textBox2.Text;
            telefon = Convert.ToInt32(textBox3);
            durata = Convert.ToInt32(textBox4);

            if (radioButton1.Checked)
            {
                con.Open();
                tipcamera = 1;
                SqlCommand cmd = new SqlCommand("insert into rezervDate values(@nume,@prenume,@telefon,@tipcamera,@durata)", con);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into rezervDate values('" + nume + "','" + prenume + "','" + telefon + "','" + tipcamera + "','" + durata + "');";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Formular trimis cu succes!");
            }
            else if(radioButton2.Checked)
            {
                con.Open();
                tipcamera = 1;
                SqlCommand cmd = new SqlCommand("insert into rezervDate values(@nume,@prenume,@telefon,@tipcamera,@durata)", con);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into rezervDate values('" + nume + "','" + prenume + "','" + telefon + "','" + tipcamera + "','" + durata + "');";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Formular trimis cu succes!");
            }
            else if(radioButton3.Checked)
            {
                con.Open();
                tipcamera = 1;
                SqlCommand cmd = new SqlCommand("insert into rezervDate values(@nume,@prenume,@telefon,@tipcamera,@durata)", con);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into rezervDate values('" + nume + "','" + prenume + "','" + telefon + "','" + tipcamera + "','" + durata + "');";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Formular trimis cu succes!");
            }
            else if(radioButton4.Checked)
            {
                con.Open();
                tipcamera = 1;
                SqlCommand cmd = new SqlCommand("insert into rezervDate values(@nume,@prenume,@telefon,@tipcamera,@durata)", con);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into rezervDate values('" + nume + "','" + prenume + "','" + telefon + "','" + tipcamera + "','" + durata + "');";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Formular trimis cu succes!");
            }

           */
            MessageBox.Show("Formular trimis cu succes!");
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
