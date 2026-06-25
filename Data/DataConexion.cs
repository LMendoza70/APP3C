using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP3C.Data
{
    internal class DataConexion
    {
        //Cadena de coneccion 
        private readonly string Cadena;

        public DataConexion()
        {
            Cadena = "Server=189.240.192.140; Database=bdescuelaterceros; Uid=grupo3a; Pwd=grupo3a; Port=3306";
        }

        //metodo para abrir la coneccion a la base de datos 
        public MySqlConnection ObtenerConeccion()
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(Cadena);
                conexion.Open();
                //MessageBox.Show("Conectado exitosamente...");
                return conexion;
            }
            catch (MySqlException ex)
            {
                //MessageBox.Show("Error al conectar a la base de datos "+ex.ToString());
                return null;
            }
        }

    }
}

