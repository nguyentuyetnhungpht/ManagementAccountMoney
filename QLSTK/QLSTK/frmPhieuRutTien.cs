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
        PhieuRutTienBUS prtBUS;
        private SoTietKiemBUS stkBUS;
        public frmPhieuRutTien()
        {
            InitializeComponent();
            prtBUS = new PhieuRutTienBUS();
            txtMaSoPRT.Text = prtBUS.getNewMaSo();
        }

        private void frmPhieuRutTien_Load(object sender, EventArgs e)
        {
            stkBUS = new SoTietKiemBUS();
            LoadDuLieuVao_Combobox();
        }

        private void LoadDuLieuVao_Combobox()
        {
            List<SoTietKiemDTO> listSTK = stkBUS.seclectSoTietKiem();

            if (listSTK == null)
            {
                MessageBox.Show("Có lỗi khi lấy LoaiTietKiem từ DB");
                return;
            }

            //Load ma khach hang
            cmbKhachHang.DataSource = new BindingSource(listSTK, String.Empty);
            cmbKhachHang.DisplayMember = "StrMaKH";
            cmbKhachHang.ValueMember = "StrMaKH";
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[cmbKhachHang.DataSource];
            myCurrencyManager.Refresh();

            //Load ma so tiet kiem
            cmbMaSoSTK.DataSource = new BindingSource(listSTK, String.Empty);
            cmbMaSoSTK.DisplayMember = "StrMaSoSTK";
            cmbMaSoSTK.ValueMember = "StrMaSoSTK";
            myCurrencyManager = (CurrencyManager)this.BindingContext[cmbMaSoSTK.DataSource];
            myCurrencyManager.Refresh();


            if (cmbMaSoSTK.Items.Count > 0)
            {
                cmbMaSoSTK.SelectedIndex = 0;
            }

            if (cmbKhachHang.Items.Count > 0)
            {
                cmbKhachHang.SelectedIndex = 0;
            }
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

        private void CmbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maKh = cmbKhachHang.SelectedValue.ToString();
        }

        private void CmbMaSoSTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maSTK = cmbMaSoSTK.SelectedValue.ToString();
        }
    }
}
