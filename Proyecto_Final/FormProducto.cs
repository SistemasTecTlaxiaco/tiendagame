using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_Final
{
    public partial class FormProducto : Form
    {
        public FormProducto()
        {
            InitializeComponent();
        }

        public void limpiarCampos()
        {
            textNombre.Text = "";
            textCodigo.Text = "";
            textPrecio.Text = "";
            textCantidad.Text = "";
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            String nombre = textNombre.Text;
            String codigo = textCodigo.Text;
            double precio = Double.Parse(textPrecio.Text);
            int cantidad = int.Parse(textCantidad.Text);

            string sql = "INSERT INTO productos(nombre, codigo, precio, cantidad) VALUES ('" + nombre + "','" + codigo + "','" + precio + "','" + cantidad + "')";
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

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();

        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            Form3 tienda = new Form3();
            tienda.Show();
            this.Hide();
        }
    }
}
