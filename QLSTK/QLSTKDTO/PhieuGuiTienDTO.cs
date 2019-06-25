using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTKDTO
{
    public class PhieuGuiTienDTO
    {
        private string strMaSoPGT;
        private string strNgayGui;
        private double dSoTienGui;
        private string strMaSTK;
        public string StrMaSoPGT { get => strMaSoPGT; set => strMaSoPGT = value; }
        public string StrNgayGui { get => strNgayGui; set => strNgayGui = value; }
        public double DSoTienGui { get => dSoTienGui; set => dSoTienGui = value; }
        public string StrMaSTK { get => strMaSTK; set => strMaSTK = value; }
        public PhieuGuiTienDTO() { }

    }
}
