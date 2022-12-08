using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ImageProcessor;
using IS_Dynamic_Image_Processing.Libraries;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IS_Dynamic_Image_Processing
{
    public partial class ImageProcessor : Form
    {
        Bitmap loaded, processed;
        public ImageProcessor()
        {
            InitializeComponent();
        }

        private void ImageProcessor_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp";
            saveFileDialog.Title = "Open an Image File";
            openFileDialog.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Bitmap Image|*.bmp";
            saveFileDialog.Title = "Save an Image File";
            saveFileDialog.ShowDialog();
        }

        private void OpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            loaded = new Bitmap(openFileDialog.FileName);
            loadedImage.Image = loaded;

            basicCopy.Enabled = true;
            greyScale.Enabled = true;
            colorInversion.Enabled = true;
            sepia.Enabled = true;
            histogram.Enabled = true;
            saveToolStripMenuItem.Enabled = true;
        }

        private void basicCopy_Click(object sender, EventArgs e)
        {
            DIPLibrary.CopyImage(ref loaded, ref processed);
            processedImage.Image = processed;
        }

        private void greyScale_Click(object sender, EventArgs e)
        {
            DIPLibrary.Greyscale(ref loaded, ref processed);
            processedImage.Image = processed;
        }

        private void colorInversion_Click(object sender, EventArgs e)
        {
            DIPLibrary.ColorInversion(ref loaded, ref processed);
            processedImage.Image = processed;
        }

        private void sepia_Click(object sender, EventArgs e)
        {
            DIPLibrary.Sepia(ref loaded, ref processed);
            processedImage.Image = processed;
        }

        private void histogram_Click(object sender, EventArgs e)
        {
            DIPLibrary.Histogram(ref loaded, ref processed);
            processedImage.Image = processed;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            SubtractionForm form2 = new SubtractionForm();
            form2.ShowDialog();
        }

        private void SaveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            processedImage.Image.Save(saveFileDialog.FileName);
        }
    }
}

