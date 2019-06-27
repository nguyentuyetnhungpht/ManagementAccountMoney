using QLSTKDAL;
using QLSTKDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLSTKBUS
{
    public class LoaiTietKiemBUS
    {
        private LoaiTietKiemDAL ltkDAL;
        public LoaiTietKiemBUS()
        {
            this.ltkDAL = new LoaiTietKiemDAL();
        }

        public List<LoaiTietKiemDTO> selectListLTK()
        {
            return ltkDAL.selectListLoaiTietKiem();
        }
        public LoaiTietKiemDTO getLoaiTietKiem(string maLTK)
        {

            return ltkDAL.getLoaiTietKiem(maLTK);
        }

        public bool them(LoaiTietKiemDTO ltkDTO)
        {
            bool re = ltkDAL.themLoaiTietKiem(ltkDTO);
            return re;
        }
        public bool xoa(LoaiTietKiemDTO ltkDTO)
        {
            bool re = ltkDAL.xoaLoaiTietKiem(ltkDTO);
            return re;
        }
        public bool sua(LoaiTietKiemDTO ltkDTO)
        {
            bool re = ltkDAL.suaLoaiTietKiem(ltkDTO);
            return re;
        }
        public string getNewMaSo()
        {
            return ltkDAL.newMaSo();
        }
    }
}
