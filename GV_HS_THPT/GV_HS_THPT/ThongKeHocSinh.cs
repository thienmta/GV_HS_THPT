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
    public partial class FormThongKeHocSinh : Form
    {
        string strConn = "Data Source=SRI8203Z3VDW2GR; Initial Catalog = GV_HS_THPT; Integrated Security = True";
        SqlConnection conn = null;

        public FormThongKeHocSinh()
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

        private void FormThongKeHocSinh_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            ShowLopHoc();
        }

        private void dgvThongKeHocSinh_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvThongKeHocSinh.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("ThongKeHocSinh", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@MaLopHoc", cmbLopHoc.SelectedValue);
            cmd.Parameters.Add(p);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvThongKeHocSinh.DataSource = dt;

            //int a=1;
            //SqlCommand cmd1 = new SqlCommand("SoHocSinh_Lop", conn);
            //cmd1.CommandType = CommandType.StoredProcedure;
            //SqlParameter p1 = new SqlParameter("@MaLopHoc", cmbLopHoc.SelectedValue);
            //cmd1.Parameters.Add(p1);
            //p1 = new SqlParameter("@TongHocSinh", a);
            //cmd1.Parameters.Add(p1);
            //SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            //DataTable dt1 = new DataTable();
            //da1.Fill(dt1);
            //dgvThongKeHocSinh.DataSource = dt1;
            //lbTongHocSinh.Text = a.ToString();
        }
    }
}
