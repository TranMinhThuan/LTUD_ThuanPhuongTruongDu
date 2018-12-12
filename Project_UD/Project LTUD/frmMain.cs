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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát chương trình không ? ", "Thoát ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void phiênBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phiên bản: 1.0" + "\n" + "Tạo bởi: Minh Thuận, Duy Phương, Công Dự, Xuân Trường" + "\n" + "Ngày: 15/11/2018" + "\n" + "Thời gian bảo hành: 12 tháng.", "Thông tin phiên bản", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ýKiếnPhảnHồiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhanHoi ykienphanhoi = new frmPhanHoi();
            ykienphanhoi.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangnhap dangnhap = new frmDangnhap();
            dangnhap.MdiParent = this;
            dangnhap.Show();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //doc file kiem tra user name & pass . if trùng -> frmNoiDung else -> "Bạn chưa dang nhap"
            //Đọc file
            try
            {
                FileStream fs = new FileStream(@"D:\Project_UD\Project LTUD\account.txt", FileMode.Open, FileAccess.Read, FileShare.None);
                StreamReader sr = new StreamReader(fs);
                string username = sr.ReadLine();
                string password = sr.ReadLine();
                MessageBox.Show("Tài khoản: " + username + " tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fs.Close();
                //sw.Close();
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QuanLyHang;Integrated Security=True");
                string sqlselect = "select * from THONGTINNV  where MaNV='" + username + "'and MatKhau='" + password + "'";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlselect, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    frmNoiDung tp = new frmNoiDung();
                    tp.MdiParent = this;
                    tp.Show();
                }
                else
                {
                    MessageBox.Show("Bạn chưa đăng nhập!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
            }

        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"D:\Project_UD\Project LTUD\Huongdan.txt", FileMode.Open, FileAccess.Read, FileShare.None);
            StreamReader sr = new StreamReader(fs);

            {
                string hdsd = sr.ReadToEnd();
                MessageBox.Show("" + hdsd + "\n Hết!", "Hướng dẫn sử dụng ", MessageBoxButtons.OK);
            }
           
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}

