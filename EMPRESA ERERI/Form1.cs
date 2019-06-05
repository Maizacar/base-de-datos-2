using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EMPRESA_ERERI
{
    public partial class Form1 : Form
    {
        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=ereri; Uid=Maiza; Pwd=maizacardona;");


        public Form1()

        {

            InitializeComponent();
        }


        private void btnconectar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                MessageBox.Show("Ya esta conectado.");
                conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha conectado");
            }
        }

        private void Btnseleccionar_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand(" select * from persona", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;

        }
        private void Btnagregar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string Query = "INSERT INTO persona (Cd_Persona, Nombres_Persona, Apellidos_Personas, Correo_Personas, Telefono, Celular) values ('" + codigo.Text + "','" + nombre.Text + "','" + apellido.Text + "','" + correo.Text + "','" + telefono.Text + "','" + celular.Text + "');";
            MySqlCommand comando = new MySqlCommand(Query, conexion);

            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se ha insertado la persona" + nombre.Text);
            codigo.Clear();
            nombre.Clear();
            apellido.Clear();
            correo.Clear();
            telefono.Clear();
            celular.Clear();


        }
        private void Btneliminar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            String Query = "DELETE FROM persona WHERE Cd_Persona='" + codigo.Text + "';";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Ya lo borrastes");
            codigo.Clear();

        }
        private void Btnactualizar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            String Query = "UPDATE persona SET Cd_Persona='" + codigo.Text +
                "',Nombres_Persona='" + nombre.Text +
                "',Apellidos_Personas='" + apellido.Text +
                "',Correo_Personas='" + correo.Text +
                "',Telefono='" + telefono.Text +
                "',Celular='" + celular.Text +
                "'WHERE Cd_Persona='" + codigo.Text +
                "';";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Ya se ha actualizado");
            codigo.Clear();
            nombre.Clear();
            apellido.Clear();
            correo.Clear();
            telefono.Clear();
            celular.Clear();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nmbre_Click(object sender, EventArgs e)
        {

        }

        private void codigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
