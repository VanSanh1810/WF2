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
    public partial class AddNhanVien : Form
    {
        THO tho = new THO();
        TEAM team = new TEAM();
        public AddNhanVien(int state,string MaTho,  string TenTho, string SDT, string DiaChi, DateTime NgaySinh, string MaTeam, string GhiChu )
        {
            InitializeComponent();
            DataTable table = new DataTable();
            table = team.getAllTEAM();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                mateam_cbb.Items.Add(table.Rows[i][0].ToString().Trim());
            }
            switch (state)
            {
                case 1: //add
                    {
                        update_btn.Enabled = false;
                        del_btn.Enabled = false;
                        update_btn.Visible = false;
                        del_btn.Visible = false;
                        break;
                    }
                case 2: //del update
                    {
                        matho_tbx.Text = "NV" + DateTime.Now.Month.ToString()
                                                + DateTime.Now.Day.ToString()
                                                + DateTime.Now.Hour.ToString()
                                                + DateTime.Now.Minute.ToString()
                                                + DateTime.Now.Second.ToString();
                        add_btn.Enabled = false;
                        add_btn.Visible = false;
                        matho_tbx.Text = MaTho;
                        matho_tbx.ReadOnly = true;
                        tentho_tbx.Text = TenTho;
                        sdt_tbx.Text = SDT;
                        diachi_tbx.Text = DiaChi;
                        dateTimePicker1.Value = NgaySinh;
                        mateam_cbb.SelectedItem = MaTeam;
                        break;
                    }
            }
        }

        private void matho_tbx_Leave(object sender, EventArgs e)
        {

        }

        private void tentho_tbx_Leave(object sender, EventArgs e)
        {
            if(matho_tbx.Text.Trim() == "")
            {
                err_tentho.SetError(tentho_tbx, "Empty!");
            }
            else
            {
                err_tentho.Clear();
            }
        }

        private void sdt_tbx_Leave(object sender, EventArgs e)
        {
            if (sdt_tbx.Text.Trim() == "")
            {
                err_sdt.SetError(sdt_tbx, "Empty!");
            }
            else
            {
                err_sdt.Clear();
            }
        }

        private void diachi_tbx_Leave(object sender, EventArgs e)
        {
            if (diachi_tbx.Text.Trim() == "")
            {
                err_diachi.SetError(diachi_tbx, "Empty!");
            }
            else
            {
                err_diachi.Clear();
            }
        }

        private void mateam_cbb_Leave(object sender, EventArgs e)
        {
            if(mateam_cbb.Text.Trim() == "")
            {
                err_mateam.SetError(mateam_cbb, "Please select team !");
            }
            else
            {
                err_mateam.Clear();
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            tho.insertTHO(tentho_tbx.Text, sdt_tbx.Text, diachi_tbx.Text,dateTimePicker1.Value, mateam_cbb.SelectedValue.ToString(), ghichu_tbx.Text);
        }

        private void AddNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSC_RXDataSet.TEAM' table. You can move, or remove it, as needed.
            this.tEAMTableAdapter.Fill(this.qLSC_RXDataSet.TEAM);

        }
    }
}
