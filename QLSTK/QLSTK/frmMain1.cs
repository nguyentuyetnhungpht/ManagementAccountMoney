using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSTK
{
    public partial class frmMain1 : Form
    {
        public frmMain1()
        {
            InitializeComponent();
        }

        private void lậpSổMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tsThayDoiQuyDinh_Click(object sender, EventArgs e)
        {
            frmQuyDinh frm = new frmQuyDinh();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsTraCuuSo_Click(object sender, EventArgs e)
        {
            frmTraCuu frm = new frmTraCuu();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsLapPhieuGuiTien_Click(object sender, EventArgs e)
        {
            frmPhieuGuiTien frm = new frmPhieuGuiTien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsLapPhieuRutTien_Click(object sender, EventArgs e)
        {
            frmPhieuRutTien frm = new frmPhieuRutTien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsBaoCaoDoanhSoNgay_Click(object sender, EventArgs e)
        {
            frmBaoCaoDoanhSoNgay frm = new frmBaoCaoDoanhSoNgay();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsBaoCaoMoDongSoThang_Click(object sender, EventArgs e)
        {
            frmBaoCaoMoDongSoThang frm = new frmBaoCaoMoDongSoThang();
            frm.MdiParent = this;
            frm.Show();
        }
        private void tsLapSoMoi_Click(object sender, EventArgs e)
        {
            frmSoTietKiem frm = new frmSoTietKiem();
            frm.MdiParent = this;
            frm.Show();
        }
       

        private void tsLapPhieuGuiTien_Click_1(object sender, EventArgs e)
        {
            frmPhieuGuiTien frm = new frmPhieuGuiTien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsLapPhieuRutTien_Click_1(object sender, EventArgs e)
        {
            frmPhieuRutTien frm = new frmPhieuRutTien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsTraCuuSo_Click_1(object sender, EventArgs e)
        {
            frmTraCuu frm = new frmTraCuu();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsThongTinKhachHang_Click(object sender, EventArgs e)
        {
            frmQLKH frm = new frmQLKH();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
