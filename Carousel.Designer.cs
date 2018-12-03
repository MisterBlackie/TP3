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
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FB_Settings
            // 
            this.FB_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FB_Settings.BackColor = System.Drawing.Color.Transparent;
            this.FB_Settings.BackgroundImage = global::Client_PM.Properties.Resources.Settings_Neutral;
            this.FB_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Settings.ClickedImage = global::Client_PM.Properties.Resources.Settings_Clicked;
            this.FB_Settings.DisabledImage = global::Client_PM.Properties.Resources.Settings_Disabled;
            this.FB_Settings.ForeColor = System.Drawing.Color.Transparent;
            this.FB_Settings.Image = ((System.Drawing.Image)(resources.GetObject("FB_Settings.Image")));
            this.FB_Settings.Location = new System.Drawing.Point(1007, 12);
            this.FB_Settings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FB_Settings.Name = "FB_Settings";
            this.FB_Settings.NeutralImage = global::Client_PM.Properties.Resources.Settings_Neutral;
            this.FB_Settings.OverImage = global::Client_PM.Properties.Resources.Settings_Over;
            this.FB_Settings.Size = new System.Drawing.Size(48, 44);
            this.FB_Settings.TabIndex = 3;
            this.FB_Settings.Text = "Options";
            this.FB_Settings.UseVisualStyleBackColor = false;
            this.FB_Settings.Click += new System.EventHandler(this.FB_Settings_Click);
            this.FB_Settings.Paint += new System.Windows.Forms.PaintEventHandler(this.FB_Settings_Paint);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // PictureBox
            // 
            this.PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox.BackColor = System.Drawing.Color.Gray;
            this.PictureBox.Location = new System.Drawing.Point(2, 1);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(1064, 552);
            this.PictureBox.TabIndex = 4;
            this.PictureBox.TabStop = false;
            // 
            // Carousel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.FB_Settings);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Carousel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diaporama";
            this.Load += new System.EventHandler(this.Carousel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Carousel_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PhotoManagerClient.FlashButton FB_Settings;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox PictureBox;
    }
}