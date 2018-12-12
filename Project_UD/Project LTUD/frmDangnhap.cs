using System;
using System.IO;
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
    public partial class frmDangnhap : Form
    {
        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmDangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không ? ", "Thoát ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QuanLyHang;Integrated Security=True");
            string sqlselect = "select * from THONGTINNV  where MaNV='" + txtTenDangNhap.Text + "'and MatKhau='" + txtMatKhau.Text + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlselect, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                Write(path);
                this.Hide();
                frmNoiDung tp = new frmNoiDung();
                tp.Show();
            }
            else
            {
                MessageBox.Show("Sai ten dang nhap hoac mat khau!!!!");
                txtMatKhau.Text = "";
                txtTenDangNhap.Text = "";
                txtTenDangNhap.Focus();
            }

        }
        private void btnDangKi_Click(object sender, EventArgs e)
        {
            frmDangKi tp = new frmDangKi();
            tp.Show();
        }
        string path = @"D:\Project_UD\Project LTUD\account.txt";
        public void Write(String path)
        {
            //Ghi file 
            try
            {
                FileStream fs = new FileStream(path , FileMode.Create, FileAccess.Write, FileShare.None);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(txtTenDangNhap.Text);
                sw.WriteLine(txtMatKhau.Text);
                sw.Flush();
                fs.Close();
                //sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
            }
        }

        private void frmDangnhap_Load(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

