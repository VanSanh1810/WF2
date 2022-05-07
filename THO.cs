using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class THO
    {
        DB dB = new DB();
        public DataTable getAllTHO()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM THO", dB.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getTHO(SqlCommand command)
        {
            command.Connection = dB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool insertTHO(string TenTho, string SDT, string DiaChi, DateTime NgaySinh, string MaTeam, string GhiChu)
        {
            SqlCommand command = new SqlCommand("INSERT INTO THO(MaTho, TenTho, SDT, DiaChi, NgaySinh, MaTeam, GhiChu) VALUES (@MaTho, @TenTho, @SDT, @DiaChi, @NgaySinh, @MaTeam, @GhiChu)", dB.getConnection);
            command.Parameters.Add("@MaTho", SqlDbType.VarChar).Value = "THO" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            command.Parameters.Add("@TenTho", SqlDbType.VarChar).Value = TenTho;
            command.Parameters.Add("@SDT", SqlDbType.VarChar).Value = SDT;
            command.Parameters.Add("@DiaChi", SqlDbType.VarChar).Value = DiaChi;
            command.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = NgaySinh;
            command.Parameters.Add("@MaTeam", SqlDbType.VarChar).Value = MaTeam;
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

        public bool delTHO(string MaTho)
        {
            SqlCommand command = new SqlCommand("DELETE FROM THO WHERE MaTho = @MaTho", dB.getConnection);
            command.Parameters.Add("@MaTho", SqlDbType.VarChar).Value = MaTho;
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

        public bool UpdateTHO(string MaTho, string TenTho, string SDT, string DiaChi, DateTime NgaySinh, string MaTeam, string GhiChu)
        {
            SqlCommand command = new SqlCommand("UPDATE THO SET TenTho = @TenTho SDT = @SDT DiaChi = @DiaChi NgaySinh = @NgaySinh MaTeam = @MaTeam GhiChu = @GhiChu WHERE MaTho = @MaTho", dB.getConnection);
            command.Parameters.Add("@MaTho", SqlDbType.VarChar).Value = MaTho;
            command.Parameters.Add("@TenTho", SqlDbType.VarChar).Value = TenTho;
            command.Parameters.Add("@SDT", SqlDbType.VarChar).Value = SDT;
            command.Parameters.Add("@DiaChi", SqlDbType.VarChar).Value = DiaChi;
            command.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = NgaySinh;
            command.Parameters.Add("@MaTeam", SqlDbType.VarChar).Value = MaTeam;
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
