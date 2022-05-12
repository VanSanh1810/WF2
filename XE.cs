using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class XE
    {
        HDDH dh = new HDDH();
        HDNH nh = new HDNH();
        DB dB = new DB();
        public DataTable getAllXE()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM XE", dB.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getXE(SqlCommand command)
        {
            command.Connection = dB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public int DHorNH(string MaXe) // 1 la ngan hann -1 la dai han 0 la con trong
        {
            DataTable a = new DataTable(); //HDNH
            DataTable b = new DataTable(); //HDDH
            SqlCommand command1 = new SqlCommand("SELECT * FROM HDNH WHERE MaXe = @MaXe", dB.getConnection);
            command1.Parameters.Add("@MaXe", SqlDbType.VarChar).Value = MaXe;
            SqlCommand command2 = new SqlCommand("SELECT * FROM HDDH WHERE MaXe = @MaXe", dB.getConnection);
            command2.Parameters.Add("@MaXe", SqlDbType.VarChar).Value = MaXe;
            a = nh.getHDNH(command1);
            b = dh.getHDDH(command2);
            if(a.Rows.Count == 0 && b.Rows.Count == 0)
            {
                return 0;
            }
            else
            {
                if(a.Rows.Count > 0)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }

        public bool insertXe(string LoaiXe, string BienSo, string ViTri, MemoryStream HinhAnh, string GhiChu)
        {
            SqlCommand command = new SqlCommand("INSERT INTO XE(MaXe, LoaiXe, BienSo, ViTri, HinhAnh, GhiChu) VALUES (@MaXe, @LoaiXe, @BienSo, @ViTri, @HinhAnh, @GhiChu)", dB.getConnection);
            command.Parameters.Add("@MaXe", SqlDbType.VarChar).Value = (LoaiXe == "XeDap")? "XD": (LoaiXe == "XeMay")? "XM": "XH" + 
                                                                        DateTime.Now.Month.ToString() + 
                                                                        DateTime.Now.Day.ToString() + 
                                                                        DateTime.Now.Hour.ToString() + 
                                                                        DateTime.Now.Minute.ToString() + 
                                                                        DateTime.Now.Second.ToString();
            command.Parameters.Add("@LoaiXe", SqlDbType.VarChar).Value = LoaiXe;
            command.Parameters.Add("@BienSo", SqlDbType.VarChar).Value = BienSo;
            command.Parameters.Add("@ViTri", SqlDbType.VarChar).Value = ViTri;
            command.Parameters.Add("@GhiChu", SqlDbType.VarChar).Value = GhiChu;
            command.Parameters.Add("@HinhAnh", SqlDbType.Image).Value = HinhAnh.ToArray();
            dB.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                dB.openConnection();
                return true;
            }
            else
            {
                dB.openConnection();
                return false;
            }
        }

        public bool delXE(string MaXe)
        {
            SqlCommand command = new SqlCommand("DELETE FROM XE WHERE MaXe = @MaXe", dB.getConnection);
            command.Parameters.Add("@MaXe", SqlDbType.VarChar).Value = MaXe;
            dB.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                dB.openConnection();
                return true;
            }
            else
            {
                dB.openConnection();
                return false;
            }
        }

        public bool UpdateXe(string MaXe, string LoaiXe, string BienSo, string ViTri, MemoryStream HinhAnh, string GhiChu)
        {
            SqlCommand command = new SqlCommand("UPDATE XE SET LoaiXe = @LoaiXe BienSo = @BienSo ViTri = @ViTri HinhAnh = @HinhAnh GhiChu = @GhiChu WHERE MaXe = @MaXe", dB.getConnection);
            command.Parameters.Add("@MaXe", SqlDbType.VarChar).Value = MaXe;
            command.Parameters.Add("@LoaiXe", SqlDbType.VarChar).Value = LoaiXe;
            command.Parameters.Add("@BienSo", SqlDbType.VarChar).Value = BienSo;
            command.Parameters.Add("@ViTri", SqlDbType.VarChar).Value = ViTri;
            command.Parameters.Add("@GhiChu", SqlDbType.VarChar).Value = GhiChu;
            command.Parameters.Add("@HinhAnh", SqlDbType.Image).Value = HinhAnh.ToArray();
            dB.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                dB.openConnection();
                return true;
            }
            else
            {
                dB.openConnection();
                return false;
            }
        }
    }
}
