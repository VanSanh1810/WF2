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
    public partial class AddKhach : Form
    {
        KHACH kh = new KHACH();
        int state;
        string makh;
        public AddKhach(int state, string makh, string tenkh, string sdt, string GhiChu)
        {
            InitializeComponent();
            this.state = state;
            switch (state)
            {
                case 1: //ADD
                    {
                        del_btn.Enabled = false;
                        del_btn.Visible = false;
                        update_btn.Enabled = false;
                        update_btn.Visible = false;
                        break;
                    }
                case 2: //DEL, UPDATE
                    {
                        add_btn.Enabled = false;
                        add_btn.Visible = false;
                        this.makh = makh;
                        makhach_tbx.Text = makh;
                        tenkhach_tbx.Text = tenkh;
                        sdt_tbx.Text = sdt;
                        ghichu_tbx.Text = GhiChu;
                        break;
                    }
            }
        }

        private void tenkhach_tbx_Leave(object sender, EventArgs e)
        {
            if(tenkhach_tbx.Text.Trim() == "")
            {
                err_tenkhach.SetError(tenkhach_tbx, "Empty!");
            }
            else
            {
                err_tenkhach.Clear();
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

        private void add_btn_Click(object sender, EventArgs e)
        {
            if(sdt_tbx.Text.Trim() != "" && tenkhach_tbx.Text.Trim() != "")
            {
                kh.insertKhach(tenkhach_tbx.Text, sdt_tbx.Text, ghichu_tbx.Text);
            }
            else
            {
                MessageBox.Show("Error !");
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (sdt_tbx.Text.Trim() != "" && tenkhach_tbx.Text.Trim() != "")
            {
                kh.UpdateKhach(makhach_tbx.Text ,tenkhach_tbx.Text, sdt_tbx.Text, ghichu_tbx.Text);
            }
            else
            {
                MessageBox.Show("Error !");
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            kh.delKhach(makh);
        }
    }
}
