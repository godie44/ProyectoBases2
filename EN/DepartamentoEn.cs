using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN
{
    public class DepartamentoEn
    {
        int id_departamento;
        string desc_departamento;

        public DepartamentoEn()
        {
            id_departamento = 0;
            desc_departamento = string.Empty;
        }

        public int Id_departamento
        {
            get
            {
                return id_departamento;
            }

            set
            {
                id_departamento = value;
            }
        }

        public string Desc_departamento
        {
            get
            {
                return desc_departamento;
            }

            set
            {
                desc_departamento = value;
            }
        }
    }
}
