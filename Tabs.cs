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
    public partial class DLG_Aide : Form
    {
        public DLG_Aide()
        {
            InitializeComponent();
        }

        private void Tabs_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void Tabs_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void LoadSettings()
        {
            if (!Properties.Settings.Default.FirstUse_Tabs)
            {
                // Taille du form
                Size = Properties.Settings.Default.TailleTabs;
                // Position du form
                Location = Properties.Settings.Default.PositionTabs;
            }
        }

        private void SaveSettings()
        {
            // Taille du form
            Properties.Settings.Default.TailleTabs = Size;
            // Position du form
            Properties.Settings.Default.PositionTabs = Location;

            Properties.Settings.Default.FirstUse_Tabs = false;
            Properties.Settings.Default.Save();

        }
    }
}
