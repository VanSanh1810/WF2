
namespace WindowsFormsApp1
{
    partial class AddXe
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bienso_tbx = new System.Windows.Forms.TextBox();
            this.vitri_tbx = new System.Windows.Forms.TextBox();
            this.addpic_btn = new System.Windows.Forms.Button();
            this.ghichu_tbx = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.err_loaixe = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_bienso = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_vitri = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_pic = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.err_loaixe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_bienso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_vitri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "XeDap",
            "XeMay",
            "XeHoi"});
            this.comboBox1.Location = new System.Drawing.Point(174, 93);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(270, 28);
            this.comboBox1.TabIndex = 5;
            // 
            // bienso_tbx
            // 
            this.bienso_tbx.Location = new System.Drawing.Point(174, 161);
            this.bienso_tbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bienso_tbx.Name = "bienso_tbx";
            this.bienso_tbx.Size = new System.Drawing.Size(270, 26);
            this.bienso_tbx.TabIndex = 6;
            // 
            // vitri_tbx
            // 
            this.vitri_tbx.Location = new System.Drawing.Point(174, 224);
            this.vitri_tbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vitri_tbx.Name = "vitri_tbx";
            this.vitri_tbx.Size = new System.Drawing.Size(270, 26);
            this.vitri_tbx.TabIndex = 7;
            // 
            // addpic_btn
            // 
            this.addpic_btn.Location = new System.Drawing.Point(174, 447);
            this.addpic_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addpic_btn.Name = "addpic_btn";
            this.addpic_btn.Size = new System.Drawing.Size(272, 35);
            this.addpic_btn.TabIndex = 9;
            this.addpic_btn.Text = "Add picture";
            this.addpic_btn.UseVisualStyleBackColor = true;
            this.addpic_btn.Click += new System.EventHandler(this.addpic_btn_Click);
            // 
            // ghichu_tbx
            // 
            this.ghichu_tbx.Location = new System.Drawing.Point(174, 516);
            this.ghichu_tbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ghichu_tbx.Multiline = true;
            this.ghichu_tbx.Name = "ghichu_tbx";
            this.ghichu_tbx.Size = new System.Drawing.Size(270, 104);
            this.ghichu_tbx.TabIndex = 10;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(669, 65);
            this.add_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(111, 98);
            this.add_btn.TabIndex = 11;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(669, 173);
            this.edit_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(111, 98);
            this.edit_btn.TabIndex = 12;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(669, 281);
            this.del_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(111, 98);
            this.del_btn.TabIndex = 13;
            this.del_btn.Text = "Delete";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // err_loaixe
            // 
            this.err_loaixe.ContainerControl = this;
            // 
            // err_bienso
            // 
            this.err_bienso.ContainerControl = this;
            // 
            // err_vitri
            // 
            this.err_vitri.ContainerControl = this;
            // 
            // err_pic
            // 
            this.err_pic.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.Location = new System.Drawing.Point(174, 295);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Goldenrod;
            this.label8.Location = new System.Drawing.Point(12, 90);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 31);
            this.label8.TabIndex = 19;
            this.label8.Text = "Loại Xe";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(13, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Biển Số";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(14, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 31);
            this.label4.TabIndex = 21;
            this.label4.Text = "Vị Trí";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(12, 295);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 31);
            this.label3.TabIndex = 22;
            this.label3.Text = "Hình Ảnh";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(12, 513);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 31);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ghi Chú";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(254, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(299, 37);
            this.label7.TabIndex = 26;
            this.label7.Text = "ADD NEW VEHICLE";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(875, 698);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.ghichu_tbx);
            this.Controls.Add(this.addpic_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.vitri_tbx);
            this.Controls.Add(this.bienso_tbx);
            this.Controls.Add(this.comboBox1);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddXe";
            this.Text = "AddXe";
            ((System.ComponentModel.ISupportInitialize)(this.err_loaixe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_bienso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_vitri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox bienso_tbx;
        private System.Windows.Forms.TextBox vitri_tbx;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addpic_btn;
        private System.Windows.Forms.TextBox ghichu_tbx;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.ErrorProvider err_loaixe;
        private System.Windows.Forms.ErrorProvider err_bienso;
        private System.Windows.Forms.ErrorProvider err_vitri;
        private System.Windows.Forms.ErrorProvider err_pic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}