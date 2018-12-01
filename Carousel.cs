using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhotoManagerClient;
using System.Threading;
namespace Client_PM
{
    public partial class Carousel : Form
    {
        public List<Photo> PhotoList { get; set; }

        public Carousel()
        {
            InitializeComponent();
        }

        private void ChangerFullScreen()
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                FormBorderStyle = FormBorderStyle.Sizable;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                FormBorderStyle = FormBorderStyle.None;
            }
        }

        private void OuvrirSettings()
        {
            CarouselSettings DLG = new CarouselSettings();

            Thread ThreadDLG = new Thread(SettingsManagement);

            ThreadDLG.Start(DLG);
            while(ThreadDLG.IsAlive)
            {

            }
        }

        private void SettingsManagement(object DLG)
        {
            try
            {
                ((CarouselSettings)DLG).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void paramètresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSettings();
        }

        private void Carousel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11) // Plein écran
            {
                ChangerFullScreen();
                e.Handled = true;
            }
        }

        private void FB_Settings_Click(object sender, EventArgs e)
        {
            OpenSettings();
            //Refresh();
        }

        private void OpenSettings()
        {
            CarouselSettings DLG = new CarouselSettings();
            DLG.Show();
        }

        private void FB_Settings_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bmp = Properties.Resources.Settings;
            bmp.MakeTransparent(Color.White);
            int x = (FB_Settings.Width - bmp.Width) / 2;
            int y = (FB_Settings.Height - bmp.Height) / 2;
            e.Graphics.DrawImage(bmp, x, y);
        }
    }
}
