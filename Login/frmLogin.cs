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
            DataConexion coneccion= new DataConexion();
            MySqlConnection conn = coneccion.ObtenerConeccion();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text.Trim();
            string password=txtPassword.Text.Trim();

            if(usuario=="luis" && password == "mendoza")
            {
                principal = new frmPrincipal();
                principal.Show();
                this.Hide();
            }
            else
            {
                lblleyenda.Text = "Credenciales Incorrectas\nIntenta de nuevo";
                lblleyenda.Visible = true;
                txtUser.Clear();
                txtPassword.Clear();
                //txtUser.Focus();
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            lblleyenda.Visible=false;
        }
    }
}
