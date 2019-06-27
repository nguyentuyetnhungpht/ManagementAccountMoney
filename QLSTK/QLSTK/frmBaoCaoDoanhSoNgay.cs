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
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {


        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnTaoBaoCao_Click(object sender, EventArgs e)
        {
            BaoCaoDoanhSoNgayBUS bcBUS = new BaoCaoDoanhSoNgayBUS();
            bool kq = bcBUS.createBaoCao();
            if (kq == false)
            {
                MessageBox.Show("Không thể hoàn thành thao tác. Vui lòng kiểm tra lại dũ liệu");
            }
            else
            {
                MessageBox.Show("Báo cáo ngày được tạo thành công");
            }
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            BaoCaoDoanhSoNgayBUS bcBUS = new BaoCaoDoanhSoNgayBUS();
            bool kq = bcBUS.updateBaoCao();
            if (kq == false)
            {
                MessageBox.Show("Không thể hoàn thành thao tác. Vui lòng kiểm tra lại dũ liệu");
            }
            else
            {
                MessageBox.Show("Báo cáo ngày được cập nhật thành công");
            }
        }
    }
}
