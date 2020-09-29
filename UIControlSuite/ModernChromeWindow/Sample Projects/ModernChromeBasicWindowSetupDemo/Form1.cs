using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Binarymission.WinForms.Controls.ContainerControls.Windows;

namespace ModernChromeBasicWindowSetupDemo
{
    public partial class Form1 : ModernChromeWindow
    {
        public Form1()
        {
            InitializeComponent();
        }
    }

    // The only line of code you need to change in order to start using the ModernChromeWindow is to derive from Binarymission "ModerChromeWindow" class, rather than the Form class from the default System.Windows.Forms namespace.
    // That is all to it.
    // More customizations can be done in addition to this basic essential code change in order to use more advanced features.
    // Please take a look at the other project samples in the installation folder for more information.
}
