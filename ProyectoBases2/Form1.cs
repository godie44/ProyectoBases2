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

        public static bool sesion = false;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (sesionToolStripMenuItem.Text.Equals("Iniciar Sesion"))
            {
                FrmIniciarSesion frmIniciar = new FrmIniciarSesion();
                frmIniciar.MdiParent = this;

                frmIniciar.Show();
            }
            else if(sesionToolStripMenuItem.Text.Equals("Cerrar Sesion"))
            {
                DialogResult result = MessageBox.Show("Desea cerrar sesion?", "Confirmation", System.Windows.Forms.MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    UsuarioLn.CerrarSesion();
                }
                else if (result == DialogResult.No)
                {

                }
            }
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sesion = UsuarioLn.SesionStatus();

            if (sesion)
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
