using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_PM
{
    // Regroupe les paramètres du diaporama.
    public class ListeSettings
    {
        public bool DefilementAleatoire { get; set; }

        // Vitesse du défilement en seconde
        public int VitesseCarousel { get; set; }

        public ListeSettings()
        {
            Reset();
        }

        ~ListeSettings()
        {
            SaveSettings();
        }

        public void Reset()
        {
            DefilementAleatoire = Properties.Settings.Default.DefilementAleatoireDiapo;
            VitesseCarousel = Properties.Settings.Default.VitesseDiapo;
        }

        public void SaveSettings()
        {
            Properties.Settings.Default.DefilementAleatoireDiapo = DefilementAleatoire;
            Properties.Settings.Default.VitesseDiapo = VitesseCarousel;
            Properties.Settings.Default.Save();
        }
    }
}
