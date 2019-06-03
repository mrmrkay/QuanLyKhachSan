using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.Forms;
using QuanLyKhachSan.UserController;

namespace QuanLyKhachSan.UserController
{
    public partial class ucTraCuu : UserControl
    {
        ucMenu menu = new ucMenu();
        public ucTraCuu(Control menu)
        {
            this.menu = menu as ucMenu; 
            InitializeComponent();
        }

        private void ucTraCuu_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.menu.AddControlToPanel(new ucMenu());
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            ucTraCuuPhong phong = new ucTraCuuPhong(menu, this);
            this.menu.AddControlToPanel(phong);
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            ucTraCuuDichVu dichVu = new ucTraCuuDichVu(menu, this);
            this.menu.AddControlToPanel(dichVu);
        }
    }
}
