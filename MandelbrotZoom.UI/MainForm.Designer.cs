namespace MandelbrotZoom;

partial class MainForm {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.MandelbrotPicture = new System.Windows.Forms.PictureBox();
            this.SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.PreviewWithZoomButton = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.PreviewButton = new System.Windows.Forms.Button();
            this.ZoomStepNUD = new System.Windows.Forms.NumericUpDown();
            this.ZoomStepLabel = new System.Windows.Forms.Label();
            this.CenterYNUD = new System.Windows.Forms.NumericUpDown();
            this.CenterYLabel = new System.Windows.Forms.Label();
            this.CenterXNUD = new System.Windows.Forms.NumericUpDown();
            this.CenterXLabel = new System.Windows.Forms.Label();
            this.HeightPxLabel = new System.Windows.Forms.Label();
            this.HeightNUD = new System.Windows.Forms.NumericUpDown();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WidthPxLabel = new System.Windows.Forms.Label();
            this.WidthNUD = new System.Windows.Forms.NumericUpDown();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.MaxIterationsNUD = new System.Windows.Forms.NumericUpDown();
            this.MaxIterationsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MandelbrotPicture)).BeginInit();
            this.SettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomStepNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CenterYNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CenterXNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxIterationsNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // MandelbrotPicture
            // 
            this.MandelbrotPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MandelbrotPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MandelbrotPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MandelbrotPicture.Location = new System.Drawing.Point(12, 12);
            this.MandelbrotPicture.Name = "MandelbrotPicture";
            this.MandelbrotPicture.Size = new System.Drawing.Size(970, 522);
            this.MandelbrotPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MandelbrotPicture.TabIndex = 0;
            this.MandelbrotPicture.TabStop = false;
            // 
            // SettingsGroupBox
            // 
            this.SettingsGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SettingsGroupBox.Controls.Add(this.PreviewWithZoomButton);
            this.SettingsGroupBox.Controls.Add(this.GenerateButton);
            this.SettingsGroupBox.Controls.Add(this.PreviewButton);
            this.SettingsGroupBox.Controls.Add(this.ZoomStepNUD);
            this.SettingsGroupBox.Controls.Add(this.ZoomStepLabel);
            this.SettingsGroupBox.Controls.Add(this.CenterYNUD);
            this.SettingsGroupBox.Controls.Add(this.CenterYLabel);
            this.SettingsGroupBox.Controls.Add(this.CenterXNUD);
            this.SettingsGroupBox.Controls.Add(this.CenterXLabel);
            this.SettingsGroupBox.Controls.Add(this.HeightPxLabel);
            this.SettingsGroupBox.Controls.Add(this.HeightNUD);
            this.SettingsGroupBox.Controls.Add(this.HeightLabel);
            this.SettingsGroupBox.Controls.Add(this.WidthPxLabel);
            this.SettingsGroupBox.Controls.Add(this.WidthNUD);
            this.SettingsGroupBox.Controls.Add(this.WidthLabel);
            this.SettingsGroupBox.Controls.Add(this.MaxIterationsNUD);
            this.SettingsGroupBox.Controls.Add(this.MaxIterationsLabel);
            this.SettingsGroupBox.Location = new System.Drawing.Point(12, 540);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Size = new System.Drawing.Size(970, 129);
            this.SettingsGroupBox.TabIndex = 1;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "Settings";
            // 
            // PreviewWithZoomButton
            // 
            this.PreviewWithZoomButton.Location = new System.Drawing.Point(102, 91);
            this.PreviewWithZoomButton.Name = "PreviewWithZoomButton";
            this.PreviewWithZoomButton.Size = new System.Drawing.Size(130, 23);
            this.PreviewWithZoomButton.TabIndex = 17;
            this.PreviewWithZoomButton.Text = "Preview with Zoom";
            this.PreviewWithZoomButton.UseVisualStyleBackColor = true;
            this.PreviewWithZoomButton.Click += new System.EventHandler(this.PreviewWithZoomButton_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GenerateButton.Location = new System.Drawing.Point(238, 91);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateButton.TabIndex = 16;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            // 
            // PreviewButton
            // 
            this.PreviewButton.Location = new System.Drawing.Point(21, 91);
            this.PreviewButton.Name = "PreviewButton";
            this.PreviewButton.Size = new System.Drawing.Size(75, 23);
            this.PreviewButton.TabIndex = 15;
            this.PreviewButton.Text = "Preview";
            this.PreviewButton.UseVisualStyleBackColor = true;
            this.PreviewButton.Click += new System.EventHandler(this.PreviewButton_Click);
            // 
            // ZoomStepNUD
            // 
            this.ZoomStepNUD.DecimalPlaces = 2;
            this.ZoomStepNUD.Location = new System.Drawing.Point(654, 30);
            this.ZoomStepNUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ZoomStepNUD.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.ZoomStepNUD.Name = "ZoomStepNUD";
            this.ZoomStepNUD.Size = new System.Drawing.Size(72, 23);
            this.ZoomStepNUD.TabIndex = 14;
            this.ZoomStepNUD.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // ZoomStepLabel
            // 
            this.ZoomStepLabel.AutoSize = true;
            this.ZoomStepLabel.Location = new System.Drawing.Point(575, 33);
            this.ZoomStepLabel.Name = "ZoomStepLabel";
            this.ZoomStepLabel.Size = new System.Drawing.Size(68, 15);
            this.ZoomStepLabel.TabIndex = 13;
            this.ZoomStepLabel.Text = "Zoom Step:";
            // 
            // CenterYNUD
            // 
            this.CenterYNUD.DecimalPlaces = 4;
            this.CenterYNUD.Location = new System.Drawing.Point(478, 59);
            this.CenterYNUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CenterYNUD.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.CenterYNUD.Name = "CenterYNUD";
            this.CenterYNUD.Size = new System.Drawing.Size(72, 23);
            this.CenterYNUD.TabIndex = 12;
            this.CenterYNUD.Value = new decimal(new int[] {
            55,
            0,
            0,
            -2147352576});
            // 
            // CenterYLabel
            // 
            this.CenterYLabel.AutoSize = true;
            this.CenterYLabel.Location = new System.Drawing.Point(411, 62);
            this.CenterYLabel.Name = "CenterYLabel";
            this.CenterYLabel.Size = new System.Drawing.Size(55, 15);
            this.CenterYLabel.TabIndex = 11;
            this.CenterYLabel.Text = "Y Center:";
            // 
            // CenterXNUD
            // 
            this.CenterXNUD.DecimalPlaces = 4;
            this.CenterXNUD.Location = new System.Drawing.Point(478, 30);
            this.CenterXNUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CenterXNUD.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.CenterXNUD.Name = "CenterXNUD";
            this.CenterXNUD.Size = new System.Drawing.Size(72, 23);
            this.CenterXNUD.TabIndex = 9;
            this.CenterXNUD.Value = new decimal(new int[] {
            55,
            0,
            0,
            -2147352576});
            // 
            // CenterXLabel
            // 
            this.CenterXLabel.AutoSize = true;
            this.CenterXLabel.Location = new System.Drawing.Point(411, 33);
            this.CenterXLabel.Name = "CenterXLabel";
            this.CenterXLabel.Size = new System.Drawing.Size(55, 15);
            this.CenterXLabel.TabIndex = 8;
            this.CenterXLabel.Text = "X Center:";
            // 
            // HeightPxLabel
            // 
            this.HeightPxLabel.AutoSize = true;
            this.HeightPxLabel.Location = new System.Drawing.Point(377, 62);
            this.HeightPxLabel.Name = "HeightPxLabel";
            this.HeightPxLabel.Size = new System.Drawing.Size(20, 15);
            this.HeightPxLabel.TabIndex = 7;
            this.HeightPxLabel.Text = "px";
            // 
            // HeightNUD
            // 
            this.HeightNUD.Location = new System.Drawing.Point(299, 59);
            this.HeightNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.HeightNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HeightNUD.Name = "HeightNUD";
            this.HeightNUD.Size = new System.Drawing.Size(72, 23);
            this.HeightNUD.TabIndex = 6;
            this.HeightNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.HeightNUD.Value = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(251, 62);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(46, 15);
            this.HeightLabel.TabIndex = 5;
            this.HeightLabel.Text = "Height:";
            // 
            // WidthPxLabel
            // 
            this.WidthPxLabel.AutoSize = true;
            this.WidthPxLabel.Location = new System.Drawing.Point(377, 33);
            this.WidthPxLabel.Name = "WidthPxLabel";
            this.WidthPxLabel.Size = new System.Drawing.Size(20, 15);
            this.WidthPxLabel.TabIndex = 4;
            this.WidthPxLabel.Text = "px";
            // 
            // WidthNUD
            // 
            this.WidthNUD.Location = new System.Drawing.Point(299, 30);
            this.WidthNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.WidthNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WidthNUD.Name = "WidthNUD";
            this.WidthNUD.Size = new System.Drawing.Size(72, 23);
            this.WidthNUD.TabIndex = 3;
            this.WidthNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.WidthNUD.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(251, 33);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(42, 15);
            this.WidthLabel.TabIndex = 2;
            this.WidthLabel.Text = "Width:";
            // 
            // MaxIterationsNUD
            // 
            this.MaxIterationsNUD.Location = new System.Drawing.Point(112, 30);
            this.MaxIterationsNUD.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.MaxIterationsNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxIterationsNUD.Name = "MaxIterationsNUD";
            this.MaxIterationsNUD.Size = new System.Drawing.Size(120, 23);
            this.MaxIterationsNUD.TabIndex = 1;
            this.MaxIterationsNUD.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // MaxIterationsLabel
            // 
            this.MaxIterationsLabel.AutoSize = true;
            this.MaxIterationsLabel.Location = new System.Drawing.Point(21, 33);
            this.MaxIterationsLabel.Name = "MaxIterationsLabel";
            this.MaxIterationsLabel.Size = new System.Drawing.Size(85, 15);
            this.MaxIterationsLabel.TabIndex = 0;
            this.MaxIterationsLabel.Text = "Max Iterations:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 681);
            this.Controls.Add(this.SettingsGroupBox);
            this.Controls.Add(this.MandelbrotPicture);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MandelbrotGenerator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MandelbrotPicture)).EndInit();
            this.SettingsGroupBox.ResumeLayout(false);
            this.SettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomStepNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CenterYNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CenterXNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxIterationsNUD)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private PictureBox MandelbrotPicture;
    private GroupBox SettingsGroupBox;
    private NumericUpDown MaxIterationsNUD;
    private Label MaxIterationsLabel;
    private Label HeightPxLabel;
    private NumericUpDown HeightNUD;
    private Label HeightLabel;
    private Label WidthPxLabel;
    private NumericUpDown WidthNUD;
    private Label WidthLabel;
    private Button GenerateButton;
    private Button PreviewButton;
    private NumericUpDown ZoomStepNUD;
    private Label ZoomStepLabel;
    private NumericUpDown CenterYNUD;
    private Label CenterYLabel;
    private NumericUpDown CenterXNUD;
    private Label CenterXLabel;
    private Button PreviewWithZoomButton;
}
