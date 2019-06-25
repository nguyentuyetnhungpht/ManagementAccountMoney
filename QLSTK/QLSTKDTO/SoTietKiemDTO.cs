using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTKDTO
{
    public class SoTietKiemDTO
    {
        private string strMaSoSTK;
        private string strMaKH;
        private double dSoTienGui;
        private string strMaLTK;
        private string strNgayMoSo;
        private double dTienLai;
        private int iSoLanDaoHan;
        private double dSoDu;
        private float fLaiSuatCamKet;
        private int iKyHanCamKet;
        public string StrMaSoSTK { get => strMaSoSTK; set => strMaSoSTK = value; }
        public string StrMaKH { get => strMaKH; set => strMaKH = value; }
        public double DSoTienGui { get => dSoTienGui; set => dSoTienGui = value; }
        public string StrMaLTK { get => strMaLTK; set => strMaLTK = value; }
        public string StrNgayMoSo { get => strNgayMoSo; set => strNgayMoSo = value; }
        public double DTienLai { get => dTienLai; set => dTienLai = value; }
        public int ISoLanDaoHan { get => iSoLanDaoHan; set => iSoLanDaoHan = value; }
        public double DSoDu { get => dSoDu; set => dSoDu = value; }
        public float FLaiSuatCamKet { get => fLaiSuatCamKet; set => fLaiSuatCamKet = value; }
        public int IKyHanCamKet { get => iKyHanCamKet; set => iKyHanCamKet = value; }
        

        public SoTietKiemDTO()
        {
            
        }
        public SoTietKiemDTO(string Maso, string MaKhachHang, double SoTienGui, string MaLTK, float LaiSuat, int KyHan)
        {
            this.strMaSoSTK = Maso;
            this.strMaKH = MaKhachHang;
            this.dSoTienGui = SoTienGui;
            this.strMaLTK = MaLTK;
            this.StrNgayMoSo = (DateTime.Now).ToString();
            this.dTienLai = 0;
            this.iSoLanDaoHan = 0;
            this.dSoDu = this.dSoTienGui;
            this.fLaiSuatCamKet = LaiSuat;
            this.iKyHanCamKet = KyHan;
        }
        
    }

}
