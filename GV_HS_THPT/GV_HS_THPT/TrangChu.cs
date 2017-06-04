using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GV_HS_THPT
{
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
        }

        private void lớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLopHoc lophoc = new GV_HS_THPT.FormLopHoc();
            lophoc.Show();
        }

        private void họcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHocSinh hocsinh = new GV_HS_THPT.FormHocSinh();
            hocsinh.Show();
        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGiaoVien giaovien = new GV_HS_THPT.FormGiaoVien();
            giaovien.Show();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMonHoc monhoc = new GV_HS_THPT.FormMonHoc();
            monhoc.Show();
        }

        private void chiTiếtLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChiTietLop chitietlophoc = new GV_HS_THPT.FormChiTietLop();
            chitietlophoc.Show();
        }

        private void họcSinhTheoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongKeHocSinh tkhs = new FormThongKeHocSinh();
            tkhs.Show();
        }

        private void giáoViênTheoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongKeGiaoVien tkgvtl = new FormThongKeGiaoVien();
            tkgvtl.Show();
        }

        private void giáoViênTheoBộMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongKeGiaoVienTheoMonHoc tkgvtmh = new GV_HS_THPT.FormThongKeGiaoVienTheoMonHoc();
            tkgvtmh.Show();
        }

        private void thoátChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void họcSinhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormTimKiemHocSinh tkhs = new GV_HS_THPT.FormTimKiemHocSinh();
            tkhs.Show();
        }

        private void giáoViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormTimKiemGiaoVien tkgv = new FormTimKiemGiaoVien();
            tkgv.Show();
        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {

        }
    }
}
