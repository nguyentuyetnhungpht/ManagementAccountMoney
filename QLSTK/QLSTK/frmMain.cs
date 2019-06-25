using QLSTKBUS;
using QLSTKDTO;
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
    public partial class frmMain : Form
    {
        public frmMain()
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

        private void tsTaoBaoCaoNgay_Click(object sender, EventArgs e)
        {
            BaoCaoDoanhSoNgayBUS bcBUS = new BaoCaoDoanhSoNgayBUS();
            bool kq = bcBUS.createBaoCao();
            if (kq == false)
            {
                MessageBox.Show("Không thể hoàn thành thao tác. Vui lòng kiểm tra lại dũ liệu");
            }
            else
            {
                MessageBox.Show("Báo cáo ngày được tạo thành công");
            }
        }

        private void tsCapNhatBaoCaoNgay_Click(object sender, EventArgs e)
        {
            BaoCaoDoanhSoNgayBUS bcBUS = new BaoCaoDoanhSoNgayBUS();
            bool kq = bcBUS.updateBaoCao();
            if (kq == false)
            {
                MessageBox.Show("Không thể hoàn thành thao tác. Vui lòng kiểm tra lại dũ liệu");
            }
            else
            {
                MessageBox.Show("Báo cáo ngày được cập nhật thành công");
            }
        }

        private void tstaoBaoCaoThang_Click(object sender, EventArgs e)
        {
            BaoCaoMoDongSoThangBUS bcBUS = new BaoCaoMoDongSoThangBUS();
            bool kq = bcBUS.createBaoCaoThang(DateTime.Now.Month, DateTime.Now.Year);
            if (kq == false)
            {
                MessageBox.Show("Không thể hoàn thành thao tác. Vui lòng kiểm tra lại dũ liệu");
            }
            else
            {
                MessageBox.Show("Báo cáo tháng được tạo thành công");
            }
        }

        private void tsCapNhatBaoCaoThang_Click(object sender, EventArgs e)
        {
            BaoCaoMoDongSoThangBUS bcBUS = new BaoCaoMoDongSoThangBUS();
            bool kq = bcBUS.updateBaoCaoThang(DateTime.Now.Month, DateTime.Now.Year);
            if (kq == false)
            {
                MessageBox.Show("Không thể hoàn thành thao tác. Vui lòng kiểm tra lại dũ liệu");
            }
            else
            {
                MessageBox.Show("Báo cáo tháng được cập nhật thành công");
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void TsAbout_Click(object sender, EventArgs e)
        {

        }
    }
}
