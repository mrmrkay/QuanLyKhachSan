namespace QuanLyKhachSan.UserController
{
    partial class ucTraCuu
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
            this.btnPhong = new System.Windows.Forms.Button();
            this.btnDichVu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPhong
            // 
            this.btnPhong.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.room;
            this.btnPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPhong.Location = new System.Drawing.Point(385, 256);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(137, 182);
            this.btnPhong.TabIndex = 0;
            this.btnPhong.Text = "Phòng";
            this.btnPhong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPhong.UseVisualStyleBackColor = true;
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);
            // 
            // btnDichVu
            // 
            this.btnDichVu.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.service;
            this.btnDichVu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDichVu.Location = new System.Drawing.Point(689, 256);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(137, 182);
            this.btnDichVu.TabIndex = 1;
            this.btnDichVu.Text = "Dịch vụ";
            this.btnDichVu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDichVu.UseVisualStyleBackColor = true;
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1131, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(116, 43);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(513, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "TRA CỨU";
            // 
            // ucTraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDichVu);
            this.Controls.Add(this.btnPhong);
            this.Name = "ucTraCuu";
            this.Size = new System.Drawing.Size(1250, 650);
            this.Load += new System.EventHandler(this.ucTraCuu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPhong;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
    }
}
