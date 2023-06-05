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

namespace Proyecto_Final
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textCodigoo_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                String codigo = textCodigoo.Text;

                MySql.Data.MySqlClient.MySqlConnection conexion = Conexion.conexion();
                conexion.Open();

                String sql = "SELECT * FROM productos WHERE codigo= '" + codigo + "'";

                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, conexion);
                    MySqlDataReader dataReader = comando.ExecuteReader();

                    if (dataReader.Read())
                    {
                        int n = tablaVentas.Rows.Add();
                        tablaVentas.Rows[n].Cells[0].Value = dataReader.GetValue(2);
                        tablaVentas.Rows[n].Cells[1].Value = dataReader.GetValue(1);
                        tablaVentas.Rows[n].Cells[2].Value = dataReader.GetValue(3);
                        tablaVentas.Rows[n].Cells[3].Value = 1;
                        tablaVentas.Rows[n].Cells[4].Value = dataReader.GetValue(3);

                        if(tablaVentas.Rows.Count >1)
                        {
                            int sumaTotal = 0;
                            for (int row = 0; row < tablaVentas.Rows.Count; row++) {
                                if(tablaVentas.Rows[row].Cells[4].Value != null)
                                {
                                    string valor = "";
                                    valor = tablaVentas.Rows[row].Cells[4].Value.ToString();
                                    if (valor != "" && valor != null)
                                    {
                                        sumaTotal += int.Parse(valor);
                                    }
                                }
                            }
                            total.Text = "$" + sumaTotal.ToString();
                        } else
                        {
                            total.Text = "$"+dataReader.GetValue(3).ToString();
                        }

                        

                    } else
                    {
                        MessageBox.Show("El código no corresponde con ningún producto");
                    }

                } catch (Exception ex) {

                }
                finally { conexion.Close(); }

            }
        }

        private void tablaVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonProducto_Click(object sender, EventArgs e)
        {
            FormProducto producto = new FormProducto();
            producto.Show();
            this.Hide();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            InicioApp inicio = new InicioApp();
            inicio.Show();
            this.Hide();
        }
    }
}
