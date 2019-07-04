﻿using QLSTKDTO;
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

    public class BaoCaoMoDongSoThangDAL
    {
        private string connectionString;
        public BaoCaoMoDongSoThangDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public bool createBaoCaoMoDongSoThang(int iThang, int iNam)
        {
            if (isCoSan())
                return false;
            # region Tính số ngày của tháng đó
            int iSoNgay = 0;
            if (iThang > 0 && iThang < 13 && iNam > 1990)
            {

                if (iThang == 1 || iThang == 3 || iThang == 5 || iThang == 7 || iThang == 8 || iThang == 10 || iThang == 12)
                    iSoNgay = 31;
                else if (iThang == 4 || iThang == 6 || iThang == 9 || iThang == 11)
                    iSoNgay = 30;
                else if ((iNam % 4 == 0) && !(iNam % 100 == 0))
                    iSoNgay = 29;
                else
                    iSoNgay = 28;
            }
            #endregion

            #region Thêm mỗi ngày trong tháng vào báo cáo
            for (int i = 1; i < iSoNgay; i++)
            {
                DateTime dt = new DateTime(iNam, iThang, i);
                bool kq = insert(dt);// insert ngày đó vào 
                if (kq == false)
                    return false;
            }
            #endregion

            return true;
        }

        public bool insert(DateTime dt)
        {
            string query = string.Empty;
            BaoCaoMoDongSoThangDTO bc = new BaoCaoMoDongSoThangDTO(dt);
            LoaiTietKiemDAL ltk = new LoaiTietKiemDAL();
            List<string> lsMaLTk = ltk.getListMaLTK();
            query += "INSERT INTO [tblBaoCaoMoDongSoThang] ([MaBCMDST], [ThangBCMDST], [NamBCMDST], [NgayBCMDST], [SoMo], [SoDong], [ChenhLechSo], [MaLTK]) ";
            query += "VALUES (@MaBCMDST, @ThangBCMDST, @NamBCMDST, @NgayBCMDST, @SoMo, @SoDong, @ChenhLechSo, @MaLTK)";

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
                            cmd.Parameters.AddWithValue("@MaBCMDST", newMaSo());
                            cmd.Parameters.AddWithValue("@ThangBCMDST", bc.IThangBCMDST);
                            cmd.Parameters.AddWithValue("@NamBCMDST", bc.INamBCMDST);
                            cmd.Parameters.AddWithValue("@NgayBCMDST", bc.StrNgayBCMDST);
                            cmd.Parameters.AddWithValue("@SoMo", bc.ISoMo);
                            cmd.Parameters.AddWithValue("@SoDong", bc.ISoDong);
                            cmd.Parameters.AddWithValue("@ChenhLechSo", bc.IChenhLechSo);
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
        // hàm insert một ngày vào báo cáo
        public bool upadteBaoCaoMoDongSoThang(int iThang, int iNam)
        {
            # region Tính số ngày của tháng đó
            int iSoNgay = 0;
            if (iThang > 0 && iThang < 13 && iNam > 1990)
            {

                if (iThang == 1 || iThang == 3 || iThang == 5 || iThang == 7 || iThang == 8 || iThang == 10 || iThang == 12)
                    iSoNgay = 31;
                else if (iThang == 4 || iThang == 6 || iThang == 9 || iThang == 11)
                    iSoNgay = 30;
                else if ((iNam % 4 == 0) && !(iNam % 100 == 0))
                    iSoNgay = 29;
                else
                    iSoNgay = 28;
            }
            #endregion
            LoaiTietKiemDAL ltk = new LoaiTietKiemDAL();
            List<string> lsMaLTk = ltk.getListMaLTK();


            #region Tính số sổ mở, sổ đóng và chênh lệch của mỗi ngày
            if (lsMaLTk != null)
            {
                foreach (string maltk in lsMaLTk)
                {
                    for (int i = 1; i <= iSoNgay; i++)
                    {
                        DateTime dt = new DateTime(iNam, iThang, i);
                        BaoCaoMoDongSoThangDTO bc = new BaoCaoMoDongSoThangDTO(dt);
                        string query = string.Empty;


                        #region Tính số sổ mở
                        query = " SELECT COUNT(tblSoTietKiem.MaSoSTK) as SoMo "
                            + " FROM tblSoTietKiem "
                            + " WHERE CONVERT(date, tblSoTietKiem.NgayMoSo) = CONVERT(date, @NgayMoSo) "
                            + " AND MaLTK = @MaLTK";


                        using (SqlConnection con = new SqlConnection(ConnectionString))
                        {
                            using (SqlCommand cmd = new SqlCommand())
                            {
                                cmd.Connection = con;
                                cmd.CommandType = System.Data.CommandType.Text;
                                cmd.CommandText = query;
                                cmd.Parameters.AddWithValue("@NgayMoSo", dt.ToString());
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
                                                bc.ISoMo = int.Parse(reader["SoMo"].ToString());
                                            }
                                            catch
                                            {
                                                bc.ISoMo = 0;
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
                        #endregion

                        #region Tính số sổ đóng
                        query = "SELECT COUNT(tblPhieuRutTien.MaSoPRT) as SoDong"
                            + " FROM tblPhieuRutTien, tblSoTietKiem "
                            + " WHERE CONVERT(date, tblPhieuRutTien.NgayRut) = CONVERT(date, @NgayRut) "
                            + " AND tblPhieuRutTien.MaSoSTK = tblSoTietKiem.MaSoSTK "
                            + " AND tblSoTietKiem.SoTienGoiSTK = 0"
                            + " AND tblSoTietKiem.MaLTK = @MaLTK";

                        using (SqlConnection con = new SqlConnection(ConnectionString))
                        {
                            using (SqlCommand cmd = new SqlCommand())
                            {
                                cmd.Connection = con;
                                cmd.CommandType = System.Data.CommandType.Text;
                                cmd.CommandText = query;
                                cmd.Parameters.AddWithValue("@NgayRut", dt.ToString());
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
                                                bc.ISoDong = int.Parse(reader["SoDong"].ToString());
                                            }
                                            catch
                                            {
                                                bc.ISoDong = 0;
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
                        #endregion

                        #region Tính số sổ chênh lệch

                        bc.IChenhLechSo = bc.ISoMo - bc.ISoDong;

                        #endregion

                        #region Cập nhật thông tin sổ vào database
                        query = "UPDATE tblBaoCaoMoDongSoThang "
                           + " SET SoMo = @SoMo, SoDong = @SoDong, ChenhLechSo = @ChenhLechSo "
                           + " WHERE CONVERT(date, tblBaoCaoMoDongSoThang.NgayBCMDST) = CONVERT(date, @NgayBC) "
                           + " AND MaLTK = @MaLTK";
                        using (SqlConnection con = new SqlConnection(ConnectionString))
                        {
                            using (SqlCommand cmd = new SqlCommand())
                            {
                                cmd.Connection = con;
                                cmd.CommandType = System.Data.CommandType.Text;
                                cmd.CommandText = query;
                                cmd.Parameters.AddWithValue("@SoMo", bc.ISoMo);
                                cmd.Parameters.AddWithValue("@SoDong", bc.ISoDong);
                                cmd.Parameters.AddWithValue("@ChenhLechSo", bc.IChenhLechSo);
                                cmd.Parameters.AddWithValue("@NgayBC", dt.ToString());
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
                        #endregion
                    }
                }
            }
            #endregion
            return true;
        }//hàm cập nhật báo cáo tháng
        public List<BaoCaoMoDongSoThangDTO> getBaoCaoThang(int iThang, int iNam, string strMaLTK)
        {
            string query = string.Empty;
            query += "SELECT [NgayBCMDST], [SoMo], [SoDong], [ChenhLechSo] ";
            query += "FROM [tblBaoCaoMoDongSoThang] ";
            query += "WHERE ThangBCMDST = @Thang AND NamBCMDST = @Nam AND MaLTk = @MaLTK";

            List<BaoCaoMoDongSoThangDTO> listBaoCao = new List<BaoCaoMoDongSoThangDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@Thang", iThang);
                    cmd.Parameters.AddWithValue("@Nam", iNam);
                    cmd.Parameters.AddWithValue("@MaLTK", strMaLTK);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                BaoCaoMoDongSoThangDTO bc = new BaoCaoMoDongSoThangDTO();
                                bc.StrNgayBCMDST = reader["NgayBCMDST"].ToString();
                                bc.ISoMo = int.Parse(reader["SoMo"].ToString());
                                bc.ISoDong = int.Parse(reader["SoDong"].ToString());
                                bc.IChenhLechSo = int.Parse(reader["ChenhLechSo"].ToString());

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
        }//Lập báo cáo tháng qua thông tin tháng và năm
        private string newMaSo()
        {
            string newMaSo;
            SqlDataAdapter ada = new SqlDataAdapter("SELECT ISNULL(MAX(CAST(MaBCMDST as INT)),0) + 1 FROM [tblBaoCaoMoDongSoThang] ", connectionString);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            newMaSo = dt.Rows[0][0].ToString();
            return newMaSo;
        }
        private bool isCoSan()
        {
            string query = string.Empty;
            query += "SELECT COUNT(*) as Tong ";
            query += "FROM [tblBaoCaoMoDongSoThang] ";
            query += "WHERE CONVERT(date, NgayBCMDST) = CONVERT(date, @NgayBCDS)";
            int count = 0;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@NgayBCDS", DateTime.Now);

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
                                count = int.Parse(reader["Tong"].ToString());
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
            if (count > 0)
                return true;
            return false;
        }
    }
    

}