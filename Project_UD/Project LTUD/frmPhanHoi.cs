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
    public partial class frmPhanHoi : Form
    {
        public frmPhanHoi()
        {
            InitializeComponent();
        }

        //Sự kiện khi click nút gửi
        private void btnGui_Click(object sender, EventArgs e)
        {
            if (rtboxPhanhoi.Text != "")
            {
                // Ghi phản hồi
                try
                {
                    FileStream fs = new FileStream(@"D:\Project_UD\Project LTUD\phanhoi.txt", FileMode.Create, FileAccess.Write, FileShare.None);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(rtboxPhanhoi.Text);
                    sw.Flush();
                    fs.Close();
                    //sw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" " + ex);
                }
                //clear sau khi phan hồi
                rtboxPhanhoi.Focus();
                rtboxPhanhoi.Text = "";
                MessageBox.Show("Phản hồi thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rtboxPhanhoi.Text == "")
            {
                MessageBox.Show("Chưa nhập phản hồi ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Close phan hoi
        private void frmPhanHoi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không ? ", "Thoát ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if (font.ShowDialog() == DialogResult.OK)
                rtboxPhanhoi.Font = font.Font; // Set Font
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
                rtboxPhanhoi.ForeColor = color.Color; // Set màu chữ 
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog backcolor = new ColorDialog();
            if (backcolor.ShowDialog() == DialogResult.OK)
                rtboxPhanhoi.BackColor = backcolor.Color;// Set background
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); //Thoát trang phản hồi
        }

        private void lưuFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "|*.txt";
            savefile.Title = "Save file nek";
            savefile.RestoreDirectory = true; //cho phep ghi đè
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(savefile.FileName);
                sw.WriteLine(rtboxPhanhoi.Text);
                sw.Close();
            }
        }
        private void mởFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                rtboxPhanhoi.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
        }

        private void frmPhanHoi_Load(object sender, EventArgs e)
        {

        }
    }
}
