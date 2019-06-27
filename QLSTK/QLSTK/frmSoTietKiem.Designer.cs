namespace QLSTK
{
    partial class frmSoTietKiem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtMaSoSTK = new System.Windows.Forms.TextBox();
            this.btnBrower = new System.Windows.Forms.Button();
            this.picKhachHang = new System.Windows.Forms.PictureBox();
            this.cmbLoaiTietKiem = new System.Windows.Forms.ComboBox();
            this.txtNgayMoSo = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtSoTienGui = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblNgayMoSo = new System.Windows.Forms.Label();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblLoaiTietKiem = new System.Windows.Forms.Label();
            this.lblSoTienGui = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblMaSo = new System.Windows.Forms.Label();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.btnDongSo = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblSoTietKiem = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.txtMaSoSTK);
            this.groupBox1.Controls.Add(this.btnBrower);
            this.groupBox1.Controls.Add(this.picKhachHang);
            this.groupBox1.Controls.Add(this.cmbLoaiTietKiem);
            this.groupBox1.Controls.Add(this.txtNgayMoSo);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.txtSoTienGui);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.lblNgayMoSo);
            this.groupBox1.Controls.Add(this.lblCMND);
            this.groupBox1.Controls.Add(this.lblLoaiTietKiem);
            this.groupBox1.Controls.Add(this.lblSoTienGui);
            this.groupBox1.Controls.Add(this.lblDiaChi);
            this.groupBox1.Controls.Add(this.lblMaSo);
            this.groupBox1.Controls.Add(this.lblKhachHang);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 461);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // txtMaKH
            // 
            this.txtMaKH.ForeColor = System.Drawing.Color.Black;
            this.txtMaKH.Location = new System.Drawing.Point(186, 136);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(203, 32);
            this.txtMaKH.TabIndex = 45;
            this.txtMaKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMaKH_KeyPress);
            // 
            // txtMaSoSTK
            // 
            this.txtMaSoSTK.ForeColor = System.Drawing.Color.Black;
            this.txtMaSoSTK.Location = new System.Drawing.Point(186, 89);
            this.txtMaSoSTK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaSoSTK.Name = "txtMaSoSTK";
            this.txtMaSoSTK.Size = new System.Drawing.Size(155, 32);
            this.txtMaSoSTK.TabIndex = 43;
            // 
            // btnBrower
            // 
            this.btnBrower.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBrower.ForeColor = System.Drawing.Color.LightCoral;
            this.btnBrower.Location = new System.Drawing.Point(596, 358);
            this.btnBrower.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBrower.Name = "btnBrower";
            this.btnBrower.Size = new System.Drawing.Size(125, 45);
            this.btnBrower.TabIndex = 42;
            this.btnBrower.Text = "Brower...";
            this.btnBrower.UseVisualStyleBackColor = false;
            // 
            // picKhachHang
            // 
            this.picKhachHang.Location = new System.Drawing.Point(520, 89);
            this.picKhachHang.Margin = new System.Windows.Forms.Padding(6);
            this.picKhachHang.Name = "picKhachHang";
            this.picKhachHang.Size = new System.Drawing.Size(201, 231);
            this.picKhachHang.TabIndex = 41;
            this.picKhachHang.TabStop = false;
            // 
            // cmbLoaiTietKiem
            // 
            this.cmbLoaiTietKiem.ForeColor = System.Drawing.Color.Black;
            this.cmbLoaiTietKiem.FormattingEnabled = true;
            this.cmbLoaiTietKiem.Location = new System.Drawing.Point(186, 324);
            this.cmbLoaiTietKiem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbLoaiTietKiem.Name = "cmbLoaiTietKiem";
            this.cmbLoaiTietKiem.Size = new System.Drawing.Size(155, 32);
            this.cmbLoaiTietKiem.TabIndex = 36;
            // 
            // txtNgayMoSo
            // 
            this.txtNgayMoSo.ForeColor = System.Drawing.Color.Black;
            this.txtNgayMoSo.Location = new System.Drawing.Point(186, 371);
            this.txtNgayMoSo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNgayMoSo.Name = "txtNgayMoSo";
            this.txtNgayMoSo.ReadOnly = true;
            this.txtNgayMoSo.Size = new System.Drawing.Size(155, 32);
            this.txtNgayMoSo.TabIndex = 34;
            // 
            // txtCMND
            // 
            this.txtCMND.ForeColor = System.Drawing.Color.Black;
            this.txtCMND.Location = new System.Drawing.Point(186, 183);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(203, 32);
            this.txtCMND.TabIndex = 33;
            this.txtCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCMND_KeyPress);
            // 
            // txtSoTienGui
            // 
            this.txtSoTienGui.ForeColor = System.Drawing.Color.Black;
            this.txtSoTienGui.Location = new System.Drawing.Point(186, 277);
            this.txtSoTienGui.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSoTienGui.Name = "txtSoTienGui";
            this.txtSoTienGui.Size = new System.Drawing.Size(203, 32);
            this.txtSoTienGui.TabIndex = 32;
            this.txtSoTienGui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSoTienGui_KeyPress);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.ForeColor = System.Drawing.Color.Black;
            this.txtDiaChi.Location = new System.Drawing.Point(186, 230);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(289, 32);
            this.txtDiaChi.TabIndex = 31;
            // 
            // lblNgayMoSo
            // 
            this.lblNgayMoSo.AutoSize = true;
            this.lblNgayMoSo.BackColor = System.Drawing.Color.CadetBlue;
            this.lblNgayMoSo.ForeColor = System.Drawing.Color.White;
            this.lblNgayMoSo.Location = new System.Drawing.Point(37, 374);
            this.lblNgayMoSo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayMoSo.Name = "lblNgayMoSo";
            this.lblNgayMoSo.Size = new System.Drawing.Size(115, 24);
            this.lblNgayMoSo.TabIndex = 30;
            this.lblNgayMoSo.Text = "Ngày mở sổ";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.BackColor = System.Drawing.Color.CadetBlue;
            this.lblCMND.ForeColor = System.Drawing.Color.White;
            this.lblCMND.Location = new System.Drawing.Point(88, 190);
            this.lblCMND.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(64, 24);
            this.lblCMND.TabIndex = 29;
            this.lblCMND.Text = "CMND";
            // 
            // lblLoaiTietKiem
            // 
            this.lblLoaiTietKiem.AutoSize = true;
            this.lblLoaiTietKiem.BackColor = System.Drawing.Color.CadetBlue;
            this.lblLoaiTietKiem.ForeColor = System.Drawing.Color.White;
            this.lblLoaiTietKiem.Location = new System.Drawing.Point(13, 328);
            this.lblLoaiTietKiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoaiTietKiem.Name = "lblLoaiTietKiem";
            this.lblLoaiTietKiem.Size = new System.Drawing.Size(139, 24);
            this.lblLoaiTietKiem.TabIndex = 28;
            this.lblLoaiTietKiem.Text = "Loại Tiết Kiệm";
            // 
            // lblSoTienGui
            // 
            this.lblSoTienGui.AutoSize = true;
            this.lblSoTienGui.BackColor = System.Drawing.Color.CadetBlue;
            this.lblSoTienGui.ForeColor = System.Drawing.Color.White;
            this.lblSoTienGui.Location = new System.Drawing.Point(46, 282);
            this.lblSoTienGui.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoTienGui.Name = "lblSoTienGui";
            this.lblSoTienGui.Size = new System.Drawing.Size(106, 24);
            this.lblSoTienGui.TabIndex = 27;
            this.lblSoTienGui.Text = "Số tiền gửi";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.BackColor = System.Drawing.Color.CadetBlue;
            this.lblDiaChi.ForeColor = System.Drawing.Color.White;
            this.lblDiaChi.Location = new System.Drawing.Point(81, 236);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(71, 24);
            this.lblDiaChi.TabIndex = 26;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblMaSo
            // 
            this.lblMaSo.AutoSize = true;
            this.lblMaSo.ForeColor = System.Drawing.Color.IndianRed;
            this.lblMaSo.Location = new System.Drawing.Point(90, 98);
            this.lblMaSo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaSo.Name = "lblMaSo";
            this.lblMaSo.Size = new System.Drawing.Size(62, 24);
            this.lblMaSo.TabIndex = 25;
            this.lblMaSo.Text = "Mã sổ";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.BackColor = System.Drawing.Color.CadetBlue;
            this.lblKhachHang.ForeColor = System.Drawing.Color.White;
            this.lblKhachHang.Location = new System.Drawing.Point(38, 144);
            this.lblKhachHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(114, 24);
            this.lblKhachHang.TabIndex = 24;
            this.lblKhachHang.Text = "Khách hàng";
            // 
            // btnDongSo
            // 
            this.btnDongSo.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDongSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDongSo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongSo.ForeColor = System.Drawing.Color.Black;
            this.btnDongSo.Image = global::QLSTK.Properties.Resources.icons8_remove_32;
            this.btnDongSo.Location = new System.Drawing.Point(312, 599);
            this.btnDongSo.Margin = new System.Windows.Forms.Padding(6);
            this.btnDongSo.Name = "btnDongSo";
            this.btnDongSo.Size = new System.Drawing.Size(146, 50);
            this.btnDongSo.TabIndex = 50;
            this.btnDongSo.Text = "Đóng sổ";
            this.btnDongSo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDongSo.UseVisualStyleBackColor = false;
            this.btnDongSo.Click += new System.EventHandler(this.BtnDongSo_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.DarkCyan;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.Image = global::QLSTK.Properties.Resources.icons8_exit_32;
            this.btnHuy.Location = new System.Drawing.Point(532, 599);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(146, 50);
            this.btnHuy.TabIndex = 49;
            this.btnHuy.Text = "Thoát";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // lblSoTietKiem
            // 
            this.lblSoTietKiem.AutoSize = true;
            this.lblSoTietKiem.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTietKiem.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSoTietKiem.Location = new System.Drawing.Point(262, 30);
            this.lblSoTietKiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoTietKiem.Name = "lblSoTietKiem";
            this.lblSoTietKiem.Size = new System.Drawing.Size(263, 36);
            this.lblSoTietKiem.TabIndex = 48;
            this.lblSoTietKiem.Text = "LẬP SỔ TIẾT KIỆM";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DarkCyan;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = global::QLSTK.Properties.Resources.icons8_add_book_32;
            this.btnThem.Location = new System.Drawing.Point(89, 600);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(146, 50);
            this.btnThem.TabIndex = 47;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // frmSoTietKiem
            // 
            this.Appearance.BackColor = System.Drawing.Color.CadetBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 682);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDongSo);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.lblSoTietKiem);
            this.Controls.Add(this.btnThem);
            this.Name = "frmSoTietKiem";
            this.Text = "frmSTK";
            this.Load += new System.EventHandler(this.FrmSTK_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtMaSoSTK;
        private System.Windows.Forms.Button btnBrower;
        private System.Windows.Forms.PictureBox picKhachHang;
        private System.Windows.Forms.ComboBox cmbLoaiTietKiem;
        private System.Windows.Forms.TextBox txtNgayMoSo;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtSoTienGui;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblNgayMoSo;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblLoaiTietKiem;
        private System.Windows.Forms.Label lblSoTienGui;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblMaSo;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Button btnDongSo;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblSoTietKiem;
        private System.Windows.Forms.Button btnThem;
    }
}