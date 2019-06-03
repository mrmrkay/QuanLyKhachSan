using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.Repositary;
using QuanLyKhachSan.Objects;

namespace QuanLyKhachSan.Forms
{
    public partial class ChiTietPhongForm : Form
    {
        TBChiTietTienNghi tbTienNghi = new TBChiTietTienNghi();
        TBKhachHang tbKhachHang = new TBKhachHang();
        KhachHang khachHang = new KhachHang();
        TBPhong tbPhong = new TBPhong();
        Phong phong = new Phong();
        
        List<TienNghi> lstTienNghi = new List<TienNghi>();
        int maPhong;
        public ChiTietPhongForm(string maPhong)
        {
            this.maPhong = Convert.ToInt32(maPhong);
            phong = tbPhong.LayPhong(maPhong);
            InitializeComponent();
            labelPhong.Text = "Phòng " + maPhong.ToString();
        }

        private void ChiTietPhongForm_Load(object sender, EventArgs e)
        {
            labelPhong.Text = "Phòng " + phong.MaPhong.ToString();
            labelTrangThai.Text = phong.TrangThai == 0 ? "Chưa thuê" : "Đã thuê";
            if(phong.TrangThai == 0)
            {
                panelTrangThai.Controls.Clear();
            }
            else
            {
                PhongThue phongThue = new PhongThue();
                phongThue = tbKhachHang.LayPhongThue(phong.MaPhong);
                khachHang = tbKhachHang.LayKhachHang(phongThue.SoCMT);
                labelTen.Text = khachHang.HoTen;
                labelCMT.Text = phongThue.SoCMT;
                labelTuNgay.Text = phongThue.NgayNhan.ToString();
                labelDenNgay.Text = phongThue.NgayTra.ToString();
            }

            lstTienNghi = tbTienNghi.LoadTienNghi(maPhong);
            listViewTienNghi.Columns.Add("Tên tiện nghi").Width = 400;
            listViewTienNghi.Columns.Add("Số lượng").Width = 300;

            foreach(TienNghi row in lstTienNghi)
            {
                ListViewItem item = new ListViewItem(row.TenTienNghi);
                item.SubItems.Add(row.SoLuong.ToString());
                listViewTienNghi.Items.Add(item);
            }
        }

        public int GetDay(string date)
        {
            return 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
