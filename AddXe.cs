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
    public partial class AddXe : Form
    {
        XE xe = new XE();
        VITRI vt = new VITRI();
        int state;
        string MaXe;
        public AddXe(int a, string MaXe, string LoaiXe, string BienSo, string ViTri, MemoryStream HinhAnh, string GhiChu)
        {
            this.MaXe = MaXe;
            InitializeComponent();
            state = a;
            switch (a)
            {
                case 1: //Add ngan han
                    {
                        edit_btn.Enabled = false;
                        edit_btn.Visible = false;
                        del_btn.Enabled = false;
                        del_btn.Visible = false;
                        vitri_tbx.Enabled = false;
                        vitri_tbx.Visible = false;
                        break;
                    }
                case 2: //del edit ngan han
                    {
                        add_btn.Enabled = false;
                        add_btn.Visible = false;
                        vitri_tbx.Enabled = false;
                        vitri_tbx.Visible = false;

                        comboBox1.SelectedItem = LoaiXe;
                        bienso_tbx.Text = BienSo;
                        ghichu_tbx.Text = GhiChu;
                        pictureBox1.Image = Image.FromStream(HinhAnh);
                        break;
                    }
                case 3: //add dai han
                    {
                        edit_btn.Enabled = false;
                        edit_btn.Visible = false;
                        del_btn.Enabled = false;
                        del_btn.Visible = false;
                        vitri_tbx.ReadOnly = true;
                        switch (comboBox1.SelectedIndex)
                        {
                            case 0:
                                {
                                    vitri_tbx.Text = vt.getOneViTriEmpty();
                                    break;
                                }
                            case 1:
                                {
                                    vitri_tbx.Text = vt.getOneViTri1Empty();
                                    break;
                                }
                            case 2:
                                {
                                    vitri_tbx.Text = vt.getOneViTri2Empty();
                                    break;
                                }
                        }
                        break;
                    }
                case 4: //del edit dai han
                    {
                        add_btn.Enabled = false;
                        add_btn.Visible = false;

                        comboBox1.SelectedItem = LoaiXe;
                        bienso_tbx.Text = BienSo;
                        vitri_tbx.Text = ViTri;
                        ghichu_tbx.Text = GhiChu;
                        pictureBox1.Image = Image.FromStream(HinhAnh);
                        break;
                    }
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            MemoryStream pic = new MemoryStream();
            pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
            if (xe.insertXe(comboBox1.SelectedItem.ToString(), bienso_tbx.Text, vitri_tbx.Text, pic, ghichu_tbx.Text))
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            MemoryStream pic = new MemoryStream();
            pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
            if (xe.UpdateXe(MaXe,comboBox1.SelectedItem.ToString(), bienso_tbx.Text, vitri_tbx.Text, pic, ghichu_tbx.Text))
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            if (xe.delXE(MaXe))
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }

        private void addpic_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "Select Image (*.jpg,*.png,*.gif)|*.jpg,*.png,*.gif ";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
