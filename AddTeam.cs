using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddTeam : Form
    {
        TEAM team = new TEAM();
        public AddTeam(int state, string MaTeam, string ChuyenMon, string GhiChu)
        {
            InitializeComponent();
            switch (state)
            {
                case 1:
                    {
                        edit_btn.Enabled = false;
                        edit_btn.Visible = false;
                        del_btn.Enabled = false;
                        del_btn.Visible = false;
                        break;
                    }
                case 2:
                    {
                        mateam_tbx.Text = MaTeam;
                        chuyenmon_tbx.Text = ChuyenMon;
                        ghichu_tbx.Text = GhiChu;
                        add_btn.Enabled = false;
                        add_btn.Visible = false;
                        mateam_tbx.ReadOnly = true;
                        break;
                    }
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (team.CheckTeamExits(mateam_tbx.Text.Trim()))
            {
                err_mateam.SetError(mateam_tbx, "Exits!");
            }
            else
            {
                err_mateam.Clear();
                team.insertTEAM(mateam_tbx.Text.Trim(), chuyenmon_tbx.Text.Trim(), ghichu_tbx.Text.Trim());
            }
        }

        private void mateam_tbx_Leave(object sender, EventArgs e)
        {
            if(mateam_tbx.Text.Trim() == "")
            {
                err_mateam.SetError(mateam_tbx, "Empty!");
            }
            else
            {
                err_mateam.Clear();
                if (team.CheckTeamExits(mateam_tbx.Text.Trim()))
                {
                    err_mateam.SetError(mateam_tbx, "Exits!");
                }
                else
                {
                    err_mateam.Clear();
                }
            }
        }

        private void chuyenmon_tbx_Leave(object sender, EventArgs e)
        {
            if (chuyenmon_tbx.Text.Trim() == "")
            {
                err_chuyenmon.SetError(chuyenmon_tbx, "Empty!");
            }
            else
            {
                err_chuyenmon.Clear();
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            team.delTEAM(mateam_tbx.Text.Trim());
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (chuyenmon_tbx.Text.Trim() == "")
            {
                err_chuyenmon.SetError(chuyenmon_tbx, "Empty!");
            }
            else
            {
                err_chuyenmon.Clear();
                team.UpdateTEAM(mateam_tbx.Text.Trim(), chuyenmon_tbx.Text.Trim(), ghichu_tbx.Text.Trim());
            }
        }
    }
}
