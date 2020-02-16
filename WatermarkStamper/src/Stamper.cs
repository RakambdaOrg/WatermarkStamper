using System;
using System.Drawing;
using Newtonsoft.Json;

namespace WatermarkStamper
{
    public class Stamper
    {
        [JsonIgnore]
        private string _watermarkFilePath;
        [JsonProperty("watermarkWidth")] private int _watermarkWidth;
        [JsonProperty("watermarkHeight")] private int _watermarkHeight;
        [JsonIgnore]  private float _watermarkOpacity;

        [JsonProperty("watermarkOpacity")]
        public float WatermarkOpacity
        {
            get => _watermarkOpacity;
            set => _watermarkOpacity = Math.Min(1, Math.Max(0, value));
        }

        [JsonProperty("inputFolder")] public string InputFolder { get; set; }
        [JsonProperty("outputFolder")] public string OutputFolder { get; set; }

        [JsonProperty("watermarkFilePath")]
        public string WatermarkFilePath
        {
            get => _watermarkFilePath;
            set
            {
                WatermarkImage = Image.FromFile(value);
                _watermarkFilePath = value;
                MaxWatermarkWidth = WatermarkImage.Width;
                MaxWatermarkHeight = WatermarkImage.Height;
                WatermarkWidth = MaxWatermarkWidth;
                WatermarkHeight = MaxWatermarkHeight;
            }
        }

        [JsonIgnore]
        public int MaxWatermarkHeight { get; private set; }

        [JsonIgnore]
        public int MaxWatermarkWidth { get; private set; }

        [JsonIgnore]
        public Image WatermarkImage { get; private set; }

        [JsonIgnore]
        public int WatermarkWidth
        {
            get => _watermarkWidth;
            set => _watermarkWidth = Math.Min(MaxWatermarkWidth, Math.Max(0, value));
        }

        [JsonIgnore]
        public int WatermarkHeight
        {
            get => _watermarkHeight;
            set => _watermarkHeight = Math.Min(MaxWatermarkHeight, Math.Max(0, value));
        }

        [JsonProperty("padding")] public int Padding { get; set; }

        [JsonProperty("position")] public WatermarkPosition WatermarkPosition { get; set; }

        public Stamper()
        {
            _watermarkHeight = 0;
            _watermarkWidth = 0;
            _watermarkOpacity = 1;
            WatermarkPosition = WatermarkPosition.BottomRight;
        }

        public bool IsValidState()
        {
            return InputFolder != null && OutputFolder != null && WatermarkImage != null;
        }
    }
}