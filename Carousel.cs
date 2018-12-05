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
        private List<Photo> Photos;
        private ListeSettings Settings;
        private int[] Order;
        private bool Random = false;
        private bool FullScreen = false;
        private int CurrentIndex;


        public Carousel()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.BackColor = Color.Black;
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.AllowTransparency = false;
            Settings = new ListeSettings();
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

        private void TSMI_Settings_Click(object sender, EventArgs e)
        {
            OpenSettings();

        }

        private void Carousel_Shown(object sender, EventArgs e)
        {
            Photos = new List<Photo>();
            foreach (Photo Photo in PhotoList)
            {
                if (Photo != null)
                    Photos.Add(Photo);
            }
            SetOrder();
            Timer.Start();
        }

        private void SetOrder()
        {
            CurrentIndex = 0;
            int Count = Photos.Count;
            Order = new int[Count];

            for (int i = 0; i < Count; i++)
            {
                Order[i] = i;
            }
            if (Random)
                Randomize();
            Next();
        }

        private void Randomize()
        {
            Random Rand = new Random(DateTime.Now.Second);
            int nb_Photos = Photos.Count;
            for (int i = 0; i < nb_Photos - 1; i++)
            {
                int j = Rand.Next((nb_Photos - i - 2)) + i + 1;
                int k = Order[i];
                Order[i] = Order[j];
                Order[j] = k;
            }
        }

        private void Next()
        {
            if (Order.Count() > 0)
            {
                // Régler l'image de fond avec la prochaine photo
                this.BackgroundImage = Photos[Order[CurrentIndex]].GetOriginalImage();
                // Index de la prochaine photo. Si était la dernière, revenir à la première
                CurrentIndex = CurrentIndex < Photos.Count - 1 ? CurrentIndex + 1 : 0;
            }
        }

        private void LoadSettings()
        {
            if (!Properties.Settings.Default.FirstUse_Carousel)
            {
                // Taille du form
                Size = Properties.Settings.Default.TailleCarousel;

                // Position du form
                Location = Properties.Settings.Default.PositionCarousel;
            }
        }

        private void SaveSettings()
        {
            // Taille du form
            Properties.Settings.Default.TailleCarousel = Size;

            // Position du form
            Properties.Settings.Default.PositionCarousel = Location;

            Properties.Settings.Default.FirstUse_Carousel = false;
            Properties.Settings.Default.Save();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Next();
            Timer.Interval = 500 * Settings.VitesseCarousel;
        }

        private void Carousel_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void Carousel_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void TSMI_FullScreen_Click(object sender, EventArgs e)
        {
            ChangerFullScreen();
        }
    }
}
