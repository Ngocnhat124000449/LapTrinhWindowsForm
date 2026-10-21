using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapTrinhWindowsForm.Chuong6.ViDu
{
    public partial class VD2 : Form
    {
        public VD2()
        {
            InitializeComponent();
        }

        private void VD2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < myImageList.Images.Count; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Image = myImageList.Images[i];
                pic.Size = new Size(50, 50);
                pic.Click += new EventHandler(VD2_Click);
                myFlowLayoutPanel.Controls.Add(pic);
            }
        }

        private void VD2_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBox pic = (PictureBox)sender;
                myPictureBox.Image = pic.Image;
            }
            catch (Exception ex) { }
        }
    }
}
