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
    public partial class frmPhieuGuiTien : Form
    {
        PhieuGuiTienBUS pgtBUS;
        BaoCaoDoanhSoNgayBUS bcdsnBUS;
        public frmPhieuGuiTien()
        {
            InitializeComponent();
        }

        private void frmPhieuGuiTien_Load(object sender, EventArgs e)
        {
            pgtBUS = new PhieuGuiTienBUS();
        }

        private void btnLuuVaXuatPhieu_Click(object sender, EventArgs e)
        {
            //1. Map data from GUI
            PhieuGuiTienDTO pgt = new PhieuGuiTienDTO();
            pgt.StrMaSoPGT = txtMaSoPGT.Text;
            pgt.StrMaSTK = cmbMaSoSTK.Text;
            pgt.DSoTienGui = double.Parse(txtSoTienGui.Text);
            pgt.StrNgayGui = DateTime.Now.ToString();

            //----------------------------------------

            //2. Kiểm tra data hợp lệ or not

            //3. Thêm vào DB
            bool kq = pgtBUS.them(pgt);
            if (kq == false)
            {
                MessageBox.Show("Thêm Phiếu gửi tiền thất bại. Vui lòng kiểm tra lại dũ liệu");
            }
            else
            {
                MessageBox.Show("Thêm Phiếu gửi tiền thành công");
            }
            //--------------------------------------------
        }
    }
}
