using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.Objects;

namespace QuanLyKhachSan.Repositary
{
    class TBChiTietTienNghi
    {
        List<TienNghi> lstTienNghi = new List<TienNghi>();

        public List<TienNghi> LoadTienNghi(int maPhong)
        {
            string query = string.Format("Select * from CHITIETTIENNGHI where MaPhong = {0}", maPhong);
            DataTable dataTable = SQLConnection.Instance.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                string tenTienNghi = null;
                string queryTienNghi = string.Format("Select * from TIENNGHI where MaTienNghi = {0}", Convert.ToInt32(row["MaTienNghi"]));
                DataTable dataTableTienNghi = SQLConnection.Instance.ExecuteQuery(queryTienNghi);
                if (dataTableTienNghi.Rows.Count > 0)
                {
                    tenTienNghi = Convert.ToString(dataTableTienNghi.Rows[0]["TenTN"]);
                }
                TienNghi tienNghi = new TienNghi
                {
                    MaPhong = Convert.ToInt32(row["MaPhong"]),
                    MaTienNghi = Convert.ToInt32(row["MaTienNghi"]),
                    SoLuong = Convert.ToInt32(row["SoLuong"]),
                    TenTienNghi = tenTienNghi
                };
                lstTienNghi.Add(tienNghi);
            }
            return lstTienNghi;
        }
    }
}
