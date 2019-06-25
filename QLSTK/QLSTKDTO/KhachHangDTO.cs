using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTKDTO
{
    public class KhachHangDTO
    {
        private string strMaKH;
        private string strHoTenKH;
        private string strDiaChi;
        private string strCMND;
        public string StrMaKH { get => strMaKH; set => strMaKH = value; }
        public string StrHoTenKH { get => strHoTenKH; set => strHoTenKH = value; }
        public string StrDiaChi { get => strDiaChi; set => strDiaChi = value; }
        public string StrCMND { get => strCMND; set => strCMND = value; }
        public KhachHangDTO() { }

    }
}
