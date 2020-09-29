using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Binarymission.WinForms.Controls;
using Binarymission.WinForms.Controls.ContainerControls.Windows;
using Binarymission.WinForms.Controls.ContainerControls.Windows.Enums;

namespace AdvancedLabelOptionsDemo
{
    public partial class LabelOptionsDemoForm : ModernChromeWindow
    {
        public LabelOptionsDemoForm()
        {
            InitializeComponent();
            Load += LabelOptionsDemoForm_Load;
        }

        void LabelOptionsDemoForm_Load(object sender, EventArgs e)
        {
            WindowChromeTheme = WindowChromeTheme.OfficeBlack;
        }

        private void chkEnableDropShadow_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var labelInstance in Controls.OfType<ExtendedLabel>())
            {
                labelInstance.ShouldDrawDropShadow = chkEnableDropShadow.Checked;
            }
        }
        
        private void borderColourInvoker_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog(this) != DialogResult.OK) return;

            foreach (var labelInstance in Controls.OfType<ExtendedLabel>())
            {
                labelInstance.BorderColor = colorDialog1.Color;
            }
        }

        private void horizontalAlignmentSelector_SelectedItemChanged(object sender, EventArgs e)
        {
            SetAlignmentOption(false);
        }

        private void verticalAlignmentSelector_SelectedItemChanged(object sender, EventArgs e)
        {
            SetAlignmentOption(true);
        }
        
        private void borderThicknessSelector_SelectedItemChanged(object sender, EventArgs e)
        {
            foreach (var labelInstance in Controls.OfType<ExtendedLabel>())
            {
                labelInstance.BorderDrawingStyle =
                    (ExtendedLabel.BorderStyle)Enum.Parse(typeof(ExtendedLabel.BorderStyle),
                        borderThicknessSelector.SelectedItem.ToString());
            }
        }

        private void SetAlignmentOption(bool isVerticalAlignmentBeingSet)
        {
            foreach (var labelInstance in Controls.OfType<ExtendedLabel>())
            {
                var stringFormat = labelInstance.StringFormat;

                if (isVerticalAlignmentBeingSet)
                {
                    stringFormat.LineAlignment =
                        (StringAlignment)Enum.Parse(typeof(StringAlignment),
                            verticalAlignmentSelector.SelectedItem.ToString());
                }
                else
                {
                    stringFormat.Alignment =
                    (StringAlignment)Enum.Parse(typeof(StringAlignment),
                        horizontalAlignmentSelector.SelectedItem.ToString());
                }

                labelInstance.StringFormat = stringFormat;
            }
        }

        private void appExitInvoker_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
