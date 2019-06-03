using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.UserController;

namespace QuanLyKhachSan.Forms
{
    public partial class ConfirmForm : Form
    {
        private ucThongTin ucThongTin;
        public ConfirmForm(string price, Control c)
        {
            ucThongTin = c as ucThongTin;
            InitializeComponent();
            label2.Text = price + "VND";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucThongTin.XacNhanDatPhong();
            MessageBox.Show("Đã xác nhận");
            this.Close();
        }
    }
}
