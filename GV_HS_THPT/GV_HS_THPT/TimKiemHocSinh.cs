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
    public partial class FormTimKiemHocSinh : Form
    {
        string strConn = "Data Source=SRI8203Z3VDW2GR; Initial Catalog = GV_HS_THPT; Integrated Security = True";
        SqlConnection conn = null;

        public FormTimKiemHocSinh()
        {
            InitializeComponent();
        }

        private void ShowHocSinh()
        {
            string sql = "SELECT * FROM HOCSINH Order by MAHOCSINH asc";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbMaHocSinh.ValueMember = "MAHOCSINH";
            cmbMaHocSinh.DisplayMember = "MAHOCSINH";
            cmbMaHocSinh.DataSource = dt;
        }

        private void FormTimKiemHocSinh_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            ShowHocSinh();
        }

        private void dgvTimKiemHocSinh_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //dgvTimKiemHocSinh.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("TimKiemHocSinh", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@MaHocSinh", cmbMaHocSinh.Text);
            cmd.Parameters.Add(p);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvTimKiemHocSinh.DataSource = dt;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiemTheoTen_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("TimKiemHocSinhTheoTen", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@TenHocSinh", txtTenHocSinh.Text);
            cmd.Parameters.Add(p);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvTimKiemHocSinh.DataSource = dt;
        }
    }
}
