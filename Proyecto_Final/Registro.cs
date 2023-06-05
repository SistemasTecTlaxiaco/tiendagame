using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Proyecto_Final
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        public void limpiarCampos()
        {
            nombre.Text = "";
            apellidos.Text = "";
            usuario.Text = "";
            password.Text = "";
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            String nombree = nombre.Text;
            String apellido = apellidos.Text;
            String usuarioo = usuario.Text;
            String pass = password.Text;

            string sql = "INSERT INTO usuarios(nombre, apellido, usuario, password) VALUES ('" + nombree + "','" + apellido + "','" + usuarioo + "','" + pass + "')";

            MySql.Data.MySqlClient.MySqlConnection conexion = Conexion.conexion();
            conexion.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.ExecuteNonQuery();
                limpiarCampos();
                MessageBox.Show("Registro guardado");
            } catch (Exception ex)
            {
                MessageBox.Show("Error al guardar" + ex.ToString());
            } finally { conexion.Close(); }

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            InicioSesi inicio = new InicioSesi();
            inicio.Show();
            this.Hide();
        }
    }
}
