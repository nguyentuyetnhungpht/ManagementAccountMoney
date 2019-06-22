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
        public bool createBaoCaoNgay()
        {
            LoaiTietKiemDAL ltk = new LoaiTietKiemDAL();
            List<string> lsMaLTk = ltk.getListMaLTK();
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
                            cmd.Parameters.AddWithValue("@MaBCDSN", "x");
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
        }
        public bool updateBaoCaoNgay()
        {
            List<BaoCaoDoanhSoNgayDTO> listbc = new List<BaoCaoDoanhSoNgayDTO>();

            LoaiTietKiemDAL ltk = new LoaiTietKiemDAL();
            List<string> lsMaLTk = ltk.getListMaLTK();
            string query = string.Empty;
            query = "SELECT SUM(SoTienGoiPGT) as TongThu, MaLTK "
                + " FROM tblPhieuGuiTien, tblSoTietKiem "
                + " WHERE tblPhieuGuiTien.MaSoSTK = tblSoTietKiem.MaSoSTK "
                + " and CONVERT(date, tblPhieuGuiTien.NgayGoi) = CONVERT(date, @NgayBCDS) "
                + " and tblSoTietKiem.MaLTK = @MaLTK"
                + " GROUP BY MaLTK";
            if (lsMaLTk != null)
            {
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
                if (listbc.Count > 0)
                {
                    //query = "SELECT SUM(SoTienRut) as TongChi, MaLTK "
                    //    + " FROM tblPhieuRutTien, tblSoTietKiem "
                    //    + " WHERE tblPhieuRutTien.MaSoSTK = tblSoTietKiem.MaSoSTK "
                    //    + " and CONVERT(date, tblPhieuGuiTien.NgayRut) = CONVERT(date, @NgayBCDS) "
                    //    + " and tblSoTietKiem.MaLTK = @MaLTK"
                    //    + " GROUP BY MaLTK";
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
            }
            update(listbc);
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
        //private bool insert(BaoCaoDoanhSoNgayDTO bc)
        //{
        //    string query = string.Empty;
        //    query += "INSERT INTO [tblBaoCaoDoanhSoNgay] ([MaBCDSN], [NgayBCDS], [TongThu], [TongChi], [ChenhLechTien], [MaLTK]) ";
        //    query += "VALUES (@MaBCDSN, @NgayBCDS, @TongThu, @TongChi, @ChenhLech, @MaLTK)";
        //    using (SqlConnection con = new SqlConnection(ConnectionString))
        //    {
        //        using (SqlCommand cmd = new SqlCommand())
        //        {
        //            cmd.Connection = con;
        //            cmd.CommandType = System.Data.CommandType.Text;
        //            cmd.CommandText = query;
        //            cmd.Parameters.AddWithValue("@MaBCDSN", "x");
        //            cmd.Parameters.AddWithValue("@NgayBCDS", bc.StrNgayBCDS);
        //            cmd.Parameters.AddWithValue("@TongThu", bc.DTongThu);
        //            cmd.Parameters.AddWithValue("@TongChi", bc.DTongChi);
        //            cmd.Parameters.AddWithValue("@ChenhLech", bc.DChenhLech);
        //            cmd.Parameters.AddWithValue("@MaLTK", bc.StrMaLTK);
        //            try
        //            {
        //                con.Open();
        //                cmd.ExecuteNonQuery();
        //                con.Close();
        //                con.Dispose();
        //            }
        //            catch (Exception ex)
        //            {
        //                con.Close();
        //                return false;
        //            }
        //        }
        //    }
        //    return true;
        //}
    }
}

