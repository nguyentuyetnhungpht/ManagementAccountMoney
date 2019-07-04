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
        SoTietKiemBUS stkBUS;
        KhachHangBUS khBUS;

        private void frmPhieuRutTien_Load(object sender, EventArgs e)
        {
            prtBUS = new PhieuRutTienBUS();
            stkBUS = new SoTietKiemBUS();
            khBUS = new KhachHangBUS();
            txtMaSoPRT.Text = prtBUS.getNewMaSo();
            loadKhachhHang_Combobox();
                
        }

        private void btnLuuVaXuatPhieu_Click(object sender, EventArgs e)
        {
            //1. Map data from GUI
            PhieuRutTienDTO prt = new PhieuRutTienDTO();
            prt.StrMaSoPRT = txtMaSoPRT.Text;
            prt.StrMaSTK = cmbMaSoSTK.Text;
            prt.DSoTienRut = double.Parse(txtSoTienRut.Text);
            prt.StrNgayRut = DateTime.Now.ToString();
            SoTietKiemDTO stk = stkBUS.getSoTietKiem(cmbMaSoSTK.Text);
            //----------------------------------------

            //2. Kiểm tra data hợp lệ or not

            if (stk.StrMaLTK == "1")
            {
                if (double.Parse(txtSoTienRut.Text) > double.Parse(stk.DSoDu.ToString()))
                {
                    MessageBox.Show("Số tiền rút không hợp lệ");
                }
                else
                {
                    //3. Thêm vào DB
                    bool kq = prtBUS.them(prt);
                    if (kq == false)
                        MessageBox.Show("Thêm Phiếu rút tiền thất bại. Vui lòng kiểm tra lại dũ liệu");
                    else
                    {
                        MessageBox.Show("Thêm Phiếu rút tiền thành công");
                        stk.DSoTienGui = stk.DSoDu - double.Parse(txtSoTienRut.Text);
                        kq = stkBUS.suaSoTietKiem(stk);
                        if (kq == false)
                            MessageBox.Show("Cập nhật sổ tiết kiệm thất bại. Vui lòng kiểm tra lại dũ liệu");
                        else
                        {
                            MessageBox.Show("Cập nhật sổ tiết kiệm thành công.");
                        }
                    }
                }
            }
            else
            {
                bool kq = prtBUS.them(prt);
                if (kq == false)
                    MessageBox.Show("Thêm Phiếu rút tiền thất bại. Vui lòng kiểm tra lại dũ liệu");
                else
                {
                    MessageBox.Show("Thêm Phiếu rút tiền thành công");
                }
                stk.DSoTienGui = 0;
                kq = stkBUS.suaSoTietKiem(stk);
                if (kq == false)
                    MessageBox.Show("Cập nhật sổ tiết kiệm thất bại. Vui lòng kiểm tra lại dũ liệu");
                else
                {
                    MessageBox.Show("Sổ đóng");
                }
            }

            //--------------------------------------------
        }

        private void cmbMaSoSTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaSoSTK.Text != "1")
            {
                SoTietKiemDTO stk = stkBUS.getSoTietKiem(cmbMaSoSTK.Text);
                txtSoTienRut.Text = stk.DSoDu.ToString();
                txtSoTienRut.ReadOnly = true;
            }
        }

        private void txtSoTienRut_Leave(object sender, EventArgs e)
        {
            if (cmbMaSoSTK.Text == "1")
            {
                SoTietKiemDTO stk = stkBUS.getSoTietKiem(cmbMaSoSTK.Text);

                if (double.Parse(txtSoTienRut.Text) > double.Parse(stk.DSoDu.ToString()))
                {
                    MessageBox.Show("Số tiền rút không hợp lệ");
                }

            }
        }
        private void loadKhachhHang_Combobox()
        {

            List<KhachHangDTO> listLTK = khBUS.selectListLTK();

            if (listLTK == null)
            {
                MessageBox.Show("Có lỗi khi lấy LaoiTietKiem từ DB");
                return;
            }
            // Load Loai tiet kiem
            cmbKhachHang.DataSource = new BindingSource(listLTK, String.Empty);
            cmbKhachHang.DisplayMember = "StrHoTenKH";
            cmbKhachHang.ValueMember = "StrMaKH";
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[cmbKhachHang.DataSource];
            myCurrencyManager.Refresh();

            if (cmbKhachHang.Items.Count > 0)
            {
                cmbKhachHang.SelectedIndex = 0;
            }
        }
    }
}