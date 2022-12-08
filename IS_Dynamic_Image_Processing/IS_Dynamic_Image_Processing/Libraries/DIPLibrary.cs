using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_Dynamic_Image_Processing.Libraries
{
    public class DIPLibrary
    {   
        /// <summary>
        /// This Method will copy the loaded image and output it as processed image
        /// </summary>
        /// <param name="loaded"></param>
        /// <param name="processed"></param>
        public static void CopyImage(ref Bitmap loaded, ref Bitmap processed)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);    

            for(int i = 0; i < loaded.Width; i++)
            {
                for(int j = 0; j < loaded.Height; j++)
                {
                    Color pixel = loaded.GetPixel(i,j);

                    processed.SetPixel(i,j,pixel);
                }
            }
        }

        /// <summary>
        /// This method will change all the apparent color of the loaded
        /// image into a color grey and output it as processed image
        /// </summary>
        /// <param name="loaded"></param>
        /// <param name="processed"></param>
        public static void Greyscale(ref Bitmap loaded, ref Bitmap processed)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);

            for (int i = 0; i < loaded.Width; i++)
            {
                for (int j = 0; j < loaded.Height; j++)
                {
                    Color pixel = loaded.GetPixel(i, j);

                    int grey = (pixel.R + pixel.G + pixel.B) / 3;

                    Color greyscaleColor = Color.FromArgb(grey, grey, grey);
                    processed.SetPixel(i, j, greyscaleColor);
                }
            }
        }

        /// <summary>
        /// This method will invert the color of all the pixel of the loaded
        /// image and output it as processed image
        /// </summary>
        /// <param name="loaded"></param>
        /// <param name="processed"></param>
        public static void ColorInversion(ref Bitmap loaded, ref Bitmap processed)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);

            for (int i = 0; i < loaded.Width; i++)
            {
                for (int j = 0; j < loaded.Height; j++)
                {
                    Color pixel = loaded.GetPixel(i, j);

                    int invertedRed = 255 - pixel.R;
                    int invertedGreen = 255 - pixel.G;
                    int invertedBlue = 255 - pixel.B;

                    Color invertedColor = Color.FromArgb(invertedRed, invertedGreen, invertedBlue);
                    processed.SetPixel(i, j, invertedColor);
                }
            }
        }

        /// <summary>
        /// This method will change the color into sepia and 
        /// output it as processed image
        /// </summary>
        /// <param name="loaded"></param>
        /// <param name="processed"></param>
        public static void Sepia(ref Bitmap loaded, ref Bitmap processed)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);

            for (int i = 0; i < loaded.Width; i++)
            {
                for (int j = 0; j < loaded.Height; j++)
                {
                    Color pixel = loaded.GetPixel(i, j);

                    int sepiaRed = (int)((0.393 * pixel.R) + (0.769 * pixel.G) + (0.189 * pixel.B));
                    int sepiaGreen = (int)((0.349 * pixel.R) + (0.686 * pixel.G) + (0.168 * pixel.B));
                    int sepiaBlue = (int)((0.272 * pixel.R) + (0.534 * pixel.G) + (0.131 * pixel.B));

                    if(sepiaRed > 255)
                        sepiaRed = 255;
                    if(sepiaBlue > 255)
                        sepiaBlue = 255;
                    if(sepiaGreen > 255)
                        sepiaGreen = 255;

                    Color sepiaColor = Color.FromArgb(sepiaRed, sepiaGreen, sepiaBlue);
                    processed.SetPixel(i, j, sepiaColor);
                }
            }
        }

        /// <summary>
        /// This method will process the loaded image and output its graphical
        /// representation and the tonal distribution in a digital image
        /// </summary>
        /// <param name="loaded"></param>
        /// <param name="processed"></param>
        public static void Histogram(ref Bitmap loaded, ref Bitmap processed)
        {
            Color temp, greyColor;
            Byte grey;

            // GreyScale
            for (int i = 0; i < loaded.Width; i++)
            {
                for (int j = 0; j < loaded.Height; j++)
                {
                    temp = loaded.GetPixel(i, j);
                    grey = (byte)((temp.R + temp.G + temp.B) / 3);
                    greyColor = Color.FromArgb(grey, grey, grey);
                    loaded.SetPixel(i, j, greyColor);
                }
            }

            // Histogram 1D data
            int[] histogramData = new int[256];
            for (int i = 0; i < loaded.Width; i++)
            {
                for (int j = 0; j < loaded.Height; j++)
                {
                    temp = loaded.GetPixel(i, j);
                    histogramData[temp.R]++;
                }
            }

            // Setting empty bitmap with BG color
            processed = new Bitmap(256, 800);
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 800; j++)
                {
                    processed.SetPixel(i, j, Color.White);
                }
            }

            // Plot points 
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < Math.Min(histogramData[i] / 5, processed.Height - 1); j++)
                {
                    processed.SetPixel(i, (processed.Height - 1) - j, Color.Black);
                }
            }
        }

        /// <summary>
        /// This method will let you subtract the green in the loaded image and set it to
        /// the loaded background and output the result as processed imaged
        /// </summary>
        /// <param name="image"></param>
        /// <param name="background"></param>
        /// <param name="processed"></param>
        public static void Subtraction(ref Bitmap image, ref Bitmap background, ref Bitmap processed)
        {
            processed = new Bitmap(image.Width, image.Height);

            Color myGreen = Color.FromArgb(0, 0, 255);
            int greyGreen = (myGreen.R + myGreen.G + myGreen.B) / 3;
            int threshold = 5;

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color imagePixel = image.GetPixel(i, j);
                    Color backgroundPixel = background.GetPixel(i, j);

                    int grey = (imagePixel.R + imagePixel.G + imagePixel.B) / 3;
                    int subtractValue = Math.Abs(grey - greyGreen);

                    if (subtractValue > threshold)
                    {
                        processed.SetPixel(i, j, imagePixel);
                    }
                    else
                    {
                        processed.SetPixel(i, j, backgroundPixel);
                    }
                }
            }
        }
    }
}
