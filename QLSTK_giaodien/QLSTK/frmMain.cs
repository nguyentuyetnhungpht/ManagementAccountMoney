using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLSTK
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
            
        }

        private void TileItem6_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmLapSoMoi frm = new frmLapSoMoi();
            this.Hide();
            frm.Show();
        }

        private void TileThayDoiQuiDinh_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmQuyDinh frm = new frmQuyDinh();
            this.Hide();
            frm.Show();
        }

        private void TileThongBao_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

        }

        private void TileTraCuu_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmTraCuu frm = new frmTraCuu();
            this.Hide();
            frm.Show();
        }

        private void TileLapPhieuGuiTien_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmPhieuGuiTien frm = new frmPhieuGuiTien();
            this.Hide();
            frm.Show();
        }

        private void TileLapPhieuRutTien_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmPhieuRutTien frm = new frmPhieuRutTien();
            this.Hide();
            frm.Show();
        }

        private void TileLapBaoCaoNgay_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmBaoCaoDoanhSoNgay frm = new frmBaoCaoDoanhSoNgay();
            this.Hide();
            frm.Show();
        }

        private void TileLapBaoCaoThang_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmBaoCaoDoanhSoThang frm = new frmBaoCaoDoanhSoThang();
            this.Hide();
            frm.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
