using QLSTKDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTKDAL
{
    public class BaoCaoDoanhSoNgayDAL
    {

        private string connectionString;
        public BaoCaoDoanhSoNgayDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
       
        
    }
}
