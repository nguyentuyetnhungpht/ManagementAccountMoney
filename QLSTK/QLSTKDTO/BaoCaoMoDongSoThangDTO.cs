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
        private int iNgayBCMDST;
        private int iSoMo;
        private int iSoDong;
        private int iChenhLechSo;
        private string strMaLTK;
        private string StrMaBCMDST { get => strMaBCMDST; set => strMaBCMDST = value; }
        public int IThangBCMDST { get => iThangBCMDST; set => iThangBCMDST = value; }
        public int INgayBCMDST { get => iNgayBCMDST; set => iNgayBCMDST = value; }
        public int ISoMo { get => iSoMo; set => iSoMo = value; }
        public int IChenhLechSo { get => iChenhLechSo; set => iChenhLechSo = value; }
        public string StrMaLTK { get => strMaLTK; set => strMaLTK = value; }
        public BaoCaoMoDongSoThangDTO() { }
    }
}
