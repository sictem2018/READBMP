Bitmap bmp = new Bitmap(pictureBox3.Image);
            int width = bmp.Width;
            int height = bmp.Height;
            //
            int[,] FingIma = new int[width, height];
            Color c;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    c = bmp.GetPixel(x, y);
                    FingIma[x, y] = System.Convert.ToInt32(c.R * 0.299 + c.G * 0.587 + c.B * 0.114);
                    //FingIma[x, y] = (c.R + c.G + c.B) / 3;
                }
            }
