using QLSTKDAL;
using QLSTKDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTKBUS
{
    public class KhachHangBUS
    {
        private KhachHangDAL khDAL;
        public KhachHangBUS()
        {
            this.khDAL = new KhachHangDAL();
        }
        public bool them(KhachHangDTO kh)
        {
            bool re = khDAL.themKhachHang(kh);
            return re;
        }
        public bool xoa(KhachHangDTO kh)
        {
            bool re = khDAL.xoaKhachHang(kh);
            return re;
        }
        public bool sua(KhachHangDTO kh)
        {
            bool re = khDAL.suaKhachHang(kh);
            return re;
        }
        public KhachHangDTO getKhachHang(string maKH)
        {
            return khDAL.getKhachHang(maKH);
        }
        public string getNewMaSo()
        {
            return khDAL.newMaSo();
        }
    }
}
