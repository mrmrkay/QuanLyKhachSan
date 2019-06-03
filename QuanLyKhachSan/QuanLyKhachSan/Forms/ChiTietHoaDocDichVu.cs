using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.UserController;

namespace QuanLyKhachSan.Forms
{
    public partial class ChiTietHoaDocDichVu : Form
    {
        ucThueDichVu ucDichVu;
        public ChiTietHoaDocDichVu(string price, Control c)
        {
            ucDichVu = c as ucThueDichVu;
            InitializeComponent();
            lblTong.Text = price + " VND";
        }

        private void ChiTietHoaDocDichVu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucDichVu.LuuChiTietToDatabase();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
