using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLSTK
{
    public partial class frmHome : DevExpress.XtraEditors.XtraForm
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void FrmMain1_Load(object sender, EventArgs e)
        {
           
        }

        private void TileLapPhieuGuiTien_ItemClick(object sender, TileItemEventArgs e)
        {
            pnZone.Controls.Clear();
            frmPhieuGuiTien frmPhieuGui = new frmPhieuGuiTien();
            frmPhieuGui.TopLevel = false;
            pnZone.Controls.Add(frmPhieuGui);
            frmPhieuGui.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmPhieuGui.AutoScroll = true;
            frmPhieuGui.Dock = DockStyle.Fill;
            frmPhieuGui.Show();
        }

        private void TileTraCuu_ItemClick(object sender, TileItemEventArgs e)
        {
            pnZone.Controls.Clear();
            frmTraCuu frmTraCuu = new frmTraCuu();
            frmTraCuu.TopLevel = false;
            pnZone.Controls.Add(frmTraCuu);
            frmTraCuu.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmTraCuu.AutoScroll = true;
            frmTraCuu.Dock = DockStyle.Fill;
            frmTraCuu.Show();
        }

        //phiếu rút tiền
        private void TileItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            pnZone.Controls.Clear();
            frmPhieuRutTien frmPhieuRut = new frmPhieuRutTien();
            frmPhieuRut.TopLevel = false;
            pnZone.Controls.Add(frmPhieuRut);
            frmPhieuRut.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmPhieuRut.AutoScroll = true;
            frmPhieuRut.Dock = DockStyle.Fill;
            frmPhieuRut.Show();
        }

        private void TileThayDoiQuyDinh_ItemClick(object sender, TileItemEventArgs e)
        {
            pnZone.Controls.Clear();
            frmQuyDinh frmQuyDinh = new frmQuyDinh();
            frmQuyDinh.TopLevel = false;
            pnZone.Controls.Add(frmQuyDinh);
            frmQuyDinh.AutoScroll = true;
            frmQuyDinh.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmQuyDinh.Dock = DockStyle.Fill;
            frmQuyDinh.Show();
        }

        private void TileTTKhachHang_ItemClick(object sender, TileItemEventArgs e)
        {
            pnZone.Controls.Clear();
            frmQLKH frmQLKH = new frmQLKH();
            frmQLKH.TopLevel = false;
            pnZone.Controls.Add(frmQLKH);
            frmQLKH.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmQLKH.AutoScroll = true;
            frmQLKH.Dock = DockStyle.Fill;
            frmQLKH.Show();
        }

        private void TileLapBaoCaoNgay_ItemClick(object sender, TileItemEventArgs e)
        {
            pnZone.Controls.Clear();
            frmBaoCaoDoanhSoNgay frmDoanhSoNgay = new frmBaoCaoDoanhSoNgay();
            frmDoanhSoNgay.TopLevel = false;
            pnZone.Controls.Add(frmDoanhSoNgay);
            frmDoanhSoNgay.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmDoanhSoNgay.AutoScroll = true;
            frmDoanhSoNgay.Dock = DockStyle.Fill;
            frmDoanhSoNgay.Show();
        }

        private void TileLapBaoCaoTháng_ItemClick(object sender, TileItemEventArgs e)
        {
            pnZone.Controls.Clear();
            frmBaoCaoMoDongSoThang frmMoDongSoThang = new frmBaoCaoMoDongSoThang();
            frmMoDongSoThang.TopLevel = false;
            pnZone.Controls.Add(frmMoDongSoThang);
            frmMoDongSoThang.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmMoDongSoThang.AutoScroll = true;
            frmMoDongSoThang.Dock = DockStyle.Fill;
            frmMoDongSoThang.Show();
        }

        private void TileLapSoMoi_ItemClick(object sender, TileItemEventArgs e)
        {
            pnZone.Controls.Clear();
            frmSoTietKiem frmLapSoMoi = new frmSoTietKiem();
            frmLapSoMoi.TopLevel = false;
            pnZone.Controls.Add(frmLapSoMoi);
            frmLapSoMoi.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmLapSoMoi.AutoScroll = true;
            frmLapSoMoi.Dock = DockStyle.Fill;
            frmLapSoMoi.Show();
        }

        private void BtnThoát_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng ứng dụng sổ tiết kiệm?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}