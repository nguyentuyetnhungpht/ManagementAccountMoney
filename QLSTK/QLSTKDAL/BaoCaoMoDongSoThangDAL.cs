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
            for (int i = 1; i < iSoNgay; i++)
            {
                DateTime dt = new DateTime(iNam, iThang, i);
                bool kq = insert(dt);
                if (kq == false)
                    return false;
            }
            return true;
        }
        public bool insert(DateTime dt)
        {
            string query = string.Empty;
            BaoCaoMoDongSoThangDTO bc = new BaoCaoMoDongSoThangDTO(dt);
            query += "INSERT INTO [tblBaoCaoMoDongSoThang] ([MaBCMDST], [ThangBCMDST], [NamBCMDST], [NgayBCMDST], [SoMo], [SoDong], [ChenhLechSo]) ";
            query += "VALUES (@MaBCMDST, @ThangBCMDST, @NamBCMDST, @NgayBCMDST, @SoMo, @SoDong, @ChenhLechSo)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaBCMDST", bc.StrNgayBCMDST);
                    cmd.Parameters.AddWithValue("@ThangBCMDST", bc.IThangBCMDST);
                    cmd.Parameters.AddWithValue("@NamBCMDST", bc.INamBCDST);
                    cmd.Parameters.AddWithValue("@NgayBCMDST", bc.StrNgayBCMDST);
                    cmd.Parameters.AddWithValue("@SoMo", bc.ISoMo);
                    cmd.Parameters.AddWithValue("@SoDong", bc.ISoDong);
                    cmd.Parameters.AddWithValue("@ChenhLechSo", bc.IChenhLechSo);
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
        public bool upadteBaoCaoMoDongSoThang(int iThang, int iNam)
        {

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
            for (int i = 1; i < iSoNgay; i++)
            {
                DateTime dt = new DateTime(iNam, iThang, i);
                BaoCaoMoDongSoThangDTO bc = new BaoCaoMoDongSoThangDTO(dt);
                string query = string.Empty;
                query = " SELECT COUNT(tblSoTietKiem.MaSoSTK) as SoMo "
                    + " FROM tblSoTietKiem "
                    + " WHERE CONVERT(date, tblSoTietKiem.NgayMoSo) = CONVERT(date, @NgayMoSo) ";

                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@NgayMoSo", dt.ToString());
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
                query = "SELECT COUNT(tblPhieuRutTien.MaSoPRT) as SoDong"
                    + " FROM tblPhieuRutTien "
                    + " WHERE CONVERT(date, tblPhieuRutTien.NgayRut) = CONVERT(date, @NgayRut) ";
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@NgayRut", dt.ToString());
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
                bc.IChenhLechSo = bc.ISoMo - bc.ISoDong;
                query = "UPDATE tblBaoCaoMoDongSoThang "
                   + " SET SoMo = @SoMo, SoDong = @SoDong, ChenhLechSo = @ChenhLechSo "
                   + " WHERE CONVERT(date, tblBaoCaoMoDongSoThang.NgayBCMDST) = CONVERT(date, @NgayBC) ";
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
            return true;
        }

    }


}