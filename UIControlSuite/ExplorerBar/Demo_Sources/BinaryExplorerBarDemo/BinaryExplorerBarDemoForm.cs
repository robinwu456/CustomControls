using System.Windows.Forms;
using Binarymission.WinForms.Controls.ContainerControls.Windows;
using Binarymission.WinForms.Controls.ContainerControls.Windows.Enums;

namespace BinaryExplorerBarDemo
{
    public partial class BinaryExplorerBarDemoForm : ModernChromeWindow
    {
        public BinaryExplorerBarDemoForm()
        {
            InitializeComponent();
            WindowChromeTheme = WindowChromeTheme.OfficeBlack;
        }
   }
}