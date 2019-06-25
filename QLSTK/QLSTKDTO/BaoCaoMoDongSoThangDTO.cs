using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTKDTO
{
    public class BaoCaoMoDongSoThangDTO
    {
        private string strMaBCMDST;
        private int iThangBCMDST;
        private int iNamBCDST;
        private string strNgayBCMDST;
        private int iSoMo;
        private int iSoDong;
        private int iChenhLechSo;
        private string StrMaBCMDST { get => strMaBCMDST; set => strMaBCMDST = value; }
        public int IThangBCMDST { get => iThangBCMDST; set => iThangBCMDST = value; }
        public int INamBCDST { get => iNamBCDST; set => iNamBCDST = value; }
        public string StrNgayBCMDST { get => strNgayBCMDST; set => strNgayBCMDST = value; }
        public int ISoMo { get => iSoMo; set => iSoMo = value; }
        public int ISoDong { get => iSoDong; set => iSoDong = value; }
        public int IChenhLechSo { get => iChenhLechSo; set => iChenhLechSo = value; }
        public BaoCaoMoDongSoThangDTO(DateTime dt)
        {
            strMaBCMDST = "x";
            iThangBCMDST = dt.Month;
            iNamBCDST = dt.Year;
            strNgayBCMDST = dt.Date.ToString();
            iSoMo = 0;
            iSoDong = 0;
            iChenhLechSo = 0;
        }
    }
}