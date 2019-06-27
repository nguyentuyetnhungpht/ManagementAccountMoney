namespace QLSTK
{
    partial class frmPhieuGuiTien
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
            this.lblPhieuGuiTien = new System.Windows.Forms.Label();
            this.txtSoTienGui = new System.Windows.Forms.TextBox();
            this.txtNgayGui = new System.Windows.Forms.TextBox();
            this.cmbKhachHang = new System.Windows.Forms.ComboBox();
            this.cmbMaSoSTK = new System.Windows.Forms.ComboBox();
            this.lbSoTienGui = new System.Windows.Forms.Label();
            this.lbNgayGui = new System.Windows.Forms.Label();
            this.lbKhachHang = new System.Windows.Forms.Label();
            this.lbMaSo = new System.Windows.Forms.Label();
            this.txtMaSoPGT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuuVaXuatPhieu = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPhieuGuiTien
            // 
            this.lblPhieuGuiTien.AutoSize = true;
            this.lblPhieuGuiTien.BackColor = System.Drawing.Color.Transparent;
            this.lblPhieuGuiTien.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhieuGuiTien.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblPhieuGuiTien.Location = new System.Drawing.Point(314, 20);
            this.lblPhieuGuiTien.Name = "lblPhieuGuiTien";
            this.lblPhieuGuiTien.Size = new System.Drawing.Size(296, 36);
            this.lblPhieuGuiTien.TabIndex = 19;
            this.lblPhieuGuiTien.Text = "LẬP PHIẾU GỬI TIỀN";
            this.lblPhieuGuiTien.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSoTienGui
            // 
            this.txtSoTienGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienGui.Location = new System.Drawing.Point(319, 353);
            this.txtSoTienGui.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoTienGui.Name = "txtSoTienGui";
            this.txtSoTienGui.Size = new System.Drawing.Size(209, 30);
            this.txtSoTienGui.TabIndex = 17;
            this.txtSoTienGui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSoTienGui_KeyPress);
            // 
            // txtNgayGui
            // 
            this.txtNgayGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayGui.Location = new System.Drawing.Point(319, 293);
            this.txtNgayGui.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNgayGui.Name = "txtNgayGui";
            this.txtNgayGui.ReadOnly = true;
            this.txtNgayGui.Size = new System.Drawing.Size(209, 30);
            this.txtNgayGui.TabIndex = 16;
            // 
            // cmbKhachHang
            // 
            this.cmbKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhachHang.FormattingEnabled = true;
            this.cmbKhachHang.Location = new System.Drawing.Point(319, 161);
            this.cmbKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbKhachHang.Name = "cmbKhachHang";
            this.cmbKhachHang.Size = new System.Drawing.Size(347, 33);
            this.cmbKhachHang.TabIndex = 15;
            this.cmbKhachHang.SelectedIndexChanged += new System.EventHandler(this.CmbKhachHang_SelectedIndexChanged);
            // 
            // cmbMaSoSTK
            // 
            this.cmbMaSoSTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaSoSTK.FormattingEnabled = true;
            this.cmbMaSoSTK.Location = new System.Drawing.Point(319, 222);
            this.cmbMaSoSTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMaSoSTK.Name = "cmbMaSoSTK";
            this.cmbMaSoSTK.Size = new System.Drawing.Size(209, 33);
            this.cmbMaSoSTK.TabIndex = 14;
            this.cmbMaSoSTK.SelectedIndexChanged += new System.EventHandler(this.CmbMaSoSTK_SelectedIndexChanged);
            // 
            // lbSoTienGui
            // 
            this.lbSoTienGui.AutoSize = true;
            this.lbSoTienGui.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTienGui.ForeColor = System.Drawing.Color.White;
            this.lbSoTienGui.Location = new System.Drawing.Point(152, 353);
            this.lbSoTienGui.Name = "lbSoTienGui";
            this.lbSoTienGui.Size = new System.Drawing.Size(106, 24);
            this.lbSoTienGui.TabIndex = 13;
            this.lbSoTienGui.Text = "Số tiền gửi";
            // 
            // lbNgayGui
            // 
            this.lbNgayGui.AutoSize = true;
            this.lbNgayGui.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayGui.ForeColor = System.Drawing.Color.White;
            this.lbNgayGui.Location = new System.Drawing.Point(169, 290);
            this.lbNgayGui.Name = "lbNgayGui";
            this.lbNgayGui.Size = new System.Drawing.Size(89, 24);
            this.lbNgayGui.TabIndex = 12;
            this.lbNgayGui.Text = "Ngày gửi";
            // 
            // lbKhachHang
            // 
            this.lbKhachHang.AutoSize = true;
            this.lbKhachHang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhachHang.ForeColor = System.Drawing.Color.White;
            this.lbKhachHang.Location = new System.Drawing.Point(144, 161);
            this.lbKhachHang.Name = "lbKhachHang";
            this.lbKhachHang.Size = new System.Drawing.Size(114, 24);
            this.lbKhachHang.TabIndex = 11;
            this.lbKhachHang.Text = "Khách hàng";
            // 
            // lbMaSo
            // 
            this.lbMaSo.AutoSize = true;
            this.lbMaSo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSo.ForeColor = System.Drawing.Color.White;
            this.lbMaSo.Location = new System.Drawing.Point(155, 226);
            this.lbMaSo.Name = "lbMaSo";
            this.lbMaSo.Size = new System.Drawing.Size(103, 24);
            this.lbMaSo.TabIndex = 10;
            this.lbMaSo.Text = "Mã sổ STK";
            // 
            // txtMaSoPGT
            // 
            this.txtMaSoPGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSoPGT.Location = new System.Drawing.Point(319, 98);
            this.txtMaSoPGT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaSoPGT.Name = "txtMaSoPGT";
            this.txtMaSoPGT.Size = new System.Drawing.Size(209, 30);
            this.txtMaSoPGT.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(154, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã số PGT";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtMaSoPGT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSoTienGui);
            this.groupBox1.Controls.Add(this.txtNgayGui);
            this.groupBox1.Controls.Add(this.cmbKhachHang);
            this.groupBox1.Controls.Add(this.cmbMaSoSTK);
            this.groupBox1.Controls.Add(this.lbSoTienGui);
            this.groupBox1.Controls.Add(this.lbNgayGui);
            this.groupBox1.Controls.Add(this.lbKhachHang);
            this.groupBox1.Controls.Add(this.lbMaSo);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(863, 472);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.DarkCyan;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = global::QLSTK.Properties.Resources.icons8_exit_32;
            this.btnHuy.Location = new System.Drawing.Point(597, 616);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(146, 50);
            this.btnHuy.TabIndex = 20;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.BtnHuy_Click);
            // 
            // btnLuuVaXuatPhieu
            // 
            this.btnLuuVaXuatPhieu.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLuuVaXuatPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuVaXuatPhieu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuVaXuatPhieu.Image = global::QLSTK.Properties.Resources.icons8_print_32;
            this.btnLuuVaXuatPhieu.Location = new System.Drawing.Point(329, 616);
            this.btnLuuVaXuatPhieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuuVaXuatPhieu.Name = "btnLuuVaXuatPhieu";
            this.btnLuuVaXuatPhieu.Size = new System.Drawing.Size(235, 50);
            this.btnLuuVaXuatPhieu.TabIndex = 18;
            this.btnLuuVaXuatPhieu.Text = "Lưu và xuất phiếu";
            this.btnLuuVaXuatPhieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuVaXuatPhieu.UseVisualStyleBackColor = false;
            this.btnLuuVaXuatPhieu.Click += new System.EventHandler(this.btnLuuVaXuatPhieu_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::QLSTK.Properties.Resources.icons8_save_close_32;
            this.btnLuu.Location = new System.Drawing.Point(150, 616);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(146, 50);
            this.btnLuu.TabIndex = 25;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // frmPhieuGuiTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(882, 703);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.lblPhieuGuiTien);
            this.Controls.Add(this.btnLuuVaXuatPhieu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhieuGuiTien";
            this.Text = "frmPhieuGuiTien";
            this.Load += new System.EventHandler(this.frmPhieuGuiTien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhieuGuiTien;
        private System.Windows.Forms.Button btnLuuVaXuatPhieu;
        private System.Windows.Forms.TextBox txtSoTienGui;
        private System.Windows.Forms.TextBox txtNgayGui;
        private System.Windows.Forms.ComboBox cmbKhachHang;
        private System.Windows.Forms.ComboBox cmbMaSoSTK;
        private System.Windows.Forms.Label lbSoTienGui;
        private System.Windows.Forms.Label lbNgayGui;
        private System.Windows.Forms.Label lbKhachHang;
        private System.Windows.Forms.Label lbMaSo;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtMaSoPGT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLuu;
    }
}