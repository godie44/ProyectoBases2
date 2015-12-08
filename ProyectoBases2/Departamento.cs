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
    public partial class Departamento : Form
    {
        public Departamento()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DepartamentoEn dep = new DepartamentoEn();

                dep.Desc_departamento = txtDepartamento.Text;

                UsuarioLn.RegistrarDepartamento(dep);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al ingresar el departamento. " + ex.Message);
            }

        }
    }
}
