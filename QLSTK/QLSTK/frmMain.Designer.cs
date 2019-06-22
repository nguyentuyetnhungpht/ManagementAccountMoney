namespace QLSTK
{
    partial class frmMain
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
            this.tsTaoBaoCaoNgay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCapNhatBaoCaoNgay = new System.Windows.Forms.ToolStripMenuItem();
            this.tstaoBaoCaoThang = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCapNhatBaoCaoThang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsQuanLyHeThong,
            this.tsQuanLySo,
            this.tsLapPhieu,
            this.tsLapBaoCao,
            this.tsAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsQuanLyHeThong
            // 
            this.tsQuanLyHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsThayDoiQuyDinh,
            this.thôngBáoToolStripMenuItem});
            this.tsQuanLyHeThong.Name = "tsQuanLyHeThong";
            this.tsQuanLyHeThong.Size = new System.Drawing.Size(111, 20);
            this.tsQuanLyHeThong.Text = "Quản lý hệ thống";
            // 
            // tsThayDoiQuyDinh
            // 
            this.tsThayDoiQuyDinh.Name = "tsThayDoiQuyDinh";
            this.tsThayDoiQuyDinh.Size = new System.Drawing.Size(170, 22);
            this.tsThayDoiQuyDinh.Text = "Thay đổi quy định";
            this.tsThayDoiQuyDinh.Click += new System.EventHandler(this.tsThayDoiQuyDinh_Click);
            // 
            // thôngBáoToolStripMenuItem
            // 
            this.thôngBáoToolStripMenuItem.Name = "thôngBáoToolStripMenuItem";
            this.thôngBáoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.thôngBáoToolStripMenuItem.Text = "Thông báo";
            // 
            // tsQuanLySo
            // 
            this.tsQuanLySo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLapSoMoi,
            this.tsTraCuuSo,
            this.tsThongTinKhachHang});
            this.tsQuanLySo.Name = "tsQuanLySo";
            this.tsQuanLySo.Size = new System.Drawing.Size(75, 20);
            this.tsQuanLySo.Text = "Quản lý sổ";
            // 
            // tsLapSoMoi
            // 
            this.tsLapSoMoi.Name = "tsLapSoMoi";
            this.tsLapSoMoi.Size = new System.Drawing.Size(191, 22);
            this.tsLapSoMoi.Text = "Lập sổ mới";
            this.tsLapSoMoi.Click += new System.EventHandler(this.tsLapSoMoi_Click);
            // 
            // tsTraCuuSo
            // 
            this.tsTraCuuSo.Name = "tsTraCuuSo";
            this.tsTraCuuSo.Size = new System.Drawing.Size(191, 22);
            this.tsTraCuuSo.Text = "Tra cứu sổ";
            this.tsTraCuuSo.Click += new System.EventHandler(this.tsTraCuuSo_Click_1);
            // 
            // tsThongTinKhachHang
            // 
            this.tsThongTinKhachHang.Name = "tsThongTinKhachHang";
            this.tsThongTinKhachHang.Size = new System.Drawing.Size(191, 22);
            this.tsThongTinKhachHang.Text = "Thông tin khách hàng";
            this.tsThongTinKhachHang.Click += new System.EventHandler(this.tsThongTinKhachHang_Click);
            // 
            // tsLapPhieu
            // 
            this.tsLapPhieu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLapPhieuGuiTien,
            this.tsLapPhieuRutTien});
            this.tsLapPhieu.Name = "tsLapPhieu";
            this.tsLapPhieu.Size = new System.Drawing.Size(71, 20);
            this.tsLapPhieu.Text = "Lập phiếu";
            // 
            // tsLapPhieuGuiTien
            // 
            this.tsLapPhieuGuiTien.Name = "tsLapPhieuGuiTien";
            this.tsLapPhieuGuiTien.Size = new System.Drawing.Size(169, 22);
            this.tsLapPhieuGuiTien.Text = "Lập phiếu gửi tiền";
            this.tsLapPhieuGuiTien.Click += new System.EventHandler(this.tsLapPhieuGuiTien_Click_1);
            // 
            // tsLapPhieuRutTien
            // 
            this.tsLapPhieuRutTien.Name = "tsLapPhieuRutTien";
            this.tsLapPhieuRutTien.Size = new System.Drawing.Size(169, 22);
            this.tsLapPhieuRutTien.Text = "Lập phiếu rút tiền";
            this.tsLapPhieuRutTien.Click += new System.EventHandler(this.tsLapPhieuRutTien_Click_1);
            // 
            // tsLapBaoCao
            // 
            this.tsLapBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBaoCaoDoanhSoNgay,
            this.tsBaoCaoMoDongSoThang});
            this.tsLapBaoCao.Name = "tsLapBaoCao";
            this.tsLapBaoCao.Size = new System.Drawing.Size(83, 20);
            this.tsLapBaoCao.Text = "Lập báo cáo";
            // 
            // tsBaoCaoDoanhSoNgay
            // 
            this.tsBaoCaoDoanhSoNgay.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTaoBaoCaoNgay,
            this.tsCapNhatBaoCaoNgay});
            this.tsBaoCaoDoanhSoNgay.Name = "tsBaoCaoDoanhSoNgay";
            this.tsBaoCaoDoanhSoNgay.Size = new System.Drawing.Size(219, 22);
            this.tsBaoCaoDoanhSoNgay.Text = "Báo cáo doanh số ngày";
            this.tsBaoCaoDoanhSoNgay.Click += new System.EventHandler(this.tsBaoCaoDoanhSoNgay_Click);
            // 
            // tsBaoCaoMoDongSoThang
            // 
            this.tsBaoCaoMoDongSoThang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstaoBaoCaoThang,
            this.tsCapNhatBaoCaoThang});
            this.tsBaoCaoMoDongSoThang.Name = "tsBaoCaoMoDongSoThang";
            this.tsBaoCaoMoDongSoThang.Size = new System.Drawing.Size(219, 22);
            this.tsBaoCaoMoDongSoThang.Text = "Báo cáo mở/đóng sổ tháng";
            this.tsBaoCaoMoDongSoThang.Click += new System.EventHandler(this.tsBaoCaoMoDongSoThang_Click);
            // 
            // tsAbout
            // 
            this.tsAbout.Name = "tsAbout";
            this.tsAbout.Size = new System.Drawing.Size(52, 20);
            this.tsAbout.Text = "About";
            // 
            // tsTaoBaoCaoNgay
            // 
            this.tsTaoBaoCaoNgay.Name = "tsTaoBaoCaoNgay";
            this.tsTaoBaoCaoNgay.Size = new System.Drawing.Size(196, 22);
            this.tsTaoBaoCaoNgay.Text = "Tạo báo cáo ngày";
            this.tsTaoBaoCaoNgay.Click += new System.EventHandler(this.tsTaoBaoCaoNgay_Click);
            // 
            // tsCapNhatBaoCaoNgay
            // 
            this.tsCapNhatBaoCaoNgay.Name = "tsCapNhatBaoCaoNgay";
            this.tsCapNhatBaoCaoNgay.Size = new System.Drawing.Size(196, 22);
            this.tsCapNhatBaoCaoNgay.Text = "Cập nhật báo cáo ngày";
            this.tsCapNhatBaoCaoNgay.Click += new System.EventHandler(this.tsCapNhatBaoCaoNgay_Click);
            // 
            // tstaoBaoCaoThang
            // 
            this.tstaoBaoCaoThang.Name = "tstaoBaoCaoThang";
            this.tstaoBaoCaoThang.Size = new System.Drawing.Size(201, 22);
            this.tstaoBaoCaoThang.Text = "Tạo báo cáo tháng";
            this.tstaoBaoCaoThang.Click += new System.EventHandler(this.tstaoBaoCaoThang_Click);
            // 
            // tsCapNhatBaoCaoThang
            // 
            this.tsCapNhatBaoCaoThang.Name = "tsCapNhatBaoCaoThang";
            this.tsCapNhatBaoCaoThang.Size = new System.Drawing.Size(201, 22);
            this.tsCapNhatBaoCaoThang.Text = "Cập nhật báo cáo tháng";
            this.tsCapNhatBaoCaoThang.Click += new System.EventHandler(this.tsCapNhatBaoCaoThang_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 500);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Quản lý sổ tiết kiệm";
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
        private System.Windows.Forms.ToolStripMenuItem tsTaoBaoCaoNgay;
        private System.Windows.Forms.ToolStripMenuItem tsCapNhatBaoCaoNgay;
        private System.Windows.Forms.ToolStripMenuItem tstaoBaoCaoThang;
        private System.Windows.Forms.ToolStripMenuItem tsCapNhatBaoCaoThang;
    }
}

