using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN
{
    public class UsuariosEn
    {
        string user_name;
        int id_usuario;
        string nombre;
        string apellido1;
        string apellido2;
        string password;
        string estado;
        DateTime fec_ultimo_cambio;
        DepartamentoEn departamento;


        public UsuariosEn()
        {
            user_name = string.Empty;
            id_usuario = 0;
            nombre = string.Empty;
            apellido1 = string.Empty;
            apellido2 = string.Empty;
            password = string.Empty;
            estado = string.Empty;
            fec_ultimo_cambio = DateTime.MinValue;
            departamento = new DepartamentoEn();
        }

        public string User_name
        {
            get
            {
                return user_name;
            }

            set
            {
                user_name = value;
            }
        }

        public int Id_usuario
        {
            get
            {
                return id_usuario;
            }

            set
            {
                id_usuario = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellido1
        {
            get
            {
                return apellido1;
            }

            set
            {
                apellido1 = value;
            }
        }

        public string Apellido2
        {
            get
            {
                return apellido2;
            }

            set
            {
                apellido2 = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public DateTime Fec_ultimo_cambio
        {
            get
            {
                return fec_ultimo_cambio;
            }

            set
            {
                fec_ultimo_cambio = value;
            }
        }

        public DepartamentoEn Departamento
        {
            get
            {
                return departamento;
            }

            set
            {
                departamento = value;
            }
        }
    }
}
