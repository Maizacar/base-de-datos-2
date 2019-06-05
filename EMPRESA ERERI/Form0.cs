using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMPRESA_ERERI
{
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
          

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form0_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "Maiza" && txtpassword.Text == "maizacardona")
            {
                this.Hide();
                Form1 NuevaVentana = new Form1();
                NuevaVentana.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta...");
                txtpassword.Text = "";
                txtuser.Text = "";
                txtuser.Focus();
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

