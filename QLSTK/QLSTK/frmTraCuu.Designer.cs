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
            this.cmbMaLoaiTietKiem = new System.Windows.Forms.ComboBox();
            this.cmbMaKH = new System.Windows.Forms.ComboBox();
            this.cmbMaSo = new System.Windows.Forms.ComboBox();
            this.lbKhachHang = new System.Windows.Forms.Label();
            this.lbLoaiTietKiem = new System.Windows.Forms.Label();
            this.lbMaSo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpToiNgay = new System.Windows.Forms.DateTimePicker();
            this.dgvSoTietKiem = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsSuaSTK = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsXoaSTK = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaxSoDu = new System.Windows.Forms.TextBox();
            this.txtMinSoDu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoTietKiem)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbMaLoaiTietKiem
            // 
            this.cmbMaLoaiTietKiem.FormattingEnabled = true;
            this.cmbMaLoaiTietKiem.Location = new System.Drawing.Point(224, 138);
            this.cmbMaLoaiTietKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMaLoaiTietKiem.Name = "cmbMaLoaiTietKiem";
            this.cmbMaLoaiTietKiem.Size = new System.Drawing.Size(176, 32);
            this.cmbMaLoaiTietKiem.TabIndex = 14;
            this.cmbMaLoaiTietKiem.SelectedIndexChanged += new System.EventHandler(this.CmbMaLoaiTietKiem_SelectedIndexChanged);
            // 
            // cmbMaKH
            // 
            this.cmbMaKH.FormattingEnabled = true;
            this.cmbMaKH.Location = new System.Drawing.Point(224, 95);
            this.cmbMaKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMaKH.Name = "cmbMaKH";
            this.cmbMaKH.Size = new System.Drawing.Size(176, 32);
            this.cmbMaKH.TabIndex = 13;
            this.cmbMaKH.SelectedIndexChanged += new System.EventHandler(this.CmbMaKH_SelectedIndexChanged);
            // 
            // cmbMaSo
            // 
            this.cmbMaSo.FormattingEnabled = true;
            this.cmbMaSo.Location = new System.Drawing.Point(224, 51);
            this.cmbMaSo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMaSo.Name = "cmbMaSo";
            this.cmbMaSo.Size = new System.Drawing.Size(176, 32);
            this.cmbMaSo.TabIndex = 12;
            this.cmbMaSo.SelectedIndexChanged += new System.EventHandler(this.CmbMaSo_SelectedIndexChanged);
            // 
            // lbKhachHang
            // 
            this.lbKhachHang.AutoSize = true;
            this.lbKhachHang.ForeColor = System.Drawing.Color.White;
            this.lbKhachHang.Location = new System.Drawing.Point(29, 102);
            this.lbKhachHang.Name = "lbKhachHang";
            this.lbKhachHang.Size = new System.Drawing.Size(144, 24);
            this.lbKhachHang.TabIndex = 11;
            this.lbKhachHang.Text = "Mã khách hàng";
            // 
            // lbLoaiTietKiem
            // 
            this.lbLoaiTietKiem.AutoSize = true;
            this.lbLoaiTietKiem.ForeColor = System.Drawing.Color.White;
            this.lbLoaiTietKiem.Location = new System.Drawing.Point(41, 146);
            this.lbLoaiTietKiem.Name = "lbLoaiTietKiem";
            this.lbLoaiTietKiem.Size = new System.Drawing.Size(132, 24);
            this.lbLoaiTietKiem.TabIndex = 10;
            this.lbLoaiTietKiem.Text = "Loại tiết kiệm";
            // 
            // lbMaSo
            // 
            this.lbMaSo.AutoSize = true;
            this.lbMaSo.ForeColor = System.Drawing.Color.IndianRed;
            this.lbMaSo.Location = new System.Drawing.Point(111, 58);
            this.lbMaSo.Name = "lbMaSo";
            this.lbMaSo.Size = new System.Drawing.Size(62, 24);
            this.lbMaSo.TabIndex = 9;
            this.lbMaSo.Text = "Mã sổ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(307, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "Danh sách sổ tiết kiệm";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(633, 89);
            this.dtpTuNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(157, 32);
            this.dtpTuNgay.TabIndex = 18;
            this.dtpTuNgay.Value = new System.DateTime(1990, 6, 1, 22, 47, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(506, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ngày mở sổ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(506, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Từ ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(506, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Đến ngày";
            // 
            // dtpToiNgay
            // 
            this.dtpToiNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToiNgay.Location = new System.Drawing.Point(633, 135);
            this.dtpToiNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpToiNgay.Name = "dtpToiNgay";
            this.dtpToiNgay.Size = new System.Drawing.Size(157, 32);
            this.dtpToiNgay.TabIndex = 23;
            // 
            // dgvSoTietKiem
            // 
            this.dgvSoTietKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoTietKiem.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvSoTietKiem.Location = new System.Drawing.Point(6, 250);
            this.dgvSoTietKiem.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSoTietKiem.Name = "dgvSoTietKiem";
            this.dgvSoTietKiem.Size = new System.Drawing.Size(850, 248);
            this.dgvSoTietKiem.TabIndex = 30;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsSuaSTK,
            this.cmsXoaSTK});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(186, 52);
            // 
            // cmsSuaSTK
            // 
            this.cmsSuaSTK.Name = "cmsSuaSTK";
            this.cmsSuaSTK.Size = new System.Drawing.Size(185, 24);
            this.cmsSuaSTK.Text = "Sửa sổ tiết kiệm";
            this.cmsSuaSTK.Click += new System.EventHandler(this.cmsSuaSTK_Click);
            // 
            // cmsXoaSTK
            // 
            this.cmsXoaSTK.Name = "cmsXoaSTK";
            this.cmsXoaSTK.Size = new System.Drawing.Size(185, 24);
            this.cmsXoaSTK.Text = "Xóa sổ tiết kiệm";
            this.cmsXoaSTK.Click += new System.EventHandler(this.cmsXoaSTK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSoTietKiem);
            this.groupBox1.Controls.Add(this.txtMaxSoDu);
            this.groupBox1.Controls.Add(this.txtMinSoDu);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtpToiNgay);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpTuNgay);
            this.groupBox1.Controls.Add(this.cmbMaLoaiTietKiem);
            this.groupBox1.Controls.Add(this.cmbMaKH);
            this.groupBox1.Controls.Add(this.cmbMaSo);
            this.groupBox1.Controls.Add(this.lbKhachHang);
            this.groupBox1.Controls.Add(this.lbLoaiTietKiem);
            this.groupBox1.Controls.Add(this.lbMaSo);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(863, 505);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // txtMaxSoDu
            // 
            this.txtMaxSoDu.Location = new System.Drawing.Point(329, 188);
            this.txtMaxSoDu.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaxSoDu.Name = "txtMaxSoDu";
            this.txtMaxSoDu.Size = new System.Drawing.Size(71, 32);
            this.txtMaxSoDu.TabIndex = 29;
            this.txtMaxSoDu.TextChanged += new System.EventHandler(this.TxtMaxSoDu_TextChanged);
            // 
            // txtMinSoDu
            // 
            this.txtMinSoDu.Location = new System.Drawing.Point(224, 188);
            this.txtMinSoDu.Margin = new System.Windows.Forms.Padding(4);
            this.txtMinSoDu.Name = "txtMinSoDu";
            this.txtMinSoDu.Size = new System.Drawing.Size(71, 32);
            this.txtMinSoDu.TabIndex = 28;
            this.txtMinSoDu.TextChanged += new System.EventHandler(this.TxtMinSoDu_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(112, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 24);
            this.label8.TabIndex = 25;
            this.label8.Text = "Số dư";
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.Image = global::QLSTK.Properties.Resources.icons8_view_32;
            this.btnTraCuu.Location = new System.Drawing.Point(281, 632);
            this.btnTraCuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(146, 50);
            this.btnTraCuu.TabIndex = 16;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTraCuu.UseVisualStyleBackColor = false;
            this.btnTraCuu.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DarkCyan;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::QLSTK.Properties.Resources.icons8_exit_32;
            this.btnThoat.Location = new System.Drawing.Point(467, 632);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(146, 50);
            this.btnThoat.TabIndex = 32;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // frmTraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(882, 703);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTraCuu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTraCuu";
            this.Text = "Tra cứu sổ";
            this.Load += new System.EventHandler(this.frmTraCuu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoTietKiem)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbMaLoaiTietKiem;
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
        private System.Windows.Forms.DataGridView dgvSoTietKiem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsSuaSTK;
        private System.Windows.Forms.ToolStripMenuItem cmsXoaSTK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaxSoDu;
        private System.Windows.Forms.TextBox txtMinSoDu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnThoat;
    }
}