namespace binhnvpq00097_QLBH
{
    partial class frmQuanlySP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDanhMucSP = new System.Windows.Forms.Label();
            this.lvDanhMucSP = new System.Windows.Forms.ListView();
            this.colMaSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDonvitinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDongia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.colMaLoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDanhMucSP
            // 
            this.lblDanhMucSP.AutoSize = true;
            this.lblDanhMucSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhMucSP.Location = new System.Drawing.Point(225, 18);
            this.lblDanhMucSP.Name = "lblDanhMucSP";
            this.lblDanhMucSP.Size = new System.Drawing.Size(269, 31);
            this.lblDanhMucSP.TabIndex = 0;
            this.lblDanhMucSP.Text = "Danh mục Sản Phẩm";
            // 
            // lvDanhMucSP
            // 
            this.lvDanhMucSP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaSP,
            this.colTenSP,
            this.colSoluong,
            this.colDonvitinh,
            this.colDongia,
            this.colMaLoai});
            this.lvDanhMucSP.FullRowSelect = true;
            this.lvDanhMucSP.GridLines = true;
            this.lvDanhMucSP.Location = new System.Drawing.Point(29, 65);
            this.lvDanhMucSP.MultiSelect = false;
            this.lvDanhMucSP.Name = "lvDanhMucSP";
            this.lvDanhMucSP.Size = new System.Drawing.Size(694, 270);
            this.lvDanhMucSP.TabIndex = 1;
            this.lvDanhMucSP.UseCompatibleStateImageBehavior = false;
            this.lvDanhMucSP.View = System.Windows.Forms.View.Details;
            // 
            // colMaSP
            // 
            this.colMaSP.Text = "Mã Sản Phẩm";
            this.colMaSP.Width = 100;
            // 
            // colTenSP
            // 
            this.colTenSP.Text = "Tên Sản phẩm";
            this.colTenSP.Width = 200;
            // 
            // colSoluong
            // 
            this.colSoluong.Text = "Số lượng";
            this.colSoluong.Width = 80;
            // 
            // colDonvitinh
            // 
            this.colDonvitinh.Text = "Đơn vị tính";
            this.colDonvitinh.Width = 100;
            // 
            // colDongia
            // 
            this.colDongia.Text = "Đơn giá";
            this.colDongia.Width = 150;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(273, 365);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(150, 365);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(27, 365);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // colMaLoai
            // 
            this.colMaLoai.Text = "Mã loại";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(648, 365);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmQuanlySP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 409);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lvDanhMucSP);
            this.Controls.Add(this.lblDanhMucSP);
            this.Name = "frmQuanlySP";
            this.Text = "Quản Lý Sản Phẩm";
            this.Load += new System.EventHandler(this.frmQuanlySP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDanhMucSP;
        private System.Windows.Forms.ListView lvDanhMucSP;
        private System.Windows.Forms.ColumnHeader colMaSP;
        private System.Windows.Forms.ColumnHeader colTenSP;
        private System.Windows.Forms.ColumnHeader colSoluong;
        private System.Windows.Forms.ColumnHeader colDonvitinh;
        private System.Windows.Forms.ColumnHeader colDongia;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ColumnHeader colMaLoai;
        private System.Windows.Forms.Button btnDong;
    }
}