namespace Client_PM
{
    partial class Carousel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carousel));
            this.FB_Settings = new PhotoManagerClient.FlashButton();
            this.imageBox1 = new PhotoManagerClient.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FB_Settings
            // 
            this.FB_Settings.BackColor = System.Drawing.Color.Transparent;
            this.FB_Settings.BackgroundImage = global::Client_PM.Properties.Resources.Settings_Neutral;
            this.FB_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Settings.ClickedImage = global::Client_PM.Properties.Resources.Settings_Clicked;
            this.FB_Settings.DisabledImage = global::Client_PM.Properties.Resources.Settings_Disabled;
            this.FB_Settings.Image = ((System.Drawing.Image)(resources.GetObject("FB_Settings.Image")));
            this.FB_Settings.Location = new System.Drawing.Point(755, 10);
            this.FB_Settings.Name = "FB_Settings";
            this.FB_Settings.NeutralImage = global::Client_PM.Properties.Resources.Settings_Neutral;
            this.FB_Settings.OverImage = global::Client_PM.Properties.Resources.Settings_Over;
            this.FB_Settings.Size = new System.Drawing.Size(36, 36);
            this.FB_Settings.TabIndex = 3;
            this.FB_Settings.Text = "Options";
            this.FB_Settings.UseVisualStyleBackColor = false;
            this.FB_Settings.Click += new System.EventHandler(this.FB_Settings_Click);
            this.FB_Settings.Paint += new System.Windows.Forms.PaintEventHandler(this.FB_Settings_Paint);
            // 
            // imageBox1
            // 
            this.imageBox1.AllowDrop = true;
            this.imageBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBox1.BackColor = System.Drawing.Color.Transparent;
            this.imageBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox1.ControlToolTipText = "You can either drag & drop, paste image from clipboard or choose an image file wi" +
    "th context menu.";
            this.imageBox1.ImportImageText = "Import image from file...";
            this.imageBox1.Location = new System.Drawing.Point(-1, -2);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.OpenFileDialogTitle = "Please choose image an file";
            this.imageBox1.PasteMenuText = "Paste image from clipboard";
            this.imageBox1.Size = new System.Drawing.Size(801, 454);
            this.imageBox1.TabIndex = 0;
            this.imageBox1.TabStop = false;
            // 
            // Carousel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FB_Settings);
            this.Controls.Add(this.imageBox1);
            this.Name = "Carousel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carousel";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Carousel_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PhotoManagerClient.ImageBox imageBox1;
        private PhotoManagerClient.FlashButton FB_Settings;
    }
}