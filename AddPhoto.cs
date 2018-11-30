using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validation;

namespace Client_PM
{
    public partial class AddPhoto : Form
    {
        public PhotoManagerClient.Photo Photo { get; set; }

        private ValidationProvider ValidationProvider;

        public AddPhoto()
        {
            Photo = new PhotoManagerClient.Photo();
            InitializeComponent();
            ValidationProvider = new ValidationProvider(this);


            ValidationProvider.AddControlToValidate(TB_Titre, TB_Titre_Validation);
            ValidationProvider.AddControlToValidate(ImageBox, ImageValidation);
        }

        /*
         *  Méthode de validation 
         */
        private bool TB_Titre_Validation(ref string Message)
        {
            Message = "Le titre ne doit pas être vide.";
            return TB_Titre.Text != "";
        }

        private bool ImageValidation(ref string Message)
        {
            Message = "Vous devez sélectionner une image";
            return ImageBox.BackgroundImage != null; // Si l'image box a une image, celle de le photo devrait être la même
        }
        /*
         *  Fin méthode de validation
         */ 
        private void BTN_Selectionner_Click(object sender, EventArgs e)
        {
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image Image = Image.FromFile(FileDialog.FileName);

                    ChangerImage(ref Image);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ChangerImage(ref Image Image, bool ChangerImageBox = true)
        {
            if (Image != null)
            {
                if (ChangerImageBox) // Ce cas sera faux seulement si nous changeons l'image de par l'image box
                   ImageBox.BackgroundImage = Image;

                Photo.SetImage(Image);
            }
        }

        private void BTN_Ajout_Click(object sender, EventArgs e)
        {
            Photo.Title = TB_Titre.Text;
            Photo.Description = RTB_Description.Text;
            Photo.Keywords = TB_Keywords.Text;
            Photo.Shared = !RBTN_EstPrivee.Checked;
        }

        private void ImageBox_BackgroundImageChanged(object sender, EventArgs e)
        {
            Image Image = ImageBox.BackgroundImage; // On ne peut pas envoyer une référence à une propriété...
            ChangerImage(ref Image, false);
        }
    }
}
