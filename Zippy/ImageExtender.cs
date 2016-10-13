/*-----------------------------------------------------
 * 此类用来扩展 System.Drawing.Image，为 Image 增加方法。
 * 
 * 
 * Author：啤酒云 
 * 
 * 
 -------------------------------------------------------*/

namespace System.Drawing
{
    using System;
    using System.Drawing.Drawing2D;
    using System.Drawing.Imaging;

    public static class ImageExtender
    {

        public static Image Resize(this Image img, int width, int height)
        {
            Bitmap newImage = new Bitmap(width, height);
            using (Graphics gr = Graphics.FromImage(newImage))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                gr.DrawImage(img, new Rectangle(0, 0, width, height));
                return newImage;
            }
        }
        public static Image Resize(this Image img, int scaleLength, ScaleModes sMode)
        {
            int xwidth = img.Width;
            int xheight = img.Height;

            if (xwidth <= scaleLength && xheight <= scaleLength)
            {
                return img;
            }

            //图片缩小后的尺寸，画布尺寸
            int lWidht = 0, lHeight = 0;

            switch (sMode)
            {
                case ScaleModes.Both:
                    if (xwidth > xheight)
                    {
                        lWidht = scaleLength;
                        lHeight = (xheight * scaleLength) / xwidth;
                    }
                    else
                    {
                        lWidht = (xwidth * scaleLength) / xheight;
                        lHeight = scaleLength;
                    }
                    break;
                case ScaleModes.Height:
                    lWidht = (xwidth * scaleLength) / xheight;
                    lHeight = scaleLength;
                    break;
                case ScaleModes.Width:
                    lWidht = scaleLength;
                    lHeight = (xheight * scaleLength) / xwidth;
                    break;
                case ScaleModes.Squre:
                    lWidht = scaleLength;
                    lHeight = scaleLength;
                    break;
            }
            return img.Resize(lWidht, lHeight);
        }
        /// <summary>
        /// 裁切图片
        /// </summary>
        /// <param name="img"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        /// <returns></returns>
        public static Image Crop(this Image img, int x, int y, int w, int h)
        {

            PixelFormat Format = img.PixelFormat;
            if (Format.ToString().Contains("Indexed"))
                Format = PixelFormat.Format24bppRgb;


            Bitmap newMap = new Bitmap(w, h, Format);
            Graphics g = Graphics.FromImage(newMap);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.DrawImage(img, new PointF(-x, -y));
            g.Dispose();
            img.Dispose();
            return newMap;
        }

        /// <summary>
        /// 缩放图片
        /// </summary>
        /// <param name="img"></param>
        /// <param name="scaleLength"></param>
        /// <param name="sMode"></param>
        /// <returns></returns>
        public static Image Scale(this Image img, int scaleLength, ScaleModes sMode)
        {
            int xwidth = img.Width;
            int xheight = img.Height;

            if (xwidth <= scaleLength && xheight <= scaleLength)
            {
                return img;
            }

            //图片缩小后的尺寸，画布尺寸
            int lWidht = 0, lHeight = 0;

            switch (sMode)
            {
                case ScaleModes.Both:
                    if (xwidth > xheight)
                    {
                        lWidht = scaleLength;
                        lHeight = (xheight * scaleLength) / xwidth;
                    }
                    else
                    {
                        lWidht = (xwidth * scaleLength) / xheight;
                        lHeight = scaleLength;
                    }
                    break;
                case ScaleModes.Height:
                    lWidht = (xwidth * scaleLength) / xheight;
                    lHeight = scaleLength;
                    break;
                case ScaleModes.Width:
                    lWidht = scaleLength;
                    lHeight = (xheight * scaleLength) / xwidth;
                    break;
                case ScaleModes.Squre:
                    lWidht = scaleLength;
                    lHeight = scaleLength;
                    break;
            }

            PixelFormat Format = img.PixelFormat;
            if (Format.ToString().Contains("Indexed"))
                Format = PixelFormat.Format24bppRgb;

            using (Bitmap newMap = new Bitmap(lWidht, lHeight, Format))
            {

                using (Graphics g = Graphics.FromImage(newMap))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    if (sMode == ScaleModes.Squre)
                    {
                        if (xwidth > xheight)
                        {
                            //g.DrawImage(img, new Rectangle(0, 0, 75, 75),                     
                            g.DrawImage(img, new RectangleF(0f, 0f, (float)lWidht, (float)lHeight), new RectangleF((float)((xwidth - xheight) / 2), 0f, (float)xheight, (float)xheight), GraphicsUnit.Pixel);
                        }
                        else
                        {
                            g.DrawImage(img, new RectangleF(0f, 0f, (float)lWidht, (float)lHeight), new RectangleF(0f, (float)((xheight - xwidth) / 2), (float)xwidth, (float)xwidth), GraphicsUnit.Pixel);
                        }
                    }
                    else
                    {
                        g.DrawImage(img, new RectangleF(0f, 0f, (float)lWidht, (float)lHeight), new RectangleF(0f, 0f, (float)xwidth, (float)xheight), GraphicsUnit.Pixel);
                    }
                    return newMap;
                }
            }
        }

        /// <summary>
        /// 缩放图片
        /// </summary>
        /// <param name="img">The img.</param>
        /// <param name="savePath">The save path.</param>
        /// <param name="scaleLength">Length of the scale.</param>
        /// <param name="sMode">The s mode.</param>
        /// <param name="encoder">The encoder.</param>


        /// <summary>
        /// 缩放图片
        /// </summary>
        /// <param name="img">The img.</param>
        /// <param name="savePath">The save path.</param>
        /// <param name="scaleLength">Length of the scale.</param>
        /// <param name="sMode">The s mode.</param>
        public static void Scale(this Image img, string savePath, int scaleLength, ScaleModes sMode)
        {
            Image newMap = img.Scale(scaleLength, sMode);
            //throw new Exception(img.RawFormat.ToString());
            newMap.Save(savePath, img.RawFormat);
            newMap.Dispose();
        }

        /// <summary>
        /// 缩放图片，不够的地方填（白？）色
        /// </summary>
        /// <param name="img">The img.</param>
        /// <param name="savePath">The save path.</param>
        /// <param name="size">The size.</param>
        public static void Scale(this Image img, string savePath, System.Drawing.Size size)
        {

            float xheight = (float)img.Height;
            float xwidth = (float)img.Width;

            if ((float)size.Height < xheight || (float)size.Width < xwidth)
            {
                if ((float)img.Width / (float)img.Height > (float)size.Width / (float)size.Height)
                {
                    xheight = ((float)size.Width / (float)img.Width) * (float)img.Height;
                    xwidth = (float)size.Width;
                }
                else
                {
                    xheight = (float)size.Height;
                    xwidth = ((float)size.Height / (float)img.Height) * img.Width;
                }
            }

            float canvasX = ((float)size.Width - xwidth) / 2;
            float canvasY = ((float)size.Height - xheight) / 2;

            //Graphics objects can not be created from bitmaps with an Indexed Pixel Format, use RGB instead.
            PixelFormat Format = img.PixelFormat;
            if (Format.ToString().Contains("Indexed"))
                Format = PixelFormat.Format24bppRgb;

            using (Bitmap newMap = new Bitmap(size.Width, size.Height, Format))
            {
                using (Graphics g = Graphics.FromImage(newMap))
                {
                    //g.FillRectangle(new SolidBrush(Color.White), new Rectangle(new Point(0, 0), size));
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                    //g.DrawImage(img, new RectangleF(new Point(0, 0), new SizeF(canvasX, canvasY)));


                    g.DrawImage(img, new RectangleF(canvasX, canvasY, xwidth, xheight), new RectangleF(0f, 0f, (float)img.Width, (float)img.Height), GraphicsUnit.Pixel);
                    newMap.Save(savePath, img.RawFormat);
                }
            }

        }
        public static Image Scale(this Image img, System.Drawing.Size size)
        {

            float xheight = (float)img.Height;
            float xwidth = (float)img.Width;

            if ((float)size.Height < xheight || (float)size.Width < xwidth)
            {
                if ((float)img.Width / (float)img.Height > (float)size.Width / (float)size.Height)
                {
                    xheight = ((float)size.Width / (float)img.Width) * (float)img.Height;
                    xwidth = (float)size.Width;
                }
                else
                {
                    xheight = (float)size.Height;
                    xwidth = ((float)size.Height / (float)img.Height) * img.Width;
                }
            }

            float canvasX = ((float)size.Width - xwidth) / 2;
            float canvasY = ((float)size.Height - xheight) / 2;


            //Graphics objects can not be created from bitmaps with an Indexed Pixel Format, use RGB instead.
            PixelFormat Format = img.PixelFormat;
            if (Format.ToString().Contains("Indexed"))
                Format = PixelFormat.Format24bppRgb;

            Bitmap newMap = new Bitmap(size.Width, size.Height, img.PixelFormat);

            using (Graphics g = Graphics.FromImage(newMap))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.DrawImage(img, new RectangleF(canvasX, canvasY, xwidth, xheight), new RectangleF(0f, 0f, (float)img.Width, (float)img.Height), GraphicsUnit.Pixel);

            }


            return newMap;

        }

        public static void DistortImage(this Bitmap b, double distortion)
        {
            int width = b.Width, height = b.Height;

            // Copy the image so that we're always using the original for source color
            using (Bitmap copy = (Bitmap)b.Clone())
            {
                // Iterate over every pixel
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        // Adds a simple wave
                        int newX = (int)(x + (distortion * Math.Sin(Math.PI * y / 64.0)));
                        int newY = (int)(y + (distortion * Math.Cos(Math.PI * x / 64.0)));
                        //while (newX < 0 || newX >= width || newY < 0 || newY >= height)
                        //{
                        //    if (newX < 0) newX = width + newX; else if (newX >= width) newX = newX - width;
                        //    if (newY < 0) newY = height + newY; else if (newY >= height) newY = newY - height;
                        //}
                        if (newX < 0 || newX >= width) newX = 2;
                        if (newY < 0 || newY >= height) newY = 2;
                        b.SetPixel(x, y, copy.GetPixel(newX, newY));
                    }
                }
            }
        }

    }


    /*
    #region 辅助类和枚举

    /// <summary>
    /// 图片压缩信息
    /// </summary>
    public class ImageEncoderInfo
    {
        /// <summary>
        /// 默认构建器
        /// </summary>
        public ImageEncoderInfo()
        {
        }
        /// <summary>
        /// 参数构造器
        /// </summary>
        /// <param name="Quality">图片质量</param>
        /// <param name="ColorDepth">颜色深度</param>
        public ImageEncoderInfo(long Quality, long ColorDepth)
        {
            myImageCodecInfo = GetEncoderInfo("image/jpeg");

            //图片质量
            Encoder myEncoder;
            EncoderParameter myEncoderParameter;
            myEncoder = Encoder.Quality;
            myEncoderParameter = new EncoderParameter(myEncoder, Quality);

            //颜色深度
            Encoder myEncoderColor;
            EncoderParameter myEncoderParameterColor;
            myEncoderColor = Encoder.ColorDepth;
            myEncoderParameterColor = new EncoderParameter(myEncoderColor, ColorDepth);

            //压缩方式
            Encoder myEncoderComp;
            EncoderParameter myEncoderParameterComp;
            myEncoderComp = Encoder.Compression;
            myEncoderParameterComp = new EncoderParameter(myEncoderComp, (long)EncoderValue.CompressionLZW);

            myEncoderParameters = new EncoderParameters(3);
            myEncoderParameters.Param[0] = myEncoderParameter;
            myEncoderParameters.Param[1] = myEncoderParameterColor;
            myEncoderParameters.Param[2] = myEncoderParameterComp;

        }
        /// <summary>
        /// 
        /// </summary>
        private System.Drawing.Imaging.EncoderParameters myEncoderParameters;

        /// <summary>
        /// Gets or sets the encoder parameters.
        /// </summary>
        /// <value>The encoder parameters.</value>
        public System.Drawing.Imaging.EncoderParameters EncoderParameters
        {
            get { return myEncoderParameters; }
            set { myEncoderParameters = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        private System.Drawing.Imaging.ImageCodecInfo myImageCodecInfo;

        /// <summary>
        /// Gets or sets the image codec info.
        /// </summary>
        /// <value>The image codec info.</value>
        public System.Drawing.Imaging.ImageCodecInfo ImageCodecInfo
        {
            get { return myImageCodecInfo; }
            set { myImageCodecInfo = value; }
        }



        //获取图片的信息
        /// <summary>
        /// Gets the encoder info.
        /// </summary>
        /// <param name="mimeType">Type of the MIME.</param>
        /// <returns></returns>
        private ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }
    }
    /// <summary>
    /// 缩放参数
    /// </summary>
    public class ScaleImageParameter
    {
        public int ScaleLength;
        public ScaleModes ScaleMode;
        public string FileNameSuffix;
    }
    #endregion
    */
    /// <summary>
    /// 缩放方式
    /// </summary>
    public enum ScaleModes
    {
        /// <summary>
        /// 
        /// </summary>
        Both = 1,
        /// <summary>
        /// 
        /// </summary>
        Width = 2,
        /// <summary>
        /// 
        /// </summary>
        Height = 4,
        /// <summary>
        /// 
        /// </summary>
        Squre = 8
    }
}
