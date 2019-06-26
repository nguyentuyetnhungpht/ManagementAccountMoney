using QLSTKDAL;
using QLSTKDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTKBUS
{
    public class BaoCaoDoanhSoNgayBUS
    {
        private BaoCaoDoanhSoNgayDAL bcDAL;
        public BaoCaoDoanhSoNgayBUS()
        {
            this.bcDAL = new BaoCaoDoanhSoNgayDAL();
        }
        public bool createBaoCao()
        {

            return bcDAL.createBaoCaoNgay();

        }
        public bool updateBaoCao()
        {
            return bcDAL.updateBaoCaoNgay();
        }
        public List<BaoCaoDoanhSoNgayDTO> getListBaoCao(DateTime dt)
        {
            return bcDAL.getListBaoCaoNgay(dt);
        }
    }
}
