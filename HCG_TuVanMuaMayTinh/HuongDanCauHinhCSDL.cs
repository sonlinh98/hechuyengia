using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//

namespace HCG_TuVanMuaMayTinh
{
    public partial class HuongDanCauHinhCSDL : Form
    {
        public HuongDanCauHinhCSDL()
        {
            InitializeComponent();
        }

        private void FormHuongDanCauHinhCSDL_Load(object sender, EventArgs e)
        {
            textBoxSQL.Text = Resource1.String1;
        }
    }
}
