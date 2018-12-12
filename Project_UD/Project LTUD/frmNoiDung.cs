using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Interface
{
    public partial class frmNoiDung : Form
    {
        public frmNoiDung()
        {
            InitializeComponent();
        }

        private void đangXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangnhap tp = new frmDangnhap();
            tp.Show();
            //Ghi file
            try
            {
                FileStream fs = new FileStream(@"D:\Project_UD\Project LTUD\account.txt", FileMode.Create, FileAccess.Write, FileShare.None);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("không");
                sw.WriteLine("dont login");
                sw.Flush();
                fs.Close();
                //sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
            }
        }

        private void frmNoiDung_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát chương trình không ? ", "Thoát ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHangHoa tp = new frmHangHoa();
            tp.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHoaDon tp = new frmHoaDon();
            tp.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNhaCungCap tp = new frmNhaCungCap();
            tp.Show();
        }

        private void frmNoiDung_Load(object sender, EventArgs e)
        {

        }
    }
}
