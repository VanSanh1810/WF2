
namespace WindowsFormsApp1
{
    partial class AddNhanVien
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
            this.matho_tbx = new System.Windows.Forms.TextBox();
            this.tentho_tbx = new System.Windows.Forms.TextBox();
            this.sdt_tbx = new System.Windows.Forms.TextBox();
            this.diachi_tbx = new System.Windows.Forms.TextBox();
            this.ghichu_tbx = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.mateam_cbb = new System.Windows.Forms.ComboBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.err_tentho = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_sdt = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_diachi = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_mateam = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.err_tentho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_sdt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_diachi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_mateam)).BeginInit();
            this.SuspendLayout();
            // 
            // matho_tbx
            // 
            this.matho_tbx.Location = new System.Drawing.Point(175, 69);
            this.matho_tbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.matho_tbx.Name = "matho_tbx";
            this.matho_tbx.ReadOnly = true;
            this.matho_tbx.Size = new System.Drawing.Size(295, 26);
            this.matho_tbx.TabIndex = 7;
            this.matho_tbx.Leave += new System.EventHandler(this.matho_tbx_Leave);
            // 
            // tentho_tbx
            // 
            this.tentho_tbx.Location = new System.Drawing.Point(175, 123);
            this.tentho_tbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tentho_tbx.Name = "tentho_tbx";
            this.tentho_tbx.Size = new System.Drawing.Size(295, 26);
            this.tentho_tbx.TabIndex = 8;
            this.tentho_tbx.Leave += new System.EventHandler(this.tentho_tbx_Leave);
            // 
            // sdt_tbx
            // 
            this.sdt_tbx.Location = new System.Drawing.Point(175, 184);
            this.sdt_tbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sdt_tbx.Name = "sdt_tbx";
            this.sdt_tbx.Size = new System.Drawing.Size(295, 26);
            this.sdt_tbx.TabIndex = 9;
            this.sdt_tbx.Leave += new System.EventHandler(this.sdt_tbx_Leave);
            // 
            // diachi_tbx
            // 
            this.diachi_tbx.Location = new System.Drawing.Point(175, 253);
            this.diachi_tbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.diachi_tbx.Name = "diachi_tbx";
            this.diachi_tbx.Size = new System.Drawing.Size(295, 26);
            this.diachi_tbx.TabIndex = 10;
            this.diachi_tbx.Leave += new System.EventHandler(this.diachi_tbx_Leave);
            // 
            // ghichu_tbx
            // 
            this.ghichu_tbx.Location = new System.Drawing.Point(175, 455);
            this.ghichu_tbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ghichu_tbx.Multiline = true;
            this.ghichu_tbx.Name = "ghichu_tbx";
            this.ghichu_tbx.Size = new System.Drawing.Size(295, 150);
            this.ghichu_tbx.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(175, 316);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(295, 26);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // mateam_cbb
            // 
            this.mateam_cbb.FormattingEnabled = true;
            this.mateam_cbb.Location = new System.Drawing.Point(175, 387);
            this.mateam_cbb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mateam_cbb.Name = "mateam_cbb";
            this.mateam_cbb.Size = new System.Drawing.Size(295, 28);
            this.mateam_cbb.TabIndex = 14;
            this.mateam_cbb.Leave += new System.EventHandler(this.mateam_cbb_Leave);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(45, 635);
            this.add_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(144, 97);
            this.add_btn.TabIndex = 15;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(198, 635);
            this.update_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(144, 97);
            this.update_btn.TabIndex = 16;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(351, 635);
            this.del_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(144, 97);
            this.del_btn.TabIndex = 17;
            this.del_btn.Text = "Delete";
            this.del_btn.UseVisualStyleBackColor = true;
            // 
            // err_tentho
            // 
            this.err_tentho.ContainerControl = this;
            // 
            // err_sdt
            // 
            this.err_sdt.ContainerControl = this;
            // 
            // err_diachi
            // 
            this.err_diachi.ContainerControl = this;
            // 
            // err_mateam
            // 
            this.err_mateam.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Teal;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Goldenrod;
            this.label8.Location = new System.Drawing.Point(18, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 31);
            this.label8.TabIndex = 18;
            this.label8.Text = "Mã Thợ ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(18, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tên Thợ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(18, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 31);
            this.label2.TabIndex = 20;
            this.label2.Text = "SDT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(18, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 31);
            this.label3.TabIndex = 21;
            this.label3.Text = "Địa Chỉ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(18, 311);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 31);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ngày Sinh";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(18, 387);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 31);
            this.label5.TabIndex = 23;
            this.label5.Text = "Đơn Vị";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Teal;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Goldenrod;
            this.label6.Location = new System.Drawing.Point(18, 452);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 31);
            this.label6.TabIndex = 24;
            this.label6.Text = "Ghi Chú";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(171, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(299, 37);
            this.label7.TabIndex = 25;
            this.label7.Text = "ADD NEW STAFF";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(618, 751);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.mateam_cbb);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ghichu_tbx);
            this.Controls.Add(this.diachi_tbx);
            this.Controls.Add(this.sdt_tbx);
            this.Controls.Add(this.tentho_tbx);
            this.Controls.Add(this.matho_tbx);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddNhanVien";
            this.Text = "AddNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.err_tentho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_sdt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_diachi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_mateam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox matho_tbx;
        private System.Windows.Forms.TextBox tentho_tbx;
        private System.Windows.Forms.TextBox sdt_tbx;
        private System.Windows.Forms.TextBox diachi_tbx;
        private System.Windows.Forms.TextBox ghichu_tbx;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox mateam_cbb;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.ErrorProvider err_tentho;
        private System.Windows.Forms.ErrorProvider err_sdt;
        private System.Windows.Forms.ErrorProvider err_diachi;
        private System.Windows.Forms.ErrorProvider err_mateam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}