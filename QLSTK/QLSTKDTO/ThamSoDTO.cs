using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTKDTO
{
    public class ThamSoDTO
    {
        private string strMaTS;
        private double dSoTienGuiToiThieuSTK;
        private double dSoTienGuiToiThieuPGT;
        private int iSoNgayGuiToiThieu;
        public string StrMaTS { get => strMaTS; set => strMaTS = value; }
        public double DSoTienGuiToiThieuSTK { get => dSoTienGuiToiThieuSTK; set => dSoTienGuiToiThieuSTK = value; }
        public double DSoTienGuiToiThieuPGT { get => dSoTienGuiToiThieuPGT; set => dSoTienGuiToiThieuPGT = value; }
        public int ISoNgayGuiToiThieu { get => iSoNgayGuiToiThieu; set => iSoNgayGuiToiThieu = value; }
        public ThamSoDTO()
        {
            strMaTS = "1";
            dSoTienGuiToiThieuPGT = -1;
            dSoTienGuiToiThieuSTK = -1;
            iSoNgayGuiToiThieu = -1;
        }
    }
}
