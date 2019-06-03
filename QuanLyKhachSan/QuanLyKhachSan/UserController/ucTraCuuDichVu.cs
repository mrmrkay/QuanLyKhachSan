using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.Objects;
using QuanLyKhachSan.Repositary;

namespace QuanLyKhachSan.UserController
{
    public partial class ucTraCuuDichVu : UserControl
    {
        List<DichVuDuocDat> lstDichVu = new List<DichVuDuocDat>();
        TBDichVu tbDichVu = new TBDichVu();
        ucMenu menu;
        ucTraCuu menuTraCuu;
        DichVuDuocDat dichVu = new DichVuDuocDat();
        public ucTraCuuDichVu(Control menu, Control menuTraCuu)
        {
            this.menu = menu as ucMenu;
            this.menuTraCuu = menuTraCuu as ucTraCuu;

            InitializeComponent();
        }

        private void ucTraCuuDichVu_Load(object sender, EventArgs e)
        {
            LoadDichVuDuocDat();
        }

        public void LoadDichVuDuocDat()
        {
            lstDichVu = tbDichVu.LayDanhSachDichVuDuocDat();

            lsvDichVu.Columns.Add("Số CMT").Width = 100;
            lsvDichVu.Columns.Add("Tên khách hàng").Width = 100;
            lsvDichVu.Columns.Add("Tên dịch vụ").Width = 200;
            lsvDichVu.Columns.Add("Ngày thuê").Width = 100;

            foreach (DichVuDuocDat row in lstDichVu)
            {
                ListViewItem item = new ListViewItem(row.MaKhachHang.ToString());
                item.SubItems.Add(row.TenKhachHang);
                item.SubItems.Add(row.TenDichVu);
                item.SubItems.Add(row.NgayThue.ToString());
                lsvDichVu.Items.Add(item);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.menu.AddControlToPanel(new ucTraCuu(menu));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstDichVu = tbDichVu.LayDanhSachDichVuDuocDat();
            List<DichVuDuocDat> lstHomNay = new List<DichVuDuocDat>();
            lstHomNay = dichVu.ListHomNay(lstDichVu);

            lsvDichVu.Items.Clear();

            foreach (DichVuDuocDat row in lstHomNay)
            {
                ListViewItem item = new ListViewItem(row.MaKhachHang.ToString());
                item.SubItems.Add(row.TenKhachHang);
                item.SubItems.Add(row.TenDichVu);
                item.SubItems.Add(row.NgayThue.ToString());
                lsvDichVu.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstDichVu = tbDichVu.LayDanhSachDichVuDuocDat();
            List<DichVuDuocDat> lstNgayMai = new List<DichVuDuocDat>();
            lstNgayMai = dichVu.ListNgayMai(lstDichVu);

            lsvDichVu.Items.Clear();

            foreach (DichVuDuocDat row in lstNgayMai)
            {
                ListViewItem item = new ListViewItem(row.MaKhachHang.ToString());
                item.SubItems.Add(row.TenKhachHang);
                item.SubItems.Add(row.TenDichVu);
                item.SubItems.Add(row.NgayThue.ToString());
                lsvDichVu.Items.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadDichVuDuocDat();
        }
    }
}
