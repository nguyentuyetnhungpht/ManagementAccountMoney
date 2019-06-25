using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTKDTO
{
    public class TaiKhoanDTO
    {
        private string MaTaiKhoan;
        private string TenTaiKhoan;
        private string MatKhau;
        private int MaLoaiTaiKhoan;

        public TaiKhoanDTO() { }

        public string MaTaiKhoan1 { get => MaTaiKhoan; set => MaTaiKhoan = value; }
        public string TenTaiKhoan1 { get => TenTaiKhoan; set => TenTaiKhoan = value; }
        public string MatKhau1 { get => MatKhau; set => MatKhau = value; }
        public int MaLoaiTaiKhoan1 { get => MaLoaiTaiKhoan; set => MaLoaiTaiKhoan = value; }
    }
}
