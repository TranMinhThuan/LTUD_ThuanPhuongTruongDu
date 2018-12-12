namespace Interface
{
    partial class frmPhanHoi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanHoi));
            this.btnGui = new System.Windows.Forms.Button();
            this.rtboxPhanhoi = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tuyChonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mởFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tùyChỉnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGui
            // 
            this.btnGui.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGui.ForeColor = System.Drawing.Color.Indigo;
            this.btnGui.Location = new System.Drawing.Point(58, 168);
            this.btnGui.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(85, 21);
            this.btnGui.TabIndex = 2;
            this.btnGui.TabStop = false;
            this.btnGui.Text = "Gửi";
            this.btnGui.UseVisualStyleBackColor = true;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // rtboxPhanhoi
            // 
            this.rtboxPhanhoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtboxPhanhoi.Location = new System.Drawing.Point(20, 46);
            this.rtboxPhanhoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtboxPhanhoi.Name = "rtboxPhanhoi";
            this.rtboxPhanhoi.Size = new System.Drawing.Size(171, 110);
            this.rtboxPhanhoi.TabIndex = 1;
            this.rtboxPhanhoi.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tuyChonToolStripMenuItem,
            this.tùyChỉnhToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(212, 25);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tuyChonToolStripMenuItem
            // 
            this.tuyChonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lưuFileToolStripMenuItem,
            this.mởFileToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.tuyChonToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tuyChonToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.tuyChonToolStripMenuItem.Image = global::Interface.Properties.Resources.Tatice_Cristal_Intense_Ok;
            this.tuyChonToolStripMenuItem.Name = "tuyChonToolStripMenuItem";
            this.tuyChonToolStripMenuItem.Size = new System.Drawing.Size(100, 21);
            this.tuyChonToolStripMenuItem.Text = "Tùy chọn";
            // 
            // lưuFileToolStripMenuItem
            // 
            this.lưuFileToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lưuFileToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.lưuFileToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lưuFileToolStripMenuItem.Image = global::Interface.Properties.Resources.Custom_Icon_Design_Pretty_Office_7_Save;
            this.lưuFileToolStripMenuItem.Name = "lưuFileToolStripMenuItem";
            this.lưuFileToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.lưuFileToolStripMenuItem.Text = "Lưu file";
            this.lưuFileToolStripMenuItem.Click += new System.EventHandler(this.lưuFileToolStripMenuItem_Click);
            // 
            // mởFileToolStripMenuItem
            // 
            this.mởFileToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mởFileToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.mởFileToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrchid;
            this.mởFileToolStripMenuItem.Image = global::Interface.Properties.Resources.Custom_Icon_Design_Pretty_Office_9_Open_file;
            this.mởFileToolStripMenuItem.Name = "mởFileToolStripMenuItem";
            this.mởFileToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.mởFileToolStripMenuItem.Text = "Mở file";
            this.mởFileToolStripMenuItem.Click += new System.EventHandler(this.mởFileToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.thoátToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F);
            this.thoátToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrchid;
            this.thoátToolStripMenuItem.Image = global::Interface.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_edit_delete;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // tùyChỉnhToolStripMenuItem
            // 
            this.tùyChỉnhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.backgroundColorToolStripMenuItem});
            this.tùyChỉnhToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tùyChỉnhToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.tùyChỉnhToolStripMenuItem.Image = global::Interface.Properties.Resources.Oxygen_Icons1;
            this.tùyChỉnhToolStripMenuItem.Name = "tùyChỉnhToolStripMenuItem";
            this.tùyChỉnhToolStripMenuItem.Size = new System.Drawing.Size(103, 21);
            this.tùyChỉnhToolStripMenuItem.Text = "Tùy chỉnh";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.fontToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrchid;
            this.fontToolStripMenuItem.Image = global::Interface.Properties.Resources.Oxygen_Icons_org_Oxygen_Apps_preferences_desktop_font;
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.fontToolStripMenuItem.Text = "Font ";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.colorToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrchid;
            this.colorToolStripMenuItem.Image = global::Interface.Properties.Resources.Itzikgur_My_Seven_Graphics_Painting;
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.backgroundColorToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrchid;
            this.backgroundColorToolStripMenuItem.Image = global::Interface.Properties.Resources.Iconshock_Real_Vista_Text_Color_fill;
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.backgroundColorToolStripMenuItem.Text = "Background color";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mời bạn nhập phản hồi ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmPhanHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(212, 212);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtboxPhanhoi);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPhanHoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Ý kiến phản hồi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPhanHoi_FormClosing);
            this.Load += new System.EventHandler(this.frmPhanHoi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.RichTextBox rtboxPhanhoi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tuyChonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mởFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tùyChỉnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}