using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Objects
{
    class PhongThue
    {
        public string SoCMT { get; set; }
        public int MaPhong { get; set; }
        public DateTime NgayNhan { get; set; }
        public DateTime NgayTra { get; set; }
        public int SoNgay { get; set; }

        public void SetNgayTra()
        {
            string[] ngayNhans = Convert.ToString(NgayNhan).Split(' ');
            string[] splitNgay = ngayNhans[0].Split('/');
            int ngay = Convert.ToInt32(splitNgay[1]);
            int thang = Convert.ToInt32(splitNgay[0]);
            int nam = Convert.ToInt32(splitNgay[2]);
            ngay = ngay + SoNgay;
            if (thang == 2)
            {
                if (ngay > 28)
                {
                    ngay = ngay - 28;
                    thang++;
                }
            } 
            else if(thang == 4 || thang == 6 || thang == 9 || thang == 11) 
            {
                if (ngay > 30)
                {
                    ngay = ngay - 30;
                    thang++;
                }
            } else
            {
                if (ngay > 31)
                {
                    ngay = ngay - 31;
                    thang++;
                }
            }

            string ngayTra = thang.ToString() + "/" + ngay.ToString() + "/" + nam.ToString();
            NgayTra = Convert.ToDateTime(ngayTra);
        }
    }
}
