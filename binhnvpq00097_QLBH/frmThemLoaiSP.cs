using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using binhnvpq00097_QLBH.DAL;
using binhnvpq00097_QLBH.BO;

namespace binhnvpq00097_QLBH
{
    public partial class frmThemLoaiSP : Form
    {
        public frmThemLoaiSP()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Tạo kết nối đến CSDL
            SqlConnection con = Database.GetConnection();

            // Tạo lệnh để thực hiện lấy dữ liệu
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO LoaiSP VALUES (@MaLoai,@TenLoai)";
            cmd.Parameters.Add("@MaLoai", SqlDbType.VarChar, 10).Value = txtMaloai.Text;
            cmd.Parameters.Add("@TenLoai", SqlDbType.NVarChar, 50).Value = txtTenloai.Text;

            // Thực hiện lệnh.
            cmd.ExecuteNonQuery();

            MessageBox.Show("Đã thêm mới loại sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Xóa dữ liệu đã thêm vào CSDL
            txtMaloai.Text = "";
            txtTenloai.Text = "";

            //Chuyển con trỏ về ô MaKH
            txtMaloai.Focus();

            frmQLLoaiSP frm = (frmQLLoaiSP)this.Tag;
            frm.LayDSLoaiSP();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemLoaiSP_Load(object sender, EventArgs e)
        {
            txtMaloai.Focus();
        }
    }
}
