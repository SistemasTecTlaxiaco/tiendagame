using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.Common;


namespace Proyecto_Final
{
    public partial class InicioSesi : Form
    {
        public InicioSesi()
        {
            InitializeComponent();
        }

        private void but_InicioSecion_Click(object sender, EventArgs e)
        {
            String usuario = texb_Usuario.Text;
            String password = Tex_Pass.Text;

            MySql.Data.MySqlClient.MySqlConnection conexion = Conexion.conexion();
            conexion.Open();

            String sql = "SELECT * FROM usuarios WHERE usuario= '" + usuario + "' AND password='"+password+"'";

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                MySqlDataReader dataReader = comando.ExecuteReader();

                if (dataReader.Read())
                {
                    if (dataReader.GetValue(3).ToString() == usuario && dataReader.GetValue(4).ToString() == password)
                    {
                        InicioApp inicio = new InicioApp();
                        inicio.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o contraseña no válidos!");
                    }
                } else
                {
                    MessageBox.Show("Usuario y/o contraseña no válidos!");
                }



            } catch (Exception ex)
            {
                MessageBox.Show("Usuario y/o contraseña no válidos!", ex.ToString());
            } finally {conexion.Close(); }
           
        }
 
             

        private void But_CancelInSe_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void But_LimUsCon_Click(object sender, EventArgs e)
        {
            texb_Usuario.Text = "";
            Tex_Pass.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void texb_Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tex_Contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            this.Hide();
        }
    }

    internal class MySqlConnection
    {
        private string connectionString;

        public MySqlConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}
