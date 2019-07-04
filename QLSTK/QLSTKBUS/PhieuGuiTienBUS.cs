using QLSTKDAL;
using QLSTKDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTKBUS
{
    public class PhieuGuiTienBUS
    {
        private PhieuGuiTienDAL ltkDAL;
        public PhieuGuiTienBUS()
        {
            this.ltkDAL = new PhieuGuiTienDAL();
        }
        public bool them(PhieuGuiTienDTO pgt)
        {
            bool re = ltkDAL.themPhieuGuiTien(pgt);
            if(re == true)
            {

            }
            return re;
        }
        public string getNewMaSo()
        {
            return ltkDAL.newMaSo();
        }
    }
}