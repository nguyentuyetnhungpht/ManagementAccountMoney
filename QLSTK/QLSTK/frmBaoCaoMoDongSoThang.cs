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
    public partial class frmBaoCaoMoDongSoThang : Form
    {
        private BaoCaoMoDongSoThangBUS bcBUS;
        public frmBaoCaoMoDongSoThang()
        {
            InitializeComponent();
        }

        private void frmBaoCaoDoanhSoThang_Load(object sender, EventArgs e)
        {
            bcBUS = new BaoCaoMoDongSoThangBUS();
            Load_Data();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            Load_Data();
        }
        private void Load_Data()
        {
            List<BaoCaoMoDongSoThangDTO> listBaoCao;
            try
            {
                listBaoCao = bcBUS.getListBaoCaoThang(int.Parse(cmbThang.Text), int.Parse(cmbNam.Text), cmbLoaiTietKiem.Text);
            }
            catch
            {
                listBaoCao = bcBUS.getListBaoCaoThang(DateTime.Now.Month, DateTime.Now.Year, cmbLoaiTietKiem.Text);
                cmbThang.Text = DateTime.Now.Month.ToString();
                cmbNam.Text = DateTime.Now.Year.ToString();
            }
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


            DataGridViewTextBoxColumn clNgayBaoCao = new DataGridViewTextBoxColumn();
            clNgayBaoCao.Name = "NgayBCMDST";
            clNgayBaoCao.HeaderText = "Ngày";
            clNgayBaoCao.DataPropertyName = "StrNgayBCMDST";
            dgvBaoCao.Columns.Add(clNgayBaoCao);


            DataGridViewTextBoxColumn clSoMo = new DataGridViewTextBoxColumn();
            clSoMo.Name = "SoMo";
            clSoMo.HeaderText = "Sổ mở";
            clSoMo.DataPropertyName = "ISoMo";
            dgvBaoCao.Columns.Add(clSoMo);

            DataGridViewTextBoxColumn clSoDong = new DataGridViewTextBoxColumn();
            clSoDong.Name = "SoDong";
            clSoDong.HeaderText = "Sổ đóng";
            clSoDong.DataPropertyName = "ISoDong";
            dgvBaoCao.Columns.Add(clSoDong);

            DataGridViewTextBoxColumn clChenhLechSo = new DataGridViewTextBoxColumn();
            clChenhLechSo.Name = "ChenhLechSo";
            clChenhLechSo.HeaderText = "Chênh lệch";
            clChenhLechSo.DataPropertyName = "IChenhLechSo";
            dgvBaoCao.Columns.Add(clChenhLechSo);



            int sum = 0;
            for (int i = 0; i < dgvBaoCao.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvBaoCao.Rows[i].Cells[3].Value);
            }
            txtTongThuNgay.Text = sum.ToString();

            for (int i = 0; i < dgvBaoCao.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvBaoCao.Rows[i].Cells[4].Value);
            }
            txtTongChiNgay.Text = sum.ToString();

            txtChenhLech.Text = (int.Parse(txtTongChiNgay.Text) - int.Parse(txtTongThuNgay.Text)).ToString();


            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvBaoCao.DataSource];// ho tro binding du lieu
            myCurrencyManager.Refresh();
        }

        private void dgvBaoCao_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvBaoCao.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
