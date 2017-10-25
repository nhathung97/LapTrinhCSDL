using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class NhanVienDAO:DataProvider
    {
        private DataProvider dp;

        public NhanVienDAO()
        {
            dp = new DataProvider();
        }

        public List<NhanVien> LoadData()
        {
            List<NhanVien> list = new List<NhanVien>();
            try
            {
                dp.Connect();
                string sql = "Select * from NhanVien";
                SqlDataReader dr = dp.ExcuteReader(sql);
                
                while (dr.Read())
                {
                    NhanVien nv = new NhanVien();
                    nv.maNV = dr.GetInt32(0);
                    nv.hoNV = dr.GetString(1);
                    nv.ten = dr.GetString(2);
                    nv.diaChi = dr.GetString(3);
                    nv.sdt = dr.GetString(4);
                    list.Add(nv);
                }
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
                dp.DisConnect();
            }
            return list;
        }

        public int Delete(int id)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("id", id));

            string sql = "uspDeleteNhanVien";
            CommandType type = CommandType.StoredProcedure;
            try
            {
                return (ExecuteNonQuery(sql,parameters,type));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
        }


    } 
}
