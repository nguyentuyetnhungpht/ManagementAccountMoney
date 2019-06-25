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

    }
}
