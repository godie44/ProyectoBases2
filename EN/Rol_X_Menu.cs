using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN
{
    public class Rol_X_Menu
    {
        RolEn rol;
        MenuEn menu;

        public Rol_X_Menu()
        {
            rol = new RolEn();
            menu = new MenuEn();
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

        internal MenuEn Menu
        {
            get
            {
                return menu;
            }

            set
            {
                menu = value;
            }
        }
    }
}
