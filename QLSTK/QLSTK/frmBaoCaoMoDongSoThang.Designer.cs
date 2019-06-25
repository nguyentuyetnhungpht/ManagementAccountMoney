namespace QLSTK
{
    partial class frmBaoCaoMoDongSoThang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBaoMoDongSoThang = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblLTK = new System.Windows.Forms.Label();
            this.cmbLoaiTietKiem = new System.Windows.Forms.ComboBox();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.cmbThang = new System.Windows.Forms.ComboBox();
            this.lblThang = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTongSoMo = new System.Windows.Forms.Label();
            this.lblTongSoDong = new System.Windows.Forms.Label();
            this.txtTongChiNgay = new System.Windows.Forms.TextBox();
            this.txtChenhLech = new System.Windows.Forms.TextBox();
            this.txtTongThuNgay = new System.Windows.Forms.TextBox();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.lblChenhLech = new System.Windows.Forms.Label();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.cmbNam = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaoMoDongSoThang
            // 
            this.lblBaoMoDongSoThang.AutoEllipsis = true;
            this.lblBaoMoDongSoThang.AutoSize = true;
            this.lblBaoMoDongSoThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaoMoDongSoThang.Location = new System.Drawing.Point(145, 62);
            this.lblBaoMoDongSoThang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBaoMoDongSoThang.Name = "lblBaoMoDongSoThang";
            this.lblBaoMoDongSoThang.Size = new System.Drawing.Size(343, 31);
            this.lblBaoMoDongSoThang.TabIndex = 48;
            this.lblBaoMoDongSoThang.Text = "Báo cáo mở/ đóng sổ tháng";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(375, 133);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(102, 20);
            this.dtpTuNgay.TabIndex = 46;
            this.dtpTuNgay.Value = new System.DateTime(1990, 6, 1, 15, 27, 0, 0);
            // 
            // lblLTK
            // 
            this.lblLTK.AutoSize = true;
            this.lblLTK.Location = new System.Drawing.Point(291, 205);
            this.lblLTK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLTK.Name = "lblLTK";
            this.lblLTK.Size = new System.Drawing.Size(69, 13);
            this.lblLTK.TabIndex = 45;
            this.lblLTK.Text = "Loại tiết kiệm";
            // 
            // cmbLoaiTietKiem
            // 
            this.cmbLoaiTietKiem.FormattingEnabled = true;
            this.cmbLoaiTietKiem.Location = new System.Drawing.Point(375, 197);
            this.cmbLoaiTietKiem.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLoaiTietKiem.Name = "cmbLoaiTietKiem";
            this.cmbLoaiTietKiem.Size = new System.Drawing.Size(102, 21);
            this.cmbLoaiTietKiem.TabIndex = 44;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoEllipsis = true;
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Location = new System.Drawing.Point(291, 174);
            this.lblDenNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(53, 13);
            this.lblDenNgay.TabIndex = 43;
            this.lblDenNgay.Text = "Đến ngày";
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoEllipsis = true;
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(291, 139);
            this.lblTuNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(46, 13);
            this.lblTuNgay.TabIndex = 42;
            this.lblTuNgay.Text = "Từ ngày";
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Location = new System.Drawing.Point(314, 237);
            this.btnXuatFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(59, 19);
            this.btnXuatFile.TabIndex = 33;
            this.btnXuatFile.Text = "Xuất file";
            this.btnXuatFile.UseVisualStyleBackColor = true;
            // 
            // cmbThang
            // 
            this.cmbThang.FormattingEnabled = true;
            this.cmbThang.Location = new System.Drawing.Point(137, 136);
            this.cmbThang.Margin = new System.Windows.Forms.Padding(2);
            this.cmbThang.Name = "cmbThang";
            this.cmbThang.Size = new System.Drawing.Size(34, 21);
            this.cmbThang.TabIndex = 32;
            // 
            // lblThang
            // 
            this.lblThang.AutoEllipsis = true;
            this.lblThang.AutoSize = true;
            this.lblThang.Location = new System.Drawing.Point(47, 142);
            this.lblThang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(38, 13);
            this.lblThang.TabIndex = 31;
            this.lblThang.Text = "Tháng";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(375, 167);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(102, 20);
            this.dtpDenNgay.TabIndex = 47;
            // 
            // lblTongSoMo
            // 
            this.lblTongSoMo.AutoSize = true;
            this.lblTongSoMo.Location = new System.Drawing.Point(47, 205);
            this.lblTongSoMo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongSoMo.Name = "lblTongSoMo";
            this.lblTongSoMo.Size = new System.Drawing.Size(63, 13);
            this.lblTongSoMo.TabIndex = 40;
            this.lblTongSoMo.Text = "Tổng sổ mở";
            // 
            // lblTongSoDong
            // 
            this.lblTongSoDong.AutoSize = true;
            this.lblTongSoDong.Location = new System.Drawing.Point(47, 174);
            this.lblTongSoDong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongSoDong.Name = "lblTongSoDong";
            this.lblTongSoDong.Size = new System.Drawing.Size(74, 13);
            this.lblTongSoDong.TabIndex = 39;
            this.lblTongSoDong.Text = "Tổng sổ đóng";
            // 
            // txtTongChiNgay
            // 
            this.txtTongChiNgay.Location = new System.Drawing.Point(137, 201);
            this.txtTongChiNgay.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongChiNgay.Name = "txtTongChiNgay";
            this.txtTongChiNgay.ReadOnly = true;
            this.txtTongChiNgay.Size = new System.Drawing.Size(99, 20);
            this.txtTongChiNgay.TabIndex = 38;
            // 
            // txtChenhLech
            // 
            this.txtChenhLech.Location = new System.Drawing.Point(137, 233);
            this.txtChenhLech.Margin = new System.Windows.Forms.Padding(2);
            this.txtChenhLech.Name = "txtChenhLech";
            this.txtChenhLech.ReadOnly = true;
            this.txtChenhLech.Size = new System.Drawing.Size(99, 20);
            this.txtChenhLech.TabIndex = 37;
            // 
            // txtTongThuNgay
            // 
            this.txtTongThuNgay.Location = new System.Drawing.Point(137, 171);
            this.txtTongThuNgay.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongThuNgay.Name = "txtTongThuNgay";
            this.txtTongThuNgay.ReadOnly = true;
            this.txtTongThuNgay.Size = new System.Drawing.Size(99, 20);
            this.txtTongThuNgay.TabIndex = 36;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(418, 237);
            this.btnTraCuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(59, 21);
            this.btnTraCuu.TabIndex = 35;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // lblChenhLech
            // 
            this.lblChenhLech.AutoSize = true;
            this.lblChenhLech.Location = new System.Drawing.Point(47, 237);
            this.lblChenhLech.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChenhLech.Name = "lblChenhLech";
            this.lblChenhLech.Size = new System.Drawing.Size(65, 13);
            this.lblChenhLech.TabIndex = 41;
            this.lblChenhLech.Text = "Chênh Lệch";
            // 
            // dgvBaoCao
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaoCao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBaoCao.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBaoCao.Location = new System.Drawing.Point(50, 280);
            this.dgvBaoCao.Name = "dgvBaoCao";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaoCao.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBaoCao.Size = new System.Drawing.Size(506, 144);
            this.dgvBaoCao.TabIndex = 49;
            this.dgvBaoCao.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvBaoCao_RowPostPaint);
            // 
            // cmbNam
            // 
            this.cmbNam.FormattingEnabled = true;
            this.cmbNam.Location = new System.Drawing.Point(189, 136);
            this.cmbNam.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNam.Name = "cmbNam";
            this.cmbNam.Size = new System.Drawing.Size(47, 21);
            this.cmbNam.TabIndex = 50;
            // 
            // frmBaoCaoMoDongSoThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 449);
            this.Controls.Add(this.cmbNam);
            this.Controls.Add(this.dgvBaoCao);
            this.Controls.Add(this.lblBaoMoDongSoThang);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.lblLTK);
            this.Controls.Add(this.cmbLoaiTietKiem);
            this.Controls.Add(this.lblDenNgay);
            this.Controls.Add(this.lblTuNgay);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.cmbThang);
            this.Controls.Add(this.lblThang);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.lblTongSoMo);
            this.Controls.Add(this.lblTongSoDong);
            this.Controls.Add(this.txtTongChiNgay);
            this.Controls.Add(this.txtChenhLech);
            this.Controls.Add(this.txtTongThuNgay);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.lblChenhLech);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBaoCaoMoDongSoThang";
            this.Text = "frmBaoCaoDoanhSoThang";
            this.Load += new System.EventHandler(this.frmBaoCaoDoanhSoThang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaoMoDongSoThang;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblLTK;
        private System.Windows.Forms.ComboBox cmbLoaiTietKiem;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.ComboBox cmbThang;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label lblTongSoMo;
        private System.Windows.Forms.Label lblTongSoDong;
        private System.Windows.Forms.TextBox txtTongChiNgay;
        private System.Windows.Forms.TextBox txtChenhLech;
        private System.Windows.Forms.TextBox txtTongThuNgay;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Label lblChenhLech;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.ComboBox cmbNam;
    }
}