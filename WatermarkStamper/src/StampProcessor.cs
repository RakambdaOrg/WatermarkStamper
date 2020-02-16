using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using NLog;

namespace WatermarkStamper
{
    public class StampProcessor
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private readonly MainForm _form;
        private readonly Stamper _stamper;

        public StampProcessor(MainForm form, Stamper stamper)
        {
            _form = form;
            _stamper = stamper;
        }

        public void Execute()
        {
            Logger.Info("Processing images of stamper {0}", _stamper);
            using var rawWatermarkImage = _stamper.WatermarkImage;
            if (rawWatermarkImage == null)
            {
                MessageBox.Show(@"No watermark file loaded", @"Invalid parameters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var watermarkImage = Utils.ResizeImage(rawWatermarkImage, _stamper.WatermarkWidth, _stamper.WatermarkHeight, _stamper.WatermarkOpacity);
            Logger.Info("Watermark file loaded and resized");
            _form.SetProgressbarValue(0);
            _form.SetProgressbarText("");

            var files = Directory.GetFiles(_stamper.InputFolder).ToArray();
            _form.SetMaxProgressbarValue(files.Length);
            Logger.Info("{0} files to process found", files.Length);

            var currentFile = 0;
            var skipped = 0;
            var errored = 0;

            foreach (var file in files)
            {
                currentFile++;
                Logger.Info("Processing file {0}", file);
                _form.SetProgressbarText($"Processing {file} ({currentFile}/{file.Length})");
                try
                {
                    var outputFile = Path.Combine(_stamper.OutputFolder, Path.GetFileName(file));
                    if (File.Exists(outputFile))
                    {
                        skipped++;
                    }
                    else
                    {
                        using var inputImage = Image.FromFile(file);
                        var watermarkedImage = new Bitmap(inputImage.Width, inputImage.Height, inputImage.PixelFormat);
                        foreach (var id in inputImage.PropertyIdList)
                        {
                            watermarkedImage.SetPropertyItem(inputImage.GetPropertyItem(id));
                        }
                        watermarkedImage.SetResolution(inputImage.HorizontalResolution, inputImage.VerticalResolution);
                        var graphics = Graphics.FromImage(watermarkedImage);

                        graphics.DrawImage(inputImage, 0, 0);

                        int x;
                        int y;
                        switch (_stamper.WatermarkPosition)
                        {
                            case WatermarkPosition.TopLeft:
                                x = _stamper.Padding;
                                y = _stamper.Padding;
                                break;
                            case WatermarkPosition.TopRight:
                                x = inputImage.Width - watermarkImage.Width - _stamper.Padding;
                                y = _stamper.Padding;
                                break;
                            case WatermarkPosition.BottomLeft:
                                x = _stamper.Padding;
                                y = inputImage.Height - watermarkImage.Height - _stamper.Padding;
                                break;
                            case WatermarkPosition.BottomRight:
                                x = inputImage.Width - watermarkImage.Width - _stamper.Padding;
                                y = inputImage.Height - watermarkImage.Height - _stamper.Padding;
                                break;
                            default:
                            // ReSharper disable once RedundantCaseLabel
                            case WatermarkPosition.Center:
                                x = inputImage.Width / 2 - watermarkImage.Width / 2;
                                y = inputImage.Height / 2 - watermarkImage.Height / 2;
                                break;
                        }

                        watermarkImage.SetResolution(inputImage.HorizontalResolution, inputImage.VerticalResolution);
                        graphics.DrawImageUnscaled(watermarkImage, x, y, watermarkImage.Width, watermarkImage.Height);

                        watermarkedImage.Save(outputFile);
                    }
                }
                catch (Exception ex)
                {
                    errored++;
                    Logger.Error(ex, "Failed to process file {0}", file);
                }

                _form.IncrementProgressbarValue();
            }

            _form.SetProgressbarText($"Done with {skipped} skipped and {errored} errors");
            Logger.Info("Files processed");
        }
    }
}