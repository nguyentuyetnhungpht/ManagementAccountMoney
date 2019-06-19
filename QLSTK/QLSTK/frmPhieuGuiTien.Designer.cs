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
            this.btnLuuVaXuatPhieu = new System.Windows.Forms.Button();
            this.txtSoTienGui = new System.Windows.Forms.TextBox();
            this.txtNgayGui = new System.Windows.Forms.TextBox();
            this.cmbKhachHang = new System.Windows.Forms.ComboBox();
            this.cmbMaSoSTK = new System.Windows.Forms.ComboBox();
            this.lbSoTienGui = new System.Windows.Forms.Label();
            this.lbNgayGui = new System.Windows.Forms.Label();
            this.lbKhachHang = new System.Windows.Forms.Label();
            this.lbMaSo = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtMaSoPGT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPhieuGuiTien
            // 
            this.lblPhieuGuiTien.AutoSize = true;
            this.lblPhieuGuiTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhieuGuiTien.Location = new System.Drawing.Point(135, 57);
            this.lblPhieuGuiTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhieuGuiTien.Name = "lblPhieuGuiTien";
            this.lblPhieuGuiTien.Size = new System.Drawing.Size(177, 31);
            this.lblPhieuGuiTien.TabIndex = 19;
            this.lblPhieuGuiTien.Text = "Phiếu gửi tiền";
            // 
            // btnLuuVaXuatPhieu
            // 
            this.btnLuuVaXuatPhieu.Location = new System.Drawing.Point(97, 407);
            this.btnLuuVaXuatPhieu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuuVaXuatPhieu.Name = "btnLuuVaXuatPhieu";
            this.btnLuuVaXuatPhieu.Size = new System.Drawing.Size(90, 36);
            this.btnLuuVaXuatPhieu.TabIndex = 18;
            this.btnLuuVaXuatPhieu.Text = "Lưu và xuất phiếu";
            this.btnLuuVaXuatPhieu.UseVisualStyleBackColor = true;
            this.btnLuuVaXuatPhieu.Click += new System.EventHandler(this.btnLuuVaXuatPhieu_Click);
            // 
            // txtSoTienGui
            // 
            this.txtSoTienGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienGui.Location = new System.Drawing.Point(192, 320);
            this.txtSoTienGui.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoTienGui.Name = "txtSoTienGui";
            this.txtSoTienGui.Size = new System.Drawing.Size(176, 26);
            this.txtSoTienGui.TabIndex = 17;
            // 
            // txtNgayGui
            // 
            this.txtNgayGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayGui.Location = new System.Drawing.Point(192, 271);
            this.txtNgayGui.Margin = new System.Windows.Forms.Padding(2);
            this.txtNgayGui.Name = "txtNgayGui";
            this.txtNgayGui.ReadOnly = true;
            this.txtNgayGui.Size = new System.Drawing.Size(176, 26);
            this.txtNgayGui.TabIndex = 16;
            // 
            // cmbKhachHang
            // 
            this.cmbKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhachHang.FormattingEnabled = true;
            this.cmbKhachHang.Location = new System.Drawing.Point(192, 164);
            this.cmbKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKhachHang.Name = "cmbKhachHang";
            this.cmbKhachHang.Size = new System.Drawing.Size(176, 28);
            this.cmbKhachHang.TabIndex = 15;
            // 
            // cmbMaSoSTK
            // 
            this.cmbMaSoSTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaSoSTK.FormattingEnabled = true;
            this.cmbMaSoSTK.Location = new System.Drawing.Point(192, 214);
            this.cmbMaSoSTK.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMaSoSTK.Name = "cmbMaSoSTK";
            this.cmbMaSoSTK.Size = new System.Drawing.Size(176, 28);
            this.cmbMaSoSTK.TabIndex = 14;
            // 
            // lbSoTienGui
            // 
            this.lbSoTienGui.AutoSize = true;
            this.lbSoTienGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTienGui.Location = new System.Drawing.Point(68, 320);
            this.lbSoTienGui.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSoTienGui.Name = "lbSoTienGui";
            this.lbSoTienGui.Size = new System.Drawing.Size(84, 20);
            this.lbSoTienGui.TabIndex = 13;
            this.lbSoTienGui.Text = "Số tiền gửi";
            // 
            // lbNgayGui
            // 
            this.lbNgayGui.AutoSize = true;
            this.lbNgayGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayGui.Location = new System.Drawing.Point(68, 269);
            this.lbNgayGui.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNgayGui.Name = "lbNgayGui";
            this.lbNgayGui.Size = new System.Drawing.Size(70, 20);
            this.lbNgayGui.TabIndex = 12;
            this.lbNgayGui.Text = "Ngày gửi";
            // 
            // lbKhachHang
            // 
            this.lbKhachHang.AutoSize = true;
            this.lbKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhachHang.Location = new System.Drawing.Point(68, 164);
            this.lbKhachHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbKhachHang.Name = "lbKhachHang";
            this.lbKhachHang.Size = new System.Drawing.Size(94, 20);
            this.lbKhachHang.TabIndex = 11;
            this.lbKhachHang.Text = "Khách hàng";
            // 
            // lbMaSo
            // 
            this.lbMaSo.AutoSize = true;
            this.lbMaSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSo.Location = new System.Drawing.Point(68, 217);
            this.lbMaSo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaSo.Name = "lbMaSo";
            this.lbMaSo.Size = new System.Drawing.Size(86, 20);
            this.lbMaSo.TabIndex = 10;
            this.lbMaSo.Text = "Mã sổ STK";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(253, 407);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(84, 36);
            this.btnHuy.TabIndex = 20;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // txtMaSoPGT
            // 
            this.txtMaSoPGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSoPGT.Location = new System.Drawing.Point(192, 113);
            this.txtMaSoPGT.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaSoPGT.Name = "txtMaSoPGT";
            this.txtMaSoPGT.Size = new System.Drawing.Size(176, 26);
            this.txtMaSoPGT.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã số PGT";
            // 
            // frmPhieuGuiTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 470);
            this.Controls.Add(this.txtMaSoPGT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.lblPhieuGuiTien);
            this.Controls.Add(this.btnLuuVaXuatPhieu);
            this.Controls.Add(this.txtSoTienGui);
            this.Controls.Add(this.txtNgayGui);
            this.Controls.Add(this.cmbKhachHang);
            this.Controls.Add(this.cmbMaSoSTK);
            this.Controls.Add(this.lbSoTienGui);
            this.Controls.Add(this.lbNgayGui);
            this.Controls.Add(this.lbKhachHang);
            this.Controls.Add(this.lbMaSo);
            this.Name = "frmPhieuGuiTien";
            this.Text = "frmPhieuGuiTien";
            this.Load += new System.EventHandler(this.frmPhieuGuiTien_Load);
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
    }
}