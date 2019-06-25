namespace QLSTK
{
    partial class SplashScreen1
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
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblTrangThai = new DevExpress.XtraEditors.LabelControl();
            this.lblStart = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnDangNhap = new System.Windows.Forms.Panel();
            this.lblTroVe = new System.Windows.Forms.Label();
            this.lbnMatKhauMoi = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lblDoiMatKhau = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.lblThoat = new System.Windows.Forms.Label();
            this.lbnMatKhau = new System.Windows.Forms.Label();
            this.lblTrangThaiMK = new System.Windows.Forms.Label();
            this.lbnID = new System.Windows.Forms.Label();
            this.tbtNhapLaiMatKhau = new System.Windows.Forms.TextBox();
            this.tbtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.tbtMatKhau = new System.Windows.Forms.TextBox();
            this.tbtTaiKhoan = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::QLSTK.Properties.Resources._9331;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(3, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(663, 358);
            this.pbLogo.TabIndex = 14;
            this.pbLogo.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.progressBar1.Location = new System.Drawing.Point(4, 396);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(663, 10);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 15;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Appearance.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblTrangThai.Appearance.Options.UseFont = true;
            this.lblTrangThai.Appearance.Options.UseForeColor = true;
            this.lblTrangThai.Location = new System.Drawing.Point(252, 420);
            this.lblTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(151, 21);
            this.lblTrangThai.TabIndex = 17;
            this.lblTrangThai.Text = "Kết nối cơ sở dữ liệu";
            // 
            // lblStart
            // 
            this.lblStart.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Appearance.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblStart.Appearance.Options.UseFont = true;
            this.lblStart.Appearance.Options.UseForeColor = true;
            this.lblStart.Location = new System.Drawing.Point(4, 368);
            this.lblStart.Margin = new System.Windows.Forms.Padding(4);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(73, 21);
            this.lblStart.TabIndex = 16;
            this.lblStart.Text = "Starting...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BackgroundImage = global::QLSTK.Properties.Resources._90440;
            this.panel1.Controls.Add(this.pnDangNhap);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.lblTrangThai);
            this.panel1.Controls.Add(this.lblStart);
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 545);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // pnDangNhap
            // 
            this.pnDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.pnDangNhap.Controls.Add(this.lblTroVe);
            this.pnDangNhap.Controls.Add(this.lbnMatKhauMoi);
            this.pnDangNhap.Controls.Add(this.btnOK);
            this.pnDangNhap.Controls.Add(this.btnDangNhap);
            this.pnDangNhap.Controls.Add(this.lblDoiMatKhau);
            this.pnDangNhap.Controls.Add(this.Label5);
            this.pnDangNhap.Controls.Add(this.lblThoat);
            this.pnDangNhap.Controls.Add(this.lbnMatKhau);
            this.pnDangNhap.Controls.Add(this.lblTrangThaiMK);
            this.pnDangNhap.Controls.Add(this.lbnID);
            this.pnDangNhap.Controls.Add(this.tbtNhapLaiMatKhau);
            this.pnDangNhap.Controls.Add(this.tbtMatKhauMoi);
            this.pnDangNhap.Controls.Add(this.tbtMatKhau);
            this.pnDangNhap.Controls.Add(this.tbtTaiKhoan);
            this.pnDangNhap.Controls.Add(this.Label10);
            this.pnDangNhap.Location = new System.Drawing.Point(673, 3);
            this.pnDangNhap.Name = "pnDangNhap";
            this.pnDangNhap.Size = new System.Drawing.Size(330, 536);
            this.pnDangNhap.TabIndex = 18;
            // 
            // lblTroVe
            // 
            this.lblTroVe.AutoSize = true;
            this.lblTroVe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroVe.ForeColor = System.Drawing.Color.White;
            this.lblTroVe.Location = new System.Drawing.Point(10, 499);
            this.lblTroVe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTroVe.Name = "lblTroVe";
            this.lblTroVe.Size = new System.Drawing.Size(64, 28);
            this.lblTroVe.TabIndex = 21;
            this.lblTroVe.Text = "Trở về";
            this.lblTroVe.Click += new System.EventHandler(this.LblTroVe_Click);
            // 
            // lbnMatKhauMoi
            // 
            this.lbnMatKhauMoi.AutoSize = true;
            this.lbnMatKhauMoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnMatKhauMoi.ForeColor = System.Drawing.Color.White;
            this.lbnMatKhauMoi.Location = new System.Drawing.Point(9, 242);
            this.lbnMatKhauMoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnMatKhauMoi.Name = "lbnMatKhauMoi";
            this.lbnMatKhauMoi.Size = new System.Drawing.Size(133, 28);
            this.lbnMatKhauMoi.TabIndex = 20;
            this.lbnMatKhauMoi.Text = "Mật khẩu mới";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.LightGray;
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(51, 446);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(239, 34);
            this.btnOK.TabIndex = 18;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.LightGray;
            this.btnDangNhap.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(51, 446);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(239, 34);
            this.btnDangNhap.TabIndex = 17;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.BtnDangNhap_Click);
            // 
            // lblDoiMatKhau
            // 
            this.lblDoiMatKhau.AutoSize = true;
            this.lblDoiMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.lblDoiMatKhau.Location = new System.Drawing.Point(10, 499);
            this.lblDoiMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoiMatKhau.Name = "lblDoiMatKhau";
            this.lblDoiMatKhau.Size = new System.Drawing.Size(129, 28);
            this.lblDoiMatKhau.TabIndex = 13;
            this.lblDoiMatKhau.Text = "Đổi mật khẩu";
            this.lblDoiMatKhau.Click += new System.EventHandler(this.LblDoiMatKhau_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(12, 499);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(64, 28);
            this.Label5.TabIndex = 14;
            this.Label5.Text = "Trở về";
            // 
            // lblThoat
            // 
            this.lblThoat.AutoSize = true;
            this.lblThoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoat.ForeColor = System.Drawing.Color.White;
            this.lblThoat.Location = new System.Drawing.Point(256, 499);
            this.lblThoat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThoat.Name = "lblThoat";
            this.lblThoat.Size = new System.Drawing.Size(62, 28);
            this.lblThoat.TabIndex = 15;
            this.lblThoat.Text = "Thoát";
            this.lblThoat.Click += new System.EventHandler(this.LblThoat_Click);
            // 
            // lbnMatKhau
            // 
            this.lbnMatKhau.AutoSize = true;
            this.lbnMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnMatKhau.ForeColor = System.Drawing.Color.White;
            this.lbnMatKhau.Location = new System.Drawing.Point(8, 158);
            this.lbnMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnMatKhau.Name = "lbnMatKhau";
            this.lbnMatKhau.Size = new System.Drawing.Size(98, 28);
            this.lbnMatKhau.TabIndex = 7;
            this.lbnMatKhau.Text = "Mật khẩu:";
            // 
            // lblTrangThaiMK
            // 
            this.lblTrangThaiMK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThaiMK.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblTrangThaiMK.Location = new System.Drawing.Point(23, 393);
            this.lblTrangThaiMK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrangThaiMK.Name = "lblTrangThaiMK";
            this.lblTrangThaiMK.Size = new System.Drawing.Size(293, 29);
            this.lblTrangThaiMK.TabIndex = 8;
            this.lblTrangThaiMK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbnID
            // 
            this.lbnID.AutoSize = true;
            this.lbnID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnID.ForeColor = System.Drawing.Color.White;
            this.lbnID.Location = new System.Drawing.Point(8, 69);
            this.lbnID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnID.Name = "lbnID";
            this.lbnID.Size = new System.Drawing.Size(147, 28);
            this.lbnID.TabIndex = 9;
            this.lbnID.Text = "ID Người dùng:";
            // 
            // tbtNhapLaiMatKhau
            // 
            this.tbtNhapLaiMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbtNhapLaiMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtNhapLaiMatKhau.Location = new System.Drawing.Point(14, 327);
            this.tbtNhapLaiMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.tbtNhapLaiMatKhau.MaxLength = 8;
            this.tbtNhapLaiMatKhau.Name = "tbtNhapLaiMatKhau";
            this.tbtNhapLaiMatKhau.PasswordChar = '*';
            this.tbtNhapLaiMatKhau.Size = new System.Drawing.Size(304, 34);
            this.tbtNhapLaiMatKhau.TabIndex = 16;
            this.tbtNhapLaiMatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbtMatKhauMoi
            // 
            this.tbtMatKhauMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbtMatKhauMoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtMatKhauMoi.Location = new System.Drawing.Point(13, 285);
            this.tbtMatKhauMoi.Margin = new System.Windows.Forms.Padding(4);
            this.tbtMatKhauMoi.MaxLength = 8;
            this.tbtMatKhauMoi.Name = "tbtMatKhauMoi";
            this.tbtMatKhauMoi.PasswordChar = '*';
            this.tbtMatKhauMoi.Size = new System.Drawing.Size(304, 34);
            this.tbtMatKhauMoi.TabIndex = 12;
            this.tbtMatKhauMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbtMatKhau
            // 
            this.tbtMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbtMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtMatKhau.Location = new System.Drawing.Point(14, 197);
            this.tbtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.tbtMatKhau.MaxLength = 8;
            this.tbtMatKhau.Name = "tbtMatKhau";
            this.tbtMatKhau.PasswordChar = '*';
            this.tbtMatKhau.Size = new System.Drawing.Size(304, 34);
            this.tbtMatKhau.TabIndex = 11;
            this.tbtMatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbtMatKhau.UseSystemPasswordChar = true;
            // 
            // tbtTaiKhoan
            // 
            this.tbtTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbtTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtTaiKhoan.Location = new System.Drawing.Point(14, 109);
            this.tbtTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.tbtTaiKhoan.Name = "tbtTaiKhoan";
            this.tbtTaiKhoan.Size = new System.Drawing.Size(304, 34);
            this.tbtTaiKhoan.TabIndex = 10;
            this.tbtTaiKhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.White;
            this.Label10.Location = new System.Drawing.Point(75, 16);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(176, 37);
            this.Label10.TabIndex = 6;
            this.Label10.Text = "ĐĂNG NHẬP";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // SplashScreen1
            // 
            this.ActiveGlowColor = System.Drawing.Color.Transparent;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 545);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SplashScreen1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SplashScreen1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnDangNhap.ResumeLayout(false);
            this.pnDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private DevExpress.XtraEditors.LabelControl lblTrangThai;
        private DevExpress.XtraEditors.LabelControl lblStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnDangNhap;
        internal System.Windows.Forms.Label lblTroVe;
        internal System.Windows.Forms.Label lbnMatKhauMoi;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnDangNhap;
        internal System.Windows.Forms.Label lblDoiMatKhau;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label lblThoat;
        internal System.Windows.Forms.Label lbnMatKhau;
        internal System.Windows.Forms.Label lblTrangThaiMK;
        internal System.Windows.Forms.Label lbnID;
        internal System.Windows.Forms.TextBox tbtNhapLaiMatKhau;
        internal System.Windows.Forms.TextBox tbtMatKhauMoi;
        internal System.Windows.Forms.TextBox tbtMatKhau;
        internal System.Windows.Forms.TextBox tbtTaiKhoan;
        internal System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Timer timer1;
    }
}
