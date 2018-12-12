using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Interface
{
    public partial class frmDangKi : Form
    {
        public frmDangKi()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QuanLyHang;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                // mo ket noi
                conn.Open();
                cmd = new SqlCommand("sp_ThemTK", conn);
                cmd.CommandText = "sp_ThemTK";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter para_ma = new SqlParameter("@ma", txt1.Text);
                cmd.Parameters.Add(para_ma);
                SqlParameter para_mk = new SqlParameter("@mk", txt2.Text);
                cmd.Parameters.Add(para_mk);
                SqlParameter para_ten = new SqlParameter("@ten", txt3.Text);
                cmd.Parameters.Add(para_ten);
                SqlParameter para_email = new SqlParameter("@email", txt4.Text);
                cmd.Parameters.Add(para_email);
                SqlParameter para_dc = new SqlParameter("@diachi", txt6.Text);
                cmd.Parameters.Add(para_dc);
                SqlParameter para_sdt = new SqlParameter("@sdt", txt6.Text);
                cmd.Parameters.Add(para_sdt);


                // thuc thi thanh cong cong hay khong?
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Đăng ký thành công !", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng ký không thành công !!!" + ex.Message, "Thông báo");
            }
            finally
            {
                // dong ket noi
                conn.Close();
            }
        }

        private void frmDangKi_Load(object sender, EventArgs e)
        {

        }

    }
}
