using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.Repositary;
using QuanLyKhachSan.Objects;
using QuanLyKhachSan.Forms;

namespace QuanLyKhachSan.UserController
{
    public partial class ucThueDichVu : UserControl
    {
        List<CheckBox> lstCbDichVu = new List<CheckBox>();
        List<DichVuDuocDat> lstDichVuDaDat = new List<DichVuDuocDat>();
        TBDichVu tbDichVu = new TBDichVu();
        private ucMenu ucmenu = null;
        SQLConnection connection;
        public double tong = 0;

        public ucThueDichVu(Control menu)
        {
            connection = new SQLConnection();
            ucmenu = menu as ucMenu;
            InitializeComponent();
        }

        private void ucThueDichVu_Load(object sender, EventArgs e)
        {
            LoadDichVu();
        }

        public void LoadDichVu()
        {
            panel1.Controls.Clear();
            List<DichVu> lstDichVu = new List<DichVu>();
            lstDichVu = tbDichVu.LoadDichVu();
            int i = 1;
            foreach(DichVu item in lstDichVu)
            {
                CheckBox cbDichVu = new CheckBox();
                cbDichVu.Name = "cbDichVu" + item.MaDichVu;
                cbDichVu.Text = item.TenDichVu;
                if(i>=8)
                {
                    cbDichVu.Location = new Point(220, -20 + 40 * (i-8));
                }
                else
                {
                    cbDichVu.Location = new Point(20, -20 + 40 * i);
                }
                cbDichVu.Width = 200;
                cbDichVu.Visible = true;
                cbDichVu.CheckedChanged += new EventHandler(CBDichVu_Checked);
                i++;
                lstCbDichVu.Add(cbDichVu);
                panel1.Controls.Add(cbDichVu);
            }
        }

        public void CBDichVu_Checked(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            DichVuDuocDat dv = new DichVuDuocDat { TenDichVu = cb.Text };
            if(cb.Checked == true)
            {
                lstDichVuDaDat.Add(dv);
            }
            else
            {
                DichVuDuocDat dichVu = lstDichVuDaDat.Where(x => x.TenDichVu == dv.TenDichVu).SingleOrDefault();
                lstDichVuDaDat.Remove(dichVu);
            }
            LoadDichVuDaDat();
        }

        public void LoadDichVuDaDat()
        {
            panelChiTiet.Controls.Clear();
            tong = 0;
            int i = 0;
            foreach(DichVuDuocDat item in lstDichVuDaDat)
            {
                DichVu dv = tbDichVu.LayDichVu(item.TenDichVu);

                Label tenDV = new Label();
                tenDV.Text = item.TenDichVu;
                tenDV.Location = new Point(10, 10 + i * 40);
                tenDV.Visible = true;
                tenDV.Width = 150;

                double price = tbDichVu.LayGiaDichVu(item.TenDichVu);
                tong += price;
                Label giaDV = new Label();
                giaDV.Text = price.ToString() + " VND";
                giaDV.Location = new Point(160, 10 + i * 40);
                giaDV.Visible = true;
                giaDV.Width = 100;

                //TextBox txtNgay = new TextBox();
                //txtNgay.Name = "txtNgay" + dv.MaDichVu;
                //txtNgay.Location = new Point(260, 10 + i * 40);
                //txtNgay.Visible = true;
                //txtNgay.Width = 150;

                NumericUpDown nudSoLuong = new NumericUpDown();
                nudSoLuong.Name = "nudSoLuong" + dv.MaDichVu;
                nudSoLuong.Location = new Point(260, 10 + i * 40);
                nudSoLuong.Visible = true;
                nudSoLuong.Width = 100;
                nudSoLuong.Minimum = 0;
                nudSoLuong.DecimalPlaces = 0;

                panelChiTiet.Controls.Add(giaDV);
                panelChiTiet.Controls.Add(tenDV);
                //panelChiTiet.Controls.Add(txtNgay);
                panelChiTiet.Controls.Add(nudSoLuong);
                i++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
         {
            double totalTemp = 0;
            foreach( DichVuDuocDat dvDat in lstDichVuDaDat)
            {
                DichVu dv = tbDichVu.LayDichVu(dvDat.TenDichVu);
                foreach (Control c in panelChiTiet.Controls.OfType<NumericUpDown>())
                {
                    if (c.Name == "nudSoLuong" + dv.MaDichVu)
                    {
                        try
                        {
                            dvDat.SoLuong = Convert.ToInt32(c.Text);
                        }
                        catch
                        {
                            MessageBox.Show("Bạn nhập sai định dạng ngày");
                        }
                    }
                }
                dvDat.NgayThue = DateTime.Now;
                totalTemp += dvDat.SoLuong * tbDichVu.LayGiaDichVu(dvDat.TenDichVu);
            }
            ChiTietHoaDocDichVu dichVuForm = new ChiTietHoaDocDichVu(totalTemp.ToString(), this);
            dichVuForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ucmenu.AddControlToPanel(new ucMenu());
        }

        public void LuuChiTietToDatabase()
        {
            try
            {
                string hoaDonDichVu = string.Format("Insert into HOADONDICHVU( SoCMT, MaNV ) values ('{0}', {1})", Convert.ToInt32(txtCMT.Text), Account.acc.MaNV);
                connection.ExcuseNonQuery(hoaDonDichVu);

                DataTable dichVuTable = connection.ExecuteQuery("Select * from HOADONDICHVU");
                int maDV = Convert.ToInt32(dichVuTable.Rows[dichVuTable.Rows.Count - 1]["MaHoaDonDichVu"]);

                foreach (DichVuDuocDat item in lstDichVuDaDat)
                {
                    DichVu dv = tbDichVu.LayDichVu(item.TenDichVu);
                    string ChiTietDichVu = string.Format("Insert into CHITIETTHUEDICHVU( MaHoaDonDichVu, MaDichVu, NgayThue, SoLuong ) values ({0}, {1}, '{2}',{3})", maDV, dv.MaDichVu, item.NgayThue.ToShortDateString(), item.SoLuong);
                    connection.ExcuseNonQuery(ChiTietDichVu);
                }
                LoadDichVu();
                txtCMT.Clear();
                lstDichVuDaDat.Clear();
                LoadDichVuDaDat();
            }
            catch (Exception)
            {
                MessageBox.Show("Nhập sai cmt hoặc khách hàng không tồn tại");
            }        
        }
    }
}
