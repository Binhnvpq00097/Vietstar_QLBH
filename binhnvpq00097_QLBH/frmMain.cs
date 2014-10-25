using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace binhnvpq00097_QLBH
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmQLKhachHang frm = new frmQLKhachHang();
            frm.ShowDialog();
        }

        private void btnLoaiSP_Click(object sender, EventArgs e)
        {
            frmQLLoaiSP frm = new frmQLLoaiSP();
            frm.ShowDialog();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            frmQuanlySP frm = new frmQuanlySP();
            frm.ShowDialog();
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            frmHoaDon frm = new frmHoaDon();
            frm.ShowDialog();
        }
    }
}
