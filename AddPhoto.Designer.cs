namespace Client_PM
{
    partial class AddPhoto
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
            this.label1 = new System.Windows.Forms.Label();
            this.RTB_Description = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Keywords = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBTN_EstPrivee = new System.Windows.Forms.RadioButton();
            this.TB_Titre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.BTN_Ajout = new System.Windows.Forms.Button();
            this.BTN_Selectionner = new System.Windows.Forms.Button();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ImageBox = new PhotoManagerClient.ImageBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Description:";
            // 
            // RTB_Description
            // 
            this.RTB_Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTB_Description.Location = new System.Drawing.Point(19, 123);
            this.RTB_Description.Margin = new System.Windows.Forms.Padding(2);
            this.RTB_Description.Name = "RTB_Description";
            this.RTB_Description.Size = new System.Drawing.Size(337, 85);
            this.RTB_Description.TabIndex = 3;
            this.RTB_Description.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mot-clé:";
            // 
            // TB_Keywords
            // 
            this.TB_Keywords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Keywords.Location = new System.Drawing.Point(19, 251);
            this.TB_Keywords.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Keywords.Name = "TB_Keywords";
            this.TB_Keywords.Size = new System.Drawing.Size(337, 30);
            this.TB_Keywords.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.RBTN_EstPrivee);
            this.groupBox1.Controls.Add(this.TB_Titre);
            this.groupBox1.Controls.Add(this.TB_Keywords);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RTB_Description);
            this.groupBox1.Location = new System.Drawing.Point(12, 255);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(373, 307);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // RBTN_EstPrivee
            // 
            this.RBTN_EstPrivee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RBTN_EstPrivee.AutoSize = true;
            this.RBTN_EstPrivee.Location = new System.Drawing.Point(249, 60);
            this.RBTN_EstPrivee.Name = "RBTN_EstPrivee";
            this.RBTN_EstPrivee.Size = new System.Drawing.Size(88, 29);
            this.RBTN_EstPrivee.TabIndex = 2;
            this.RBTN_EstPrivee.TabStop = true;
            this.RBTN_EstPrivee.Text = "Privée";
            this.RBTN_EstPrivee.UseVisualStyleBackColor = true;
            // 
            // TB_Titre
            // 
            this.TB_Titre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Titre.Location = new System.Drawing.Point(19, 59);
            this.TB_Titre.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Titre.Name = "TB_Titre";
            this.TB_Titre.Size = new System.Drawing.Size(215, 30);
            this.TB_Titre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Titre:";
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(179, 567);
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
            this.BTN_Ajout.Location = new System.Drawing.Point(290, 567);
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
            this.BTN_Selectionner.Location = new System.Drawing.Point(14, 567);
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
            this.ImageBox.Location = new System.Drawing.Point(14, 14);
            this.ImageBox.Margin = new System.Windows.Forms.Padding(5);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.OpenFileDialogTitle = "Please choose image an file";
            this.ImageBox.PasteMenuText = "Paste image from clipboard";
            this.ImageBox.Size = new System.Drawing.Size(371, 235);
            this.ImageBox.TabIndex = 0;
            this.ImageBox.TabStop = false;
            this.ImageBox.BackgroundImageChanged += new System.EventHandler(this.ImageBox_BackgroundImageChanged);
            // 
            // AJoutPhoto
            // 
            this.AcceptButton = this.BTN_Ajout;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Cancel;
            this.ClientSize = new System.Drawing.Size(402, 613);
            this.Controls.Add(this.BTN_Selectionner);
            this.Controls.Add(this.BTN_Ajout);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ImageBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(418, 652);
            this.Name = "AJoutPhoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout d\'une photo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PhotoManagerClient.ImageBox ImageBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RTB_Description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Keywords;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBTN_EstPrivee;
        private System.Windows.Forms.TextBox TB_Titre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_Ajout;
        private System.Windows.Forms.Button BTN_Selectionner;
        private System.Windows.Forms.OpenFileDialog FileDialog;
    }
}