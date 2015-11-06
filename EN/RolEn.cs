using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN
{
    public class RolEn
    {
        string desc_rol;
        int id_rol;

        public RolEn()
        {
            desc_rol = string.Empty;
            id_rol = 0;
        }

        public string Desc_rol
        {
            get
            {
                return desc_rol;
            }

            set
            {
                desc_rol = value;
            }
        }

        public int Id_rol
        {
            get
            {
                return id_rol;
            }

            set
            {
                id_rol = value;
            }
        }
    }
}
