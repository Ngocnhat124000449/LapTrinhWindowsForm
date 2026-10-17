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
    public partial class VD6 : Form
    {
        public VD6()
        {
            InitializeComponent();
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            MyStatusLabel.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
