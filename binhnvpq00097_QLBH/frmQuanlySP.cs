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
using binhnvpq00097_QLBH.BOSP;

namespace binhnvpq00097_QLBH
{
    public partial class frmQuanlySP : Form
    {
        public frmQuanlySP()
        {
            InitializeComponent();
        }

        public void LayDSSP()
        {
            // Tạo kết nối đến CSDL
            SqlConnection con = Database.GetConnection();

            // Tạo lệnh để thực hiện lấy dữ liệu
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT [MaSP], [TenSP], [SoLuong], [DonViTinh], [DonGia],[MaLoai] FROM SanPham";

            // Tạo DataSet để chứa dữ liệu lấy được
            DataSet sp = new DataSet();

            // Tạo đối tượng thực hiện lệnh SqlCommand để trả dữ liệu về DataSet.
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(sp, "SanPham");

            // Đưa dữ liệu vào ListView
            lvDanhMucSP.Items.Clear();
            for (int i = 0; i < sp.Tables["SanPham"].Rows.Count; i++)
            {
                ListViewItem lvItem = lvDanhMucSP.Items.Add(sp.Tables["SanPham"].Rows[i]["MaSP"].ToString());
                lvItem.SubItems.Add(sp.Tables["SanPham"].Rows[i]["TenSP"].ToString());
                lvItem.SubItems.Add(sp.Tables["SanPham"].Rows[i]["SoLuong"].ToString());
                lvItem.SubItems.Add(sp.Tables["SanPham"].Rows[i]["DonViTinh"].ToString());
                lvItem.SubItems.Add(sp.Tables["SanPham"].Rows[i]["DonGia"].ToString());
                lvItem.SubItems.Add(sp.Tables["SanPham"].Rows[i]["MaLoai"].ToString());
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemSP frm = new frmThemSP();
            frm.Tag = this;
            frm.ShowDialog();
        }

        private void frmQuanlySP_Load(object sender, EventArgs e)
        {
            LayDSSP();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Hỏi người dùng xem có chắc muốn xóa ko?
            DialogResult result = MessageBox.Show("Bạn muốn xóa Sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            // Kiểm tra xem người dùng đã chọn khách hàng để xóa chưa?
            if (lvDanhMucSP.SelectedItems.Count > 0)
            {
                // Tạo kết nối đến CSDL
                SqlConnection con = Database.GetConnection();

                // Tạo lệnh để thực hiện lấy dữ liệu
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM SanPham WHERE MaSP = @MaSP";
                cmd.Parameters.Add("@MaSP", SqlDbType.NVarChar, 10).Value = lvDanhMucSP.SelectedItems[0].Text;

                // Thực hiện lệnh.
                cmd.ExecuteNonQuery();

                LayDSSP();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn khách hàng để xóa chưa?
            if (lvDanhMucSP.SelectedItems.Count > 0)
            {
                string MaSP = lvDanhMucSP.SelectedItems[0].Text;
                string TenSP = lvDanhMucSP.SelectedItems[0].SubItems[1].Text;
                string SoLuong = lvDanhMucSP.SelectedItems[0].SubItems[2].Text;
                string DonViTinh = lvDanhMucSP.SelectedItems[0].SubItems[3].Text;
                string DonGia = lvDanhMucSP.SelectedItems[0].SubItems[4].Text;
                string MaLoai = lvDanhMucSP.SelectedItems[0].SubItems[5].Text;

                SanPham sp = new SanPham();
                sp.MaSP = MaSP;
                sp.TenSP = TenSP;
                sp.SoLuong = SoLuong;
                sp.DonViTinh = DonViTinh;
                sp.DonGia = DonGia;
                sp.MaLoai = MaLoai;
                sp.ParentForm = this;

                frmSuaThongTinSP frm = new frmSuaThongTinSP();
                frm.Tag = sp;
                frm.ShowDialog();
            }
        }
    }
}
