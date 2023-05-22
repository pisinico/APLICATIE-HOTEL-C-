using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IOC
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

      SqlConnection con=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Control.mdf;Integrated Security=True;Connect Timeout=30");



        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            inreg.Height = panel1.Height;
            panel1.Location = new Point(5, 5);
            panmain.Location = new Point(380, 5);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            inreg.Height = 0;
            panel1.Location = new Point(320, 5);
            panmain.Location = new Point(9, 5);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            inreg.Height = 0;
            panel1.Location = new Point(320, 5);
            panmain.Location = new Point(9, 5);
            string nume, parola = null;
            nume = textBox4.Text;
            if (textBox3.Text == textBox5.Text)
            {
                parola = textBox3.Text;

                con.Open();
                SqlCommand cmd = new SqlCommand("insert into controldate values(@nume,@parola)",con);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into controldate values('" + nume + "','" + parola + "');";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inregistrare facuta cu succes!");
                var form = new Interfata();
                form.Show();
            }

            else { MessageBox.Show("Parolele nu corespund!"); }

        }
        bool flag = false;

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cme= new SqlCommand("insert into controldate values(@nume,@parola)", con);
            cme.CommandText = "Select*from [controldate]";
            cme.Connection = con;
            SqlDataReader rd = cme.ExecuteReader();
            while(rd.Read())
            {
                if (rd[0].ToString() == textBox1.Text && (rd[1].ToString() == textBox2.Text))
                {
                    flag = true;
                    break;
                }
               
            }
            
         if(flag==true)
            {
                MessageBox.Show("Autentificare cu succes!");
                var form = new Interfata();
                form.Show();
            }
         if(flag==false)
            { MessageBox.Show("Date de autentificare invalide!"); }
            con.Close();
        }
    }
}
