
namespace WindowsFormsApp1
{
    partial class AddTeam
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
            this.add_btn = new System.Windows.Forms.Button();
            this.mateam_tbx = new System.Windows.Forms.TextBox();
            this.chuyenmon_tbx = new System.Windows.Forms.TextBox();
            this.ghichu_tbx = new System.Windows.Forms.TextBox();
            this.edit_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.err_mateam = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_chuyenmon = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err_mateam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_chuyenmon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã team :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chuyên môn :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ghi chú :";
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(12, 281);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(85, 54);
            this.add_btn.TabIndex = 3;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // mateam_tbx
            // 
            this.mateam_tbx.Location = new System.Drawing.Point(88, 24);
            this.mateam_tbx.Name = "mateam_tbx";
            this.mateam_tbx.Size = new System.Drawing.Size(140, 20);
            this.mateam_tbx.TabIndex = 4;
            this.mateam_tbx.Leave += new System.EventHandler(this.mateam_tbx_Leave);
            // 
            // chuyenmon_tbx
            // 
            this.chuyenmon_tbx.Location = new System.Drawing.Point(88, 68);
            this.chuyenmon_tbx.Name = "chuyenmon_tbx";
            this.chuyenmon_tbx.Size = new System.Drawing.Size(140, 20);
            this.chuyenmon_tbx.TabIndex = 5;
            this.chuyenmon_tbx.Leave += new System.EventHandler(this.chuyenmon_tbx_Leave);
            // 
            // ghichu_tbx
            // 
            this.ghichu_tbx.Location = new System.Drawing.Point(88, 112);
            this.ghichu_tbx.Multiline = true;
            this.ghichu_tbx.Name = "ghichu_tbx";
            this.ghichu_tbx.Size = new System.Drawing.Size(140, 73);
            this.ghichu_tbx.TabIndex = 6;
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(103, 281);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(85, 54);
            this.edit_btn.TabIndex = 7;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(194, 281);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(85, 54);
            this.del_btn.TabIndex = 8;
            this.del_btn.Text = "Delete";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // err_mateam
            // 
            this.err_mateam.ContainerControl = this;
            // 
            // err_chuyenmon
            // 
            this.err_chuyenmon.ContainerControl = this;
            // 
            // AddTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 347);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.ghichu_tbx);
            this.Controls.Add(this.chuyenmon_tbx);
            this.Controls.Add(this.mateam_tbx);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddTeam";
            this.Text = "AddTeam";
            ((System.ComponentModel.ISupportInitialize)(this.err_mateam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_chuyenmon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox mateam_tbx;
        private System.Windows.Forms.TextBox chuyenmon_tbx;
        private System.Windows.Forms.TextBox ghichu_tbx;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.ErrorProvider err_mateam;
        private System.Windows.Forms.ErrorProvider err_chuyenmon;
    }
}