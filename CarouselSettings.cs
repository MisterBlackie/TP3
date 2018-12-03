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

        public CarouselSettings(ref ListeSettings Liste)
        {
            InitializeComponent();

            Settings = Liste;
        }

        private void SetValue()
        {
            TrackBarVitesse.Value = Settings.VitesseCarousel;
            CB_DefilementAleatoire.Checked = Settings.DefilementAleatoire;
        }

        private void CarouselSettings_Load(object sender, EventArgs e)
        {
            SetValue();
        }

        private void CB_DefilementAleatoire_CheckedChanged(object sender, EventArgs e)
        {
            Settings.DefilementAleatoire = CB_DefilementAleatoire.Checked;
        }

        private void TrackBarVitesse_ValueChanged(object sender, EventArgs e)
        {
            if (TrackBarVitesse.Value == 0)
                TrackBarVitesse.Value++;

            Settings.VitesseCarousel = TrackBarVitesse.Value;
        }

        private void BTN_Reset_Click(object sender, EventArgs e)
        {
            Settings.Reset();
            SetValue();
        }
    }
}
