using System;
using System.Drawing;

namespace HideAndSeek
{
    class Program
    {
        static int Main(string[] args)
        {
            ///Tests for Seek
            /*Bitmap hidden_b_and_w = new Bitmap("../../../../ref_hidden_b_and_w.png"); 
            Bitmap hidden_R = Seek.SeekGrayScale(hidden_b_and_w, color_type.R, 1); 
            Bitmap hidden_G = Seek.SeekGrayScale(hidden_b_and_w, color_type.G, 1); 
            Bitmap hidden_B = Seek.SeekGrayScale(hidden_b_and_w, color_type.B, 1); 
            hidden_R.Save("../../../../relic_R.png", System.Drawing.Imaging.ImageFormat.Png);
            hidden_G.Save("../../../../relic_G.png", System.Drawing.Imaging.ImageFormat.Png); 
            hidden_B.Save("../../../../relic_B.png", System.Drawing.Imaging.ImageFormat.Png);
            

            
            Bitmap hidden_grayscale = new Bitmap("../../../../ref_hidden_grayscale.png"); 
            hidden_R = Seek.SeekGrayScale(hidden_grayscale, color_type.R, 4); 
            hidden_G = Seek.SeekGrayScale(hidden_grayscale, color_type.G, 4); 
            hidden_B = Seek.SeekGrayScale(hidden_grayscale, color_type.B, 4); 
            hidden_R.Save("../../../../character_R.png", System.Drawing.Imaging.ImageFormat.Png); 
            hidden_G.Save("../../../../character_G.png", System.Drawing.Imaging.ImageFormat.Png); 
            hidden_B.Save("../../../../character_B.png", System.Drawing.Imaging.ImageFormat.Png);

            
            Bitmap hidden_p_stone = new Bitmap("../../../../hidden_stone.png"); 
            Bitmap hidden_stone = Seek.SeekColor(hidden_p_stone, 6); 
            hidden_stone.Save("../../../../found_stone.png", System.Drawing.Imaging.ImageFormat.Png);

            
            Bitmap hidden_color = new Bitmap("../../../../ref_hidden_quidditch.png"); 
            Bitmap hidden_quiditch = Seek.SeekColor(hidden_color, 4);
            hidden_quiditch.Save("../../../../found_quidditch.png", System.Drawing.Imaging.ImageFormat.Png);




            /// Tests for Hide
            Bitmap image = new Bitmap("../../../../harry_potter.png"); 
            Bitmap save = new Bitmap(image); 
            Bitmap first_relic = new Bitmap("../../../../first_relic.png"); 
            Bitmap second_relic = new Bitmap("../../../../second_relic.png"); 
            Bitmap third_relic = new Bitmap("../../../../third_relic.png"); 
            Hide.HideGrayScale(image, first_relic, color_type.R, 5); 
            Hide.HideGrayScale(image, second_relic, color_type.G, 5); 
            Hide.HideGrayScale(image, third_relic, color_type.B, 5); 
            image.Save("../../../../hidden_b_and_w.png", System.Drawing.Imaging.ImageFormat.Png);


            
            Bitmap Voldemort = new Bitmap("../../../../Voldemort.png"); 
            Bitmap Draco_Malfoy = new Bitmap("../../../../Draco_Malfoy.png"); 
            Bitmap Dolores_Ombrage = new Bitmap("../../../../Dolores_Umbridge.png"); 
            image = new Bitmap(save); 
            Hide.HideGrayScale(image, Voldemort, color_type.R, 6); 
            Hide.HideGrayScale(image, Draco_Malfoy, color_type.G, 6); 
            Hide.HideGrayScale(image, Dolores_Ombrage, color_type.B, 6); 
            image.Save("../../../../hidden_grayscale.png", System.Drawing.Imaging.ImageFormat.Png);

            
            Bitmap philosophers_stone = new Bitmap("../../../../philosophers_stone.png"); 
            image = new Bitmap(save); 
            Hide.HideColor(image, philosophers_stone, 6); 
            image.Save("../../../../hidden_stone.png", System.Drawing.Imaging.ImageFormat.Png);

            
            Bitmap quiditch = new Bitmap("../../../../quidditch.png"); 
            image = new Bitmap(save); 
            Hide.HideColor(image, quiditch, 6); 
            image.Save("../../../../hidden_quidditch.png", System.Drawing.Imaging.ImageFormat.Png);*/

            
            
            return 0;
        }
    }
}
