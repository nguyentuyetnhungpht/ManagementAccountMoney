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
    public class KhachHangDAL
    {

        private string connectionString;
        public KhachHangDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public bool themKhachHang(KhachHangDTO kh)
        {
            string query = string.Empty;
            query += "INSERT INTO [tblKhachHang] ([MaKH], [HoTenKH], [DiaChi], [CMND])";
            query += "VALUES (@Makh,@Tenkh,@Diachi,@cmnd)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@Makh", kh.StrMaKH);
                    cmd.Parameters.AddWithValue("@Tenkh", kh.StrHoTenKH);
                    cmd.Parameters.AddWithValue("@Diachi", kh.StrDiaChi);
                    cmd.Parameters.AddWithValue("@cmnd", kh.StrCMND);
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
        public bool xoaKhachHang(KhachHangDTO kh)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM tblKhachHang WHERE MaKH = '" + kh.StrMaKH + "'", con))
                    {
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (SystemException ex)
            {
                return false;
            }
            return true;
        }

        public bool suaKhachHang(KhachHangDTO kh)
        {
            string query = string.Empty;
            query += "UPDATE tblKhachHang SET HoTenKH = @HoTenKH, DiaChi = @DiaChi, CMND = @CMND WHERE MaKH = @MaKH";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;

                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@HoTenKH", kh.StrHoTenKH);
                    cmd.Parameters.AddWithValue("@DiaChi", kh.StrDiaChi);
                    cmd.Parameters.AddWithValue("@CMND", kh.StrCMND);
                    cmd.Parameters.AddWithValue("@MaKH", kh.StrMaKH);
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

        public List<KhachHangDTO> selecListKhachHang()
        {
            string query = string.Empty;
            query += "SELECT [MaKH], [HoTenKH], [DiaChi], [CMND]";
            query += "FROM [tblKhachHang]";

            List<KhachHangDTO> lsKhachHang = new List<KhachHangDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                KhachHangDTO kh = new KhachHangDTO();
                                kh.StrMaKH = reader["MaKH"].ToString();
                                kh.StrHoTenKH = reader["HoTenKH"].ToString();
                                kh.StrDiaChi = reader["DiaChi"].ToString();
                                kh.StrCMND = reader["CMND"].ToString();
                                lsKhachHang.Add(kh);
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
            return lsKhachHang;
        }
        public KhachHangDTO getKhachHang(string maKH)
        {
            var table = new DataTable();
            using (var da = new SqlDataAdapter("SELECT [MaKH], [HoTenKH], [DiaChi], [CMND] FROM [tblKhachHang] WHERE [MaKH] = '" + maKH +"'", connectionString))
            {
                da.Fill(table);
            }
            KhachHangDTO kh = new KhachHangDTO();

            kh.StrMaKH = (table.Rows[0][0]).ToString();
            kh.StrHoTenKH =(table.Rows[0][1]).ToString();
            kh.StrDiaChi = (table.Rows[0][2]).ToString();
            kh.StrCMND = (table.Rows[0][3]).ToString();

            return kh;
        }
        public string newMaSo()
        {
            string newMaSo;
            SqlDataAdapter ada = new SqlDataAdapter("SELECT ISNULL(MAX(CAST(MaKH as INT)),0) + 1 FROM [tblKhachHang] ", connectionString);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            newMaSo = dt.Rows[0][0].ToString();
            return newMaSo;
        }
    }
}