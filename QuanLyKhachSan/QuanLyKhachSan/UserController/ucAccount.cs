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

namespace QuanLyKhachSan.UserController
{
    public partial class ucAccount : UserControl
    {
        ucMenu menu;
        SQLConnection connection;
        public ucAccount(Control menu)
        {
            connection = new SQLConnection();
            this.menu = menu as ucMenu;
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string hoten = txtHoTen.Text;
            int gioiTinh = radNam.Checked ? 1 : 0;
            string ngaySinh = txtNgaySinh.Text;
            string chucVu = txtChucVu.Text;
            string query = string.Format("INSERT INTO dbo.NHANVIEN(TenNV, GioiTinh, NgaySinh, ChucVu) VALUES(N'{0}', {1}, '{2}', N'{3}')", hoten, gioiTinh, ngaySinh, chucVu);
            connection.ExcuseNonQuery(query);

            query = string.Format("Select * from NHANVIEN where TenNV = N'{0}'", hoten);
            DataTable table = connection.ExecuteQuery(query);

            if(table.Rows.Count > 0)
            {
                query = string.Format("INSERT INTO dbo.ACCOUNT (MaNV, TenTK, MatKhau, IsAdmin) VALUES ({0}, N'{1}', N'{2}', {3})", Convert.ToInt32(table.Rows[0]["MaNV"]), txtUsername.Text, txtPassword.Text, cbAdmin.Checked ? 1 : 0);
                connection.ExcuseNonQuery(query);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.menu.AddControlToPanel(new ucMenu());
        }
    }
}
