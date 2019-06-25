using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTKDTO
{
    public class LoaiTietKiemDTO
    {
        private string strMaLTK;
        private string strTenLTK;
        private float fLaiSuat;
        private int iKyHan;
        public string StrMaLTK { get => strMaLTK; set => strMaLTK = value; }
        public string StrTenLTK { get => strTenLTK; set => strTenLTK = value; }

        public float FLaiSuat { get => fLaiSuat; set => fLaiSuat = value; }
        public int IKyHan { get => iKyHan; set => iKyHan = value; }
        public LoaiTietKiemDTO()
        {
            fLaiSuat = -1;
        }
        public LoaiTietKiemDTO(string MaLTK, string TenLTK, float LaiSuat, int KyHan)
        {
            this.strMaLTK = MaLTK;
            this.strTenLTK = TenLTK;
            this.fLaiSuat = LaiSuat;
            this.iKyHan = KyHan;
        }
    }

}
