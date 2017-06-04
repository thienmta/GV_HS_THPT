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
    public partial class FormLopHoc : Form
    {
        string strConn = "Data Source=SRI8203Z3VDW2GR; Initial Catalog = GV_HS_THPT; Integrated Security = True";
        SqlConnection conn = null;
        void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MALOPHOC,TENLOPHOC,TENGIAOVIEN FROM LOPHOC JOIN GIAOVIEN ON GIAOVIEN.MAGIAOVIEN=LOPHOC.MAGIAOVIEN ", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvLopHoc.DataSource = dt;
            txtMaLopHoc.Enabled = false;
            btnLuu.Enabled = false;
        }

        public FormLopHoc()
        {
            InitializeComponent();
        }

        private void ShowGiaoVien()
        {
            string sql = "SELECT * FROM GIAOVIEN where GIAOVIEN.MAGIAOVIEN not in (select LOPHOC.MAGIAOVIEN from LOPHOC)";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbGVCN.ValueMember = "MAGIAOVIEN";
            cmbGVCN.DisplayMember = "TENGIAOVIEN";
            cmbGVCN.DataSource = dt;
        }

        private void LopHoc_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            LoadData();
            ShowGiaoVien();
        }

        private void dgvLopHoc_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvLopHoc.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void dgvLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txtMaLopHoc.Text = Convert.ToString(dgvLopHoc.CurrentRow.Cells[1].Value);
                    txtTenLopHoc.Text = Convert.ToString(dgvLopHoc.CurrentRow.Cells[2].Value);
                    cmbGVCN.Text = Convert.ToString(dgvLopHoc.CurrentRow.Cells[3].Value);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi không tải dữ liệu lên được!");
            }
        }
        
        int a;
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            ShowGiaoVien();
            txtMaLopHoc.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            a = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaLopHoc.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            a = 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("XoaLopHoc", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaLopHoc", txtMaLopHoc.Text);
                cmd.Parameters.Add(p);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    LoadData();
                    txtTenLopHoc.ResetText();
                    cmbGVCN.ResetText();
                    MessageBox.Show("Xóa thành công !");
                }
                else
                {
                    MessageBox.Show("Không thể xóa !");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                if (txtTenLopHoc.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập đủ thông tin !", "Thông Bóa");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("ThemLopHoc", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@TenLopHoc", txtTenLopHoc.Text);
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@MaGiaoVien", cmbGVCN.SelectedValue);
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
                SqlCommand cmd = new SqlCommand("SuaLopHoc", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaLopHoc", txtMaLopHoc.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TenLopHoc", txtTenLopHoc.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaGiaoVien", cmbGVCN.SelectedValue);
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
