using System.Drawing;
using System;

namespace HideAndSeek
{
    public class Hide
    {

        /// <summary>
        /// Compress a value that was on 8 bits into a value on 'n' bits
        /// </summary>
        /// <param name="to_compress"> The value to compress</param>
        /// <param name="n"> On how many bits it must be compressed</param>
        /// <returns> The compressed value</returns>
        public static int CompressBits(int to_compress, int n) =>
            to_compress * Bits.GetMaxForNBits(n) / 255;
        
        /// <summary>
        /// Hides the image 'to_hide' which is supposed to be a grayscale in the color 'where_to_hide'
        /// of the image 'image'
        /// </summary>
        /// <param name="image"> The image where you have to hide the image</param>
        /// <param name="to_hide"> The image to hide</param>
        /// <param name="where_to_hide"> In which of composant R, G or B you want to hide it</param>
        /// <param name="n"> The number of bits you want to hide</param>
        public static void HideGrayScale(Bitmap image, Bitmap to_hide, color_type where_to_hide, int n)
        {
            int w = image.Width, h = image.Height;
            Color clearPixel = new Color(),pixelToHide = new Color();
            int[] clearCanals = new[] {0, 0, 0},canalsToHide = new[] {0, 0, 0};
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    //on recupere les pixels des deux images a la pos (i,j)
                    clearPixel = image.GetPixel(i, j);
                    pixelToHide = to_hide.GetPixel(i, j);
                    
                    //on cree deux tableaux afin d'acceder tout de suite a l'index represente par l'enum @param where_to_hide
                    clearCanals = new[] {(int)clearPixel.R, (int)clearPixel.G, (int)clearPixel.B};
                    canalsToHide = new[] {(int) pixelToHide.R, (int) pixelToHide.G, (int)pixelToHide.B};
                    Bits.ResetLeastSignificantBits(ref clearCanals[(int) where_to_hide], n);
                    clearCanals[(int) where_to_hide] += CompressBits(canalsToHide[(int) where_to_hide],n);
                    
                    //On inscrit le pixel avec le pixel cache dans image
                    image.SetPixel(i,j,Color.FromArgb(clearCanals[0],clearCanals[1],clearCanals[2]));
                }
            }
            
        }

        /// <summary>
        /// Hides the image 'to_hide' in the image 'image'
        /// Red color of 'to_hide' is hidden in Red color of image
        /// Green color of 'to_hide' is hidden in Green color of image
        /// And Blue color of 'to_hide' is hidden in Blue color of image
        /// </summary>
        /// <param name="image"> The image where you have to hide the image</param>
        /// <param name="to_hide"> The image to hide</param>
        /// <param name="n"> The number of bits you want to hide</param>
        public static void HideColor(Bitmap image, Bitmap to_hide, int n)
        {
            int w = image.Width, h = image.Height;
            Color clearPixel = new Color(),pixelToHide = new Color();
            int[] clearCanals = new[] {0, 0, 0},canalsToHide = new[] {0, 0, 0};
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    //on recupere les pixels des deux images a la pos (i,j)
                    clearPixel = image.GetPixel(i, j);
                    pixelToHide = to_hide.GetPixel(i, j);
                    
                    //on cree deux tableaux afin d'acceder tout de suite a l'index represente par l'enum @param where_to_hide
                    clearCanals = new[] {(int)clearPixel.R, (int)clearPixel.G, (int)clearPixel.B};
                    canalsToHide = new[] {(int) pixelToHide.R, (int) pixelToHide.G, (int)pixelToHide.B};
                    for (int k = 0; k < 3; k++)
                    {
                        Bits.ResetLeastSignificantBits(ref clearCanals[k], n);
                        clearCanals[k] += CompressBits(canalsToHide[k],n);
                    }
                    
                    //On inscrit le pixel avec le pixel cache dans image
                    image.SetPixel(i,j,Color.FromArgb(clearCanals[0],clearCanals[1],clearCanals[2]));
                }
            }
        }
    }
}
