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
            //frm.MdiParent = this;
            frm.Show();
        }

        private void TileThayDoiQuiDinh_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmQuyDinh frm = new frmQuyDinh();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void TileThongBao_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

        }

        private void TileTraCuu_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmTraCuu frm = new frmTraCuu();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void TileLapPhieuGuiTien_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmPhieuGuiTien frm = new frmPhieuGuiTien();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void TileLapPhieuRutTien_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmPhieuRutTien frm = new frmPhieuRutTien();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void TileLapBaoCaoNgay_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmBaoCaoDoanhSoNgay frm = new frmBaoCaoDoanhSoNgay();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void TileLapBaoCaoThang_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmBaoCaoDoanhSoThang frm = new frmBaoCaoDoanhSoThang();
            //frm.MdiParent = this;
            frm.Show();
        }
    }
}
