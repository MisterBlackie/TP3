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
        bool FullScreen = false;
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
            FullScreen = !FullScreen;
            if (FullScreen)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.MS_Carousel.Visible = false;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.MS_Carousel.Visible = true;
                this.WindowState = FormWindowState.Normal;
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
                NbProchainePhoto = 0;
            
            Timer.Interval = Settings.VitesseCarousel * 1000; // Au cas que l'interval est été changé dans les settings
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.BackgroundImage = PhotoList.ElementAt(NbProchainePhoto).GetOriginalImage();

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

        private void Carousel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11) // Plein écran
            {
                ChangerFullScreen();
            }
            else if (e.KeyCode == Keys.F1) // Ouverture du menu des settings
            {
                OpenSettings();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            GetProchainePhoto();
        }

        private void TSMI_Settings_Click(object sender, EventArgs e)
        {
            OpenSettings();

        }
    }
}
