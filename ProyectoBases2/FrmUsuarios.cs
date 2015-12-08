using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EN;
using LN;


namespace ProyectoBases2
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void brnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuariosEn user = new UsuariosEn();
                Rol_X_Usuario rol = new Rol_X_Usuario();

                user.Nombre = txtNombre.Text;
                user.Apellido1 = txtApellido1.Text;
                user.Apellido2 = txtApellido2.Text;
                user.Departamento.Id_departamento = Convert.ToInt32(cbDepartamento.SelectedValue);
                user.Departamento.Desc_departamento = cbDepartamento.SelectedText;
                user.Estado = cbEstado.SelectedText;
                user.Password = Encriptar.MD5Hash(txtPassword.Text);
                user.User_name = txtUsuario.Text;

                UsuarioLn.RegistrarUsuario(user);

                

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al ingresar el usuario: "+ex.Message);
            }
        }
    }
}
