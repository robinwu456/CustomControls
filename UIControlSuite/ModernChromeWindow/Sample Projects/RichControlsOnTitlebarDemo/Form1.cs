using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Binarymission.WinForms.Controls.ContainerControls.Windows;
using Binarymission.WinForms.Controls.ContainerControls.Windows.Enums;

namespace RichControlsOnTitlebarDemo
{
    public partial class Form1 : ModernChromeWindow
    {
        private Panel _titlebarControlsHostingPanel;
        private ComboBox _combobox;
        private Button _button;

        public Form1()
        {
            InitializeComponent();

            // Set some properties of the Form window.
            // Of course, these properties can be set even from the Designer mode, but I am just doing them here just to show-off some cool properties ;)

            // Set a theme
            WindowChromeTheme = WindowChromeTheme.OfficeBlue;

            // Set the title-bar height.
            ChromeTitlebarHeight = 64;

            // Since we have the title-bar section to be 64 units, let me set this property to false - so that the window will render the app icon at a larger possible size (rather than forcing it at 16 bits)
            ShouldRenderAppIconUsingStandardSize = false;

            // Let me set some decent left margin. Well, remember that the ModernChromeWindow will only allow a maximum of 6 units for this property.
            AppIconLeftMargin = 6;

            // Refer to step 4 in the "SetupCaptionbarControls" method for this property details.
            ShouldAnchorTitlebarChildControlsToRight = true;

            // Important: Ensure to create the title-bar child controls in the Form's HandleCreated event (or alternatively on the "Shown" event)
            HandleCreated += InitializeChildControls;
        }

        void InitializeChildControls(object sender, EventArgs e)
        {
            SetupCaptionbarControls();
        }

        private void SetupCaptionbarControls()
        {
            // Step 1 : Construct some controls to be hosted on the non-client area.

            _titlebarControlsHostingPanel = new Panel();

            _combobox = new ComboBox
            {
                Location = new Point(0, 3),
                Size = new Size(100, 22),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            _combobox.Items.AddRange(new object[] { "1", "2", "3" });
            _combobox.SelectedIndex = (_combobox.Items.Count > 0) ? 0 : -1;
            _combobox.SelectedIndexChanged += new EventHandler(_combobox_SelectedIndexChanged);


            _button = new Button
            {
                Text = @"?",
                Size = new Size(16, 22),
                Location = new Point(_combobox.Bounds.Width + 2, 3),
            };

            _button.Click += _button_Click;
           
            _titlebarControlsHostingPanel.Controls.AddRange(new Control[]
            {
                _combobox, _button
            });

            // Step 2: Add child controls to the ModernChromeWindow.TitlebarControls controls collection property
            // In our case, we are just adding one control (a container control - i.e. a panel) that contains all our desired child controls that we want to host in the title bar.

            TitlebarControls.Add(_titlebarControlsHostingPanel);

            // Step 3: Set a custom size for the hosted controls container

            TitlebarControlsHostSize = new Size(138, 28);

            // Step 4: Setup a desired custom location (in client co-ordinates) where you would like the controls to appear on the title bar.
            // This will ensure the controls are rendered at the specific coordinates.

            // If you wanted the controls to have an anchored behavior - i.e. anchored to right hand side in the title bar, so that when the
            // window is resized, maximized etc., the title-bar controls also get rendered at the maximum X coordinate viable,
            // based on the resized window size, then in that case - you would want to set the property ShouldAnchorTitlebarChildControlsToRight = true
            // You can see that I have set this property to true in the Form's constructor, just to prove its behavior.
            // If you want the controls to be rendered at teh exact location that you specify, then set that property value to false instead.

            // For now, I will set the location to a fixed custom location.
            // If you set this property to a particular coordinate (like as below), then the Form will ensure it remains at that location, always.
            TitlebarControlsHostLocation = new Point(427, 7);

            // All done! :) Enjoy!!
        }

        void _combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Combobox current selected index is:  {0}", _combobox.SelectedIndex.ToString()), @"Message from title bar controls", MessageBoxButtons.OK);
        }

        void _button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Help system active:  Help is currently available.", @"Message from title bar controls", MessageBoxButtons.OK);
        }
    }
}
