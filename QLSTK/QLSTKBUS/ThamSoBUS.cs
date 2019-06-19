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
    public class ThamSoBUS
    {
        private ThamSoDAL tsDAL;
        public ThamSoBUS()
        {
            this.tsDAL = new ThamSoDAL();
        }

        public bool suaThamSo(ThamSoDTO ts)
        {
            bool re = this.tsDAL.suaThamSo(ts);
            return true;
        }

        public List<ThamSoDTO> selectListTS()
        {
            return null;
        }

        public DataTable getThamSo()
        {
            return tsDAL.getThamSo();
        }

    }
}
