using QLSTKDTO;
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace QLSTKDAL
{
    public class TaiKhoanDAL
    {
        private string connectionString;

        public TaiKhoanDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public bool Update(string tenTK, string matkhaumoi, ref bool isOK)
        {
            string query = string.Empty;
            query += "UPDATE[tblTaiKhoan] SET";
            query += "[MatKhau] = @matkhaumoi";
            query += "WHERE [TenTaiKhoan] = @tenTK";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@tenTK", tenTK);
                    cmd.Parameters.AddWithValue("@matkhaumoi", matkhaumoi);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                        con.Close();
                        isOK = false;
                        return false;
                    }
                }
            }
            return true; //success
        }


        public bool KiemTra(string tenTK, string matkhau, ref bool isOK, ref int loaiTK) //tham trị isOK,ltk
        {
            string query = string.Empty;

            query += " SELECT [MaLoaiTaiKhoan] ";
            query += " FROM [tblTaiKhoan] ";
            query += " WHERE [TenTaiKhoan] = @tenTK AND [MatKhau] = @matkhau";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@tenTK", tenTK);
                    cmd.Parameters.AddWithValue("@matkhau", matkhau);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                isOK = true;
                                loaiTK = reader.GetOrdinal("MaLoaiTaiKhoan");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }

    }
}
