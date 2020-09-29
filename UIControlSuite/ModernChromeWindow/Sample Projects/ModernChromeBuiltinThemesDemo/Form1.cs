using System;
using System.Drawing;
using System.Windows.Forms;
using Binarymission.WinForms.Controls.ContainerControls.Windows;
using Binarymission.WinForms.Controls.ContainerControls.Windows.Enums;

namespace ModernChromeBuiltinThemesDemo
{
    public partial class Form1 : ModernChromeWindow
    {
        public Form1()
        {
            InitializeComponent();
            WindowChromeThemeChanged += Form1_WindowChromeThemeChanged;
        }

        void Form1_WindowChromeThemeChanged(object sender, Binarymission.WinForms.Controls.ContainerControls.Windows.CustomEventArgs.WindowChromeThemeChangedEventArgs e)
        {
            // Just demonstrating the use of the event "WindowChromeThemeChanged" that is raised by the ModernChromneWindow component.

            if (e.NewChromeTheme == WindowChromeTheme.VisualStudioDark)
            {
                groupBox1.ForeColor = Color.White;
                label1.ForeColor = Color.White;
            }
            else
            {
                groupBox1.ForeColor = Control.DefaultForeColor;
                label1.ForeColor = Control.DefaultForeColor;
            }
        }

        private void BtnExitAppClick(object sender, EventArgs e)
        {
            Close();
        }

        private void OfficeBlackCheckedChanged(object sender, EventArgs e)
        {
            WindowChromeTheme = WindowChromeTheme.OfficeBlack;
        }

        private void OfficeBlueCheckedChanged(object sender, EventArgs e)
        {
            WindowChromeTheme = WindowChromeTheme.OfficeBlue;
        }

        private void OfficeSilverCheckedChanged(object sender, EventArgs e)
        {
            WindowChromeTheme = WindowChromeTheme.OfficeSilver;
        }

        private void Win8NativeCheckedChanged(object sender, EventArgs e)
        {
            WindowChromeTheme = WindowChromeTheme.Win8;
        }

        private void WinRtCheckedChanged(object sender, EventArgs e)
        {
            WindowChromeTheme = WindowChromeTheme.WinRT;
        }

        private void CadetBlueCheckedChanged(object sender, EventArgs e)
        {
            WindowChromeTheme = WindowChromeTheme.CadetBlue;
        }

        private void SandyBrownCheckedChanged(object sender, EventArgs e)
        {
            WindowChromeTheme = WindowChromeTheme.SandyBrown;
        }

        private void SeaGreenCheckedChanged(object sender, EventArgs e)
        {
            WindowChromeTheme = WindowChromeTheme.SeaGreen;
        }

        private void SalmonCheckedChanged(object sender, EventArgs e)
        {
            WindowChromeTheme = WindowChromeTheme.Salmon;
        }

        private void GradientSandyBrownCheckedChanged(object sender, EventArgs e)
        {
            WindowChromeTheme = WindowChromeTheme.GradientSandyBrown;
        }

        private void GradientSeaGreenCheckedChanged(object sender, EventArgs e)
        {
            WindowChromeTheme = WindowChromeTheme.GradientSeaGreen;
        }

        private void GradientSalmonCheckedChanged(object sender, EventArgs e)
        {
            WindowChromeTheme = WindowChromeTheme.GradientSalmon;
        }

        private void optVisualStudioLight_CheckedChanged(object sender, EventArgs e)
        {
            WindowChromeTheme = WindowChromeTheme.VisualStudioLight;
        }

        private void optVisualStudioDark_CheckedChanged(object sender, EventArgs e)
        {
            WindowChromeTheme = WindowChromeTheme.VisualStudioDark;
        }
    }
}
