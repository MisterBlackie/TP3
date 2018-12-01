using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_PM
{
    public partial class InfoPhoto : Form
    {
        public PhotoManagerClient.Photo Photo { get; set; }
        public string User { get; set; }
        public InfoPhoto()
        {
            InitializeComponent();
        }

        private void InfoPhoto_Load(object sender, EventArgs e)
        {
            PictureBox.Image = Photo.GetOriginalImage();

            TBX_Author.Text = User;
            TBX_Title.Text = Photo.Title;
            TBX_CreationDate.Text = Photo.CreationDate.ToString();
            RTB_Description.Text = Photo.Description;
            TBX_Keywords.Text = Photo.Keywords;
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
