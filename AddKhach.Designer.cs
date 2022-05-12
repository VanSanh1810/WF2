
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tenkhach_tbx = new System.Windows.Forms.TextBox();
            this.sdt_tbx = new System.Windows.Forms.TextBox();
            this.ghichu_tbx = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.err_tenkhach = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_sdt = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.makhach_tbx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.err_tenkhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_sdt)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SĐT :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ghi chú :";
            // 
            // tenkhach_tbx
            // 
            this.tenkhach_tbx.Location = new System.Drawing.Point(83, 42);
            this.tenkhach_tbx.Name = "tenkhach_tbx";
            this.tenkhach_tbx.Size = new System.Drawing.Size(137, 20);
            this.tenkhach_tbx.TabIndex = 5;
            this.tenkhach_tbx.Leave += new System.EventHandler(this.tenkhach_tbx_Leave);
            // 
            // sdt_tbx
            // 
            this.sdt_tbx.Location = new System.Drawing.Point(83, 77);
            this.sdt_tbx.Name = "sdt_tbx";
            this.sdt_tbx.Size = new System.Drawing.Size(137, 20);
            this.sdt_tbx.TabIndex = 6;
            this.sdt_tbx.Leave += new System.EventHandler(this.sdt_tbx_Leave);
            // 
            // ghichu_tbx
            // 
            this.ghichu_tbx.Location = new System.Drawing.Point(83, 114);
            this.ghichu_tbx.Multiline = true;
            this.ghichu_tbx.Name = "ghichu_tbx";
            this.ghichu_tbx.Size = new System.Drawing.Size(137, 101);
            this.ghichu_tbx.TabIndex = 7;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(12, 273);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 55);
            this.add_btn.TabIndex = 8;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(93, 273);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 55);
            this.update_btn.TabIndex = 9;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(174, 273);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(75, 55);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã khách :";
            // 
            // makhach_tbx
            // 
            this.makhach_tbx.Enabled = false;
            this.makhach_tbx.Location = new System.Drawing.Point(83, 6);
            this.makhach_tbx.Name = "makhach_tbx";
            this.makhach_tbx.Size = new System.Drawing.Size(137, 20);
            this.makhach_tbx.TabIndex = 12;
            // 
            // AddKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 340);
            this.Controls.Add(this.makhach_tbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.ghichu_tbx);
            this.Controls.Add(this.sdt_tbx);
            this.Controls.Add(this.tenkhach_tbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AddKhach";
            this.Text = "AddKhach";
            ((System.ComponentModel.ISupportInitialize)(this.err_tenkhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_sdt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tenkhach_tbx;
        private System.Windows.Forms.TextBox sdt_tbx;
        private System.Windows.Forms.TextBox ghichu_tbx;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.ErrorProvider err_tenkhach;
        private System.Windows.Forms.ErrorProvider err_sdt;
        private System.Windows.Forms.TextBox makhach_tbx;
        private System.Windows.Forms.Label label1;
    }
}