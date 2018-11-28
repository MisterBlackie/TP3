﻿using PhotoManagerClient;
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
    public partial class MainForm : Form
    {
        User Logged_User = null;
        PhotoFilter PhotoFilter = null;
        public MainForm()
        {
            InitializeComponent();
            Text = "Photo Manager Client application - Not connected";
        }
 
        bool initializing = true;
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
            MI_Account_Profile.Enabled = Logged_User != null;
        }

        private void Init_UsersList()
        {
            foreach (User user in PhotoFilter.UsersList)
            {
                if (user.Name != null)
                    CBX_UsersList.Items.Add(user);
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

        private void AjouterPhoto()
        {
            AJoutPhoto DLG = new AJoutPhoto();

           if ( DLG.ShowDialog() == DialogResult.OK)
            {
                //DLG.Photo.OwnerId = Logged_User.Id;
                DBPhotosWebServices.CreatePhoto(DLG.Photo); // À vérifier, est-ce le web service lie la photo au usager automatiquement ou on doit l'affecter par nous même ? Si on doit le lier, décommenté la ligne au dessus
            }
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

        private void CBX_UsersList_SelectedIndexChanged(object sender, EventArgs e)
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
            initializing = true;
            PhotoFilter.SetKeywordsFilter(false, "");
            LoadPhoto();
            Init_Keywords_List();
            initializing = false;
        }

        private void CBX_Keywords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!initializing)
            {

                PhotoFilter.SetKeywordsFilter(true, CBX_Keywords.SelectedItem.ToString());

                LoadPhoto();
                PhotoBrowser.SelectNext();
                PhotoBrowser.Focus();
            }
        }

        private void BTN_Left_Click(object sender, EventArgs e)
        {
            PhotoBrowser.Placement = PhotoBrowserPlacement.Left;
        }

        private void BTN_Top_Click(object sender, EventArgs e)
        {
            PhotoBrowser.Placement = PhotoBrowserPlacement.Top;
        }

        private void BTN_Right_Click(object sender, EventArgs e)
        {
            PhotoBrowser.Placement = PhotoBrowserPlacement.Right;
        }

        private void BTN_Bottom_Click(object sender, EventArgs e)
        {
            PhotoBrowser.Placement = PhotoBrowserPlacement.Bottom;
        }

        private void Setup_Logged_User()
        {
            if (Logged_User != null)
            {
                Text = "Photo Manager Client application -" + Logged_User.Name;
                PhotoFilter = new PhotoFilter(Logged_User.Id);
                Init_UsersList();
                initializing = true;
                LoadPhoto();
                Init_Keywords_List();
                initializing = false;
            }
            else
            {
                Text = "Photo Manager Client application - Not connected";
                CBX_UsersList.Items.Clear();
                CBX_Keywords.Items.Clear();
                PhotoBrowser.Clear();
                PhotoFilter = null;
            }
            Update_UI();
        }
        private void MI_Account_Login_Click(object sender, EventArgs e)
        {
            DLG_Login dlg = new DLG_Login();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Logged_User = dlg.Logged_User;
                Setup_Logged_User();
            }
        }

        private void MI_Account_Profil_Click(object sender, EventArgs e)
        {
            DLG_Account dlg = new DLG_Account();
            dlg.User = Logged_User;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Logged_User = dlg.User;
                Setup_Logged_User();
            }
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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void flashButton6_Click(object sender, EventArgs e)
        {
            Carousel dlg = new Carousel();
            dlg.Show();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void àProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A_propos DLG = new A_propos();
            DLG.ShowDialog();
        }

        private void MI_Account_Exit_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void FB_AjouterPhoto_Click(object sender, EventArgs e)
        {
            AjouterPhoto();
        }
    }
}