using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.Objects;       

namespace QuanLyKhachSan.Repositary
{
    class TBAccount
    {
        public Account GetAccount(string username, string password)
        {
            string query = string.Format("Select * from ACCOUNT where TenTK = N'{0}'", username);
            DataTable dataTable = SQLConnection.Instance.ExecuteQuery(query);
            if (dataTable.Rows.Count > 0)
            {
                if (dataTable.Rows[0]["MatKhau"].ToString() == password)
                {
                    Account acc = new Account
                    {
                        MaNV = Convert.ToInt32(dataTable.Rows[0]["MaNV"]),
                        TenTK = Convert.ToString(dataTable.Rows[0]["TenTK"]),
                        MatKhau = Convert.ToString(dataTable.Rows[0]["MatKhau"]),
                        IsAdmin = Convert.ToInt32(dataTable.Rows[0]["IsAdmin"])
                    };
                    return acc;
                }
            }
            return null;
        }
    }
}
