namespace ModernChromeAdvancedOptionsDemo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ExitApp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numSpinnerCustomTopMarginForControlBox = new System.Windows.Forms.NumericUpDown();
            this.numSpinnerTitlebarHeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.optShouldAutoResizeWindowSizeOnBorderWidthChange = new System.Windows.Forms.CheckBox();
            this.optShouldAutoResizeWindowHeightOnTitlebarHeightChange = new System.Windows.Forms.CheckBox();
            this.chkShouldDrawBorderForWindowChromeCommandButtons = new System.Windows.Forms.CheckBox();
            this.chkShouldDrawWindowEdgesAsRoundedCorners = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numSpinnerBorderWidth = new System.Windows.Forms.NumericUpDown();
            this.radioButtonOfficeBlack = new System.Windows.Forms.RadioButton();
            this.radioButtonOfficeBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonOfficeSilver = new System.Windows.Forms.RadioButton();
            this.radioButtonWin8Native = new System.Windows.Forms.RadioButton();
            this.radioButtonWinRT = new System.Windows.Forms.RadioButton();
            this.radioButtonCadetBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonBrown = new System.Windows.Forms.RadioButton();
            this.radioButtonSeaGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonSalmon = new System.Windows.Forms.RadioButton();
            this.radioButtonGradientBrown = new System.Windows.Forms.RadioButton();
            this.radioButtonGradientSeaGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonGradientSalmon = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optVisualStudioDark = new System.Windows.Forms.RadioButton();
            this.optVisualStudioLight = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numSpinnerCustomTopMarginForControlBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpinnerTitlebarHeight)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpinnerBorderWidth)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitApp
            // 
            this.ExitApp.Location = new System.Drawing.Point(552, 483);
            this.ExitApp.Name = "ExitApp";
            this.ExitApp.Size = new System.Drawing.Size(95, 30);
            this.ExitApp.TabIndex = 1;
            this.ExitApp.Text = "Exit";
            this.ExitApp.UseVisualStyleBackColor = true;
            this.ExitApp.Click += new System.EventHandler(this.ExitAppClicked);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(609, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Advanced feature: You can also set the WindowTheme property to \"Custom\", and set " +
    "various properties to set up your custom look/feel for the window chrome.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Set a custom top margin for the control box section:";
            // 
            // numSpinnerCustomTopMarginForControlBox
            // 
            this.numSpinnerCustomTopMarginForControlBox.Location = new System.Drawing.Point(279, 25);
            this.numSpinnerCustomTopMarginForControlBox.Maximum = new decimal(new int[] {
            125,
            0,
            0,
            0});
            this.numSpinnerCustomTopMarginForControlBox.Name = "numSpinnerCustomTopMarginForControlBox";
            this.numSpinnerCustomTopMarginForControlBox.Size = new System.Drawing.Size(62, 20);
            this.numSpinnerCustomTopMarginForControlBox.TabIndex = 13;
            this.numSpinnerCustomTopMarginForControlBox.ValueChanged += new System.EventHandler(this.CustomTopMarginForControlBoxValueChanged);
            // 
            // numSpinnerTitlebarHeight
            // 
            this.numSpinnerTitlebarHeight.Location = new System.Drawing.Point(279, 53);
            this.numSpinnerTitlebarHeight.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numSpinnerTitlebarHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSpinnerTitlebarHeight.Name = "numSpinnerTitlebarHeight";
            this.numSpinnerTitlebarHeight.Size = new System.Drawing.Size(62, 20);
            this.numSpinnerTitlebarHeight.TabIndex = 15;
            this.numSpinnerTitlebarHeight.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numSpinnerTitlebarHeight.ValueChanged += new System.EventHandler(this.TitlebarHeightValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Set a custom height for Chrome title bar:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optShouldAutoResizeWindowSizeOnBorderWidthChange);
            this.groupBox2.Controls.Add(this.optShouldAutoResizeWindowHeightOnTitlebarHeightChange);
            this.groupBox2.Controls.Add(this.chkShouldDrawBorderForWindowChromeCommandButtons);
            this.groupBox2.Controls.Add(this.chkShouldDrawWindowEdgesAsRoundedCorners);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numSpinnerBorderWidth);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numSpinnerCustomTopMarginForControlBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numSpinnerTitlebarHeight);
            this.groupBox2.Location = new System.Drawing.Point(18, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(629, 195);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customization";
            // 
            // optShouldAutoResizeWindowSizeOnBorderWidthChange
            // 
            this.optShouldAutoResizeWindowSizeOnBorderWidthChange.AutoSize = true;
            this.optShouldAutoResizeWindowSizeOnBorderWidthChange.Checked = true;
            this.optShouldAutoResizeWindowSizeOnBorderWidthChange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.optShouldAutoResizeWindowSizeOnBorderWidthChange.Location = new System.Drawing.Point(21, 139);
            this.optShouldAutoResizeWindowSizeOnBorderWidthChange.Name = "optShouldAutoResizeWindowSizeOnBorderWidthChange";
            this.optShouldAutoResizeWindowSizeOnBorderWidthChange.Size = new System.Drawing.Size(323, 17);
            this.optShouldAutoResizeWindowSizeOnBorderWidthChange.TabIndex = 23;
            this.optShouldAutoResizeWindowSizeOnBorderWidthChange.Text = "Should auto-resize window height upon border width changed?";
            this.optShouldAutoResizeWindowSizeOnBorderWidthChange.UseVisualStyleBackColor = true;
            this.optShouldAutoResizeWindowSizeOnBorderWidthChange.CheckedChanged += new System.EventHandler(this.ShouldAutoResizeWindowSizeOnBorderWidthChangeCheckedChanged);
            // 
            // optShouldAutoResizeWindowHeightOnTitlebarHeightChange
            // 
            this.optShouldAutoResizeWindowHeightOnTitlebarHeightChange.AutoSize = true;
            this.optShouldAutoResizeWindowHeightOnTitlebarHeightChange.Checked = true;
            this.optShouldAutoResizeWindowHeightOnTitlebarHeightChange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.optShouldAutoResizeWindowHeightOnTitlebarHeightChange.Location = new System.Drawing.Point(21, 112);
            this.optShouldAutoResizeWindowHeightOnTitlebarHeightChange.Name = "optShouldAutoResizeWindowHeightOnTitlebarHeightChange";
            this.optShouldAutoResizeWindowHeightOnTitlebarHeightChange.Size = new System.Drawing.Size(331, 17);
            this.optShouldAutoResizeWindowHeightOnTitlebarHeightChange.TabIndex = 22;
            this.optShouldAutoResizeWindowHeightOnTitlebarHeightChange.Text = "Should auto-resize window height upon title bar height changed?";
            this.optShouldAutoResizeWindowHeightOnTitlebarHeightChange.UseVisualStyleBackColor = true;
            this.optShouldAutoResizeWindowHeightOnTitlebarHeightChange.CheckedChanged += new System.EventHandler(this.ShouldAutoResizeWindowHeightOnTitlebarHeightChangeCheckedChanged);
            // 
            // chkShouldDrawBorderForWindowChromeCommandButtons
            // 
            this.chkShouldDrawBorderForWindowChromeCommandButtons.AutoSize = true;
            this.chkShouldDrawBorderForWindowChromeCommandButtons.Location = new System.Drawing.Point(22, 166);
            this.chkShouldDrawBorderForWindowChromeCommandButtons.Name = "chkShouldDrawBorderForWindowChromeCommandButtons";
            this.chkShouldDrawBorderForWindowChromeCommandButtons.Size = new System.Drawing.Size(286, 17);
            this.chkShouldDrawBorderForWindowChromeCommandButtons.TabIndex = 21;
            this.chkShouldDrawBorderForWindowChromeCommandButtons.Text = "Should draw border around window command buttons?";
            this.chkShouldDrawBorderForWindowChromeCommandButtons.UseVisualStyleBackColor = true;
            this.chkShouldDrawBorderForWindowChromeCommandButtons.CheckedChanged += new System.EventHandler(this.ShouldDrawBorderForWindowChromeCommandButtonsCheckedChanged);
            // 
            // chkShouldDrawWindowEdgesAsRoundedCorners
            // 
            this.chkShouldDrawWindowEdgesAsRoundedCorners.AutoSize = true;
            this.chkShouldDrawWindowEdgesAsRoundedCorners.Location = new System.Drawing.Point(21, 85);
            this.chkShouldDrawWindowEdgesAsRoundedCorners.Name = "chkShouldDrawWindowEdgesAsRoundedCorners";
            this.chkShouldDrawWindowEdgesAsRoundedCorners.Size = new System.Drawing.Size(289, 17);
            this.chkShouldDrawWindowEdgesAsRoundedCorners.TabIndex = 20;
            this.chkShouldDrawWindowEdgesAsRoundedCorners.Text = "Should draw window corner edges as rounded corners?";
            this.chkShouldDrawWindowEdgesAsRoundedCorners.UseVisualStyleBackColor = true;
            this.chkShouldDrawWindowEdgesAsRoundedCorners.CheckedChanged += new System.EventHandler(this.ShouldDrawWindowEdgesAsRoundedCornersCheckChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Set border thickness:";
            // 
            // numSpinnerBorderWidth
            // 
            this.numSpinnerBorderWidth.Location = new System.Drawing.Point(538, 26);
            this.numSpinnerBorderWidth.Maximum = new decimal(new int[] {
            125,
            0,
            0,
            0});
            this.numSpinnerBorderWidth.Name = "numSpinnerBorderWidth";
            this.numSpinnerBorderWidth.Size = new System.Drawing.Size(62, 20);
            this.numSpinnerBorderWidth.TabIndex = 19;
            this.numSpinnerBorderWidth.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numSpinnerBorderWidth.ValueChanged += new System.EventHandler(this.BorderThicknessValueChanged);
            // 
            // radioButtonOfficeBlack
            // 
            this.radioButtonOfficeBlack.AutoSize = true;
            this.radioButtonOfficeBlack.Location = new System.Drawing.Point(20, 34);
            this.radioButtonOfficeBlack.Name = "radioButtonOfficeBlack";
            this.radioButtonOfficeBlack.Size = new System.Drawing.Size(89, 17);
            this.radioButtonOfficeBlack.TabIndex = 0;
            this.radioButtonOfficeBlack.TabStop = true;
            this.radioButtonOfficeBlack.Text = "Office - Black";
            this.radioButtonOfficeBlack.UseVisualStyleBackColor = true;
            this.radioButtonOfficeBlack.CheckedChanged += new System.EventHandler(this.OfficeBlackCheckedChanged);
            // 
            // radioButtonOfficeBlue
            // 
            this.radioButtonOfficeBlue.AutoSize = true;
            this.radioButtonOfficeBlue.Location = new System.Drawing.Point(20, 69);
            this.radioButtonOfficeBlue.Name = "radioButtonOfficeBlue";
            this.radioButtonOfficeBlue.Size = new System.Drawing.Size(83, 17);
            this.radioButtonOfficeBlue.TabIndex = 1;
            this.radioButtonOfficeBlue.TabStop = true;
            this.radioButtonOfficeBlue.Text = "Office - Blue";
            this.radioButtonOfficeBlue.UseVisualStyleBackColor = true;
            this.radioButtonOfficeBlue.CheckedChanged += new System.EventHandler(this.OfficeBlueCheckedChanged);
            // 
            // radioButtonOfficeSilver
            // 
            this.radioButtonOfficeSilver.AutoSize = true;
            this.radioButtonOfficeSilver.Location = new System.Drawing.Point(20, 104);
            this.radioButtonOfficeSilver.Name = "radioButtonOfficeSilver";
            this.radioButtonOfficeSilver.Size = new System.Drawing.Size(88, 17);
            this.radioButtonOfficeSilver.TabIndex = 2;
            this.radioButtonOfficeSilver.TabStop = true;
            this.radioButtonOfficeSilver.Text = "Office - Silver";
            this.radioButtonOfficeSilver.UseVisualStyleBackColor = true;
            this.radioButtonOfficeSilver.CheckedChanged += new System.EventHandler(this.OfficeSilverCheckedChanged);
            // 
            // radioButtonWin8Native
            // 
            this.radioButtonWin8Native.AutoSize = true;
            this.radioButtonWin8Native.Location = new System.Drawing.Point(174, 34);
            this.radioButtonWin8Native.Name = "radioButtonWin8Native";
            this.radioButtonWin8Native.Size = new System.Drawing.Size(110, 17);
            this.radioButtonWin8Native.TabIndex = 3;
            this.radioButtonWin8Native.TabStop = true;
            this.radioButtonWin8Native.Text = "Windows 8 native";
            this.radioButtonWin8Native.UseVisualStyleBackColor = true;
            this.radioButtonWin8Native.CheckedChanged += new System.EventHandler(this.Win8NativeCheckedChanged);
            // 
            // radioButtonWinRT
            // 
            this.radioButtonWinRT.AutoSize = true;
            this.radioButtonWinRT.Location = new System.Drawing.Point(174, 69);
            this.radioButtonWinRT.Name = "radioButtonWinRT";
            this.radioButtonWinRT.Size = new System.Drawing.Size(59, 17);
            this.radioButtonWinRT.TabIndex = 4;
            this.radioButtonWinRT.TabStop = true;
            this.radioButtonWinRT.Text = "WinRT";
            this.radioButtonWinRT.UseVisualStyleBackColor = true;
            this.radioButtonWinRT.CheckedChanged += new System.EventHandler(this.WinRtCheckedChanged);
            // 
            // radioButtonCadetBlue
            // 
            this.radioButtonCadetBlue.AutoSize = true;
            this.radioButtonCadetBlue.Location = new System.Drawing.Point(174, 104);
            this.radioButtonCadetBlue.Name = "radioButtonCadetBlue";
            this.radioButtonCadetBlue.Size = new System.Drawing.Size(77, 17);
            this.radioButtonCadetBlue.TabIndex = 5;
            this.radioButtonCadetBlue.TabStop = true;
            this.radioButtonCadetBlue.Text = "Cadet Blue";
            this.radioButtonCadetBlue.UseVisualStyleBackColor = true;
            this.radioButtonCadetBlue.CheckedChanged += new System.EventHandler(this.CadetBlueCheckedChanged);
            // 
            // radioButtonBrown
            // 
            this.radioButtonBrown.AutoSize = true;
            this.radioButtonBrown.Location = new System.Drawing.Point(342, 34);
            this.radioButtonBrown.Name = "radioButtonBrown";
            this.radioButtonBrown.Size = new System.Drawing.Size(55, 17);
            this.radioButtonBrown.TabIndex = 6;
            this.radioButtonBrown.TabStop = true;
            this.radioButtonBrown.Text = "Brown";
            this.radioButtonBrown.UseVisualStyleBackColor = true;
            this.radioButtonBrown.CheckedChanged += new System.EventHandler(this.BrownCheckedChanged);
            // 
            // radioButtonSeaGreen
            // 
            this.radioButtonSeaGreen.AutoSize = true;
            this.radioButtonSeaGreen.Location = new System.Drawing.Point(342, 69);
            this.radioButtonSeaGreen.Name = "radioButtonSeaGreen";
            this.radioButtonSeaGreen.Size = new System.Drawing.Size(73, 17);
            this.radioButtonSeaGreen.TabIndex = 7;
            this.radioButtonSeaGreen.TabStop = true;
            this.radioButtonSeaGreen.Text = "SeaGreen";
            this.radioButtonSeaGreen.UseVisualStyleBackColor = true;
            this.radioButtonSeaGreen.CheckedChanged += new System.EventHandler(this.SeaGreenCheckedChanged);
            // 
            // radioButtonSalmon
            // 
            this.radioButtonSalmon.AutoSize = true;
            this.radioButtonSalmon.Location = new System.Drawing.Point(342, 104);
            this.radioButtonSalmon.Name = "radioButtonSalmon";
            this.radioButtonSalmon.Size = new System.Drawing.Size(60, 17);
            this.radioButtonSalmon.TabIndex = 8;
            this.radioButtonSalmon.TabStop = true;
            this.radioButtonSalmon.Text = "Salmon";
            this.radioButtonSalmon.UseVisualStyleBackColor = true;
            this.radioButtonSalmon.CheckedChanged += new System.EventHandler(this.SalmonCheckedChanged);
            // 
            // radioButtonGradientBrown
            // 
            this.radioButtonGradientBrown.AutoSize = true;
            this.radioButtonGradientBrown.Location = new System.Drawing.Point(469, 34);
            this.radioButtonGradientBrown.Name = "radioButtonGradientBrown";
            this.radioButtonGradientBrown.Size = new System.Drawing.Size(98, 17);
            this.radioButtonGradientBrown.TabIndex = 9;
            this.radioButtonGradientBrown.TabStop = true;
            this.radioButtonGradientBrown.Text = "Gradient Brown";
            this.radioButtonGradientBrown.UseVisualStyleBackColor = true;
            this.radioButtonGradientBrown.CheckedChanged += new System.EventHandler(this.GradientBrownCheckedChanged);
            // 
            // radioButtonGradientSeaGreen
            // 
            this.radioButtonGradientSeaGreen.AutoSize = true;
            this.radioButtonGradientSeaGreen.Location = new System.Drawing.Point(469, 69);
            this.radioButtonGradientSeaGreen.Name = "radioButtonGradientSeaGreen";
            this.radioButtonGradientSeaGreen.Size = new System.Drawing.Size(116, 17);
            this.radioButtonGradientSeaGreen.TabIndex = 10;
            this.radioButtonGradientSeaGreen.TabStop = true;
            this.radioButtonGradientSeaGreen.Text = "Gradient SeaGreen";
            this.radioButtonGradientSeaGreen.UseVisualStyleBackColor = true;
            this.radioButtonGradientSeaGreen.CheckedChanged += new System.EventHandler(this.GradientSeaGreenCheckedChanged);
            // 
            // radioButtonGradientSalmon
            // 
            this.radioButtonGradientSalmon.AutoSize = true;
            this.radioButtonGradientSalmon.Location = new System.Drawing.Point(469, 104);
            this.radioButtonGradientSalmon.Name = "radioButtonGradientSalmon";
            this.radioButtonGradientSalmon.Size = new System.Drawing.Size(103, 17);
            this.radioButtonGradientSalmon.TabIndex = 11;
            this.radioButtonGradientSalmon.TabStop = true;
            this.radioButtonGradientSalmon.Text = "Gradient Salmon";
            this.radioButtonGradientSalmon.UseVisualStyleBackColor = true;
            this.radioButtonGradientSalmon.CheckedChanged += new System.EventHandler(this.GradientSalmonCheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optVisualStudioDark);
            this.groupBox1.Controls.Add(this.optVisualStudioLight);
            this.groupBox1.Controls.Add(this.radioButtonGradientSalmon);
            this.groupBox1.Controls.Add(this.radioButtonGradientSeaGreen);
            this.groupBox1.Controls.Add(this.radioButtonGradientBrown);
            this.groupBox1.Controls.Add(this.radioButtonSalmon);
            this.groupBox1.Controls.Add(this.radioButtonSeaGreen);
            this.groupBox1.Controls.Add(this.radioButtonBrown);
            this.groupBox1.Controls.Add(this.radioButtonCadetBlue);
            this.groupBox1.Controls.Add(this.radioButtonWinRT);
            this.groupBox1.Controls.Add(this.radioButtonWin8Native);
            this.groupBox1.Controls.Add(this.radioButtonOfficeSilver);
            this.groupBox1.Controls.Add(this.radioButtonOfficeBlue);
            this.groupBox1.Controls.Add(this.radioButtonOfficeBlack);
            this.groupBox1.Location = new System.Drawing.Point(16, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose a window theme from built-in themes";
            // 
            // optVisualStudioDark
            // 
            this.optVisualStudioDark.AutoSize = true;
            this.optVisualStudioDark.Location = new System.Drawing.Point(174, 141);
            this.optVisualStudioDark.Name = "optVisualStudioDark";
            this.optVisualStudioDark.Size = new System.Drawing.Size(118, 17);
            this.optVisualStudioDark.TabIndex = 15;
            this.optVisualStudioDark.TabStop = true;
            this.optVisualStudioDark.Text = "Visual Studio - Dark";
            this.optVisualStudioDark.UseVisualStyleBackColor = true;
            this.optVisualStudioDark.CheckedChanged += new System.EventHandler(this.optVisualStudioDark_CheckedChanged);
            // 
            // optVisualStudioLight
            // 
            this.optVisualStudioLight.AutoSize = true;
            this.optVisualStudioLight.Location = new System.Drawing.Point(20, 141);
            this.optVisualStudioLight.Name = "optVisualStudioLight";
            this.optVisualStudioLight.Size = new System.Drawing.Size(118, 17);
            this.optVisualStudioLight.TabIndex = 14;
            this.optVisualStudioLight.TabStop = true;
            this.optVisualStudioLight.Text = "Visual Studio - Light";
            this.optVisualStudioLight.UseVisualStyleBackColor = true;
            this.optVisualStudioLight.CheckedChanged += new System.EventHandler(this.optVisualStudioLight_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 564);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitApp);
            this.Controls.Add(this.groupBox1);
            this.DefaultNormalWindowSize = new System.Drawing.Size(300, 300);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.TitlebarText = "Built-in Window Chrome Themes Advanced options Demo";
            ((System.ComponentModel.ISupportInitialize)(this.numSpinnerCustomTopMarginForControlBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpinnerTitlebarHeight)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpinnerBorderWidth)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSpinnerCustomTopMarginForControlBox;
        private System.Windows.Forms.NumericUpDown numSpinnerTitlebarHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numSpinnerBorderWidth;
        private System.Windows.Forms.RadioButton radioButtonOfficeBlack;
        private System.Windows.Forms.RadioButton radioButtonOfficeBlue;
        private System.Windows.Forms.RadioButton radioButtonOfficeSilver;
        private System.Windows.Forms.RadioButton radioButtonWin8Native;
        private System.Windows.Forms.RadioButton radioButtonWinRT;
        private System.Windows.Forms.RadioButton radioButtonCadetBlue;
        private System.Windows.Forms.RadioButton radioButtonBrown;
        private System.Windows.Forms.RadioButton radioButtonSeaGreen;
        private System.Windows.Forms.RadioButton radioButtonSalmon;
        private System.Windows.Forms.RadioButton radioButtonGradientBrown;
        private System.Windows.Forms.RadioButton radioButtonGradientSeaGreen;
        private System.Windows.Forms.RadioButton radioButtonGradientSalmon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkShouldDrawWindowEdgesAsRoundedCorners;
        private System.Windows.Forms.RadioButton optVisualStudioDark;
        private System.Windows.Forms.RadioButton optVisualStudioLight;
        private System.Windows.Forms.CheckBox chkShouldDrawBorderForWindowChromeCommandButtons;
        private System.Windows.Forms.CheckBox optShouldAutoResizeWindowSizeOnBorderWidthChange;
        private System.Windows.Forms.CheckBox optShouldAutoResizeWindowHeightOnTitlebarHeightChange;
    }
}

