using QLSTKDAL;
using QLSTKDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTKBUS
{
    public class PhieuRutTienBUS
    {
        private PhieuRutTienDAL ltkDAL;
        public PhieuRutTienBUS()
        {
            this.ltkDAL = new PhieuRutTienDAL();
        }
        public bool them(PhieuRutTienDTO prt)
        {
            bool re = ltkDAL.themPhieuRutTien(prt);
            return re;
        }
    }
}
