namespace Client_PM
{
    partial class CarouselSettings
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
            this.CB_DefilementAleatoire = new System.Windows.Forms.CheckBox();
            this.BTN_Reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TrackBarVitesse = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarVitesse)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_DefilementAleatoire
            // 
            this.CB_DefilementAleatoire.AutoSize = true;
            this.CB_DefilementAleatoire.Location = new System.Drawing.Point(17, 16);
            this.CB_DefilementAleatoire.Margin = new System.Windows.Forms.Padding(4);
            this.CB_DefilementAleatoire.Name = "CB_DefilementAleatoire";
            this.CB_DefilementAleatoire.Size = new System.Drawing.Size(156, 21);
            this.CB_DefilementAleatoire.TabIndex = 0;
            this.CB_DefilementAleatoire.Text = "Défilement aléatoire";
            this.CB_DefilementAleatoire.UseVisualStyleBackColor = true;
            this.CB_DefilementAleatoire.CheckedChanged += new System.EventHandler(this.CB_DefilementAleatoire_CheckedChanged);
            // 
            // BTN_Reset
            // 
            this.BTN_Reset.Location = new System.Drawing.Point(155, 254);
            this.BTN_Reset.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Reset.Name = "BTN_Reset";
            this.BTN_Reset.Size = new System.Drawing.Size(100, 28);
            this.BTN_Reset.TabIndex = 1;
            this.BTN_Reset.Text = "Réinitialiser";
            this.BTN_Reset.UseVisualStyleBackColor = true;
            this.BTN_Reset.Click += new System.EventHandler(this.BTN_Reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vitesse de défilement";
            // 
            // TrackBarVitesse
            // 
            this.TrackBarVitesse.Location = new System.Drawing.Point(20, 76);
            this.TrackBarVitesse.Name = "TrackBarVitesse";
            this.TrackBarVitesse.Size = new System.Drawing.Size(193, 56);
            this.TrackBarVitesse.TabIndex = 3;
            this.TrackBarVitesse.ValueChanged += new System.EventHandler(this.TrackBarVitesse_ValueChanged);
            // 
            // CarouselSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 286);
            this.Controls.Add(this.TrackBarVitesse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Reset);
            this.Controls.Add(this.CB_DefilementAleatoire);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CarouselSettings";
            this.Text = "CarouselSettings";
            this.Load += new System.EventHandler(this.CarouselSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarVitesse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CB_DefilementAleatoire;
        private System.Windows.Forms.Button BTN_Reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar TrackBarVitesse;
    }
}