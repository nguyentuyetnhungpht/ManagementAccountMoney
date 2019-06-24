namespace QLSTK
{
    partial class frmBaoCaoDoanhSoNgay
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
            this.pnlBaoCaoNgay = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblbaoCaoDoanhSoNgay = new System.Windows.Forms.Label();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.lbChenhLech = new System.Windows.Forms.Label();
            this.lbTongChiNgay = new System.Windows.Forms.Label();
            this.lbTongThuNgay = new System.Windows.Forms.Label();
            this.txtTongChiNgay = new System.Windows.Forms.TextBox();
            this.txtChenhLech = new System.Windows.Forms.TextBox();
            this.txtTongThuNgay = new System.Windows.Forms.TextBox();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.dtgBaoCaoNgay = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChenhLech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.lbNgay = new System.Windows.Forms.Label();
            this.pnlBaoCaoNgay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBaoCaoNgay)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBaoCaoNgay
            // 
            this.pnlBaoCaoNgay.BackgroundImage = global::QLSTK.Properties.Resources._90440;
            this.pnlBaoCaoNgay.Controls.Add(this.btnThoat);
            this.pnlBaoCaoNgay.Controls.Add(this.lblbaoCaoDoanhSoNgay);
            this.pnlBaoCaoNgay.Controls.Add(this.dtpNgay);
            this.pnlBaoCaoNgay.Controls.Add(this.lbChenhLech);
            this.pnlBaoCaoNgay.Controls.Add(this.lbTongChiNgay);
            this.pnlBaoCaoNgay.Controls.Add(this.lbTongThuNgay);
            this.pnlBaoCaoNgay.Controls.Add(this.txtTongChiNgay);
            this.pnlBaoCaoNgay.Controls.Add(this.txtChenhLech);
            this.pnlBaoCaoNgay.Controls.Add(this.txtTongThuNgay);
            this.pnlBaoCaoNgay.Controls.Add(this.btnTraCuu);
            this.pnlBaoCaoNgay.Controls.Add(this.dtgBaoCaoNgay);
            this.pnlBaoCaoNgay.Controls.Add(this.btnXuatFile);
            this.pnlBaoCaoNgay.Controls.Add(this.lbNgay);
            this.pnlBaoCaoNgay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBaoCaoNgay.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBaoCaoNgay.Location = new System.Drawing.Point(0, 0);
            this.pnlBaoCaoNgay.Name = "pnlBaoCaoNgay";
            this.pnlBaoCaoNgay.Size = new System.Drawing.Size(734, 542);
            this.pnlBaoCaoNgay.TabIndex = 49;
            this.pnlBaoCaoNgay.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlBaoCaoNgay_Paint);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = global::QLSTK.Properties.Resources.icons8_close_window_481;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Location = new System.Drawing.Point(707, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(24, 22);
            this.btnThoat.TabIndex = 49;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // lblbaoCaoDoanhSoNgay
            // 
            this.lblbaoCaoDoanhSoNgay.AutoEllipsis = true;
            this.lblbaoCaoDoanhSoNgay.AutoSize = true;
            this.lblbaoCaoDoanhSoNgay.BackColor = System.Drawing.Color.Transparent;
            this.lblbaoCaoDoanhSoNgay.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbaoCaoDoanhSoNgay.ForeColor = System.Drawing.Color.White;
            this.lblbaoCaoDoanhSoNgay.Location = new System.Drawing.Point(412, 3);
            this.lblbaoCaoDoanhSoNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbaoCaoDoanhSoNgay.Name = "lblbaoCaoDoanhSoNgay";
            this.lblbaoCaoDoanhSoNgay.Size = new System.Drawing.Size(265, 27);
            this.lblbaoCaoDoanhSoNgay.TabIndex = 48;
            this.lblbaoCaoDoanhSoNgay.Text = "Báo cáo doanh số ngày";
            // 
            // dtpNgay
            // 
            this.dtpNgay.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpNgay.CustomFormat = "";
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(136, 122);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(150, 29);
            this.dtpNgay.TabIndex = 47;
            this.dtpNgay.ValueChanged += new System.EventHandler(this.DtpNgay_ValueChanged);
            // 
            // lbChenhLech
            // 
            this.lbChenhLech.AutoSize = true;
            this.lbChenhLech.BackColor = System.Drawing.Color.Transparent;
            this.lbChenhLech.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChenhLech.ForeColor = System.Drawing.Color.White;
            this.lbChenhLech.Location = new System.Drawing.Point(361, 199);
            this.lbChenhLech.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbChenhLech.Name = "lbChenhLech";
            this.lbChenhLech.Size = new System.Drawing.Size(109, 23);
            this.lbChenhLech.TabIndex = 46;
            this.lbChenhLech.Text = "Chênh Lệch";
            // 
            // lbTongChiNgay
            // 
            this.lbTongChiNgay.AutoSize = true;
            this.lbTongChiNgay.BackColor = System.Drawing.Color.Transparent;
            this.lbTongChiNgay.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongChiNgay.ForeColor = System.Drawing.Color.White;
            this.lbTongChiNgay.Location = new System.Drawing.Point(361, 110);
            this.lbTongChiNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTongChiNgay.Name = "lbTongChiNgay";
            this.lbTongChiNgay.Size = new System.Drawing.Size(130, 23);
            this.lbTongChiNgay.TabIndex = 45;
            this.lbTongChiNgay.Text = "Tổng chi ngày";
            // 
            // lbTongThuNgay
            // 
            this.lbTongThuNgay.AutoSize = true;
            this.lbTongThuNgay.BackColor = System.Drawing.Color.Transparent;
            this.lbTongThuNgay.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongThuNgay.ForeColor = System.Drawing.Color.White;
            this.lbTongThuNgay.Location = new System.Drawing.Point(361, 154);
            this.lbTongThuNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTongThuNgay.Name = "lbTongThuNgay";
            this.lbTongThuNgay.Size = new System.Drawing.Size(134, 23);
            this.lbTongThuNgay.TabIndex = 44;
            this.lbTongThuNgay.Text = "Tổng thu ngày";
            // 
            // txtTongChiNgay
            // 
            this.txtTongChiNgay.Location = new System.Drawing.Point(502, 111);
            this.txtTongChiNgay.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongChiNgay.Name = "txtTongChiNgay";
            this.txtTongChiNgay.ReadOnly = true;
            this.txtTongChiNgay.Size = new System.Drawing.Size(150, 29);
            this.txtTongChiNgay.TabIndex = 43;
            this.txtTongChiNgay.TextChanged += new System.EventHandler(this.TxtTongChiNgay_TextChanged);
            // 
            // txtChenhLech
            // 
            this.txtChenhLech.Location = new System.Drawing.Point(502, 197);
            this.txtChenhLech.Margin = new System.Windows.Forms.Padding(2);
            this.txtChenhLech.Name = "txtChenhLech";
            this.txtChenhLech.ReadOnly = true;
            this.txtChenhLech.Size = new System.Drawing.Size(150, 29);
            this.txtChenhLech.TabIndex = 42;
            this.txtChenhLech.TextChanged += new System.EventHandler(this.TxtChenhLech_TextChanged);
            // 
            // txtTongThuNgay
            // 
            this.txtTongThuNgay.Location = new System.Drawing.Point(502, 154);
            this.txtTongThuNgay.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongThuNgay.Name = "txtTongThuNgay";
            this.txtTongThuNgay.ReadOnly = true;
            this.txtTongThuNgay.Size = new System.Drawing.Size(150, 29);
            this.txtTongThuNgay.TabIndex = 41;
            this.txtTongThuNgay.TextChanged += new System.EventHandler(this.TxtTongThuNgay_TextChanged);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.Image = global::QLSTK.Properties.Resources.icons8_search_26;
            this.btnTraCuu.Location = new System.Drawing.Point(159, 187);
            this.btnTraCuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(127, 35);
            this.btnTraCuu.TabIndex = 40;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTraCuu.UseVisualStyleBackColor = false;
            // 
            // dtgBaoCaoNgay
            // 
            this.dtgBaoCaoNgay.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgBaoCaoNgay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBaoCaoNgay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.LTK,
            this.Thu,
            this.Chi,
            this.ChenhLech});
            this.dtgBaoCaoNgay.Location = new System.Drawing.Point(0, 270);
            this.dtgBaoCaoNgay.Margin = new System.Windows.Forms.Padding(2);
            this.dtgBaoCaoNgay.MaximumSize = new System.Drawing.Size(734, 271);
            this.dtgBaoCaoNgay.MinimumSize = new System.Drawing.Size(734, 271);
            this.dtgBaoCaoNgay.Name = "dtgBaoCaoNgay";
            this.dtgBaoCaoNgay.RowTemplate.Height = 24;
            this.dtgBaoCaoNgay.Size = new System.Drawing.Size(734, 271);
            this.dtgBaoCaoNgay.TabIndex = 39;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            // 
            // LTK
            // 
            this.LTK.HeaderText = "Loại tiết kiệm";
            this.LTK.Name = "LTK";
            // 
            // Thu
            // 
            this.Thu.HeaderText = "Tổng thu";
            this.Thu.Name = "Thu";
            // 
            // Chi
            // 
            this.Chi.HeaderText = "Tổng chi";
            this.Chi.Name = "Chi";
            // 
            // ChenhLech
            // 
            this.ChenhLech.HeaderText = "Chênh lệch";
            this.ChenhLech.Name = "ChenhLech";
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.BackColor = System.Drawing.Color.DarkCyan;
            this.btnXuatFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXuatFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatFile.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.Image = global::QLSTK.Properties.Resources.icons8_export_26;
            this.btnXuatFile.Location = new System.Drawing.Point(28, 187);
            this.btnXuatFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(127, 35);
            this.btnXuatFile.TabIndex = 38;
            this.btnXuatFile.Text = "Xuất file";
            this.btnXuatFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXuatFile.UseVisualStyleBackColor = false;
            // 
            // lbNgay
            // 
            this.lbNgay.AutoEllipsis = true;
            this.lbNgay.AutoSize = true;
            this.lbNgay.BackColor = System.Drawing.Color.Transparent;
            this.lbNgay.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgay.ForeColor = System.Drawing.Color.White;
            this.lbNgay.Location = new System.Drawing.Point(28, 127);
            this.lbNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(53, 23);
            this.lbNgay.TabIndex = 37;
            this.lbNgay.Text = "Ngày";
            // 
            // frmBaoCaoDoanhSoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 542);
            this.Controls.Add(this.pnlBaoCaoNgay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(734, 542);
            this.MinimumSize = new System.Drawing.Size(734, 542);
            this.Name = "frmBaoCaoDoanhSoNgay";
            this.Text = "XtraForm1";
            this.pnlBaoCaoNgay.ResumeLayout(false);
            this.pnlBaoCaoNgay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBaoCaoNgay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblbaoCaoDoanhSoNgay;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Label lbChenhLech;
        private System.Windows.Forms.Label lbTongChiNgay;
        private System.Windows.Forms.Label lbTongThuNgay;
        private System.Windows.Forms.TextBox txtTongChiNgay;
        private System.Windows.Forms.TextBox txtChenhLech;
        private System.Windows.Forms.TextBox txtTongThuNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChenhLech;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridView dtgBaoCaoNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn LTK;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.Panel pnlBaoCaoNgay;
        private System.Windows.Forms.Button btnThoat;
    }
}