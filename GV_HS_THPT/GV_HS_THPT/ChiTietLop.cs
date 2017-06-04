using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GV_HS_THPT
{
    public partial class FormChiTietLop : Form
    {
        string strConn = "Data Source=SRI8203Z3VDW2GR; Initial Catalog = GV_HS_THPT; Integrated Security = True";
        SqlConnection conn = null;
        void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MACHITIETLOP, TENLOPHOC, TENMONHOC, TENGIAOVIEN FROM CHITIETLOPHOC JOIN LOPHOC ON LOPHOC.MALOPHOC=CHITIETLOPHOC.MALOPHOC JOIN MONHOC ON MONHOC.MAMONHOC=CHITIETLOPHOC.MAMONHOC JOIN GIAOVIEN ON GIAOVIEN.MAGIAOVIEN=CHITIETLOPHOC.MAGIAOVIEN", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvChiTietLop.DataSource = dt;
            txtMaChiTietLop.Enabled = false;
            btnLuu.Enabled = false;
        }

        public FormChiTietLop()
        {
            InitializeComponent();
        }

        private void ShowMonHoc()
        {
            string sql = "SELECT * FROM MONHOC";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbMaMonHoc.ValueMember = "MAMONHOC";
            cmbMaMonHoc.DisplayMember = "TENMONHOC";
            cmbMaMonHoc.DataSource = dt;
        }

        private void ShowLopHoc()
        {
            string sql = "SELECT * FROM LOPHOC";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbMaLopHoc.ValueMember = "MALOPHOC";
            cmbMaLopHoc.DisplayMember = "TENLOPHOC";
            cmbMaLopHoc.DataSource = dt;
        }

        private void FormChiTietLop_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            LoadData();
            ShowMonHoc();
            ShowLopHoc();
        }
        
        private void dgvChiTietLop_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvChiTietLop.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void dgvChiTietLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txtMaChiTietLop.Text = Convert.ToString(dgvChiTietLop.CurrentRow.Cells[1].Value);
                    cmbMaLopHoc.Text = Convert.ToString(dgvChiTietLop.CurrentRow.Cells[2].Value);
                    cmbMaMonHoc.Text = Convert.ToString(dgvChiTietLop.CurrentRow.Cells[3].Value);
                    cmbMaGiaoVien.Text = Convert.ToString(dgvChiTietLop.CurrentRow.Cells[4].Value);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi không tải dữ liệu lên được!");
            }
        }

        int a;
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaChiTietLop.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            a = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaChiTietLop.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            a = 0;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("XoaChiTietLopHoc", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaCTLP", txtMaChiTietLop.Text);
                cmd.Parameters.Add(p);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    LoadData();
                    MessageBox.Show("Xóa thành công !");
                }
                else
                {
                    MessageBox.Show("Không thể xóa !");
                }
            }
        }

        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbMaMonHoc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbMaGiaoVien.ResetText();
            string sql = "SELECT * FROM GIAOVIEN WHERE MAMONHOC = " + cmbMaMonHoc.SelectedValue.ToString() + "";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbMaGiaoVien.ValueMember = "MAGIAOVIEN";
            cmbMaGiaoVien.DisplayMember = "TENGIAOVIEN";
            cmbMaGiaoVien.DataSource = dt;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                if (cmbMaLopHoc.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập đủ thông tin !", "Thông Bóa");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("ThemChiTietLopHoc", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@MaLopHoc", cmbMaLopHoc.SelectedValue);
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@MaMonHoc", cmbMaMonHoc.SelectedValue);
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@MaGiaoVien", cmbMaGiaoVien.SelectedValue);
                    cmd.Parameters.Add(p);
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Thêm mới thành công !");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm mới !");
                    }
                }
            }
            else
            {
                SqlCommand cmd = new SqlCommand("SuaChiTietLopHoc", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaCTLP", txtMaChiTietLop.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaLopHoc", cmbMaLopHoc.SelectedValue);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaMonHoc", cmbMaMonHoc.SelectedValue);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaGiaoVien", cmbMaGiaoVien.SelectedValue);
                cmd.Parameters.Add(p);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    LoadData();
                    MessageBox.Show("Sửa thành công !");
                }
                else
                {
                    MessageBox.Show("Không thể sửa !");
                }
            }
        }
    }
}
