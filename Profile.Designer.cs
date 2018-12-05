namespace Client_PM
{
    partial class Profile
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
            this.LBL_Username = new System.Windows.Forms.Label();
            this.LBL_Password = new System.Windows.Forms.Label();
            this.LBL_Confirm = new System.Windows.Forms.Label();
            this.LBL_Avatar = new System.Windows.Forms.Label();
            this.GBX_Details = new System.Windows.Forms.GroupBox();
            this.BTN_Choose = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.BTN_Edit = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.PBX_Avatar = new System.Windows.Forms.PictureBox();
            this.TBX_Validate = new System.Windows.Forms.TextBox();
            this.TBX_Password = new System.Windows.Forms.TextBox();
            this.TBX_Username = new System.Windows.Forms.TextBox();
            this.OFD_Image = new System.Windows.Forms.OpenFileDialog();
            this.GBX_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_Username
            // 
            this.LBL_Username.AutoSize = true;
            this.LBL_Username.Location = new System.Drawing.Point(13, 32);
            this.LBL_Username.Margin = new System.Windows.Forms.Padding(10);
            this.LBL_Username.Name = "LBL_Username";
            this.LBL_Username.Size = new System.Drawing.Size(126, 20);
            this.LBL_Username.TabIndex = 0;
            this.LBL_Username.Text = "Nom d\'utilisateur";
            // 
            // LBL_Password
            // 
            this.LBL_Password.AutoSize = true;
            this.LBL_Password.Location = new System.Drawing.Point(34, 72);
            this.LBL_Password.Margin = new System.Windows.Forms.Padding(10);
            this.LBL_Password.Name = "LBL_Password";
            this.LBL_Password.Size = new System.Drawing.Size(105, 20);
            this.LBL_Password.TabIndex = 1;
            this.LBL_Password.Text = "Mot de passe";
            // 
            // LBL_Confirm
            // 
            this.LBL_Confirm.AutoSize = true;
            this.LBL_Confirm.Location = new System.Drawing.Point(34, 112);
            this.LBL_Confirm.Margin = new System.Windows.Forms.Padding(10);
            this.LBL_Confirm.Name = "LBL_Confirm";
            this.LBL_Confirm.Size = new System.Drawing.Size(99, 20);
            this.LBL_Confirm.TabIndex = 2;
            this.LBL_Confirm.Text = "Confirmation";
            // 
            // LBL_Avatar
            // 
            this.LBL_Avatar.AutoSize = true;
            this.LBL_Avatar.Location = new System.Drawing.Point(77, 152);
            this.LBL_Avatar.Margin = new System.Windows.Forms.Padding(10);
            this.LBL_Avatar.Name = "LBL_Avatar";
            this.LBL_Avatar.Size = new System.Drawing.Size(55, 20);
            this.LBL_Avatar.TabIndex = 3;
            this.LBL_Avatar.Text = "Avatar";
            // 
            // GBX_Details
            // 
            this.GBX_Details.Controls.Add(this.BTN_Choose);
            this.GBX_Details.Controls.Add(this.BTN_Cancel);
            this.GBX_Details.Controls.Add(this.BTN_Edit);
            this.GBX_Details.Controls.Add(this.BTN_Delete);
            this.GBX_Details.Controls.Add(this.PBX_Avatar);
            this.GBX_Details.Controls.Add(this.LBL_Avatar);
            this.GBX_Details.Controls.Add(this.TBX_Validate);
            this.GBX_Details.Controls.Add(this.TBX_Password);
            this.GBX_Details.Controls.Add(this.TBX_Username);
            this.GBX_Details.Controls.Add(this.LBL_Username);
            this.GBX_Details.Controls.Add(this.LBL_Password);
            this.GBX_Details.Controls.Add(this.LBL_Confirm);
            this.GBX_Details.Location = new System.Drawing.Point(13, 13);
            this.GBX_Details.Name = "GBX_Details";
            this.GBX_Details.Size = new System.Drawing.Size(374, 347);
            this.GBX_Details.TabIndex = 4;
            this.GBX_Details.TabStop = false;
            this.GBX_Details.Text = "Détails";
            // 
            // BTN_Choose
            // 
            this.BTN_Choose.Location = new System.Drawing.Point(74, 243);
            this.BTN_Choose.Name = "BTN_Choose";
            this.BTN_Choose.Size = new System.Drawing.Size(65, 27);
            this.BTN_Choose.TabIndex = 11;
            this.BTN_Choose.Text = "Choisir";
            this.BTN_Choose.UseVisualStyleBackColor = true;
            this.BTN_Choose.Click += new System.EventHandler(this.BTN_Choose_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(248, 309);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(76, 27);
            this.BTN_Cancel.TabIndex = 10;
            this.BTN_Cancel.Text = "Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Edit.Location = new System.Drawing.Point(169, 309);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Size = new System.Drawing.Size(73, 27);
            this.BTN_Edit.TabIndex = 9;
            this.BTN_Edit.Text = "Modifier";
            this.BTN_Edit.UseVisualStyleBackColor = true;
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.BTN_Delete.Location = new System.Drawing.Point(17, 309);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(96, 27);
            this.BTN_Delete.TabIndex = 8;
            this.BTN_Delete.Text = "Supprimer";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            // 
            // PBX_Avatar
            // 
            this.PBX_Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBX_Avatar.Location = new System.Drawing.Point(152, 148);
            this.PBX_Avatar.Margin = new System.Windows.Forms.Padding(10);
            this.PBX_Avatar.Name = "PBX_Avatar";
            this.PBX_Avatar.Size = new System.Drawing.Size(172, 122);
            this.PBX_Avatar.TabIndex = 7;
            this.PBX_Avatar.TabStop = false;
            this.PBX_Avatar.BackgroundImageChanged += new System.EventHandler(this.PBX_Avatar_BackgroundImageChanged);
            // 
            // TBX_Validate
            // 
            this.TBX_Validate.Location = new System.Drawing.Point(152, 109);
            this.TBX_Validate.Name = "TBX_Validate";
            this.TBX_Validate.Size = new System.Drawing.Size(172, 26);
            this.TBX_Validate.TabIndex = 6;
            this.TBX_Validate.UseSystemPasswordChar = true;
            // 
            // TBX_Password
            // 
            this.TBX_Password.Location = new System.Drawing.Point(152, 69);
            this.TBX_Password.Name = "TBX_Password";
            this.TBX_Password.Size = new System.Drawing.Size(172, 26);
            this.TBX_Password.TabIndex = 5;
            this.TBX_Password.UseSystemPasswordChar = true;
            // 
            // TBX_Username
            // 
            this.TBX_Username.Location = new System.Drawing.Point(152, 29);
            this.TBX_Username.Name = "TBX_Username";
            this.TBX_Username.Size = new System.Drawing.Size(172, 26);
            this.TBX_Username.TabIndex = 4;
            // 
            // OFD_Image
            // 
            this.OFD_Image.FileName = "openFileDialog1";
            // 
            // Profile
            // 
            this.AcceptButton = this.BTN_Edit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Cancel;
            this.ClientSize = new System.Drawing.Size(394, 365);
            this.Controls.Add(this.GBX_Details);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.GBX_Details.ResumeLayout(false);
            this.GBX_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBL_Username;
        private System.Windows.Forms.Label LBL_Password;
        private System.Windows.Forms.Label LBL_Confirm;
        private System.Windows.Forms.Label LBL_Avatar;
        private System.Windows.Forms.GroupBox GBX_Details;
        private System.Windows.Forms.Button BTN_Choose;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_Edit;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.PictureBox PBX_Avatar;
        private System.Windows.Forms.TextBox TBX_Validate;
        private System.Windows.Forms.TextBox TBX_Password;
        private System.Windows.Forms.TextBox TBX_Username;
        private System.Windows.Forms.OpenFileDialog OFD_Image;
    }
}