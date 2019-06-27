using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTKDTO
{
    public class BaoCaoDoanhSoNgayDTO
    {
        private string strMaBCDSN;
        private string strNgayBCDS;
        private double dTongThu;
        private double dTongChi;
        private double dChenhLech;
        private string strMaLTK;
        public string StrMaBCDSN { get => strMaBCDSN; set => strMaBCDSN = value; }
        public string StrNgayBCDS { get => strNgayBCDS; set => strNgayBCDS = value; }
        public double DTongThu { get => dTongThu; set => dTongThu = value; }
        public double DTongChi { get => dTongChi; set => dTongChi = value; }
        public double DChenhLech { get => dChenhLech; set => dChenhLech = value; }
        public string StrMaLTK { get => strMaLTK; set => strMaLTK = value; }
        public BaoCaoDoanhSoNgayDTO(string MaLTK)
        {
            strMaBCDSN = "0";
            strNgayBCDS = DateTime.Now.ToString();
            dTongThu = 0;
            dTongChi = 0;
            dChenhLech = 0;
            strMaLTK = MaLTK;
        }
        public BaoCaoDoanhSoNgayDTO()
        {
            strNgayBCDS = DateTime.Now.Date.ToString();
            dTongThu = 0;
            dTongChi = 0;
            dChenhLech = 0;
        }
    }
}
