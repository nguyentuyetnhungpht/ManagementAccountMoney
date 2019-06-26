using QLSTKDAL;
using QLSTKDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTKBUS
{
    public class SoTietKiemBUS
    {
        private SoTietKiemDAL stkDAL;
        public SoTietKiemBUS()
        {
            this.stkDAL = new SoTietKiemDAL();
        }
        public bool themSoTietKiem(SoTietKiemDTO stkDTO)
        {
            bool re = stkDAL.themSoTietKiem(stkDTO);
            return re;

        }
        public bool dongSoTietKiem(SoTietKiemDTO stkDTO)
        {
            bool re = stkDAL.xoaSoTietKiem(stkDTO);
            return re;
        }
        //public List<SoTietKiemDTO> selectSTK(string masoSTK, string maKH, string maLTK, double minSoDu)
        //{
        //    return stkDAL.selectListSTK(masoSTK, maKH, maLTK, minSoDu);
        //}
        public List<SoTietKiemDTO> selectSTK(string masoSTK, string maKH, string maLTK, double minSoDu, double maxSoDu, DateTime minNgay, DateTime maxNgay)
        {
            return stkDAL.selectListSTK(masoSTK, maKH, maLTK, minSoDu, maxSoDu, minNgay, maxNgay);
        }
        public SoTietKiemDTO getSoTietKiem(string maSTK)
        {
            return stkDAL.getSTK(maSTK);
        }
        public string getNewMaSo()
        {
            return stkDAL.newMaSo();
        }
       
    }
}
