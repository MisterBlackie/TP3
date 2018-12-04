namespace Client_PM
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DTP_End = new System.Windows.Forms.DateTimePicker();
            this.LBL_DateText = new System.Windows.Forms.Label();
            this.DTP_Start = new System.Windows.Forms.DateTimePicker();
            this.CBX_Keywords = new System.Windows.Forms.ComboBox();
            this.CBX_UsersList = new System.Windows.Forms.ComboBox();
            this.MS_Account = new System.Windows.Forms.MenuStrip();
            this.TSMI_Account = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Account_Login = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Account_Profile = new System.Windows.Forms.ToolStripMenuItem();
            this.Mi_Account_Create = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Account_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Photos = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Display = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Display_Up = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Display_Down = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Display_Left = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Display_Right = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Info = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Blacklist = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Blacklist_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Blacklist_Show = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_About = new System.Windows.Forms.ToolStripMenuItem();
            this.FileWatcher = new System.IO.FileSystemWatcher();
            this.TBC_PhotoManager = new System.Windows.Forms.TabControl();
            this.TP_Photos = new System.Windows.Forms.TabPage();
            this.GB_Others = new System.Windows.Forms.GroupBox();
            this.GB_Scroll = new System.Windows.Forms.GroupBox();
            this.GB_Slideshow = new System.Windows.Forms.GroupBox();
            this.GB_Image = new System.Windows.Forms.GroupBox();
            this.TP_Filters = new System.Windows.Forms.TabPage();
            this.GB_Filters = new System.Windows.Forms.GroupBox();
            this.RB_Users = new System.Windows.Forms.RadioButton();
            this.RB_Date = new System.Windows.Forms.RadioButton();
            this.CB_HideMyPhotos = new System.Windows.Forms.CheckBox();
            this.RB_Keyword = new System.Windows.Forms.RadioButton();
            this.GB_Blacklist = new System.Windows.Forms.GroupBox();
            this.CBX_BlackList = new System.Windows.Forms.ComboBox();
            this.FB_ToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.diaporamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierLesPhotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réinitialiserLesPhotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.démarrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PhotoBrowser = new PhotoManagerClient.PhotosBrowser();
            this.FB_Other_Download = new PhotoManagerClient.FlashButton();
            this.FB_Scroll_Next = new PhotoManagerClient.FlashButton();
            this.FB_Scroll_Prev = new PhotoManagerClient.FlashButton();
            this.FB_EditDiapo = new PhotoManagerClient.FlashButton();
            this.FB_Slideshow_Reset = new PhotoManagerClient.FlashButton();
            this.FB_Slideshow_Start = new PhotoManagerClient.FlashButton();
            this.FB_Slideshow_Add = new PhotoManagerClient.FlashButton();
            this.FB_Image_Show = new PhotoManagerClient.FlashButton();
            this.FB_Image_Remove = new PhotoManagerClient.FlashButton();
            this.FB_Image_Edit = new PhotoManagerClient.FlashButton();
            this.FB_Image_Add = new PhotoManagerClient.FlashButton();
            this.FB_Blacklist_Reset = new PhotoManagerClient.FlashButton();
            this.FB_Blacklist_Add = new PhotoManagerClient.FlashButton();
            this.MS_Account.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileWatcher)).BeginInit();
            this.TBC_PhotoManager.SuspendLayout();
            this.TP_Photos.SuspendLayout();
            this.GB_Others.SuspendLayout();
            this.GB_Scroll.SuspendLayout();
            this.GB_Slideshow.SuspendLayout();
            this.GB_Image.SuspendLayout();
            this.TP_Filters.SuspendLayout();
            this.GB_Filters.SuspendLayout();
            this.GB_Blacklist.SuspendLayout();
            this.SuspendLayout();
            //
            // DTP_End
            //
            this.DTP_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_End.Location = new System.Drawing.Point(366, 46);
            this.DTP_End.Name = "DTP_End";
            this.DTP_End.Size = new System.Drawing.Size(176, 22);
            this.DTP_End.TabIndex = 9;
            //
            // LBL_DateText
            //
            this.LBL_DateText.AutoSize = true;
            this.LBL_DateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DateText.Location = new System.Drawing.Point(344, 50);
            this.LBL_DateText.Name = "LBL_DateText";
            this.LBL_DateText.Size = new System.Drawing.Size(16, 16);
            this.LBL_DateText.TabIndex = 8;
            this.LBL_DateText.Text = "à";
            //
            // DTP_Start
            //
            this.DTP_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_Start.Location = new System.Drawing.Point(366, 21);
            this.DTP_Start.Name = "DTP_Start";
            this.DTP_Start.Size = new System.Drawing.Size(176, 22);
            this.DTP_Start.TabIndex = 7;
            //
            // CBX_Keywords
            //
            this.CBX_Keywords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBX_Keywords.FormattingEnabled = true;
            this.CBX_Keywords.Location = new System.Drawing.Point(104, 48);
            this.CBX_Keywords.Name = "CBX_Keywords";
            this.CBX_Keywords.Size = new System.Drawing.Size(195, 24);
            this.CBX_Keywords.TabIndex = 0;
            this.CBX_Keywords.SelectedIndexChanged += new System.EventHandler(this.CBX_Keywords_SelectedIndexChanged);
            //
            // CBX_UsersList
            //
            this.CBX_UsersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBX_UsersList.FormattingEnabled = true;
            this.CBX_UsersList.Location = new System.Drawing.Point(104, 20);
            this.CBX_UsersList.Name = "CBX_UsersList";
            this.CBX_UsersList.Size = new System.Drawing.Size(195, 24);
            this.CBX_UsersList.TabIndex = 0;
            this.CBX_UsersList.SelectedIndexChanged += new System.EventHandler(this.CBX_UsersList_SelectedIndexChanged);
            //
            // MS_Account
            //
            this.MS_Account.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MS_Account.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Account,
            this.TSMI_Photos,
            this.diaporamaToolStripMenuItem,
            this.TSMI_Blacklist,
            this.TSMI_Help,
            this.TSMI_About});
            this.MS_Account.Location = new System.Drawing.Point(0, 0);
            this.MS_Account.Name = "MS_Account";
            this.MS_Account.Size = new System.Drawing.Size(1153, 24);
            this.MS_Account.TabIndex = 2;
            this.MS_Account.Text = "menuStrip1";
            //
            // TSMI_Account
            //
            this.TSMI_Account.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_Account_Login,
            this.MI_Account_Profile,
            this.Mi_Account_Create,
            this.MI_Account_Exit});
            this.TSMI_Account.Name = "TSMI_Account";
            this.TSMI_Account.Size = new System.Drawing.Size(62, 20);
            this.TSMI_Account.Text = "Compte";
            //
            // MI_Account_Login
            //
            this.MI_Account_Login.Name = "MI_Account_Login";
            this.MI_Account_Login.Size = new System.Drawing.Size(166, 22);
            this.MI_Account_Login.Text = "Connexion";
            this.MI_Account_Login.Click += new System.EventHandler(this.MI_Account_Login_Click);
            //
            // MI_Account_Profile
            //
            this.MI_Account_Profile.Name = "MI_Account_Profile";
            this.MI_Account_Profile.Size = new System.Drawing.Size(166, 22);
            this.MI_Account_Profile.Text = "Profil";
            this.MI_Account_Profile.Click += new System.EventHandler(this.MI_Account_Profile_Click);
            //
            // Mi_Account_Create
            //
            this.Mi_Account_Create.Name = "Mi_Account_Create";
            this.Mi_Account_Create.Size = new System.Drawing.Size(166, 22);
            this.Mi_Account_Create.Text = "Nouveau compte";
            this.Mi_Account_Create.Click += new System.EventHandler(this.Mi_Account_Create_Click);
            //
            // MI_Account_Exit
            //
            this.MI_Account_Exit.Name = "MI_Account_Exit";
            this.MI_Account_Exit.Size = new System.Drawing.Size(166, 22);
            this.MI_Account_Exit.Text = "Déconnexion";
            this.MI_Account_Exit.Click += new System.EventHandler(this.MI_Account_Exit_Click);
            //
            // TSMI_Photos
            //
            this.TSMI_Photos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_Display,
            this.MI_Add,
            this.MI_Edit,
            this.MI_Delete,
            this.MI_Info});
            this.TSMI_Photos.Name = "TSMI_Photos";
            this.TSMI_Photos.Size = new System.Drawing.Size(56, 20);
            this.TSMI_Photos.Text = "Photos";
            //
            // MI_Display
            //
            this.MI_Display.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_Display_Up,
            this.MI_Display_Down,
            this.MI_Display_Left,
            this.MI_Display_Right});
            this.MI_Display.Name = "MI_Display";
            this.MI_Display.Size = new System.Drawing.Size(142, 22);
            this.MI_Display.Text = "Affichage";
            //
            // MI_Display_Up
            //
            this.MI_Display_Up.Name = "MI_Display_Up";
            this.MI_Display_Up.Size = new System.Drawing.Size(114, 22);
            this.MI_Display_Up.Text = "Haut";
            this.MI_Display_Up.Click += new System.EventHandler(this.MI_Display_Up_Click);
            //
            // MI_Display_Down
            //
            this.MI_Display_Down.Name = "MI_Display_Down";
            this.MI_Display_Down.Size = new System.Drawing.Size(114, 22);
            this.MI_Display_Down.Text = "Bas";
            this.MI_Display_Down.Click += new System.EventHandler(this.MI_Display_Down_Click);
            //
            // MI_Display_Left
            //
            this.MI_Display_Left.Name = "MI_Display_Left";
            this.MI_Display_Left.Size = new System.Drawing.Size(114, 22);
            this.MI_Display_Left.Text = "Gauche";
            this.MI_Display_Left.Click += new System.EventHandler(this.MI_Display_Left_Click);
            //
            // MI_Display_Right
            //
            this.MI_Display_Right.Name = "MI_Display_Right";
            this.MI_Display_Right.Size = new System.Drawing.Size(114, 22);
            this.MI_Display_Right.Text = "Droite";
            this.MI_Display_Right.Click += new System.EventHandler(this.MI_Display_Right_Click);
            //
            // MI_Add
            //
            this.MI_Add.Enabled = false;
            this.MI_Add.Name = "MI_Add";
            this.MI_Add.Size = new System.Drawing.Size(142, 22);
            this.MI_Add.Text = "Ajouter";
            this.MI_Add.Click += new System.EventHandler(this.MI_Add_Click);
            //
            // MI_Edit
            //
            this.MI_Edit.Enabled = false;
            this.MI_Edit.Name = "MI_Edit";
            this.MI_Edit.Size = new System.Drawing.Size(142, 22);
            this.MI_Edit.Text = "Modifier";
            this.MI_Edit.Click += new System.EventHandler(this.MI_Edit_Click);
            //
            // MI_Delete
            //
            this.MI_Delete.Enabled = false;
            this.MI_Delete.Name = "MI_Delete";
            this.MI_Delete.Size = new System.Drawing.Size(142, 22);
            this.MI_Delete.Text = "Supprimer";
            this.MI_Delete.Click += new System.EventHandler(this.MI_Delete_Click);
            //
            // MI_Info
            //
            this.MI_Info.Enabled = false;
            this.MI_Info.Name = "MI_Info";
            this.MI_Info.Size = new System.Drawing.Size(142, 22);
            this.MI_Info.Text = "Informations";
            this.MI_Info.Click += new System.EventHandler(this.MI_Info_Click);
            //
            // TSMI_Blacklist
            //
            this.TSMI_Blacklist.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_Blacklist_Add,
            this.MI_Blacklist_Show});
            this.TSMI_Blacklist.Name = "TSMI_Blacklist";
            this.TSMI_Blacklist.Size = new System.Drawing.Size(75, 20);
            this.TSMI_Blacklist.Text = "Liste Noire";
            //
            // MI_Blacklist_Add
            //
            this.MI_Blacklist_Add.Name = "MI_Blacklist_Add";
            this.MI_Blacklist_Add.Size = new System.Drawing.Size(179, 22);
            this.MI_Blacklist_Add.Text = "Ajouter / Supprimer";
            this.MI_Blacklist_Add.Click += new System.EventHandler(this.MI_Blacklist_Add_Click);
            //
            // MI_Blacklist_Show
            //
            this.MI_Blacklist_Show.Name = "MI_Blacklist_Show";
            this.MI_Blacklist_Show.Size = new System.Drawing.Size(179, 22);
            this.MI_Blacklist_Show.Text = "Réinitialiser";
            this.MI_Blacklist_Show.Click += new System.EventHandler(this.MI_Blacklist_Show_Click);
            //
            // TSMI_Help
            //
            this.TSMI_Help.Name = "TSMI_Help";
            this.TSMI_Help.Size = new System.Drawing.Size(43, 20);
            this.TSMI_Help.Text = "Aide";
            this.TSMI_Help.Click += new System.EventHandler(this.TSMI_Help_Click);
            //
            // TSMI_About
            //
            this.TSMI_About.Name = "TSMI_About";
            this.TSMI_About.Size = new System.Drawing.Size(67, 20);
            this.TSMI_About.Text = "À propos";
            this.TSMI_About.Click += new System.EventHandler(this.TSMI_About_Click);
            //
            // FileWatcher
            //
            this.FileWatcher.EnableRaisingEvents = true;
            this.FileWatcher.SynchronizingObject = this;
            //
            // TBC_PhotoManager
            //
            this.TBC_PhotoManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBC_PhotoManager.Controls.Add(this.TP_Photos);
            this.TBC_PhotoManager.Controls.Add(this.TP_Filters);
            this.TBC_PhotoManager.Location = new System.Drawing.Point(12, 27);
            this.TBC_PhotoManager.Name = "TBC_PhotoManager";
            this.TBC_PhotoManager.SelectedIndex = 0;
            this.TBC_PhotoManager.Size = new System.Drawing.Size(1129, 120);
            this.TBC_PhotoManager.TabIndex = 4;
            //
            // TP_Photos
            //
            this.TP_Photos.BackColor = System.Drawing.Color.White;
            this.TP_Photos.Controls.Add(this.GB_Others);
            this.TP_Photos.Controls.Add(this.GB_Scroll);
            this.TP_Photos.Controls.Add(this.GB_Slideshow);
            this.TP_Photos.Controls.Add(this.GB_Image);
            this.TP_Photos.Location = new System.Drawing.Point(4, 29);
            this.TP_Photos.Name = "TP_Photos";
            this.TP_Photos.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Photos.Size = new System.Drawing.Size(1121, 87);
            this.TP_Photos.TabIndex = 0;
            this.TP_Photos.Text = "Photos";
            //
            // GB_Others
            //
            this.GB_Others.Controls.Add(this.FB_Other_Download);
            this.GB_Others.Location = new System.Drawing.Point(624, 6);
            this.GB_Others.Name = "GB_Others";
            this.GB_Others.Size = new System.Drawing.Size(491, 75);
            this.GB_Others.TabIndex = 11;
            this.GB_Others.TabStop = false;
            this.GB_Others.Text = "Autres options";
            //
            // GB_Scroll
            //
            this.GB_Scroll.Controls.Add(this.FB_Scroll_Next);
            this.GB_Scroll.Controls.Add(this.FB_Scroll_Prev);
            this.GB_Scroll.Location = new System.Drawing.Point(243, 6);
            this.GB_Scroll.Name = "GB_Scroll";
            this.GB_Scroll.Size = new System.Drawing.Size(135, 75);
            this.GB_Scroll.TabIndex = 10;
            this.GB_Scroll.TabStop = false;
            this.GB_Scroll.Text = "Défilement";
            //
            // GB_Slideshow
            //
            this.GB_Slideshow.Controls.Add(this.FB_EditDiapo);
            this.GB_Slideshow.Controls.Add(this.FB_Slideshow_Reset);
            this.GB_Slideshow.Controls.Add(this.FB_Slideshow_Start);
            this.GB_Slideshow.Controls.Add(this.FB_Slideshow_Add);
            this.GB_Slideshow.Location = new System.Drawing.Point(384, 6);
            this.GB_Slideshow.Name = "GB_Slideshow";
            this.GB_Slideshow.Size = new System.Drawing.Size(234, 75);
            this.GB_Slideshow.TabIndex = 8;
            this.GB_Slideshow.TabStop = false;
            this.GB_Slideshow.Text = "Diaporama";
            //
            // GB_Image
            //
            this.GB_Image.Controls.Add(this.FB_Image_Show);
            this.GB_Image.Controls.Add(this.FB_Image_Remove);
            this.GB_Image.Controls.Add(this.FB_Image_Edit);
            this.GB_Image.Controls.Add(this.FB_Image_Add);
            this.GB_Image.Location = new System.Drawing.Point(6, 6);
            this.GB_Image.Name = "GB_Image";
            this.GB_Image.Size = new System.Drawing.Size(231, 75);
            this.GB_Image.TabIndex = 7;
            this.GB_Image.TabStop = false;
            this.GB_Image.Text = "Image";
            //
            // TP_Filters
            //
            this.TP_Filters.BackColor = System.Drawing.Color.White;
            this.TP_Filters.Controls.Add(this.GB_Filters);
            this.TP_Filters.Controls.Add(this.GB_Blacklist);
            this.TP_Filters.Location = new System.Drawing.Point(4, 34);
            this.TP_Filters.Name = "TP_Filters";
            this.TP_Filters.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Filters.Size = new System.Drawing.Size(1121, 82);
            this.TP_Filters.TabIndex = 1;
            this.TP_Filters.Text = "Filtres";
            //
            // GB_Filters
            //
            this.GB_Filters.Controls.Add(this.RB_Users);
            this.GB_Filters.Controls.Add(this.CBX_Keywords);
            this.GB_Filters.Controls.Add(this.RB_Date);
            this.GB_Filters.Controls.Add(this.CB_HideMyPhotos);
            this.GB_Filters.Controls.Add(this.DTP_Start);
            this.GB_Filters.Controls.Add(this.RB_Keyword);
            this.GB_Filters.Controls.Add(this.CBX_UsersList);
            this.GB_Filters.Controls.Add(this.LBL_DateText);
            this.GB_Filters.Controls.Add(this.DTP_End);
            this.GB_Filters.Location = new System.Drawing.Point(6, 6);
            this.GB_Filters.Name = "GB_Filters";
            this.GB_Filters.Size = new System.Drawing.Size(755, 75);
            this.GB_Filters.TabIndex = 15;
            this.GB_Filters.TabStop = false;
            this.GB_Filters.Text = "Filtres";
            //
            // RB_Users
            //
            this.RB_Users.AutoSize = true;
            this.RB_Users.Checked = true;
            this.RB_Users.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Users.Location = new System.Drawing.Point(6, 22);
            this.RB_Users.Name = "RB_Users";
            this.RB_Users.Size = new System.Drawing.Size(115, 24);
            this.RB_Users.TabIndex = 11;
            this.RB_Users.TabStop = true;
            this.RB_Users.Text = "Utilisateurs";
            this.RB_Users.UseVisualStyleBackColor = true;
            //
            // RB_Date
            //
            this.RB_Date.AutoSize = true;
            this.RB_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Date.Location = new System.Drawing.Point(305, 21);
            this.RB_Date.Name = "RB_Date";
            this.RB_Date.Size = new System.Drawing.Size(66, 24);
            this.RB_Date.TabIndex = 13;
            this.RB_Date.Text = "Date";
            this.RB_Date.UseVisualStyleBackColor = true;
            //
            // CB_HideMyPhotos
            //
            this.CB_HideMyPhotos.AutoSize = true;
            this.CB_HideMyPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_HideMyPhotos.Location = new System.Drawing.Point(559, 35);
            this.CB_HideMyPhotos.Name = "CB_HideMyPhotos";
            this.CB_HideMyPhotos.Size = new System.Drawing.Size(237, 24);
            this.CB_HideMyPhotos.TabIndex = 10;
            this.CB_HideMyPhotos.Text = "Ne pas afficher mes photos";
            this.CB_HideMyPhotos.UseVisualStyleBackColor = true;
            this.CB_HideMyPhotos.CheckedChanged += new System.EventHandler(this.CB_HideMyPhotos_CheckedChanged);
            //
            // RB_Keyword
            //
            this.RB_Keyword.AutoSize = true;
            this.RB_Keyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Keyword.Location = new System.Drawing.Point(6, 48);
            this.RB_Keyword.Name = "RB_Keyword";
            this.RB_Keyword.Size = new System.Drawing.Size(98, 24);
            this.RB_Keyword.TabIndex = 12;
            this.RB_Keyword.Text = "Mots-Clé";
            this.RB_Keyword.UseVisualStyleBackColor = true;
            //
            // GB_Blacklist
            //
            this.GB_Blacklist.Controls.Add(this.CBX_BlackList);
            this.GB_Blacklist.Controls.Add(this.FB_Blacklist_Reset);
            this.GB_Blacklist.Controls.Add(this.FB_Blacklist_Add);
            this.GB_Blacklist.Location = new System.Drawing.Point(768, 6);
            this.GB_Blacklist.Name = "GB_Blacklist";
            this.GB_Blacklist.Size = new System.Drawing.Size(347, 75);
            this.GB_Blacklist.TabIndex = 14;
            this.GB_Blacklist.TabStop = false;
            this.GB_Blacklist.Text = "Liste noire";
            //
            // CBX_BlackList
            //
            this.CBX_BlackList.FormattingEnabled = true;
            this.CBX_BlackList.Location = new System.Drawing.Point(137, 30);
            this.CBX_BlackList.Margin = new System.Windows.Forms.Padding(10, 3, 20, 3);
            this.CBX_BlackList.Name = "CBX_BlackList";
            this.CBX_BlackList.Size = new System.Drawing.Size(187, 33);
            this.CBX_BlackList.TabIndex = 3;
            this.CBX_BlackList.SelectedIndexChanged += new System.EventHandler(this.CBX_BlackList_SelectedIndexChanged);
            //
            // FileDialog
            //
            this.FileDialog.FileName = "openFileDialog1";
            this.FileDialog.Title = "Choisir un avatar...";
            //
            // FolderBrowser
            //
            this.FolderBrowser.Description = "Pour le télégargement d\'une image";
            //
            // diaporamaToolStripMenuItem
            //
            this.diaporamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem1,
            this.modifierLesPhotosToolStripMenuItem,
            this.réinitialiserLesPhotosToolStripMenuItem,
            this.démarrerToolStripMenuItem});
            this.diaporamaToolStripMenuItem.Name = "diaporamaToolStripMenuItem";
            this.diaporamaToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.diaporamaToolStripMenuItem.Text = "Diaporama";
            //
            // ajouterToolStripMenuItem1
            //
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(233, 26);
            this.ajouterToolStripMenuItem1.Text = "Ajouter";
            this.ajouterToolStripMenuItem1.Click += new System.EventHandler(this.ajouterToolStripMenuItem1_Click);
            //
            // modifierLesPhotosToolStripMenuItem
            //
            this.modifierLesPhotosToolStripMenuItem.Name = "modifierLesPhotosToolStripMenuItem";
            this.modifierLesPhotosToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.modifierLesPhotosToolStripMenuItem.Text = "Modifier les photos";
            this.modifierLesPhotosToolStripMenuItem.Click += new System.EventHandler(this.modifierLesPhotosToolStripMenuItem_Click);
            //
            // réinitialiserLesPhotosToolStripMenuItem
            //
            this.réinitialiserLesPhotosToolStripMenuItem.Name = "réinitialiserLesPhotosToolStripMenuItem";
            this.réinitialiserLesPhotosToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.réinitialiserLesPhotosToolStripMenuItem.Text = "Réinitialiser les photos";
            this.réinitialiserLesPhotosToolStripMenuItem.Click += new System.EventHandler(this.réinitialiserLesPhotosToolStripMenuItem_Click);
            //
            // démarrerToolStripMenuItem
            //
            this.démarrerToolStripMenuItem.Name = "démarrerToolStripMenuItem";
            this.démarrerToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.démarrerToolStripMenuItem.Text = "Démarrer";
            this.démarrerToolStripMenuItem.Click += new System.EventHandler(this.démarrerToolStripMenuItem_Click);
            //
            // PhotoBrowser
            //
            this.PhotoBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhotoBrowser.Location = new System.Drawing.Point(12, 150);
            this.PhotoBrowser.Name = "PhotoBrowser";
            this.PhotoBrowser.Placement = PhotoManagerClient.PhotoBrowserPlacement.Left;
            this.PhotoBrowser.SelectedPhoto = null;
            this.PhotoBrowser.Size = new System.Drawing.Size(1125, 512);
            this.PhotoBrowser.TabIndex = 5;
            this.PhotoBrowser.SelectedChanged += new PhotoManagerClient.PhotosBrowser.SelectedChangedHandler(this.PhotoBrowser_SelectedChanged);
            //
            // FB_Other_Download
            //
            this.FB_Other_Download.BackgroundImage = global::Client_PM.Properties.Resources.Download_Neutral;
            this.FB_Other_Download.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Other_Download.ClickedImage = global::Client_PM.Properties.Resources.Download_Clicked;
            this.FB_Other_Download.DisabledImage = global::Client_PM.Properties.Resources.Download_Disabled;
            this.FB_Other_Download.Image = ((System.Drawing.Image)(resources.GetObject("FB_Other_Download.Image")));
            this.FB_Other_Download.Location = new System.Drawing.Point(13, 26);
            this.FB_Other_Download.Margin = new System.Windows.Forms.Padding(10);
            this.FB_Other_Download.Name = "FB_Other_Download";
            this.FB_Other_Download.NeutralImage = global::Client_PM.Properties.Resources.Download_Neutral;
            this.FB_Other_Download.OverImage = global::Client_PM.Properties.Resources.Download_Over;
            this.FB_Other_Download.Size = new System.Drawing.Size(36, 36);
            this.FB_Other_Download.TabIndex = 0;
            this.FB_ToolTips.SetToolTip(this.FB_Other_Download, "Télécharger l\'image séléctionnée");
            this.FB_Other_Download.UseVisualStyleBackColor = true;
            this.FB_Other_Download.Click += new System.EventHandler(this.FB_Other_Download_Click);
            //
            // FB_Scroll_Next
            //
            this.FB_Scroll_Next.BackgroundImage = global::Client_PM.Properties.Resources.Next_Neutral;
            this.FB_Scroll_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Scroll_Next.ClickedImage = global::Client_PM.Properties.Resources.Next_Clicked;
            this.FB_Scroll_Next.DisabledImage = global::Client_PM.Properties.Resources.Next_Disabled;
            this.FB_Scroll_Next.Image = ((System.Drawing.Image)(resources.GetObject("FB_Scroll_Next.Image")));
            this.FB_Scroll_Next.Location = new System.Drawing.Point(76, 30);
            this.FB_Scroll_Next.Margin = new System.Windows.Forms.Padding(10);
            this.FB_Scroll_Next.Name = "FB_Scroll_Next";
            this.FB_Scroll_Next.NeutralImage = global::Client_PM.Properties.Resources.Next_Neutral;
            this.FB_Scroll_Next.OverImage = global::Client_PM.Properties.Resources.Next_Over;
            this.FB_Scroll_Next.Size = new System.Drawing.Size(36, 36);
            this.FB_Scroll_Next.TabIndex = 1;
            this.FB_ToolTips.SetToolTip(this.FB_Scroll_Next, "Image suivante");
            this.FB_Scroll_Next.UseVisualStyleBackColor = true;
            this.FB_Scroll_Next.Click += new System.EventHandler(this.FB_Scroll_Next_Click);
            //
            // FB_Scroll_Prev
            //
            this.FB_Scroll_Prev.BackgroundImage = global::Client_PM.Properties.Resources.Previous_Neutral;
            this.FB_Scroll_Prev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Scroll_Prev.ClickedImage = global::Client_PM.Properties.Resources.Previous_Clicked;
            this.FB_Scroll_Prev.DisabledImage = global::Client_PM.Properties.Resources.Previous_Disabled;
            this.FB_Scroll_Prev.Image = ((System.Drawing.Image)(resources.GetObject("FB_Scroll_Prev.Image")));
            this.FB_Scroll_Prev.Location = new System.Drawing.Point(20, 30);
            this.FB_Scroll_Prev.Margin = new System.Windows.Forms.Padding(10);
            this.FB_Scroll_Prev.Name = "FB_Scroll_Prev";
            this.FB_Scroll_Prev.NeutralImage = global::Client_PM.Properties.Resources.Previous_Neutral;
            this.FB_Scroll_Prev.OverImage = global::Client_PM.Properties.Resources.Previous_Over;
            this.FB_Scroll_Prev.Size = new System.Drawing.Size(36, 36);
            this.FB_Scroll_Prev.TabIndex = 0;
            this.FB_ToolTips.SetToolTip(this.FB_Scroll_Prev, "Image précédente");
            this.FB_Scroll_Prev.UseVisualStyleBackColor = true;
            this.FB_Scroll_Prev.Click += new System.EventHandler(this.FB_Scroll_Prev_Click);
            //
            // FB_EditDiapo
            //
            this.FB_EditDiapo.BackgroundImage = global::Client_PM.Properties.Resources.Edit_Neutral;
            this.FB_EditDiapo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_EditDiapo.ClickedImage = global::Client_PM.Properties.Resources.Edit_Clicked;
            this.FB_EditDiapo.DisabledImage = global::Client_PM.Properties.Resources.Edit_Disabled;
            this.FB_EditDiapo.Image = ((System.Drawing.Image)(resources.GetObject("FB_EditDiapo.Image")));
            this.FB_EditDiapo.Location = new System.Drawing.Point(127, 26);
            this.FB_EditDiapo.Name = "FB_EditDiapo";
            this.FB_EditDiapo.NeutralImage = global::Client_PM.Properties.Resources.Edit_Neutral;
            this.FB_EditDiapo.OverImage = global::Client_PM.Properties.Resources.Edit_Over;
            this.FB_EditDiapo.Size = new System.Drawing.Size(36, 36);
            this.FB_EditDiapo.TabIndex = 3;
            this.FB_ToolTips.SetToolTip(this.FB_EditDiapo, "Modifier les photos du diaporama");
            this.FB_EditDiapo.UseVisualStyleBackColor = true;
            this.FB_EditDiapo.Click += new System.EventHandler(this.FB_EditDiapo_Click);
            //
            // FB_Slideshow_Reset
            //
            this.FB_Slideshow_Reset.BackgroundImage = global::Client_PM.Properties.Resources.Reset_Neutral;
            this.FB_Slideshow_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Slideshow_Reset.ClickedImage = global::Client_PM.Properties.Resources.Reset_Clicked;
            this.FB_Slideshow_Reset.DisabledImage = global::Client_PM.Properties.Resources.Reset_Disabled;
            this.FB_Slideshow_Reset.Image = ((System.Drawing.Image)(resources.GetObject("FB_Slideshow_Reset.Image")));
            this.FB_Slideshow_Reset.Location = new System.Drawing.Point(187, 27);
            this.FB_Slideshow_Reset.Margin = new System.Windows.Forms.Padding(10);
            this.FB_Slideshow_Reset.Name = "FB_Slideshow_Reset";
            this.FB_Slideshow_Reset.NeutralImage = global::Client_PM.Properties.Resources.Reset_Neutral;
            this.FB_Slideshow_Reset.OverImage = global::Client_PM.Properties.Resources.Reset_Over;
            this.FB_Slideshow_Reset.Size = new System.Drawing.Size(36, 36);
            this.FB_Slideshow_Reset.TabIndex = 2;
            this.FB_ToolTips.SetToolTip(this.FB_Slideshow_Reset, "Réinitialiser le diaporama");
            this.FB_Slideshow_Reset.UseVisualStyleBackColor = true;
            this.FB_Slideshow_Reset.Click += new System.EventHandler(this.FB_Slideshow_Reset_Click);
            //
            // FB_Slideshow_Start
            //
            this.FB_Slideshow_Start.BackgroundImage = global::Client_PM.Properties.Resources.Start_Neutral;
            this.FB_Slideshow_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Slideshow_Start.ClickedImage = global::Client_PM.Properties.Resources.Start_Clicked;
            this.FB_Slideshow_Start.DisabledImage = global::Client_PM.Properties.Resources.Start_Disabled;
            this.FB_Slideshow_Start.Image = ((System.Drawing.Image)(resources.GetObject("FB_Slideshow_Start.Image")));
            this.FB_Slideshow_Start.Location = new System.Drawing.Point(69, 27);
            this.FB_Slideshow_Start.Margin = new System.Windows.Forms.Padding(10);
            this.FB_Slideshow_Start.Name = "FB_Slideshow_Start";
            this.FB_Slideshow_Start.NeutralImage = global::Client_PM.Properties.Resources.Start_Neutral;
            this.FB_Slideshow_Start.OverImage = global::Client_PM.Properties.Resources.Start_Over;
            this.FB_Slideshow_Start.Size = new System.Drawing.Size(36, 36);
            this.FB_Slideshow_Start.TabIndex = 1;
            this.FB_ToolTips.SetToolTip(this.FB_Slideshow_Start, "Démarrer le diaporama");
            this.FB_Slideshow_Start.UseVisualStyleBackColor = true;
            this.FB_Slideshow_Start.Click += new System.EventHandler(this.FB_Slideshow_Start_Click);
            //
            // FB_Slideshow_Add
            //
            this.FB_Slideshow_Add.BackgroundImage = global::Client_PM.Properties.Resources.AddToSlide_Neutral;
            this.FB_Slideshow_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Slideshow_Add.ClickedImage = global::Client_PM.Properties.Resources.AddToSlide_Clicked;
            this.FB_Slideshow_Add.DisabledImage = global::Client_PM.Properties.Resources.AddToSlide_Disabled;
            this.FB_Slideshow_Add.Enabled = false;
            this.FB_Slideshow_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FB_Slideshow_Add.Image = ((System.Drawing.Image)(resources.GetObject("FB_Slideshow_Add.Image")));
            this.FB_Slideshow_Add.Location = new System.Drawing.Point(13, 26);
            this.FB_Slideshow_Add.Margin = new System.Windows.Forms.Padding(10);
            this.FB_Slideshow_Add.Name = "FB_Slideshow_Add";
            this.FB_Slideshow_Add.NeutralImage = global::Client_PM.Properties.Resources.AddToSlide_Neutral;
            this.FB_Slideshow_Add.OverImage = global::Client_PM.Properties.Resources.AddToSlide_Over;
            this.FB_Slideshow_Add.Size = new System.Drawing.Size(36, 36);
            this.FB_Slideshow_Add.TabIndex = 0;
            this.FB_ToolTips.SetToolTip(this.FB_Slideshow_Add, "Ajouter l\'image au diaporama");
            this.FB_Slideshow_Add.UseVisualStyleBackColor = true;
            this.FB_Slideshow_Add.Click += new System.EventHandler(this.FB_Slideshow_Add_Click);
            //
            // FB_Image_Show
            //
            this.FB_Image_Show.BackgroundImage = global::Client_PM.Properties.Resources.Show_Neutral;
            this.FB_Image_Show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Image_Show.ClickedImage = global::Client_PM.Properties.Resources.Show_Clicked;
            this.FB_Image_Show.DisabledImage = global::Client_PM.Properties.Resources.Show_Disabled;
            this.FB_Image_Show.Enabled = false;
            this.FB_Image_Show.Image = ((System.Drawing.Image)(resources.GetObject("FB_Image_Show.Image")));
            this.FB_Image_Show.Location = new System.Drawing.Point(181, 26);
            this.FB_Image_Show.Margin = new System.Windows.Forms.Padding(10);
            this.FB_Image_Show.Name = "FB_Image_Show";
            this.FB_Image_Show.NeutralImage = global::Client_PM.Properties.Resources.Show_Neutral;
            this.FB_Image_Show.OverImage = global::Client_PM.Properties.Resources.Show_Over;
            this.FB_Image_Show.Size = new System.Drawing.Size(36, 36);
            this.FB_Image_Show.TabIndex = 3;
            this.FB_ToolTips.SetToolTip(this.FB_Image_Show, "Afficher les informations de l\'image");
            this.FB_Image_Show.UseVisualStyleBackColor = true;
            this.FB_Image_Show.Click += new System.EventHandler(this.FB_Image_Show_Click);
            //
            // FB_Image_Remove
            //
            this.FB_Image_Remove.BackgroundImage = global::Client_PM.Properties.Resources.Delete_Neutral;
            this.FB_Image_Remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Image_Remove.ClickedImage = global::Client_PM.Properties.Resources.Delete_Clicked;
            this.FB_Image_Remove.DisabledImage = global::Client_PM.Properties.Resources.Delete_Disabled;
            this.FB_Image_Remove.Enabled = false;
            this.FB_Image_Remove.Image = ((System.Drawing.Image)(resources.GetObject("FB_Image_Remove.Image")));
            this.FB_Image_Remove.Location = new System.Drawing.Point(125, 26);
            this.FB_Image_Remove.Margin = new System.Windows.Forms.Padding(10);
            this.FB_Image_Remove.Name = "FB_Image_Remove";
            this.FB_Image_Remove.NeutralImage = global::Client_PM.Properties.Resources.Delete_Neutral;
            this.FB_Image_Remove.OverImage = global::Client_PM.Properties.Resources.Delete_Over;
            this.FB_Image_Remove.Size = new System.Drawing.Size(36, 36);
            this.FB_Image_Remove.TabIndex = 2;
            this.FB_ToolTips.SetToolTip(this.FB_Image_Remove, "Supprimer l\'image séléctionnée");
            this.FB_Image_Remove.UseVisualStyleBackColor = true;
            this.FB_Image_Remove.Click += new System.EventHandler(this.FB_Image_Remove_Click);
            //
            // FB_Image_Edit
            //
            this.FB_Image_Edit.BackgroundImage = global::Client_PM.Properties.Resources.Edit_Neutral;
            this.FB_Image_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Image_Edit.ClickedImage = global::Client_PM.Properties.Resources.Edit_Clicked;
            this.FB_Image_Edit.DisabledImage = global::Client_PM.Properties.Resources.Edit_Disabled;
            this.FB_Image_Edit.Enabled = false;
            this.FB_Image_Edit.Image = ((System.Drawing.Image)(resources.GetObject("FB_Image_Edit.Image")));
            this.FB_Image_Edit.Location = new System.Drawing.Point(69, 26);
            this.FB_Image_Edit.Margin = new System.Windows.Forms.Padding(10);
            this.FB_Image_Edit.Name = "FB_Image_Edit";
            this.FB_Image_Edit.NeutralImage = global::Client_PM.Properties.Resources.Edit_Neutral;
            this.FB_Image_Edit.OverImage = global::Client_PM.Properties.Resources.Edit_Over;
            this.FB_Image_Edit.Size = new System.Drawing.Size(36, 36);
            this.FB_Image_Edit.TabIndex = 1;
            this.FB_ToolTips.SetToolTip(this.FB_Image_Edit, "Modifier l\'image séléctionnée");
            this.FB_Image_Edit.UseVisualStyleBackColor = true;
            this.FB_Image_Edit.Click += new System.EventHandler(this.FB_Image_Edit_Click);
            //
            // FB_Image_Add
            //
            this.FB_Image_Add.BackgroundImage = global::Client_PM.Properties.Resources.Add_Neutral;
            this.FB_Image_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Image_Add.ClickedImage = global::Client_PM.Properties.Resources.Add_Clicked;
            this.FB_Image_Add.DisabledImage = global::Client_PM.Properties.Resources.Add_Disabled;
            this.FB_Image_Add.Image = ((System.Drawing.Image)(resources.GetObject("FB_Image_Add.Image")));
            this.FB_Image_Add.Location = new System.Drawing.Point(13, 26);
            this.FB_Image_Add.Margin = new System.Windows.Forms.Padding(10);
            this.FB_Image_Add.Name = "FB_Image_Add";
            this.FB_Image_Add.NeutralImage = global::Client_PM.Properties.Resources.Add_Neutral;
            this.FB_Image_Add.OverImage = global::Client_PM.Properties.Resources.Add_Over;
            this.FB_Image_Add.Size = new System.Drawing.Size(36, 36);
            this.FB_Image_Add.TabIndex = 0;
            this.FB_ToolTips.SetToolTip(this.FB_Image_Add, "Ajouter une image");
            this.FB_Image_Add.UseVisualStyleBackColor = true;
            this.FB_Image_Add.Click += new System.EventHandler(this.FB_Image_Add_Click);
            //
            // TP_Filters
            //
            this.TP_Filters.BackColor = System.Drawing.Color.White;
            this.TP_Filters.Controls.Add(this.GB_Filters);
            this.TP_Filters.Controls.Add(this.GB_Blacklist);
            this.TP_Filters.Location = new System.Drawing.Point(4, 29);
            this.TP_Filters.Name = "TP_Filters";
            this.TP_Filters.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Filters.Size = new System.Drawing.Size(1121, 87);
            this.TP_Filters.TabIndex = 1;
            this.TP_Filters.Text = "Filtres";
            //
            // GB_Filters
            //
            this.GB_Filters.Controls.Add(this.RB_Users);
            this.GB_Filters.Controls.Add(this.CBX_Keywords);
            this.GB_Filters.Controls.Add(this.RB_Date);
            this.GB_Filters.Controls.Add(this.CB_HideMyPhotos);
            this.GB_Filters.Controls.Add(this.DTP_Start);
            this.GB_Filters.Controls.Add(this.RB_Keyword);
            this.GB_Filters.Controls.Add(this.CBX_UsersList);
            this.GB_Filters.Controls.Add(this.LBL_DateText);
            this.GB_Filters.Controls.Add(this.DTP_End);
            this.GB_Filters.Location = new System.Drawing.Point(6, 6);
            this.GB_Filters.Name = "GB_Filters";
            this.GB_Filters.Size = new System.Drawing.Size(755, 75);
            this.GB_Filters.TabIndex = 15;
            this.GB_Filters.TabStop = false;
            this.GB_Filters.Text = "Filtres";
            //
            // RB_Users
            //
            this.RB_Users.AutoSize = true;
            this.RB_Users.Checked = true;
            this.RB_Users.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Users.Location = new System.Drawing.Point(6, 22);
            this.RB_Users.Name = "RB_Users";
            this.RB_Users.Size = new System.Drawing.Size(92, 20);
            this.RB_Users.TabIndex = 11;
            this.RB_Users.TabStop = true;
            this.RB_Users.Text = "Utilisateurs";
            this.RB_Users.UseVisualStyleBackColor = true;
            //
            // RB_Date
            //
            this.RB_Date.AutoSize = true;
            this.RB_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Date.Location = new System.Drawing.Point(305, 21);
            this.RB_Date.Name = "RB_Date";
            this.RB_Date.Size = new System.Drawing.Size(55, 20);
            this.RB_Date.TabIndex = 13;
            this.RB_Date.Text = "Date";
            this.RB_Date.UseVisualStyleBackColor = true;
            //
            // CB_HideMyPhotos
            //
            this.CB_HideMyPhotos.AutoSize = true;
            this.CB_HideMyPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_HideMyPhotos.Location = new System.Drawing.Point(559, 35);
            this.CB_HideMyPhotos.Name = "CB_HideMyPhotos";
            this.CB_HideMyPhotos.Size = new System.Drawing.Size(190, 20);
            this.CB_HideMyPhotos.TabIndex = 10;
            this.CB_HideMyPhotos.Text = "Ne pas afficher mes photos";
            this.CB_HideMyPhotos.UseVisualStyleBackColor = true;
            this.CB_HideMyPhotos.CheckedChanged += new System.EventHandler(this.CB_HideMyPhotos_CheckedChanged);
            //
            // RB_Keyword
            //
            this.RB_Keyword.AutoSize = true;
            this.RB_Keyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Keyword.Location = new System.Drawing.Point(6, 48);
            this.RB_Keyword.Name = "RB_Keyword";
            this.RB_Keyword.Size = new System.Drawing.Size(79, 20);
            this.RB_Keyword.TabIndex = 12;
            this.RB_Keyword.Text = "Mots-Clé";
            this.RB_Keyword.UseVisualStyleBackColor = true;
            //
            // GB_Blacklist
            //
            this.GB_Blacklist.Controls.Add(this.CBX_BlackList);
            this.GB_Blacklist.Controls.Add(this.FB_Blacklist_Reset);
            this.GB_Blacklist.Controls.Add(this.FB_Blacklist_Add);
            this.GB_Blacklist.Location = new System.Drawing.Point(768, 6);
            this.GB_Blacklist.Name = "GB_Blacklist";
            this.GB_Blacklist.Size = new System.Drawing.Size(347, 75);
            this.GB_Blacklist.TabIndex = 14;
            this.GB_Blacklist.TabStop = false;
            this.GB_Blacklist.Text = "Liste noire";
            //
            // CBX_BlackList
            //
            this.CBX_BlackList.FormattingEnabled = true;
            this.CBX_BlackList.Location = new System.Drawing.Point(137, 30);
            this.CBX_BlackList.Margin = new System.Windows.Forms.Padding(10, 3, 20, 3);
            this.CBX_BlackList.Name = "CBX_BlackList";
            this.CBX_BlackList.Size = new System.Drawing.Size(187, 28);
            this.CBX_BlackList.TabIndex = 3;
            this.CBX_BlackList.SelectedIndexChanged += new System.EventHandler(this.CBX_BlackList_SelectedIndexChanged);
            //
            // FB_Blacklist_Reset
            //
            this.FB_Blacklist_Reset.BackgroundImage = global::Client_PM.Properties.Resources.Reset_Neutral;
            this.FB_Blacklist_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Blacklist_Reset.ClickedImage = global::Client_PM.Properties.Resources.Reset_Clicked;
            this.FB_Blacklist_Reset.DisabledImage = global::Client_PM.Properties.Resources.Reset_Disabled;
            this.FB_Blacklist_Reset.Enabled = false;
            this.FB_Blacklist_Reset.Image = ((System.Drawing.Image)(resources.GetObject("FB_Blacklist_Reset.Image")));
            this.FB_Blacklist_Reset.Location = new System.Drawing.Point(79, 24);
            this.FB_Blacklist_Reset.Margin = new System.Windows.Forms.Padding(10);
            this.FB_Blacklist_Reset.Name = "FB_Blacklist_Reset";
            this.FB_Blacklist_Reset.NeutralImage = global::Client_PM.Properties.Resources.Reset_Neutral;
            this.FB_Blacklist_Reset.OverImage = global::Client_PM.Properties.Resources.Reset_Over;
            this.FB_Blacklist_Reset.Size = new System.Drawing.Size(38, 38);
            this.FB_Blacklist_Reset.TabIndex = 2;
            this.FB_ToolTips.SetToolTip(this.FB_Blacklist_Reset, "Réinitialiser la liste noire");
            this.FB_Blacklist_Reset.UseVisualStyleBackColor = true;
            this.FB_Blacklist_Reset.Click += new System.EventHandler(this.FB_Blacklist_Reset_Click);
            //
            // FB_Blacklist_Add
            //
            this.FB_Blacklist_Add.BackgroundImage = global::Client_PM.Properties.Resources.Add_Neutral;
            this.FB_Blacklist_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Blacklist_Add.ClickedImage = global::Client_PM.Properties.Resources.Add_Clicked;
            this.FB_Blacklist_Add.DisabledImage = global::Client_PM.Properties.Resources.Add_Disabled;
            this.FB_Blacklist_Add.Enabled = false;
            this.FB_Blacklist_Add.Image = ((System.Drawing.Image)(resources.GetObject("FB_Blacklist_Add.Image")));
            this.FB_Blacklist_Add.Location = new System.Drawing.Point(23, 25);
            this.FB_Blacklist_Add.Margin = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.FB_Blacklist_Add.Name = "FB_Blacklist_Add";
            this.FB_Blacklist_Add.NeutralImage = global::Client_PM.Properties.Resources.Add_Neutral;
            this.FB_Blacklist_Add.OverImage = global::Client_PM.Properties.Resources.Add_Over;
            this.FB_Blacklist_Add.Size = new System.Drawing.Size(36, 36);
            this.FB_Blacklist_Add.TabIndex = 1;
            this.FB_ToolTips.SetToolTip(this.FB_Blacklist_Add, "Ajouter l\'auteur de l\'image à la liste noire");
            this.FB_Blacklist_Add.UseVisualStyleBackColor = true;
            this.FB_Blacklist_Add.Click += new System.EventHandler(this.FB_Blacklist_Add_Click);
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 674);
            this.Controls.Add(this.PhotoBrowser);
            this.Controls.Add(this.TBC_PhotoManager);
            this.Controls.Add(this.MS_Account);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MainMenuStrip = this.MS_Account;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1169, 713);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo Manager Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.MS_Account.ResumeLayout(false);
            this.MS_Account.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileWatcher)).EndInit();
            this.TBC_PhotoManager.ResumeLayout(false);
            this.TP_Photos.ResumeLayout(false);
            this.GB_Others.ResumeLayout(false);
            this.GB_Scroll.ResumeLayout(false);
            this.GB_Slideshow.ResumeLayout(false);
            this.GB_Image.ResumeLayout(false);
            this.TP_Filters.ResumeLayout(false);
            this.GB_Filters.ResumeLayout(false);
            this.GB_Filters.PerformLayout();
            this.GB_Blacklist.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MS_Account;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Account;
        private System.Windows.Forms.ToolStripMenuItem MI_Account_Login;
        private System.Windows.Forms.ToolStripMenuItem MI_Account_Profile;
        private System.Windows.Forms.ToolStripMenuItem Mi_Account_Create;
        private System.Windows.Forms.ToolStripMenuItem MI_Account_Exit;
        private System.Windows.Forms.ComboBox CBX_UsersList;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Photos;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Blacklist;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Help;
        private System.Windows.Forms.ToolStripMenuItem TSMI_About;
        private System.Windows.Forms.DateTimePicker DTP_End;
        private System.Windows.Forms.Label LBL_DateText;
        private System.Windows.Forms.DateTimePicker DTP_Start;
        private System.Windows.Forms.ComboBox CBX_Keywords;
        private System.IO.FileSystemWatcher FileWatcher;
        private System.Windows.Forms.ToolStripMenuItem MI_Blacklist_Add;
        private System.Windows.Forms.ToolStripMenuItem MI_Blacklist_Show;
        private System.Windows.Forms.ToolStripMenuItem MI_Display;
        private System.Windows.Forms.ToolStripMenuItem MI_Display_Up;
        private System.Windows.Forms.ToolStripMenuItem MI_Display_Down;
        private System.Windows.Forms.ToolStripMenuItem MI_Display_Left;
        private System.Windows.Forms.ToolStripMenuItem MI_Display_Right;
        private System.Windows.Forms.TabControl TBC_PhotoManager;
        private System.Windows.Forms.TabPage TP_Photos;
        private System.Windows.Forms.TabPage TP_Filters;
        private System.Windows.Forms.GroupBox GB_Slideshow;
        private System.Windows.Forms.GroupBox GB_Image;
        private System.Windows.Forms.GroupBox GB_Others;
        private System.Windows.Forms.GroupBox GB_Scroll;
        private System.Windows.Forms.CheckBox CB_HideMyPhotos;
        private System.Windows.Forms.GroupBox GB_Blacklist;
        private System.Windows.Forms.RadioButton RB_Date;
        private System.Windows.Forms.RadioButton RB_Keyword;
        private System.Windows.Forms.RadioButton RB_Users;
        private System.Windows.Forms.ToolTip FB_ToolTips;
        private System.Windows.Forms.GroupBox GB_Filters;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private PhotoManagerClient.PhotosBrowser PhotoBrowser;
        private PhotoManagerClient.FlashButton FB_Other_Download;
        private PhotoManagerClient.FlashButton FB_Scroll_Next;
        private PhotoManagerClient.FlashButton FB_Scroll_Prev;
        private PhotoManagerClient.FlashButton FB_Slideshow_Reset;
        private PhotoManagerClient.FlashButton FB_Slideshow_Start;
        private PhotoManagerClient.FlashButton FB_Slideshow_Add;
        private PhotoManagerClient.FlashButton FB_Image_Show;
        private PhotoManagerClient.FlashButton FB_Image_Remove;
        private PhotoManagerClient.FlashButton FB_Image_Edit;
        private PhotoManagerClient.FlashButton FB_Image_Add;
        private PhotoManagerClient.FlashButton FB_Blacklist_Reset;
        private PhotoManagerClient.FlashButton FB_Blacklist_Add;
        private System.Windows.Forms.ToolStripMenuItem MI_Add;
        private System.Windows.Forms.ToolStripMenuItem MI_Edit;
        private System.Windows.Forms.ToolStripMenuItem MI_Delete;
        private System.Windows.Forms.ToolStripMenuItem MI_Info;
        private System.Windows.Forms.ComboBox CBX_BlackList;
        private System.Windows.Forms.ToolStripMenuItem diaporamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifierLesPhotosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réinitialiserLesPhotosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem démarrerToolStripMenuItem;
        private PhotoManagerClient.FlashButton FB_EditDiapo;
    }
}
