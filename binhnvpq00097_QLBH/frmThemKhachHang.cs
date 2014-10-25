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
    public partial class frmThemKhachHang : Form
    {
        public frmThemKhachHang()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Tạo kết nối đến CSDL
            SqlConnection con = Database.GetConnection();

            // Tạo lệnh để thực hiện lấy dữ liệu
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO KhachHang VALUES (@MaKH,@TenKH,@DiaChi,@DienThoai,@Email)";
            cmd.Parameters.Add("@MaKH", SqlDbType.VarChar, 10).Value = txtMaKH.Text;
            cmd.Parameters.Add("@TenKH", SqlDbType.NVarChar, 50).Value = txtTenKH.Text;
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 200).Value = txtDiaChi.Text;
            cmd.Parameters.Add("@DienThoai", SqlDbType.VarChar, 30).Value = txtDienThoai.Text;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar, 200).Value = txtEmail.Text;

            // Thực hiện lệnh.
            cmd.ExecuteNonQuery();

            MessageBox.Show("Đã thêm mới khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Xóa các thông tin KH đã được lưu và CSDL
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";

            //Chuyển con trỏ về ô mã KH
            txtMaKH.Focus();
           

            frmQLKhachHang frm = (frmQLKhachHang)this.Tag;
            frm.LayDSKhachHang();
        }

        private void frmThemKhachHang_Load(object sender, EventArgs e)
        {
            //Chuyển con trỏ về ô mã KH
            txtMaKH.Focus();
        }
    }
}
