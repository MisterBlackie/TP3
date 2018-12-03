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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarVitesse)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_DefilementAleatoire
            // 
            this.CB_DefilementAleatoire.AutoSize = true;
            this.CB_DefilementAleatoire.Location = new System.Drawing.Point(9, 29);
            this.CB_DefilementAleatoire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CB_DefilementAleatoire.Name = "CB_DefilementAleatoire";
            this.CB_DefilementAleatoire.Size = new System.Drawing.Size(170, 24);
            this.CB_DefilementAleatoire.TabIndex = 0;
            this.CB_DefilementAleatoire.Text = "Défilement aléatoire";
            this.CB_DefilementAleatoire.UseVisualStyleBackColor = true;
            this.CB_DefilementAleatoire.CheckedChanged += new System.EventHandler(this.CB_DefilementAleatoire_CheckedChanged);
            // 
            // BTN_Reset
            // 
            this.BTN_Reset.Location = new System.Drawing.Point(99, 250);
            this.BTN_Reset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.label1.Location = new System.Drawing.Point(9, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vitesse de défilement";
            // 
            // TrackBarVitesse
            // 
            this.TrackBarVitesse.Location = new System.Drawing.Point(6, 138);
            this.TrackBarVitesse.Minimum = 1;
            this.TrackBarVitesse.Name = "TrackBarVitesse";
            this.TrackBarVitesse.Size = new System.Drawing.Size(173, 45);
            this.TrackBarVitesse.TabIndex = 3;
            this.TrackBarVitesse.Value = 1;
            this.TrackBarVitesse.ValueChanged += new System.EventHandler(this.TrackBarVitesse_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rapide";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lent";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CB_DefilementAleatoire);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TrackBarVitesse);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(186, 226);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // CarouselSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 288);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTN_Reset);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CarouselSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarouselSettings";
            this.Load += new System.EventHandler(this.CarouselSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarVitesse)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox CB_DefilementAleatoire;
        private System.Windows.Forms.Button BTN_Reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar TrackBarVitesse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}