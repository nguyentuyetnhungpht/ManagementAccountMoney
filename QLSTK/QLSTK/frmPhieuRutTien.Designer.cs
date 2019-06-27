namespace QLSTK
{
    partial class frmPhieuRutTien
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
            this.btnLuuVaXuatPhieu = new System.Windows.Forms.Button();
            this.txtSoTienRut = new System.Windows.Forms.TextBox();
            this.txtNgayRut = new System.Windows.Forms.TextBox();
            this.cmbKhachHang = new System.Windows.Forms.ComboBox();
            this.cmbMaSoSTK = new System.Windows.Forms.ComboBox();
            this.lbSoTienRut = new System.Windows.Forms.Label();
            this.lbNgayRut = new System.Windows.Forms.Label();
            this.lbKhachHang = new System.Windows.Forms.Label();
            this.lbMaSoSTK = new System.Windows.Forms.Label();
            this.txtMaSoPRT = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPhieuRutTien = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLuuVaXuatPhieu
            // 
            this.btnLuuVaXuatPhieu.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLuuVaXuatPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuVaXuatPhieu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuVaXuatPhieu.Image = global::QLSTK.Properties.Resources.icons8_print_32;
            this.btnLuuVaXuatPhieu.Location = new System.Drawing.Point(319, 609);
            this.btnLuuVaXuatPhieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuuVaXuatPhieu.Name = "btnLuuVaXuatPhieu";
            this.btnLuuVaXuatPhieu.Size = new System.Drawing.Size(235, 50);
            this.btnLuuVaXuatPhieu.TabIndex = 29;
            this.btnLuuVaXuatPhieu.Text = "Lưu và xuất phiếu";
            this.btnLuuVaXuatPhieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuVaXuatPhieu.UseVisualStyleBackColor = false;
            this.btnLuuVaXuatPhieu.Click += new System.EventHandler(this.btnLuuVaXuatPhieu_Click);
            // 
            // txtSoTienRut
            // 
            this.txtSoTienRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienRut.Location = new System.Drawing.Point(307, 354);
            this.txtSoTienRut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoTienRut.Name = "txtSoTienRut";
            this.txtSoTienRut.Size = new System.Drawing.Size(250, 30);
            this.txtSoTienRut.TabIndex = 28;
            this.txtSoTienRut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSoTienRut_KeyPress);
            // 
            // txtNgayRut
            // 
            this.txtNgayRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayRut.Location = new System.Drawing.Point(307, 294);
            this.txtNgayRut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNgayRut.Name = "txtNgayRut";
            this.txtNgayRut.ReadOnly = true;
            this.txtNgayRut.Size = new System.Drawing.Size(250, 30);
            this.txtNgayRut.TabIndex = 27;
            // 
            // cmbKhachHang
            // 
            this.cmbKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhachHang.FormattingEnabled = true;
            this.cmbKhachHang.Location = new System.Drawing.Point(307, 178);
            this.cmbKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbKhachHang.Name = "cmbKhachHang";
            this.cmbKhachHang.Size = new System.Drawing.Size(358, 33);
            this.cmbKhachHang.TabIndex = 26;
            this.cmbKhachHang.SelectedIndexChanged += new System.EventHandler(this.CmbKhachHang_SelectedIndexChanged);
            // 
            // cmbMaSoSTK
            // 
            this.cmbMaSoSTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaSoSTK.FormattingEnabled = true;
            this.cmbMaSoSTK.Location = new System.Drawing.Point(307, 236);
            this.cmbMaSoSTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMaSoSTK.Name = "cmbMaSoSTK";
            this.cmbMaSoSTK.Size = new System.Drawing.Size(250, 33);
            this.cmbMaSoSTK.TabIndex = 25;
            this.cmbMaSoSTK.SelectedIndexChanged += new System.EventHandler(this.CmbMaSoSTK_SelectedIndexChanged);
            // 
            // lbSoTienRut
            // 
            this.lbSoTienRut.AutoSize = true;
            this.lbSoTienRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTienRut.ForeColor = System.Drawing.Color.White;
            this.lbSoTienRut.Location = new System.Drawing.Point(154, 353);
            this.lbSoTienRut.Name = "lbSoTienRut";
            this.lbSoTienRut.Size = new System.Drawing.Size(100, 25);
            this.lbSoTienRut.TabIndex = 24;
            this.lbSoTienRut.Text = "Số tiền rút";
            // 
            // lbNgayRut
            // 
            this.lbNgayRut.AutoSize = true;
            this.lbNgayRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayRut.ForeColor = System.Drawing.Color.White;
            this.lbNgayRut.Location = new System.Drawing.Point(169, 295);
            this.lbNgayRut.Name = "lbNgayRut";
            this.lbNgayRut.Size = new System.Drawing.Size(85, 25);
            this.lbNgayRut.TabIndex = 23;
            this.lbNgayRut.Text = "Ngày rút";
            // 
            // lbKhachHang
            // 
            this.lbKhachHang.AutoSize = true;
            this.lbKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhachHang.ForeColor = System.Drawing.Color.White;
            this.lbKhachHang.Location = new System.Drawing.Point(136, 179);
            this.lbKhachHang.Name = "lbKhachHang";
            this.lbKhachHang.Size = new System.Drawing.Size(118, 25);
            this.lbKhachHang.TabIndex = 22;
            this.lbKhachHang.Text = "Khách hàng";
            // 
            // lbMaSoSTK
            // 
            this.lbMaSoSTK.AutoSize = true;
            this.lbMaSoSTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSoSTK.ForeColor = System.Drawing.Color.White;
            this.lbMaSoSTK.Location = new System.Drawing.Point(142, 237);
            this.lbMaSoSTK.Name = "lbMaSoSTK";
            this.lbMaSoSTK.Size = new System.Drawing.Size(112, 25);
            this.lbMaSoSTK.TabIndex = 21;
            this.lbMaSoSTK.Text = "Mã sổ STK";
            // 
            // txtMaSoPRT
            // 
            this.txtMaSoPRT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSoPRT.Location = new System.Drawing.Point(307, 116);
            this.txtMaSoPRT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaSoPRT.Name = "txtMaSoPRT";
            this.txtMaSoPRT.Size = new System.Drawing.Size(250, 30);
            this.txtMaSoPRT.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaSoPRT);
            this.groupBox1.Controls.Add(this.txtSoTienRut);
            this.groupBox1.Controls.Add(this.txtNgayRut);
            this.groupBox1.Controls.Add(this.cmbKhachHang);
            this.groupBox1.Controls.Add(this.cmbMaSoSTK);
            this.groupBox1.Controls.Add(this.lbSoTienRut);
            this.groupBox1.Controls.Add(this.lbNgayRut);
            this.groupBox1.Controls.Add(this.lbKhachHang);
            this.groupBox1.Controls.Add(this.lbMaSoSTK);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(863, 472);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(150, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "Mã số PGT";
            // 
            // lblPhieuRutTien
            // 
            this.lblPhieuRutTien.AutoSize = true;
            this.lblPhieuRutTien.BackColor = System.Drawing.Color.Transparent;
            this.lblPhieuRutTien.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhieuRutTien.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblPhieuRutTien.Location = new System.Drawing.Point(313, 18);
            this.lblPhieuRutTien.Name = "lblPhieuRutTien";
            this.lblPhieuRutTien.Size = new System.Drawing.Size(300, 36);
            this.lblPhieuRutTien.TabIndex = 35;
            this.lblPhieuRutTien.Text = "LẬP PHIẾU RÚT TIỀN";
            this.lblPhieuRutTien.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::QLSTK.Properties.Resources.icons8_save_close_32;
            this.button1.Location = new System.Drawing.Point(127, 609);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 50);
            this.button1.TabIndex = 37;
            this.button1.Text = "Lưu";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.DarkCyan;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = global::QLSTK.Properties.Resources.icons8_exit_32;
            this.btnHuy.Location = new System.Drawing.Point(600, 609);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(146, 50);
            this.btnHuy.TabIndex = 36;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // frmPhieuRutTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(882, 703);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.lblPhieuRutTien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLuuVaXuatPhieu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhieuRutTien";
            this.Text = "frmPhieuRutTien";
            this.Load += new System.EventHandler(this.frmPhieuRutTien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLuuVaXuatPhieu;
        private System.Windows.Forms.TextBox txtSoTienRut;
        private System.Windows.Forms.TextBox txtNgayRut;
        private System.Windows.Forms.ComboBox cmbKhachHang;
        private System.Windows.Forms.ComboBox cmbMaSoSTK;
        private System.Windows.Forms.Label lbSoTienRut;
        private System.Windows.Forms.Label lbNgayRut;
        private System.Windows.Forms.Label lbKhachHang;
        private System.Windows.Forms.Label lbMaSoSTK;
        private System.Windows.Forms.TextBox txtMaSoPRT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPhieuRutTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHuy;
    }
}