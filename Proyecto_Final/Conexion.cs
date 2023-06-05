using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Proyecto_Final
{
    internal class Conexion
    {
        public static MySql.Data.MySqlClient.MySqlConnection conexion()
        {
            string cadenaConexion = "SERVER = 127.0.0.1; PORT=3306; DATABASE=datadab; UID=root;PASSWORD=;";
            try
            {
                MySql.Data.MySqlClient.MySqlConnection conexion = new MySql.Data.MySqlClient.MySqlConnection(cadenaConexion);
                return conexion;
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
            
    }
}
