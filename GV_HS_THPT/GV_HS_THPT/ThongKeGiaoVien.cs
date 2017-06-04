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
    public partial class FormThongKeGiaoVien : Form
    {
        string strConn = "Data Source=SRI8203Z3VDW2GR; Initial Catalog = GV_HS_THPT; Integrated Security = True";
        SqlConnection conn = null;

        public FormThongKeGiaoVien()
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

        private void FormThongKeGiaoVien_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            ShowLopHoc();
        }

        private void dgvThongKeGiaoVien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvThongKeGiaoVien.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        
        private void btnThongKe_Click_1(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("ThongKeGiaoVien", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@MaLopHoc", cmbLopHoc.SelectedValue);
            cmd.Parameters.Add(p);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvThongKeGiaoVien.DataSource = dt;
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
