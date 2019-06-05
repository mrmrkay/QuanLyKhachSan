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
                cbDichVu.Location = new Point(50, 40 + 40*i);
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

                TextBox txtNgay = new TextBox();
                txtNgay.Name = "txtNgay" + dv.MaDichVu;
                txtNgay.Location = new Point(260, 10 + i * 40);
                txtNgay.Visible = true;
                txtNgay.Width = 150;

                panelChiTiet.Controls.Add(giaDV);
                panelChiTiet.Controls.Add(tenDV);
                panelChiTiet.Controls.Add(txtNgay);
                i++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
         {
            foreach( DichVuDuocDat dvDat in lstDichVuDaDat)
            {
                DichVu dv = tbDichVu.LayDichVu(dvDat.TenDichVu);
                foreach (Control c in panelChiTiet.Controls.OfType<TextBox>())
                {
                    if(c.Name == "txtNgay" + dv.MaDichVu)
                    {
                        try
                        {
                            dvDat.NgayThue = Convert.ToDateTime(c.Text);
                        } catch
                        {
                            MessageBox.Show("Bạn nhập sai định dạng ngày");
                        }
                    }
                }
            }
            ChiTietHoaDocDichVu dichVuForm = new ChiTietHoaDocDichVu(tong.ToString(), this);
            dichVuForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ucmenu.AddControlToPanel(new ucMenu());
        }

        public void LuuChiTietToDatabase()
        {
            string hoaDonDichVu = string.Format("Insert into HOADONDICHVU( SoCMT, MaNV ) values ('{0}', {1})", Convert.ToInt32(txtCMT.Text), Account.acc.MaNV);
            connection.ExcuseNonQuery(hoaDonDichVu);

            DataTable dichVuTable = connection.ExecuteQuery("Select * from HOADONDICHVU");
            int maDV = Convert.ToInt32(dichVuTable.Rows[dichVuTable.Rows.Count - 1]["MaHoaDonDichVu"]);

            foreach (DichVuDuocDat item in lstDichVuDaDat)
            {
                DichVu dv = tbDichVu.LayDichVu(item.TenDichVu);
                string ChiTietDichVu = string.Format("Insert into CHITIETTHUEDICHVU( MaHoaDonDichVu, MaDichVu, NgayThue ) values ({0}, {1}, '{2}')", maDV, dv.MaDichVu, item.NgayThue);
                connection.ExcuseNonQuery(ChiTietDichVu);
            }
            LoadDichVu();
            txtCMT.Clear();
            lstDichVuDaDat.Clear();
            LoadDichVuDaDat();
        }
    }
}
