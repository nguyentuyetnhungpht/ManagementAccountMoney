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
        private int iNamBCMDST;
        private string strNgayBCMDST;
        private int iSoMo;
        private int iSoDong;
        private int iChenhLechSo;
        private string strMaLTK;
        public string StrMaBCMDST { get => strMaBCMDST; set => strMaBCMDST = value; }
        public int IThangBCMDST { get => iThangBCMDST; set => iThangBCMDST = value; }

        public int ISoMo { get => iSoMo; set => iSoMo = value; }
        public int IChenhLechSo { get => iChenhLechSo; set => iChenhLechSo = value; }
        public int ISoDong { get => iSoDong; set => iSoDong = value; }
        public string StrNgayBCMDST { get => strNgayBCMDST; set => strNgayBCMDST = value; }
        public int INamBCMDST { get => iNamBCMDST; set => iNamBCMDST = value; }
        public string StrMaLTK { get => strMaLTK; set => strMaLTK = value; }

        public BaoCaoMoDongSoThangDTO()
        {
            strNgayBCMDST = DateTime.Now.ToString();
            iThangBCMDST = DateTime.Now.Month;
            INamBCMDST = DateTime.Now.Year;
            iSoMo = 0;
            iSoDong = 0;
            iChenhLechSo = 0;

        }
        public BaoCaoMoDongSoThangDTO(DateTime dt)
        {
            strNgayBCMDST = dt.Date.ToString();
            iThangBCMDST = dt.Month;
            INamBCMDST = dt.Year;
            iSoMo = 0;
            iSoDong = 0;
            iChenhLechSo = 0;
        }
    }
}
