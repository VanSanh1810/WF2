
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bienso_tbx = new System.Windows.Forms.TextBox();
            this.vitri_tbx = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addpic_btn = new System.Windows.Forms.Button();
            this.ghichu_tbx = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.err_loaixe = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_bienso = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_vitri = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_pic = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_loaixe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_bienso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_vitri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại xe :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ghi chú :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hình ảnh :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vị trí :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Biển số :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "XeDap",
            "XeMay",
            "XeHoi"});
            this.comboBox1.Location = new System.Drawing.Point(75, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // bienso_tbx
            // 
            this.bienso_tbx.Location = new System.Drawing.Point(75, 70);
            this.bienso_tbx.Name = "bienso_tbx";
            this.bienso_tbx.Size = new System.Drawing.Size(181, 20);
            this.bienso_tbx.TabIndex = 6;
            // 
            // vitri_tbx
            // 
            this.vitri_tbx.Location = new System.Drawing.Point(75, 111);
            this.vitri_tbx.Name = "vitri_tbx";
            this.vitri_tbx.Size = new System.Drawing.Size(181, 20);
            this.vitri_tbx.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(75, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 106);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // addpic_btn
            // 
            this.addpic_btn.Location = new System.Drawing.Point(75, 269);
            this.addpic_btn.Name = "addpic_btn";
            this.addpic_btn.Size = new System.Drawing.Size(181, 23);
            this.addpic_btn.TabIndex = 9;
            this.addpic_btn.Text = "Add picture";
            this.addpic_btn.UseVisualStyleBackColor = true;
            this.addpic_btn.Click += new System.EventHandler(this.addpic_btn_Click);
            // 
            // ghichu_tbx
            // 
            this.ghichu_tbx.Location = new System.Drawing.Point(75, 301);
            this.ghichu_tbx.Multiline = true;
            this.ghichu_tbx.Name = "ghichu_tbx";
            this.ghichu_tbx.Size = new System.Drawing.Size(181, 69);
            this.ghichu_tbx.TabIndex = 10;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(52, 378);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(74, 64);
            this.add_btn.TabIndex = 11;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(132, 378);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(74, 64);
            this.edit_btn.TabIndex = 12;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(212, 378);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(74, 64);
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
            // AddXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 454);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.ghichu_tbx);
            this.Controls.Add(this.addpic_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.vitri_tbx);
            this.Controls.Add(this.bienso_tbx);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddXe";
            this.Text = "AddXe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_loaixe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_bienso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_vitri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
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
    }
}