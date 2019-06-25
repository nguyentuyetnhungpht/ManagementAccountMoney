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
    public partial class frmBaoCaoDoanhSoThang : DevExpress.XtraEditors.XtraForm
    {
        frmMain main = new frmMain();
        public frmBaoCaoDoanhSoThang()
        {
            InitializeComponent();
        }

        private void PnlBaoCaoThang_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnTraCuu_Click(object sender, EventArgs e)
        {

        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            main.Show();
        }
    }
}