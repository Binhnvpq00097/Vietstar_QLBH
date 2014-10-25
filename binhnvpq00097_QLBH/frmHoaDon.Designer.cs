namespace binhnvpq00097_QLBH
{
    partial class frmHoaDon
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
            this.lvHoadon = new System.Windows.Forms.ListView();
            this.colSohoadon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTongtien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayhoadon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDong = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvHoadon
            // 
            this.lvHoadon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSohoadon,
            this.colMaKH,
            this.colTongtien,
            this.colNgayhoadon});
            this.lvHoadon.GridLines = true;
            this.lvHoadon.Location = new System.Drawing.Point(23, 38);
            this.lvHoadon.Name = "lvHoadon";
            this.lvHoadon.Size = new System.Drawing.Size(656, 331);
            this.lvHoadon.TabIndex = 0;
            this.lvHoadon.UseCompatibleStateImageBehavior = false;
            this.lvHoadon.View = System.Windows.Forms.View.Details;
            // 
            // colSohoadon
            // 
            this.colSohoadon.Text = "Số hóa đơn";
            this.colSohoadon.Width = 150;
            // 
            // colMaKH
            // 
            this.colMaKH.Text = "Mã Khách hàng";
            this.colMaKH.Width = 150;
            // 
            // colTongtien
            // 
            this.colTongtien.Text = "Tổng tiền";
            this.colTongtien.Width = 200;
            // 
            // colNgayhoadon
            // 
            this.colNgayhoadon.Text = "Ngày viết hóa đơn";
            this.colNgayhoadon.Width = 150;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(604, 399);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(273, 399);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(150, 399);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(23, 399);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 451);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lvHoadon);
            this.Name = "frmHoaDon";
            this.Text = "Tổng hợp hóa đơn";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvHoadon;
        private System.Windows.Forms.ColumnHeader colSohoadon;
        private System.Windows.Forms.ColumnHeader colMaKH;
        private System.Windows.Forms.ColumnHeader colTongtien;
        private System.Windows.Forms.ColumnHeader colNgayhoadon;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}