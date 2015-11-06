using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN
{
    public class Permiso_X_Rol
    {
        RolEn rol;
        PermisoEn permiso;


        public Permiso_X_Rol()
        {
            rol = new RolEn();
            permiso = new PermisoEn();
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

        public PermisoEn Permiso
        {
            get
            {
                return permiso;
            }

            set
            {
                permiso = value;
            }
        }
    }
}
