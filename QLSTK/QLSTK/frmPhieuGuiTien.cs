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
        SoTietKiemBUS stkBUS;
        KhachHangBUS khBUS;
        ThamSoBUS tsBUS;
        public frmPhieuGuiTien()
        {
            InitializeComponent();

        }

        private void frmPhieuGuiTien_Load(object sender, EventArgs e)
        {
            pgtBUS = new PhieuGuiTienBUS();
            stkBUS = new SoTietKiemBUS();
            khBUS = new KhachHangBUS();
            tsBUS = new ThamSoBUS();
            txtMaSoPGT.Text = pgtBUS.getNewMaSo();
            loadKhachhHang_Combobox();
            Load_MaSoSTk();
        }

        private void btnLuuVaXuatPhieu_Click(object sender, EventArgs e)
        {
            //1. Map data from GUI


            SoTietKiemDTO stk = stkBUS.getSoTietKiem(cmbMaSoSTK.Text);
            if (stk.StrMaLTK == "1")
            {
                PhieuGuiTienDTO pgt = new PhieuGuiTienDTO();
                pgt.StrMaSoPGT = txtMaSoPGT.Text;
                pgt.StrMaSTK = cmbMaSoSTK.Text;
                pgt.DSoTienGui = double.Parse(txtSoTienGui.Text);
                pgt.StrNgayGui = DateTime.Now.ToString();
                
                {
                    //3. Thêm vào DB
                    {
                        bool kq = pgtBUS.them(pgt);
                        if (kq == false)
                        {
                            MessageBox.Show("Thêm Phiếu gửi tiền thất bại. Vui lòng kiểm tra lại dũ liệu");
                        }
                        else
                        {
                            MessageBox.Show("Thêm Phiếu gửi tiền thành công");
                            stk.DSoTienGui = stk.DSoDu + double.Parse(txtSoTienGui.Text);
                            kq = stkBUS.suaSoTietKiem(stk);
                            if (kq == true)
                            {
                                MessageBox.Show("Cập nhật sổ tiết kiệm thành công");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật sổ tiết kiệm thất bại");
                            }

                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Bạn không thể gởi thêm tiền vào sổ tiết kiệm có kỳ hạn");
            }
            //--------------------------------------------
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
        private void cmbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Load_MaSoSTk();
        }

        private void cmbKhachHang_ValueMemberChanged(object sender, EventArgs e)
        {
           
        }
        private void Load_MaSoSTk()
        {
            List<SoTietKiemDTO> lsSTK = stkBUS.selectSTKcuaKhachHang(cmbKhachHang.SelectedValue.ToString());
            if (lsSTK == null)
            {
                MessageBox.Show("Có lỗi khi lấy Sổ tiết kiệm từ DB");
                return;
            }

            // Load Loai tiet kiem
            cmbMaSoSTK.DataSource = new BindingSource(lsSTK, String.Empty);
            cmbMaSoSTK.DisplayMember = "StrMaSoSTK";
            cmbMaSoSTK.ValueMember = "StrMaSoSTK";
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[cmbMaSoSTK.DataSource];
            myCurrencyManager.Refresh();
            if (cmbKhachHang.Items.Count > 0)
            {
                cmbKhachHang.SelectedIndex = 0;
            }
        }

        private void cmbKhachHang_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Load_MaSoSTk();
        }

        private void txtSoTienGui_Leave(object sender, EventArgs e)
        {
            
        }
    }
}