using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class HDNH
    {
        DB db = new DB();
        public DataTable getAllHDNH()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM HDNH", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getHDNH(SqlCommand command)
        {
            command.Connection = db.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getIDHDNH(string MaHD)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM HDNH WHERE MaHD = @MaHD", db.getConnection);
            command.Parameters.Add("@MaHD", SqlDbType.VarChar).Value = MaHD;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        public bool insertHDNH(string MaXe, DateTime NgayGui, string GhiChu)
        {
            SqlCommand command = new SqlCommand("INSERT INTO HDNH(MaHD, MaXe, NgayGui, GhiChu) VALUES (@MaHD, @MaXe, @NgayGui, @GhiChu)", db.getConnection);
            command.Parameters.Add("@MaHD", SqlDbType.VarChar).Value = "NH" + DateTime.Now.Month.ToString() +
                                                                            DateTime.Now.Day.ToString() +
                                                                            DateTime.Now.Hour.ToString() +
                                                                            DateTime.Now.Minute.ToString() +
                                                                            DateTime.Now.Second.ToString();
            command.Parameters.Add("@MaXe", SqlDbType.VarChar).Value = MaXe;
            command.Parameters.Add("@NgayGui", SqlDbType.DateTime).Value = NgayGui;
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

        public bool delHDNH(string MaHD)
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

        public bool updateHDNH(string MaHD, string MaXe, DateTime NgayGui, string GhiChu)
        {
            SqlCommand command = new SqlCommand("UPDATE HDNH SET MaHD = @MaHD, MaXe = @MaXe, NgayGui = @NgayGui, GhiChu = @GhiChu WHERE MaHD = @MaHD", db.getConnection);
            command.Parameters.Add("@MaHD", SqlDbType.VarChar).Value = MaHD;
            command.Parameters.Add("@MaXe", SqlDbType.VarChar).Value = MaXe;
            command.Parameters.Add("@NgayGui", SqlDbType.DateTime).Value = NgayGui;
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
