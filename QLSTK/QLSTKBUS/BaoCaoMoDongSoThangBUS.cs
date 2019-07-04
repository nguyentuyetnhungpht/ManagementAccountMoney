using QLSTKDAL;
using QLSTKDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTKBUS
{
    public class BaoCaoMoDongSoThangBUS
    {
        private BaoCaoMoDongSoThangDAL bcDAL;
        public BaoCaoMoDongSoThangBUS()
        {
            this.bcDAL = new BaoCaoMoDongSoThangDAL();
        }
       public bool createBaoCaoThang(int Thang, int Nam)
        {
            return bcDAL.createBaoCaoMoDongSoThang(Thang, Nam);
        }
        public bool updateBaoCaoThang(int Thang, int Nam)
        {
            return bcDAL.upadteBaoCaoMoDongSoThang(Thang, Nam);
        }
        public List<BaoCaoMoDongSoThangDTO> getListBaoCaoThang(int iThang, int iNam, string strMaLTK)
        {
            return bcDAL.getBaoCaoThang(iThang, iNam, strMaLTK);
        }
    }
}
