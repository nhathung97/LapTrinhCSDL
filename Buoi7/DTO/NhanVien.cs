using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class NhanVien
    {
        private int MaNV;
        private string HoNV;
        private string Ten;
        private string Diachi;
        private string Dienthoai;

        //public NhanVien(int id, string ho, string ten, string diachi, string dienthoai)
        //{
        //    this.maNV = id;
        //    this.HoNV = ho;
        //    this.Ten = ten;
        //    this.Diachi = diachi;
        //    this.Dienthoai = dienthoai;
        //}

        public int maNV
        {
            get { return MaNV; }
            set { MaNV = value; }
        }
        public string hoNV
        {
            get { return HoNV; }
            set { HoNV = value; }
        }
        public string ten
        {
            get { return Ten; }
            set { Ten = value; }
        }
        public string diaChi
        {
            get { return Diachi; }
            set { Diachi = value; }
        }
        public string sdt
        {
            get { return Dienthoai; }
            set { Dienthoai = value; }
        }
    }
}
