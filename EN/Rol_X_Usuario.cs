using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN
{
    public class Rol_X_Usuario
    {
        UsuariosEn usuario;
        RolEn rol;


        public Rol_X_Usuario()
        {
            usuario = new UsuariosEn();
            rol = new RolEn();
        }

        public UsuariosEn Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public RolEn Rol
        {
            get
            {
                return rol;
            }

            set
            {
                rol = value;
            }
        }
    }
}
