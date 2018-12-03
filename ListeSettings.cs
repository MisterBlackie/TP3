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

        public void Reset()
        {
            DefilementAleatoire = false;
            VitesseCarousel = 3;
        }
    }
}
