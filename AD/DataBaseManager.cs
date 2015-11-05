using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AD
{
    class DataBaseManager
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

        public static SqlConnection OpenSqlDatabase(string _user, string _pass,string _server,string _db)
        {
            try
            {

                if (con == null || con.State == System.Data.ConnectionState.Closed)
                {
                    string conString = _db.Equals("")?"Data Source=" + _server + ";User Id=" + _user + ";Password=" + _pass :
                                                      "Data Source=" + _server + ";User Id=" + _user + ";Password=" + _pass+";Initial Catalog="+_db;

                    con = new SqlConnection(conString);
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
