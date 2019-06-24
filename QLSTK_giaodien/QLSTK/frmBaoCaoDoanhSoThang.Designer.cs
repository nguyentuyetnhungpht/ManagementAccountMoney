namespace QLSTK
{
    partial class frmBaoCaoDoanhSoThang
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
            this.pnlBaoCaoThang = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoMo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChenhLech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTongSoMo = new System.Windows.Forms.Label();
            this.lblTongSoDong = new System.Windows.Forms.Label();
            this.txtTongChiNgay = new System.Windows.Forms.TextBox();
            this.txtChenhLech = new System.Windows.Forms.TextBox();
            this.txtTongThuNgay = new System.Windows.Forms.TextBox();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.lblChenhLech = new System.Windows.Forms.Label();
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
            this.pnlBaoCaoThang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBaoCaoThang
            // 
            this.pnlBaoCaoThang.BackColor = System.Drawing.Color.Transparent;
            this.pnlBaoCaoThang.BackgroundImage = global::QLSTK.Properties.Resources._90440;
            this.pnlBaoCaoThang.Controls.Add(this.btn_exit);
            this.pnlBaoCaoThang.Controls.Add(this.dataGridView1);
            this.pnlBaoCaoThang.Controls.Add(this.lblTongSoMo);
            this.pnlBaoCaoThang.Controls.Add(this.lblTongSoDong);
            this.pnlBaoCaoThang.Controls.Add(this.txtTongChiNgay);
            this.pnlBaoCaoThang.Controls.Add(this.txtChenhLech);
            this.pnlBaoCaoThang.Controls.Add(this.txtTongThuNgay);
            this.pnlBaoCaoThang.Controls.Add(this.btnTraCuu);
            this.pnlBaoCaoThang.Controls.Add(this.lblChenhLech);
            this.pnlBaoCaoThang.Controls.Add(this.lblBaoMoDongSoThang);
            this.pnlBaoCaoThang.Controls.Add(this.dtpTuNgay);
            this.pnlBaoCaoThang.Controls.Add(this.lblLTK);
            this.pnlBaoCaoThang.Controls.Add(this.cmbLoaiTietKiem);
            this.pnlBaoCaoThang.Controls.Add(this.lblDenNgay);
            this.pnlBaoCaoThang.Controls.Add(this.lblTuNgay);
            this.pnlBaoCaoThang.Controls.Add(this.btnXuatFile);
            this.pnlBaoCaoThang.Controls.Add(this.cmbThang);
            this.pnlBaoCaoThang.Controls.Add(this.lblThang);
            this.pnlBaoCaoThang.Controls.Add(this.dtpDenNgay);
            this.pnlBaoCaoThang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBaoCaoThang.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBaoCaoThang.ForeColor = System.Drawing.Color.White;
            this.pnlBaoCaoThang.Location = new System.Drawing.Point(0, 0);
            this.pnlBaoCaoThang.Name = "pnlBaoCaoThang";
            this.pnlBaoCaoThang.Size = new System.Drawing.Size(734, 542);
            this.pnlBaoCaoThang.TabIndex = 67;
            this.pnlBaoCaoThang.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlBaoCaoThang_Paint);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.BackgroundImage = global::QLSTK.Properties.Resources.icons8_close_window_481;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.ForeColor = System.Drawing.Color.Transparent;
            this.btn_exit.Location = new System.Drawing.Point(698, 8);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(24, 22);
            this.btn_exit.TabIndex = 68;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.Ngay,
            this.SoDong,
            this.SoMo,
            this.ChenhLech});
            this.dataGridView1.Location = new System.Drawing.Point(0, 270);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(734, 271);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(734, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(734, 271);
            this.dataGridView1.TabIndex = 67;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            // 
            // Ngay
            // 
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.Name = "Ngay";
            // 
            // SoDong
            // 
            this.SoDong.HeaderText = "Sổ đóng";
            this.SoDong.Name = "SoDong";
            // 
            // SoMo
            // 
            this.SoMo.HeaderText = "Sổ mở";
            this.SoMo.Name = "SoMo";
            // 
            // ChenhLech
            // 
            this.ChenhLech.HeaderText = "Chênh lệch";
            this.ChenhLech.Name = "ChenhLech";
            // 
            // lblTongSoMo
            // 
            this.lblTongSoMo.AutoSize = true;
            this.lblTongSoMo.BackColor = System.Drawing.Color.Transparent;
            this.lblTongSoMo.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSoMo.ForeColor = System.Drawing.Color.White;
            this.lblTongSoMo.Location = new System.Drawing.Point(16, 181);
            this.lblTongSoMo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongSoMo.Name = "lblTongSoMo";
            this.lblTongSoMo.Size = new System.Drawing.Size(109, 23);
            this.lblTongSoMo.TabIndex = 58;
            this.lblTongSoMo.Text = "Tổng sổ mở";
            // 
            // lblTongSoDong
            // 
            this.lblTongSoDong.AutoSize = true;
            this.lblTongSoDong.BackColor = System.Drawing.Color.Transparent;
            this.lblTongSoDong.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSoDong.ForeColor = System.Drawing.Color.White;
            this.lblTongSoDong.Location = new System.Drawing.Point(16, 140);
            this.lblTongSoDong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongSoDong.Name = "lblTongSoDong";
            this.lblTongSoDong.Size = new System.Drawing.Size(126, 23);
            this.lblTongSoDong.TabIndex = 57;
            this.lblTongSoDong.Text = "Tổng sổ đóng";
            // 
            // txtTongChiNgay
            // 
            this.txtTongChiNgay.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongChiNgay.Location = new System.Drawing.Point(146, 174);
            this.txtTongChiNgay.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongChiNgay.Name = "txtTongChiNgay";
            this.txtTongChiNgay.ReadOnly = true;
            this.txtTongChiNgay.Size = new System.Drawing.Size(150, 29);
            this.txtTongChiNgay.TabIndex = 56;
            // 
            // txtChenhLech
            // 
            this.txtChenhLech.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChenhLech.Location = new System.Drawing.Point(146, 214);
            this.txtChenhLech.Margin = new System.Windows.Forms.Padding(2);
            this.txtChenhLech.Name = "txtChenhLech";
            this.txtChenhLech.ReadOnly = true;
            this.txtChenhLech.Size = new System.Drawing.Size(150, 29);
            this.txtChenhLech.TabIndex = 55;
            // 
            // txtTongThuNgay
            // 
            this.txtTongThuNgay.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongThuNgay.Location = new System.Drawing.Point(146, 134);
            this.txtTongThuNgay.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongThuNgay.Name = "txtTongThuNgay";
            this.txtTongThuNgay.ReadOnly = true;
            this.txtTongThuNgay.Size = new System.Drawing.Size(150, 29);
            this.txtTongThuNgay.TabIndex = 54;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.ForeColor = System.Drawing.Color.Black;
            this.btnTraCuu.Image = global::QLSTK.Properties.Resources.icons8_search_26;
            this.btnTraCuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraCuu.Location = new System.Drawing.Point(400, 208);
            this.btnTraCuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(127, 34);
            this.btnTraCuu.TabIndex = 53;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTraCuu.UseVisualStyleBackColor = false;
            this.btnTraCuu.Click += new System.EventHandler(this.BtnTraCuu_Click);
            // 
            // lblChenhLech
            // 
            this.lblChenhLech.AutoSize = true;
            this.lblChenhLech.BackColor = System.Drawing.Color.Transparent;
            this.lblChenhLech.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChenhLech.ForeColor = System.Drawing.Color.White;
            this.lblChenhLech.Location = new System.Drawing.Point(16, 221);
            this.lblChenhLech.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChenhLech.Name = "lblChenhLech";
            this.lblChenhLech.Size = new System.Drawing.Size(109, 23);
            this.lblChenhLech.TabIndex = 59;
            this.lblChenhLech.Text = "Chênh Lệch";
            // 
            // lblBaoMoDongSoThang
            // 
            this.lblBaoMoDongSoThang.AutoEllipsis = true;
            this.lblBaoMoDongSoThang.AutoSize = true;
            this.lblBaoMoDongSoThang.BackColor = System.Drawing.Color.Transparent;
            this.lblBaoMoDongSoThang.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaoMoDongSoThang.ForeColor = System.Drawing.Color.White;
            this.lblBaoMoDongSoThang.Location = new System.Drawing.Point(362, 3);
            this.lblBaoMoDongSoThang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBaoMoDongSoThang.Name = "lblBaoMoDongSoThang";
            this.lblBaoMoDongSoThang.Size = new System.Drawing.Size(316, 27);
            this.lblBaoMoDongSoThang.TabIndex = 66;
            this.lblBaoMoDongSoThang.Text = "Báo cáo mở/ đóng sổ tháng";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(534, 93);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(145, 29);
            this.dtpTuNgay.TabIndex = 64;
            // 
            // lblLTK
            // 
            this.lblLTK.AutoSize = true;
            this.lblLTK.BackColor = System.Drawing.Color.Transparent;
            this.lblLTK.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLTK.ForeColor = System.Drawing.Color.White;
            this.lblLTK.Location = new System.Drawing.Point(396, 163);
            this.lblLTK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLTK.Name = "lblLTK";
            this.lblLTK.Size = new System.Drawing.Size(120, 23);
            this.lblLTK.TabIndex = 63;
            this.lblLTK.Text = "Loại tiết kiệm";
            // 
            // cmbLoaiTietKiem
            // 
            this.cmbLoaiTietKiem.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoaiTietKiem.FormattingEnabled = true;
            this.cmbLoaiTietKiem.Location = new System.Drawing.Point(535, 155);
            this.cmbLoaiTietKiem.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLoaiTietKiem.Name = "cmbLoaiTietKiem";
            this.cmbLoaiTietKiem.Size = new System.Drawing.Size(145, 30);
            this.cmbLoaiTietKiem.TabIndex = 62;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoEllipsis = true;
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.BackColor = System.Drawing.Color.Transparent;
            this.lblDenNgay.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenNgay.ForeColor = System.Drawing.Color.White;
            this.lblDenNgay.Location = new System.Drawing.Point(396, 131);
            this.lblDenNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(91, 23);
            this.lblDenNgay.TabIndex = 61;
            this.lblDenNgay.Text = "Đến ngày";
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoEllipsis = true;
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.BackColor = System.Drawing.Color.Transparent;
            this.lblTuNgay.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuNgay.ForeColor = System.Drawing.Color.White;
            this.lblTuNgay.Location = new System.Drawing.Point(396, 96);
            this.lblTuNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(80, 23);
            this.lblTuNgay.TabIndex = 60;
            this.lblTuNgay.Text = "Từ ngày";
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.BackColor = System.Drawing.Color.DarkCyan;
            this.btnXuatFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatFile.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.ForeColor = System.Drawing.Color.Black;
            this.btnXuatFile.Image = global::QLSTK.Properties.Resources.icons8_export_26;
            this.btnXuatFile.Location = new System.Drawing.Point(553, 207);
            this.btnXuatFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(127, 35);
            this.btnXuatFile.TabIndex = 51;
            this.btnXuatFile.Text = "Xuất file";
            this.btnXuatFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXuatFile.UseVisualStyleBackColor = false;
            // 
            // cmbThang
            // 
            this.cmbThang.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbThang.FormattingEnabled = true;
            this.cmbThang.Location = new System.Drawing.Point(146, 93);
            this.cmbThang.Margin = new System.Windows.Forms.Padding(2);
            this.cmbThang.Name = "cmbThang";
            this.cmbThang.Size = new System.Drawing.Size(150, 30);
            this.cmbThang.TabIndex = 50;
            // 
            // lblThang
            // 
            this.lblThang.AutoEllipsis = true;
            this.lblThang.AutoSize = true;
            this.lblThang.BackColor = System.Drawing.Color.Transparent;
            this.lblThang.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThang.ForeColor = System.Drawing.Color.White;
            this.lblThang.Location = new System.Drawing.Point(16, 102);
            this.lblThang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(64, 23);
            this.lblThang.TabIndex = 49;
            this.lblThang.Text = "Tháng";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(535, 124);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(145, 29);
            this.dtpDenNgay.TabIndex = 65;
            // 
            // frmBaoCaoDoanhSoThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 542);
            this.Controls.Add(this.pnlBaoCaoThang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(734, 542);
            this.MinimumSize = new System.Drawing.Size(734, 542);
            this.Name = "frmBaoCaoDoanhSoThang";
            this.Text = "frmBaoCaoDoanhSoThang";
            this.pnlBaoCaoThang.ResumeLayout(false);
            this.pnlBaoCaoThang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTongSoMo;
        private System.Windows.Forms.Label lblTongSoDong;
        private System.Windows.Forms.TextBox txtTongChiNgay;
        private System.Windows.Forms.TextBox txtChenhLech;
        private System.Windows.Forms.TextBox txtTongThuNgay;
        private System.Windows.Forms.Label lblChenhLech;
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
        private System.Windows.Forms.Panel pnlBaoCaoThang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoMo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChenhLech;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btn_exit;
    }
}