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
        private SoTietKiemBUS stkBUS;
        public frmPhieuGuiTien()
        {
            InitializeComponent();
            pgtBUS = new PhieuGuiTienBUS();
            txtMaSoPGT.Text = pgtBUS.getNewMaSo();
        }

        private void frmPhieuGuiTien_Load(object sender, EventArgs e)
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
            //-------------------------------------------

        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Đã huỷ, bạn có muốn đóng ứng dụng sổ tiết kiệm?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void CmbMaSoSTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maSTK = cmbMaSoSTK.SelectedValue.ToString();
        }

        private void CmbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maKh = cmbKhachHang.SelectedValue.ToString();
        }

        //rang buoc du lieu nhap vao, chi dc nhap so
        private void TxtSoTienGui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
             
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
