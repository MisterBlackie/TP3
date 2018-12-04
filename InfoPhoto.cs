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

namespace Client_PM
{
    public partial class InfoPhoto : Form
    {
        public PhotoManagerClient.Photo Photo { get; set; }
        public string User { get; set; }
        public bool IsClosing = false;
        private MainForm Parent;
        public InfoPhoto(MainForm Parent)
        {
            if (Parent == null)
                throw new Exception("Le formulaire parent ne doit pas être null");

            this.Parent = Parent;
            InitializeComponent();
        }

        private void InfoPhoto_Load(object sender, EventArgs e)
        {
            LoadSettings();
            PictureBox.Image = Photo.GetOriginalImage();

            TBX_Author.Text = User;
            TBX_Title.Text = Photo.Title;
            TBX_CreationDate.Text = Photo.CreationDate.ToString();
            RTB_Description.Text = Photo.Description;
            TBX_Keywords.Text = Photo.Keywords;
            TBX_Size.Text = Photo.GetOriginalImage().Width + "x" + Photo.GetOriginalImage().Height + " pixels";
            PBX_Avatar.BackgroundImage = DBPhotosWebServices.GetUser(Photo.OwnerId).GetAvatarOriginalImage();
        }


        private void LoadSettings()
        {
            if (!Properties.Settings.Default.FirstUse_InfoPhoto)
            {
                // Taille du form
                // Size = Properties.Settings.Default.TailleInfoPhoto;
                // Position du form
                Location = Properties.Settings.Default.PositionInfoPhoto;
            }
        }

        private void SaveSettings()
        {
            // Taille du form
            Properties.Settings.Default.TailleInfoPhoto = Size;
            // Position du form
            Properties.Settings.Default.PositionInfoPhoto = Location;

            Properties.Settings.Default.FirstUse_InfoPhoto = false;
            Properties.Settings.Default.Save();

        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InfoPhoto_FormClosed(object sender, FormClosedEventArgs e)
        {
            IsClosing = true;
            Parent.ShowPhoto();
        }

        private void InfoPhoto_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }
    }
}
