using PhotoManagerClient;
using System;
using System.Collections.Generic;
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
            {
                AddToSlideshow();
            }
            else
            {
                RemoveFromSlideshow();
            }
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
            //AddToBlacklist(); //Pas terminé.
        }

        private void FB_Blacklist_Reset_Click(object sender, EventArgs e)
        {

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

        }

        private void Mi_Account_Create_Click(object sender, EventArgs e)
        {
            DLG_Account dlg = new DLG_Account();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Logged_User = dlg.User;
                Setup_Logged_User();
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

        }

        private void MI_Blacklist_Show_Click(object sender, EventArgs e)
        {

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
            if (RB_Users.Checked)
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
            if (RB_Keyword.Checked)
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
            UpdateAddSlideShow();

            if (PhotoBrowser.SelectedPhoto != null)
            {
                if (PhotoBrowser.SelectedPhoto.OwnerId == Logged_User.Id)
                {
                    FB_Image_Edit.Enabled = true;
                    FB_Image_Remove.Enabled = true;
                }

                FB_Other_Download.Enabled = true;
            }
            else
            {
                FB_Image_Edit.Enabled = false;
                FB_Image_Remove.Enabled = false;
                FB_Other_Download.Enabled = false;
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.H)
            {
                if (TBC_PhotoManager.Visible)
                    CloseTabs();
                else
                    OpenTabs();

                e.Handled = true;
            }
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
            //Image
            FB_Image_Add.Enabled = Logged_User != null;

            //Scroll
            FB_Scroll_Prev.Enabled = Logged_User != null;
            FB_Scroll_Next.Enabled = Logged_User != null;

            //SlideShow
            FB_Slideshow_Start.Enabled = Logged_User != null;
            FB_Slideshow_Reset.Enabled = Logged_User != null;

            //Others
            FB_Other_Download.Enabled = PhotoBrowser.SelectedPhoto != null;

            //Blacklist
            FB_Blacklist_Add.Enabled = Logged_User != null;
            FB_Blacklist_Reset.Enabled = Logged_User != null;
        }

        private void Init_UsersList()
        {
            foreach (User user in PhotoFilter.UsersList)
            {
                if (user.Name != null)
                {
                    CBX_UsersList.Items.Add(user);
                    CBX_BlackList.Items.Add(user);
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
            PhotoBrowser.LoadPhotos(PhotoFilter.GetPhotos());
            WaitSplash.Hide();
        }

        private void UpdateControls()
        {
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
                        //Les images utilisé sont temporaire jusqu'à ce que l'image adéquate soit faite.
                        FB_Slideshow_Add.BackgroundImage = Properties.Resources.Remove_Neutral;
                        FB_Slideshow_Add.ClickedImage = Properties.Resources.Remove_Clicked;
                        FB_Slideshow_Add.DisabledImage = Properties.Resources.Remove_Disabled;
                        FB_Slideshow_Add.NeutralImage = Properties.Resources.Remove_Neutral;
                        FB_Slideshow_Add.OverImage = Properties.Resources.Remove_Over;
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

        private void AddToBlacklist()
        {
            if (CBX_BlackList.SelectedIndex > 0)
            {
                foreach (User User in PhotoFilter.UsersList)
                {
                    if (User.Name == CBX_BlackList.SelectedText)
                    {
                        Blacklist.Add(User.Id);
                        CBX_BlackList.SelectedIndex = -1;
                        CBX_BlackList.Text = "";
                    }
                }
            }
            else
            {
                if (PhotoBrowser.SelectedPhoto != null)
                {
                    Blacklist.Add(PhotoBrowser.SelectedPhoto.OwnerId);
                }
            }
        }

        private void UpdateAddBlacklist()
        {
            FB_Blacklist_Add.Enabled = PhotoBrowser.SelectedPhoto != null || CBX_BlackList.SelectedIndex > 0;

            foreach (int User in Blacklist)
            {
                if (PhotoBrowser.SelectedPhoto != null && User == PhotoBrowser.SelectedPhoto.OwnerId)
                {

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
        #endregion
    }
}
