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
        }

        private void BtnTaoBaoCao_Click(object sender, EventArgs e)
        {
            BaoCaoMoDongSoThangBUS bcBUS = new BaoCaoMoDongSoThangBUS();
            bool kq = bcBUS.createBaoCaoThang(DateTime.Now.Month, DateTime.Now.Year);
            if (kq == false)
            {
                MessageBox.Show("Không thể hoàn thành thao tác. Vui lòng kiểm tra lại dũ liệu");
            }
            else
            {
                MessageBox.Show("Báo cáo tháng được tạo thành công");
            }
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            BaoCaoMoDongSoThangBUS bcBUS = new BaoCaoMoDongSoThangBUS();
            bool kq = bcBUS.updateBaoCaoThang(DateTime.Now.Month, DateTime.Now.Year);
            if (kq == false)
            {
                MessageBox.Show("Không thể hoàn thành thao tác. Vui lòng kiểm tra lại dũ liệu");
            }
            else
            {
                MessageBox.Show("Báo cáo tháng được cập nhật thành công");
            }
        }
    }
}
