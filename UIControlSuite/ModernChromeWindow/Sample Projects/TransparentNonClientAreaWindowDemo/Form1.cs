using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Binarymission.WinForms.Controls.ContainerControls.Windows;

namespace TransparentNonClientAreaWindowDemo
{
    public partial class Form1 : ModernChromeWindow
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetupTitlebarTransparency(bool value)
        {
            IsTitlebarBackgroundTransparent = value;
        }

        private void SetupTitlebarAndBorderTransparency(bool value)
        {
            IsTitlebarAndBorderBackgroundTransparent = value;
        }

        private void TitlebarTransparentCheckedChanged(object sender, EventArgs e)
        {
            SetupTitlebarTransparency(rdbtnTitlebarTransparent.Checked);
        }

        private void TitlebarAndBorderTransparentCheckedChanged(object sender, EventArgs e)
        {
            SetupTitlebarAndBorderTransparency(rdbtnTitlebarAndBorderTransparent.Checked);
        }

        private void NoTransparencyCheckedChanged(object sender, EventArgs e)
        {
            SetupTitlebarAndBorderTransparency(false);
        }
    }
}
