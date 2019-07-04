namespace QLSTK
{
    partial class frmTraCuu
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
            this.components = new System.ComponentModel.Container();
            this.cmbMaLTK = new System.Windows.Forms.ComboBox();
            this.cmbMaKH = new System.Windows.Forms.ComboBox();
            this.cmbMaSo = new System.Windows.Forms.ComboBox();
            this.lbKhachHang = new System.Windows.Forms.Label();
            this.lbLoaiTietKiem = new System.Windows.Forms.Label();
            this.lbMaSo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpToiNgay = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMinSoDu = new System.Windows.Forms.TextBox();
            this.txtMaxSoDu = new System.Windows.Forms.TextBox();
            this.dgvSoTietKiem = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsThongTinSoTietKiem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoTietKiem)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbMaLTK
            // 
            this.cmbMaLTK.FormattingEnabled = true;
            this.cmbMaLTK.Location = new System.Drawing.Point(170, 202);
            this.cmbMaLTK.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMaLTK.Name = "cmbMaLTK";
            this.cmbMaLTK.Size = new System.Drawing.Size(133, 21);
            this.cmbMaLTK.TabIndex = 14;
            // 
            // cmbMaKH
            // 
            this.cmbMaKH.FormattingEnabled = true;
            this.cmbMaKH.Location = new System.Drawing.Point(170, 167);
            this.cmbMaKH.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMaKH.Name = "cmbMaKH";
            this.cmbMaKH.Size = new System.Drawing.Size(133, 21);
            this.cmbMaKH.TabIndex = 13;
            // 
            // cmbMaSo
            // 
            this.cmbMaSo.FormattingEnabled = true;
            this.cmbMaSo.Location = new System.Drawing.Point(170, 132);
            this.cmbMaSo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMaSo.Name = "cmbMaSo";
            this.cmbMaSo.Size = new System.Drawing.Size(133, 21);
            this.cmbMaSo.TabIndex = 12;
            // 
            // lbKhachHang
            // 
            this.lbKhachHang.AutoSize = true;
            this.lbKhachHang.Location = new System.Drawing.Point(80, 175);
            this.lbKhachHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbKhachHang.Name = "lbKhachHang";
            this.lbKhachHang.Size = new System.Drawing.Size(82, 13);
            this.lbKhachHang.TabIndex = 11;
            this.lbKhachHang.Text = "Mã khách hàng";
            // 
            // lbLoaiTietKiem
            // 
            this.lbLoaiTietKiem.AutoSize = true;
            this.lbLoaiTietKiem.Location = new System.Drawing.Point(79, 210);
            this.lbLoaiTietKiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLoaiTietKiem.Name = "lbLoaiTietKiem";
            this.lbLoaiTietKiem.Size = new System.Drawing.Size(69, 13);
            this.lbLoaiTietKiem.TabIndex = 10;
            this.lbLoaiTietKiem.Text = "Loại tiết kiệm";
            // 
            // lbMaSo
            // 
            this.lbMaSo.AutoSize = true;
            this.lbMaSo.Location = new System.Drawing.Point(81, 132);
            this.lbMaSo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaSo.Name = "lbMaSo";
            this.lbMaSo.Size = new System.Drawing.Size(36, 13);
            this.lbMaSo.TabIndex = 9;
            this.lbMaSo.Text = "Mã sổ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Danh sách sổ tiết kiệm";
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(472, 210);
            this.btnTraCuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(91, 20);
            this.btnTraCuu.TabIndex = 16;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(472, 165);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(83, 20);
            this.dtpTuNgay.TabIndex = 18;
            this.dtpTuNgay.Value = new System.DateTime(1990, 6, 1, 22, 47, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ngày mở sổ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Từ ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(571, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Đến ngày";
            // 
            // dtpToiNgay
            // 
            this.dtpToiNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToiNgay.Location = new System.Drawing.Point(629, 164);
            this.dtpToiNgay.Name = "dtpToiNgay";
            this.dtpToiNgay.Size = new System.Drawing.Size(88, 20);
            this.dtpToiNgay.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(571, 135);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Đến ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 137);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Từ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(354, 136);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Số dư";
            // 
            // txtMinSoDu
            // 
            this.txtMinSoDu.Location = new System.Drawing.Point(472, 131);
            this.txtMinSoDu.Name = "txtMinSoDu";
            this.txtMinSoDu.Size = new System.Drawing.Size(83, 20);
            this.txtMinSoDu.TabIndex = 28;
            // 
            // txtMaxSoDu
            // 
            this.txtMaxSoDu.Location = new System.Drawing.Point(629, 129);
            this.txtMaxSoDu.Name = "txtMaxSoDu";
            this.txtMaxSoDu.Size = new System.Drawing.Size(88, 20);
            this.txtMaxSoDu.TabIndex = 29;
            // 
            // dgvSoTietKiem
            // 
            this.dgvSoTietKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoTietKiem.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvSoTietKiem.Location = new System.Drawing.Point(84, 274);
            this.dgvSoTietKiem.Name = "dgvSoTietKiem";
            this.dgvSoTietKiem.Size = new System.Drawing.Size(633, 164);
            this.dgvSoTietKiem.TabIndex = 30;
            this.dgvSoTietKiem.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvSoTietKiem_RowPostPaint);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsThongTinSoTietKiem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(191, 26);
            // 
            // tsThongTinSoTietKiem
            // 
            this.tsThongTinSoTietKiem.Name = "tsThongTinSoTietKiem";
            this.tsThongTinSoTietKiem.Size = new System.Drawing.Size(190, 22);
            this.tsThongTinSoTietKiem.Text = "Thông tin sổ tiết kiệm";
            this.tsThongTinSoTietKiem.Click += new System.EventHandler(this.cmsXoaSTK_Click);
            // 
            // frmTraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.dgvSoTietKiem);
            this.Controls.Add(this.txtMaxSoDu);
            this.Controls.Add(this.txtMinSoDu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpToiNgay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.cmbMaLTK);
            this.Controls.Add(this.cmbMaKH);
            this.Controls.Add(this.cmbMaSo);
            this.Controls.Add(this.lbKhachHang);
            this.Controls.Add(this.lbLoaiTietKiem);
            this.Controls.Add(this.lbMaSo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTraCuu);
            this.Name = "frmTraCuu";
            this.Text = "Tra cứu sổ";
            this.Load += new System.EventHandler(this.frmTraCuu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoTietKiem)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbMaLTK;
        private System.Windows.Forms.ComboBox cmbMaKH;
        private System.Windows.Forms.ComboBox cmbMaSo;
        private System.Windows.Forms.Label lbKhachHang;
        private System.Windows.Forms.Label lbLoaiTietKiem;
        private System.Windows.Forms.Label lbMaSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpToiNgay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMinSoDu;
        private System.Windows.Forms.TextBox txtMaxSoDu;
        private System.Windows.Forms.DataGridView dgvSoTietKiem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsThongTinSoTietKiem;
    }
}