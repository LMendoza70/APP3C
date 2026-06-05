using Calificaciones.Cafeteria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP3C.Cafeteria
{
    public partial class frmCafeteria : Form
    {
        private List<Bebida> bebidas;
       
        public frmCafeteria()
        {
            InitializeComponent();
            bebidas = new List<Bebida>();
            
        }

        private void rdbCaliente_CheckedChanged(object sender, EventArgs e)
        {
            if( rdbCaliente.Checked==true)
            {
                lblExtra.Text = "Temperatura";
            }
            else
            {
                lblExtra.Text = "Cantidad de hielo";
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            float precio= float.Parse( txtPrecio.Text.Trim());
            string tamaño=cmbtamaño.Text;
            int extra= int.Parse( txtExtra.Text.Trim());

            if (rdbCaliente.Checked == true)
            {
                bebidas.Add(new BebidaCaliente(nombre, tamaño, precio, extra));
            }
            else
            {
                bebidas.Add(new BebidaFria(nombre, tamaño, precio, extra));
            }

            MessageBox.Show("Bebida agregada correctamente, tienes : "+bebidas.Count + " bebidas registradas");
            LimpiaCajas();
        }

        private void LimpiaCajas()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtExtra.Clear();
            cmbtamaño.SelectedValue = 0;
        }
    }
}
