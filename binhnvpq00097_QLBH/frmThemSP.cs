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
    public partial class frmThemSP : Form
    {
        public frmThemSP()
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
            cmd.CommandText = "INSERT INTO SanPham VALUES (@MaSP,@TenSP,@SoLuong,@DonViTinh,@DonGia,@MaLoai)";
            cmd.Parameters.Add("@MaSP", SqlDbType.VarChar, 10).Value = txtMaSP.Text;
            cmd.Parameters.Add("@TenSP", SqlDbType.NVarChar, 50).Value = txtTenSP.Text;
            cmd.Parameters.Add("@SoLuong",SqlDbType.Int).Value = txtSoLuong.Text;
            cmd.Parameters.Add("@DonViTinh", SqlDbType.NVarChar, 10).Value = txtDonViTinh.Text;
            cmd.Parameters.Add("@DonGia", SqlDbType.Decimal).Value = txtDonGia.Text;
            //cmd.Parameters.Add("@MaLoai", SqlDbType.NVarChar, 10).Value = cobMaLoai.Text;
            cmd.Parameters.Add("@MaLoai", SqlDbType.NVarChar, 10).Value = cobMaLoai.SelectedValue.ToString();

            // Thực hiện lệnh.
            cmd.ExecuteNonQuery();

            MessageBox.Show("Đã thêm mới Sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Xóa các thông tin KH đã được lưu và CSDL
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtSoLuong.Text = "";
            txtDonViTinh.Text = "";
            txtDonGia.Text = "";
            //cobMaLoai.Text = "";

            //Chuyển con trỏ về ô mã KH
            txtMaSP.Focus();


            frmQuanlySP frm = (frmQuanlySP)this.Tag;
            frm.LayDSSP();
        }

        private void frmThemSP_Load(object sender, EventArgs e)
        {
            //Ghi chú cobMaLoai
            cobMaLoai.Text = "";
            
            // Tạo kết nối đến CSDL
            SqlConnection con = Database.GetConnection();

            // Tạo lệnh để thực hiện lấy dữ liệu
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM LoaiSP";

            // Thực hiện lệnh.
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "LoaiSP");

            cobMaLoai.DataSource = ds.Tables["LoaiSP"];
            cobMaLoai.DisplayMember = "TenLoai";
            cobMaLoai.ValueMember = "MaLoai";
        }
    }
}
