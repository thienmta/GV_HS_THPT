namespace GV_HS_THPT
{
    partial class FormTimKiemHocSinh
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvTimKiemHocSinh = new System.Windows.Forms.DataGridView();
            this.MaHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LopHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbMaHocSinh = new System.Windows.Forms.ComboBox();
            this.btnTimKiemTheoTen = new System.Windows.Forms.Button();
            this.txtTenHocSinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm Học Sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập Mã Học Sinh\r\n";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(408, 66);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(215, 23);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm Kiếm Theo Mã";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(650, 65);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvTimKiemHocSinh
            // 
            this.dgvTimKiemHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiemHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHocSinh,
            this.TenHocSinh,
            this.GioiTinh,
            this.NgaySinh,
            this.QueQuan,
            this.LopHoc});
            this.dgvTimKiemHocSinh.Location = new System.Drawing.Point(28, 137);
            this.dgvTimKiemHocSinh.Name = "dgvTimKiemHocSinh";
            this.dgvTimKiemHocSinh.Size = new System.Drawing.Size(768, 108);
            this.dgvTimKiemHocSinh.TabIndex = 4;
            this.dgvTimKiemHocSinh.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvTimKiemHocSinh_RowPrePaint);
            // 
            // MaHocSinh
            // 
            this.MaHocSinh.DataPropertyName = "MAHOCSINH";
            this.MaHocSinh.HeaderText = "Mã Học Sinh";
            this.MaHocSinh.Name = "MaHocSinh";
            this.MaHocSinh.Width = 50;
            // 
            // TenHocSinh
            // 
            this.TenHocSinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenHocSinh.DataPropertyName = "TENHOCSINH";
            this.TenHocSinh.HeaderText = "Tên Học Sinh";
            this.TenHocSinh.Name = "TenHocSinh";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GIOITINH";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 50;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NGAYSINH";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // QueQuan
            // 
            this.QueQuan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QueQuan.DataPropertyName = "QUEQUAN";
            this.QueQuan.HeaderText = "Quê Quán";
            this.QueQuan.Name = "QueQuan";
            // 
            // LopHoc
            // 
            this.LopHoc.DataPropertyName = "TENLOPHOC";
            this.LopHoc.HeaderText = "Lớp Học";
            this.LopHoc.Name = "LopHoc";
            // 
            // cmbMaHocSinh
            // 
            this.cmbMaHocSinh.FormattingEnabled = true;
            this.cmbMaHocSinh.Location = new System.Drawing.Point(220, 66);
            this.cmbMaHocSinh.Name = "cmbMaHocSinh";
            this.cmbMaHocSinh.Size = new System.Drawing.Size(173, 24);
            this.cmbMaHocSinh.TabIndex = 5;
            // 
            // btnTimKiemTheoTen
            // 
            this.btnTimKiemTheoTen.Location = new System.Drawing.Point(408, 94);
            this.btnTimKiemTheoTen.Name = "btnTimKiemTheoTen";
            this.btnTimKiemTheoTen.Size = new System.Drawing.Size(215, 23);
            this.btnTimKiemTheoTen.TabIndex = 6;
            this.btnTimKiemTheoTen.Text = "Tìm Kiếm Theo Tên";
            this.btnTimKiemTheoTen.UseVisualStyleBackColor = true;
            this.btnTimKiemTheoTen.Click += new System.EventHandler(this.btnTimKiemTheoTen_Click);
            // 
            // txtTenHocSinh
            // 
            this.txtTenHocSinh.Location = new System.Drawing.Point(220, 97);
            this.txtTenHocSinh.Name = "txtTenHocSinh";
            this.txtTenHocSinh.Size = new System.Drawing.Size(173, 22);
            this.txtTenHocSinh.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhập Họ Tên Học Sinh\r\n";
            // 
            // FormTimKiemHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 255);
            this.Controls.Add(this.txtTenHocSinh);
            this.Controls.Add(this.btnTimKiemTheoTen);
            this.Controls.Add(this.cmbMaHocSinh);
            this.Controls.Add(this.dgvTimKiemHocSinh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormTimKiemHocSinh";
            this.Text = "Tìm Kiếm Học Sinh";
            this.Load += new System.EventHandler(this.FormTimKiemHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemHocSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvTimKiemHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn LopHoc;
        private System.Windows.Forms.ComboBox cmbMaHocSinh;
        private System.Windows.Forms.Button btnTimKiemTheoTen;
        private System.Windows.Forms.TextBox txtTenHocSinh;
        private System.Windows.Forms.Label label3;
    }
}