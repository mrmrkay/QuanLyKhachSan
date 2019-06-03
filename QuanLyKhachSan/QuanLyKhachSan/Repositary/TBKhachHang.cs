using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.Objects;

namespace QuanLyKhachSan.Repositary
{
    class TBKhachHang
    {
        public KhachHang LayKhachHang(string maKH)
        {
            string query = string.Format("Select * from KHACHHANG where SoCMT = N'{0}'", maKH);
            DataTable dataTable = SQLConnection.Instance.ExecuteQuery(query);
            if (dataTable.Rows.Count > 0)
            {
                KhachHang khachHang = new KhachHang
                {
                    CMND = Convert.ToString(dataTable.Rows[0]["SoCMT"]),
                    HoTen = Convert.ToString(dataTable.Rows[0]["TenKH"]),
                    GioiTinh = Convert.ToInt32(dataTable.Rows[0]["GioiTinh"]),
                    NgaySinh = Convert.ToDateTime(dataTable.Rows[0]["NgaySinh"])
                };
                return khachHang;
            }
            return null;
        }

        public PhongThue LayPhongThue(int maPhong)
        {
            int maHoaDon = 0;
            string maKH = null;
            string ngayNhan = null;
            int soNgay = 0;
            string queryChiTiet = string.Format("Select * from CHITIETTHUEPHONG where MaPhong = {0} order by Ma DESC", maPhong);
            DataTable dataTable = SQLConnection.Instance.ExecuteQuery(queryChiTiet);
            if (dataTable.Rows.Count > 0)
            {
                maHoaDon = Convert.ToInt32(dataTable.Rows[0]["MaHoaDonPhong"]);
                ngayNhan = Convert.ToString(dataTable.Rows[0]["NgayThue"]);
                soNgay = Convert.ToInt32(dataTable.Rows[0]["SoNgay"]);
            }

            string queryHoaDon = string.Format("Select * from HOADONPHONG where MaHoaDonPhong = {0} order by MaHoaDonPhong DESC", maHoaDon);
            dataTable = SQLConnection.Instance.ExecuteQuery(queryHoaDon);
            if (dataTable.Rows.Count > 0)
            {
                maKH = Convert.ToString(dataTable.Rows[0]["SoCMT"]);
            }

            PhongThue phong = new PhongThue
            {
                MaPhong = maPhong,
                SoCMT = maKH,
                NgayNhan = Convert.ToDateTime(ngayNhan),
                SoNgay = Convert.ToInt32(soNgay)
            };
            phong.SetNgayTra();
            return phong;
        }
    }
}
