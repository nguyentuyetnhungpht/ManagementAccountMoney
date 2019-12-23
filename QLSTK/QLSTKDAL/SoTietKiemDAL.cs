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
            string query = string.Empty;
            query += "UPDATE tblSoTietKiem SET SoTienGoiSTK = @SoTienGoiSTK, NgayChinhSua = @NgayChinhSua Where MaSoSTK = @MaSoSTK ";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;

                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@SoTienGoiSTK", stk.DSoTienGui);
                    cmd.Parameters.AddWithValue("@MaSoSTK", stk.StrMaSoSTK);
                    cmd.Parameters.AddWithValue("@NgayChinhSua", DateTime.Now);
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
            
            var table = new DataTable();
            using (var da = new SqlDataAdapter("SELECT [MaSoSTK], [MaKH], [SoTienGoiSTK], [MaLTK], [NgayMoSo], [TienLai], [SoLanDaoHan], [SoDu], [LaiSuatCamKet], [KyHanCamKet] FROM [tblSoTietKiem] WHERE [MaSoSTK] = '" + masoSTK + "'", connectionString))
            {
                da.Fill(table);
            }
            SoTietKiemDTO stk = new SoTietKiemDTO();
            stk.StrMaSoSTK = (table.Rows[0][0]).ToString();
            stk.StrMaKH = (table.Rows[0][1]).ToString();
            stk.DSoTienGui = double.Parse((table.Rows[0][2]).ToString());
            stk.StrMaLTK = (table.Rows[0][3]).ToString();
            stk.StrNgayMoSo = (table.Rows[0][4]).ToString();
            stk.DTienLai = double.Parse((table.Rows[0][5]).ToString());
            stk.ISoLanDaoHan = int.Parse((table.Rows[0][6]).ToString());
            stk.DSoDu = double.Parse((table.Rows[0][7]).ToString());
            stk.FLaiSuatCamKet = float.Parse((table.Rows[0][8]).ToString());
            stk.IKyHanCamKet = int.Parse((table.Rows[0][9]).ToString());

            //-------------------------------


            stk.DSoDu = tinhSoDu(stk);
            stk.DTienLai = tinhTienLai(stk);
            stk.ISoLanDaoHan = getSoLanDaoHan(stk);
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
        private int getSoLanDaoHan(SoTietKiemDTO stk)
        {
            //TimeSpan x = DateTime.Now - DateTime.Parse(stk.StrNgayChinhSua);
            TimeSpan x = DateTime.Now - DateTime.Parse(stk.StrNgayMoSo);
            return x.Days / 30 / stk.IKyHanCamKet;
        }
        private double tinhTienLai(SoTietKiemDTO stk)
        {
            return stk.FLaiSuatCamKet * stk.IKyHanCamKet * getSoLanDaoHan(stk);
        }
        private double tinhSoDu(SoTietKiemDTO stk)
        {
            return stk.DSoTienGui * (1 + tinhTienLai(stk));
        }
        public List<SoTietKiemDTO> listSTKCuaKhachHang(string strMaKH)
        {
            List<SoTietKiemDTO> lsSTK = new List<SoTietKiemDTO>();
            string query = string.Empty;
            query += "SELECT [MaSoSTK], [MaKH], [SoTienGoiSTK], [MaLTK], [NgayMoSo], [TienLai], [SoLanDaoHan], [SoDu], [LaiSuatCamKet], [KyHanCamKet]";
            query += " FROM [tblSoTietKiem]";
            query += " WHERE MaKH = @MaKH";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maKH", strMaKH);

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
                                lsSTK.Add(stk);
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


            return lsSTK;
        }
    }
}
