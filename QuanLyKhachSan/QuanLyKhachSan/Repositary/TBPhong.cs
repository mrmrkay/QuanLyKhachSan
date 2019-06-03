using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.Objects;

namespace QuanLyKhachSan.Repositary
{
    class TBPhong
    {
        List<Phong> lstPhong = new List<Phong>();

        public List<Phong> LoadPhong()
        {
            DataTable dataTable = SQLConnection.Instance.ExecuteQuery("Select * from PHONG");
            foreach(DataRow row in dataTable.Rows)
            {
                Phong phong = new Phong
                {
                    MaPhong = Convert.ToInt32(row["MaPhong"]),
                    Price = Convert.ToDouble(row["Price"]),
                    TrangThai = Convert.ToInt32(row["TrangThai"])
                };
                lstPhong.Add(phong);
            }
            return lstPhong;
        }

        public Phong LayPhong(string maPhong)
        {
            string query = string.Format("Select * from PHONG where MaPhong = {0}", Convert.ToInt32(maPhong));
            DataTable dataTable = SQLConnection.Instance.ExecuteQuery(query);
            if (dataTable.Rows.Count > 0)
            {
                Phong phong = new Phong
                {
                    MaPhong = Convert.ToInt32(dataTable.Rows[0]["MaPhong"]),
                    Price = Convert.ToDouble(dataTable.Rows[0]["Price"]),
                    TrangThai = Convert.ToInt32(dataTable.Rows[0]["TrangThai"])
                };
                return phong;
            }
            return null;
        }
    }
}
