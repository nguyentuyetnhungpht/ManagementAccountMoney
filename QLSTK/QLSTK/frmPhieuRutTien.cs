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
    public partial class frmPhieuRutTien : Form
    {
        public frmPhieuRutTien()
        {
            InitializeComponent();
        }
        PhieuRutTienBUS prtBUS;

        private void frmPhieuRutTien_Load(object sender, EventArgs e)
        {
            prtBUS = new PhieuRutTienBUS();
            txtMaSoPRT.Text = prtBUS.getNewMaSo();
        }

        private void btnLuuVaXuatPhieu_Click(object sender, EventArgs e)
        {
            //1. Map data from GUI
            PhieuRutTienDTO prt = new PhieuRutTienDTO();
            prt.StrMaSoPRT = txtMaSoPRT.Text;
            prt.StrMaSTK = cmbMaSoSTK.Text;
            prt.DSoTienRut = double.Parse(txtSoTienRut.Text);
            prt.StrNgayRut = DateTime.Now.ToString();

            //----------------------------------------

            //2. Kiểm tra data hợp lệ or not

            //3. Thêm vào DB
            bool kq = prtBUS.them(prt);
            if (kq == false)
                MessageBox.Show("Thêm Phiếu rút tiền thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
                MessageBox.Show("Thêm Phiếu rút tiền thành công");
            //--------------------------------------------
        }

    }
}
