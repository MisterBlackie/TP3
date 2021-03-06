﻿namespace Client_PM
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
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.MS_Carousel = new System.Windows.Forms.MenuStrip();
            this.TSMI_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_FullScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Carousel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // MS_Carousel
            // 
            this.MS_Carousel.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MS_Carousel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Settings,
            this.TSMI_FullScreen});
            this.MS_Carousel.Location = new System.Drawing.Point(0, 0);
            this.MS_Carousel.Name = "MS_Carousel";
            this.MS_Carousel.Size = new System.Drawing.Size(800, 24);
            this.MS_Carousel.TabIndex = 4;
            this.MS_Carousel.Text = "MS_Carousel";
            // 
            // TSMI_Settings
            // 
            this.TSMI_Settings.Name = "TSMI_Settings";
            this.TSMI_Settings.Size = new System.Drawing.Size(61, 20);
            this.TSMI_Settings.Text = "Options";
            this.TSMI_Settings.Click += new System.EventHandler(this.TSMI_Settings_Click);
            // 
            // TSMI_FullScreen
            // 
            this.TSMI_FullScreen.Name = "TSMI_FullScreen";
            this.TSMI_FullScreen.Size = new System.Drawing.Size(77, 20);
            this.TSMI_FullScreen.Text = "Plein écran";
            this.TSMI_FullScreen.Click += new System.EventHandler(this.TSMI_FullScreen_Click);
            // 
            // Carousel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MS_Carousel);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.MS_Carousel;
            this.Name = "Carousel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diaporama";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Carousel_FormClosing);
            this.Load += new System.EventHandler(this.Carousel_Load);
            this.Shown += new System.EventHandler(this.Carousel_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Carousel_KeyDown);
            this.MS_Carousel.ResumeLayout(false);
            this.MS_Carousel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.MenuStrip MS_Carousel;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Settings;
        private System.Windows.Forms.ToolStripMenuItem TSMI_FullScreen;
    }
}