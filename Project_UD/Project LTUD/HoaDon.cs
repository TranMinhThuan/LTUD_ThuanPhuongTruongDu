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
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QuanLyHang;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public void clear()
        {
            txtMaHD.ResetText();
            txtSL.ResetText();
            txtTDH.ResetText();
            txtTenHD.ResetText();
            txtThue.ResetText();
            cboMH.ResetText();
            txtMaHD.Focus();
        }
        public DataTable LayDSHD()
        {
            try
            {
                conn.Open();// mo ket noi

                cmd = new SqlCommand("sp_LayDSHoaDon", conn);
                cmd.CommandText = "sp_LayDSHoaDon";
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
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                dgvHoaDon.DataSource = LayDSHD();

                conn.Open();//mo ket noi
                string getMaTP = "SELECT MaHang FROM dbo.HANGHOA;";
                SqlDataReader dr = new SqlCommand(getMaTP, conn).ExecuteReader();

                while (dr.Read())
                {
                    cboMH.Items.Add(dr.GetValue(0).ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // dong ket noi
                conn.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // mo ket noi
                conn.Open();
                cmd = new SqlCommand("sp_themHD", conn);
                cmd.CommandText = "sp_themHD";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter para_ma = new SqlParameter("@mahd", txtMaHD.Text);
                cmd.Parameters.Add(para_ma);
                SqlParameter para_ten = new SqlParameter("@tenhd", txtTenHD.Text);
                cmd.Parameters.Add(para_ten);
                SqlParameter para_mh = new SqlParameter("@mahang", cboMH.Text);
                cmd.Parameters.Add(para_mh);
                SqlParameter para_sl = new SqlParameter("@soluong", txtSL.Text);
                cmd.Parameters.Add(para_sl);
                SqlParameter para_tongdonhang = new SqlParameter("@dongia", txtTDH.Text);
                cmd.Parameters.Add(para_tongdonhang);
                SqlParameter para_thue = new SqlParameter("@thue", txtThue.Text);
                cmd.Parameters.Add(para_thue);

                // thuc thi thanh cong cong hay khong?
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm hóa đơn thành công !", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm hóa đơn không thành công !!!" + ex.Message, "Thông báo");
            }
            finally
            {
                // dong ket noi
                conn.Close();
            }
            clear();
            dgvHoaDon.DataSource = LayDSHD();
        
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // mo ket noi
                conn.Open();
                cmd = new SqlCommand("sp_HD", conn);
                cmd.CommandText = "sp_HD";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter para_ma = new SqlParameter("@mahd", txtMaHD.Text);
                cmd.Parameters.Add(para_ma);
                SqlParameter para_ten = new SqlParameter("@tenhd", txtTenHD.Text);
                cmd.Parameters.Add(para_ten);
                SqlParameter para_mh = new SqlParameter("@mahang", cboMH.Text);
                cmd.Parameters.Add(para_mh);
                SqlParameter para_sl = new SqlParameter("@soluong", txtSL.Text);
                cmd.Parameters.Add(para_sl);
                SqlParameter para_tongdonhang = new SqlParameter("@dongia", txtTDH.Text);
                cmd.Parameters.Add(para_tongdonhang);
                SqlParameter para_thue = new SqlParameter("@thue", txtThue.Text);
                cmd.Parameters.Add(para_thue);

                // thuc thi thanh cong cong hay khong?
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa hóa đơn thành công !", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa hóa đơn không thành công !!!" + ex.Message, "Thông báo");
            }
            finally
            {
                // dong ket noi
                conn.Close();
            }
            clear();
            dgvHoaDon.DataSource = LayDSHD();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // mo ket noi
                conn.Open();
                cmd = new SqlCommand("sp_XoaHD", conn);
                cmd.CommandText = "sp_XoaHD";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter para_ma = new SqlParameter("@mahd", txtMaHD.Text);
                cmd.Parameters.Add(para_ma);

                // thuc thi thanh cong cong hay khong?
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa hóa đơn thành công !", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa hóa đơn không thành công !!!" + ex.Message, "Thông báo");
            }
            finally
            {
                // dong ket noi
                conn.Close();
            }
            clear();
            dgvHoaDon.DataSource = LayDSHD();
        }

        

    }
}
