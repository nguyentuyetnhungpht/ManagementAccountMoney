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
    public partial class frmTraCuu : Form
    {
        private SoTietKiemBUS stkBUS;
        private LoaiTietKiemBUS ltkBUS;
        public frmTraCuu()
        {
            InitializeComponent();
           
        }
         private void frmTraCuu_Load(object sender, EventArgs e)
        {
            stkBUS = new SoTietKiemBUS();
            ltkBUS = new LoaiTietKiemBUS();
        }
        private void btTimKiem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string maso = cmbMaSo.Text.Trim();
            string makh = cmbMaKH.Text.Trim();
            string maltk = cmbMaLTK.Text.Trim();
            double minsodu = 0;
            double maxsodu = 0;
            DateTime minNgay = dtpTuNgay.Value;
            DateTime maxNgay = dtpToiNgay.Value;


            if (maso == null || maso == string.Empty || maso.Length == 0)
            {
                maso = "";
            }
            if (makh == null || makh == string.Empty || makh.Length == 0)
            {
                makh = "";
            }
            if (maltk == null || maltk == string.Empty || maltk.Length == 0)
            {
                maltk = "";
            }
            try
            {
                minsodu = double.Parse(txtMinSoDu.Text);
            }
            catch
            {
                minsodu = 0;
            }
            try
            {
                maxsodu = double.Parse(txtMaxSoDu.Text);
            }
            catch
            {
                maxsodu = 0;
            }



            List<SoTietKiemDTO> listSTK = stkBUS.selectSTK(maso, makh, maltk, minsodu, maxsodu, minNgay, maxNgay);

            if (listSTK == null)
            {
                MessageBox.Show("Có lỗi khi lấy sổ tiết kiệm từ DB");
                return;
            }

            dgvSoTietKiem.Columns.Clear();
            dgvSoTietKiem.DataSource = null;

            dgvSoTietKiem.AutoGenerateColumns = false;
            dgvSoTietKiem.AllowUserToAddRows = false;
            dgvSoTietKiem.DataSource = listSTK;

            DataGridViewTextBoxColumn clSTT = new DataGridViewTextBoxColumn();
            clSTT.Name = "STT";
            clSTT.HeaderText = "STT";
            clSTT.CellTemplate.Value = "*";
            dgvSoTietKiem.Columns.Add(clSTT);

            DataGridViewTextBoxColumn clMaSoSTK = new DataGridViewTextBoxColumn();
            clMaSoSTK.Name = "MaSoSTK";
            clMaSoSTK.HeaderText = "Mã Số Sổ TIết Kiệm";
            clMaSoSTK.DataPropertyName = "StrMaSoSTK";
            dgvSoTietKiem.Columns.Add(clMaSoSTK);


            DataGridViewTextBoxColumn clLoaiTietKiem = new DataGridViewTextBoxColumn();
            clLoaiTietKiem.Name = "MaLTK";
            clLoaiTietKiem.HeaderText = "Mã Số";
            clLoaiTietKiem.DataPropertyName = "StrMaLTK";
            dgvSoTietKiem.Columns.Add(clLoaiTietKiem);

            DataGridViewTextBoxColumn clKhachHang = new DataGridViewTextBoxColumn();
            clKhachHang.Name = "MaKH";
            clKhachHang.HeaderText = "Khách hàng";
            clKhachHang.DataPropertyName = "StrMaKH";
            dgvSoTietKiem.Columns.Add(clKhachHang);

            DataGridViewTextBoxColumn clSoDu = new DataGridViewTextBoxColumn();
            clSoDu.Name = "SoDu";
            clSoDu.HeaderText = "Số dư";
            clSoDu.DataPropertyName = "DSoDu";
            dgvSoTietKiem.Columns.Add(clSoDu);

            DataGridViewTextBoxColumn clNgayMoSo = new DataGridViewTextBoxColumn();
            clNgayMoSo.Name = "NgayMoSo";
            clNgayMoSo.HeaderText = "Ngày mở sổ";
            clNgayMoSo.DataPropertyName = "StrNgayMoSo";
            dgvSoTietKiem.Columns.Add(clNgayMoSo);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvSoTietKiem.DataSource];// ho tro binding du lieu
            myCurrencyManager.Refresh();
        }
        private void cmsSuaSTK_Click(object sender, EventArgs e)
        {
            // ' Get the current cell location.
            int currentRowIndex = dgvSoTietKiem.CurrentCellAddress.Y;// 'current row selected


            //'Verify that indexing OK
            if (-1 < currentRowIndex && currentRowIndex < dgvSoTietKiem.RowCount)
            {
                SoTietKiemDTO kn = (SoTietKiemDTO)dgvSoTietKiem.Rows[currentRowIndex].DataBoundItem;
                if (kn != null)
                {
                    frmSoTietKiem frm = new frmSoTietKiem(kn);
                    frm.ShowDialog();
                }
            }
        }

        private void cmsXoaSTK_Click(object sender, EventArgs e)
        {
            // ' Get the current cell location.
            //int currentRowIndex = dgvSoTietKiem.CurrentCellAddress.Y;// 'current row selected


            //'Verify that indexing OK
            //if (-1 < currentRowIndex && currentRowIndex < dgvSoTietKiem.RowCount)
            //{
            //    SoTietKiemDTO stk = (SoTietKiemDTO)dgvSoTietKiem.Rows[currentRowIndex].DataBoundItem;
            //    if (stk != null)
            //    {
            //        bool kt = stkBUS.dongSoTietKiem(stk);
            //        if (kt == false)
            //            MessageBox.Show("Đóng sổ tiết kiệm thất bại. Vui lòng kiểm tra lại dũ liệu");
            //        else
            //        {
            //            MessageBox.Show("Đóng sổ tiết kiệm thành công");
            //            this.LoadData();
            //        }
            //    }
            //}

            // ' Get the current cell location.
            int currentRowIndex = dgvSoTietKiem.CurrentCellAddress.Y;// 'current row selected


            //'Verify that indexing OK
            if (-1 < currentRowIndex && currentRowIndex < dgvSoTietKiem.RowCount)
            {
                SoTietKiemDTO stk = (SoTietKiemDTO)dgvSoTietKiem.Rows[currentRowIndex].DataBoundItem;
                if (stk != null)
                {
                    frmSoTietKiem frm = new frmSoTietKiem(stk);
                    frm.ShowDialog();
                }
            }

        }

        private void dgvSoTietKiem_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvSoTietKiem.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
