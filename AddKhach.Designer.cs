
namespace WindowsFormsApp1
{
    partial class AddKhach
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
            this.tenkhach_tbx = new System.Windows.Forms.TextBox();
            this.sdt_tbx = new System.Windows.Forms.TextBox();
            this.ghichu_tbx = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.err_tenkhach = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_sdt = new System.Windows.Forms.ErrorProvider(this.components);
            this.makhach_tbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.err_tenkhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_sdt)).BeginInit();
            this.SuspendLayout();
            // 
            // tenkhach_tbx
            // 
            this.tenkhach_tbx.Location = new System.Drawing.Point(246, 125);
            this.tenkhach_tbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tenkhach_tbx.Name = "tenkhach_tbx";
            this.tenkhach_tbx.Size = new System.Drawing.Size(287, 26);
            this.tenkhach_tbx.TabIndex = 5;
            this.tenkhach_tbx.Leave += new System.EventHandler(this.tenkhach_tbx_Leave);
            // 
            // sdt_tbx
            // 
            this.sdt_tbx.Location = new System.Drawing.Point(246, 178);
            this.sdt_tbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sdt_tbx.Name = "sdt_tbx";
            this.sdt_tbx.Size = new System.Drawing.Size(287, 26);
            this.sdt_tbx.TabIndex = 6;
            this.sdt_tbx.Leave += new System.EventHandler(this.sdt_tbx_Leave);
            // 
            // ghichu_tbx
            // 
            this.ghichu_tbx.Location = new System.Drawing.Point(246, 235);
            this.ghichu_tbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ghichu_tbx.Multiline = true;
            this.ghichu_tbx.Name = "ghichu_tbx";
            this.ghichu_tbx.Size = new System.Drawing.Size(287, 153);
            this.ghichu_tbx.TabIndex = 7;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(18, 420);
            this.add_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(112, 85);
            this.add_btn.TabIndex = 8;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(140, 420);
            this.update_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(112, 85);
            this.update_btn.TabIndex = 9;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(261, 420);
            this.del_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(112, 85);
            this.del_btn.TabIndex = 10;
            this.del_btn.Text = "Delete";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // err_tenkhach
            // 
            this.err_tenkhach.ContainerControl = this;
            // 
            // err_sdt
            // 
            this.err_sdt.ContainerControl = this;
            // 
            // makhach_tbx
            // 
            this.makhach_tbx.Enabled = false;
            this.makhach_tbx.Location = new System.Drawing.Point(246, 69);
            this.makhach_tbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.makhach_tbx.Name = "makhach_tbx";
            this.makhach_tbx.Size = new System.Drawing.Size(287, 26);
            this.makhach_tbx.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Navy;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(32, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mã Khách :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(32, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên Khách :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Navy;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(33, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "SDT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Navy;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(33, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 31);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ghi Chú :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(173, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 43);
            this.label4.TabIndex = 17;
            this.label4.Text = "ADD Guest";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(578, 523);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.makhach_tbx);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.ghichu_tbx);
            this.Controls.Add(this.sdt_tbx);
            this.Controls.Add(this.tenkhach_tbx);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddKhach";
            this.Text = "AddKhach";
            ((System.ComponentModel.ISupportInitialize)(this.err_tenkhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_sdt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tenkhach_tbx;
        private System.Windows.Forms.TextBox sdt_tbx;
        private System.Windows.Forms.TextBox ghichu_tbx;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.ErrorProvider err_tenkhach;
        private System.Windows.Forms.ErrorProvider err_sdt;
        private System.Windows.Forms.TextBox makhach_tbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}