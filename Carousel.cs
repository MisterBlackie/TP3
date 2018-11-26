using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_PM
{
    public partial class Carousel : Form
    {
        public Carousel()
        {
            InitializeComponent();
        }



        private void paramètresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarouselSettings DLG = new CarouselSettings();
            DLG.Show();
        }

        private void flashButton1_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bmp = Properties.Resources.Settings;
            bmp.MakeTransparent(Color.White);
            int x = (flashButton1.Width - bmp.Width) / 2;
            int y = (flashButton1.Height - bmp.Height) / 2;
            e.Graphics.DrawImage(bmp, x, y);
        }

        private void flashButton1_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
