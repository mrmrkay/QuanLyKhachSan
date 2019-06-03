namespace QuanLyKhachSan.UserController
{
    partial class ucMenu
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
            this.panelControl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnDichVu = new System.Windows.Forms.Button();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.DCQOSbR;
            this.panelControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelControl.Controls.Add(this.label1);
            this.panelControl.Controls.Add(this.btnTraCuu);
            this.panelControl.Controls.Add(this.btnProfile);
            this.panelControl.Controls.Add(this.btnDichVu);
            this.panelControl.Controls.Add(this.btnDatPhong);
            this.panelControl.Location = new System.Drawing.Point(3, 3);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1244, 644);
            this.panelControl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "QUẢN LÝ KHÁCH SẠN";
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.search;
            this.btnTraCuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTraCuu.Location = new System.Drawing.Point(363, 386);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(137, 182);
            this.btnTraCuu.TabIndex = 1;
            this.btnTraCuu.Text = "TRA CỨU";
            this.btnTraCuu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.profile;
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProfile.Location = new System.Drawing.Point(667, 386);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(137, 182);
            this.btnProfile.TabIndex = 3;
            this.btnProfile.Text = "PROFILE";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnDichVu
            // 
            this.btnDichVu.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.service;
            this.btnDichVu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDichVu.Location = new System.Drawing.Point(667, 162);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(137, 182);
            this.btnDichVu.TabIndex = 1;
            this.btnDichVu.Text = "DỊCH VỤ";
            this.btnDichVu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDichVu.UseVisualStyleBackColor = true;
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.room;
            this.btnDatPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDatPhong.Location = new System.Drawing.Point(363, 162);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(137, 182);
            this.btnDatPhong.TabIndex = 2;
            this.btnDatPhong.Text = "ĐẶT PHÒNG";
            this.btnDatPhong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // ucMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl);
            this.Name = "ucMenu";
            this.Size = new System.Drawing.Size(1250, 650);
            this.Load += new System.EventHandler(this.ucMenu_Load);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Label label1;
    }
}
