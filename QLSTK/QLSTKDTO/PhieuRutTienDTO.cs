using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTKDTO
{
    public class PhieuRutTienDTO
    {
        private string strMaSoPRT;
        private string strNgayRut;
        private double dSoTienRut;
        private string strMaSTK;
        public string StrMaSoPRT { get => strMaSoPRT; set => strMaSoPRT = value; }
        public string StrNgayRut { get => strNgayRut; set => strNgayRut = value; }
        public double DSoTienRut { get => dSoTienRut; set => dSoTienRut = value; }
        public string StrMaSTK { get => strMaSTK; set => strMaSTK = value; }
        public PhieuRutTienDTO() { }
    }
}
