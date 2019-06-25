using QLSTKDAL;
using QLSTKDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTKBUS
{
    public class TaiKhoanBUS
    {
        private TaiKhoanDAL tkDAL = new TaiKhoanDAL();

        public bool KiemTra(string tenTK, string matkhau, ref bool isOK, ref int loaiTK)
        {
            return tkDAL.KiemTra(tenTK, matkhau, ref isOK, ref loaiTK);
        }

        public bool Update(string tenTK, string matkhaumoi, ref bool isOK)
        {
            return tkDAL.Update(tenTK, matkhaumoi, ref isOK);
        }
    }
}
