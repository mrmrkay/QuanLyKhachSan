using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.Objects;

namespace QuanLyKhachSan.Repositary
{
    class TBDichVu
    {
        List<DichVu> lstDichVu = new List<DichVu>();

        public List<DichVu> LoadDichVu()
        {
            DataTable dataTable = SQLConnection.Instance.ExecuteQuery("Select * from DICHVU");
            foreach (DataRow row in dataTable.Rows)
            {
                DichVu dichVu = new DichVu
                {
                    MaDichVu = Convert.ToInt32(row["MaDichVu"]),
                    Price = Convert.ToDouble(row["Price"]),
                    TenDichVu = Convert.ToString(row["TenDV"])
                };
                lstDichVu.Add(dichVu);
            }
            return lstDichVu;
        }

        public DichVu LayDichVu(string tenDV)
        {
            string query = string.Format("Select * from DICHVU where TenDV = N'{0}'", tenDV);
            DataTable dataTable = SQLConnection.Instance.ExecuteQuery(query);
            if (dataTable.Rows.Count > 0)
            {
                DichVu dv = new DichVu
                {
                    MaDichVu = Convert.ToInt32(dataTable.Rows[0]["MaDichVu"]),
                    TenDichVu = Convert.ToString(dataTable.Rows[0]["TenDV"])
                };
                return dv;
            }
            return null;
        }

        public double LayGiaDichVu(string tenDV)
        {
            string query = string.Format("Select * from DICHVU where TenDV = N'{0}'", tenDV);
            DataTable dataTable = SQLConnection.Instance.ExecuteQuery(query);
            if(dataTable.Rows.Count > 0)
            {
                double price = Convert.ToDouble(dataTable.Rows[0]["Price"]);
                return price;
            }
            return 0;
        }
        
        public List<DichVuDuocDat> LayDanhSachDichVuDuocDat()
        {
            List<DichVuDuocDat> lstDichVu = new List<DichVuDuocDat>();
            string query = string.Format("SELECT dbo.KHACHHANG.SoCMT,TenKH, TenDV, NgayThue FROM dbo.CHITIETTHUEDICHVU, dbo.KHACHHANG, dbo.HOADONDICHVU, dbo.DICHVU"
                                            + " WHERE dbo.CHITIETTHUEDICHVU.MaHoaDonDichVu = dbo.HOADONDICHVU.MaHoaDonDichVu"
                                            +" AND HOADONDICHVU.SoCMT = dbo.KHACHHANG.SoCMT"
                                            +" AND dbo.DICHVU.MaDichVu = dbo.CHITIETTHUEDICHVU.MaDichVu");
            DataTable dataTable = SQLConnection.Instance.ExecuteQuery(query);
            if (dataTable.Rows.Count > 0)
            {
                foreach(DataRow row in dataTable.Rows)
                {
                    DichVuDuocDat newItem = new DichVuDuocDat
                    {
                        MaKhachHang = Convert.ToInt32(row["SoCMT"]),
                        TenKhachHang = Convert.ToString(row["TenKH"]),
                        TenDichVu = Convert.ToString(row["TenDV"]),
                        NgayThue = Convert.ToDateTime(row["NgayThue"])
                    };
                    lstDichVu.Add(newItem);
                }
            }
            return lstDichVu;
        }
    }
}
