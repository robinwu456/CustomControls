namespace ScrollbarsDemoApp
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbbxColorTheme = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericSpinnerScrollerSize = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.horizontalScrollBar1 = new Binarymission.WinForms.Controls.ScrollBars.HorizontalScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpinnerScrollerSize)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ScrollbarsDemoApp.Properties.Resources.Desert;
            this.pictureBox1.Location = new System.Drawing.Point(15, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(621, 428);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "A picture control that uses Custom Scrollbar controls:";
            // 
            // cmbbxColorTheme
            // 
            this.cmbbxColorTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxColorTheme.FormattingEnabled = true;
            this.cmbbxColorTheme.Location = new System.Drawing.Point(802, 126);
            this.cmbbxColorTheme.Name = "cmbbxColorTheme";
            this.cmbbxColorTheme.Size = new System.Drawing.Size(253, 20);
            this.cmbbxColorTheme.TabIndex = 5;
            this.cmbbxColorTheme.SelectedIndexChanged += new System.EventHandler(this.cmbbxColorTheme_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(800, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Change Color Theme for the Scrollbars:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(800, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Change Size fo Scrollbars:";
            // 
            // numericSpinnerScrollerSize
            // 
            this.numericSpinnerScrollerSize.Location = new System.Drawing.Point(804, 65);
            this.numericSpinnerScrollerSize.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericSpinnerScrollerSize.Name = "numericSpinnerScrollerSize";
            this.numericSpinnerScrollerSize.Size = new System.Drawing.Size(159, 22);
            this.numericSpinnerScrollerSize.TabIndex = 8;
            this.numericSpinnerScrollerSize.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericSpinnerScrollerSize.ValueChanged += new System.EventHandler(this.numericSpinnerScrollerSize_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(803, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 196);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notes:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 81);
            this.label5.TabIndex = 11;
            this.label5.Text = "Please referemce the control\'s property \"ScrollBarConfigurator\"  and its sub-prop" +
    "erties for all the advanced customisations you can achieve.";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 97);
            this.label4.TabIndex = 10;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // horizontalScrollBar1
            // 
            this.horizontalScrollBar1.BackColor = System.Drawing.Color.White;
            this.horizontalScrollBar1.BackgroundImage = global::ScrollbarsDemoApp.Properties.Resources.scrollBar;
            this.horizontalScrollBar1.HorizontalScrollBarHeight = 61;
            this.horizontalScrollBar1.IsDefaultScrollContextMenuEnabled = true;
            this.horizontalScrollBar1.Location = new System.Drawing.Point(79, 499);
            this.horizontalScrollBar1.Name = "horizontalScrollBar1";
            this.horizontalScrollBar1.PaddingGap = 0;
            this.horizontalScrollBar1.Position = 80D;
            this.horizontalScrollBar1.ScrollBarNavigationButtonRenderer = null;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.BorderColor = System.Drawing.Color.Transparent;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.BuiltInNavigationButtonImageDimension = new System.Drawing.Size(0, 0);
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.ColorTheme = Binarymission.WinForms.Controls.ScrollBars.Enums.ColorTheme.Custom;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.ControlOnHoverBorderHighlightColor = System.Drawing.Color.Transparent;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.ControlVisualStateHoverColor = System.Drawing.Color.Transparent;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.ControlVisualStatePressedColor = System.Drawing.Color.Transparent;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.GradientEndNavigationButtonBackgroundColor = System.Drawing.Color.Transparent;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.GradientEndThumbFillColor = System.Drawing.Color.Transparent;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.GradientEndTrackFillColor = System.Drawing.Color.Transparent;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.GradientStartNavigationButtonBackgroundColor = System.Drawing.Color.Transparent;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.GradientStartThumbFillColor = System.Drawing.Color.Transparent;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.GradientStartTrackFillColor = System.Drawing.Color.Transparent;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.GripperColor1 = System.Drawing.Color.Transparent;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.GripperColor2 = System.Drawing.Color.Transparent;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.HorizontalGripperImage = global::ScrollbarsDemoApp.Properties.Resources.scrollBar;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.HorizontalScrollButtonImageLeftHot = null;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.HorizontalScrollButtonImageLeftNormal = null;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.HorizontalScrollButtonImageLeftPressed = null;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.HorizontalScrollButtonImageRightHot = null;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.HorizontalScrollButtonImageRightNormal = null;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.HorizontalScrollButtonImageRightPressed = null;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.HorizontalThumbBoxImageHot = global::ScrollbarsDemoApp.Properties.Resources.scrollBarThumb_hover;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.HorizontalThumbBoxImageNormal = global::ScrollbarsDemoApp.Properties.Resources.scrollBarThumb;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.HorizontalThumbBoxImagePressed = global::ScrollbarsDemoApp.Properties.Resources.scrollBarThumb_hover;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.IsDrawingNavigationButtonArrowsEnabled = true;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.NavigationButtonArrowColor = System.Drawing.Color.Transparent;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.NavigationButtonsColor = System.Drawing.Color.Empty;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.ShouldDrawBorderOnThumbWhenDrawingThumbAsCustomImage = true;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.ShouldDrawCustomNavigationButtonArrowImageUnscaled = true;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.ShouldDrawGripperArtefact = true;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.ThumbFillColor = System.Drawing.Color.Transparent;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.ThumbGripperMajorColor = System.Drawing.Color.Transparent;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.ThumbGripperMinorColor = System.Drawing.Color.Transparent;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.TrackFillColor = System.Drawing.Color.Transparent;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.VerticalGripperImage = null;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.VerticalScrollButtonImageDownHot = null;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.VerticalScrollButtonImageDownNormal = null;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.VerticalScrollButtonImageDownPressed = null;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.VerticalScrollButtonImageUpHot = null;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.VerticalScrollButtonImageUpNormal = null;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.VerticalScrollButtonImageUpPressed = null;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.VerticalThumbBoxImageHot = null;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.VerticalThumbBoxImageNormal = null;
            this.horizontalScrollBar1.ScrollBarRenderingConfigurator.VerticalThumbBoxImagePressed = null;
            this.horizontalScrollBar1.ScrollBarThumbGripperRenderer = null;
            this.horizontalScrollBar1.ScrollBarThumbRenderer = null;
            this.horizontalScrollBar1.ScrollBarTrackRenderer = null;
            this.horizontalScrollBar1.ShouldAutomaticallyPositionScroller = false;
            this.horizontalScrollBar1.ShouldUseExtendedMenuControlForContextMenu = false;
            this.horizontalScrollBar1.Size = new System.Drawing.Size(466, 61);
            this.horizontalScrollBar1.TabIndex = 10;
            this.horizontalScrollBar1.VerticalScrollBarWidth = 61;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundDisabledCloseCommandButton.Color = System.Drawing.Color.SlateGray;
            this.BackgroundDisabledMaximizeRestoreCommandButton.Color = System.Drawing.Color.SlateGray;
            this.BackgroundDisabledMinimizeCommandButton.Color = System.Drawing.Color.SlateGray;
            this.BackgroundHotCloseCommandButton.Color = System.Drawing.Color.SlateGray;
            this.BackgroundHotMaximizeRestoreCommandButton.Color = System.Drawing.Color.SlateGray;
            this.BackgroundHotMinimizeCommandButton.Color = System.Drawing.Color.SlateGray;
            this.BackgroundNormalCloseCommandButton.Color = System.Drawing.Color.SlateGray;
            this.BackgroundNormalMaximizeRestoreCommandButton.Color = System.Drawing.Color.SlateGray;
            this.BackgroundNormalMinimizeCommandButton.Color = System.Drawing.Color.SlateGray;
            this.BackgroundPressedCloseCommandButton.Color = System.Drawing.Color.SlateGray;
            this.BackgroundPressedMaximizeRestoreCommandButton.Color = System.Drawing.Color.SlateGray;
            this.BackgroundPressedMinimizeCommandButton.Color = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1127, 630);
            this.Controls.Add(this.horizontalScrollBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericSpinnerScrollerSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbbxColorTheme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DefaultNormalWindowSize = new System.Drawing.Size(300, 300);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.TitlebarText = "";
            this.WindowChromeTitleTextBrush.Color = System.Drawing.Color.SlateGray;
            this.WindowChromeTitleTextBrushWhenTitlebarBackgroundIsTransparent.Color = System.Drawing.Color.SlateGray;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpinnerScrollerSize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbbxColorTheme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericSpinnerScrollerSize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Binarymission.WinForms.Controls.ScrollBars.HorizontalScrollBar horizontalScrollBar1;
    }
}

