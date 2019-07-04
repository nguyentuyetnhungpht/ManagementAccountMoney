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

using System.Data.SqlClient;



namespace QLSTK
{
    public partial class frmQuyDinh : Form
    {

        private ThamSoBUS tsBUS;
        private LoaiTietKiemBUS ltkBUS;
        public frmQuyDinh()
        {
            InitializeComponent();
        }

        private void frmQuyDinh_Load(object sender, EventArgs e)
        {

            ltkBUS = new LoaiTietKiemBUS();
            tsBUS = new ThamSoBUS();

            ThamSoDTO ts = new ThamSoDTO();
            DataTable dtThamSo = tsBUS.getThamSo(); // get Tham so
            txtTienGuiToiThieu.Text = (dtThamSo.Rows[0][1]).ToString(); // tu dong hien thi tham so
            txtThoiGianGuiToiThieu.Text = (dtThamSo.Rows[0][3]).ToString(); // tu dong hien thi tham so
            loadLoaiTietKiemVao_Combobox(); // load thong tin cac loai tiet kiem dang co
        }
        private void loadLoaiTietKiemVao_Combobox()
        {

            List<LoaiTietKiemDTO> listLTK = ltkBUS.selectListLTK();

            if (listLTK == null)
            {
                MessageBox.Show("Có lỗi khi lấy LaoiTietKiem từ DB");
                return;
            }
            // Load Loai tiet kiem
            cmbMaLoaiTietKiem.DataSource = new BindingSource(listLTK, String.Empty);
            cmbMaLoaiTietKiem.DisplayMember = "StrMaLTK";
            cmbMaLoaiTietKiem.ValueMember = "StrMaLTK";
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[cmbMaLoaiTietKiem.DataSource];
            myCurrencyManager.Refresh();


            // Load Loai Ky Han
            cmbLoaiKyHan.DataSource = new BindingSource(listLTK, String.Empty);
            cmbLoaiKyHan.DisplayMember = "IKyhan";
            cmbLoaiKyHan.ValueMember = "IKyHan";
            myCurrencyManager = (CurrencyManager)this.BindingContext[cmbMaLoaiTietKiem.DataSource];
            myCurrencyManager.Refresh();

            cmbLoaiKyHan_QD3.DataSource = new BindingSource(listLTK, String.Empty);
            cmbLoaiKyHan_QD3.DisplayMember = "IKyhan";
            cmbLoaiKyHan_QD3.ValueMember = "StrMaLTK";
            myCurrencyManager = (CurrencyManager)this.BindingContext[cmbLoaiKyHan_QD3.DataSource];
            myCurrencyManager.Refresh();



            // Load Ten Loai Tiet Kiem
            cmbTenLoaiTietKiem.DataSource = new BindingSource(listLTK, String.Empty);
            cmbTenLoaiTietKiem.DisplayMember = "StrTenLTK";
            cmbTenLoaiTietKiem.ValueMember = "StrTenLTK";
            myCurrencyManager = (CurrencyManager)this.BindingContext[cmbMaLoaiTietKiem.DataSource];


            if (cmbMaLoaiTietKiem.Items.Count > 0)
            {
                cmbMaLoaiTietKiem.SelectedIndex = 0;
            }
        }

        private void btnthemKyHan_Click(object sender, EventArgs e)
        {
            //1. Map data from GUI
            LoaiTietKiemDTO ltk = new LoaiTietKiemDTO();
            ltk.StrMaLTK = cmbMaLoaiTietKiem.Text;
            ltk.StrTenLTK = cmbTenLoaiTietKiem.Text;
            ltk.FLaiSuat = float.Parse(txtLaiSuat_QD1.Text);
            ltk.IKyHan = int.Parse(cmbLoaiKyHan.Text);

            //2. Kiểm tra data hợp lệ or not

            //3. Thêm vào DB
            bool kq = ltkBUS.them(ltk);
            if (kq == false)
                MessageBox.Show("Thêm Loại tiết kiệm thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
                MessageBox.Show("Thêm Loại tiết kiệm thành công");
        }

        private void btnXoaKyHan_Click(object sender, EventArgs e)
        {
            //1. Map key primary from GUI
            LoaiTietKiemDTO ltk = new LoaiTietKiemDTO();
            ltk.StrMaLTK = cmbMaLoaiTietKiem.Text;
            //2. Kiểm tra data hợp lệ

            //3. Xóa khỏi DB
            bool kq = ltkBUS.xoa(ltk);
            if (kq == false)
                MessageBox.Show("Xóa kỳ hạn thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
                MessageBox.Show("Xóa kỳ hạn thành công");

        }

        private void btnSuaKyHan_Click(object sender, EventArgs e)
        {
            //1. Map data from GUI
            LoaiTietKiemDTO ltk = new LoaiTietKiemDTO();
            ltk.StrMaLTK = cmbMaLoaiTietKiem.Text;
            ltk.StrTenLTK = cmbTenLoaiTietKiem.Text;
            ltk.FLaiSuat = float.Parse(txtLaiSuat_QD1.Text);
            ltk.IKyHan = int.Parse(cmbLoaiKyHan.Text);

            //2. Kiểm tra data hợp lệ or not

            //3. Thêm vào DB
            bool kq = ltkBUS.sua(ltk);
            if (kq == false)
                MessageBox.Show("Sửa Loại tiết kiệm thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
                MessageBox.Show("Sửa Loại tiết kiệm thành công"); 
        }

        private void btnThayDoiTienGuiToiThieu_Click(object sender, EventArgs e)
        {
            
            ThamSoDTO ts = new ThamSoDTO();
            ts.DSoTienGuiToiThieuPGT = double.Parse(txtTienGuiToiThieu.Text);

            bool kq = tsBUS.suaThamSo(ts);
            if (kq == false)
                MessageBox.Show("Thay đổi Tiền gửi tối thiểu thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
                MessageBox.Show("Thay đổi Tiền gửi tối thiểu thành công");
        }

        private void btnThayDoiThoiGianGuiToiThieu_Click(object sender, EventArgs e)
        {
            ThamSoDTO ts = new ThamSoDTO();
            ts.ISoNgayGuiToiThieu = int.Parse(txtThoiGianGuiToiThieu.Text);

            bool kq = tsBUS.suaThamSo(ts);
            if (kq == false)
                MessageBox.Show("Thay đổi Thời gian gửi tối thiểu thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
                MessageBox.Show("Thay đổi Thời gian gửi tối thiểu thành công");
        }

        private void btnThayDoiLoaiKyHan_Click(object sender, EventArgs e)
        {
            LoaiTietKiemDTO ltk = new LoaiTietKiemDTO();
            ltk.StrMaLTK = cmbLoaiKyHan.ValueMember.ToString();
            ltk.FLaiSuat = float.Parse(txtLaiSuat_QD3.Text);

            bool kq = ltkBUS.sua(ltk);
            if (kq == false)
                MessageBox.Show("Thay đổi Lãi suất loại kỳ hạn thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
                MessageBox.Show("Thay đổi Lãi suất loại kỳ hạn thành công");
        }

        private void cmbMaLoaiTietKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maLoaiTK = cmbMaLoaiTietKiem.SelectedValue.ToString();

        }

        private void cmbTenLoaiTietKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenLoaiTK = cmbTenLoaiTietKiem.SelectedValue.ToString();
        }

        private void cmbLoaiKyHan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string loaiKyhan = cmbLoaiKyHan.SelectedValue.ToString();
        }

        private void grbQuyDinh1_Enter(object sender, EventArgs e)
        {

        }
    }
}
