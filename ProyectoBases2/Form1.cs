using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LN;

namespace ProyectoBases2
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIniciarSesion frmIniciar = new FrmIniciarSesion();
            frmIniciar.MdiParent = this;

            frmIniciar.Show();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool status = UsuarioLn.SesionStatus();

            if (status)
            {
                sesionToolStripMenuItem.Text = "Cerrar Sesion";
            }
            else
            {
                sesionToolStripMenuItem.Text = "Iniciar Sesion";
            }
        }
    }
}
