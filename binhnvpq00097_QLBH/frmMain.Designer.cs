namespace binhnvpq00097_QLBH
{
    partial class frmMain
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
            this.btnLoaiSP = new System.Windows.Forms.Button();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnDonHang = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.lblTenUD = new System.Windows.Forms.Label();
            this.lblTenNguoiviet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoaiSP
            // 
            this.btnLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiSP.Location = new System.Drawing.Point(152, 108);
            this.btnLoaiSP.Name = "btnLoaiSP";
            this.btnLoaiSP.Size = new System.Drawing.Size(218, 34);
            this.btnLoaiSP.TabIndex = 0;
            this.btnLoaiSP.Text = "Danh mục loại sản phẩm";
            this.btnLoaiSP.UseVisualStyleBackColor = true;
            this.btnLoaiSP.Click += new System.EventHandler(this.btnLoaiSP_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham.Location = new System.Drawing.Point(421, 108);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(187, 34);
            this.btnSanPham.TabIndex = 1;
            this.btnSanPham.Text = "Danh mục sản phẩm";
            this.btnSanPham.UseVisualStyleBackColor = true;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnDonHang
            // 
            this.btnDonHang.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonHang.Location = new System.Drawing.Point(948, 108);
            this.btnDonHang.Name = "btnDonHang";
            this.btnDonHang.Size = new System.Drawing.Size(187, 34);
            this.btnDonHang.TabIndex = 2;
            this.btnDonHang.Text = "Quản lý đơn hàng";
            this.btnDonHang.UseVisualStyleBackColor = true;
            this.btnDonHang.Click += new System.EventHandler(this.btnDonHang_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.Location = new System.Drawing.Point(669, 108);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(218, 34);
            this.btnKhachHang.TabIndex = 3;
            this.btnKhachHang.Text = "Danh sách khách hàng";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // lblTenUD
            // 
            this.lblTenUD.AutoSize = true;
            this.lblTenUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenUD.Location = new System.Drawing.Point(424, 27);
            this.lblTenUD.Name = "lblTenUD";
            this.lblTenUD.Size = new System.Drawing.Size(463, 31);
            this.lblTenUD.TabIndex = 4;
            this.lblTenUD.Text = "ỨNG DỤNG QUẢN LÝ BÁN HÀNG";
            // 
            // lblTenNguoiviet
            // 
            this.lblTenNguoiviet.AutoSize = true;
            this.lblTenNguoiviet.Location = new System.Drawing.Point(572, 62);
            this.lblTenNguoiviet.Name = "lblTenNguoiviet";
            this.lblTenNguoiviet.Size = new System.Drawing.Size(159, 13);
            this.lblTenNguoiviet.TabIndex = 5;
            this.lblTenNguoiviet.Text = "===Binhnvp00097 - PT09301==";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::binhnvpq00097_QLBH.Properties.Resources.a1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1249, 347);
            this.Controls.Add(this.lblTenNguoiviet);
            this.Controls.Add(this.lblTenUD);
            this.Controls.Add(this.btnKhachHang);
            this.Controls.Add(this.btnDonHang);
            this.Controls.Add(this.btnSanPham);
            this.Controls.Add(this.btnLoaiSP);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ỨNG DỤNG QUẢN LÝ BÁN HÀNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoaiSP;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnDonHang;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Label lblTenUD;
        private System.Windows.Forms.Label lblTenNguoiviet;
    }
}

