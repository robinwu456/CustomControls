using System;
using System.Drawing;
using System.Windows.Forms;
using Binarymission.WinForms.Controls.ContainerControls.Windows;
using Binarymission.WinForms.Controls.ContainerControls.Windows.Enums;

namespace ModernChromeAdvancedOptionsDemo
{
    public partial class Form1 : ModernChromeWindow
    {
        public Form1()
        {
            InitializeComponent();
            WindowChromeThemeChanged += Form1WindowChromeThemeChanged;
            WindowChromeTitlebarHeightChanged += WindowChromeTitlebarHeightChangedHandler;

            ShouldAutoResizeWindowHeightOnTitlebarHeightChange =
                optShouldAutoResizeWindowHeightOnTitlebarHeightChange.Checked;
            ShouldAutoResizeWindowSizeOnBorderWidthChange = optShouldAutoResizeWindowSizeOnBorderWidthChange.Checked;
        }

        void WindowChromeTitlebarHeightChangedHandler(object sender, Binarymission.WinForms.Controls.ContainerControls.Windows.CustomEventArgs.WindowChromeTitlebarHeightChangedEventArgs e)
        {
            // I will use this event and ask the component to draw my application icon to its full size if the changed title bar height can accommodate it.
            ShouldRenderAppIconUsingStandardSize = (e.NewHeight <= 48);
        }

        void Form1WindowChromeThemeChanged(object sender, Binarymission.WinForms.Controls.ContainerControls.Windows.CustomEventArgs.WindowChromeThemeChangedEventArgs e)
        {
            AppIconLeftMargin = 3;
            chkShouldDrawWindowEdgesAsRoundedCorners.Enabled = !(e.NewChromeTheme == WindowChromeTheme.Win8 ||
                                                                        e.NewChromeTheme == WindowChromeTheme.WinRT);
            ShouldDrawBorderForWindowChromeCommandButtonsCheckedChanged(this, EventArgs.Empty);

            if (e.NewChromeTheme == WindowChromeTheme.VisualStudioDark)
            {
                groupBox1.ForeColor = groupBox2.ForeColor = Color.White;
                label1.ForeColor = Color.White;
            }
            else
            {
                groupBox1.ForeColor = groupBox2.ForeColor = DefaultForeColor;
                label1.ForeColor = DefaultForeColor;
            }
        }

        private void OfficeBlackCheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOfficeBlack.Checked)
            {
                WindowChromeTheme = WindowChromeTheme.OfficeBlack;
            }
        }

        private void OfficeBlueCheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOfficeBlue.Checked)
            {
                WindowChromeTheme = WindowChromeTheme.OfficeBlue;
            }
        }

        private void OfficeSilverCheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOfficeSilver.Checked)
            {
                WindowChromeTheme = WindowChromeTheme.OfficeSilver;
            }
        }

        private void Win8NativeCheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWin8Native.Checked)
            {
                WindowChromeTheme = WindowChromeTheme.Win8;
            }
        }

        private void WinRtCheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWinRT.Checked)
            {
                WindowChromeTheme = WindowChromeTheme.WinRT;
            }
        }

        private void CadetBlueCheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCadetBlue.Checked)
            {
                WindowChromeTheme = WindowChromeTheme.CadetBlue;
            }
        }

        private void BrownCheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBrown.Checked)
            {
                WindowChromeTheme = WindowChromeTheme.SandyBrown;
            }
        }
        
        private void SalmonCheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSalmon.Checked)
            {
                WindowChromeTheme = WindowChromeTheme.Salmon;
            }
        }

        private void SeaGreenCheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSeaGreen.Checked)
            {
                WindowChromeTheme = WindowChromeTheme.SeaGreen;
            }
        }

        private void GradientBrownCheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGradientBrown.Checked)
            {
                WindowChromeTheme = WindowChromeTheme.GradientSandyBrown;
            }
        }

        private void GradientSeaGreenCheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGradientSeaGreen.Checked)
            {
                WindowChromeTheme = WindowChromeTheme.GradientSeaGreen;
            }
        }

        private void GradientSalmonCheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGradientSalmon.Checked)
            {
                WindowChromeTheme = WindowChromeTheme.GradientSalmon;   
            }
        }

        private void ExitAppClicked(object sender, EventArgs e)
        {
            Close();
        }

        private void CustomTopMarginForControlBoxValueChanged(object sender, EventArgs e)
        {
            TopMarginForDrawingWindowChromeCommandButtons = (int)numSpinnerCustomTopMarginForControlBox.Value;
            numSpinnerCustomTopMarginForControlBox.Value = TopMarginForDrawingWindowChromeCommandButtons;
        }
        
        private void TitlebarHeightValueChanged(object sender, EventArgs e)
        {
            var changedValue = (int) numSpinnerTitlebarHeight.Value;
            if (changedValue >= 32)
            {
                ChromeTitlebarHeight = changedValue;
            }
        }
        
        private void BorderThicknessValueChanged(object sender, EventArgs e)
        {
            ChromeBorderSize = (int)numSpinnerBorderWidth.Value;
        }

        private void ShouldDrawWindowEdgesAsRoundedCornersCheckChanged(object sender, EventArgs e)
        {
            WindowEdgeCornerRadius = chkShouldDrawWindowEdgesAsRoundedCorners.Checked ? new WindowEdgeCornerRadius(15, 15) : new WindowEdgeCornerRadius(0, 0);
            ShouldDrawWindowEdgesWithRoundedCorners = chkShouldDrawWindowEdgesAsRoundedCorners.Checked;
        }

        private void optVisualStudioLight_CheckedChanged(object sender, EventArgs e)
        {
            WindowChromeTheme = WindowChromeTheme.VisualStudioLight;
        }

        private void optVisualStudioDark_CheckedChanged(object sender, EventArgs e)
        {
            WindowChromeTheme = WindowChromeTheme.VisualStudioDark;
        }

        private void ShouldDrawBorderForWindowChromeCommandButtonsCheckedChanged(object sender, EventArgs e)
        {
            ShouldDrawBorderForWindowChromeCommandButtons = chkShouldDrawBorderForWindowChromeCommandButtons.Checked;
        }

        private void ShouldAutoResizeWindowHeightOnTitlebarHeightChangeCheckedChanged(object sender, EventArgs e)
        {
            ShouldAutoResizeWindowHeightOnTitlebarHeightChange =
                optShouldAutoResizeWindowHeightOnTitlebarHeightChange.Checked;
        }

        private void ShouldAutoResizeWindowSizeOnBorderWidthChangeCheckedChanged(object sender, EventArgs e)
        {
            ShouldAutoResizeWindowSizeOnBorderWidthChange = optShouldAutoResizeWindowSizeOnBorderWidthChange.Checked;
        }
    }
}
