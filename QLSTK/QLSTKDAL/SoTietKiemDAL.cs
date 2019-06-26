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
    public class SoTietKiemDAL
    {
        private string connectionString;
        public SoTietKiemDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public bool themSoTietKiem(SoTietKiemDTO stk)
        {

            // câu lệnh insert sổ vào bảng
            string query = string.Empty;
            query += "INSERT INTO [tblSoTietKiem] ([MaSoSTK], [MaKH], [SoTienGoiSTK], [MaLTK], [NgayMoSo], [TienLai], [SoLanDaoHan], [SoDu], [LaiSuatCamKet], [KyHanCamKet]) ";
            query += "VALUES (@MaSoSTK, @MaKH, @SoTienGoiSTK, @MaLTK, @NgayMoSo, @TienLai, @SoLanDaoHan, @SoDu, @LaiSuatCamKet, @KyHanCamKet)";
            //----------------------------

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    //---------------------

                    //Tham số từ sổ tiết kiệm
                    cmd.Parameters.AddWithValue("@MaSoSTK", stk.StrMaSoSTK);
                    cmd.Parameters.AddWithValue("@MaKH", stk.StrMaKH);
                    cmd.Parameters.AddWithValue("@SoTienGoiSTK", stk.DSoTienGui);
                    cmd.Parameters.AddWithValue("@MaLTK", stk.StrMaLTK);
                    cmd.Parameters.AddWithValue("@NgayMoSo", stk.StrNgayMoSo);
                    cmd.Parameters.AddWithValue("@TienLai", stk.DTienLai);
                    cmd.Parameters.AddWithValue("@SoLanDaoHan", stk.ISoLanDaoHan);
                    cmd.Parameters.AddWithValue("@SoDu", stk.DSoDu);
                    cmd.Parameters.AddWithValue("@LaiSuatCamKet", stk.FLaiSuatCamKet);
                    cmd.Parameters.AddWithValue("@KyHanCamKet", stk.IKyHanCamKet);
                    //---------------------------

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
        public bool xoaSoTietKiem(SoTietKiemDTO stk)
        {
            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM tblSoTietKiem WHERE MaSoSTK = '" + stk.StrMaSoSTK + "'", con))
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

        public bool suaSoTietKiem(SoTietKiemDTO stk)
        {

            return true;
        }

        public List<SoTietKiemDTO> selectListSTK(string masoSTK, string maKH, string maLTK, double minSoDu, double maxSoDu, DateTime minNgay, DateTime maxNgay)
        {
            string query = string.Empty;
            query += "SELECT [MaSoSTK], [MaKH], [SoTienGoiSTK], [MaLTK], [NgayMoSo], [TienLai], [SoLanDaoHan], [SoDu], [LaiSuatCamKet], [KyHanCamKet]";
            query += " FROM [tblSoTietKiem]";
            query += " WHERE ([MaSoSTK] LIKE CONCAT('%',@masoSTK,'%'))";
            query += " AND ([MaKH] LIKE CONCAT('%',@maKH,'%'))";
            query += " AND ([MaLTK] LIKE CONCAT('%',@maLTK,'%'))";
            query += " AND ([SoDu] >= " + minSoDu.ToString() + ")";
            if(maxSoDu > 0)
            {
                query += " AND ([SoDu] <= " + maxSoDu.ToString() + ")";
            }
            query += " AND ([NgayMoSo] >= '" + minNgay.ToString() + "')";
            query += " AND ([NgayMoSo] <= '" + maxNgay.ToString() + "')";

            List<SoTietKiemDTO> listSTK = new List<SoTietKiemDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@masoSTK", masoSTK);
                    cmd.Parameters.AddWithValue("@maKH", maKH);
                    cmd.Parameters.AddWithValue("@maLTK", maLTK);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();

                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                SoTietKiemDTO stk = new SoTietKiemDTO();

                                stk.StrMaSoSTK = reader["MaSoSTK"].ToString();
                                stk.StrMaKH = reader["MaKH"].ToString();
                                stk.DSoTienGui = double.Parse(reader["SoTienGoiSTK"].ToString());
                                stk.StrMaLTK = reader["MaLTK"].ToString();
                                stk.StrNgayMoSo = reader["NgayMoSo"].ToString();
                                stk.DTienLai = double.Parse(reader["TienLai"].ToString());
                                stk.ISoLanDaoHan = int.Parse(reader["SoLanDaoHan"].ToString());
                                stk.DSoDu = double.Parse(reader["SoDu"].ToString());
                                stk.FLaiSuatCamKet = float.Parse(reader["LaiSuatCamKet"].ToString());
                                stk.IKyHanCamKet = int.Parse(reader["KyHanCamKet"].ToString());

                                listSTK.Add(stk);
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
            return listSTK;
        }
        public SoTietKiemDTO getSTK(string masoSTK)
        {
            string query = string.Empty;
            query += "SELECT [MaSoSTK], [MaKH], [SoTienGoiSTK], [MaLTK], [NgayMoSo], [TienLai], [SoLanDaoHan], [SoDu], [LaiSuatCamKet], [KyHanCamKet]";
            query += " FROM [tblSoTietKiem]";
            query += " WHERE ([MaSoSTK] = @masoSTK";
            SoTietKiemDTO stk = new SoTietKiemDTO();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@masoSTK", masoSTK);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();

                        if (reader.HasRows == true)
                        {
                            stk.StrMaSoSTK = reader["MaSoSTK"].ToString();
                            stk.StrMaKH = reader["MaKH"].ToString();
                            stk.DSoTienGui = double.Parse(reader["SoTienGoiSTK"].ToString());
                            stk.StrMaLTK = reader["MaLTK"].ToString();
                            stk.StrNgayMoSo = reader["NgayMoSo"].ToString();
                            stk.DTienLai = double.Parse(reader["TienLai"].ToString());
                            stk.ISoLanDaoHan = int.Parse(reader["SoLanDaoHan"].ToString());
                            stk.DSoDu = double.Parse(reader["SoDu"].ToString());
                            stk.FLaiSuatCamKet = float.Parse(reader["LaiSuatCamKet"].ToString());
                            stk.IKyHanCamKet = int.Parse(reader["KyHanCamKet"].ToString());
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
            return stk;
        }
        public string newMaSo()
        {
            string newMaSo;
            SqlDataAdapter ada = new SqlDataAdapter("SELECT ISNULL(MAX(CAST(MaSoSTK as INT)),0) + 1 FROM [tblSoTietKiem] ", connectionString);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            newMaSo = dt.Rows[0][0].ToString();
            return newMaSo;
        }
    }
}