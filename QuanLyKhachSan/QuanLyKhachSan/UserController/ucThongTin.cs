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
using QuanLyKhachSan.Repositary;
using QuanLyKhachSan.Objects;

namespace QuanLyKhachSan.UserController
{
    public partial class ucThongTin : UserControl
    {
        private ucMenu ucmenu = null;
        SQLConnection connection;
        public ucThongTin(Control callingControll)
        {
            connection = new SQLConnection();
            ucmenu = callingControll as ucMenu;
            InitializeComponent();
            txtNgayNhanPhong.Text = DateTime.Now.ToString();
        }

        private void ucThongTinDatPhong2_Load(object sender, EventArgs e)
        {

        }

        private void buttonDatPhong_Click(object sender, EventArgs e)
        {
            int soNgay = Convert.ToInt32(txtSoNgay.Text);
            double tongTien = 0;
            string[] danhSachPhong = txtPhongThue.Text.Split(',');
            foreach (string phong in danhSachPhong)
            {
                string getPrice = string.Format("select * from PHONG where MaPhong = {0}", Convert.ToInt32(phong.Trim()));
                DataTable dt = connection.ExecuteQuery(getPrice);
                tongTien += Convert.ToDouble(dt.Rows[0]["Price"]) * soNgay;
            }
            ConfirmForm form = new ConfirmForm(tongTien.ToString(), this);
            form.Show();
        }

        private void buttonDanhSachPhong_Click(object sender, EventArgs e)
        {
            ucDanhSachPhong ucPhong = new ucDanhSachPhong(ucmenu, this);
            this.ucmenu.AddControlToPanel(ucPhong);
        }

        private void ClearTextBox()
        {
            txtHoTen.Text = "";
            txtCMND.Text = "";
            txtNgayNhanPhong.Text = DateTime.Now.ToString();
            txtPhongThue.Text = "";
            txtSoNgay.Text = "";
        }

        public void XacNhanDatPhong()
        {
            KhachHang customer = new KhachHang
            {
                CMND = txtCMND.Text,
                HoTen = txtHoTen.Text,
                NgaySinh = ngaySinh.Value,
                GioiTinh = radNam.Checked ? 1 : 0
            };

            string query = string.Format("Select * from KHACHHANG where SoCMT = '{0}'", customer.CMND);
            DataTable dataTable = connection.ExecuteQuery(query);
            if (dataTable.Rows.Count == 0)
            {
                string insert = string.Format("Insert into KHACHHANG( SoCMT, TenKH, GioiTinh, NgaySinh ) values (N'{0}', N'{1}', {2}, '{3}')", customer.CMND, customer.HoTen, customer.GioiTinh, ngaySinh.Value.ToShortDateString());
                connection.ExcuseNonQuery(insert);
            }

            string hoaDonPhong = string.Format("Insert into HOADONPHONG( SoCMT, MaNV ) values ('{0}', {1})", customer.CMND, Account.acc.MaNV);
            connection.ExcuseNonQuery(hoaDonPhong);

            DataTable phongTable = connection.ExecuteQuery("Select * from HOADONPHONG");
            int maHoaDon = Convert.ToInt32(phongTable.Rows[phongTable.Rows.Count - 1]["MaHoaDonPhong"]);
            string[] danhSachPhong = txtPhongThue.Text.Split(',');
            foreach (string phong in danhSachPhong)
            {
                string queryPhong = string.Format("Update PHONG set TrangThai = 1 where MaPhong = {0}", Convert.ToInt32(phong.Trim()));
                connection.ExcuseNonQuery(queryPhong);
                string ChiTietHoaDon = string.Format("Insert into CHITIETTHUEPHONG( MaHoaDonPhong, MaPhong, SoNgay, NgayThue ) values ({0}, {1}, {2}, '{3}')", maHoaDon, Convert.ToInt32(phong.Trim()), Convert.ToInt32(txtSoNgay.Text), Convert.ToDateTime(txtNgayNhanPhong.Text).ToShortDateString());
                connection.ExcuseNonQuery(ChiTietHoaDon);
            }
            ClearTextBox();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.ucmenu.AddControlToPanel(new ucMenu());
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang();
            TBKhachHang tbKhachHang = new TBKhachHang();
            khachHang = tbKhachHang.LayKhachHang(txtCMND.Text.Trim());

            if (khachHang != null)
            {
                txtHoTen.Text = khachHang.HoTen;
                if (khachHang.GioiTinh == 1)
                {
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }
                ngaySinh.Value = khachHang.NgaySinh;
                txtNgayNhanPhong.Text = "";
                txtPhongThue.Text = tbKhachHang.LayDanhSachPhongThue(txtCMND.Text.Trim());
            }


        }

        private void buttonTraPhong_Click(object sender, EventArgs e)
        {
            TBPhong tbPhong = new TBPhong();
            string[] phongs = txtPhongThue.Text.Split(',');
            for(int i = 0; i < phongs.Count() - 1; i++)
            {
                tbPhong.TraPhong(phongs[i]);
            }
            ClearTextBox();
            MessageBox.Show("Da tra thanh cong");
        }
    }
}
