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
    public class PhieuGuiTienDAL
    {
        private string connectionString;
        public PhieuGuiTienDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public bool themPhieuGuiTien(PhieuGuiTienDTO pgt)
        {

            string query = string.Empty;
            query += "INSERT INTO [tblPhieuGuiTien] ([MaSoPGT], [NgayGoi], [SoTienGoiPGT], [MaSoSTK])";
            query += "VALUES (@MaSoPGT,@NgayGoi,@SoTienGoiPGT,@MaSoSTK)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaSoPGT", pgt.StrMaSoPGT);
                    cmd.Parameters.AddWithValue("@NgayGoi", pgt.StrNgayGui);
                    cmd.Parameters.AddWithValue("@SoTienGoiPGT", pgt.DSoTienGui);
                    cmd.Parameters.AddWithValue("@MaSoSTK", pgt.StrMaSTK);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
