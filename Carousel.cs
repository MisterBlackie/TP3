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

        private ListeSettings Settings;
        private Random Randomizer { get; set; }
        private int NbProchainePhoto { get; set; }

        public Carousel()
        {
            InitializeComponent();

            Settings = new ListeSettings();
            Randomizer = new Random();


            NbProchainePhoto = 0;
            Timer.Start();
        }

        private void ChangerFullScreen()
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                FormBorderStyle = FormBorderStyle.Sizable;
                FB_Settings.Enabled = true;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                FormBorderStyle = FormBorderStyle.None;
                FB_Settings.Enabled = false;
            }
        }

        private void SettingsManagement(object DLG)
        {
            try
            {
                ((CarouselSettings)DLG).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetProchainePhoto()
        {
            if (NbProchainePhoto >= PhotoList.Count)
            {
                NbProchainePhoto = 0;
            }

            Timer.Interval = Settings.VitesseCarousel * 1000; // Au cas que l'interval est été changé dans les settings
            PictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            PictureBox.BackgroundImage = PhotoList.ElementAt(NbProchainePhoto).GetOriginalImage();

            if (Settings.DefilementAleatoire)
                NbProchainePhoto = Randomizer.Next() % PhotoList.Count;
            else
                NbProchainePhoto++;

        }

        private void OpenSettings()
        {
            CarouselSettings DLG = new CarouselSettings(ref Settings);

            Thread ThreadDLG = new Thread(SettingsManagement);

            ThreadDLG.Start(DLG);
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
            else if (e.KeyCode == Keys.F1) // Ouverture du menu des settings
            {
                OpenSettings();
                e.Handled = true;
            }
        }

        private void FB_Settings_Click(object sender, EventArgs e)
        {
            OpenSettings();
        }

        private void FB_Settings_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bmp = Properties.Resources.Settings;
            bmp.MakeTransparent(Color.White);
            int x = (FB_Settings.Width - bmp.Width) / 2;
            int y = (FB_Settings.Height - bmp.Height) / 2;
            e.Graphics.DrawImage(bmp, x, y);
        }

        private void Carousel_Load(object sender, EventArgs e)
        {
            FB_Settings.BringToFront();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            GetProchainePhoto();
        }
    }
}
