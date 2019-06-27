namespace QLSTK
{
    partial class frmBaoCaoDoanhSoNgay
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
            this.lblbaoCaoDoanhSoNgay = new System.Windows.Forms.Label();
            this.dtpNgayBaoCao = new System.Windows.Forms.DateTimePicker();
            this.lbChenhLech = new System.Windows.Forms.Label();
            this.lbTongChiNgay = new System.Windows.Forms.Label();
            this.lbTongThuNgay = new System.Windows.Forms.Label();
            this.txtTongChiNgay = new System.Windows.Forms.TextBox();
            this.txtChenhLech = new System.Windows.Forms.TextBox();
            this.txtTongThuNgay = new System.Windows.Forms.TextBox();
            this.lbNgay = new System.Windows.Forms.Label();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnTaoBaoCao = new System.Windows.Forms.Button();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.btnXuatFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblbaoCaoDoanhSoNgay
            // 
            this.lblbaoCaoDoanhSoNgay.AutoEllipsis = true;
            this.lblbaoCaoDoanhSoNgay.AutoSize = true;
            this.lblbaoCaoDoanhSoNgay.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbaoCaoDoanhSoNgay.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblbaoCaoDoanhSoNgay.Location = new System.Drawing.Point(270, 9);
            this.lblbaoCaoDoanhSoNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbaoCaoDoanhSoNgay.Name = "lblbaoCaoDoanhSoNgay";
            this.lblbaoCaoDoanhSoNgay.Size = new System.Drawing.Size(324, 36);
            this.lblbaoCaoDoanhSoNgay.TabIndex = 36;
            this.lblbaoCaoDoanhSoNgay.Text = "Báo cáo doanh số ngày";
            // 
            // dtpNgayBaoCao
            // 
            this.dtpNgayBaoCao.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpNgayBaoCao.CustomFormat = "";
            this.dtpNgayBaoCao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBaoCao.Location = new System.Drawing.Point(203, 53);
            this.dtpNgayBaoCao.Name = "dtpNgayBaoCao";
            this.dtpNgayBaoCao.Size = new System.Drawing.Size(117, 23);
            this.dtpNgayBaoCao.TabIndex = 35;
            // 
            // lbChenhLech
            // 
            this.lbChenhLech.AutoSize = true;
            this.lbChenhLech.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChenhLech.ForeColor = System.Drawing.Color.White;
            this.lbChenhLech.Location = new System.Drawing.Point(37, 99);
            this.lbChenhLech.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbChenhLech.Name = "lbChenhLech";
            this.lbChenhLech.Size = new System.Drawing.Size(113, 24);
            this.lbChenhLech.TabIndex = 34;
            this.lbChenhLech.Text = "Chênh Lệch";
            // 
            // lbTongChiNgay
            // 
            this.lbTongChiNgay.AutoSize = true;
            this.lbTongChiNgay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongChiNgay.ForeColor = System.Drawing.Color.White;
            this.lbTongChiNgay.Location = new System.Drawing.Point(447, 45);
            this.lbTongChiNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTongChiNgay.Name = "lbTongChiNgay";
            this.lbTongChiNgay.Size = new System.Drawing.Size(135, 24);
            this.lbTongChiNgay.TabIndex = 33;
            this.lbTongChiNgay.Text = "Tổng chi ngày";
            // 
            // lbTongThuNgay
            // 
            this.lbTongThuNgay.AutoSize = true;
            this.lbTongThuNgay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongThuNgay.ForeColor = System.Drawing.Color.White;
            this.lbTongThuNgay.Location = new System.Drawing.Point(443, 99);
            this.lbTongThuNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTongThuNgay.Name = "lbTongThuNgay";
            this.lbTongThuNgay.Size = new System.Drawing.Size(139, 24);
            this.lbTongThuNgay.TabIndex = 32;
            this.lbTongThuNgay.Text = "Tổng thu ngày";
            // 
            // txtTongChiNgay
            // 
            this.txtTongChiNgay.Location = new System.Drawing.Point(624, 48);
            this.txtTongChiNgay.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongChiNgay.Name = "txtTongChiNgay";
            this.txtTongChiNgay.ReadOnly = true;
            this.txtTongChiNgay.Size = new System.Drawing.Size(199, 23);
            this.txtTongChiNgay.TabIndex = 31;
            // 
            // txtChenhLech
            // 
            this.txtChenhLech.Location = new System.Drawing.Point(203, 102);
            this.txtChenhLech.Margin = new System.Windows.Forms.Padding(2);
            this.txtChenhLech.Name = "txtChenhLech";
            this.txtChenhLech.ReadOnly = true;
            this.txtChenhLech.Size = new System.Drawing.Size(199, 23);
            this.txtChenhLech.TabIndex = 30;
            // 
            // txtTongThuNgay
            // 
            this.txtTongThuNgay.Location = new System.Drawing.Point(624, 102);
            this.txtTongThuNgay.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongThuNgay.Name = "txtTongThuNgay";
            this.txtTongThuNgay.ReadOnly = true;
            this.txtTongThuNgay.Size = new System.Drawing.Size(199, 23);
            this.txtTongThuNgay.TabIndex = 29;
            // 
            // lbNgay
            // 
            this.lbNgay.AutoEllipsis = true;
            this.lbNgay.AutoSize = true;
            this.lbNgay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgay.ForeColor = System.Drawing.Color.White;
            this.lbNgay.Location = new System.Drawing.Point(95, 52);
            this.lbNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(55, 24);
            this.lbNgay.TabIndex = 25;
            this.lbNgay.Text = "Ngày";
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCao.Location = new System.Drawing.Point(6, 153);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.Size = new System.Drawing.Size(851, 313);
            this.dgvBaoCao.TabIndex = 37;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvBaoCao);
            this.groupBox1.Controls.Add(this.dtpNgayBaoCao);
            this.groupBox1.Controls.Add(this.lbChenhLech);
            this.groupBox1.Controls.Add(this.lbTongChiNgay);
            this.groupBox1.Controls.Add(this.lbTongThuNgay);
            this.groupBox1.Controls.Add(this.txtTongChiNgay);
            this.groupBox1.Controls.Add(this.txtChenhLech);
            this.groupBox1.Controls.Add(this.txtTongThuNgay);
            this.groupBox1.Controls.Add(this.lbNgay);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(863, 472);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Image = global::QLSTK.Properties.Resources.icons8_update_32;
            this.btnCapNhat.Location = new System.Drawing.Point(99, 632);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(171, 50);
            this.btnCapNhat.TabIndex = 40;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.BtnCapNhat_Click);
            // 
            // btnTaoBaoCao
            // 
            this.btnTaoBaoCao.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTaoBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoBaoCao.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoBaoCao.Image = global::QLSTK.Properties.Resources.icons8_create_32;
            this.btnTaoBaoCao.Location = new System.Drawing.Point(619, 632);
            this.btnTaoBaoCao.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaoBaoCao.Name = "btnTaoBaoCao";
            this.btnTaoBaoCao.Size = new System.Drawing.Size(171, 50);
            this.btnTaoBaoCao.TabIndex = 39;
            this.btnTaoBaoCao.Text = "Tạo";
            this.btnTaoBaoCao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaoBaoCao.UseVisualStyleBackColor = false;
            this.btnTaoBaoCao.Click += new System.EventHandler(this.BtnTaoBaoCao_Click);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.Image = global::QLSTK.Properties.Resources.icons8_view_32;
            this.btnTraCuu.Location = new System.Drawing.Point(454, 632);
            this.btnTraCuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(146, 50);
            this.btnTraCuu.TabIndex = 28;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTraCuu.UseVisualStyleBackColor = false;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.BackColor = System.Drawing.Color.DarkCyan;
            this.btnXuatFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatFile.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.Image = global::QLSTK.Properties.Resources.icons8_print_32;
            this.btnXuatFile.Location = new System.Drawing.Point(289, 632);
            this.btnXuatFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(146, 50);
            this.btnXuatFile.TabIndex = 26;
            this.btnXuatFile.Text = "Xuất file";
            this.btnXuatFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXuatFile.UseVisualStyleBackColor = false;
            // 
            // frmBaoCaoDoanhSoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(882, 703);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnTaoBaoCao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblbaoCaoDoanhSoNgay);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.btnXuatFile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBaoCaoDoanhSoNgay";
            this.Text = "frmBaoCaoDoanhSoNgay";
            this.Load += new System.EventHandler(this.frmBaoCaoDoanhSoNgay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbaoCaoDoanhSoNgay;
        private System.Windows.Forms.DateTimePicker dtpNgayBaoCao;
        private System.Windows.Forms.Label lbChenhLech;
        private System.Windows.Forms.Label lbTongChiNgay;
        private System.Windows.Forms.Label lbTongThuNgay;
        private System.Windows.Forms.TextBox txtTongChiNgay;
        private System.Windows.Forms.TextBox txtChenhLech;
        private System.Windows.Forms.TextBox txtTongThuNgay;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTaoBaoCao;
        private System.Windows.Forms.Button btnCapNhat;
    }
}