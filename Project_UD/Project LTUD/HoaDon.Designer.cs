namespace Interface
{
    partial class frmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.cboMH = new System.Windows.Forms.ComboBox();
            this.lblTongDonHang = new System.Windows.Forms.Label();
            this.lblMaHang = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtTenHD = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lbTenHoaDon = new System.Windows.Forms.Label();
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.txtTDH = new System.Windows.Forms.TextBox();
            this.txtThue = new System.Windows.Forms.TextBox();
            this.lblThue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMH
            // 
            this.cboMH.FormattingEnabled = true;
            this.cboMH.Location = new System.Drawing.Point(131, 280);
            this.cboMH.Name = "cboMH";
            this.cboMH.Size = new System.Drawing.Size(268, 21);
            this.cboMH.TabIndex = 40;
            // 
            // lblTongDonHang
            // 
            this.lblTongDonHang.AutoSize = true;
            this.lblTongDonHang.BackColor = System.Drawing.SystemColors.Control;
            this.lblTongDonHang.ForeColor = System.Drawing.Color.Purple;
            this.lblTongDonHang.Location = new System.Drawing.Point(44, 336);
            this.lblTongDonHang.Name = "lblTongDonHang";
            this.lblTongDonHang.Size = new System.Drawing.Size(44, 13);
            this.lblTongDonHang.TabIndex = 38;
            this.lblTongDonHang.Text = "Đơn giá";
            // 
            // lblMaHang
            // 
            this.lblMaHang.AutoSize = true;
            this.lblMaHang.BackColor = System.Drawing.SystemColors.Control;
            this.lblMaHang.ForeColor = System.Drawing.Color.Purple;
            this.lblMaHang.Location = new System.Drawing.Point(44, 280);
            this.lblMaHang.Name = "lblMaHang";
            this.lblMaHang.Size = new System.Drawing.Size(49, 13);
            this.lblMaHang.TabIndex = 37;
            this.lblMaHang.Text = "Mã hàng";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(640, 104);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 29);
            this.btnSua.TabIndex = 36;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(640, 168);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 29);
            this.btnXoa.TabIndex = 35;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(640, 45);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 29);
            this.btnThem.TabIndex = 34;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(131, 307);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(268, 20);
            this.txtSL.TabIndex = 33;
            // 
            // txtTenHD
            // 
            this.txtTenHD.Location = new System.Drawing.Point(131, 254);
            this.txtTenHD.Name = "txtTenHD";
            this.txtTenHD.Size = new System.Drawing.Size(268, 20);
            this.txtTenHD.TabIndex = 32;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(131, 228);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(268, 20);
            this.txtMaHD.TabIndex = 31;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.BackColor = System.Drawing.SystemColors.Control;
            this.lblSoLuong.ForeColor = System.Drawing.Color.Purple;
            this.lblSoLuong.Location = new System.Drawing.Point(44, 307);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(53, 13);
            this.lblSoLuong.TabIndex = 28;
            this.lblSoLuong.Text = "Số Lượng";
            // 
            // lbTenHoaDon
            // 
            this.lbTenHoaDon.AutoSize = true;
            this.lbTenHoaDon.BackColor = System.Drawing.SystemColors.Control;
            this.lbTenHoaDon.ForeColor = System.Drawing.Color.Purple;
            this.lbTenHoaDon.Location = new System.Drawing.Point(44, 254);
            this.lbTenHoaDon.Name = "lbTenHoaDon";
            this.lbTenHoaDon.Size = new System.Drawing.Size(69, 13);
            this.lbTenHoaDon.TabIndex = 29;
            this.lbTenHoaDon.Text = "Tên hóa đơn";
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.AutoSize = true;
            this.lblMaHoaDon.BackColor = System.Drawing.SystemColors.Control;
            this.lblMaHoaDon.ForeColor = System.Drawing.Color.Purple;
            this.lblMaHoaDon.Location = new System.Drawing.Point(45, 230);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(65, 13);
            this.lblMaHoaDon.TabIndex = 30;
            this.lblMaHoaDon.Text = "Mã hóa đơn";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(37, 45);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(548, 150);
            this.dgvHoaDon.TabIndex = 27;
            // 
            // txtTDH
            // 
            this.txtTDH.Location = new System.Drawing.Point(131, 333);
            this.txtTDH.Name = "txtTDH";
            this.txtTDH.Size = new System.Drawing.Size(268, 20);
            this.txtTDH.TabIndex = 41;
            // 
            // txtThue
            // 
            this.txtThue.Location = new System.Drawing.Point(131, 359);
            this.txtThue.Name = "txtThue";
            this.txtThue.Size = new System.Drawing.Size(268, 20);
            this.txtThue.TabIndex = 43;
            // 
            // lblThue
            // 
            this.lblThue.AutoSize = true;
            this.lblThue.BackColor = System.Drawing.SystemColors.Control;
            this.lblThue.ForeColor = System.Drawing.Color.Purple;
            this.lblThue.Location = new System.Drawing.Point(44, 362);
            this.lblThue.Name = "lblThue";
            this.lblThue.Size = new System.Drawing.Size(32, 13);
            this.lblThue.TabIndex = 42;
            this.lblThue.Text = "Thuế";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(192, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "DANH SÁCH HÓA ĐƠN";
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtThue);
            this.Controls.Add(this.lblThue);
            this.Controls.Add(this.txtTDH);
            this.Controls.Add(this.cboMH);
            this.Controls.Add(this.lblTongDonHang);
            this.Controls.Add(this.lblMaHang);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtTenHD);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lbTenHoaDon);
            this.Controls.Add(this.lblMaHoaDon);
            this.Controls.Add(this.dgvHoaDon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHoaDon";
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMH;
        private System.Windows.Forms.Label lblTongDonHang;
        private System.Windows.Forms.Label lblMaHang;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtTenHD;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lbTenHoaDon;
        private System.Windows.Forms.Label lblMaHoaDon;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.TextBox txtTDH;
        private System.Windows.Forms.TextBox txtThue;
        private System.Windows.Forms.Label lblThue;
        private System.Windows.Forms.Label label1;
    }
}