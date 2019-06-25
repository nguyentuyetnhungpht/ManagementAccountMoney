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
            this.lblBaoMoDongSoThang = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblLTK = new System.Windows.Forms.Label();
            this.cmbLoaiTietKiem = new System.Windows.Forms.ComboBox();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.cmbThang = new System.Windows.Forms.ComboBox();
            this.lblThang = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTongSoMo = new System.Windows.Forms.Label();
            this.lblTongSoDong = new System.Windows.Forms.Label();
            this.txtTongChiNgay = new System.Windows.Forms.TextBox();
            this.txtChenhLech = new System.Windows.Forms.TextBox();
            this.txtTongThuNgay = new System.Windows.Forms.TextBox();
            this.lblChenhLech = new System.Windows.Forms.Label();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.cmbNam = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.btnXuatFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBaoMoDongSoThang
            // 
            this.lblBaoMoDongSoThang.AutoEllipsis = true;
            this.lblBaoMoDongSoThang.AutoSize = true;
            this.lblBaoMoDongSoThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaoMoDongSoThang.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblBaoMoDongSoThang.Location = new System.Drawing.Point(223, 9);
            this.lblBaoMoDongSoThang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBaoMoDongSoThang.Name = "lblBaoMoDongSoThang";
            this.lblBaoMoDongSoThang.Size = new System.Drawing.Size(431, 39);
            this.lblBaoMoDongSoThang.TabIndex = 48;
            this.lblBaoMoDongSoThang.Text = "Báo cáo mở/ đóng sổ tháng";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(631, 78);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(161, 32);
            this.dtpTuNgay.TabIndex = 46;
            this.dtpTuNgay.Value = new System.DateTime(1990, 6, 1, 15, 27, 0, 0);
            // 
            // lblLTK
            // 
            this.lblLTK.AutoSize = true;
            this.lblLTK.BackColor = System.Drawing.Color.CadetBlue;
            this.lblLTK.ForeColor = System.Drawing.Color.White;
            this.lblLTK.Location = new System.Drawing.Point(475, 165);
            this.lblLTK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLTK.Name = "lblLTK";
            this.lblLTK.Size = new System.Drawing.Size(132, 24);
            this.lblLTK.TabIndex = 45;
            this.lblLTK.Text = "Loại tiết kiệm";
            // 
            // cmbLoaiTietKiem
            // 
            this.cmbLoaiTietKiem.FormattingEnabled = true;
            this.cmbLoaiTietKiem.Location = new System.Drawing.Point(631, 157);
            this.cmbLoaiTietKiem.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLoaiTietKiem.Name = "cmbLoaiTietKiem";
            this.cmbLoaiTietKiem.Size = new System.Drawing.Size(161, 32);
            this.cmbLoaiTietKiem.TabIndex = 44;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoEllipsis = true;
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.BackColor = System.Drawing.Color.CadetBlue;
            this.lblDenNgay.ForeColor = System.Drawing.Color.White;
            this.lblDenNgay.Location = new System.Drawing.Point(512, 127);
            this.lblDenNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(95, 24);
            this.lblDenNgay.TabIndex = 43;
            this.lblDenNgay.Text = "Đến ngày";
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoEllipsis = true;
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.BackColor = System.Drawing.Color.CadetBlue;
            this.lblTuNgay.ForeColor = System.Drawing.Color.White;
            this.lblTuNgay.Location = new System.Drawing.Point(524, 89);
            this.lblTuNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(83, 24);
            this.lblTuNgay.TabIndex = 42;
            this.lblTuNgay.Text = "Từ ngày";
            // 
            // cmbThang
            // 
            this.cmbThang.FormattingEnabled = true;
            this.cmbThang.Location = new System.Drawing.Point(631, 41);
            this.cmbThang.Margin = new System.Windows.Forms.Padding(2);
            this.cmbThang.Name = "cmbThang";
            this.cmbThang.Size = new System.Drawing.Size(34, 32);
            this.cmbThang.TabIndex = 32;
            // 
            // lblThang
            // 
            this.lblThang.AutoEllipsis = true;
            this.lblThang.AutoSize = true;
            this.lblThang.BackColor = System.Drawing.Color.CadetBlue;
            this.lblThang.ForeColor = System.Drawing.Color.White;
            this.lblThang.Location = new System.Drawing.Point(541, 49);
            this.lblThang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(66, 24);
            this.lblThang.TabIndex = 31;
            this.lblThang.Text = "Tháng";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(631, 118);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(161, 32);
            this.dtpDenNgay.TabIndex = 47;
            // 
            // lblTongSoMo
            // 
            this.lblTongSoMo.AutoSize = true;
            this.lblTongSoMo.BackColor = System.Drawing.Color.CadetBlue;
            this.lblTongSoMo.ForeColor = System.Drawing.Color.White;
            this.lblTongSoMo.Location = new System.Drawing.Point(39, 129);
            this.lblTongSoMo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongSoMo.Name = "lblTongSoMo";
            this.lblTongSoMo.Size = new System.Drawing.Size(115, 24);
            this.lblTongSoMo.TabIndex = 40;
            this.lblTongSoMo.Text = "Tổng sổ mở";
            // 
            // lblTongSoDong
            // 
            this.lblTongSoDong.AutoSize = true;
            this.lblTongSoDong.BackColor = System.Drawing.Color.CadetBlue;
            this.lblTongSoDong.ForeColor = System.Drawing.Color.White;
            this.lblTongSoDong.Location = new System.Drawing.Point(23, 88);
            this.lblTongSoDong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongSoDong.Name = "lblTongSoDong";
            this.lblTongSoDong.Size = new System.Drawing.Size(131, 24);
            this.lblTongSoDong.TabIndex = 39;
            this.lblTongSoDong.Text = "Tổng sổ đóng";
            // 
            // txtTongChiNgay
            // 
            this.txtTongChiNgay.Location = new System.Drawing.Point(199, 121);
            this.txtTongChiNgay.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongChiNgay.Name = "txtTongChiNgay";
            this.txtTongChiNgay.ReadOnly = true;
            this.txtTongChiNgay.Size = new System.Drawing.Size(99, 32);
            this.txtTongChiNgay.TabIndex = 38;
            // 
            // txtChenhLech
            // 
            this.txtChenhLech.Location = new System.Drawing.Point(199, 161);
            this.txtChenhLech.Margin = new System.Windows.Forms.Padding(2);
            this.txtChenhLech.Name = "txtChenhLech";
            this.txtChenhLech.ReadOnly = true;
            this.txtChenhLech.Size = new System.Drawing.Size(161, 32);
            this.txtChenhLech.TabIndex = 37;
            // 
            // txtTongThuNgay
            // 
            this.txtTongThuNgay.Location = new System.Drawing.Point(199, 82);
            this.txtTongThuNgay.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongThuNgay.Name = "txtTongThuNgay";
            this.txtTongThuNgay.ReadOnly = true;
            this.txtTongThuNgay.Size = new System.Drawing.Size(99, 32);
            this.txtTongThuNgay.TabIndex = 36;
            // 
            // lblChenhLech
            // 
            this.lblChenhLech.AutoSize = true;
            this.lblChenhLech.BackColor = System.Drawing.Color.CadetBlue;
            this.lblChenhLech.ForeColor = System.Drawing.Color.White;
            this.lblChenhLech.Location = new System.Drawing.Point(41, 167);
            this.lblChenhLech.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChenhLech.Name = "lblChenhLech";
            this.lblChenhLech.Size = new System.Drawing.Size(113, 24);
            this.lblChenhLech.TabIndex = 41;
            this.lblChenhLech.Text = "Chênh Lệch";
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCao.Location = new System.Drawing.Point(6, 227);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.Size = new System.Drawing.Size(851, 270);
            this.dgvBaoCao.TabIndex = 49;
            // 
            // cmbNam
            // 
            this.cmbNam.FormattingEnabled = true;
            this.cmbNam.Location = new System.Drawing.Point(669, 41);
            this.cmbNam.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNam.Name = "cmbNam";
            this.cmbNam.Size = new System.Drawing.Size(47, 32);
            this.cmbNam.TabIndex = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbNam);
            this.groupBox1.Controls.Add(this.dgvBaoCao);
            this.groupBox1.Controls.Add(this.dtpTuNgay);
            this.groupBox1.Controls.Add(this.lblLTK);
            this.groupBox1.Controls.Add(this.cmbLoaiTietKiem);
            this.groupBox1.Controls.Add(this.lblDenNgay);
            this.groupBox1.Controls.Add(this.lblTuNgay);
            this.groupBox1.Controls.Add(this.cmbThang);
            this.groupBox1.Controls.Add(this.lblThang);
            this.groupBox1.Controls.Add(this.dtpDenNgay);
            this.groupBox1.Controls.Add(this.lblTongSoMo);
            this.groupBox1.Controls.Add(this.lblTongSoDong);
            this.groupBox1.Controls.Add(this.txtTongChiNgay);
            this.groupBox1.Controls.Add(this.txtChenhLech);
            this.groupBox1.Controls.Add(this.txtTongThuNgay);
            this.groupBox1.Controls.Add(this.lblChenhLech);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(863, 505);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.ForeColor = System.Drawing.Color.Black;
            this.btnTraCuu.Image = global::QLSTK.Properties.Resources.icons8_view_32;
            this.btnTraCuu.Location = new System.Drawing.Point(490, 646);
            this.btnTraCuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(146, 50);
            this.btnTraCuu.TabIndex = 53;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTraCuu.UseVisualStyleBackColor = false;
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.BackColor = System.Drawing.Color.DarkCyan;
            this.btnXuatFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatFile.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.ForeColor = System.Drawing.Color.Black;
            this.btnXuatFile.Image = global::QLSTK.Properties.Resources.icons8_print_32;
            this.btnXuatFile.Location = new System.Drawing.Point(215, 646);
            this.btnXuatFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(146, 50);
            this.btnXuatFile.TabIndex = 52;
            this.btnXuatFile.Text = "Xuất file";
            this.btnXuatFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXuatFile.UseVisualStyleBackColor = false;
            // 
            // frmBaoCaoMoDongSoThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(882, 703);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBaoMoDongSoThang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmBaoCaoMoDongSoThang";
            this.Text = "frmBaoCaoDoanhSoThang";
            this.Load += new System.EventHandler(this.frmBaoCaoDoanhSoThang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ComboBox cmbThang;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label lblTongSoMo;
        private System.Windows.Forms.Label lblTongSoDong;
        private System.Windows.Forms.TextBox txtTongChiNgay;
        private System.Windows.Forms.TextBox txtChenhLech;
        private System.Windows.Forms.TextBox txtTongThuNgay;
        private System.Windows.Forms.Label lblChenhLech;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.ComboBox cmbNam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btnXuatFile;
    }
}