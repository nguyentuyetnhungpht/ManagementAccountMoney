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
    public class LoaiTietKiemDAL
    {

        private string connectionString;
        public LoaiTietKiemDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public bool themLoaiTietKiem(LoaiTietKiemDTO ltk)
        {

            string query = string.Empty;
            query += "INSERT INTO [tblLoaiTietKiem] ([MaLTK], [TenLTK], [LaiSuat], [KyHan])";
            query += "VALUES (@MaLTK,@TenLTK,@LaiSuat,@KyHan)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaLTK", ltk.StrMaLTK);
                    cmd.Parameters.AddWithValue("@TenLTK", ltk.StrTenLTK);
                    cmd.Parameters.AddWithValue("@LaiSuat", ltk.FLaiSuat);
                    cmd.Parameters.AddWithValue("@KyHan", ltk.IKyHan);
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
        public bool xoaLoaiTietKiem(LoaiTietKiemDTO ltk)
        {
            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM tblLoaiTietKiem WHERE MaLTK = '" + ltk.StrMaLTK + "'", con))
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
    

        public bool suaLoaiTietKiem(LoaiTietKiemDTO ltk)
        {
            string query = string.Empty;
            
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    
                    if (ltk.FLaiSuat != -1)
                    {
                        query += "UPDATE tblLoaiTietKiem SET TenLTK = @TenLTK, LaiSuat = @LaiSuat, KyHan = @KyHan Where MaLTK = @MaLTK";
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@MaLTK", ltk.StrMaLTK);
                        cmd.Parameters.AddWithValue("@TenLTK", ltk.StrTenLTK);
                        cmd.Parameters.AddWithValue("@LaiSuat", ltk.FLaiSuat);
                        cmd.Parameters.AddWithValue("@KyHan", ltk.IKyHan);
                    }
                    else
                    {
                        query += "UPDATE tblLoaiTietKiem SET LaiSuat = @LaiSuat Where MaLTK = @MaLTK";
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@LaiSuat", ltk.FLaiSuat);
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

        public List<LoaiTietKiemDTO> selectListLoaiTietKiem()
        {
            string query = string.Empty;
            query += "SELECT [MaLTK], [TenLTK], [LaiSuat], [KyHan]";
            query += "FROM [tblLoaiTietKiem]";

            List<LoaiTietKiemDTO> lsLoaiTietKiem = new List<LoaiTietKiemDTO>();

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
                                LoaiTietKiemDTO ltk = new LoaiTietKiemDTO();
                                ltk.StrMaLTK = reader["MaLTK"].ToString();
                                ltk.StrTenLTK = reader["TenLTK"].ToString();
                                ltk.FLaiSuat = float.Parse(reader["LaiSuat"].ToString());
                                ltk.IKyHan = int.Parse(reader["KyHan"].ToString());

                                lsLoaiTietKiem.Add(ltk);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        //  return null;
                    }
                }
            }
            return lsLoaiTietKiem;
        }
        public LoaiTietKiemDTO getLoaiTietKiem(string maLTK)
        {
            var table = new DataTable();
            using (var da = new SqlDataAdapter("SELECT [LaiSuat], [KyHan], [TenLTK] FROM [tblLoaiTietKiem] WHERE [MaLTK] = '" + maLTK + "'", connectionString))
            {
                da.Fill(table);
            }
            LoaiTietKiemDTO ltk = new LoaiTietKiemDTO();
            ltk.StrMaLTK = maLTK;
            ltk.StrTenLTK = (table.Rows[0][2]).ToString();
            ltk.FLaiSuat = float.Parse((table.Rows[0][0]).ToString());
            ltk.IKyHan = int.Parse(table.Rows[0][1].ToString());
            return ltk;
        }
        public List<string> getListMaLTK()
        {
            string query = string.Empty;
            query += "SELECT [MaLTK]";
            query += "FROM [tblLoaiTietKiem]";

            List<string> lsLoaiTietKiem = new List<string>();

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
                                lsLoaiTietKiem.Add(reader["MaLTK"].ToString());
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
            return lsLoaiTietKiem;
        }
    }
}
