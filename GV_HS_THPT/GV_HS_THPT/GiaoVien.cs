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
    public partial class FormGiaoVien : Form
    {
        string strConn = "Data Source=SRI8203Z3VDW2GR; Initial Catalog = GV_HS_THPT; Integrated Security = True";
        SqlConnection conn = null;
        void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MAGIAOVIEN,TENGIAOVIEN,GIOITINH,NGAYSINH,TENMONHOC FROM GIAOVIEN JOIN MONHOC ON MONHOC.MAMONHOC=GIAOVIEN.MAMONHOC", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvGiaoVien.DataSource = dt;
            txtMaGiaoVien.Enabled = false;
            btnLuu.Enabled = false;
        }

        public FormGiaoVien()
        {
            InitializeComponent();
        }

        int a;
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaGiaoVien.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            a = 1;
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
        private void ShowGioiTinh()
        {
            string sql = "SELECT * FROM GIOITINH";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbGioiTinh.ValueMember = "MAGIOITINH";
            cmbGioiTinh.DisplayMember = "TENGIOITINH";
            cmbGioiTinh.DataSource = dt;
        }

        private void FormGiaoVien_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            LoadData();
            ShowMonHoc();
            ShowGioiTinh();
        }

        private void dgvGiaoVien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvGiaoVien.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txtMaGiaoVien.Text = Convert.ToString(dgvGiaoVien.CurrentRow.Cells[1].Value);
                    txtTenGiaoVien.Text = Convert.ToString(dgvGiaoVien.CurrentRow.Cells[2].Value);
                    cmbGioiTinh.Text = Convert.ToString(dgvGiaoVien.CurrentRow.Cells[3].Value);
                    dtNgaySinh.Text = Convert.ToString(dgvGiaoVien.CurrentRow.Cells[4].Value);
                    cmbMaMonHoc.Text = Convert.ToString(dgvGiaoVien.CurrentRow.Cells[5].Value);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi không tải dữ liệu lên được!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaGiaoVien.Enabled = false;
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
                SqlCommand cmd = new SqlCommand("XoaGiaoVien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaGiaoVien", txtMaGiaoVien.Text);
                cmd.Parameters.Add(p);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    LoadData();
                    txtMaGiaoVien.ResetText();
                    txtTenGiaoVien.ResetText();
                    cmbGioiTinh.ResetText();
                    cmbMaMonHoc.ResetText();
                    dtNgaySinh.ResetText();
                    MessageBox.Show("Xóa thành công !");
                }
                else
                {
                    MessageBox.Show("Không thể xóa !");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                if (txtTenGiaoVien.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập đủ thông tin !", "Thông Bóa");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("ThemGiaoVien", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@TenGiaoVien", txtTenGiaoVien.Text);
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@GioiTinh", cmbGioiTinh.Text);
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@NgaySinh", dtNgaySinh.Text);
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@MaMonHoc", cmbMaMonHoc.SelectedValue);
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
                SqlCommand cmd = new SqlCommand("SuaGiaoVien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaGiaoVien", txtMaGiaoVien.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TenGiaoVien", txtTenGiaoVien.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@GioiTinh", cmbGioiTinh.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@NgaySinh", dtNgaySinh.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaMonHoc", cmbMaMonHoc.SelectedValue);
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
