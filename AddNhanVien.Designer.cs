
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.qLSC_RXDataSet = new WindowsFormsApp1.QLSC_RXDataSet();
            this.tEAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tEAMTableAdapter = new WindowsFormsApp1.QLSC_RXDataSetTableAdapters.TEAMTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.err_tentho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_sdt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_diachi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_mateam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSC_RXDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thợ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên thợ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SĐT :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày sinh :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã team :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ghi chú :";
            // 
            // matho_tbx
            // 
            this.matho_tbx.Location = new System.Drawing.Point(82, 20);
            this.matho_tbx.Name = "matho_tbx";
            this.matho_tbx.ReadOnly = true;
            this.matho_tbx.Size = new System.Drawing.Size(198, 20);
            this.matho_tbx.TabIndex = 7;
            this.matho_tbx.Leave += new System.EventHandler(this.matho_tbx_Leave);
            // 
            // tentho_tbx
            // 
            this.tentho_tbx.Location = new System.Drawing.Point(82, 55);
            this.tentho_tbx.Name = "tentho_tbx";
            this.tentho_tbx.Size = new System.Drawing.Size(198, 20);
            this.tentho_tbx.TabIndex = 8;
            this.tentho_tbx.Leave += new System.EventHandler(this.tentho_tbx_Leave);
            // 
            // sdt_tbx
            // 
            this.sdt_tbx.Location = new System.Drawing.Point(82, 95);
            this.sdt_tbx.Name = "sdt_tbx";
            this.sdt_tbx.Size = new System.Drawing.Size(198, 20);
            this.sdt_tbx.TabIndex = 9;
            this.sdt_tbx.Leave += new System.EventHandler(this.sdt_tbx_Leave);
            // 
            // diachi_tbx
            // 
            this.diachi_tbx.Location = new System.Drawing.Point(82, 140);
            this.diachi_tbx.Name = "diachi_tbx";
            this.diachi_tbx.Size = new System.Drawing.Size(198, 20);
            this.diachi_tbx.TabIndex = 10;
            this.diachi_tbx.Leave += new System.EventHandler(this.diachi_tbx_Leave);
            // 
            // ghichu_tbx
            // 
            this.ghichu_tbx.Location = new System.Drawing.Point(82, 271);
            this.ghichu_tbx.Multiline = true;
            this.ghichu_tbx.Name = "ghichu_tbx";
            this.ghichu_tbx.Size = new System.Drawing.Size(198, 99);
            this.ghichu_tbx.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(82, 181);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // mateam_cbb
            // 
            this.mateam_cbb.DataSource = this.tEAMBindingSource;
            this.mateam_cbb.DisplayMember = "MaTeam";
            this.mateam_cbb.FormattingEnabled = true;
            this.mateam_cbb.Location = new System.Drawing.Point(82, 227);
            this.mateam_cbb.Name = "mateam_cbb";
            this.mateam_cbb.Size = new System.Drawing.Size(198, 21);
            this.mateam_cbb.TabIndex = 14;
            this.mateam_cbb.ValueMember = "MaTeam";
            this.mateam_cbb.Leave += new System.EventHandler(this.mateam_cbb_Leave);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(30, 413);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(96, 63);
            this.add_btn.TabIndex = 15;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(132, 413);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(96, 63);
            this.update_btn.TabIndex = 16;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(234, 413);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(96, 63);
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
            // qLSC_RXDataSet
            // 
            this.qLSC_RXDataSet.DataSetName = "QLSC_RXDataSet";
            this.qLSC_RXDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tEAMBindingSource
            // 
            this.tEAMBindingSource.DataMember = "TEAM";
            this.tEAMBindingSource.DataSource = this.qLSC_RXDataSet;
            // 
            // tEAMTableAdapter
            // 
            this.tEAMTableAdapter.ClearBeforeFill = true;
            // 
            // AddNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 488);
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
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNhanVien";
            this.Text = "AddNhanVien";
            this.Load += new System.EventHandler(this.AddNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err_tentho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_sdt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_diachi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_mateam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSC_RXDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
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
        private QLSC_RXDataSet qLSC_RXDataSet;
        private System.Windows.Forms.BindingSource tEAMBindingSource;
        private QLSC_RXDataSetTableAdapters.TEAMTableAdapter tEAMTableAdapter;
    }
}