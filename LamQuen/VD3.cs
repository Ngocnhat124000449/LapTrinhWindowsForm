using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LapTrinhWindowsForm.utilities;

namespace LapTrinhWindowsForm.LamQuen
{
    public partial class VD3 : Form
    {
        public VD3()
        {
            InitializeComponent();
        }

        private void btn_HCN_Click(object sender, EventArgs e)
        {
            VD1 vD = new VD1();
            vD.ShowDialog();
        }

        private void btn_SoLN_Click(object sender, EventArgs e)
        {
            VD2 vD = new VD2();
            vD.ShowDialog();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MyExtentions.XacNhanThoat(this)) this.Close();
        }
    }
}
