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

        public static bool CerrarSesion()
        {
            bool response = false;

            response = ConsultasAd.Sesion();

            if (response)
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


        public static List<MenuEn> ConsultaMenu(UsuariosEn _usuario)
        {
            try
            {
                return ConsultasAd.ConsultaMenu(_usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static void RegistrarDepartamento(DepartamentoEn _departamento)
        {
            try
            {
                ConsultasAd.RegistrarDepartamento(_departamento);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void RegistrarMenu(MenuEn _menu)
        {
            try
            {
                ConsultasAd.RegistrarMenu(_menu);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void RegistrarRol(RolEn _rol)
        {
            try
            {
                ConsultasAd.RegistrarRol(_rol);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void RegistrarPermisos(PermisoEn _permiso)
        {
            try
            {
                ConsultasAd.RegistrarPermisos(_permiso);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void RegistrarPermisoRol(Permiso_X_Rol _permiso_x_rol)
        {
            try
            {
                ConsultasAd.RegistrarPermisoRol(_permiso_x_rol);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void RegistrarUsuario(UsuariosEn _usuario)
        {
            try
            {
                ConsultasAd.RegistrarUsuario(_usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void RegistrarRolesXMenu(Rol_X_Menu _rol_x_menu)
        {
            try
            {
                ConsultasAd.RegistrarRolesXMenu(_rol_x_menu);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void RegistrarRolesXUsuario(Rol_X_Usuario _rol_x_usuario)
        {
            try
            {
                ConsultasAd.RegistrarRolesXUsuario(_rol_x_usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
