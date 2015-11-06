using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EN;

namespace AD
{
    public class ConsultasAd
    {

        private static string user ="";

        public static string User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }


        private static string pass = "";
        public static string Pass
        {
            get
            {
                return pass;
            }

            set
            {
                pass = value;
            }
        }

        private static string servidor = "";
        public static string Servidor
        {
            get
            {
                return servidor;
            }

            set
            {
                servidor = value;
            }
        }

        private static string baseDatos = "";
        public static string BaseDatos
        {
            get
            {
                return baseDatos;
            }

            set
            {
                baseDatos = value;
            }
        }

        public ConsultasAd()
        {
            user = string.Empty;
            pass = string.Empty;
            servidor = string.Empty;
            BaseDatos = string.Empty;
        }


        public ConsultasAd(string _user,string _pass,string _servidor,string _baseDatos)
        {
            user = _user;
            pass = _pass;
            servidor = _servidor;
            baseDatos = _baseDatos;
        }


        public static List<String> BasesDisponibles()
        {
            List<string> response = new List<string>();
            try
            {
                using(SqlConnection con = DataBaseManager.OpenSqlDatabase(user,pass,servidor,baseDatos))
                {
                    using (SqlCommand command = con.CreateCommand())
                    {
                        command.CommandText = "sp_helpuser";
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                response.Add(dr["DefDBName"].ToString() ?? string.Empty);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response = new List<string>();
            }
            response.RemoveAll(a => a.Equals(""));
            return response.Distinct().ToList();
        }


        public static bool Sesion()
        {
            bool response = false;
            try
            {
                using (SqlConnection con = DataBaseManager.OpenSqlDatabase(user, pass, servidor, baseDatos))
                {


                    if (con.State == System.Data.ConnectionState.Open && con.Database.Equals(baseDatos))
                    {
                        response = true;
                    }


                }
            }
            catch (Exception ex)
            {
                return false;
            }
            
            return response;
        }

        public static void RegistrarUsuario(UsuariosEn _usuario)
        {
            try
            {
                using (SqlConnection con = DataBaseManager.OpenSqlDatabase(user, pass, servidor, baseDatos))
                {
                    using (SqlCommand command = con.CreateCommand())
                    {
                        command.CommandText = "sp_registrar_usuario";
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@p_username", _usuario.User_name);
                        command.Parameters.AddWithValue("@p_id_usuario", _usuario.Id_usuario);
                        command.Parameters.AddWithValue("@p_nombre", _usuario.Nombre);
                        command.Parameters.AddWithValue("@p_apellido1", _usuario.Apellido1);
                        command.Parameters.AddWithValue("@p_apellido2", _usuario.Apellido2);
                        command.Parameters.AddWithValue("@p_password", _usuario.Password);
                        command.Parameters.AddWithValue("@p_estado", _usuario.Estado);
                        command.Parameters.AddWithValue("@p_fec_ult_cambio", _usuario.Fec_ultimo_cambio);
                        command.Parameters.AddWithValue("@p_id_depa", _usuario.Departamento.Id_departamento);


                        command.ExecuteNonQuery();
                    }
                }
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
                using (SqlConnection con = DataBaseManager.OpenSqlDatabase(user, pass, servidor, baseDatos))
                {
                    using (SqlCommand command = con.CreateCommand())
                    {
                        command.CommandText = "sp_registrar_usuario";
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@p_id_rol", _rol.Id_rol);
                        command.Parameters.AddWithValue("@p_desc_rol", _rol.Desc_rol);



                        command.ExecuteNonQuery();
                    }
                }
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
                using (SqlConnection con = DataBaseManager.OpenSqlDatabase(user, pass, servidor, baseDatos))
                {
                    using (SqlCommand command = con.CreateCommand())
                    {
                        command.CommandText = "PA_MENU";
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ID_MENU", _menu.Id_menu);
                        command.Parameters.AddWithValue("@COD_OBJETO", _menu.Cod_objeto);
                        command.Parameters.AddWithValue("@DESC_MENU", _menu.Desc_menu);
                        

                        command.ExecuteNonQuery();
                    }
                }
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
                using (SqlConnection con = DataBaseManager.OpenSqlDatabase(user, pass, servidor, baseDatos))
                {
                    using (SqlCommand command = con.CreateCommand())
                    {
                        command.CommandText = "PA_PERMISOS";
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ID_PERMISO", _permiso.Id_permiso);
                        command.Parameters.AddWithValue("@NOMBRE_PERMISO", _permiso.Nombre_permiso);
                        command.Parameters.AddWithValue("@DSC_PERMISO", _permiso.Desc_permiso);


                        command.ExecuteNonQuery();
                    }
                }
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
                using (SqlConnection con = DataBaseManager.OpenSqlDatabase(user, pass, servidor, baseDatos))
                {
                    using (SqlCommand command = con.CreateCommand())
                    {
                        command.CommandText = "sp_departamento";
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ID_DEPARTAMENTO", _departamento.Id_departamento);
                        command.Parameters.AddWithValue("@DESC_DEPARTAMENTO",_departamento.Desc_departamento);



                        command.ExecuteNonQuery();
                    }
                }
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
                using (SqlConnection con = DataBaseManager.OpenSqlDatabase(user, pass, servidor, baseDatos))
                {
                    using (SqlCommand command = con.CreateCommand())
                    {
                        command.CommandText = "sp_permiso_rol";
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ID_ROL", _permiso_x_rol.Rol.Id_rol);
                        command.Parameters.AddWithValue("@ID_PERMISO", _permiso_x_rol.Rol.Id_rol);



                        command.ExecuteNonQuery();
                    }
                }
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
                using (SqlConnection con = DataBaseManager.OpenSqlDatabase(user, pass, servidor, baseDatos))
                {
                    using (SqlCommand command = con.CreateCommand())
                    {
                        command.CommandText = "sp_roles_x_menu";
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@IF_ROL", _rol_x_menu.Rol.Id_rol);
                        command.Parameters.AddWithValue("@IF_PERMISO", _rol_x_menu.Menu.Id_menu);



                        command.ExecuteNonQuery();
                    }
                }
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
                using (SqlConnection con = DataBaseManager.OpenSqlDatabase(user, pass, servidor, baseDatos))
                {
                    using (SqlCommand command = con.CreateCommand())
                    {
                        command.CommandText = "sp_roles_x_usuario";
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@IF_ROL", _rol_x_usuario.Rol.Id_rol);
                        command.Parameters.AddWithValue("@IF_PERMISO", _rol_x_usuario.Usuario.User_name);



                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static List<MenuEn> ConsultaMenu(UsuariosEn _usuario)
        {

            List<MenuEn> response = new List<MenuEn>();
            try
            {
                using (SqlConnection con = DataBaseManager.OpenSqlDatabase(user, pass, servidor, baseDatos))
                {
                    using (SqlCommand command = con.CreateCommand())
                    {
                        command.CommandText = "sp_consulta_menuxuser";
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        
                        command.Parameters.AddWithValue("@p_username", _usuario.User_name);



                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                MenuEn tmp = new MenuEn();

                                tmp.Cod_objeto = dr["cod_objeto"].ToString() ?? string.Empty;
                                tmp.Id_menu = dr["id_menu"] != DBNull.Value ?Convert.ToInt32(dr["id_menu"]) : 0;

                                response.Add(tmp);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return response;
        }


    }
}
