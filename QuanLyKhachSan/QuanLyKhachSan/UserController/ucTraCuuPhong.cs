using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.Repositary;
using QuanLyKhachSan.Objects;
using QuanLyKhachSan.Forms;

namespace QuanLyKhachSan.UserController
{
    public partial class ucTraCuuPhong : UserControl
    {
        TBPhong tbPhong = new TBPhong();
        ucMenu menu;
        ucTraCuu menuTraCuu;

        public ucTraCuuPhong(Control menu, Control menuTraCuu)
        {
            this.menu = menu as ucMenu;
            this.menuTraCuu = menuTraCuu as ucTraCuu;
            InitializeComponent();
        }

        private void ucTraCuuPhong_Load(object sender, EventArgs e)
        {
            int soPhongTrong = 0;
            int soPhongThue = 0;
            List<Phong> lstPhong = tbPhong.LoadPhong();
            int i = 0, j = 0;
            foreach (Phong phong in lstPhong)
            {
                if (phong.TrangThai == 0) soPhongTrong++;
                else soPhongThue++;
                Button btn = new Button();
                btn.Text = phong.MaPhong.ToString();
                btn.Name = "btn" + phong.MaPhong.ToString();
                btn.Width = 100;
                btn.Height = 50;
                if (i < 5)
                {
                    btn.Location = new Point(50 + 150 * i, 50 + 100 * j);
                    i++;
                }
                else
                {
                    i = 0;
                    j++;
                    btn.Location = new Point(50 + 150 * i, 50 + 100 * j);
                    i++;
                }
                if (phong.TrangThai == 0)
                {
                    btn.BackColor = Color.White;
                }
                else btn.BackColor = Color.Red;
                btn.Click += new EventHandler(ButtonPhong_Click);
                btn.Visible = true;
                panelPhong.Controls.Add(btn);
            }
            labelPhongTrong.Text = soPhongTrong.ToString() + " phòng";
            labelPhongThue.Text = soPhongThue.ToString() + " phòng";
        }

        private void ButtonPhong_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            ChiTietPhongForm phongForm = new ChiTietPhongForm(btn.Text);
            phongForm.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.menu.AddControlToPanel(menuTraCuu);
        }
    }
}
