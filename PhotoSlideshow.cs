using PhotoManagerClient;
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
    public partial class PhotoSlideshow : Form
    {
        List<Photo> ListPhoto;
        public PhotoSlideshow(ref List<Photo> List)
        {
            ListPhoto = List;
            InitializeComponent();
        }

        private void PhotoSlideshow_Load(object sender, EventArgs e)
        {
            ListToBrowser();
            ChangerEtatBouton();
        }

        private void ChangerEtatBouton()
        {
            BTN_Delete.Enabled = PhotoBrowser.SelectedPhoto != null;
        }

        private void ListToBrowser()
        {
            PhotoBrowser.Clear();

            foreach(Photo P in ListPhoto)
            {
                PhotoBrowser.AddPhoto(P);
            }
        }

        private void PhotoBrowser_SelectedChanged(object sender, EventArgs e)
        {
            ChangerEtatBouton();
        }

        private void RemovePhoto()
        {
            if (PhotoBrowser.SelectedPhoto != null)
            {
                ListPhoto.Remove(PhotoBrowser.SelectedPhoto);
                ListToBrowser();
            }
        }

        private void BTN_Quitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            RemovePhoto();
        }
    }
}
