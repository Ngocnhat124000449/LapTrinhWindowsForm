using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapTrinhWindowsForm.Chuong5.ViDu
{
    public partial class VD5 : Form
    {
        public VD5()
        {
            InitializeComponent();
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                MyWebsite.Navigate(txtAddress.Text);
        }
    }
}
