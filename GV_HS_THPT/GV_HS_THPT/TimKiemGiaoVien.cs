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
    public partial class FormTimKiemGiaoVien : Form
    {
        string strConn = "Data Source=SRI8203Z3VDW2GR; Initial Catalog = GV_HS_THPT; Integrated Security = True";
        SqlConnection conn = null;

        public FormTimKiemGiaoVien()
        {
            InitializeComponent();
        }

        private void ShowGiaoVien()
        {
            string sql = "SELECT * FROM GIAOVIEN Order by MAGIAOVIEN asc";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbMaGiaoVien.ValueMember = "MAGIAOVIEN";
            cmbMaGiaoVien.DisplayMember = "MAGIAOVIEN";
            cmbMaGiaoVien.DataSource = dt;
        }

        private void FormTimKiemGiaoVien_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            ShowGiaoVien();
        }

        private void btnTimKiemTheoMa_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("TimKiemGiaoVienTheoMaGiaoVien", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@MaGiaoVien", cmbMaGiaoVien.Text);
            cmd.Parameters.Add(p);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvTimKiemGiaoVien.DataSource = dt;
        }

        private void btnTimKiemTheoTen_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("TimKiemGiaoVienTheoTen", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@TenGiaoVien", txtTenGiaoVien.Text);
            cmd.Parameters.Add(p);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvTimKiemGiaoVien.DataSource = dt;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
