using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class List : Form
    {
        //DB dB = new DB();
        int type;
        /*1 XE
            2 KHACH
            3 HDDH
            4 HDNH
            5 NV
            6 TEAM */
        XE xe = new XE();
        KHACH khach = new KHACH();
        THO tho = new THO();
        TEAM team = new TEAM();
        public List(int a)
        {
            type = a;
            InitializeComponent();
            switch (type)
            {
                case 1:
                    {
                        dataGridView1.DataSource = xe.getAllXE();
                        break;
                    }
                case 2:
                    {
                        dataGridView1.DataSource = khach.getAllKHACK();
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }
                case 5:
                    {
                        dataGridView1.DataSource = tho.getAllTHO();
                        break;
                    }
                case 6:
                    {
                        dataGridView1.DataSource = team.getAllTEAM();
                        break;
                    }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (type)
            {
                case 1:
                    {
                        int state = xe.DHorNH(dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim());
                        switch (state)
                        {
                            case -1: //edit ngan han
                                {
                                    byte[] pic;
                                    pic = (byte[])dataGridView1.CurrentRow.Cells[4].Value;
                                    MemoryStream picture = new MemoryStream(pic);
                                    AddXe a = new AddXe(2, dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim(),
                                                            dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim(),
                                                            dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim(),
                                                            "",
                                                            picture,
                                                            dataGridView1.CurrentRow.Cells[5].Value.ToString().Trim());
                                    break;
                                }
                            case 1: //edit dai han
                                {
                                    byte[] pic;
                                    pic = (byte[])dataGridView1.CurrentRow.Cells[4].Value;
                                    MemoryStream picture = new MemoryStream(pic);
                                    AddXe a = new AddXe(4, dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim(),
                                                            dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim(),
                                                            dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim(),
                                                            dataGridView1.CurrentRow.Cells[3].Value.ToString().Trim(),
                                                            picture,
                                                            dataGridView1.CurrentRow.Cells[5].Value.ToString().Trim());
                                    break;
                                }
                            case 0: //Chua co hop dong
                                {
                                    MemoryStream mst = new MemoryStream();
                                    switch(MessageBox.Show("Khong co hop dong /n Ban co muon tao hop dong moi","Thong bao", MessageBoxButtons.YesNo))
                                    {
                                        case DialogResult.Yes:
                                            switch(MessageBox.Show("(Yes) Dai han \n (No) Ngan han", "Thong bao", MessageBoxButtons.YesNo))
                                            {
                                                case DialogResult.Yes:
                                                    {
                                                        AddXe a = new AddXe(2, "", "", "", "", mst, "");
                                                        a.Show(this);
                                                        break;
                                                    }
                                                case DialogResult.No:
                                                    {
                                                        AddXe a = new AddXe(1, "", "", "", "", mst, "");
                                                        a.Show(this);
                                                        break;
                                                    }
                                            }
                                            break;
                                        case DialogResult.No:
                                            break;
                                        
                                    }
                                    break;
                                }
                        }
                        break;
                    }
                case 2:
                    {
                        dataGridView1.DataSource = khach.getAllKHACK();
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }
                case 5:
                    {
                        AddNhanVien a = new AddNhanVien(2, dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim(),
                                                            dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim(),
                                                            dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim(),
                                                            dataGridView1.CurrentRow.Cells[3].Value.ToString().Trim(),
                                                            (DateTime)dataGridView1.CurrentRow.Cells[4].Value,
                                                            dataGridView1.CurrentRow.Cells[5].Value.ToString().Trim(),
                                                            dataGridView1.CurrentRow.Cells[6].Value.ToString().Trim());
                        a.Show(this);
                        break;
                    }
                case 6:
                    {
                        AddTeam a = new AddTeam(2, dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim(),
                                                    dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim(),
                                                    dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim());
                        a.Show(this);
                        break;
                    }
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            switch (type)
            {
                case 1:
                    {
                        MemoryStream ac = new MemoryStream();
                        AddXe a = new AddXe(1, "", "", "", "", ac, "");
                        a.Show(this);
                        break;
                    }
                case 2:
                    {
                        dataGridView1.DataSource = khach.getAllKHACK();
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }
                case 5:
                    {
                        DateTime b = new DateTime();
                        AddNhanVien a = new AddNhanVien(1,"", "","","", b,"","");
                        a.Show(this);
                        break;
                    }
                case 6:
                    {
                        AddTeam a = new AddTeam(1, "","","");
                        a.Show(this);
                        break;
                    }
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            switch (type)
            {
                case 1:
                    {
                        dataGridView1.DataSource = xe.getAllXE();
                        break;
                    }
                case 2:
                    {
                        dataGridView1.DataSource = khach.getAllKHACK();
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }
                case 5:
                    {
                        dataGridView1.DataSource = tho.getAllTHO();
                        break;
                    }
                case 6:
                    {
                        dataGridView1.DataSource = team.getAllTEAM();
                        break;
                    }
            }
        }
    }
}
