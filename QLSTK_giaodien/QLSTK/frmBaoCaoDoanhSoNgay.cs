using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLSTK
{
    public partial class frmBaoCaoDoanhSoNgay : DevExpress.XtraEditors.XtraForm
    {
        public frmBaoCaoDoanhSoNgay()
        {
            InitializeComponent();
        }

        private void PnlBaoCaoNgay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtTongThuNgay_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTongChiNgay_TextChanged(object sender, EventArgs e)
        {

        }

        private void DtpNgay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtChenhLech_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}