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
using PhotoManagerClient;

namespace Client_PM
{
    public partial class Profile : Form
    {
        public User User = new User();
        private ValidationProvider Validation;
        bool AvatarChanged;
        bool UName = false, UNameUnique = false, PSD = false, VLD = false, Avatar = false;
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            Validation = new ValidationProvider(this, SubmitTask);
            Validation.AddControlToValidate(TBX_Username, Validate_TBX_Username, Validate_TBX_Username_OnSubmit);
            Validation.AddControlToValidate(TBX_Password, Validate_TBX_Password);
            Validation.AddControlToValidate(TBX_Validate, Validate_TBX_Validation);
            Validation.AddControlToValidate(PBX_Avatar, Validate_PBX_Avatar);
            if (User != null)
                User_To_DLG();
        }

        private void BTN_Choose_Click(object sender, EventArgs e)
        {
            if (OFD_Image.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PBX_Avatar.BackgroundImage = Image.FromFile(OFD_Image.FileName);
            }
        }

        private bool Validate_TBX_Username(ref string message)
        {
            message = "Nom d'usager manquant";
            UName = TBX_Username.Text != "";
            return TBX_Username.Text != "";
        }
        private bool Validate_TBX_Password(ref string message)
        {
            PSD = TBX_Password.Text != "";
            message = "Mot de passe manquant";
            return TBX_Password.Text != "";
        }
        private bool Validate_TBX_Validation(ref string message)
        {
            VLD = TBX_Validate.Text == TBX_Password.Text;
            message = "Mot de passe ne correspond avec vérification";
            return TBX_Validate.Text == TBX_Password.Text;
        }
        private bool Validate_PBX_Avatar(ref string message)
        {
            Avatar = PBX_Avatar.BackgroundImage != null;
            message = "Veuillez vhoisir votre avatar.";
            return PBX_Avatar.BackgroundImage != null;
        }

        private bool Validate_TBX_Username_OnSubmit(ref string message)
        {
            UNameUnique = !DBPhotosWebServices.UserNameAlreadyUsed(User.Id, TBX_Username.Text);
            message = "Nom d'usager déjà utilisé";
            if (User != null)
                return !DBPhotosWebServices.UserNameAlreadyUsed(User.Id, TBX_Username.Text);
            else
                return !DBPhotosWebServices.UserNameExist(TBX_Username.Text);
        }

        private void User_To_DLG()
        {
            TBX_Username.Text = User.Name;
            TBX_Password.Text = User.Password;
            TBX_Validate.Text = User.Password;
            PBX_Avatar.BackgroundImage = User.GetAvatarOriginalImage();
        }

        private void PBX_Avatar_BackgroundImageChanged(object sender, EventArgs e)
        {
            AvatarChanged = true;
            Validation.UpdateValid(PBX_Avatar);
        }

        private void SubmitTask()
        {
            //if (UName && UNameUnique && PSD && VLD && Avatar)
            //{

            User.Name = TBX_Username.Text;
            User.Password = TBX_Password.Text;
            if (AvatarChanged)
                User.SetAvatarImage(PBX_Avatar.BackgroundImage);
            //}
            //else
            //    BTN_Edit.DialogResult = DialogResult.None;
        }

        private void BTN_Edit_Click(object sender, EventArgs e)
        {
            SubmitTask();
        }
    }
}
