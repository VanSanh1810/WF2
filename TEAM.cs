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
    class TEAM
    {
        DB dB = new DB();
        public DataTable getAllTEAM()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM TEAM", dB.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getTEAM(SqlCommand command)
        {
            command.Connection = dB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool CheckTeamExits(string MaTeam)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM TEAM WHERE MaTeam = @MaTeam", dB.getConnection);
            command.Parameters.Add("@MaTeam", SqlDbType.VarChar).Value = MaTeam;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if(table.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool insertTEAM(string MaTeam, string ChuyenMon, string GhiChu)
        {
            SqlCommand command = new SqlCommand("INSERT INTO TEAM(MaTeam, ChuyenMon, GhiChu) VALUES (@MaTeam, @ChuyenMon, @GhiChu)", dB.getConnection);
            command.Parameters.Add("@MaTeam", SqlDbType.VarChar).Value = MaTeam;
            command.Parameters.Add("@ChuyenMon", SqlDbType.VarChar).Value = ChuyenMon;
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

        public bool delTEAM(string MaTeam)
        {
            SqlCommand command = new SqlCommand("DELETE FROM TEAM WHERE MaTeam = @MaTeam", dB.getConnection);
            command.Parameters.Add("@MaTeam", SqlDbType.VarChar).Value = MaTeam;
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

        public bool UpdateTEAM(string MaTeam, string ChuyenMon, string GhiChu)
        {
            SqlCommand command = new SqlCommand("UPDATE TEAM SET MaTeam = @MaTeam, ChuyenMon = @ChuyenMon, GhiChu = @GhiChu WHERE MaTeam = @MaTeam", dB.getConnection);
            command.Parameters.Add("@MaTeam", SqlDbType.VarChar).Value = MaTeam;
            command.Parameters.Add("@ChuyenMon", SqlDbType.VarChar).Value = ChuyenMon;
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
