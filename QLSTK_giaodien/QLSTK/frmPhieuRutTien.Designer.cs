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
            this.lblPhieuRutTien = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlPhieuRutTien = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuuVaXuatPhieu = new System.Windows.Forms.Button();
            this.txtSoTienGui = new System.Windows.Forms.TextBox();
            this.txtNgayGui = new System.Windows.Forms.TextBox();
            this.cmbKhachHang = new System.Windows.Forms.ComboBox();
            this.cmbMaSo = new System.Windows.Forms.ComboBox();
            this.lbSoTienRut = new System.Windows.Forms.Label();
            this.lbNgayRut = new System.Windows.Forms.Label();
            this.lbKhachHang = new System.Windows.Forms.Label();
            this.lbMaSo = new System.Windows.Forms.Label();
            this.pnlPhieuRutTien.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPhieuRutTien
            // 
            this.lblPhieuRutTien.AutoSize = true;
            this.lblPhieuRutTien.BackColor = System.Drawing.Color.Transparent;
            this.lblPhieuRutTien.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhieuRutTien.ForeColor = System.Drawing.Color.White;
            this.lblPhieuRutTien.Location = new System.Drawing.Point(208, 5);
            this.lblPhieuRutTien.Name = "lblPhieuRutTien";
            this.lblPhieuRutTien.Size = new System.Drawing.Size(162, 27);
            this.lblPhieuRutTien.TabIndex = 41;
            this.lblPhieuRutTien.Text = "Phiếu rút tiền";
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::QLSTK.Properties.Resources.icons8_close_window_481;
            this.btnExit.Location = new System.Drawing.Point(387, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 22);
            this.btnExit.TabIndex = 43;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // pnlPhieuRutTien
            // 
            this.pnlPhieuRutTien.BackgroundImage = global::QLSTK.Properties.Resources._90440;
            this.pnlPhieuRutTien.Controls.Add(this.btnHuy);
            this.pnlPhieuRutTien.Controls.Add(this.btnLuuVaXuatPhieu);
            this.pnlPhieuRutTien.Controls.Add(this.txtSoTienGui);
            this.pnlPhieuRutTien.Controls.Add(this.txtNgayGui);
            this.pnlPhieuRutTien.Controls.Add(this.cmbKhachHang);
            this.pnlPhieuRutTien.Controls.Add(this.cmbMaSo);
            this.pnlPhieuRutTien.Controls.Add(this.lbSoTienRut);
            this.pnlPhieuRutTien.Controls.Add(this.lbNgayRut);
            this.pnlPhieuRutTien.Controls.Add(this.lbKhachHang);
            this.pnlPhieuRutTien.Controls.Add(this.lbMaSo);
            this.pnlPhieuRutTien.Controls.Add(this.btnExit);
            this.pnlPhieuRutTien.Controls.Add(this.lblPhieuRutTien);
            this.pnlPhieuRutTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPhieuRutTien.Location = new System.Drawing.Point(0, 0);
            this.pnlPhieuRutTien.Name = "pnlPhieuRutTien";
            this.pnlPhieuRutTien.Size = new System.Drawing.Size(418, 500);
            this.pnlPhieuRutTien.TabIndex = 44;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.DarkCyan;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = global::QLSTK.Properties.Resources.icons8_delete_file_24;
            this.btnHuy.Location = new System.Drawing.Point(242, 388);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(127, 35);
            this.btnHuy.TabIndex = 53;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnLuuVaXuatPhieu
            // 
            this.btnLuuVaXuatPhieu.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLuuVaXuatPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuVaXuatPhieu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuVaXuatPhieu.Image = global::QLSTK.Properties.Resources.icons8_send_to_printer_30;
            this.btnLuuVaXuatPhieu.Location = new System.Drawing.Point(44, 388);
            this.btnLuuVaXuatPhieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuuVaXuatPhieu.Name = "btnLuuVaXuatPhieu";
            this.btnLuuVaXuatPhieu.Size = new System.Drawing.Size(158, 35);
            this.btnLuuVaXuatPhieu.TabIndex = 52;
            this.btnLuuVaXuatPhieu.Text = "Lưu và xuất";
            this.btnLuuVaXuatPhieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuVaXuatPhieu.UseVisualStyleBackColor = false;
            // 
            // txtSoTienGui
            // 
            this.txtSoTienGui.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienGui.Location = new System.Drawing.Point(169, 310);
            this.txtSoTienGui.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoTienGui.Name = "txtSoTienGui";
            this.txtSoTienGui.Size = new System.Drawing.Size(200, 29);
            this.txtSoTienGui.TabIndex = 51;
            // 
            // txtNgayGui
            // 
            this.txtNgayGui.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayGui.Location = new System.Drawing.Point(169, 250);
            this.txtNgayGui.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNgayGui.Name = "txtNgayGui";
            this.txtNgayGui.ReadOnly = true;
            this.txtNgayGui.Size = new System.Drawing.Size(200, 29);
            this.txtNgayGui.TabIndex = 50;
            // 
            // cmbKhachHang
            // 
            this.cmbKhachHang.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhachHang.FormattingEnabled = true;
            this.cmbKhachHang.Location = new System.Drawing.Point(169, 184);
            this.cmbKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbKhachHang.Name = "cmbKhachHang";
            this.cmbKhachHang.Size = new System.Drawing.Size(200, 30);
            this.cmbKhachHang.TabIndex = 49;
            // 
            // cmbMaSo
            // 
            this.cmbMaSo.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaSo.FormattingEnabled = true;
            this.cmbMaSo.Location = new System.Drawing.Point(169, 124);
            this.cmbMaSo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMaSo.Name = "cmbMaSo";
            this.cmbMaSo.Size = new System.Drawing.Size(200, 30);
            this.cmbMaSo.TabIndex = 48;
            // 
            // lbSoTienRut
            // 
            this.lbSoTienRut.AutoSize = true;
            this.lbSoTienRut.BackColor = System.Drawing.Color.Transparent;
            this.lbSoTienRut.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTienRut.ForeColor = System.Drawing.Color.White;
            this.lbSoTienRut.Location = new System.Drawing.Point(40, 310);
            this.lbSoTienRut.Name = "lbSoTienRut";
            this.lbSoTienRut.Size = new System.Drawing.Size(98, 23);
            this.lbSoTienRut.TabIndex = 47;
            this.lbSoTienRut.Text = "Số tiền rút";
            // 
            // lbNgayRut
            // 
            this.lbNgayRut.AutoSize = true;
            this.lbNgayRut.BackColor = System.Drawing.Color.Transparent;
            this.lbNgayRut.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayRut.ForeColor = System.Drawing.Color.White;
            this.lbNgayRut.Location = new System.Drawing.Point(40, 247);
            this.lbNgayRut.Name = "lbNgayRut";
            this.lbNgayRut.Size = new System.Drawing.Size(83, 23);
            this.lbNgayRut.TabIndex = 46;
            this.lbNgayRut.Text = "Ngày rút";
            // 
            // lbKhachHang
            // 
            this.lbKhachHang.AutoSize = true;
            this.lbKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.lbKhachHang.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhachHang.ForeColor = System.Drawing.Color.White;
            this.lbKhachHang.Location = new System.Drawing.Point(40, 184);
            this.lbKhachHang.Name = "lbKhachHang";
            this.lbKhachHang.Size = new System.Drawing.Size(111, 23);
            this.lbKhachHang.TabIndex = 45;
            this.lbKhachHang.Text = "Khách hàng";
            // 
            // lbMaSo
            // 
            this.lbMaSo.AutoSize = true;
            this.lbMaSo.BackColor = System.Drawing.Color.Transparent;
            this.lbMaSo.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSo.ForeColor = System.Drawing.Color.White;
            this.lbMaSo.Location = new System.Drawing.Point(40, 128);
            this.lbMaSo.Name = "lbMaSo";
            this.lbMaSo.Size = new System.Drawing.Size(59, 23);
            this.lbMaSo.TabIndex = 44;
            this.lbMaSo.Text = "Mã sổ";
            // 
            // frmPhieuRutTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::QLSTK.Properties.Resources._90440;
            this.ClientSize = new System.Drawing.Size(418, 500);
            this.Controls.Add(this.pnlPhieuRutTien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(418, 500);
            this.MinimumSize = new System.Drawing.Size(418, 500);
            this.Name = "frmPhieuRutTien";
            this.Text = "frmPhieuRutTien";
            this.pnlPhieuRutTien.ResumeLayout(false);
            this.pnlPhieuRutTien.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblPhieuRutTien;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlPhieuRutTien;
        private System.Windows.Forms.TextBox txtSoTienGui;
        private System.Windows.Forms.TextBox txtNgayGui;
        private System.Windows.Forms.ComboBox cmbKhachHang;
        private System.Windows.Forms.ComboBox cmbMaSo;
        private System.Windows.Forms.Label lbSoTienRut;
        private System.Windows.Forms.Label lbNgayRut;
        private System.Windows.Forms.Label lbKhachHang;
        private System.Windows.Forms.Label lbMaSo;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuuVaXuatPhieu;
    }
}