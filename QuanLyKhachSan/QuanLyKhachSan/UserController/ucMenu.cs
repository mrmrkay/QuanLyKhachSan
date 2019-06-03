using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.UserController
{
    public partial class ucMenu : UserControl
    {
        public ucMenu()
        {
            InitializeComponent();
        }

        public Panel GetPanel()
        {
            return this.panelControl;
        }

        public void AddControlToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            GetPanel().Controls.Clear();
            GetPanel().Controls.Add(c);
        }

        private void ucMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            ucTraCuu traCuu = new ucTraCuu(this);
            AddControlToPanel(traCuu);
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            ucThueDichVu ucDichVu = new ucThueDichVu(this);
            AddControlToPanel(ucDichVu);
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            ucThongTin ucThongTin = new ucThongTin(this);
            AddControlToPanel(ucThongTin);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ucAccount account = new ucAccount(this);
            AddControlToPanel(account);
        }
    }
}
