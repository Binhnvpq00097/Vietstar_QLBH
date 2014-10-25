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
using binhnvpq00097_QLBH.BOLOAISP;

namespace binhnvpq00097_QLBH
{
    public partial class frmSuaThongTinLoaiSP : Form
    {
        public frmSuaThongTinLoaiSP()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSuaThongTinLoaiSP_Load(object sender, EventArgs e)
        {
            LoaiSP lsp = (LoaiSP)this.Tag;

            txtMaloai.Text = lsp.MaLoai;
            txtTenloai.Text = lsp.TenLoai;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Tạo kết nối đến CSDL
            SqlConnection con = Database.GetConnection();

            // Tạo lệnh để thực hiện lấy dữ liệu
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update LoaiSP set MaLoai = @MaLoaiMoi, TenLoai = @TenLoai Where MaLoai = @MaLoaiCu";
            cmd.Parameters.Add("@MaLoaiMoi", SqlDbType.VarChar, 10).Value = txtMaloai.Text;
            cmd.Parameters.Add("@TenLoai", SqlDbType.NVarChar, 50).Value = txtTenloai.Text;
            LoaiSP lsp = (LoaiSP)this.Tag;

            cmd.Parameters.Add("@MaLoaiCu", SqlDbType.VarChar, 10).Value = lsp.MaLoai;

            // Thực hiện lệnh.
            cmd.ExecuteNonQuery();


            MessageBox.Show("Đã Sửa mới loại sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmQLLoaiSP frm = (frmQLLoaiSP)lsp.ParentForm;
            frm.LayDSLoaiSP();
            this.Close();
        }
    }
}
