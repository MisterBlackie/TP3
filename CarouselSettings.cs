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

    public partial class CarouselSettings : Form
    {

        ListeSettings Settings = new ListeSettings();

        public CarouselSettings()
        {
            InitializeComponent();
            Settings.VitesseCarousel = -1;
        }

        private void SetBaseValue()
        {
            Settings.VitesseCarousel = 10;
        }

        private void CarouselSettings_Load(object sender, EventArgs e)
        {
            if (Settings.VitesseCarousel == -1)
                SetBaseValue();
        }

        private void CB_DefilementAleatoire_CheckedChanged(object sender, EventArgs e)
        {
            Settings.DefilementAleatoire = CB_DefilementAleatoire.Checked;
        }

        private void TrackBarVitesse_ValueChanged(object sender, EventArgs e)
        {
            Settings.VitesseCarousel = TrackBarVitesse.Value;
        }

        private void BTN_Reset_Click(object sender, EventArgs e)
        {
            SetBaseValue();
        }
    }

    class ListeSettings
    {
        public bool DefilementAleatoire { get; set; }
        public int VitesseCarousel { get; set; }
    }
}
