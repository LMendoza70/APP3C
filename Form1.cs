using APP3C.HolaMundo;
using APP3C.Cafeteria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP3C
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form calculadora = Application.OpenForms["frmCalculadora"];

            if (calculadora != null)
            {
                if (calculadora.WindowState == FormWindowState.Minimized)
                {
                    calculadora.WindowState=FormWindowState.Normal;
                }
            }
            else
            {
                calculadora = new frmCalculadora();
                calculadora.MdiParent = this;
                calculadora.FormClosed += (s, args) => calculadora.Dispose();
                calculadora.Show();
            }

        }

        private void cafeteriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cafeteria = Application.OpenForms["frmCafeteria"];
            if(cafeteria != null) 
            {
                if (cafeteria.WindowState == FormWindowState.Minimized)
                {
                    cafeteria.WindowState = FormWindowState.Normal;
                }
            }
            else
            {
                cafeteria = new frmCafeteria();
                cafeteria.MdiParent=this;
                cafeteria.FormClosed += (s, args) => cafeteria.Dispose();
                cafeteria.Show();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
