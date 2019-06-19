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
    public partial class frmSoTietKiem : Form
    {
        private SoTietKiemBUS stkBUS;
        private LoaiTietKiemBUS ltkBUS;
        private KhachHangBUS khBUS;
        public frmSoTietKiem()
        {
            InitializeComponent();
        }
        public frmSoTietKiem(SoTietKiemDTO stk)
        {
            InitializeComponent();

            khBUS = new KhachHangBUS();
            KhachHangDTO kh = khBUS.getKhachHang(stk.StrMaKH);
            txtMaSoSTK.Text = stk.StrMaSoSTK;
            txtMaKH.Text = stk.StrMaKH;
            txtCMND.Text = kh.StrCMND;
            txtDiaChi.Text = kh.StrDiaChi;
            txtSoTienGui.Text = stk.DSoDu.ToString();
            cmbLoaiTietKiem.Text = stk.StrMaLTK;
        }
        private void frmSoTietKiem_Load(object sender, EventArgs e)
        {
            stkBUS = new SoTietKiemBUS();
            ltkBUS = new LoaiTietKiemBUS();
            load_MaLTK();
        }
        private void load_MaLTK()
        {
            List<LoaiTietKiemDTO> listLTK = ltkBUS.selectListLTK();

            if (listLTK == null)
            {
                MessageBox.Show("Có lỗi khi lấy LoaiTietKiem từ DB");
                return;
            }
            // Load Loai tiet kiem
            cmbLoaiTietKiem.DataSource = new BindingSource(listLTK, String.Empty);
            cmbLoaiTietKiem.DisplayMember = "StrMaLTK";
            cmbLoaiTietKiem.ValueMember = "StrMaLTK";
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[cmbLoaiTietKiem.DataSource];
            myCurrencyManager.Refresh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //1. Map data from GUI

            //1.1 info từ form Sổ tiết kiểm
            SoTietKiemDTO stk = new SoTietKiemDTO();
            stk.StrMaSoSTK = txtMaSoSTK.Text;
            stk.StrMaKH = txtMaKH.Text;
            stk.DSoTienGui = double.Parse(txtSoTienGui.Text);
            stk.StrMaLTK = cmbLoaiTietKiem.Text;
            stk.StrNgayMoSo = (DateTime.Now).ToString();
            stk.DSoDu = double.Parse(txtSoTienGui.Text);
            //----------------------------------------
        

            //1.2 info từ table tblLoaiTietKiem
            LoaiTietKiemDTO ltk = ltkBUS.getLoaiTietKiem(cmbLoaiTietKiem.Text);
            stk.FLaiSuatCamKet = ltk.FLaiSuat;
            stk.IKyHanCamKet = ltk.IKyHan;
            //----------------------------------------------

            //2. Kiểm tra data hợp lệ or not

            //3. Thêm vào DB
            bool kq = stkBUS.themSoTietKiem(stk);
            if (kq == false)
                MessageBox.Show("Thêm Loại tiết kiệm thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
                MessageBox.Show("Thêm Loại tiết kiệm thành công");
            //--------------------------------------------
        }

        private void btnDongSo_Click(object sender, EventArgs e)
        {
            //1. Map key primary from GUI
            SoTietKiemDTO stk = new SoTietKiemDTO();
            stk.StrMaSoSTK = txtMaSoSTK.Text;
            //2. Kiểm tra data hợp lệ

            //3. Xóa khỏi DB
            bool kq = stkBUS.dongSoTietKiem(stk);
            if (kq == false)
                MessageBox.Show("Đóng Sổ Tiết Kiệm thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
                MessageBox.Show("Đóng Sổ tiết kiệm thành công");
        }
    }
}
