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
    public partial class A_propos : Form
    {
        public A_propos()
        {
            InitializeComponent();
        }

        private void LoadSettings()
        {
            if (!Properties.Settings.Default.FirstUse_APropos)
            {
                // Taille du form
                Size = Properties.Settings.Default.TailleAPropos;

                // Position du form
                Location = Properties.Settings.Default.PositionAPropos;
            }
        }

        private void SaveSettings()
        {
            // Taille du form
            Properties.Settings.Default.TailleAPropos = Size;

            // Position du form
            Properties.Settings.Default.PositionAPropos = Location;

            Properties.Settings.Default.FirstUse_APropos = false;

            Properties.Settings.Default.Save();
        }

        private void A_propos_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void A_propos_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }
    }
}
