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
    public partial class frmBaoCaoDoanhSoNgay : Form
    {
        private BaoCaoDoanhSoNgayBUS bcBUS;
        public frmBaoCaoDoanhSoNgay()
        {
            InitializeComponent();

            
        }

        private void frmBaoCaoDoanhSoNgay_Load(object sender, EventArgs e)
        {
            bcBUS = new BaoCaoDoanhSoNgayBUS();
            Load_data();

        }
        private void Load_data()
        {
            DateTime dt = dtpNgayBaoCao.Value;
            List<BaoCaoDoanhSoNgayDTO> listBaoCao = bcBUS.getListBaoCao(dt);

            if (listBaoCao == null)
            {
                MessageBox.Show("Có lỗi khi lấy danh sach từ DB");
                return;
            }

            dgvBaoCao.Columns.Clear();
            dgvBaoCao.DataSource = null;

            dgvBaoCao.AutoGenerateColumns = false;
            dgvBaoCao.AllowUserToAddRows = false;
            dgvBaoCao.DataSource = listBaoCao;

            DataGridViewTextBoxColumn clSTT = new DataGridViewTextBoxColumn();
            clSTT.Name = "STT";
            clSTT.HeaderText = "STT";
            //clSTT.DataPropertyName = "STT";
            dgvBaoCao.Columns.Add(clSTT);


            DataGridViewTextBoxColumn clNgayMoSo = new DataGridViewTextBoxColumn();
            clNgayMoSo.Name = "NgayBCDS";
            clNgayMoSo.HeaderText = "Ngày";
            clNgayMoSo.DataPropertyName = "StrNgayBCDS";
            dgvBaoCao.Columns.Add(clNgayMoSo);

            DataGridViewTextBoxColumn clMaLTK = new DataGridViewTextBoxColumn();
            clMaLTK.Name = "MaLTK";
            clMaLTK.HeaderText = "Loại tiết kiệm";
            clMaLTK.DataPropertyName = "StrMaLTK";
            dgvBaoCao.Columns.Add(clMaLTK);

            DataGridViewTextBoxColumn clTongThu = new DataGridViewTextBoxColumn();
            clTongThu.Name = "TongThu";
            clTongThu.HeaderText = "Tổng thu";
            clTongThu.DataPropertyName = "DTongThu";
            dgvBaoCao.Columns.Add(clTongThu);

            DataGridViewTextBoxColumn clTongChi = new DataGridViewTextBoxColumn();
            clTongChi.Name = "TongChi";
            clTongChi.HeaderText = "Tổng chi";
            clTongChi.DataPropertyName = "DTongChi";
            dgvBaoCao.Columns.Add(clTongChi);

            DataGridViewTextBoxColumn clChenhLechTien = new DataGridViewTextBoxColumn();
            clChenhLechTien.Name = "ChenhLechTien";
            clChenhLechTien.HeaderText = "Chênh lệch";
            clChenhLechTien.DataPropertyName = "DChenhLechTien";
            dgvBaoCao.Columns.Add(clChenhLechTien);




            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvBaoCao.DataSource];// ho tro binding du lieu
            myCurrencyManager.Refresh();


        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            Load_data();

        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {

        }

        private void dgvBaoCao_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvBaoCao.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
