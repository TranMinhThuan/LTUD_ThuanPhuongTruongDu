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
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QuanLyHang;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            dgvNhaCungCap.DataSource = LayDSNCC();
        }
        public DataTable LayDSNCC()
        {
            try
            {
                conn.Open();// mo ket noi
                cmd = new SqlCommand("sp_LayDSNhaCungCap", conn);
                cmd.CommandText = "sp_LayDSNhaCungCap";
                cmd.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);// fill cho bang dt
                return dt; // tra ve bang
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Loi " + ex.Message, "Thong bao");
                return null;
            }
            finally
            {
                conn.Close(); // dong ket noi
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // mo ket noi
                conn.Open();
                cmd = new SqlCommand("sp_themNCC", conn);
                cmd.CommandText = "sp_themNCC";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter para_ma = new SqlParameter("@macc", txtMaNCC.Text);
                cmd.Parameters.Add(para_ma);
                SqlParameter para_ho = new SqlParameter("@tencc", txtTenNCC.Text);
                cmd.Parameters.Add(para_ho);
                SqlParameter para_ten = new SqlParameter("@diachi", txtDC.Text);
                cmd.Parameters.Add(para_ten);


                // thuc thi thanh cong cong hay khong?
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm nhà cung cấp thành công !", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm nhà cung cấp không thành công !!!" + ex.Message, "Thông báo");
            }
            finally
            {
                // dong ket noi
                conn.Close();
            }
            clear();
            dgvNhaCungCap.DataSource = LayDSNCC();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // mo ket noi
                conn.Open();
                cmd = new SqlCommand("sp_XoaNCC", conn);
                cmd.CommandText = "sp_XoaNCC";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter para_ma = new SqlParameter("@macc", txtMaNCC.Text);
                cmd.Parameters.Add(para_ma);
                // thuc thi thanh cong cong hay khong?
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa nhà cung cấp thành công !", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa nhà cung cấp không thành công !!!" + ex.Message, "Thông báo");
            }
            finally
            {
                // dong ket noi
                conn.Close();
            }
            clear();
            dgvNhaCungCap.DataSource = LayDSNCC();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // mo ket noi
                conn.Open();
                cmd = new SqlCommand("sp_SuaNCC", conn);
                cmd.CommandText = "sp_SuaNCC";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter para_ma = new SqlParameter("@macc", txtMaNCC.Text);
                cmd.Parameters.Add(para_ma);
                SqlParameter para_ho = new SqlParameter("@tencc", txtTenNCC.Text);
                cmd.Parameters.Add(para_ho);
                SqlParameter para_ten = new SqlParameter("@diachi", txtDC.Text);
                cmd.Parameters.Add(para_ten);


                // thuc thi thanh cong cong hay khong?
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa nhà cung cấp thành công !", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa nhà cung cấp không thành công !!!" + ex.Message, "Thông báo");
            }
            finally
            {
                // dong ket noi
                conn.Close();
            }
            clear();
            dgvNhaCungCap.DataSource = LayDSNCC();
        }
        public void clear() {
            txtMaNCC.ResetText();
            txtTenNCC.ResetText();
            txtDC.ResetText();
            txtMaNCC.Focus();
        }
    }
}
