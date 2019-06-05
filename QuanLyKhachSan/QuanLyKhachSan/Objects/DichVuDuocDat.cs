using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Objects
{
    class DichVuDuocDat
    {
        public int MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string TenDichVu { get; set; }
        public DateTime NgayThue { get; set; }
        public int SoLuong { get; set; }
        public string HomNay()
        {
            string[] ngayThues = Convert.ToString(DateTime.Now).Split(' ');
            return ngayThues[0];
        }

        public List<DichVuDuocDat> ListHomNay(List<DichVuDuocDat> lst)
        {
            List<DichVuDuocDat> lstHomNay = new List<DichVuDuocDat>();

            foreach(DichVuDuocDat dv in lst)
            {
                string[] ngayThues = Convert.ToString(dv.NgayThue).Split(' ');
                string[] splitNgay = ngayThues[0].Split('/');
                int thang = Convert.ToInt32(splitNgay[1]);
                int ngay = Convert.ToInt32(splitNgay[0]);
                int nam = Convert.ToInt32(splitNgay[2]);

                string ngayThue = thang.ToString() + "/" + ngay.ToString() + "/" + nam.ToString();

                string homNay = HomNay();
                if(ngayThue == homNay)
                {
                    lstHomNay.Add(dv);
                }
            }
            return lstHomNay;
            
        }

        public List<DichVuDuocDat> ListNgayMai(List<DichVuDuocDat> lst)
        {
            List<DichVuDuocDat> lstNgayMai = new List<DichVuDuocDat>();
            foreach (DichVuDuocDat dv in lst)
            {
                string[] ngayMais = Convert.ToString(dv.NgayThue).Split(' ');

                string homNay = HomNay();
                string[] splitNgay = homNay.Split('/');
                int ngay = Convert.ToInt32(splitNgay[1]);
                int thang = Convert.ToInt32(splitNgay[0]);
                int nam = Convert.ToInt32(splitNgay[2]);
                ngay = ngay + 1;
                if (thang == 2)
                {
                    if (ngay > 28)
                    {
                        ngay = ngay - 28;
                        thang++;
                    }
                }
                else if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
                {
                    if (ngay > 30)
                    {
                        ngay = ngay - 30;
                        thang++;
                    }
                }
                else
                {
                    if (ngay > 31)
                    {
                        ngay = ngay - 31;
                        thang++;
                    }
                }

                homNay = thang.ToString() + "/" + ngay.ToString() + "/" + nam.ToString();
                
                if (ngayMais[0] == homNay)
                {
                    lstNgayMai.Add(dv);
                }
            }
            return lstNgayMai;
        }
    }
}
