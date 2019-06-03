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

namespace QuanLyKhachSan.UserController
{
    public partial class ucDanhSachPhong : UserControl
    {
        TBPhong tbPhong = new TBPhong();
        private ucMenu ucmenu = null;
        private ucThongTin ucThongTin = null;

        public ucDanhSachPhong(Control menu, Control info)
        {
            ucmenu = menu as ucMenu;
            ucThongTin = info as ucThongTin;
            InitializeComponent();
        }

        private void ucDanhSachPhong_Load(object sender, EventArgs e)
        {
            List<Phong> lstPhong = tbPhong.LoadPhong();
            int i = 0, j = 0;
            foreach (Phong phong in lstPhong)
            {
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
                if (phong.TrangThai == 0) btn.BackColor = Color.White;
                //btn.Click += new EventHandler(ButtonPhong_Click);
                else btn.BackColor = Color.Red;
                btn.Visible = true;
                Controls.Add(btn);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.ucmenu.AddControlToPanel(ucThongTin);
        }
    }
}
