using PhotoManagerClient;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_PM
{
    public partial class MainForm : Form
    {
        User Logged_User = null;
        PhotoFilter PhotoFilter = null;
        bool Initializing = true;
        InfoPhoto DLG;
        public bool IsInfoOpen = false;
        List<Photo> Slideshow = new List<Photo>();
        List<int> Blacklist = new List<int>();
        bool AddToSlideMode = true;     //True: Ajout  -  False - Retrait
        bool AddToBlacklistMode = true; //True: Ajout  -  False - Retrait
        public MainForm()
        {
            InitializeComponent();
            Text = "Photo Manager Client - Not connected";
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            // Get server attention...
            WaitSplash.Show(this, "Connecting to Photo Manager...");
            string bidon = DBPhotosWebServices.GetServerImagesURLBase();
            WaitSplash.Hide();
            Update_UI();
        }

        private void Update_UI()
        {
            UpdateControls();
            UpdateFlashButtons();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadSettings();
            UpdateFlashButtons();
        }

        #region FlashButtons

        private void FB_Image_Add_Click(object sender, EventArgs e)
        {
            AddPhoto();
        }

        private void FB_Image_Edit_Click(object sender, EventArgs e)
        {
            EditPhoto();
        }

        private void FB_Image_Remove_Click(object sender, EventArgs e)
        {
            if (PhotoBrowser.SelectedPhoto != null && PhotoBrowser.SelectedPhoto.OwnerId == Logged_User.Id)
            {
                DBPhotosWebServices.DeletePhoto(PhotoBrowser.SelectedPhoto);
                PhotoBrowser.DeleteSelectedPhoto();
            }
        }

        private void FB_Image_Show_Click(object sender, EventArgs e)
        {
            ShowPhoto();
        }

        private void FB_Scroll_Prev_Click(object sender, EventArgs e)
        {
            PhotoBrowser.SelectPrevious();
        }

        private void FB_Scroll_Next_Click(object sender, EventArgs e)
        {
            PhotoBrowser.SelectNext();
        }

        private void FB_Slideshow_Add_Click(object sender, EventArgs e)
        {
            if (AddToSlideMode)
                AddToSlideshow();
            else
                RemoveFromSlideshow();
            UpdateAddSlideShow();
        }

        private void FB_Slideshow_Start_Click(object sender, EventArgs e)
        {
            OpenSlideShow();
        }

        private void FB_Slideshow_Reset_Click(object sender, EventArgs e)
        {
            ResetSlideshow();
            UpdateAddSlideShow();
        }

        private void FB_Other_Download_Click(object sender, EventArgs e)
        {
            DownloadSelectedImage();
        }

        private void FB_Blacklist_Add_Click(object sender, EventArgs e)
        {
            if (AddToBlacklistMode)
            {
                AddToBlacklist();
            }
            else
            {
                RemoveFromBlacklist();
            }
            FB_Blacklist_Add.Enabled = false;
            LoadPhoto();
            UpdateBlacklistFB();
            FB_Blacklist_Reset.Enabled = CBX_BlackList.Items.Count > 0;
        }

        private void FB_Blacklist_Reset_Click(object sender, EventArgs e)
        {
            if (CBX_BlackList.Items.Count > 0)
            {
                CBX_BlackList.Items.Clear();
                CBX_BlackList.ResetText();
                Blacklist.Clear();
                LoadPhoto();
                FB_Blacklist_Reset.Enabled = CBX_BlackList.Items.Count > 0;
            }
        }
        #endregion

        #region StripMenu
        private void MI_Account_Login_Click(object sender, EventArgs e)
        {
            DLG_Login dlg = new DLG_Login();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Logged_User = dlg.Logged_User;
                Setup_Logged_User();
            }
        }

        private void MI_Account_Profile_Click(object sender, EventArgs e)
        {
            Profile DLG = new Profile();
            DLG.User = Logged_User;
            DialogResult DGR = DLG.ShowDialog();

            if (DGR == DialogResult.OK)
            {
                Logged_User = DLG.User;
                DBPhotosWebServices.UpdateUser(Logged_User);
            }
            else if (DGR == DialogResult.Yes)
            {
                DBPhotosWebServices.DeleteUser(Logged_User.Id);
                Logged_User = null;
            }
            Setup_Logged_User();
        }

        private void Mi_Account_Create_Click(object sender, EventArgs e)
        {
            DLG_Account dlg = new DLG_Account();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Logged_User = dlg.User;
                Setup_Logged_User();
                LoadPhoto();
            }
        }

        private void MI_Account_Exit_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void MI_Display_Up_Click(object sender, EventArgs e)
        {
            PhotoBrowser.Placement = PhotoBrowserPlacement.Top;
        }

        private void MI_Display_Down_Click(object sender, EventArgs e)
        {
            PhotoBrowser.Placement = PhotoBrowserPlacement.Bottom;
        }

        private void MI_Display_Left_Click(object sender, EventArgs e)
        {
            PhotoBrowser.Placement = PhotoBrowserPlacement.Left;
        }

        private void MI_Display_Right_Click(object sender, EventArgs e)
        {
            PhotoBrowser.Placement = PhotoBrowserPlacement.Right;
        }

        private void MI_Blacklist_Add_Click(object sender, EventArgs e)
        {
            TBC_PhotoManager.SelectTab(1);
        }

        private void TSMI_Help_Click(object sender, EventArgs e)
        {

        }
        private void TSMI_About_Click(object sender, EventArgs e)
        {
            A_propos DLG = new A_propos();
            DLG.ShowDialog();
        }
        #endregion

        #region Filters

        private void CBX_UsersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RB_Users.Checked && CBX_UsersList.SelectedItem.ToString() != "")
            {
                User selectedUser = (User)CBX_UsersList.SelectedItem;
                if (selectedUser.Id == -1) // Only mine
                {
                    PhotoFilter.SetUserFilter(false, false, 0);
                }
                else
                {
                    if (selectedUser.Id == 0) // All users
                    {
                        PhotoFilter.SetUserFilter(false, true, 0);
                    }
                    else
                    {
                        PhotoFilter.SetUserFilter(true, false, selectedUser.Id);
                    }
                }
                Initializing = true;
                PhotoFilter.SetKeywordsFilter(false, "");
                LoadPhoto();
                Init_Keywords_List();
                Initializing = false;
            }
        }

        private void CBX_Keywords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RB_Keyword.Checked && CBX_Keywords.Text != "")
            {
                if (!Initializing)
                {
                    PhotoFilter.SetKeywordsFilter(true, CBX_Keywords.SelectedItem.ToString());
                    LoadPhoto();
                    PhotoBrowser.SelectNext();
                    PhotoBrowser.Focus();
                }
            }
        }
        private void CB_HideMyPhotos_CheckedChanged(object sender, EventArgs e)
        {
            PhotoFilter.SetUserFilter(CB_HideMyPhotos.Checked, PhotoFilter.ShowAllUsers, PhotoFilter.ByOwnerUserId);
            LoadPhoto();
        }
        #endregion

        #region Events
        private void PhotoBrowser_SelectedChanged(object sender, EventArgs e)
        {
            FB_Image_Show.Enabled = PhotoBrowser.SelectedPhoto != null;
            MI_Info.Enabled = PhotoBrowser.SelectedPhoto != null;
            MI_Info.Enabled = PhotoBrowser.SelectedPhoto != null;
            FB_Blacklist_Add.Enabled = PhotoBrowser.SelectedPhoto != null;
            UpdateAddSlideShow();
            UpdateBlacklistFB();

            if (PhotoBrowser.SelectedPhoto != null)
            {
                if (PhotoBrowser.SelectedPhoto.OwnerId == Logged_User.Id)
                {
                    FB_Image_Edit.Enabled = true;
                    MI_Edit.Enabled = true;
                    FB_Image_Remove.Enabled = true;
                    MI_Delete.Enabled = true;
                }

                FB_Other_Download.Enabled = true;
            }
            else
            {
                MI_Edit.Enabled = false;
                FB_Image_Edit.Enabled = false;
                FB_Image_Remove.Enabled = false;
                MI_Delete.Enabled = false;
                FB_Other_Download.Enabled = false;
            }
        }

        private void CBX_BlackList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBX_BlackList.SelectedIndex >= 0)
            {
                FB_Blacklist_Add.Enabled = true;
                AddToBlacklistMode = false;
                FB_Blacklist_Add.BackgroundImage = Properties.Resources.Remove_Neutral;
                FB_Blacklist_Add.ClickedImage = Properties.Resources.Remove_Clicked;
                FB_Blacklist_Add.DisabledImage = Properties.Resources.Remove_Disabled;
                FB_Blacklist_Add.NeutralImage = Properties.Resources.Remove_Neutral;
                FB_Blacklist_Add.OverImage = Properties.Resources.Remove_Over;
            }
            else
            {
                AddToBlacklistMode = true;
                FB_Blacklist_Add.BackgroundImage = Properties.Resources.Add_Neutral;
                FB_Blacklist_Add.ClickedImage = Properties.Resources.Add_Clicked;
                FB_Blacklist_Add.DisabledImage = Properties.Resources.Add_Disabled;
                FB_Blacklist_Add.NeutralImage = Properties.Resources.Add_Neutral;
                FB_Blacklist_Add.OverImage = Properties.Resources.Add_Over;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void MI_Blacklist_Show_Click(object sender, EventArgs e)
        {
            ResetSlideshow();
            UpdateAddSlideShow();
        }
        #endregion

        #region Functions
        private void Setup_Logged_User()
        {
            if (Logged_User != null)
            {
                Text = "Photo Manager Client - " + Logged_User.Name;
                PhotoFilter = new PhotoFilter(Logged_User.Id);
                Init_UsersList();
                Initializing = true;
                LoadPhoto();
                Init_Keywords_List();
                Initializing = false;
            }
            else
            {
                Text = "Photo Manager Client - Not connected";
                CBX_UsersList.Items.Clear();
                CBX_Keywords.Items.Clear();
                PhotoBrowser.Clear();
                PhotoFilter = null;
            }
            Update_UI();
        }

        private void Init_Keywords_List()
        {
            CBX_Keywords.Items.Clear();
            CBX_Keywords.Items.Add("");

            foreach (string keyword in PhotoFilter.KeywordsList)
            {
                CBX_Keywords.Items.Add(keyword.Clone());
            }
            CBX_Keywords.SelectedIndex = 0;
        }

        private void AddPhoto()
        {
            AddEditPhoto DLG = new AddEditPhoto(false);

            if (DLG.ShowDialog() == DialogResult.OK)
            {
                DLG.Photo.OwnerId = Logged_User.Id;
                DBPhotosWebServices.CreatePhoto(DLG.Photo);
                LoadPhoto();
            }
        }

        private void EditPhoto()
        {
            AddEditPhoto DLG = new AddEditPhoto(true);
            DLG.Photo = PhotoBrowser.SelectedPhoto;
            if (DLG.ShowDialog() == DialogResult.OK)
            {
                DBPhotosWebServices.UpdatePhoto(DLG.Photo);
                LoadPhoto();
            }
        }

        public void ShowPhoto()
        {
            //Modifier la façon de savoir si l'image et en mode show ou hide.
            if (!IsInfoOpen)
            {
                IsInfoOpen = true;
                DLG = new InfoPhoto(this);
                DLG.Photo = PhotoBrowser.SelectedPhoto;
                DLG.User = DBPhotosWebServices.GetUser(PhotoBrowser.SelectedPhoto.OwnerId).ToString();
                DLG.Show();
                FB_Image_Show.BackgroundImage = Properties.Resources.Hide_Neutral;
                FB_Image_Show.ClickedImage = Properties.Resources.Hide_Clicked;
                FB_Image_Show.DisabledImage = Properties.Resources.Hide_Disabled;
                FB_Image_Show.NeutralImage = Properties.Resources.Hide_Neutral;
                FB_Image_Show.OverImage = Properties.Resources.Hide_Over;
            }
            else
            {
                if (!DLG.IsClosing)
                {
                    DLG.Close();
                }
                FB_Image_Show.BackgroundImage = Properties.Resources.Show_Neutral;
                FB_Image_Show.ClickedImage = Properties.Resources.Show_Clicked;
                FB_Image_Show.DisabledImage = Properties.Resources.Show_Disabled;
                FB_Image_Show.NeutralImage = Properties.Resources.Show_Neutral;
                FB_Image_Show.OverImage = Properties.Resources.Show_Over;
                FB_Image_Show.Refresh();
                IsInfoOpen = false;
            }
        }

        private void UpdateFlashButtons()
        {
            FB_Image_Add.Enabled = Logged_User != null;
            MI_Add.Enabled = Logged_User != null;
            FB_Scroll_Prev.Enabled = Logged_User != null;
            FB_Scroll_Next.Enabled = Logged_User != null;
            FB_Slideshow_Start.Enabled = Logged_User != null;
            FB_Slideshow_Reset.Enabled = Logged_User != null;
            FB_Blacklist_Reset.Enabled = Logged_User != null && CBX_BlackList.Items.Count > 0;
            FB_Other_Download.Enabled = PhotoBrowser.SelectedPhoto != null;
            FB_EditDiapo.Enabled = Logged_User != null;
        }

        private void Init_UsersList()
        {
            foreach (User user in PhotoFilter.UsersList)
            {
                if (user.Name != null)
                {
                    CBX_UsersList.Items.Add(user);
                }
            }
            CBX_UsersList.SelectedIndex = 1;
        }

        private void Disconnect()
        {
            Logged_User = null;
            Setup_Logged_User();
        }


        private void LoadPhoto()
        {
            WaitSplash.Show(this, "Loading photos from server...");
            PhotoBrowser.LoadPhotos(PhotoFilter.GetPhotos(), Blacklist);
            WaitSplash.Hide();
        }

        private void UpdateControls()
        {
            TSMI_Carousel.Enabled = Logged_User != null;
            MI_Account_Profile.Enabled = Logged_User != null;
            MI_Account_Login.Enabled = Logged_User == null;
            TSMI_Blacklist.Enabled = Logged_User != null;
            RB_Users.Enabled = Logged_User != null;
            RB_Keyword.Enabled = Logged_User != null;
            RB_Date.Enabled = Logged_User != null;
            CBX_UsersList.Enabled = Logged_User != null;
            CBX_Keywords.Enabled = Logged_User != null;
            CBX_BlackList.Enabled = Logged_User != null;
            DTP_Start.Enabled = Logged_User != null;
            DTP_End.Enabled = Logged_User != null;
            CB_HideMyPhotos.Enabled = Logged_User != null;
        }

        private void AddToSlideshow()
        {
            bool AlreadyInSlideshow = false;
            foreach (Photo Image in Slideshow)
            {
                AlreadyInSlideshow = AlreadyInSlideshow || Image == PhotoBrowser.SelectedPhoto; //Si l'image est déjà présente dans le slideshow.
            }
            if (!AlreadyInSlideshow)
                Slideshow.Add(PhotoBrowser.SelectedPhoto);
        }

        private void ModifyPhotoSlideshow()
        {
            PhotoSlideshow DLG = new PhotoSlideshow(ref Slideshow);
            DLG.ShowDialog();
        }

        private void ResetSlideshow()
        {
            Slideshow.Clear();
        }

        private void UpdateAddSlideShow()
        {
            bool AlreadyInSlideshow = false;
            FB_Slideshow_Add.Enabled = PhotoBrowser.SelectedPhoto != null;
            if (PhotoBrowser.SelectedPhoto != null)
            {
                foreach (Photo Image in Slideshow)
                {
                    if (Image == PhotoBrowser.SelectedPhoto)
                    {
                        AlreadyInSlideshow = true;
                        AddToSlideMode = false;
                        FB_Slideshow_Add.BackgroundImage = Properties.Resources.RemoveFromSlide_Neutral;
                        FB_Slideshow_Add.ClickedImage = Properties.Resources.RemoveFromSlide_Clicked;
                        FB_Slideshow_Add.DisabledImage = Properties.Resources.RemoveFromSlide_Disabled;
                        FB_Slideshow_Add.NeutralImage = Properties.Resources.RemoveFromSlide_Neutral;
                        FB_Slideshow_Add.OverImage = Properties.Resources.RemoveFromSlide_Over;
                    }
                }
                if (!AlreadyInSlideshow)
                {
                    AddToSlideMode = true;
                    FB_Slideshow_Add.BackgroundImage = Properties.Resources.AddToSlide_Neutral;
                    FB_Slideshow_Add.ClickedImage = Properties.Resources.AddToSlide_Clicked;
                    FB_Slideshow_Add.DisabledImage = Properties.Resources.AddToSlide_Disabled;
                    FB_Slideshow_Add.NeutralImage = Properties.Resources.AddToSlide_Neutral;
                    FB_Slideshow_Add.OverImage = Properties.Resources.AddToSlide_Over;
                }
            }
        }

        private void RemoveFromSlideshow()
        {
            foreach (Photo Image in Slideshow)
            {
                if (Image == PhotoBrowser.SelectedPhoto)
                {
                    Slideshow.Remove(Image);
                    break;
                }

            }
        }

        private void OpenSlideShow()
        {
            Carousel DLG = new Carousel();
            if (Slideshow.Count != 0)
                DLG.PhotoList = Slideshow;
            else
                DLG.PhotoList = DBPhotosWebServices.GetFilteredPhotos(PhotoFilter);

            DLG.Show();
        }

        private void CloseTabs()
        {
            TBC_PhotoManager.Visible = false;
            PhotoBrowser.Location = TBC_PhotoManager.Location;
            PhotoBrowser.Size = new Size(TBC_PhotoManager.Size.Width, ClientSize.Height - 37);
            Refresh();

        }

        private void OpenTabs()
        {
            TBC_PhotoManager.Visible = true;
            PhotoBrowser.Location = new Point(TBC_PhotoManager.Location.X, TBC_PhotoManager.Size.Height + 30);
            PhotoBrowser.Size = new Size(TBC_PhotoManager.Size.Width, ClientSize.Height - TBC_PhotoManager.Height - 40);
            Refresh();
        }

        private void DownloadSelectedImage()
        {
            try
            {
                if (PhotoBrowser.SelectedPhoto != null)
                {
                    if (FolderBrowser.ShowDialog() == DialogResult.OK)
                    {
                        PhotoBrowser.SelectedPhoto.GetOriginalImage().Save(FolderBrowser.SelectedPath + "/" + PhotoBrowser.SelectedPhoto.Title + ".png", System.Drawing.Imaging.ImageFormat.Png);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddToBlacklist()
        {
            if (PhotoBrowser.SelectedPhoto != null)
            {
                User CurrentUser = DBPhotosWebServices.GetUser(PhotoBrowser.SelectedPhoto.OwnerId);
                CBX_BlackList.Items.Add(CurrentUser);
                Blacklist.Add(CurrentUser.Id);
            }
        }

        private void RemoveFromBlacklist()
        {
            if (CBX_BlackList.SelectedIndex >= 0)
            {
                foreach (int Id in Blacklist)
                {
                    if (DBPhotosWebServices.GetUser(Id).Name == CBX_BlackList.SelectedItem.ToString())
                    {
                        CBX_BlackList.Items.Remove(CBX_BlackList.SelectedItem);
                        Blacklist.Remove(Id);
                        CBX_BlackList.ResetText();
                        break;
                    }
                }
            }
        }

        private void UpdateBlacklistFB()
        {
            bool AlreadyInBlacklist = false;

            if (PhotoBrowser.SelectedPhoto != null)
            {
                User CurrentUser = DBPhotosWebServices.GetUser(PhotoBrowser.SelectedPhoto.OwnerId);
                foreach (User User in CBX_BlackList.Items)
                {
                    if (CurrentUser == User)
                        AlreadyInBlacklist = true;
                }
            }

            if (!AlreadyInBlacklist)
            {
                AddToBlacklistMode = true;
                FB_Blacklist_Add.ClickedImage = Properties.Resources.Add_Clicked;
                FB_Blacklist_Add.DisabledImage = Properties.Resources.Add_Disabled;
                FB_Blacklist_Add.NeutralImage = Properties.Resources.Add_Neutral;
                FB_Blacklist_Add.OverImage = Properties.Resources.Add_Over;
            }

        }

        private void SaveSettings()
        {
            // Position du fureteur de photo
            Properties.Settings.Default.PositionFureteur = PhotoBrowser.Placement.ToString();

            // Liste des photos dans le carousel
            // On ne garde que la liste des IDs des photos puisque Properties ne donne pas l'option de stocker une list<Photo>
            StringCollection List = new StringCollection();
            foreach (Photo P in Slideshow)
            {
                List.Add(P.Id.ToString());
            }
            Properties.Settings.Default.PhotoCarousel = List;
            List.Clear();

            // Liste des usagers dans la blaclist
            foreach (int I in Blacklist)
            {
                List.Add(I.ToString());
            }
            Properties.Settings.Default.Blacklist = List;

            // Position du MainForm
            Properties.Settings.Default.PositionMainForm = Location;

            // Taille du MainForm
            Properties.Settings.Default.TailleMainForm = Size;

            Properties.Settings.Default.FirstUse_MainForm = false;
            Properties.Settings.Default.Save();
        }

        private void LoadSettings()
        {
            if (!Properties.Settings.Default.FirstUse_MainForm)
            {
                // Position du fureteur
                // Puisqu'il que Properties n'offre pas l'option de choisir des enums, il est stocké en string
                switch (Properties.Settings.Default.PositionFureteur.ToLower())
                {
                    case "bottom":
                        PhotoBrowser.Placement = PhotoBrowserPlacement.Bottom;
                        break;
                    case "top":
                        PhotoBrowser.Placement = PhotoBrowserPlacement.Top;
                        break;
                    case "left":
                        PhotoBrowser.Placement = PhotoBrowserPlacement.Left;
                        break;
                    case "right":
                        PhotoBrowser.Placement = PhotoBrowserPlacement.Right;
                        break;
                }

                // Liste des photos du carousel
                foreach (string ID in Properties.Settings.Default.PhotoCarousel)
                {
                    Photo Photo = DBPhotosWebServices.GetPhoto(int.Parse(ID));
                    if (Photo != null)
                        Slideshow.Add(Photo);
                }

                // Liste des usagers dans la blacklist
                foreach (string ID in Properties.Settings.Default.Blacklist)
                {
                    Blacklist.Add(int.Parse(ID));
                }
                CBX_BlackList_Load();

                // Position du MainForm
                Location = Properties.Settings.Default.PositionMainForm;
                // Taille du MainForm
                Size = Properties.Settings.Default.TailleMainForm;
            }
        }

        private void CBX_BlackList_Load()
        {
            CBX_BlackList.Items.Clear();

            foreach (int ID in Blacklist)
            {
                CBX_BlackList.Items.Add(DBPhotosWebServices.GetUser(ID));
            }
        }

        #endregion

        private void MI_Add_Click(object sender, EventArgs e)
        {
            AddPhoto();
        }

        private void MI_Edit_Click(object sender, EventArgs e)
        {
            EditPhoto();
        }

        private void MI_Delete_Click(object sender, EventArgs e)
        {
            if (PhotoBrowser.SelectedPhoto != null && PhotoBrowser.SelectedPhoto.OwnerId == Logged_User.Id)
            {
                DBPhotosWebServices.DeletePhoto(PhotoBrowser.SelectedPhoto);
                PhotoBrowser.DeleteSelectedPhoto();
            }
        }

        private void MI_Info_Click(object sender, EventArgs e)
        {
            ShowPhoto();
        }

        private void FB_EditDiapo_Click(object sender, EventArgs e)
        {
            ModifyPhotoSlideshow();
            UpdateAddSlideShow();
        }

        private void MI_AddToSlideshow_Click(object sender, EventArgs e)
        {
            if (PhotoBrowser.SelectedPhoto != null)
            {
                AddToSlideshow();
                UpdateAddSlideShow();
            }
        }

        private void MI_EditSlideshow_Click(object sender, EventArgs e)
        {
            ModifyPhotoSlideshow();
            UpdateAddSlideShow();
        }

        private void MI_ResetSlideshow_Click(object sender, EventArgs e)
        {
            ResetSlideshow();
            UpdateAddSlideShow();
        }

        private void MI_StartSlideshow_Click(object sender, EventArgs e)
        {
            OpenSlideShow();
        }

<<<<<<< HEAD
        private void BTN_DateSearch_Click(object sender, EventArgs e)
        {

            PhotoFilter.SetDateFilter(true, DTP_Start.Value, DTP_End.Value);
            LoadPhoto();
        }

        private void RB_Date_CheckedChanged(object sender, EventArgs e)
        {
            BTN_DateSearch.Enabled = RB_Date.Checked;
            if (RB_Date.Checked == false)
                PhotoFilter.SetDateFilter(false, DTP_Start.Value, DTP_End.Value);

        }

        private void RB_Users_CheckedChanged(object sender, EventArgs e)
        {
            if (CBX_UsersList.SelectedItem.ToString() != "")
                CBX_UsersList_SelectedIndexChanged(sender, e);
        }

        private void RB_Keyword_CheckedChanged(object sender, EventArgs e)
        {
            if (CBX_Keywords.SelectedItem.ToString() != "")
                PhotoFilter.SetKeywordsFilter(true, CBX_Keywords.SelectedItem.ToString());
            LoadPhoto();
        }

=======
>>>>>>> 0bf03d11b466e1ac1d8ab148dd456f0da235dfd7
        private void masquerLesOngletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TBC_PhotoManager.Visible)
                CloseTabs();
            else
                OpenTabs();
        }
    }
}
