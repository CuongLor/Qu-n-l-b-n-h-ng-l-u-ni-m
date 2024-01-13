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
    public partial class fromnv : Form
    {
        public fromnv()
        {
            InitializeComponent();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmDanhMucKhachHang kh = new frmDanhMucKhachHang();
            //this.Hide();
            kh.Show();
        }

        private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            frmHoaDonBanHang hd = new frmHoaDonBanHang();
            //this.Hide();
            hd.Show();

        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Danhmuc dm = new Danhmuc();
            dm.Show();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
