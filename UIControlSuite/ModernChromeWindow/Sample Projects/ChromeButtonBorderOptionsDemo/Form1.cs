using System;
using System.Drawing;
using Binarymission.WinForms.Controls.ContainerControls.Windows;

namespace ChromeButtonBorderOptionsDemo
{
    public partial class Form1 : ModernChromeWindow
    {
        public Form1()
        {
            InitializeComponent();
            chkShouldDrawButtonsBorder.Checked = true;
        }

        private void BtnExitAppClick(object sender, EventArgs e)
        {
            Close();
        }

        private void NumGapBetweenChromeButtonsValueChanged(object sender, EventArgs e)
        {
            GapBetweenCommandButtons = (int) numGapBetweenChromeButtons.Value;
        }

        private void ChkShouldDrawButtonsBorderCheckedChanged(object sender, EventArgs e)
        {
            ShouldDrawBorderForWindowChromeCommandButtons = chkShouldDrawButtonsBorder.Checked;
        }
    }
}
