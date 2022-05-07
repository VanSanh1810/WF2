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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void listXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List a = new List(1);
            a.Show(this);
        }

        private void listKhachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List a = new List(2);
            a.Show(this);
        }

        private void listNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List a = new List(5);
            a.Show(this);
        }

        private void listTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List a = new List(6);
            a.Show(this);
        }

        private void addTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeam a = new AddTeam(1,"","","");
            a.Show(this);
        }
    }
}
