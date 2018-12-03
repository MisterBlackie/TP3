namespace Client_PM
{
    partial class A_propos
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
            this.RTB_Infos = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // RTB_Infos
            // 
            this.RTB_Infos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTB_Infos.Location = new System.Drawing.Point(12, 12);
            this.RTB_Infos.Margin = new System.Windows.Forms.Padding(5);
            this.RTB_Infos.Name = "RTB_Infos";
            this.RTB_Infos.ReadOnly = true;
            this.RTB_Infos.Size = new System.Drawing.Size(243, 116);
            this.RTB_Infos.TabIndex = 0;
            this.RTB_Infos.Text = " Application client photo manager\n\n Gabriel Lachapelle\n Alexandre Tremblay\n";
            // 
            // A_propos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 136);
            this.Controls.Add(this.RTB_Infos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "A_propos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "À propos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTB_Infos;
    }
}