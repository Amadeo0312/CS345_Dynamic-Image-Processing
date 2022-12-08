using System;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;
using IS_Dynamic_Image_Processing.Libraries;

namespace ImageProcessor
{
    public partial class SubtractionForm : Form
    {
        Bitmap image, background, processed;
        bool imageEnable = false;
        public SubtractionForm()
        {
            InitializeComponent();
        }

        private void OpenImageDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            image = new Bitmap(OpenImageDialog.FileName);
            loadPicture.Image = image;

            imageEnable = true;
            LoadBackground.Enabled = true;
        }

        private void OpenBackgroundDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            background = new Bitmap(OpenBackgroundDialog.FileName);
            loadBg.Image = background;

            if (imageEnable)
                Subtract.Enabled = true;
        }

        private void LoadBackground_Click(object sender, EventArgs e)
        {
            OpenBackgroundDialog.ShowDialog();
        }

        private void Subtract_Click(object sender, EventArgs e)
        {     
            DIPLibrary.Subtraction(ref image, ref background, ref processed);
            processedPicture.Image = processed;

            saveToolStripMenuItem.Enabled = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog.Filter = "Bitmap Image|*.bmp";
            SaveFileDialog.Title = "Save an Image File";
            SaveFileDialog.ShowDialog();
        }

        private void SaveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            processedPicture.Image.Save(SaveFileDialog.FileName);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadImage_Click(object sender, EventArgs e)
        {
            OpenImageDialog.ShowDialog();
        }
    }
}
