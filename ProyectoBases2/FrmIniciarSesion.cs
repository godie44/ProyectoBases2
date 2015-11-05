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
using EN;

namespace ProyectoBases2
{
    public partial class FrmIniciarSesion : Form
    {
        public FrmIniciarSesion()
        {
            InitializeComponent();
        }

        private void lblVerificar_Click(object sender, EventArgs e)
        {
            if (!txtPass.Text.Equals("") &&
               !txtServidor.Text.Equals("") &&
               !txtUserName.Text.Equals(""))
            {
                List<string> lstBases = UsuarioLn.BasesDisponibles(txtUserName.Text, txtPass.Text, txtServidor.Text);

                if (lstBases.Count > 0)
                {
                    cbBase.Enabled = true;
                    lstBases.ForEach(a => cbBase.Items.Add(a));

                    txtPass.Enabled = false;
                    txtServidor.Enabled = false;
                    txtUserName.Enabled = false;

                }

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool response = UsuarioLn.setSesion(txtUserName.Text, txtPass.Text, txtServidor.Text, cbBase.SelectedItem.ToString());

            if (!response)
            {
                MessageBox.Show("No se pudo iniciar sesion.");
            }
            else
            {
                this.Close();
            }

        }
    }
}
