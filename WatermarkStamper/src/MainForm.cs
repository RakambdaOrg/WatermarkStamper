using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using NLog;

namespace WatermarkStamper
{
    public partial class MainForm : Form
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private Stamper _stamper;

        public MainForm()
        {
            InitializeComponent();
        }

        private void SelectInputFolderClick(object sender, EventArgs e)
        {
            var result = Utils.AskFolder();
            if (result != null)
            {
                SetInputFolder(result);
            }
        }

        private void SelectWatermarkFileClick(object sender, EventArgs e)
        {
            var result = Utils.AskFile(null);
            if (result != null)
            {
                SetWatermarkFilePath(result);
            }
        }

        private void SelectOutputFolderClick(object sender, EventArgs e)
        {
            var result = Utils.AskFolder();
            if (result != null)
            {
                SetOutputFolder(result);
            }
        }

        private void StartButtonClick(object sender, EventArgs e)
        {
            if (positionComboBox.SelectedValue.ToString().Length <= 0)
                return;

            startButton.Enabled = false;
            selectedInputFolderText.Enabled = false;
            selectedOutputFolderText.Enabled = false;
            selectedWatermarkText.Enabled = false;

            var thread = new Thread(() =>
            {
                try
                {
                    new StampProcessor(this, _stamper).Execute();
                }
                catch (Exception ex)
                {
                    Logger.Error(ex, "Error duting stamping");
                    MessageBox.Show(ex.ToString());
                }

                startButton.Enabled = true;
                selectedInputFolderText.Enabled = true;
                selectedOutputFolderText.Enabled = true;
                selectedWatermarkText.Enabled = true;
            }) {IsBackground = true};
            thread.Start();
        }

        private void WatermarkPositionSelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse<WatermarkPosition>(positionComboBox.SelectedValue.ToString(), out var watermarkPosition);
            if(_stamper != null)
            {
                _stamper.WatermarkPosition = watermarkPosition;
            }
        }

        private void PaddingValueChanged(object sender, EventArgs e)
        {
            _stamper.Padding = (int) paddingUpDown.Value;
        }

        private void WatermarkWidthValueChanged(object sender, EventArgs e)
        {
            _stamper.WatermarkWidth = (int) watermarkWidthUpDown.Value;
        }

        private void WatermarkHeightValueChanged(object sender, EventArgs e)
        {
            _stamper.WatermarkHeight = (int) watermarkHeightUpDown.Value;
        }

        private void WatermarkOpacityValueChanged(object sender, EventArgs e)
        {
            _stamper.WatermarkOpacity = (float) watermarkOpacityUpDown.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            positionComboBox.DataSource = Enum.GetValues(typeof(WatermarkPosition));
            progressBar.DisplayStyle = ProgressBarDisplayText.CustomText;
            SetStamper(new Stamper());
        }

        private void LoadPresetClick(object sender, EventArgs e)
        {
            var result = Utils.AskFile(@"JSON files (*.json)|*.json");
            if (result != null)
            {
                try
                {
                    var json = File.ReadAllText(result);
                    var stamper = JsonConvert.DeserializeObject<Stamper>(json, new JsonSerializerSettings {NullValueHandling = NullValueHandling.Ignore});
                    SetStamper(stamper);
                    
                }
                catch (Exception ex)
                {
                    Logger.Error(ex, "Failed to load preset from {0}", result);
                    MessageBox.Show(@"Failed to load preset file.\n" + ex, @"Invalid parameters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SetStamper(Stamper stamper)
        {
            _stamper = stamper;
            selectedInputFolderText.Text = _stamper.InputFolder != null ? _stamper.InputFolder : "Select folder";
            selectedOutputFolderText.Text = _stamper.OutputFolder != null ? _stamper.OutputFolder : "Select file";
            selectedWatermarkText.Text = _stamper.WatermarkFilePath != null ? _stamper.WatermarkFilePath : "Select folder";
            positionComboBox.SelectedIndex = (int) _stamper.WatermarkPosition;
            paddingUpDown.Value = _stamper.Padding;
            watermarkWidthUpDown.Maximum = _stamper.MaxWatermarkWidth;
            watermarkHeightUpDown.Maximum = _stamper.MaxWatermarkHeight;
            watermarkWidthUpDown.Value = _stamper.WatermarkWidth;
            watermarkHeightUpDown.Value = _stamper.WatermarkHeight;
            watermarkOpacityUpDown.Value = (decimal) _stamper.WatermarkOpacity;
        }

        private void SavePresetClick(object sender, EventArgs e)
        {
            var result = Utils.AskSaveFile(@"JSON files (*.json)|*.json");
            if (result != null)
            {
                var serializer = new JsonSerializer {NullValueHandling = NullValueHandling.Ignore};
                using var sw = new StreamWriter(result);
                using JsonWriter writer = new JsonTextWriter(sw);
                serializer.Serialize(writer, _stamper);
                MessageBox.Show(@"Perset saved", @"Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateStartButton()
        {
            startButton.Enabled = _stamper.IsValidState();
        }

        private void SetInputFolder(string inputFolder)
        {
            _stamper.InputFolder = inputFolder;
            selectedInputFolderText.Text = inputFolder;
            UpdateStartButton();
        }

        private void SetOutputFolder(string outputFolder)
        {
            _stamper.OutputFolder = outputFolder;
            selectedOutputFolderText.Text = outputFolder;
            UpdateStartButton();
        }

        private void SetWatermarkFilePath(string watermarkFilePath)
        {
            try
            {
                _stamper.WatermarkFilePath = watermarkFilePath;
                selectedWatermarkText.Text = watermarkFilePath;
                watermarkHeightUpDown.Maximum = _stamper.MaxWatermarkHeight;
                watermarkWidthUpDown.Maximum = _stamper.MaxWatermarkWidth;
                watermarkHeightUpDown.Value = _stamper.WatermarkHeight;
                watermarkWidthUpDown.Value = _stamper.WatermarkWidth;
                UpdateStartButton();
            }
            catch (Exception e)
            {
                Logger.Error(e, "Failed to load wwatermark from {0}", watermarkFilePath);
                MessageBox.Show(@"Failed to load watermark file", @"Invalid parameters", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void IncrementProgressbarValue()
        {
            if (progressBar.InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate { progressBar.Value++; }));
            }
            else
            {
                progressBar.Value++;
            }
        }

        public void SetMaxProgressbarValue(int max)
        {
            if (progressBar.InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate { progressBar.Maximum = max; }));
            }
            else
            {
                progressBar.Maximum = max;
            }
        }

        public void SetProgressbarValue(int value)
        {
            if (progressBar.InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate { progressBar.Value = value; }));
            }
            else
            {
                progressBar.Value = value;
            }
        }

        public void SetProgressbarText(string value)
        {
            if (progressBar.InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate { progressBar.CustomText = value; }));
            }
            else
            {
                progressBar.Text = value;
            }
        }
    }
}