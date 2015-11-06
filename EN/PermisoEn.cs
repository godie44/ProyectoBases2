using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN
{
    public class PermisoEn
    {
        int id_permiso;
        string nombre_permiso;
        string desc_permiso;


        public PermisoEn()
        {
            id_permiso = 0;
            nombre_permiso = string.Empty;
            desc_permiso = string.Empty;
        }

        public int Id_permiso
        {
            get
            {
                return id_permiso;
            }

            set
            {
                id_permiso = value;
            }
        }

        public string Nombre_permiso
        {
            get
            {
                return nombre_permiso;
            }

            set
            {
                nombre_permiso = value;
            }
        }

        public string Desc_permiso
        {
            get
            {
                return desc_permiso;
            }

            set
            {
                desc_permiso = value;
            }
        }
    }
}
