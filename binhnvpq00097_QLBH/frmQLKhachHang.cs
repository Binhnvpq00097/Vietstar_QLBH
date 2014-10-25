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
    public partial class frmQLKhachHang : Form
    {
        public frmQLKhachHang()
        {
            InitializeComponent();
        }

        public void LayDSKhachHang()
        {
            // Tạo kết nối đến CSDL
            SqlConnection con = Database.GetConnection();

            // Tạo lệnh để thực hiện lấy dữ liệu
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT [MaKH], [TenKH], [DiaChi], [DienThoai], [Email] FROM KhachHang";

            // Tạo DataSet để chứa dữ liệu lấy được
            DataSet ds = new DataSet();

            // Tạo đối tượng thực hiện lệnh SqlCommand để trả dữ liệu về DataSet.
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds, "KhachHang");

            // Đưa dữ liệu vào ListView
            lvDanhSachKH.Items.Clear();
            for (int i = 0; i < ds.Tables["KhachHang"].Rows.Count; i++)
            {
                ListViewItem lvItem = lvDanhSachKH.Items.Add(ds.Tables["KhachHang"].Rows[i]["MaKH"].ToString());
                lvItem.SubItems.Add(ds.Tables["KhachHang"].Rows[i]["TenKH"].ToString());
                lvItem.SubItems.Add(ds.Tables["KhachHang"].Rows[i]["DiaChi"].ToString());
                lvItem.SubItems.Add(ds.Tables["KhachHang"].Rows[i]["DienThoai"].ToString());
                lvItem.SubItems.Add(ds.Tables["KhachHang"].Rows[i]["Email"].ToString());
            }
        }

        private void frmQLKhachHang_Load(object sender, EventArgs e)
        {
            LayDSKhachHang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemKhachHang frm = new frmThemKhachHang();
            frm.Tag = this;
            frm.ShowDialog();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Hỏi người dùng xem có chắc muốn xóa ko?
            DialogResult result = MessageBox.Show("Bạn muốn xóa khách hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            // Kiểm tra xem người dùng đã chọn khách hàng để xóa chưa?
            if (lvDanhSachKH.SelectedItems.Count > 0)
            {
                // Tạo kết nối đến CSDL
                SqlConnection con = Database.GetConnection();

                // Tạo lệnh để thực hiện lấy dữ liệu
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM KhachHang WHERE MaKH = @MaKH";
                cmd.Parameters.Add("@MaKH", SqlDbType.VarChar, 10).Value = lvDanhSachKH.SelectedItems[0].Text;

                // Thực hiện lệnh.
                cmd.ExecuteNonQuery();

                LayDSKhachHang();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn khách hàng để xóa chưa?
            if (lvDanhSachKH.SelectedItems.Count > 0)
            {
                string maKH = lvDanhSachKH.SelectedItems[0].Text;
                string tenKH = lvDanhSachKH.SelectedItems[0].SubItems[1].Text;
                string diaChi = lvDanhSachKH.SelectedItems[0].SubItems[2].Text;
                string dienThoai = lvDanhSachKH.SelectedItems[0].SubItems[3].Text;
                string Email = lvDanhSachKH.SelectedItems[0].SubItems[4].Text;

                KhachHang kh = new KhachHang();
                kh.MaKH = maKH;
                kh.TenKH = tenKH;
                kh.DiaChi = diaChi;
                kh.DienThoai = dienThoai;
                kh.Email = Email;
                kh.ParentForm = this;

                frmSuaThongTinKhachHang frm = new frmSuaThongTinKhachHang();
                frm.Tag = kh;
                frm.ShowDialog();
            }
        }

    }
}