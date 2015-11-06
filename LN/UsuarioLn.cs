using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AD;
using EN;

namespace LN
{
    public class UsuarioLn
    {
        public static List<string> BasesDisponibles(string _user, string _pass, string _servidor)
        {
            try
            {
                ConsultasAd.User = _user;
                ConsultasAd.Servidor = _servidor;
                ConsultasAd.Pass = _pass;
                ConsultasAd.BaseDatos = string.Empty;
                return ConsultasAd.BasesDisponibles();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool setSesion(string _user, string _pass, string _servidor, string _db)
        {
            bool response = false;

            ConsultasAd.User = _user;
            ConsultasAd.Servidor = _servidor;
            ConsultasAd.Pass = _pass;
            ConsultasAd.BaseDatos = _db;

			response = ConsultasAd.Sesion();

			if(!response)
            {
                ConsultasAd.User = "";
                ConsultasAd.Servidor = "";
                ConsultasAd.Pass = "";
                ConsultasAd.BaseDatos = "";
            }

            return response;

        }


        public static bool SesionStatus()
        {
            bool response = false;


            if (!ConsultasAd.User.Equals("") &&
                !ConsultasAd.Servidor.Equals("") &&
                !ConsultasAd.Pass.Equals("") &&
                !ConsultasAd.BaseDatos.Equals(""))
            {
                response = true;
            }


            return response;

        }



    }
}
