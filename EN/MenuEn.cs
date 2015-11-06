using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN
{
    public class MenuEn
    {
        int id_menu;
        string cod_objeto;
        string desc_menu;


        public MenuEn()
        {
            id_menu = 0;
            cod_objeto = string.Empty;
            desc_menu = string.Empty;
        }

        public int Id_menu
        {
            get
            {
                return id_menu;
            }

            set
            {
                id_menu = value;
            }
        }

        public string Cod_objeto
        {
            get
            {
                return cod_objeto;
            }

            set
            {
                cod_objeto = value;
            }
        }

        public string Desc_menu
        {
            get
            {
                return desc_menu;
            }

            set
            {
                desc_menu = value;
            }
        }
    }
}
