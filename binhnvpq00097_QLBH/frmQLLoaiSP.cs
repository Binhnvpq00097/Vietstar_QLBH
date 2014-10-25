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
    public partial class frmQLLoaiSP : Form
    {
        public frmQLLoaiSP()
        {
            InitializeComponent();
        }

        public void LayDSLoaiSP()
        {
            // Tạo kết nối đến CSDL
            SqlConnection con = Database.GetConnection();

            // Tạo lệnh để thực hiện lấy dữ liệu
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT [MaLoai],[TenLoai] FROM LoaiSP";

            // Tạo DataSet để chứa dữ liệu lấy được
            DataSet ds = new DataSet();

            // Tạo đối tượng thực hiện lệnh SqlCommand để trả dữ liệu về DataSet.
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds, "LoaiSP");

            // Đưa dữ liệu vào ListView
            lvLoaiSP.Items.Clear();
            for (int i = 0; i < ds.Tables["LoaiSP"].Rows.Count; i++)
            {
                ListViewItem lvItem = lvLoaiSP.Items.Add(ds.Tables["LoaiSP"].Rows[i]["MaLoai"].ToString());
                lvItem.SubItems.Add(ds.Tables["LoaiSP"].Rows[i]["TenLoai"].ToString());
            }
        }

        private void frmQLLoaiSP_Load(object sender, EventArgs e)
        {
            LayDSLoaiSP();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn khách hàng để xóa chưa?
            if (lvLoaiSP.SelectedItems.Count > 0)
            {
                string MaLoai = lvLoaiSP.SelectedItems[0].Text;
                string TenLoai = lvLoaiSP.SelectedItems[0].SubItems[1].Text;

                LoaiSP lsp = new LoaiSP();
                lsp.MaLoai = MaLoai;
                lsp.TenLoai = TenLoai;
                lsp.ParentForm = this;

                frmSuaThongTinLoaiSP frm = new frmSuaThongTinLoaiSP();
                frm.Tag = lsp;
                frm.ShowDialog();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemLoaiSP frm = new frmThemLoaiSP();
            frm.Tag = this;
            frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Hỏi người dùng xem có chắc muốn xóa ko?
            DialogResult result = MessageBox.Show("Bạn muốn xóa loại sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            // Kiểm tra xem người dùng đã chọn loại sản phẩm để xóa chưa?
            if (lvLoaiSP.SelectedItems.Count > 0)
            {
                // Tạo kết nối đến CSDL
                SqlConnection con = Database.GetConnection();

                // Tạo lệnh để thực hiện lấy dữ liệu
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM LoaiSP WHERE MaLoai = @MaLoai";
                cmd.Parameters.Add("@MaLoai", SqlDbType.VarChar, 10).Value = lvLoaiSP.SelectedItems[0].Text;

                // Thực hiện lệnh.
                cmd.ExecuteNonQuery();

                LayDSLoaiSP();
            }
        }
    }

}
 