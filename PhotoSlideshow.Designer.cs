namespace Client_PM
{
    partial class PhotoSlideshow
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
            this.BTN_Quitter = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.PhotoBrowser = new PhotoManagerClient.PhotosBrowser();
            this.SuspendLayout();
            // 
            // BTN_Quitter
            // 
            this.BTN_Quitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Quitter.Location = new System.Drawing.Point(993, 557);
            this.BTN_Quitter.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_Quitter.Name = "BTN_Quitter";
            this.BTN_Quitter.Size = new System.Drawing.Size(110, 58);
            this.BTN_Quitter.TabIndex = 1;
            this.BTN_Quitter.Text = "Quitter";
            this.BTN_Quitter.UseVisualStyleBackColor = true;
            this.BTN_Quitter.Click += new System.EventHandler(this.BTN_Quitter_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Delete.Location = new System.Drawing.Point(861, 557);
            this.BTN_Delete.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(110, 58);
            this.BTN_Delete.TabIndex = 3;
            this.BTN_Delete.Text = "Retirer";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // PhotoBrowser
            // 
            this.PhotoBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhotoBrowser.Location = new System.Drawing.Point(14, 14);
            this.PhotoBrowser.Margin = new System.Windows.Forms.Padding(5);
            this.PhotoBrowser.Name = "PhotoBrowser";
            this.PhotoBrowser.Placement = PhotoManagerClient.PhotoBrowserPlacement.Left;
            this.PhotoBrowser.SelectedPhoto = null;
            this.PhotoBrowser.Size = new System.Drawing.Size(1089, 533);
            this.PhotoBrowser.TabIndex = 0;
            this.PhotoBrowser.SelectedChanged += new PhotoManagerClient.PhotosBrowser.SelectedChangedHandler(this.PhotoBrowser_SelectedChanged);
            // 
            // PhotoSlideshow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 629);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.BTN_Quitter);
            this.Controls.Add(this.PhotoBrowser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PhotoSlideshow";
            this.Text = "Modification des photos du diaporama";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PhotoSlideshow_FormClosing);
            this.Load += new System.EventHandler(this.PhotoSlideshow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PhotoManagerClient.PhotosBrowser PhotoBrowser;
        private System.Windows.Forms.Button BTN_Quitter;
        private System.Windows.Forms.Button BTN_Delete;
    }
}