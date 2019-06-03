using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.Objects;
using QuanLyKhachSan.UserController;

namespace QuanLyKhachSan.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ucMenu ucmenu = new ucMenu();
            AddControlToPanel(ucmenu);

        }

        private void AddControlToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(c);
        }

        private void panelControl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
