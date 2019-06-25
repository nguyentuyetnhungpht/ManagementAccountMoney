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

        
    }
}
