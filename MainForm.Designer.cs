
namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.xeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listKhachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hopDongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nganHanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daiHanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listNhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xeToolStripMenuItem,
            this.khachToolStripMenuItem,
            this.hopDongToolStripMenuItem,
            this.nhanVienToolStripMenuItem,
            this.teamToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // xeToolStripMenuItem
            // 
            this.xeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listXeToolStripMenuItem});
            this.xeToolStripMenuItem.Name = "xeToolStripMenuItem";
            this.xeToolStripMenuItem.Size = new System.Drawing.Size(32, 20);
            this.xeToolStripMenuItem.Text = "Xe";
            // 
            // listXeToolStripMenuItem
            // 
            this.listXeToolStripMenuItem.Name = "listXeToolStripMenuItem";
            this.listXeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listXeToolStripMenuItem.Text = "List xe";
            this.listXeToolStripMenuItem.Click += new System.EventHandler(this.listXeToolStripMenuItem_Click);
            // 
            // khachToolStripMenuItem
            // 
            this.khachToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listKhachToolStripMenuItem});
            this.khachToolStripMenuItem.Name = "khachToolStripMenuItem";
            this.khachToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.khachToolStripMenuItem.Text = "Khach";
            // 
            // listKhachToolStripMenuItem
            // 
            this.listKhachToolStripMenuItem.Name = "listKhachToolStripMenuItem";
            this.listKhachToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.listKhachToolStripMenuItem.Text = "List Khach";
            this.listKhachToolStripMenuItem.Click += new System.EventHandler(this.listKhachToolStripMenuItem_Click);
            // 
            // hopDongToolStripMenuItem
            // 
            this.hopDongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nganHanToolStripMenuItem,
            this.daiHanToolStripMenuItem});
            this.hopDongToolStripMenuItem.Name = "hopDongToolStripMenuItem";
            this.hopDongToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.hopDongToolStripMenuItem.Text = "HopDong";
            // 
            // nganHanToolStripMenuItem
            // 
            this.nganHanToolStripMenuItem.Name = "nganHanToolStripMenuItem";
            this.nganHanToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.nganHanToolStripMenuItem.Text = "Ngan Han";
            // 
            // daiHanToolStripMenuItem
            // 
            this.daiHanToolStripMenuItem.Name = "daiHanToolStripMenuItem";
            this.daiHanToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.daiHanToolStripMenuItem.Text = "Dai Han";
            // 
            // nhanVienToolStripMenuItem
            // 
            this.nhanVienToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listNhanVienToolStripMenuItem});
            this.nhanVienToolStripMenuItem.Name = "nhanVienToolStripMenuItem";
            this.nhanVienToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.nhanVienToolStripMenuItem.Text = "NhanVien";
            // 
            // listNhanVienToolStripMenuItem
            // 
            this.listNhanVienToolStripMenuItem.Name = "listNhanVienToolStripMenuItem";
            this.listNhanVienToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.listNhanVienToolStripMenuItem.Text = "List Nhan vien";
            this.listNhanVienToolStripMenuItem.Click += new System.EventHandler(this.listNhanVienToolStripMenuItem_Click);
            // 
            // teamToolStripMenuItem
            // 
            this.teamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listTeamToolStripMenuItem,
            this.addTeamToolStripMenuItem});
            this.teamToolStripMenuItem.Name = "teamToolStripMenuItem";
            this.teamToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.teamToolStripMenuItem.Text = "Team";
            // 
            // listTeamToolStripMenuItem
            // 
            this.listTeamToolStripMenuItem.Name = "listTeamToolStripMenuItem";
            this.listTeamToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listTeamToolStripMenuItem.Text = "List team";
            this.listTeamToolStripMenuItem.Click += new System.EventHandler(this.listTeamToolStripMenuItem_Click);
            // 
            // addTeamToolStripMenuItem
            // 
            this.addTeamToolStripMenuItem.Name = "addTeamToolStripMenuItem";
            this.addTeamToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addTeamToolStripMenuItem.Text = "Add Team";
            this.addTeamToolStripMenuItem.Click += new System.EventHandler(this.addTeamToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hopDongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nganHanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daiHanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listKhachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listNhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTeamToolStripMenuItem;
    }
}