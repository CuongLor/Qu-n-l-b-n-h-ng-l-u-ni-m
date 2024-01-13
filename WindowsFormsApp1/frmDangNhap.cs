using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            Class.Function.Connect();
        }
        QuanLy ql = new QuanLy();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
            string username = txbUsername.Text;
            string password = txbPassWord.Text;
            if (txbPassWord.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbPassWord.Focus();
                return;
            }
            if (txbUsername.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tài khoản hoặc mật khẩu ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbUsername.Focus();
                return;
            }
            if (ql.AuthenticateUser(username,password))
            {
                // Đăng nhập thành công
                frmMain main = new frmMain();
                fromnv nv = new fromnv();
               
                if (ql.typeacc(username, password) == 1)
                {
                    this.Hide();
                    main.ShowDialog();
                }
                else
                {
                    this.Hide();
                    nv.ShowDialog();
                }
                // this.Show();

            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
