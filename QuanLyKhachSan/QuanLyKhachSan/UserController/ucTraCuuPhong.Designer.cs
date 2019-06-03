namespace QuanLyKhachSan.UserController
{
    partial class ucTraCuuPhong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPhongThue = new System.Windows.Forms.Label();
            this.labelPhongTrong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panelPhong = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPhongThue
            // 
            this.labelPhongThue.AutoSize = true;
            this.labelPhongThue.Location = new System.Drawing.Point(861, 109);
            this.labelPhongThue.Name = "labelPhongThue";
            this.labelPhongThue.Size = new System.Drawing.Size(64, 17);
            this.labelPhongThue.TabIndex = 12;
            this.labelPhongThue.Text = "0 phòng ";
            // 
            // labelPhongTrong
            // 
            this.labelPhongTrong.AutoSize = true;
            this.labelPhongTrong.Location = new System.Drawing.Point(388, 109);
            this.labelPhongTrong.Name = "labelPhongTrong";
            this.labelPhongTrong.Size = new System.Drawing.Size(64, 17);
            this.labelPhongTrong.TabIndex = 11;
            this.labelPhongTrong.Text = "0 phòng ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Số phòng chưa thuê : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(702, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Số phòng đang thuê :  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Thống kê phòng : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 89);
            this.panel1.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(491, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 30);
            this.label6.TabIndex = 7;
            this.label6.Text = "Quản lý phòng";
            // 
            // panelPhong
            // 
            this.panelPhong.Location = new System.Drawing.Point(3, 145);
            this.panelPhong.Name = "panelPhong";
            this.panelPhong.Size = new System.Drawing.Size(1071, 502);
            this.panelPhong.TabIndex = 13;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1129, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(115, 45);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // ucTraCuuPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelPhong);
            this.Controls.Add(this.labelPhongThue);
            this.Controls.Add(this.labelPhongTrong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "ucTraCuuPhong";
            this.Size = new System.Drawing.Size(1250, 650);
            this.Load += new System.EventHandler(this.ucTraCuuPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPhongThue;
        private System.Windows.Forms.Label labelPhongTrong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelPhong;
        private System.Windows.Forms.Button btnThoat;
    }
}
