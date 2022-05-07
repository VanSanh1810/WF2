using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class HDDH
    {
        DB db = new DB();
        public DataTable getAllHDDH()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM HDDH", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getHDDH(SqlCommand command)
        {
            command.Connection = db.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getIDHDDH(string MaHD)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM HDDH WHERE MaHD = @MaHD", db.getConnection);
            command.Parameters.Add("@MaHD", SqlDbType.VarChar).Value = MaHD;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        public bool insertHDDH(string MaXe, string MaKhach, DateTime NgayDKHD, DateTime NgayKTHD, string GhiChu)
        {
            SqlCommand command = new SqlCommand("INSERT INTO HDNH(MaHD, MaXe, MaKhach, NgayDKHD, NgayKTHD, GhiChu) VALUES (@MaHD, @MaXe, @MaKhach, @NgayDKHD, @NgayKTHD, @GhiChu)", db.getConnection);
            command.Parameters.Add("@MaHD", SqlDbType.VarChar).Value = "DH" + DateTime.Now.Month.ToString() +
                                                                            DateTime.Now.Day.ToString() +
                                                                            DateTime.Now.Hour.ToString() +
                                                                            DateTime.Now.Minute.ToString() +
                                                                            DateTime.Now.Second.ToString();
            command.Parameters.Add("@MaXe", SqlDbType.VarChar).Value = MaXe;
            command.Parameters.Add("@MaKhach", SqlDbType.VarChar).Value = MaKhach;
            command.Parameters.Add("@NgayDKHD", SqlDbType.DateTime).Value = NgayDKHD;
            command.Parameters.Add("@NgayKTHD", SqlDbType.DateTime).Value = NgayKTHD;
            command.Parameters.Add("@GhiChu", SqlDbType.VarChar).Value = GhiChu;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                db.openConnection();
                return true;
            }
            else
            {
                db.openConnection();
                return false;
            }

        }

        public bool delHDDH(string MaHD)
        {
            SqlCommand command = new SqlCommand("DELETE FROM HDNH WHERE MaHD = @MaHD", db.getConnection);
            command.Parameters.Add("@MaHD", SqlDbType.VarChar).Value = MaHD;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                db.openConnection();
                return true;
            }
            else
            {
                db.openConnection();
                return false;
            }
        }

        public bool updateHDDH(string MaHD, string MaXe, string MaKhach, DateTime NgayDKHD, DateTime NgayKTHD, string GhiChu)
        {
            SqlCommand command = new SqlCommand("UPDATE HDNH SET MaHD = @MaHD, MaXe = @MaXe, MaKhach = @MaKhach, NgayDKHD = @NgayDKHD, NgayKTHD = @NgayKTHD, GhiChu = @GhiChu WHERE MaHD = @MaHD", db.getConnection);
            command.Parameters.Add("@MaHD", SqlDbType.VarChar).Value = MaHD;
            command.Parameters.Add("@MaXe", SqlDbType.VarChar).Value = MaXe;
            command.Parameters.Add("@MaKhach", SqlDbType.VarChar).Value = MaKhach;
            command.Parameters.Add("@NgayDKHD", SqlDbType.DateTime).Value = NgayDKHD;
            command.Parameters.Add("@NgayKTHD", SqlDbType.DateTime).Value = NgayKTHD;
            command.Parameters.Add("@GhiChu", SqlDbType.VarChar).Value = GhiChu;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                db.openConnection();
                return true;
            }
            else
            {
                db.openConnection();
                return false;
            }
        }
    }
}
