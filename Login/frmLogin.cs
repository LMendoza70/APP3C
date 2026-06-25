using APP3C.Data;
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

namespace APP3C.Login
{
    public partial class frmLogin : Form
    {
        private frmPrincipal principal;
        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //resctar los campos 
            string usuario = txtUser.Text.Trim();
            string password=txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(password))
            {
                lblleyenda.Text = "El usuario o la contraseña no pueden \n ir vacios";
                lblleyenda.Visible = true;
                return;
            }
                //conectamos a la base de datos 
                DataConexion coneccion = new DataConexion();
                MySqlConnection conn = coneccion.ObtenerConeccion();

            //verificamos si conecta o no
            if (conn == null) return;

            try
            {
                string consulta = "select * from tblusuarios where nombreUsuario=@nombre";

                //creamos un command para poder ejecutar la consulta
                MySqlCommand command=new MySqlCommand(consulta, conn);
                command.Parameters.AddWithValue("@nombre", usuario);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    //rescatamos el password hash
                    string passhash = reader["PASSWORD"].ToString();
                    //verificamos si la contraseña escrita coincide 
                    bool verifica= BCrypt.Net.BCrypt.Verify(password, passhash);
                    if (verifica == true)
                    {
                        MessageBox.Show("Acceso correcto...");
                        conn.Close();
                        this.Hide();
                        principal = new frmPrincipal();
                        principal.Show();
                    }
                    else
                    {
                        conn.Close();
                        lblleyenda.Text = "Credenciales Incorrectas\nIntenta de nuevo";
                        lblleyenda.Visible=true;
                        txtUser.Clear();
                        txtPassword.Clear();
                        txtUser.Focus();
                    }
                }
                else
                {
                    conn.Close();
                    lblleyenda.Text = "Credenciales Incorrectas\nIntenta de nuevo";
                    lblleyenda.Visible = true;
                    txtUser.Clear();
                    txtPassword.Clear();
                    txtUser.Focus();
                }
           
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado : "+ex.Message);
            }

        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            lblleyenda.Visible=false;
        }
    }
}
