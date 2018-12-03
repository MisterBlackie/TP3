namespace Client_PM
{
    partial class AddEditPhoto
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
            this.LBL_Desc = new System.Windows.Forms.Label();
            this.RTB_Description = new System.Windows.Forms.RichTextBox();
            this.LBL_Keywords = new System.Windows.Forms.Label();
            this.TBX_Keywords = new System.Windows.Forms.TextBox();
            this.GB_Info = new System.Windows.Forms.GroupBox();
            this.RB_Private = new System.Windows.Forms.RadioButton();
            this.TBX_Title = new System.Windows.Forms.TextBox();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.BTN_Ajout = new System.Windows.Forms.Button();
            this.BTN_Selectionner = new System.Windows.Forms.Button();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.BTN_Rotate = new System.Windows.Forms.Button();
            this.ImageBox = new PhotoManagerClient.ImageBox();
            this.GB_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_Desc
            // 
            this.LBL_Desc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Desc.AutoSize = true;
            this.LBL_Desc.Location = new System.Drawing.Point(16, 84);
            this.LBL_Desc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_Desc.Name = "LBL_Desc";
            this.LBL_Desc.Size = new System.Drawing.Size(93, 20);
            this.LBL_Desc.TabIndex = 10;
            this.LBL_Desc.Text = "Description:";
            // 
            // RTB_Description
            // 
            this.RTB_Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTB_Description.Location = new System.Drawing.Point(19, 106);
            this.RTB_Description.Margin = new System.Windows.Forms.Padding(2);
            this.RTB_Description.Name = "RTB_Description";
            this.RTB_Description.Size = new System.Drawing.Size(337, 85);
            this.RTB_Description.TabIndex = 3;
            this.RTB_Description.Text = "";
            // 
            // LBL_Keywords
            // 
            this.LBL_Keywords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Keywords.AutoSize = true;
            this.LBL_Keywords.Location = new System.Drawing.Point(15, 206);
            this.LBL_Keywords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_Keywords.Name = "LBL_Keywords";
            this.LBL_Keywords.Size = new System.Drawing.Size(73, 20);
            this.LBL_Keywords.TabIndex = 11;
            this.LBL_Keywords.Text = "Mot-clés:";
            // 
            // TBX_Keywords
            // 
            this.TBX_Keywords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBX_Keywords.Location = new System.Drawing.Point(19, 228);
            this.TBX_Keywords.Margin = new System.Windows.Forms.Padding(2);
            this.TBX_Keywords.Name = "TBX_Keywords";
            this.TBX_Keywords.Size = new System.Drawing.Size(337, 26);
            this.TBX_Keywords.TabIndex = 4;
            // 
            // GB_Info
            // 
            this.GB_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_Info.Controls.Add(this.RB_Private);
            this.GB_Info.Controls.Add(this.TBX_Title);
            this.GB_Info.Controls.Add(this.TBX_Keywords);
            this.GB_Info.Controls.Add(this.LBL_Title);
            this.GB_Info.Controls.Add(this.LBL_Keywords);
            this.GB_Info.Controls.Add(this.LBL_Desc);
            this.GB_Info.Controls.Add(this.RTB_Description);
            this.GB_Info.Location = new System.Drawing.Point(12, 281);
            this.GB_Info.Margin = new System.Windows.Forms.Padding(2);
            this.GB_Info.Name = "GB_Info";
            this.GB_Info.Padding = new System.Windows.Forms.Padding(2);
            this.GB_Info.Size = new System.Drawing.Size(373, 270);
            this.GB_Info.TabIndex = 2;
            this.GB_Info.TabStop = false;
            this.GB_Info.Text = "Informations";
            // 
            // RB_Private
            // 
            this.RB_Private.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RB_Private.AutoSize = true;
            this.RB_Private.Location = new System.Drawing.Point(278, 44);
            this.RB_Private.Name = "RB_Private";
            this.RB_Private.Size = new System.Drawing.Size(70, 24);
            this.RB_Private.TabIndex = 2;
            this.RB_Private.TabStop = true;
            this.RB_Private.Text = "Privée";
            this.RB_Private.UseVisualStyleBackColor = true;
            // 
            // TBX_Title
            // 
            this.TBX_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBX_Title.Location = new System.Drawing.Point(20, 43);
            this.TBX_Title.Margin = new System.Windows.Forms.Padding(2);
            this.TBX_Title.Name = "TBX_Title";
            this.TBX_Title.Size = new System.Drawing.Size(215, 26);
            this.TBX_Title.TabIndex = 1;
            // 
            // LBL_Title
            // 
            this.LBL_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Location = new System.Drawing.Point(16, 21);
            this.LBL_Title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(44, 20);
            this.LBL_Title.TabIndex = 9;
            this.LBL_Title.Text = "Titre:";
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(194, 567);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(95, 34);
            this.BTN_Cancel.TabIndex = 6;
            this.BTN_Cancel.Text = "Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // BTN_Ajout
            // 
            this.BTN_Ajout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Ajout.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ajout.Location = new System.Drawing.Point(295, 567);
            this.BTN_Ajout.Name = "BTN_Ajout";
            this.BTN_Ajout.Size = new System.Drawing.Size(95, 34);
            this.BTN_Ajout.TabIndex = 7;
            this.BTN_Ajout.Text = "Ajouter";
            this.BTN_Ajout.UseVisualStyleBackColor = true;
            this.BTN_Ajout.Click += new System.EventHandler(this.BTN_Ajout_Click);
            // 
            // BTN_Selectionner
            // 
            this.BTN_Selectionner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_Selectionner.Location = new System.Drawing.Point(12, 567);
            this.BTN_Selectionner.Name = "BTN_Selectionner";
            this.BTN_Selectionner.Size = new System.Drawing.Size(95, 34);
            this.BTN_Selectionner.TabIndex = 1;
            this.BTN_Selectionner.Text = "Parcourir";
            this.BTN_Selectionner.UseVisualStyleBackColor = true;
            this.BTN_Selectionner.Click += new System.EventHandler(this.BTN_Selectionner_Click);
            // 
            // FileDialog
            // 
            this.FileDialog.Title = "Sélectionner une photo...";
            // 
            // BTN_Rotate
            // 
            this.BTN_Rotate.Enabled = false;
            this.BTN_Rotate.Location = new System.Drawing.Point(298, 251);
            this.BTN_Rotate.Name = "BTN_Rotate";
            this.BTN_Rotate.Size = new System.Drawing.Size(85, 25);
            this.BTN_Rotate.TabIndex = 12;
            this.BTN_Rotate.Text = "Rotation";
            this.BTN_Rotate.UseVisualStyleBackColor = true;
            this.BTN_Rotate.Click += new System.EventHandler(this.BTN_Rotate_Click);
            // 
            // ImageBox
            // 
            this.ImageBox.AllowDrop = true;
            this.ImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageBox.ControlToolTipText = "You can either drag & drop, paste image from clipboard or choose an image file wi" +
    "th context menu.";
            this.ImageBox.ImportImageText = "Import image from file...";
            this.ImageBox.Location = new System.Drawing.Point(12, 13);
            this.ImageBox.Margin = new System.Windows.Forms.Padding(5);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.OpenFileDialogTitle = "Please choose image an file";
            this.ImageBox.PasteMenuText = "Paste image from clipboard";
            this.ImageBox.Size = new System.Drawing.Size(371, 235);
            this.ImageBox.TabIndex = 0;
            this.ImageBox.TabStop = false;
            this.ImageBox.BackgroundImageChanged += new System.EventHandler(this.ImageBox_BackgroundImageChanged);
            // 
            // AddEditPhoto
            // 
            this.AcceptButton = this.BTN_Ajout;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Cancel;
            this.ClientSize = new System.Drawing.Size(402, 613);
            this.Controls.Add(this.BTN_Rotate);
            this.Controls.Add(this.BTN_Selectionner);
            this.Controls.Add(this.BTN_Ajout);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.GB_Info);
            this.Controls.Add(this.ImageBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(418, 652);
            this.Name = "AddEditPhoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout d\'une photo";
            this.Load += new System.EventHandler(this.AddEditPhoto_Load);
            this.GB_Info.ResumeLayout(false);
            this.GB_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PhotoManagerClient.ImageBox ImageBox;
        private System.Windows.Forms.Label LBL_Desc;
        private System.Windows.Forms.RichTextBox RTB_Description;
        private System.Windows.Forms.Label LBL_Keywords;
        private System.Windows.Forms.TextBox TBX_Keywords;
        private System.Windows.Forms.GroupBox GB_Info;
        private System.Windows.Forms.RadioButton RB_Private;
        private System.Windows.Forms.TextBox TBX_Title;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_Ajout;
        private System.Windows.Forms.Button BTN_Selectionner;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.Button BTN_Rotate;
    }
}