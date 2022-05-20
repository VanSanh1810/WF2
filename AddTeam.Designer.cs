
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
            this.add_btn = new System.Windows.Forms.Button();
            this.mateam_tbx = new System.Windows.Forms.TextBox();
            this.chuyenmon_tbx = new System.Windows.Forms.TextBox();
            this.ghichu_tbx = new System.Windows.Forms.TextBox();
            this.edit_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.err_mateam = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_chuyenmon = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.err_mateam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_chuyenmon)).BeginInit();
            this.SuspendLayout();
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(18, 383);
            this.add_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(128, 83);
            this.add_btn.TabIndex = 3;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // mateam_tbx
            // 
            this.mateam_tbx.Location = new System.Drawing.Point(154, 115);
            this.mateam_tbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mateam_tbx.Name = "mateam_tbx";
            this.mateam_tbx.Size = new System.Drawing.Size(208, 26);
            this.mateam_tbx.TabIndex = 4;
            this.mateam_tbx.Leave += new System.EventHandler(this.mateam_tbx_Leave);
            // 
            // chuyenmon_tbx
            // 
            this.chuyenmon_tbx.Location = new System.Drawing.Point(154, 183);
            this.chuyenmon_tbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chuyenmon_tbx.Name = "chuyenmon_tbx";
            this.chuyenmon_tbx.Size = new System.Drawing.Size(208, 26);
            this.chuyenmon_tbx.TabIndex = 5;
            this.chuyenmon_tbx.Leave += new System.EventHandler(this.chuyenmon_tbx_Leave);
            // 
            // ghichu_tbx
            // 
            this.ghichu_tbx.Location = new System.Drawing.Point(154, 250);
            this.ghichu_tbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ghichu_tbx.Multiline = true;
            this.ghichu_tbx.Name = "ghichu_tbx";
            this.ghichu_tbx.Size = new System.Drawing.Size(208, 110);
            this.ghichu_tbx.TabIndex = 6;
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(154, 383);
            this.edit_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(128, 83);
            this.edit_btn.TabIndex = 7;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(291, 383);
            this.del_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(128, 83);
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
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(8, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã Team";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(8, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "Chuyên Môn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(8, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 31);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ghi Chú";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(107, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 43);
            this.label4.TabIndex = 20;
            this.label4.Text = "ADD Team";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(533, 499);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.ghichu_tbx);
            this.Controls.Add(this.chuyenmon_tbx);
            this.Controls.Add(this.mateam_tbx);
            this.Controls.Add(this.add_btn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddTeam";
            this.Text = "AddTeam";
            ((System.ComponentModel.ISupportInitialize)(this.err_mateam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_chuyenmon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox mateam_tbx;
        private System.Windows.Forms.TextBox chuyenmon_tbx;
        private System.Windows.Forms.TextBox ghichu_tbx;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.ErrorProvider err_mateam;
        private System.Windows.Forms.ErrorProvider err_chuyenmon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}