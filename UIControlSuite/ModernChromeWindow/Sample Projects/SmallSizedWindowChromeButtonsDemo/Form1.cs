using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Binarymission.WinForms.Controls.ContainerControls.Windows;

namespace SmallSizedWindowChromeButtonsDemo
{
    public partial class Form1 : ModernChromeWindow
    {
        public Form1()
        {
            InitializeComponent();
            SetupCommandButtonsSizeToSmallerSize();
        }

        private void SetupCommandButtonsSizeToSmallerSize()
        {
            // Of course, this can be done just by using the designer property editor as well.
            // But here I am illustrating what properties are to be typically set for this feature to take effect.

            WindowChromeCommandButtonSize = new Size(12, 12);
            // That one property setup is all that is needed :)

            // Some more fancy properties setup... so as to make the form look a bit more beautiful (not necessary though!)
            SetupAdditionalFancyProperties();   
        }

        private void SetupAdditionalFancyProperties()
        {
            // Lets also make the form more aesthetically pleasing, and make the title bar itself of a bit smaller height
            // so as to suit the smaller command button sizes, and also allow a bit of gap between the buttons.
            // Setting up these following properties are not a requirement, but I am just setting them here so as to make the form look better.
            // Typically you would want to keep the title bar smaller as well if you were choosing to render the chrome command buttons smaller?

            ChromeTitlebarHeight = 24;
            GapBetweenCommandButtons = 4;

            // Lets also setup some top margin for the command buttons, so it lines up nicely into the middle of the title bar.
            TopMarginForDrawingWindowChromeCommandButtons = 1;
        }

        private void ExitAppClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
