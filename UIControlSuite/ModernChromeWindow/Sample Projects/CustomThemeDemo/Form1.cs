using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using Binarymission.WinForms.Controls.ContainerControls.Windows;
using Binarymission.WinForms.Controls.ContainerControls.Windows.Entities;
using Binarymission.WinForms.Controls.ContainerControls.Windows.Enums;

namespace CustomThemeDemo
{
    public partial class Form1 : ModernChromeWindow
    {
        private RichTextBox _richTextBox;

        public Form1()
        {
            InitializeComponent();
            SetupCustomTheme();
            SetCustomThemeWithCustomLinearGradientBrushForTitleBar();
            SetupClientControls();
        }

        private void SetupCustomTheme()
        {
            // I will set the theme to be "Custom", so I can set up some custom properties to deep customize the chrome parts.
            // Please note that you do not have to set the theme to "Custom" in oder to be able to customize the window chrome,
            // since you can still use one of the built-in WindowChromeThemes (like Office) and be able to customize on top of that, even further with other custom property values.
            WindowChromeTheme = WindowChromeTheme.Custom;

            // Lets draw a large sized title bar
            ChromeTitlebarHeight = 64;

            // Lets also customize the chrome border size and color
            ChromeBorderSize = 6;
            WindowChromeBorderColor = Color.Tan;

            // Set this since we do have an large-sized app icon, and if we did not set this property to false, the component will draw the large icon in a fixed standard 16 x 16 pixels boundary.
            // Of course if we set the title bar height to less than the app icon height, then it is better to leave this property's value as true.
            ShouldRenderAppIconUsingStandardSize = false;

            // Now, let us also set up some custom colors for drawing the title bar itself.
            WindowChromeStartColor = Color.Tan;
            WindowChromeEndColor = Color.Wheat;

            // Let us choose an aesthetically-pleasing back-color for the form client area
            BackColor = Color.Moccasin;

            // Set up a custom title bar brush color so it can play nicely with the title bar background we have set up so far.
            WindowChromeTitleTextBrush = new BrushContainer {Brush = Brushes.Black};

            // Its now time to set up some colors for various properties relating to the command-buttons in the chrome as well...
            BackgroundNormalCloseCommandButton = new BrushContainer {Brush = Brushes.Tan};
            BackgroundNormalMinimizeCommandButton = new BrushContainer {Brush = Brushes.Tan};
            BackgroundNormalMaximizeRestoreCommandButton = new BrushContainer {Brush = Brushes.Tan};
            ForegroundInternalVisualForNormalCloseCommandButton = Color.SaddleBrown;
            ForegroundInternalVisualForNormalMaximizeRestoreCommandButton = Color.SaddleBrown;
            ForegroundInternalVisualForNormalMinimizeCommandButton = Color.SaddleBrown;

            // Set up a custom title bar text.
            TitlebarText = @"Custom Theme setup Demo";
        }

        private void SetCustomThemeWithCustomLinearGradientBrushForTitleBar()
        {
            WindowChromeStartColor = Color.Tan;
            WindowChromeEndColor = Color.Moccasin;
            WindowChromeGradientMode = LinearGradientMode.Vertical;
        }

        private void SetupClientControls()
        {
            // Set up some client area controls for the window/form.

            _richTextBox = new RichTextBox { Dock = DockStyle.Fill, BorderStyle = BorderStyle.Fixed3D, Font = new Font(Font.FontFamily, 11f)};
            Controls.Add(_richTextBox);
        }
    }
}
