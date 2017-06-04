namespace GV_HS_THPT
{
    partial class FormTimKiemGiaoVien
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
            this.txtTenGiaoVien = new System.Windows.Forms.TextBox();
            this.btnTimKiemTheoTen = new System.Windows.Forms.Button();
            this.cmbMaGiaoVien = new System.Windows.Forms.ComboBox();
            this.dgvTimKiemGiaoVien = new System.Windows.Forms.DataGridView();
            this.MaHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LopHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimKiemTheoMa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenGiaoVien
            // 
            this.txtTenGiaoVien.Location = new System.Drawing.Point(207, 97);
            this.txtTenGiaoVien.Name = "txtTenGiaoVien";
            this.txtTenGiaoVien.Size = new System.Drawing.Size(173, 22);
            this.txtTenGiaoVien.TabIndex = 16;
            // 
            // btnTimKiemTheoTen
            // 
            this.btnTimKiemTheoTen.Location = new System.Drawing.Point(392, 94);
            this.btnTimKiemTheoTen.Name = "btnTimKiemTheoTen";
            this.btnTimKiemTheoTen.Size = new System.Drawing.Size(215, 23);
            this.btnTimKiemTheoTen.TabIndex = 15;
            this.btnTimKiemTheoTen.Text = "Tìm Kiếm Theo Tên";
            this.btnTimKiemTheoTen.UseVisualStyleBackColor = true;
            this.btnTimKiemTheoTen.Click += new System.EventHandler(this.btnTimKiemTheoTen_Click);
            // 
            // cmbMaGiaoVien
            // 
            this.cmbMaGiaoVien.FormattingEnabled = true;
            this.cmbMaGiaoVien.Location = new System.Drawing.Point(207, 66);
            this.cmbMaGiaoVien.Name = "cmbMaGiaoVien";
            this.cmbMaGiaoVien.Size = new System.Drawing.Size(173, 24);
            this.cmbMaGiaoVien.TabIndex = 14;
            // 
            // dgvTimKiemGiaoVien
            // 
            this.dgvTimKiemGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiemGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHocSinh,
            this.TenHocSinh,
            this.GioiTinh,
            this.NgaySinh,
            this.LopHoc});
            this.dgvTimKiemGiaoVien.Location = new System.Drawing.Point(12, 135);
            this.dgvTimKiemGiaoVien.Name = "dgvTimKiemGiaoVien";
            this.dgvTimKiemGiaoVien.Size = new System.Drawing.Size(697, 108);
            this.dgvTimKiemGiaoVien.TabIndex = 13;
            // 
            // MaHocSinh
            // 
            this.MaHocSinh.DataPropertyName = "MAGIAOVIEN";
            this.MaHocSinh.HeaderText = "Mã Giáo Viên";
            this.MaHocSinh.Name = "MaHocSinh";
            // 
            // TenHocSinh
            // 
            this.TenHocSinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenHocSinh.DataPropertyName = "TENGIAOVIEN";
            this.TenHocSinh.HeaderText = "Tên Giáo Viên";
            this.TenHocSinh.Name = "TenHocSinh";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GIOITINH";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NGAYSINH";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // LopHoc
            // 
            this.LopHoc.DataPropertyName = "TENMONHOC";
            this.LopHoc.HeaderText = "Môn Học";
            this.LopHoc.Name = "LopHoc";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(634, 65);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimKiemTheoMa
            // 
            this.btnTimKiemTheoMa.Location = new System.Drawing.Point(392, 66);
            this.btnTimKiemTheoMa.Name = "btnTimKiemTheoMa";
            this.btnTimKiemTheoMa.Size = new System.Drawing.Size(215, 23);
            this.btnTimKiemTheoMa.TabIndex = 12;
            this.btnTimKiemTheoMa.Text = "Tìm Kiếm Theo Mã";
            this.btnTimKiemTheoMa.UseVisualStyleBackColor = true;
            this.btnTimKiemTheoMa.Click += new System.EventHandler(this.btnTimKiemTheoMa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nhập Họ Tên Giáo Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nhập Mã Giáo Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tìm kiếm giáo viên";
            // 
            // FormTimKiemGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 257);
            this.Controls.Add(this.txtTenGiaoVien);
            this.Controls.Add(this.btnTimKiemTheoTen);
            this.Controls.Add(this.cmbMaGiaoVien);
            this.Controls.Add(this.dgvTimKiemGiaoVien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiemTheoMa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTimKiemGiaoVien";
            this.Text = "TimKiemGiaoVien";
            this.Load += new System.EventHandler(this.FormTimKiemGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemGiaoVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenGiaoVien;
        private System.Windows.Forms.Button btnTimKiemTheoTen;
        private System.Windows.Forms.ComboBox cmbMaGiaoVien;
        private System.Windows.Forms.DataGridView dgvTimKiemGiaoVien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiemTheoMa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn LopHoc;
    }
}