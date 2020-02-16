using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using NLog;

namespace WatermarkStamper
{
    public class Utils
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public static string AskFolder()
        {
            var folderBrowser = new OpenFileDialog {ValidateNames = false, CheckFileExists = false, CheckPathExists = true, FileName = "Folder Selection."};
            var result = folderBrowser.ShowDialog();
            if (result != DialogResult.OK || string.IsNullOrWhiteSpace(folderBrowser.FileName)) return null;
            return Path.GetDirectoryName(folderBrowser.FileName);
        }

        public static string AskFile(string filter)
        {
            using var openFileDialog = new OpenFileDialog();
            if (filter != null)
            {
                openFileDialog.Filter = filter;
            }
            var result = openFileDialog.ShowDialog();
            if (result != DialogResult.OK || string.IsNullOrWhiteSpace(openFileDialog.FileName)) return null;
            return openFileDialog.FileName;
        }

        public static string AskSaveFile(string filter)
        {
            using var openFileDialog = new SaveFileDialog();
            if(filter != null)
            {
                openFileDialog.Filter = filter;
            }
            var result = openFileDialog.ShowDialog();
            if (result != DialogResult.OK || string.IsNullOrWhiteSpace(openFileDialog.FileName)) return null;
            return openFileDialog.FileName;
        }

        public static Bitmap ResizeImage(Image image, int width, int height, float opacity)
        {
            width = width == 0 ? image.Width : width;
            height = height == 0 ? image.Height : height;
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                var matrix = new ColorMatrix {Matrix33 = opacity};
                using var attributes = new ImageAttributes();
                attributes.SetWrapMode(WrapMode.TileFlipXY);
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
            }

            return destImage;
        }
    }
}