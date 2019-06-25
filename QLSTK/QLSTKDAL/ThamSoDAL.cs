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
    public class ThamSoDAL
    {
        private string connectionString;
        public ThamSoDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public bool suaThamSo(ThamSoDTO ts)
        {
            string query = string.Empty;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    if (ts.DSoTienGuiToiThieuPGT != 0)
                    {
                        query += "UPDATE tblThamSo SET SoTienGuiToiThieuSTK = @SoTienGuiToiThieuSTK Where MaTS = '1'";
                        cmd.Parameters.AddWithValue("@SoTienGuiToiThieuSTK", ts.DSoTienGuiToiThieuPGT);
                    }
                    else if (ts.DSoTienGuiToiThieuPGT != 0)
                    {
                        query += "UPDATE tblThamSo SET SoTienGuiToiThieuPG = @SoTienGuiToiThieuPG Where MaTS = '1'";
                        cmd.Parameters.AddWithValue("@SoTienGuiToiThieuPG", ts.DSoTienGuiToiThieuSTK);
                    }
                    else
                    {
                        query += "UPDATE tblThamSo SET SoNgayGuiToiTheu = @SoNgayGuiToiTheu Where MaTS = '1'";
                        cmd.Parameters.AddWithValue("@SoNgayGuiToiTheu", ts.ISoNgayGuiToiThieu);
                    }
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
        public DataTable getThamSo()
        {
            
            var table = new DataTable();
            using (var da = new SqlDataAdapter("SELECT * FROM tblThamSo", connectionString))
            {
                da.Fill(table);
            }
            return table;
        }
        public List<ThamSoDTO> selectListThamSo()
        {

            return null;
        }
    }
}
