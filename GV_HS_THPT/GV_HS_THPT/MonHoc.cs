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
    public partial class FormMonHoc : Form
    {
        string strConn = "Data Source=SRI8203Z3VDW2GR; Initial Catalog = GV_HS_THPT; Integrated Security = True";
        SqlConnection conn = null;
        void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MONHOC", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMonHoc.DataSource = dt;
            txtMaMonHoc.Enabled = false;
            btnLuu.Enabled = false;
        }

        public FormMonHoc()
        {
            InitializeComponent();
        }

        private void MonHoc_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            LoadData();
        }

        private void dgvMonHoc_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvMonHoc.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txtMaMonHoc.Text = Convert.ToString(dgvMonHoc.CurrentRow.Cells[1].Value);
                    txtTenMonHoc.Text = Convert.ToString(dgvMonHoc.CurrentRow.Cells[2].Value);
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
            txtMaMonHoc.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            a = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaMonHoc.Enabled = false;
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
                SqlCommand cmd = new SqlCommand("XoaMonHoc", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@Ma", txtMaMonHoc.Text);
                cmd.Parameters.Add(p);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    LoadData();
                    txtTenMonHoc.ResetText();
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
                if (txtTenMonHoc.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập đủ thông tin !", "Thông Bóa");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("ThemMonHoc", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@Ten", txtTenMonHoc.Text);
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
                SqlCommand cmd = new SqlCommand("SuaMonHoc", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@Ma", txtMaMonHoc.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@Ten", txtTenMonHoc.Text);
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
