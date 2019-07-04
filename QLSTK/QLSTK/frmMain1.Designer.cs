namespace QLSTK
{
    partial class frmMain1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsQuanLyHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsThayDoiQuyDinh = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngBáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsQuanLySo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLapSoMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTraCuuSo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsThongTinKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLapPhieu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLapPhieuGuiTien = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLapPhieuRutTien = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLapBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBaoCaoDoanhSoNgay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBaoCaoMoDongSoThang = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsQuanLyHeThong,
            this.tsQuanLySo,
            this.tsLapPhieu,
            this.tsLapBaoCao,
            this.tsAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1173, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsQuanLyHeThong
            // 
            this.tsQuanLyHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsThayDoiQuyDinh,
            this.thôngBáoToolStripMenuItem});
            this.tsQuanLyHeThong.Name = "tsQuanLyHeThong";
            this.tsQuanLyHeThong.Size = new System.Drawing.Size(134, 24);
            this.tsQuanLyHeThong.Text = "Quản lý hệ thống";
            // 
            // tsThayDoiQuyDinh
            // 
            this.tsThayDoiQuyDinh.Name = "tsThayDoiQuyDinh";
            this.tsThayDoiQuyDinh.Size = new System.Drawing.Size(216, 26);
            this.tsThayDoiQuyDinh.Text = "Thay đổi quy định";
            this.tsThayDoiQuyDinh.Click += new System.EventHandler(this.tsThayDoiQuyDinh_Click);
            // 
            // thôngBáoToolStripMenuItem
            // 
            this.thôngBáoToolStripMenuItem.Name = "thôngBáoToolStripMenuItem";
            this.thôngBáoToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.thôngBáoToolStripMenuItem.Text = "Thông báo";
            // 
            // tsQuanLySo
            // 
            this.tsQuanLySo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLapSoMoi,
            this.tsTraCuuSo,
            this.tsThongTinKhachHang});
            this.tsQuanLySo.Name = "tsQuanLySo";
            this.tsQuanLySo.Size = new System.Drawing.Size(90, 24);
            this.tsQuanLySo.Text = "Quản lý sổ";
            // 
            // tsLapSoMoi
            // 
            this.tsLapSoMoi.Name = "tsLapSoMoi";
            this.tsLapSoMoi.Size = new System.Drawing.Size(226, 26);
            this.tsLapSoMoi.Text = "Lập sổ mới";
            this.tsLapSoMoi.Click += new System.EventHandler(this.tsLapSoMoi_Click);
            // 
            // tsTraCuuSo
            // 
            this.tsTraCuuSo.Name = "tsTraCuuSo";
            this.tsTraCuuSo.Size = new System.Drawing.Size(226, 26);
            this.tsTraCuuSo.Text = "Tra cứu sổ";
            this.tsTraCuuSo.Click += new System.EventHandler(this.tsTraCuuSo_Click_1);
            // 
            // tsThongTinKhachHang
            // 
            this.tsThongTinKhachHang.Name = "tsThongTinKhachHang";
            this.tsThongTinKhachHang.Size = new System.Drawing.Size(226, 26);
            this.tsThongTinKhachHang.Text = "Thông tin khách hàng";
            this.tsThongTinKhachHang.Click += new System.EventHandler(this.tsThongTinKhachHang_Click);
            // 
            // tsLapPhieu
            // 
            this.tsLapPhieu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLapPhieuGuiTien,
            this.tsLapPhieuRutTien});
            this.tsLapPhieu.Name = "tsLapPhieu";
            this.tsLapPhieu.Size = new System.Drawing.Size(86, 24);
            this.tsLapPhieu.Text = "Lập phiếu";
            // 
            // tsLapPhieuGuiTien
            // 
            this.tsLapPhieuGuiTien.Name = "tsLapPhieuGuiTien";
            this.tsLapPhieuGuiTien.Size = new System.Drawing.Size(216, 26);
            this.tsLapPhieuGuiTien.Text = "Lập phiếu gửi tiền";
            this.tsLapPhieuGuiTien.Click += new System.EventHandler(this.tsLapPhieuGuiTien_Click_1);
            // 
            // tsLapPhieuRutTien
            // 
            this.tsLapPhieuRutTien.Name = "tsLapPhieuRutTien";
            this.tsLapPhieuRutTien.Size = new System.Drawing.Size(216, 26);
            this.tsLapPhieuRutTien.Text = "Lập phiếu rút tiền";
            this.tsLapPhieuRutTien.Click += new System.EventHandler(this.tsLapPhieuRutTien_Click_1);
            // 
            // tsLapBaoCao
            // 
            this.tsLapBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBaoCaoDoanhSoNgay,
            this.tsBaoCaoMoDongSoThang});
            this.tsLapBaoCao.Name = "tsLapBaoCao";
            this.tsLapBaoCao.Size = new System.Drawing.Size(103, 24);
            this.tsLapBaoCao.Text = "Lập báo cáo";
            // 
            // tsBaoCaoDoanhSoNgay
            // 
            this.tsBaoCaoDoanhSoNgay.Name = "tsBaoCaoDoanhSoNgay";
            this.tsBaoCaoDoanhSoNgay.Size = new System.Drawing.Size(266, 26);
            this.tsBaoCaoDoanhSoNgay.Text = "Báo cáo doanh số ngày";
            this.tsBaoCaoDoanhSoNgay.Click += new System.EventHandler(this.tsBaoCaoDoanhSoNgay_Click);
            // 
            // tsBaoCaoMoDongSoThang
            // 
            this.tsBaoCaoMoDongSoThang.Name = "tsBaoCaoMoDongSoThang";
            this.tsBaoCaoMoDongSoThang.Size = new System.Drawing.Size(266, 26);
            this.tsBaoCaoMoDongSoThang.Text = "Báo cáo mở/đóng sổ tháng";
            this.tsBaoCaoMoDongSoThang.Click += new System.EventHandler(this.tsBaoCaoMoDongSoThang_Click);
            // 
            // tsAbout
            // 
            this.tsAbout.Name = "tsAbout";
            this.tsAbout.Size = new System.Drawing.Size(62, 24);
            this.tsAbout.Text = "About";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 615);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Quản lý sổ tiết kiệm";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsQuanLyHeThong;
        private System.Windows.Forms.ToolStripMenuItem tsQuanLySo;
        private System.Windows.Forms.ToolStripMenuItem tsLapSoMoi;
        private System.Windows.Forms.ToolStripMenuItem tsAbout;
        private System.Windows.Forms.ToolStripMenuItem tsThayDoiQuyDinh;
        private System.Windows.Forms.ToolStripMenuItem tsTraCuuSo;
        private System.Windows.Forms.ToolStripMenuItem tsLapPhieu;
        private System.Windows.Forms.ToolStripMenuItem tsLapPhieuGuiTien;
        private System.Windows.Forms.ToolStripMenuItem tsLapPhieuRutTien;
        private System.Windows.Forms.ToolStripMenuItem tsLapBaoCao;
        private System.Windows.Forms.ToolStripMenuItem tsBaoCaoDoanhSoNgay;
        private System.Windows.Forms.ToolStripMenuItem tsBaoCaoMoDongSoThang;
        private System.Windows.Forms.ToolStripMenuItem thôngBáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsThongTinKhachHang;
    }
}

