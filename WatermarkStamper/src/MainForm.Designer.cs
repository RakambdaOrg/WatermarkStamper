namespace WatermarkStamper
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.inputFolderLabel = new System.Windows.Forms.Label();
            this.watermarkImageLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.progressBar = new WatermarkStamper.TextProgressBar();
            this.outputFolderLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.paddingLabel = new System.Windows.Forms.Label();
            this.paddingUpDown = new System.Windows.Forms.NumericUpDown();
            this.positionComboBox = new System.Windows.Forms.ComboBox();
            this.selectedInputFolderText = new System.Windows.Forms.TextBox();
            this.selectedWatermarkText = new System.Windows.Forms.TextBox();
            this.selectedOutputFolderText = new System.Windows.Forms.TextBox();
            this.watermarkWidthLabel = new System.Windows.Forms.Label();
            this.watermarkHeightLabel = new System.Windows.Forms.Label();
            this.watermarkWidthUpDown = new System.Windows.Forms.NumericUpDown();
            this.watermarkHeightUpDown = new System.Windows.Forms.NumericUpDown();
            this.watermarkOpacityLabel = new System.Windows.Forms.Label();
            this.watermarkOpacityUpDown = new System.Windows.Forms.NumericUpDown();
            this.loadPresetButton = new System.Windows.Forms.Button();
            this.savePresetButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.paddingUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.watermarkWidthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.watermarkHeightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.watermarkOpacityUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 737F));
            this.tableLayoutPanel1.Controls.Add(this.inputFolderLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.watermarkImageLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.startButton, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.progressBar, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.outputFolderLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.positionLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.paddingLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.paddingUpDown, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.positionComboBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.selectedInputFolderText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.selectedWatermarkText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.selectedOutputFolderText, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.watermarkWidthLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.watermarkHeightLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.watermarkWidthUpDown, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.watermarkHeightUpDown, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.watermarkOpacityLabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.watermarkOpacityUpDown, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.loadPresetButton, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.savePresetButton, 1, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(887, 342);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // inputFolderLabel
            // 
            this.inputFolderLabel.AutoSize = true;
            this.inputFolderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputFolderLabel.Location = new System.Drawing.Point(3, 0);
            this.inputFolderLabel.Name = "inputFolderLabel";
            this.inputFolderLabel.Size = new System.Drawing.Size(144, 30);
            this.inputFolderLabel.TabIndex = 0;
            this.inputFolderLabel.Text = "Input folder";
            this.inputFolderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // watermarkImageLabel
            // 
            this.watermarkImageLabel.AutoSize = true;
            this.watermarkImageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.watermarkImageLabel.Location = new System.Drawing.Point(3, 30);
            this.watermarkImageLabel.Name = "watermarkImageLabel";
            this.watermarkImageLabel.Size = new System.Drawing.Size(144, 30);
            this.watermarkImageLabel.TabIndex = 1;
            this.watermarkImageLabel.Text = "Watermark image";
            this.watermarkImageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.startButton, 2);
            this.startButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(3, 273);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(881, 24);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButtonClick);
            // 
            // progressBar
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.progressBar, 2);
            this.progressBar.CustomText = null;
            this.progressBar.DisplayStyle = WatermarkStamper.ProgressBarDisplayText.Percentage;
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(3, 303);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(881, 36);
            this.progressBar.TabIndex = 5;
            // 
            // outputFolderLabel
            // 
            this.outputFolderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputFolderLabel.Location = new System.Drawing.Point(3, 60);
            this.outputFolderLabel.Name = "outputFolderLabel";
            this.outputFolderLabel.Size = new System.Drawing.Size(144, 30);
            this.outputFolderLabel.TabIndex = 7;
            this.outputFolderLabel.Text = "Output folder";
            this.outputFolderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // positionLabel
            // 
            this.positionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.positionLabel.Location = new System.Drawing.Point(3, 90);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(144, 30);
            this.positionLabel.TabIndex = 8;
            this.positionLabel.Text = "Position";
            this.positionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paddingLabel
            // 
            this.paddingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paddingLabel.Location = new System.Drawing.Point(3, 120);
            this.paddingLabel.Name = "paddingLabel";
            this.paddingLabel.Size = new System.Drawing.Size(144, 30);
            this.paddingLabel.TabIndex = 9;
            this.paddingLabel.Text = "Padding (px)";
            this.paddingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paddingUpDown
            // 
            this.paddingUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paddingUpDown.Location = new System.Drawing.Point(153, 123);
            this.paddingUpDown.Maximum = new decimal(new int[] {100000000, 0, 0, 0});
            this.paddingUpDown.Name = "paddingUpDown";
            this.paddingUpDown.Size = new System.Drawing.Size(731, 23);
            this.paddingUpDown.TabIndex = 10;
            this.paddingUpDown.ValueChanged += new System.EventHandler(this.PaddingValueChanged);
            // 
            // positionComboBox
            // 
            this.positionComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.Location = new System.Drawing.Point(153, 93);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(731, 23);
            this.positionComboBox.TabIndex = 11;
            this.positionComboBox.SelectedIndexChanged += new System.EventHandler(this.WatermarkPositionSelectedIndexChanged);
            // 
            // selectedInputFolderText
            // 
            this.selectedInputFolderText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedInputFolderText.Location = new System.Drawing.Point(153, 3);
            this.selectedInputFolderText.Name = "selectedInputFolderText";
            this.selectedInputFolderText.ReadOnly = true;
            this.selectedInputFolderText.Size = new System.Drawing.Size(731, 23);
            this.selectedInputFolderText.TabIndex = 12;
            this.selectedInputFolderText.Text = "Select folder";
            this.selectedInputFolderText.Click += new System.EventHandler(this.SelectInputFolderClick);
            // 
            // selectedWatermarkText
            // 
            this.selectedWatermarkText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedWatermarkText.Location = new System.Drawing.Point(153, 33);
            this.selectedWatermarkText.Name = "selectedWatermarkText";
            this.selectedWatermarkText.ReadOnly = true;
            this.selectedWatermarkText.Size = new System.Drawing.Size(731, 23);
            this.selectedWatermarkText.TabIndex = 13;
            this.selectedWatermarkText.Text = "Select file";
            this.selectedWatermarkText.Click += new System.EventHandler(this.SelectWatermarkFileClick);
            // 
            // selectedOutputFolderText
            // 
            this.selectedOutputFolderText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedOutputFolderText.Location = new System.Drawing.Point(153, 63);
            this.selectedOutputFolderText.Name = "selectedOutputFolderText";
            this.selectedOutputFolderText.ReadOnly = true;
            this.selectedOutputFolderText.Size = new System.Drawing.Size(731, 23);
            this.selectedOutputFolderText.TabIndex = 14;
            this.selectedOutputFolderText.Text = "Select folder";
            this.selectedOutputFolderText.Click += new System.EventHandler(this.SelectOutputFolderClick);
            // 
            // watermarkWidthLabel
            // 
            this.watermarkWidthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.watermarkWidthLabel.Location = new System.Drawing.Point(3, 150);
            this.watermarkWidthLabel.Name = "watermarkWidthLabel";
            this.watermarkWidthLabel.Size = new System.Drawing.Size(144, 30);
            this.watermarkWidthLabel.TabIndex = 15;
            this.watermarkWidthLabel.Text = "Watermark width";
            this.watermarkWidthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // watermarkHeightLabel
            // 
            this.watermarkHeightLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.watermarkHeightLabel.Location = new System.Drawing.Point(3, 180);
            this.watermarkHeightLabel.Name = "watermarkHeightLabel";
            this.watermarkHeightLabel.Size = new System.Drawing.Size(144, 30);
            this.watermarkHeightLabel.TabIndex = 16;
            this.watermarkHeightLabel.Text = "Watermark height";
            this.watermarkHeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // watermarkWidthUpDown
            // 
            this.watermarkWidthUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.watermarkWidthUpDown.Location = new System.Drawing.Point(153, 153);
            this.watermarkWidthUpDown.Maximum = new decimal(new int[] {0, 0, 0, 0});
            this.watermarkWidthUpDown.Name = "watermarkWidthUpDown";
            this.watermarkWidthUpDown.Size = new System.Drawing.Size(731, 23);
            this.watermarkWidthUpDown.TabIndex = 17;
            this.watermarkWidthUpDown.ValueChanged += new System.EventHandler(this.WatermarkWidthValueChanged);
            // 
            // watermarkHeightUpDown
            // 
            this.watermarkHeightUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.watermarkHeightUpDown.Location = new System.Drawing.Point(153, 183);
            this.watermarkHeightUpDown.Maximum = new decimal(new int[] {0, 0, 0, 0});
            this.watermarkHeightUpDown.Name = "watermarkHeightUpDown";
            this.watermarkHeightUpDown.Size = new System.Drawing.Size(731, 23);
            this.watermarkHeightUpDown.TabIndex = 18;
            this.watermarkHeightUpDown.ValueChanged += new System.EventHandler(this.WatermarkHeightValueChanged);
            // 
            // watermarkOpacityLabel
            // 
            this.watermarkOpacityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.watermarkOpacityLabel.Location = new System.Drawing.Point(3, 210);
            this.watermarkOpacityLabel.Name = "watermarkOpacityLabel";
            this.watermarkOpacityLabel.Size = new System.Drawing.Size(144, 30);
            this.watermarkOpacityLabel.TabIndex = 19;
            this.watermarkOpacityLabel.Text = "Watermark opacity";
            this.watermarkOpacityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // watermarkOpacityUpDown
            // 
            this.watermarkOpacityUpDown.DecimalPlaces = 2;
            this.watermarkOpacityUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.watermarkOpacityUpDown.Increment = new decimal(new int[] {1, 0, 0, 131072});
            this.watermarkOpacityUpDown.Location = new System.Drawing.Point(153, 213);
            this.watermarkOpacityUpDown.Maximum = new decimal(new int[] {1, 0, 0, 0});
            this.watermarkOpacityUpDown.Name = "watermarkOpacityUpDown";
            this.watermarkOpacityUpDown.Size = new System.Drawing.Size(731, 23);
            this.watermarkOpacityUpDown.TabIndex = 20;
            this.watermarkOpacityUpDown.ValueChanged += new System.EventHandler(this.WatermarkOpacityValueChanged);
            // 
            // loadPresetButton
            // 
            this.loadPresetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadPresetButton.Location = new System.Drawing.Point(3, 243);
            this.loadPresetButton.Name = "loadPresetButton";
            this.loadPresetButton.Size = new System.Drawing.Size(144, 24);
            this.loadPresetButton.TabIndex = 21;
            this.loadPresetButton.Text = "Load preset";
            this.loadPresetButton.UseVisualStyleBackColor = true;
            this.loadPresetButton.Click += new System.EventHandler(this.LoadPresetClick);
            // 
            // savePresetButton
            // 
            this.savePresetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savePresetButton.Location = new System.Drawing.Point(153, 243);
            this.savePresetButton.Name = "savePresetButton";
            this.savePresetButton.Size = new System.Drawing.Size(731, 24);
            this.savePresetButton.TabIndex = 22;
            this.savePresetButton.Text = "Save preset";
            this.savePresetButton.UseVisualStyleBackColor = true;
            this.savePresetButton.Click += new System.EventHandler(this.SavePresetClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 342);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(999999, 381);
            this.MinimumSize = new System.Drawing.Size(500, 381);
            this.Name = "MainForm";
            this.Text = "WatermarkStamper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.paddingUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.watermarkWidthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.watermarkHeightUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.watermarkOpacityUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label inputFolderLabel;
        private System.Windows.Forms.Button loadPresetButton;
        private System.Windows.Forms.Label outputFolderLabel;
        private System.Windows.Forms.Label paddingLabel;
        private System.Windows.Forms.NumericUpDown paddingUpDown;
        private System.Windows.Forms.ComboBox positionComboBox;
        private System.Windows.Forms.Label positionLabel;
        private WatermarkStamper.TextProgressBar progressBar;
        private System.Windows.Forms.Button savePresetButton;
        private System.Windows.Forms.TextBox selectedInputFolderText;
        private System.Windows.Forms.TextBox selectedOutputFolderText;
        private System.Windows.Forms.TextBox selectedWatermarkText;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label watermarkHeightLabel;
        private System.Windows.Forms.NumericUpDown watermarkHeightUpDown;
        private System.Windows.Forms.Label watermarkImageLabel;
        private System.Windows.Forms.Label watermarkOpacityLabel;
        private System.Windows.Forms.NumericUpDown watermarkOpacityUpDown;
        private System.Windows.Forms.Label watermarkWidthLabel;
        private System.Windows.Forms.NumericUpDown watermarkWidthUpDown;

        #endregion
    }
}