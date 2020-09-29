using System;
using System.Drawing;
using System.Windows.Forms;
using Binarymission.WinForms.Controls.ContainerControls.Windows;
using Binarymission.WinForms.Controls.ContainerControls.Windows.Enums;
using Binarymission.WinForms.Controls.ScrollBars;
using Binarymission.WinForms.Controls.ScrollBars.Enums;

namespace ScrollbarsDemoApp
{
    public partial class Form1 : ModernChromeWindow
    {
        private double _picture1X, _picture1Y;

        // Let's setup the scrollbar instances that we can use as scroller for a picture box control
        private HorizontalScrollBar _horizontalScrollBar1;
        private VerticalScrollBar _verticalScrollBar1;
        
        public Form1()
        {
            InitializeComponent();
            WindowChromeTheme = WindowChromeTheme.OfficeBlack;
            InitialiseScrollbarInstances();
            SubscribeToScrollbarAndTargetScrolledControlEvents();
        }

        private void InitialiseUiArtefactsState()
        {
            cmbbxColorTheme.Items.AddRange(Enum.GetNames(typeof(ColorTheme)));
            numericSpinnerScrollerSize.Value = _horizontalScrollBar1.HorizontalScrollBarHeight;
            var item = Enum.Parse(typeof (ColorTheme),
                _horizontalScrollBar1.ScrollBarRenderingConfigurator.ColorTheme.ToString());
            cmbbxColorTheme.SelectedIndex = cmbbxColorTheme.Items.IndexOf(item.ToString());
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
            // Let's customize the custom scrollbar controls with various desired property values like height, width, color, etc.
            // Note that there are many more properties that we can customize, including plugging-in our own renderer for each part of the scrollbar control (like Thumb, Track, etc.)
            // Please refer to the API help guide to see what all more you can do with the control's customization.

            // But here, we will customize some handful of properties... just to prove the point...

            CustomiseScrollbarInstances();
            InitialiseUiArtefactsState();
        }

        private void InitialiseScrollbarInstances()
        {
            _horizontalScrollBar1 = new HorizontalScrollBar();
            _verticalScrollBar1 = new VerticalScrollBar();
            
            Controls.Add(_horizontalScrollBar1);
            Controls.Add(_verticalScrollBar1);
        }

        private void CustomiseScrollbarInstances()
        {
            _horizontalScrollBar1.ScrollBarRenderingConfigurator.ColorTheme = ColorTheme.OfficeBlue;
            _verticalScrollBar1.ScrollBarRenderingConfigurator.ColorTheme = ColorTheme.OfficeBlue;

            _horizontalScrollBar1.ScrollBarRenderingConfigurator.ControlVisualStateHoverColor = Color.Teal;
            _verticalScrollBar1.ScrollBarRenderingConfigurator.ControlVisualStateHoverColor = Color.Teal;

            // Setup various other core properties, i.e. the size and location of the scrollbar controls in relation to the other control 
            // that we are trying to attach the custom scrollbar to (i.e. picture box control in this case).

            _horizontalScrollBar1.Width = pictureBox1.Width;
            _horizontalScrollBar1.Height = 24;
            _horizontalScrollBar1.Left = pictureBox1.Left;
            _horizontalScrollBar1.Top = pictureBox1.Bottom;
            _horizontalScrollBar1.MaximumScrollRange = pictureBox1.Image.Width - pictureBox1.Width;
            _verticalScrollBar1.Height = pictureBox1.Height;
            _verticalScrollBar1.Width = 24;
            _verticalScrollBar1.Left = pictureBox1.Left + pictureBox1.Width;
            _verticalScrollBar1.Top = pictureBox1.Top;
            _verticalScrollBar1.MaximumScrollRange = pictureBox1.Image.Height - pictureBox1.Height;
        }

        private void SubscribeToScrollbarAndTargetScrolledControlEvents()
        {
            // Lets subscribe to some core events of the custom scrollbar control...

            // Typically, you only need to subscribe to the two important events - "PositionChanged" and "Scroll".

            // On the horizontal scrollbar instance
            _horizontalScrollBar1.PositionChanged += _horizontalScrollBar1_PositionChanged;
            _horizontalScrollBar1.Scroll += horizontalScrollBar1_Scroll;
            
            // On the vertical scollbar instance
            _verticalScrollBar1.PositionChanged += _verticalScrollBar1_PositionChanged;
            _verticalScrollBar1.Scroll += verticalScrollBar1_Scroll;
            
            // Lets also subscribe to the paint event of the target control (picture box control in our case here)... 
            // so we can move (scroll) the picture as we desire, when the scrollbar events are raised.
            pictureBox1.Paint += pictureBox1_Paint;
        }

        private void numericSpinnerScrollerSize_ValueChanged(object sender, EventArgs e)
        {
            _horizontalScrollBar1.HorizontalScrollBarHeight = (int)numericSpinnerScrollerSize.Value;
            _verticalScrollBar1.VerticalScrollBarWidth = (int)numericSpinnerScrollerSize.Value;
        }

        private void cmbbxColorTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            _horizontalScrollBar1.ScrollBarRenderingConfigurator.ColorTheme = (ColorTheme)Enum.Parse(typeof(ColorTheme),
                cmbbxColorTheme.SelectedItem.ToString());
            _verticalScrollBar1.ScrollBarRenderingConfigurator.ColorTheme = (ColorTheme)Enum.Parse(typeof(ColorTheme),
                cmbbxColorTheme.SelectedItem.ToString());
            _horizontalScrollBar1.Invalidate();
            _verticalScrollBar1.Invalidate();
        }
        
        void _horizontalScrollBar1_PositionChanged(object sender, Binarymission.WinForms.Controls.ScrollBars.Events.PositionChangedArgs e)
        {
            _picture1X = _horizontalScrollBar1.Position;
            pictureBox1.Invalidate();
        }

        void _verticalScrollBar1_PositionChanged(object sender, Binarymission.WinForms.Controls.ScrollBars.Events.PositionChangedArgs e)
        {
            _picture1Y = _verticalScrollBar1.Position;
            pictureBox1.Invalidate();
        }

        void verticalScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            _picture1Y = _verticalScrollBar1.Position;
            pictureBox1.Refresh();
        }

        void horizontalScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            _picture1X = _horizontalScrollBar1.Position;
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // NOTE: Obviously this way (as below) of redrawing is not the ideal way to do the redrawing of any .NET control, specifically picture box control.
            // But I have this in place here just to prove the point of how to use custom scrollbar controls with any other control.
            // For better performant way of scrolling and redrawing a picture box, please use P/Invoke and Win32 APIs or consider using our ScrollablePictureViuewer control (if you want), which is 
            // pre-written from scratch for offering much better performance when redrawing its view.

            // But for demo purposes, this should do well, since all we are proving here is show how to use the custom scrollbar controls with any other control/user control.
            e.Graphics.DrawImage(pictureBox1.Image, e.ClipRectangle, (int)_picture1X, (int)_picture1Y, e.ClipRectangle.Width,
                e.ClipRectangle.Height, GraphicsUnit.Pixel);
        }
    }
}
