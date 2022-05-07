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
    class KHACH
    {
        DB dB = new DB();
        public DataTable getAllKHACK()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM KHACH", dB.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getKHACH(SqlCommand command)
        {
            command.Connection = dB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool insertKhach(string TenKhach, string SDT, string GhiChu)
        {
            SqlCommand command = new SqlCommand("INSERT INTO KHACH(MaKhach, TenKhach, SDT, GhiChu) VALUES (@MaKhach, @TenKhach, @SDT, @GhiChu)", dB.getConnection);
            command.Parameters.Add("@MaKhach", SqlDbType.VarChar).Value = "KH" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            command.Parameters.Add("@TenKhach", SqlDbType.VarChar).Value = TenKhach;
            command.Parameters.Add("@SDT", SqlDbType.VarChar).Value = SDT;
            command.Parameters.Add("@GhiChu", SqlDbType.VarChar).Value = GhiChu;
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

        public bool delKhach(string MaKhach)
        {
            SqlCommand command = new SqlCommand("DELETE FROM XE WHERE MaKhach = @MaKhach", dB.getConnection);
            command.Parameters.Add("@MaKhach", SqlDbType.VarChar).Value = MaKhach;
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

        public bool UpdateKhach(string MaKhach, string TenKhach, string SDT, string GhiChu)
        {
            SqlCommand command = new SqlCommand("UPDATE XE SET TenKhach = @TenKhach SDT = @SDT GhiChu = @GhiChu WHERE MaKhach = @MaKhach", dB.getConnection);
            command.Parameters.Add("@MaKhach", SqlDbType.VarChar).Value = MaKhach;
            command.Parameters.Add("@TenKhach", SqlDbType.VarChar).Value = TenKhach;
            command.Parameters.Add("@SDT", SqlDbType.VarChar).Value = SDT;
            command.Parameters.Add("@GhiChu", SqlDbType.VarChar).Value = GhiChu;
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
