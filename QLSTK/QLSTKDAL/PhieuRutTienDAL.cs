using QLSTKDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLSTKDAL
{
    public class PhieuRutTienDAL
    {
        private string connectionString;
        public PhieuRutTienDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public bool themPhieuRutTien(PhieuRutTienDTO prt)
        {

            string query = string.Empty;
            query += "INSERT INTO [tblPhieuRutTien] ([MaSoPRT], [NgayRut], [SoTienRut], [MaSoSTK])";
            query += "VALUES (@MaSoPRT,@NgayRut,@SoTienRut,@MaSoSTK)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaSoPRT", prt.StrMaSoPRT);
                    cmd.Parameters.AddWithValue("@NgayRut", prt.StrNgayRut);
                    cmd.Parameters.AddWithValue("@SoTienRut", prt.DSoTienRut);
                    cmd.Parameters.AddWithValue("@MaSoSTK", prt.StrMaSTK);
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
        public string newMaSo()
        {
            string newMaSo;
            SqlDataAdapter ada = new SqlDataAdapter("SELECT ISNULL(MAX(CAST(MaSoPRT as INT)),0) + 1 FROM [tblPhieuRutTien] ", connectionString);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            newMaSo = dt.Rows[0][0].ToString();
            return newMaSo;
        }
    }
}
