namespace binhnvpq00097_QLBH
{
    partial class frmQLLoaiSP
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
            this.lblQuanLyLoaiSP = new System.Windows.Forms.Label();
            this.lvLoaiSP = new System.Windows.Forms.ListView();
            this.colMaloai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenloai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuanLyLoaiSP
            // 
            this.lblQuanLyLoaiSP.AutoSize = true;
            this.lblQuanLyLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyLoaiSP.Location = new System.Drawing.Point(83, 23);
            this.lblQuanLyLoaiSP.Name = "lblQuanLyLoaiSP";
            this.lblQuanLyLoaiSP.Size = new System.Drawing.Size(306, 31);
            this.lblQuanLyLoaiSP.TabIndex = 0;
            this.lblQuanLyLoaiSP.Text = "Quản Lý Loại Sản Phẩm";
            this.lblQuanLyLoaiSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvLoaiSP
            // 
            this.lvLoaiSP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaloai,
            this.colTenloai});
            this.lvLoaiSP.FullRowSelect = true;
            this.lvLoaiSP.GridLines = true;
            this.lvLoaiSP.Location = new System.Drawing.Point(40, 72);
            this.lvLoaiSP.MultiSelect = false;
            this.lvLoaiSP.Name = "lvLoaiSP";
            this.lvLoaiSP.Size = new System.Drawing.Size(403, 222);
            this.lvLoaiSP.TabIndex = 1;
            this.lvLoaiSP.UseCompatibleStateImageBehavior = false;
            this.lvLoaiSP.View = System.Windows.Forms.View.Details;
            // 
            // colMaloai
            // 
            this.colMaloai.Text = "Mã loại";
            this.colMaloai.Width = 100;
            // 
            // colTenloai
            // 
            this.colTenloai.Text = "Tên Loại ";
            this.colTenloai.Width = 300;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(40, 321);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(121, 321);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(202, 321);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(368, 321);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmQLLoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 362);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lvLoaiSP);
            this.Controls.Add(this.lblQuanLyLoaiSP);
            this.Name = "frmQLLoaiSP";
            this.Text = "Quản Lý Loại Sản Phẩm";
            this.Load += new System.EventHandler(this.frmQLLoaiSP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuanLyLoaiSP;
        private System.Windows.Forms.ListView lvLoaiSP;
        private System.Windows.Forms.ColumnHeader colMaloai;
        private System.Windows.Forms.ColumnHeader colTenloai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
    }
}