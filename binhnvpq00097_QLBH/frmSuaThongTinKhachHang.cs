using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using binhnvpq00097_QLBH.DAL;
using binhnvpq00097_QLBH.BO;


namespace binhnvpq00097_QLBH
{
    public partial class frmSuaThongTinKhachHang : Form
    {
        public frmSuaThongTinKhachHang()
        {
            InitializeComponent();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Tạo kết nối đến CSDL
            SqlConnection con = Database.GetConnection();

            // Tạo lệnh để thực hiện lấy dữ liệu
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update KhachHang set MaKH = @MaKHMoi, TenKh = @TenKH, DiaChi = @DiaChi, DienThoai = @DienThoai, Email = @Email Where MaKH = @MaKHCu";
            cmd.Parameters.Add("@MaKHMoi", SqlDbType.VarChar, 10).Value = txtMaKH.Text;
            cmd.Parameters.Add("@TenKH", SqlDbType.NVarChar, 50).Value = txtTenKH.Text;
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 200).Value = txtDiaChi.Text;
            cmd.Parameters.Add("@DienThoai", SqlDbType.VarChar, 30).Value = txtDienThoai.Text;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar, 200).Value = txtEmail.Text;

            KhachHang kh = (KhachHang)this.Tag;

            cmd.Parameters.Add("@MaKHCu", SqlDbType.VarChar, 15).Value = kh.MaKH;

            // Thực hiện lệnh.
            cmd.ExecuteNonQuery();


            MessageBox.Show("Đã Sửa mới khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmQLKhachHang frm = (frmQLKhachHang)kh.ParentForm;
            frm.LayDSKhachHang();
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSuaThongTinKhachHang_Load(object sender, EventArgs e)
        {
            KhachHang kh = (KhachHang)this.Tag;

            txtMaKH.Text = kh.MaKH;
            txtTenKH.Text = kh.TenKH;
            txtDiaChi.Text = kh.DiaChi;
            txtDienThoai.Text = kh.DienThoai;
            txtEmail.Text = kh.Email;
        }
    }
}
