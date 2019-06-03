namespace QuanLyKhachSan.Forms
{
    partial class ChiTietPhongForm
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
            this.panelTrangThai = new System.Windows.Forms.Panel();
            this.labelTrangThai = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTienNghi = new System.Windows.Forms.Panel();
            this.listViewTienNghi = new System.Windows.Forms.ListView();
            this.labelPhong = new System.Windows.Forms.Label();
            this.labelTen = new System.Windows.Forms.Label();
            this.labelCMT = new System.Windows.Forms.Label();
            this.labelTuNgay = new System.Windows.Forms.Label();
            this.labelDenNgay = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelTrangThai.SuspendLayout();
            this.panelTienNghi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTrangThai
            // 
            this.panelTrangThai.Controls.Add(this.label8);
            this.panelTrangThai.Controls.Add(this.label7);
            this.panelTrangThai.Controls.Add(this.label6);
            this.panelTrangThai.Controls.Add(this.label5);
            this.panelTrangThai.Controls.Add(this.labelDenNgay);
            this.panelTrangThai.Controls.Add(this.labelTuNgay);
            this.panelTrangThai.Controls.Add(this.labelCMT);
            this.panelTrangThai.Controls.Add(this.labelTen);
            this.panelTrangThai.Location = new System.Drawing.Point(13, 131);
            this.panelTrangThai.Name = "panelTrangThai";
            this.panelTrangThai.Size = new System.Drawing.Size(932, 114);
            this.panelTrangThai.TabIndex = 0;
            // 
            // labelTrangThai
            // 
            this.labelTrangThai.AutoSize = true;
            this.labelTrangThai.Location = new System.Drawing.Point(133, 96);
            this.labelTrangThai.Name = "labelTrangThai";
            this.labelTrangThai.Size = new System.Drawing.Size(73, 17);
            this.labelTrangThai.TabIndex = 1;
            this.labelTrangThai.Text = "Chưa thuê";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Trạng thái : ";
            // 
            // panelTienNghi
            // 
            this.panelTienNghi.Controls.Add(this.listViewTienNghi);
            this.panelTienNghi.Location = new System.Drawing.Point(13, 251);
            this.panelTienNghi.Name = "panelTienNghi";
            this.panelTienNghi.Size = new System.Drawing.Size(932, 262);
            this.panelTienNghi.TabIndex = 1;
            // 
            // listViewTienNghi
            // 
            this.listViewTienNghi.Location = new System.Drawing.Point(62, 21);
            this.listViewTienNghi.Name = "listViewTienNghi";
            this.listViewTienNghi.Size = new System.Drawing.Size(786, 216);
            this.listViewTienNghi.TabIndex = 0;
            this.listViewTienNghi.UseCompatibleStateImageBehavior = false;
            this.listViewTienNghi.View = System.Windows.Forms.View.Details;
            // 
            // labelPhong
            // 
            this.labelPhong.AutoSize = true;
            this.labelPhong.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhong.Location = new System.Drawing.Point(368, 40);
            this.labelPhong.Name = "labelPhong";
            this.labelPhong.Size = new System.Drawing.Size(92, 30);
            this.labelPhong.TabIndex = 2;
            this.labelPhong.Text = "Phòng";
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Location = new System.Drawing.Point(17, 48);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(99, 17);
            this.labelTen.TabIndex = 2;
            this.labelTen.Text = "Nguyễn Văn A";
            // 
            // labelCMT
            // 
            this.labelCMT.AutoSize = true;
            this.labelCMT.Location = new System.Drawing.Point(168, 48);
            this.labelCMT.Name = "labelCMT";
            this.labelCMT.Size = new System.Drawing.Size(56, 17);
            this.labelCMT.TabIndex = 3;
            this.labelCMT.Text = "123456";
            // 
            // labelTuNgay
            // 
            this.labelTuNgay.AutoSize = true;
            this.labelTuNgay.Location = new System.Drawing.Point(328, 48);
            this.labelTuNgay.Name = "labelTuNgay";
            this.labelTuNgay.Size = new System.Drawing.Size(56, 17);
            this.labelTuNgay.TabIndex = 4;
            this.labelTuNgay.Text = "123456";
            this.labelTuNgay.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelDenNgay
            // 
            this.labelDenNgay.AutoSize = true;
            this.labelDenNgay.Location = new System.Drawing.Point(496, 48);
            this.labelDenNgay.Name = "labelDenNgay";
            this.labelDenNgay.Size = new System.Drawing.Size(56, 17);
            this.labelDenNgay.TabIndex = 5;
            this.labelDenNgay.Text = "123456";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tên người thuê";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "CMTND";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Từ ngày";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(496, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Đến ngày";
            // 
            // ChiTietPhongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 543);
            this.Controls.Add(this.labelPhong);
            this.Controls.Add(this.panelTienNghi);
            this.Controls.Add(this.labelTrangThai);
            this.Controls.Add(this.panelTrangThai);
            this.Controls.Add(this.label2);
            this.Name = "ChiTietPhongForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChiTietPhongForm";
            this.Load += new System.EventHandler(this.ChiTietPhongForm_Load);
            this.panelTrangThai.ResumeLayout(false);
            this.panelTrangThai.PerformLayout();
            this.panelTienNghi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTrangThai;
        private System.Windows.Forms.Label labelTrangThai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelTienNghi;
        private System.Windows.Forms.ListView listViewTienNghi;
        private System.Windows.Forms.Label labelPhong;
        private System.Windows.Forms.Label labelDenNgay;
        private System.Windows.Forms.Label labelTuNgay;
        private System.Windows.Forms.Label labelCMT;
        private System.Windows.Forms.Label labelTen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}