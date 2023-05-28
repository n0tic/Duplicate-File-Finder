using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duplicate_Finder.UI
{
    internal class ButtonSimulator
    {
        private void ApplyGrayscaleEffect(PictureBox pictureBox)
        {
            // Create the grayscale color matrix
            ColorMatrix colorMatrix = new ColorMatrix(
                new float[][]
                {
            new float[] { 0.299f, 0.299f, 0.299f, 0, 0 },
            new float[] { 0.587f, 0.587f, 0.587f, 0, 0 },
            new float[] { 0.114f, 0.114f, 0.114f, 0, 0 },
            new float[] { 0, 0, 0, 1, 0 },
            new float[] { 0, 0, 0, 0, 1 }
                });

            // Create an ImageAttributes object and set the color matrix
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix);

            // Create a rectangle that covers the entire image
            Rectangle rectangle = new Rectangle(0, 0, pictureBox.Image.Width, pictureBox.Image.Height);

            // Draw the image with the grayscale effect
            using (Graphics graphics = Graphics.FromImage(pictureBox.Image))
            {
                graphics.DrawImage(pictureBox.Image, rectangle, 0, 0, pictureBox.Image.Width, pictureBox.Image.Height, GraphicsUnit.Pixel, imageAttributes);
            }

            // Refresh the picture box to reflect the updated image
            pictureBox.Refresh();
        }

        public void DisableButton(PictureBox pictureBoxButton)
        {
            // Apply the grayscale effect to the button's image
            ApplyGrayscaleEffect(pictureBoxButton);
            pictureBoxButton.Enabled = false;
        }

        public void EnableButton(PictureBox pictureBoxButton)
        {
            // Reset the button's image to its original state

            if(pictureBoxButton.Name == "FolderBrowserButton")
            {
                pictureBoxButton.Image = Properties.Resources._010_folder_30;
            }
            else if (pictureBoxButton.Name == "GetFilesButton")
            {
                pictureBoxButton.Image = Properties.Resources.play_button;
            }

            pictureBoxButton.Enabled = true;
        }
    }
}
