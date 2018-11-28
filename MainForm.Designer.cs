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
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            this.TSMI_Blacklist = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Blacklist_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Blacklist_Show = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_About = new System.Windows.Forms.ToolStripMenuItem();
            this.FileWatcher = new System.IO.FileSystemWatcher();
            this.TBC_PhotoManager = new System.Windows.Forms.TabControl();
            this.TP_Photos = new System.Windows.Forms.TabPage();
            this.GB_Others = new System.Windows.Forms.GroupBox();
            this.flashButton8 = new PhotoManagerClient.FlashButton();
            this.GB_Scroll = new System.Windows.Forms.GroupBox();
            this.flashButton7 = new PhotoManagerClient.FlashButton();
            this.flashButton5 = new PhotoManagerClient.FlashButton();
            this.GB_Slideshow = new System.Windows.Forms.GroupBox();
            this.flashButton9 = new PhotoManagerClient.FlashButton();
            this.flashButton10 = new PhotoManagerClient.FlashButton();
            this.flashButton6 = new PhotoManagerClient.FlashButton();
            this.GB_Image = new System.Windows.Forms.GroupBox();
            this.FB_AjouterPhoto = new PhotoManagerClient.FlashButton();
            this.FB_EditionPhoto = new PhotoManagerClient.FlashButton();
            this.flashButton4 = new PhotoManagerClient.FlashButton();
            this.FB_SupprimerPhoto = new PhotoManagerClient.FlashButton();
            this.TP_Filters = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.flashButton12 = new PhotoManagerClient.FlashButton();
            this.flashButton11 = new PhotoManagerClient.FlashButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.FB_ToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.PhotoBrowser = new PhotoManagerClient.PhotosBrowser();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.MS_Account.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileWatcher)).BeginInit();
            this.TBC_PhotoManager.SuspendLayout();
            this.TP_Photos.SuspendLayout();
            this.GB_Others.SuspendLayout();
            this.GB_Scroll.SuspendLayout();
            this.GB_Slideshow.SuspendLayout();
            this.GB_Image.SuspendLayout();
            this.TP_Filters.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(366, 46);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(176, 22);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "à";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(366, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(176, 22);
            this.dateTimePicker1.TabIndex = 7;
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
            this.MI_Account_Login.Size = new System.Drawing.Size(180, 22);
            this.MI_Account_Login.Text = "Connexion";
            this.MI_Account_Login.Click += new System.EventHandler(this.MI_Account_Login_Click);
            // 
            // MI_Account_Profile
            // 
            this.MI_Account_Profile.Name = "MI_Account_Profile";
            this.MI_Account_Profile.Size = new System.Drawing.Size(180, 22);
            this.MI_Account_Profile.Text = "Profil";
            this.MI_Account_Profile.Click += new System.EventHandler(this.MI_Account_Profil_Click);
            // 
            // Mi_Account_Create
            // 
            this.Mi_Account_Create.Name = "Mi_Account_Create";
            this.Mi_Account_Create.Size = new System.Drawing.Size(180, 22);
            this.Mi_Account_Create.Text = "Nouveau compte";
            this.Mi_Account_Create.Click += new System.EventHandler(this.Mi_Account_Create_Click);
            // 
            // MI_Account_Exit
            // 
            this.MI_Account_Exit.Name = "MI_Account_Exit";
            this.MI_Account_Exit.Size = new System.Drawing.Size(180, 22);
            this.MI_Account_Exit.Text = "Déconnexion";
            this.MI_Account_Exit.Click += new System.EventHandler(this.MI_Account_Exit_Click);
            // 
            // TSMI_Photos
            // 
            this.TSMI_Photos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_Display});
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
            this.MI_Display.Size = new System.Drawing.Size(180, 22);
            this.MI_Display.Text = "Affichage";
            // 
            // MI_Display_Up
            // 
            this.MI_Display_Up.Name = "MI_Display_Up";
            this.MI_Display_Up.Size = new System.Drawing.Size(180, 22);
            this.MI_Display_Up.Text = "Haut";
            // 
            // MI_Display_Down
            // 
            this.MI_Display_Down.Name = "MI_Display_Down";
            this.MI_Display_Down.Size = new System.Drawing.Size(180, 22);
            this.MI_Display_Down.Text = "Bas";
            // 
            // MI_Display_Left
            // 
            this.MI_Display_Left.Name = "MI_Display_Left";
            this.MI_Display_Left.Size = new System.Drawing.Size(180, 22);
            this.MI_Display_Left.Text = "Gauche";
            // 
            // MI_Display_Right
            // 
            this.MI_Display_Right.Name = "MI_Display_Right";
            this.MI_Display_Right.Size = new System.Drawing.Size(180, 22);
            this.MI_Display_Right.Text = "Droite";
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
            this.MI_Blacklist_Add.Size = new System.Drawing.Size(180, 22);
            this.MI_Blacklist_Add.Text = "Ajouter";
            // 
            // MI_Blacklist_Show
            // 
            this.MI_Blacklist_Show.Name = "MI_Blacklist_Show";
            this.MI_Blacklist_Show.Size = new System.Drawing.Size(180, 22);
            this.MI_Blacklist_Show.Text = "Afficher la liste";
            // 
            // TSMI_Help
            // 
            this.TSMI_Help.Name = "TSMI_Help";
            this.TSMI_Help.Size = new System.Drawing.Size(43, 20);
            this.TSMI_Help.Text = "Aide";
            // 
            // TSMI_About
            // 
            this.TSMI_About.Name = "TSMI_About";
            this.TSMI_About.Size = new System.Drawing.Size(67, 20);
            this.TSMI_About.Text = "À propos";
            this.TSMI_About.Click += new System.EventHandler(this.àProposToolStripMenuItem_Click);
            // 
            // FileWatcher
            // 
            this.FileWatcher.EnableRaisingEvents = true;
            this.FileWatcher.SynchronizingObject = this;
            // 
            // TBC_PhotoManager
            // 
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
            this.GB_Others.Controls.Add(this.flashButton8);
            this.GB_Others.Location = new System.Drawing.Point(553, 6);
            this.GB_Others.Name = "GB_Others";
            this.GB_Others.Size = new System.Drawing.Size(562, 75);
            this.GB_Others.TabIndex = 11;
            this.GB_Others.TabStop = false;
            this.GB_Others.Text = "Autres options";
            // 
            // flashButton8
            // 
            this.flashButton8.BackgroundImage = global::Client_PM.Properties.Resources.Download;
            this.flashButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashButton8.ClickedImage = global::Client_PM.Properties.Resources.Download_Clicked;
            this.flashButton8.DisabledImage = global::Client_PM.Properties.Resources.Download_Disabled;
            this.flashButton8.Image = ((System.Drawing.Image)(resources.GetObject("flashButton8.Image")));
            this.flashButton8.Location = new System.Drawing.Point(13, 25);
            this.flashButton8.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.flashButton8.Name = "flashButton8";
            this.flashButton8.NeutralImage = global::Client_PM.Properties.Resources.Download_Neutral;
            this.flashButton8.OverImage = global::Client_PM.Properties.Resources.Download_Hover;
            this.flashButton8.Size = new System.Drawing.Size(40, 40);
            this.flashButton8.TabIndex = 12;
            this.flashButton8.Text = "flashButton8";
            this.FB_ToolTips.SetToolTip(this.flashButton8, "Télécharger l\'image séléctionnée");
            this.flashButton8.UseVisualStyleBackColor = true;
            // 
            // GB_Scroll
            // 
            this.GB_Scroll.Controls.Add(this.flashButton7);
            this.GB_Scroll.Controls.Add(this.flashButton5);
            this.GB_Scroll.Location = new System.Drawing.Point(239, 6);
            this.GB_Scroll.Name = "GB_Scroll";
            this.GB_Scroll.Size = new System.Drawing.Size(114, 75);
            this.GB_Scroll.TabIndex = 10;
            this.GB_Scroll.TabStop = false;
            this.GB_Scroll.Text = "Défilement";
            // 
            // flashButton7
            // 
            this.flashButton7.BackgroundImage = global::Client_PM.Properties.Resources.Previous_Neutral;
            this.flashButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashButton7.ClickedImage = global::Client_PM.Properties.Resources.Previous_Hover;
            this.flashButton7.DisabledImage = global::Client_PM.Properties.Resources.Previous_Disabled;
            this.flashButton7.Image = ((System.Drawing.Image)(resources.GetObject("flashButton7.Image")));
            this.flashButton7.Location = new System.Drawing.Point(11, 25);
            this.flashButton7.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.flashButton7.Name = "flashButton7";
            this.flashButton7.NeutralImage = global::Client_PM.Properties.Resources.Previous_Neutral;
            this.flashButton7.OverImage = global::Client_PM.Properties.Resources.Previous_Hover;
            this.flashButton7.Size = new System.Drawing.Size(40, 40);
            this.flashButton7.TabIndex = 8;
            this.flashButton7.Text = "flashButton7";
            this.FB_ToolTips.SetToolTip(this.flashButton7, "Image précédente");
            this.flashButton7.UseVisualStyleBackColor = true;
            // 
            // flashButton5
            // 
            this.flashButton5.BackgroundImage = global::Client_PM.Properties.Resources.Next_Neutral;
            this.flashButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashButton5.ClickedImage = global::Client_PM.Properties.Resources.Next_Clicked;
            this.flashButton5.DisabledImage = global::Client_PM.Properties.Resources.Next_Disabled;
            this.flashButton5.Image = ((System.Drawing.Image)(resources.GetObject("flashButton5.Image")));
            this.flashButton5.Location = new System.Drawing.Point(63, 25);
            this.flashButton5.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.flashButton5.Name = "flashButton5";
            this.flashButton5.NeutralImage = global::Client_PM.Properties.Resources.Next_Neutral;
            this.flashButton5.OverImage = global::Client_PM.Properties.Resources.Next_Neutral;
            this.flashButton5.Size = new System.Drawing.Size(40, 40);
            this.flashButton5.TabIndex = 7;
            this.flashButton5.Text = "flashButton5";
            this.FB_ToolTips.SetToolTip(this.flashButton5, "Image suivante");
            this.flashButton5.UseVisualStyleBackColor = true;
            // 
            // GB_Slideshow
            // 
            this.GB_Slideshow.Controls.Add(this.flashButton9);
            this.GB_Slideshow.Controls.Add(this.flashButton10);
            this.GB_Slideshow.Controls.Add(this.flashButton6);
            this.GB_Slideshow.Location = new System.Drawing.Point(359, 6);
            this.GB_Slideshow.Name = "GB_Slideshow";
            this.GB_Slideshow.Size = new System.Drawing.Size(188, 75);
            this.GB_Slideshow.TabIndex = 8;
            this.GB_Slideshow.TabStop = false;
            this.GB_Slideshow.Text = "Diaporama";
            // 
            // flashButton9
            // 
            this.flashButton9.BackgroundImage = global::Client_PM.Properties.Resources.Reset_Neutral;
            this.flashButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashButton9.ClickedImage = global::Client_PM.Properties.Resources.Reset_Clicked;
            this.flashButton9.DisabledImage = global::Client_PM.Properties.Resources.Reset_Disabled;
            this.flashButton9.Image = ((System.Drawing.Image)(resources.GetObject("flashButton9.Image")));
            this.flashButton9.Location = new System.Drawing.Point(135, 25);
            this.flashButton9.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.flashButton9.Name = "flashButton9";
            this.flashButton9.NeutralImage = global::Client_PM.Properties.Resources.Reset_Neutral;
            this.flashButton9.OverImage = global::Client_PM.Properties.Resources.Reset_Hover;
            this.flashButton9.Size = new System.Drawing.Size(40, 40);
            this.flashButton9.TabIndex = 13;
            this.flashButton9.Text = "flashButton9";
            this.FB_ToolTips.SetToolTip(this.flashButton9, "Réinitialiser le diaporama");
            this.flashButton9.UseVisualStyleBackColor = true;
            // 
            // flashButton10
            // 
            this.flashButton10.BackgroundImage = global::Client_PM.Properties.Resources.Start_Neutral;
            this.flashButton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashButton10.ClickedImage = global::Client_PM.Properties.Resources.Start_Clicked;
            this.flashButton10.DisabledImage = global::Client_PM.Properties.Resources.Start_Disabled;
            this.flashButton10.Image = ((System.Drawing.Image)(resources.GetObject("flashButton10.Image")));
            this.flashButton10.Location = new System.Drawing.Point(73, 25);
            this.flashButton10.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.flashButton10.Name = "flashButton10";
            this.flashButton10.NeutralImage = global::Client_PM.Properties.Resources.Start_Neutral;
            this.flashButton10.OverImage = global::Client_PM.Properties.Resources.Start_Hover;
            this.flashButton10.Size = new System.Drawing.Size(40, 40);
            this.flashButton10.TabIndex = 14;
            this.flashButton10.Text = "flashButton10";
            this.FB_ToolTips.SetToolTip(this.flashButton10, "Démarrer le diaporama");
            this.flashButton10.UseVisualStyleBackColor = true;
            // 
            // flashButton6
            // 
            this.flashButton6.BackgroundImage = global::Client_PM.Properties.Resources.AddToSlide_Neutral;
            this.flashButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashButton6.ClickedImage = global::Client_PM.Properties.Resources.AddToSlide_Clicked;
            this.flashButton6.DisabledImage = global::Client_PM.Properties.Resources.AddToSlide_Disabled;
            this.flashButton6.Image = ((System.Drawing.Image)(resources.GetObject("flashButton6.Image")));
            this.flashButton6.Location = new System.Drawing.Point(13, 25);
            this.flashButton6.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.flashButton6.Name = "flashButton6";
            this.flashButton6.NeutralImage = global::Client_PM.Properties.Resources.AddToSlide_Neutral;
            this.flashButton6.OverImage = global::Client_PM.Properties.Resources.AddToSlide_Hover;
            this.flashButton6.Size = new System.Drawing.Size(40, 40);
            this.flashButton6.TabIndex = 3;
            this.flashButton6.Text = "flashButton6";
            this.FB_ToolTips.SetToolTip(this.flashButton6, "Ajoute l\'image séléctionnée au diaporama");
            this.flashButton6.UseVisualStyleBackColor = true;
            this.flashButton6.Click += new System.EventHandler(this.flashButton6_Click);
            // 
            // GB_Image
            // 
            this.GB_Image.Controls.Add(this.FB_AjouterPhoto);
            this.GB_Image.Controls.Add(this.FB_EditionPhoto);
            this.GB_Image.Controls.Add(this.flashButton4);
            this.GB_Image.Controls.Add(this.FB_SupprimerPhoto);
            this.GB_Image.Location = new System.Drawing.Point(6, 6);
            this.GB_Image.Name = "GB_Image";
            this.GB_Image.Size = new System.Drawing.Size(220, 75);
            this.GB_Image.TabIndex = 7;
            this.GB_Image.TabStop = false;
            this.GB_Image.Text = "Image";
            // 
            // FB_AjouterPhoto
            // 
            this.FB_AjouterPhoto.BackColor = System.Drawing.Color.Transparent;
            this.FB_AjouterPhoto.BackgroundImage = global::Client_PM.Properties.Resources.Add_Neutral;
            this.FB_AjouterPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_AjouterPhoto.ClickedImage = global::Client_PM.Properties.Resources.Add_Clicked;
            this.FB_AjouterPhoto.DisabledImage = global::Client_PM.Properties.Resources.Add_Disabled;
            this.FB_AjouterPhoto.Image = ((System.Drawing.Image)(resources.GetObject("FB_AjouterPhoto.Image")));
            this.FB_AjouterPhoto.Location = new System.Drawing.Point(10, 25);
            this.FB_AjouterPhoto.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.FB_AjouterPhoto.Name = "FB_AjouterPhoto";
            this.FB_AjouterPhoto.NeutralImage = global::Client_PM.Properties.Resources.Add_Neutral;
            this.FB_AjouterPhoto.OverImage = global::Client_PM.Properties.Resources.Add_Hover;
            this.FB_AjouterPhoto.Size = new System.Drawing.Size(40, 40);
            this.FB_AjouterPhoto.TabIndex = 3;
            this.FB_ToolTips.SetToolTip(this.FB_AjouterPhoto, "Ajouter une image");
            this.FB_AjouterPhoto.UseVisualStyleBackColor = false;
            this.FB_AjouterPhoto.Click += new System.EventHandler(this.FB_AjouterPhoto_Click);
            // 
            // FB_EditionPhoto
            // 
            this.FB_EditionPhoto.BackgroundImage = global::Client_PM.Properties.Resources.Edit_Neutral;
            this.FB_EditionPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_EditionPhoto.ClickedImage = global::Client_PM.Properties.Resources.Edit_Clicked;
            this.FB_EditionPhoto.DisabledImage = global::Client_PM.Properties.Resources.Edit_Disabled;
            this.FB_EditionPhoto.Image = ((System.Drawing.Image)(resources.GetObject("FB_EditionPhoto.Image")));
            this.FB_EditionPhoto.Location = new System.Drawing.Point(64, 25);
            this.FB_EditionPhoto.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.FB_EditionPhoto.Name = "FB_EditionPhoto";
            this.FB_EditionPhoto.NeutralImage = global::Client_PM.Properties.Resources.Edit_Neutral;
            this.FB_EditionPhoto.OverImage = global::Client_PM.Properties.Resources.Edit_Hover;
            this.FB_EditionPhoto.Size = new System.Drawing.Size(40, 40);
            this.FB_EditionPhoto.TabIndex = 5;
            this.FB_ToolTips.SetToolTip(this.FB_EditionPhoto, "Modifier l\'image séléctionnée");
            this.FB_EditionPhoto.UseVisualStyleBackColor = true;
            // 
            // flashButton4
            // 
            this.flashButton4.BackgroundImage = global::Client_PM.Properties.Resources.Show_Neutral;
            this.flashButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashButton4.ClickedImage = global::Client_PM.Properties.Resources.Show_Clicked;
            this.flashButton4.DisabledImage = global::Client_PM.Properties.Resources.Show_Disabled;
            this.flashButton4.Image = ((System.Drawing.Image)(resources.GetObject("flashButton4.Image")));
            this.flashButton4.Location = new System.Drawing.Point(170, 25);
            this.flashButton4.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.flashButton4.Name = "flashButton4";
            this.flashButton4.NeutralImage = global::Client_PM.Properties.Resources.Show_Neutral;
            this.flashButton4.OverImage = global::Client_PM.Properties.Resources.Show_Hover;
            this.flashButton4.Size = new System.Drawing.Size(40, 40);
            this.flashButton4.TabIndex = 6;
            this.flashButton4.Text = "flashButton4";
            this.FB_ToolTips.SetToolTip(this.flashButton4, "Masquer les informations des photos");
            this.flashButton4.UseVisualStyleBackColor = true;
            // 
            // FB_SupprimerPhoto
            // 
            this.FB_SupprimerPhoto.BackgroundImage = global::Client_PM.Properties.Resources.Delete_Neutral;
            this.FB_SupprimerPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_SupprimerPhoto.ClickedImage = global::Client_PM.Properties.Resources.Delete_Clicked;
            this.FB_SupprimerPhoto.DisabledImage = global::Client_PM.Properties.Resources.Delete_Disabled;
            this.FB_SupprimerPhoto.Image = ((System.Drawing.Image)(resources.GetObject("FB_SupprimerPhoto.Image")));
            this.FB_SupprimerPhoto.Location = new System.Drawing.Point(116, 25);
            this.FB_SupprimerPhoto.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.FB_SupprimerPhoto.Name = "FB_SupprimerPhoto";
            this.FB_SupprimerPhoto.NeutralImage = global::Client_PM.Properties.Resources.Delete_Neutral;
            this.FB_SupprimerPhoto.OverImage = global::Client_PM.Properties.Resources.Delete_Hover;
            this.FB_SupprimerPhoto.Size = new System.Drawing.Size(40, 40);
            this.FB_SupprimerPhoto.TabIndex = 4;
            this.FB_ToolTips.SetToolTip(this.FB_SupprimerPhoto, "Supprimer l\'image séléctionnée");
            this.FB_SupprimerPhoto.UseVisualStyleBackColor = true;
            // 
            // TP_Filters
            // 
            this.TP_Filters.BackColor = System.Drawing.Color.White;
            this.TP_Filters.Controls.Add(this.groupBox6);
            this.TP_Filters.Controls.Add(this.groupBox5);
            this.TP_Filters.Location = new System.Drawing.Point(4, 29);
            this.TP_Filters.Name = "TP_Filters";
            this.TP_Filters.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Filters.Size = new System.Drawing.Size(1121, 87);
            this.TP_Filters.TabIndex = 1;
            this.TP_Filters.Text = "Filtres";
            this.TP_Filters.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radioButton1);
            this.groupBox6.Controls.Add(this.CBX_Keywords);
            this.groupBox6.Controls.Add(this.radioButton3);
            this.groupBox6.Controls.Add(this.checkBox4);
            this.groupBox6.Controls.Add(this.dateTimePicker1);
            this.groupBox6.Controls.Add(this.radioButton2);
            this.groupBox6.Controls.Add(this.CBX_UsersList);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.dateTimePicker2);
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(755, 75);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Filtres sur l\'image";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(6, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(92, 20);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Utilisateurs";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(305, 21);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(55, 20);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Date";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(559, 35);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(190, 20);
            this.checkBox4.TabIndex = 10;
            this.checkBox4.Text = "Ne pas afficher mes photos";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(6, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(86, 20);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Mots-Clés";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.flashButton12);
            this.groupBox5.Controls.Add(this.flashButton11);
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Location = new System.Drawing.Point(768, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(347, 81);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Liste noire";
            // 
            // flashButton12
            // 
            this.flashButton12.BackgroundImage = global::Client_PM.Properties.Resources.Reset_Neutral;
            this.flashButton12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashButton12.ClickedImage = global::Client_PM.Properties.Resources.Reset_Clicked;
            this.flashButton12.DisabledImage = global::Client_PM.Properties.Resources.Reset_Disabled;
            this.flashButton12.Image = ((System.Drawing.Image)(resources.GetObject("flashButton12.Image")));
            this.flashButton12.Location = new System.Drawing.Point(280, 23);
            this.flashButton12.Margin = new System.Windows.Forms.Padding(10);
            this.flashButton12.Name = "flashButton12";
            this.flashButton12.NeutralImage = global::Client_PM.Properties.Resources.Reset_Neutral;
            this.flashButton12.OverImage = global::Client_PM.Properties.Resources.Reset_Hover;
            this.flashButton12.Size = new System.Drawing.Size(40, 40);
            this.flashButton12.TabIndex = 3;
            this.flashButton12.Text = "flashButton12";
            this.FB_ToolTips.SetToolTip(this.flashButton12, "Réinitialiser la liste");
            this.flashButton12.UseVisualStyleBackColor = true;
            // 
            // flashButton11
            // 
            this.flashButton11.BackgroundImage = global::Client_PM.Properties.Resources.Add_Neutral;
            this.flashButton11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashButton11.ClickedImage = global::Client_PM.Properties.Resources.Add_Clicked;
            this.flashButton11.DisabledImage = global::Client_PM.Properties.Resources.Add_Disabled;
            this.flashButton11.Image = ((System.Drawing.Image)(resources.GetObject("flashButton11.Image")));
            this.flashButton11.Location = new System.Drawing.Point(220, 23);
            this.flashButton11.Margin = new System.Windows.Forms.Padding(10);
            this.flashButton11.Name = "flashButton11";
            this.flashButton11.NeutralImage = global::Client_PM.Properties.Resources.Add_Neutral;
            this.flashButton11.OverImage = global::Client_PM.Properties.Resources.Add_Hover;
            this.flashButton11.Size = new System.Drawing.Size(40, 40);
            this.flashButton11.TabIndex = 2;
            this.flashButton11.Text = "flashButton11";
            this.FB_ToolTips.SetToolTip(this.flashButton11, "Ajouter l\'utilisateur à la liste");
            this.flashButton11.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // PhotoBrowser
            // 
            this.PhotoBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhotoBrowser.Location = new System.Drawing.Point(12, 149);
            this.PhotoBrowser.Name = "PhotoBrowser";
            this.PhotoBrowser.Placement = PhotoManagerClient.PhotoBrowserPlacement.Left;
            this.PhotoBrowser.SelectedPhoto = null;
            this.PhotoBrowser.Size = new System.Drawing.Size(1129, 513);
            this.PhotoBrowser.TabIndex = 0;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 674);
            this.Controls.Add(this.TBC_PhotoManager);
            this.Controls.Add(this.PhotoBrowser);
            this.Controls.Add(this.MS_Account);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.MS_Account;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1169, 713);
            this.Name = "MainForm";
            this.Text = "Photo Manager Client";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
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
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PhotoManagerClient.PhotosBrowser PhotoBrowser;
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
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox CBX_Keywords;
        private System.IO.FileSystemWatcher FileWatcher;
        private System.Windows.Forms.ToolStripMenuItem MI_Blacklist_Add;
        private System.Windows.Forms.ToolStripMenuItem MI_Blacklist_Show;
        private PhotoManagerClient.FlashButton FB_EditionPhoto;
        private PhotoManagerClient.FlashButton FB_SupprimerPhoto;
        private PhotoManagerClient.FlashButton FB_AjouterPhoto;
        private PhotoManagerClient.FlashButton flashButton4;
        private System.Windows.Forms.ToolStripMenuItem MI_Display;
        private System.Windows.Forms.ToolStripMenuItem MI_Display_Up;
        private System.Windows.Forms.ToolStripMenuItem MI_Display_Down;
        private System.Windows.Forms.ToolStripMenuItem MI_Display_Left;
        private System.Windows.Forms.ToolStripMenuItem MI_Display_Right;
        private PhotoManagerClient.FlashButton flashButton6;
        private System.Windows.Forms.TabControl TBC_PhotoManager;
        private System.Windows.Forms.TabPage TP_Photos;
        private System.Windows.Forms.TabPage TP_Filters;
        private System.Windows.Forms.GroupBox GB_Slideshow;
        private System.Windows.Forms.GroupBox GB_Image;
        private PhotoManagerClient.FlashButton flashButton7;
        private PhotoManagerClient.FlashButton flashButton5;
        private System.Windows.Forms.GroupBox GB_Others;
        private System.Windows.Forms.GroupBox GB_Scroll;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private PhotoManagerClient.FlashButton flashButton8;
        private System.Windows.Forms.ToolTip FB_ToolTips;
        private PhotoManagerClient.FlashButton flashButton9;
        private PhotoManagerClient.FlashButton flashButton10;
        private System.Windows.Forms.GroupBox groupBox6;
        private PhotoManagerClient.FlashButton flashButton12;
        private PhotoManagerClient.FlashButton flashButton11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
    }
}

