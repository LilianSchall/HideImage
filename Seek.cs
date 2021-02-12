using System;
using System.Drawing;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace HideAndSeek
{
    public enum color_type
    {
        R = 0,
        G,
        B,
    }
    public class Seek
    {

        /// <summary>
        /// Decompress a value that was on 'n' bits to a value on 8 bits
        /// </summary>
        /// <param name="to_decompress"> The value to decompress</param>
        /// <param name="n"> On how many bits it has been compressed</param>
        /// <returns> The decompressed value</returns>
        public static int DecompressBits(int to_decompress, int n) =>
            to_decompress * 255 / Bits.GetMaxForNBits(n);

        /// <summary>
        /// Seek a new image in the Bitmap image and in the color 'where_is_hidden' on 'n' bits
        /// </summary>
        /// <param name="image"> The image where it is hidden</param>
        /// <param name="where_is_hidden"> In which color it is hidden</param>
        /// <param name="n"> On how many bits it is hidden</param>
        /// <returns> The image found</returns>
        public static Bitmap SeekGrayScale(Bitmap image, color_type where_is_hidden, int n)
        {
            int w = image.Width, h = image.Height;
            Bitmap NewImage = new Bitmap(w, h);
            Color pixel = new Color();
            int[] canals = new[] {0, 0, 0};
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    //on cree un tableau afin d'acceder tout de suite a l'index represente par l'enum @param where_is_hidden
                    pixel = image.GetPixel(i, j);
                    canals = new[] {(int)pixel.R, (int)pixel.G, (int)pixel.B};
                    canals[(int) where_is_hidden] = DecompressBits(Bits.GetLeastSignificantBits(canals[(int) where_is_hidden],n), n);
                    NewImage.SetPixel(i,j,Color.FromArgb(canals[(int) where_is_hidden],canals[(int) where_is_hidden],canals[(int) where_is_hidden]));
                }
            }

            return NewImage;
        }

        /// <summary>
        /// Seek a new image in the Bitmap image on 'n' bits
        /// </summary>
        /// <param name="image"> The image where it is hidden</param>
        /// <param name="n"> On how many bits it is hidden</param>
        /// <returns> The image found</returns>
        public static Bitmap SeekColor(Bitmap image, int n)
        {
            int w = image.Width, h = image.Height;
            Bitmap NewImage = new Bitmap(w, h);
            Color pixel = new Color();
            int[] canals = new[] {0, 0, 0};
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    //on cree un tableau afin d'acceder tout de suite a l'index represente par l'enum @param where_is_hidden
                    pixel = image.GetPixel(i, j);
                    canals = new[] {(int)pixel.R, (int)pixel.G, (int)pixel.B};
                    for (int k = 0; k < 3; k++)
                        canals[k] = DecompressBits(Bits.GetLeastSignificantBits(canals[k],n), n);
                    NewImage.SetPixel(i,j,Color.FromArgb(canals[0],canals[1],canals[2]));
                }
            }

            return NewImage;
        }
    }
}
