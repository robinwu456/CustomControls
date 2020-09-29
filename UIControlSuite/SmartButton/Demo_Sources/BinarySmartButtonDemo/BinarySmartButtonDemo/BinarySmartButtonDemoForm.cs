using System;
using System.Drawing;
using System.Windows.Forms;
using Binarymission.WinForms.Controls.ContainerControls.Windows;
using Binarymission.WinForms.Controls.ContainerControls.Windows.Enums;

namespace BinarySmartButtonDemo
{
    public partial class BinarySmartButtonDemoForm : ModernChromeWindow
    {
        public BinarySmartButtonDemoForm()
        {
            InitializeComponent();
            WindowChromeTheme = WindowChromeTheme.OfficeBlack;
        }

        private void HandleApplicationExitRequest(object sender, EventArgs e)
        {
            Close();
        }
    }
}
