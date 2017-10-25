using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DTO;
using DAO;

namespace BUS
{
   public class NhanvienBUS
    {
        public List<NhanVien> GetData()
        {
            try
            {
                return  new NhanVienDAO().LoadData();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        
        public int Delete(int id)
        {
            try
            {
                return (new NhanVienDAO().Delete(id));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
