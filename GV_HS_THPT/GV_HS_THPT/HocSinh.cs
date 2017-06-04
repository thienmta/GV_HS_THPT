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
    public partial class FormHocSinh : Form
    {
        string strConn = "Data Source=SRI8203Z3VDW2GR; Initial Catalog = GV_HS_THPT; Integrated Security = True";
        SqlConnection conn = null;
        void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MAHOCSINH,TENHOCSINH,GIOITINH,NGAYSINH,QUEQUAN,TENLOPHOC FROM HOCSINH JOIN LOPHOC ON LOPHOC.MALOPHOC=HOCSINH.MALOPHOC", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvHocSinh.DataSource = dt;
            txtMaHocSinh.Enabled = false;
            btnLuu.Enabled = false;
        }

        public FormHocSinh()
        {
            InitializeComponent();
        }

        private void ShowLopHoc()
        {
            string sql = "SELECT * FROM LOPHOC";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbLopHoc.ValueMember = "MALOPHOC";
            cmbLopHoc.DisplayMember = "TENLOPHOC";
            cmbLopHoc.DataSource = dt;
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

        private void HocSinh_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            LoadData();
            ShowLopHoc();
            ShowGioiTinh();
        }

        private void dgvHocSinh_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //dgvHocSinh.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
            dgvHocSinh.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        
        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txtMaHocSinh.Text = Convert.ToString(dgvHocSinh.CurrentRow.Cells[1].Value);
                    txtTenHocSinh.Text = Convert.ToString(dgvHocSinh.CurrentRow.Cells[2].Value);
                    cmbGioiTinh.Text = Convert.ToString(dgvHocSinh.CurrentRow.Cells[3].Value);
                    dtNgaySinh.Text = Convert.ToString(dgvHocSinh.CurrentRow.Cells[4].Value);
                    txtQueQuan.Text = Convert.ToString(dgvHocSinh.CurrentRow.Cells[5].Value);
                    cmbLopHoc.Text = Convert.ToString(dgvHocSinh.CurrentRow.Cells[6].Value);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi không tải dữ liệu lên được!");
            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (a == 1)
            {
                if (txtTenHocSinh.Text == "" || txtQueQuan.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập đủ thông tin !", "Thông Bóa");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("ThemHocSinh", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@TenHocSinh", txtTenHocSinh.Text);
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@GioiTinh", cmbGioiTinh.Text);
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@NgaySinh", dtNgaySinh.Value);
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@QueQuan", txtQueQuan.Text);
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@MaLopHoc", cmbLopHoc.SelectedValue);
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
                SqlCommand cmd = new SqlCommand("SuaHocSinh", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaHocSinh", txtMaHocSinh.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TenHocSinh", txtTenHocSinh.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@GioiTinh", cmbGioiTinh.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@NgaySinh", dtNgaySinh.Value);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@QueQuan", txtQueQuan.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaLopHoc", cmbLopHoc.SelectedValue);
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("XoaHocSinh", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaHocSinh", txtMaHocSinh.Text);
                cmd.Parameters.Add(p);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    LoadData();
                    txtMaHocSinh.ResetText();
                    txtTenHocSinh.ResetText();
                    cmbGioiTinh.ResetText();
                    cmbLopHoc.ResetText();
                    dtNgaySinh.ResetText();
                    txtQueQuan.ResetText();
                    MessageBox.Show("Xóa thành công !");
                }
                else
                {
                    MessageBox.Show("Không thể xóa !");
                }
            }
        }

        int a;
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaHocSinh.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            a = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaHocSinh.Enabled = false;
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
