using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAO
{
    public class DataProvider
    {
        private SqlConnection cn = null;
        public string cnstring = ConfigurationManager.ConnectionStrings["Ketnoi"].ConnectionString;

        public DataProvider()
        {
            cn = new SqlConnection(cnstring);
        }

        public void Connect()
        {
            try
            {
                if (cn != null && cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (ConfigurationErrorsException ex)
            {
                throw ex;
            }

        }
        public void DisConnect()
        {
            if (cn != null && cn.State != ConnectionState.Closed)
            {
                cn.Close();
            }
        }

        public SqlDataReader ExcuteReader( string sql)
        {
             SqlCommand cmd = new SqlCommand(sql, cn);
            return cmd.ExecuteReader();
        }

        public int ExecuteNonQuery(string sql, List<SqlParameter> parameters, CommandType type)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = type;

            if(parameters != null)
            {
                foreach (SqlParameter para in parameters)
                {
                    cmd.Parameters.Add(para);
                }
            }
            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }
    }
}
