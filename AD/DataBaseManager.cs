using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AD
{
    private class DataBaseManager
    {
        private static SqlConnection con;
        
        public SqlConnection Con
        {
            get
            {
                return con;
            }

            set
            {
                con = value;
            }
        }

        public static SqlConnection OpenSqlDatabase(string _user, string _pass,string _server)
        {
            try
            {

                if (con == null || con.State == System.Data.ConnectionState.Closed)
                {
                    con = new SqlConnection("Data Source=" + _server + ";User Id=" + _user + ";Password=" + _pass);
                    con.Open();
                }
                return con;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public static void CloseSqlDatabase()
        {
            try
            {
                if (con != null || con.State == System.Data.ConnectionState.Open)
                {

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
