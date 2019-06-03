namespace QuanLyKhachSan.UserController
{
    partial class ucTraCuuDichVu
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
            this.label8 = new System.Windows.Forms.Label();
            this.lsvDichVu = new System.Windows.Forms.ListView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(424, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(321, 30);
            this.label8.TabIndex = 48;
            this.label8.Text = "Danh sách dịch vụ đã đặt";
            // 
            // lsvDichVu
            // 
            this.lsvDichVu.Location = new System.Drawing.Point(52, 105);
            this.lsvDichVu.Name = "lsvDichVu";
            this.lsvDichVu.Size = new System.Drawing.Size(656, 491);
            this.lsvDichVu.TabIndex = 49;
            this.lsvDichVu.UseCompatibleStateImageBehavior = false;
            this.lsvDichVu.View = System.Windows.Forms.View.Details;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1131, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(116, 43);
            this.btnThoat.TabIndex = 50;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(840, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 43);
            this.button1.TabIndex = 51;
            this.button1.Text = "Hôm nay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(840, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 43);
            this.button2.TabIndex = 52;
            this.button2.Text = "Ngày mai";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(840, 384);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 43);
            this.button3.TabIndex = 53;
            this.button3.Text = "Tất cả";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ucTraCuuDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lsvDichVu);
            this.Controls.Add(this.label8);
            this.Name = "ucTraCuuDichVu";
            this.Size = new System.Drawing.Size(1250, 650);
            this.Load += new System.EventHandler(this.ucTraCuuDichVu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView lsvDichVu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
