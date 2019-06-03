using QuanLyKhachSan.Objects;
using QuanLyKhachSan.Repositary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.Forms
{
    public partial class Login : Form
    {
        TBAccount tbAccount = new TBAccount();
        Account account = new Account();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            account = tbAccount.GetAccount(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            if(account == null)
            {
                txtPassword.Clear();
                MessageBox.Show("Tai khoan khong ton tai hoac mat khau sai");
            }
            else
            {
                var me = this;
                Account.acc = account;
                MainForm form = new MainForm();
                this.Hide();
                form.ShowDialog();
            }
        }
    }
}
