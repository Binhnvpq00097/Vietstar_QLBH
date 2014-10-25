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
using binhnvpq00097_QLBH.BOSP;

namespace binhnvpq00097_QLBH
{
    public partial class frmSuaThongTinSP : Form
    {
        public frmSuaThongTinSP()
        {
            InitializeComponent();
        }

        private void frmSuaThongTinSP_Load(object sender, EventArgs e)
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
            
            
            /////
            SanPham sp = (SanPham)this.Tag;

            txtMaSP.Text = sp.MaSP;
            txtTenSP.Text = sp.TenSP;
            txtSoLuong.Text = sp.SoLuong;
            txtDonViTinh.Text = sp.DonViTinh;
            txtDonGia.Text = sp.DonGia;
            cobMaLoai.Text = sp.MaLoai;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Tạo kết nối đến CSDL
            SqlConnection con = Database.GetConnection();

            // Tạo lệnh để thực hiện lấy dữ liệu
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update SanPham set MaSP = @MaSPMoi, TenSP = @TenSP, SoLuong = @SoLuong, DonViTinh = @DonViTinh, DonGia = @DonGia, MaLoai = @MaLoai Where MaSP = @MaSPCu";
            cmd.Parameters.Add("@MaSPMoi", SqlDbType.NVarChar, 10).Value = txtMaSP.Text;
            cmd.Parameters.Add("@TenSP", SqlDbType.NVarChar, 50).Value = txtTenSP.Text;
            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = txtSoLuong.Text;
            cmd.Parameters.Add("@DonViTinh", SqlDbType.NVarChar, 10).Value = txtDonViTinh.Text;
            cmd.Parameters.Add("@DonGia", SqlDbType.Decimal).Value = txtDonGia.Text;
            cmd.Parameters.Add("@MaLoai", SqlDbType.NVarChar, 10).Value = cobMaLoai.SelectedValue.ToString();

            SanPham sp = (SanPham)this.Tag;

            cmd.Parameters.Add("@MaSPCu", SqlDbType.NVarChar, 10).Value = sp.MaSP;

            // Thực hiện lệnh.
            cmd.ExecuteNonQuery();


            MessageBox.Show("Đã Sửa mới khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmQuanlySP frm = (frmQuanlySP)sp.ParentForm;
            frm.LayDSSP();
            this.Close();
        }
    }
}
