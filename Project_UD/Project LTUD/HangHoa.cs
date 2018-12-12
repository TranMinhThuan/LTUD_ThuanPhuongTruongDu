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
    public partial class frmHangHoa : Form
    {
        public frmHangHoa()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QuanLyHang;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        
        public DataTable LayDSHH()
        {
            try
            {
                conn.Open();// mo ket noi

                cmd = new SqlCommand("sp_LayDSHangHoa", conn);
                cmd.CommandText = "sp_LayDSHangHoa";
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
        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            
            try
            {
                dgvHangHoa.DataSource = LayDSHH();

                conn.Open();//mo ket noi
                string getMaTP = "SELECT MaNhaCungCap FROM dbo.NHACUNGCAP;";
                SqlDataReader dr = new SqlCommand(getMaTP, conn).ExecuteReader();

                while (dr.Read())
                {
                    cboMaNCC.Items.Add(dr.GetValue(0).ToString());
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
                cmd = new SqlCommand("sp_themHang", conn);
                cmd.CommandText = "sp_themHang";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter para_ma = new SqlParameter("@ma", txtMaHH.Text);
                cmd.Parameters.Add(para_ma);
                SqlParameter para_ten = new SqlParameter("@ten", txtTenHH.Text);
                cmd.Parameters.Add(para_ten);
                SqlParameter para_dongia = new SqlParameter("@dongia", txtDonGia.Text);
                cmd.Parameters.Add(para_dongia);
                SqlParameter para_ncc = new SqlParameter("@nhacungcap", cboMaNCC.Text);
                cmd.Parameters.Add(para_ncc);
                SqlParameter para_ngaynhap = new SqlParameter("@ngaynhap", Convert.ToDateTime(dtpNgayNhap.Text));
                cmd.Parameters.Add(para_ngaynhap);
                SqlParameter para_ngayxuat = new SqlParameter("@ngayxuat", Convert.ToDateTime(dtpNgayXuat.Text));
                cmd.Parameters.Add(para_ngayxuat);

                // thuc thi thanh cong cong hay khong?
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm hàng hóa thành công !", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm hàng hóa không thành công !!!" + ex.Message, "Thông báo");
            }
            finally
            {
                // dong ket noi
                conn.Close();
            }
            clear();
            dgvHangHoa.DataSource = LayDSHH();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // mo ket noi
                conn.Open();
                cmd = new SqlCommand("sp_XoaH", conn);
                cmd.CommandText = "sp_XoaH";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter para_mah = new SqlParameter("@mah", txtMaHH.Text);
                cmd.Parameters.Add(para_mah);


                // thuc thi thanh cong cong hay khong?
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa hàng hóa thành công !", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa hàng hóa không thành công !!!" + ex.Message, "Thông báo");
            }
            finally
            {
                // dong ket noi
                conn.Close();
            }
            clear();
            dgvHangHoa.DataSource = LayDSHH();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // mo ket noi
                conn.Open();
                cmd = new SqlCommand("sp_SuaHang", conn);
                cmd.CommandText = "sp_SuaHang";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter para_ma = new SqlParameter("@ma", txtMaHH.Text);
                cmd.Parameters.Add(para_ma);
                SqlParameter para_ten = new SqlParameter("@ten", txtTenHH.Text);
                cmd.Parameters.Add(para_ten);
                SqlParameter para_dongia = new SqlParameter("@dongia", txtDonGia.Text);
                cmd.Parameters.Add(para_dongia);
                SqlParameter para_ncc = new SqlParameter("@nhacungcap", cboMaNCC.Text);
                cmd.Parameters.Add(para_ncc);
                SqlParameter para_ngaynhap = new SqlParameter("@ngaynhap", Convert.ToDateTime(dtpNgayNhap.Text));
                cmd.Parameters.Add(para_ngaynhap);
                SqlParameter para_ngayxuat = new SqlParameter("@ngayxuat", Convert.ToDateTime(dtpNgayXuat.Text));
                cmd.Parameters.Add(para_ngayxuat);

                // thuc thi thanh cong cong hay khong?
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa hàng hóa thành công !", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa hàng hóa không thành công !!!" + ex.Message, "Thông báo");
            }
            finally
            {
                // dong ket noi
                conn.Close();
            }
            clear();
            dgvHangHoa.DataSource = LayDSHH();
        }
        public void clear() {
            txtMaHH.ResetText();
            txtTenHH.ResetText();
            txtDonGia.ResetText();
            cboMaNCC.ResetText();
            dtpNgayNhap.ResetText();
            dtpNgayXuat.ResetText();
        }

        private void dtpNgayNhap_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
