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
    public partial class AddEditPhoto : Form
    {
        public PhotoManagerClient.Photo Photo { get; set; }
        private ValidationProvider ValidationProvider;
        bool EditingMode = false;

        public AddEditPhoto(bool Editing)
        {
            Photo = new PhotoManagerClient.Photo();
            EditingMode = Editing;

            InitializeComponent();
            ValidationProvider = new ValidationProvider(this);
            ValidationProvider.AddControlToValidate(TBX_Title, TB_Titre_Validation);
            ValidationProvider.AddControlToValidate(ImageBox, ImageValidation);
        }

        /*
         *  Méthode de validation 
         */
        private bool TB_Titre_Validation(ref string Message)
        {
            Message = "Le titre ne doit pas être vide.";
            return TBX_Title.Text != "";
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
                    BTN_Rotate.Enabled = true;
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
            Photo.Title = TBX_Title.Text;
            Photo.Description = RTB_Description.Text;
            Photo.Keywords = TBX_Keywords.Text; //Devrait permettre plus qu'un mot clé...
            Photo.Shared = !RB_Private.Checked;
        }

        private void ImageBox_BackgroundImageChanged(object sender, EventArgs e)
        {
            Image Image = ImageBox.BackgroundImage; // On ne peut pas envoyer une référence à une propriété...
            ChangerImage(ref Image, false);
        }

        private void AddEditPhoto_Load(object sender, EventArgs e)
        {
            LoadSettings();

            if (EditingMode)
            {
                BTN_Ajout.Text = "Modifier";
                ImageBox.BackgroundImage = Photo.GetOriginalImage();
                TBX_Title.Text = Photo.Title;
                RTB_Description.Text = Photo.Description;
                TBX_Keywords.Text = Photo.Keywords;
                RB_Private.Checked = !Photo.Shared;
            }
        }

        private Image Rotate(Image BaseImage)
        {
            Image RotatedImage = (Image)BaseImage.Clone();
            RotatedImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            return RotatedImage;
        }

        private void BTN_Rotate_Click(object sender, EventArgs e)
        {
            ImageBox.BackgroundImage = Rotate(ImageBox.BackgroundImage);
        }

        private void LoadSettings()
        {
            if (!Properties.Settings.Default.FirstUse_AddEditPhoto)
            {
                // Taille du form
                Size = Properties.Settings.Default.TailleAddEditPhoto;

                // Position du form
                Location = Properties.Settings.Default.PositionAddEditPhoto;
            }
        }

        private void SaveSettings()
        {
            // Taille du form
            Properties.Settings.Default.TailleAddEditPhoto = Size;

            // Position du form
            Properties.Settings.Default.PositionAddEditPhoto = Location;

            Properties.Settings.Default.FirstUse_AddEditPhoto = false;
            Properties.Settings.Default.Save();
        }

        private void AddEditPhoto_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }
    }
}
