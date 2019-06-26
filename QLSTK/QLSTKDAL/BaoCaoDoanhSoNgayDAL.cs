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
    public class BaoCaoDoanhSoNgayDAL
    {

        private string connectionString;
        public BaoCaoDoanhSoNgayDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }

        // Tạo báo cáo ngày đối với mỗi loại tiết kiệm
        public bool createBaoCaoNgay()
        {
            LoaiTietKiemDAL ltk = new LoaiTietKiemDAL();
            List<string> lsMaLTk = ltk.getListMaLTK(); // Lấy toàn bộ các loại tiết kiệm làm khóa chính
            #region insert các loại tiết tiệm trong một ngày báo cáo
            string query = string.Empty;

            query += "INSERT INTO [tblBaoCaoDoanhSoNgay] ([MaBCDSN], [NgayBCDS], [TongThu], [TongChi], [ChenhLechTien], [MaLTK]) ";
            query += "VALUES (@MaBCDSN, @NgayBCDS, 0, 0, 0, @MaLTK)";
            if (lsMaLTk != null)
            {
                foreach (string maltk in lsMaLTk)
                {
                    using (SqlConnection con = new SqlConnection(ConnectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.Connection = con;
                            cmd.CommandType = System.Data.CommandType.Text;
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@NgayBCDS", DateTime.Now.Date.ToString());
                            cmd.Parameters.AddWithValue("@MaBCDSN", newMaSo());
                            cmd.Parameters.AddWithValue("@MaLTK", maltk);
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
                }
            }
            return true;
            #endregion
        }
        public bool updateBaoCaoNgay()
        {
            List<BaoCaoDoanhSoNgayDTO> listbc = new List<BaoCaoDoanhSoNgayDTO>();

            LoaiTietKiemDAL ltk = new LoaiTietKiemDAL();
            List<string> lsMaLTk = ltk.getListMaLTK();
            string query = string.Empty;

            #region Tính tổng thu của mỗi loại tiết kiệm ngày đó rồi cho vào list báo cáo

            #region Câu lệnh  Lấy ra tổng số tiền thu vào của mỗi loại tiết kiệm
            query = "SELECT SUM(SoTienGoiPGT) as TongThu, MaLTK "
                + " FROM tblPhieuGuiTien, tblSoTietKiem "
                + " WHERE tblPhieuGuiTien.MaSoSTK = tblSoTietKiem.MaSoSTK "
                + " and CONVERT(date, tblPhieuGuiTien.NgayGoi) = CONVERT(date, @NgayBCDS) "
                + " and tblSoTietKiem.MaLTK = @MaLTK"
                + " GROUP BY MaLTK";
            #endregion

            #region nếu có loại tiết kiệm lúc đó ta bắt đầu tính doanh thu
            if (lsMaLTk != null)
            {
                // Với mỗi mã tiết kiệm, ta tính Tổng thu tương ứng
                foreach (string maltk in lsMaLTk)
                {

                    BaoCaoDoanhSoNgayDTO bc = new BaoCaoDoanhSoNgayDTO(maltk);
                    using (SqlConnection con = new SqlConnection(ConnectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.Connection = con;
                            cmd.CommandType = System.Data.CommandType.Text;
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@NgayBCDS", DateTime.Now.Date.ToString());
                            cmd.Parameters.AddWithValue("@MaLTK", maltk);
                            try
                            {
                                con.Open();
                                SqlDataReader reader = null;
                                reader = cmd.ExecuteReader();
                                if (reader.HasRows == true)
                                {
                                    while (reader.Read())
                                    {
                                        try
                                        {
                                            bc.DTongThu = double.Parse(reader["TongThu"].ToString());
                                        }
                                        catch
                                        {
                                            bc.DTongThu = 0;
                                        }
                                    }
                                }
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
                    listbc.Add(bc);
                }

                #endregion

                #region Nếu List báo cáo đó có, ta tính tổng chi, và tính luôn chênh lệch = tổng thu - tổng chi
                if (listbc.Count > 0)
                {

                    query = "SELECT SUM(SoTienRut) as TongChi, MaLTK "
                + " FROM tblPhieuRutTien, tblSoTietKiem "
                + " WHERE tblPhieuRutTien.MaSoSTK = tblSoTietKiem.MaSoSTK "
                + " and CONVERT(date, tblPhieuRutTien.NgayRut) = CONVERT(date, @NgayBCDS) "
                + " and tblSoTietKiem.MaLTK = @MaLTK"
                + " GROUP BY MaLTK";

                    foreach (BaoCaoDoanhSoNgayDTO bc in listbc)
                    {
                        using (SqlConnection con = new SqlConnection(ConnectionString))
                        {
                            using (SqlCommand cmd = new SqlCommand())
                            {
                                cmd.Connection = con;
                                cmd.CommandType = System.Data.CommandType.Text;
                                cmd.CommandText = query;
                                cmd.Parameters.AddWithValue("@NgayBCDS", DateTime.Now.Date.ToString());
                                cmd.Parameters.AddWithValue("@MaLTK", bc.StrMaLTK);
                                try
                                {
                                    con.Open();
                                    SqlDataReader reader = null;
                                    reader = cmd.ExecuteReader();
                                    if (reader.HasRows == true)
                                    {
                                        while (reader.Read())
                                        {
                                            try
                                            {
                                                bc.DTongChi = double.Parse(reader["TongChi"].ToString());
                                            }
                                            catch
                                            {
                                                bc.DTongChi = 0;
                                            }
                                        }
                                    }
                                    bc.DChenhLech = bc.DTongThu - bc.DTongChi;
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
                    }

                }
                #endregion
            }
            #endregion

            update(listbc); // update thông tin mới vào báo cáo
            return true;
        }
        private bool update(List<BaoCaoDoanhSoNgayDTO> Listbc)
        {
            if (Listbc != null)
            {
                string query = string.Empty;
                query += "INSERT INTO [tblBaoCaoDoanhSoNgay] ([MaBCDSN], [NgayBCDS], [TongThu], [TongChi], [ChenhLechTien], [MaLTK]) ";
                query += "VALUES (@MaBCDSN, @NgayBCDS, @TongThu, @TongChi, @ChenhLech, @MaLTK)";
                foreach (BaoCaoDoanhSoNgayDTO bc in Listbc)
                {
                    using (SqlConnection con = new SqlConnection(ConnectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.Connection = con;
                            cmd.CommandType = System.Data.CommandType.Text;
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@MaBCDSN", "x");
                            cmd.Parameters.AddWithValue("@NgayBCDS", bc.StrNgayBCDS);
                            cmd.Parameters.AddWithValue("@TongThu", bc.DTongThu);
                            cmd.Parameters.AddWithValue("@TongChi", bc.DTongChi);
                            cmd.Parameters.AddWithValue("@ChenhLech", bc.DChenhLech);
                            cmd.Parameters.AddWithValue("@MaLTK", bc.StrMaLTK);
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
                }

            }
            return true;
        }
        

        public List<BaoCaoDoanhSoNgayDTO> getListBaoCaoNgay(DateTime dt)
        {
            string query = string.Empty;
            query += "SELECT [NgayBCDS], [MaLTK], [TongThu], [TongChi], [ChenhLechTien] ";
            query += "FROM [tblBaoCaoDoanhSoNgay] ";
            query += "WHERE CONVERT(date, NgayBCDS) = CONVERT(date, @NgayBCDS)";

            List<BaoCaoDoanhSoNgayDTO> listBaoCao = new List<BaoCaoDoanhSoNgayDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@NgayBCDS", dt.ToString());

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                BaoCaoDoanhSoNgayDTO bc = new BaoCaoDoanhSoNgayDTO();


                                bc.StrNgayBCDS = reader["NgayBCDS"].ToString();
                                bc.StrMaLTK = reader["MaLTK"].ToString();
                                bc.DTongThu = double.Parse(reader["TongThu"].ToString());
                                bc.DTongChi = double.Parse(reader["TongChi"].ToString());
                                bc.DChenhLech = double.Parse(reader["ChenhLechTien"].ToString());

                                listBaoCao.Add(bc);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                          return null;
                    }
                }
            }
            return listBaoCao;
        } //Lập danh sách báo cáo qua thông tin ngày báo cáo

        private string newMaSo()
        {
            string newMaSo;
            SqlDataAdapter ada = new SqlDataAdapter("SELECT ISNULL(MAX(CAST(MaBCDSN as INT)),0) + 1 FROM [tblBaoCaoDoanhSoNgay] ", connectionString);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            newMaSo = dt.Rows[0][0].ToString();
            return newMaSo;
        }
    }
}
    
