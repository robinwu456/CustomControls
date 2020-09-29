namespace AdvancedLabelOptionsDemo
{
    partial class LabelOptionsDemoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Drawing.StringFormat stringFormat1 = new System.Drawing.StringFormat();
            System.Drawing.StringFormat stringFormat2 = new System.Drawing.StringFormat();
            System.Drawing.StringFormat stringFormat3 = new System.Drawing.StringFormat();
            System.Drawing.StringFormat stringFormat4 = new System.Drawing.StringFormat();
            System.Drawing.StringFormat stringFormat5 = new System.Drawing.StringFormat();
            System.Drawing.StringFormat stringFormat6 = new System.Drawing.StringFormat();
            System.Drawing.StringFormat stringFormat7 = new System.Drawing.StringFormat();
            System.Drawing.StringFormat stringFormat8 = new System.Drawing.StringFormat();
            System.Drawing.StringFormat stringFormat9 = new System.Drawing.StringFormat();
            System.Drawing.StringFormat stringFormat10 = new System.Drawing.StringFormat();
            System.Drawing.StringFormat stringFormat11 = new System.Drawing.StringFormat();
            System.Drawing.StringFormat stringFormat12 = new System.Drawing.StringFormat();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabelOptionsDemoForm));
            this.chkEnableDropShadow = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.horizontalAlignmentSelector = new System.Windows.Forms.DomainUpDown();
            this.verticalAlignmentSelector = new System.Windows.Forms.DomainUpDown();
            this.borderThicknessSelector = new System.Windows.Forms.DomainUpDown();
            this.borderColourInvoker = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.appExitInvoker = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.extendedLabel11 = new Binarymission.WinForms.Controls.ExtendedLabel();
            this.extendedLabel10 = new Binarymission.WinForms.Controls.ExtendedLabel();
            this.extendedLabel9 = new Binarymission.WinForms.Controls.ExtendedLabel();
            this.extendedLabel8 = new Binarymission.WinForms.Controls.ExtendedLabel();
            this.extendedLabel7 = new Binarymission.WinForms.Controls.ExtendedLabel();
            this.extendedLabel5 = new Binarymission.WinForms.Controls.ExtendedLabel();
            this.extendedLabel6 = new Binarymission.WinForms.Controls.ExtendedLabel();
            this.extendedLabel4 = new Binarymission.WinForms.Controls.ExtendedLabel();
            this.extendedLabel3 = new Binarymission.WinForms.Controls.ExtendedLabel();
            this.extendedLabel2 = new Binarymission.WinForms.Controls.ExtendedLabel();
            this.extendedLabel1 = new Binarymission.WinForms.Controls.ExtendedLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.extendedLabel12 = new Binarymission.WinForms.Controls.ExtendedLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkEnableDropShadow
            // 
            this.chkEnableDropShadow.AutoSize = true;
            this.chkEnableDropShadow.Checked = true;
            this.chkEnableDropShadow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableDropShadow.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableDropShadow.Location = new System.Drawing.Point(22, 31);
            this.chkEnableDropShadow.Name = "chkEnableDropShadow";
            this.chkEnableDropShadow.Size = new System.Drawing.Size(169, 20);
            this.chkEnableDropShadow.TabIndex = 8;
            this.chkEnableDropShadow.Text = "Enable Drop-shadow?";
            this.chkEnableDropShadow.UseVisualStyleBackColor = true;
            this.chkEnableDropShadow.CheckedChanged += new System.EventHandler(this.chkEnableDropShadow_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.horizontalAlignmentSelector);
            this.groupBox1.Controls.Add(this.verticalAlignmentSelector);
            this.groupBox1.Controls.Add(this.borderThicknessSelector);
            this.groupBox1.Controls.Add(this.borderColourInvoker);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkEnableDropShadow);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(763, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 430);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 68);
            this.label6.TabIndex = 20;
            this.label6.Text = "There are many more properties in the control that you can customise in order to " +
    "get more special effects.";
            // 
            // horizontalAlignmentSelector
            // 
            this.horizontalAlignmentSelector.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horizontalAlignmentSelector.Items.Add("Near");
            this.horizontalAlignmentSelector.Items.Add("Center");
            this.horizontalAlignmentSelector.Items.Add("Far");
            this.horizontalAlignmentSelector.Location = new System.Drawing.Point(158, 114);
            this.horizontalAlignmentSelector.Name = "horizontalAlignmentSelector";
            this.horizontalAlignmentSelector.Size = new System.Drawing.Size(104, 23);
            this.horizontalAlignmentSelector.TabIndex = 19;
            this.horizontalAlignmentSelector.Text = "Center";
            this.horizontalAlignmentSelector.SelectedItemChanged += new System.EventHandler(this.horizontalAlignmentSelector_SelectedItemChanged);
            // 
            // verticalAlignmentSelector
            // 
            this.verticalAlignmentSelector.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verticalAlignmentSelector.Items.Add("Near");
            this.verticalAlignmentSelector.Items.Add("Center");
            this.verticalAlignmentSelector.Items.Add("Far");
            this.verticalAlignmentSelector.Location = new System.Drawing.Point(158, 72);
            this.verticalAlignmentSelector.Name = "verticalAlignmentSelector";
            this.verticalAlignmentSelector.Size = new System.Drawing.Size(104, 23);
            this.verticalAlignmentSelector.TabIndex = 18;
            this.verticalAlignmentSelector.Text = "Center";
            this.verticalAlignmentSelector.SelectedItemChanged += new System.EventHandler(this.verticalAlignmentSelector_SelectedItemChanged);
            // 
            // borderThicknessSelector
            // 
            this.borderThicknessSelector.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderThicknessSelector.Items.Add("None");
            this.borderThicknessSelector.Items.Add("Thin");
            this.borderThicknessSelector.Items.Add("Thick");
            this.borderThicknessSelector.Items.Add("SuperThick");
            this.borderThicknessSelector.Location = new System.Drawing.Point(158, 158);
            this.borderThicknessSelector.Name = "borderThicknessSelector";
            this.borderThicknessSelector.Size = new System.Drawing.Size(104, 23);
            this.borderThicknessSelector.TabIndex = 17;
            this.borderThicknessSelector.Text = "Thin";
            this.borderThicknessSelector.SelectedItemChanged += new System.EventHandler(this.borderThicknessSelector_SelectedItemChanged);
            // 
            // borderColourInvoker
            // 
            this.borderColourInvoker.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderColourInvoker.Location = new System.Drawing.Point(158, 193);
            this.borderColourInvoker.Name = "borderColourInvoker";
            this.borderColourInvoker.Size = new System.Drawing.Size(103, 23);
            this.borderColourInvoker.TabIndex = 16;
            this.borderColourInvoker.Text = "...";
            this.borderColourInvoker.UseVisualStyleBackColor = true;
            this.borderColourInvoker.Click += new System.EventHandler(this.borderColourInvoker_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Border color:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Border thickness:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "Text horizontal alignment";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Text vertical alignment";
            // 
            // appExitInvoker
            // 
            this.appExitInvoker.Location = new System.Drawing.Point(938, 559);
            this.appExitInvoker.Name = "appExitInvoker";
            this.appExitInvoker.Size = new System.Drawing.Size(105, 30);
            this.appExitInvoker.TabIndex = 14;
            this.appExitInvoker.Text = "Exit";
            this.appExitInvoker.UseVisualStyleBackColor = true;
            this.appExitInvoker.Click += new System.EventHandler(this.appExitInvoker_Click);
            // 
            // extendedLabel11
            // 
            this.extendedLabel11.BackgroundGradientFloatAngle = 0F;
            this.extendedLabel11.BorderColor = System.Drawing.Color.Black;
            this.extendedLabel11.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.extendedLabel11.BorderDrawingStyle = Binarymission.WinForms.Controls.ExtendedLabel.BorderStyle.Thin;
            this.extendedLabel11.DropShadowGradientFloatAngle = 45F;
            this.extendedLabel11.DropShadowMargin = 6;
            this.extendedLabel11.EndLinearGradientBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.extendedLabel11.EndLinearGradientDropShadowBackgroundColor = System.Drawing.Color.LightGray;
            this.extendedLabel11.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extendedLabel11.IsBackgroundTransparent = false;
            this.extendedLabel11.Location = new System.Drawing.Point(126, 404);
            this.extendedLabel11.Name = "extendedLabel11";
            this.extendedLabel11.Orientation = Binarymission.WinForms.Controls.ExtendedLabel.DrawingOrientation.Horizontal;
            this.extendedLabel11.ShouldDrawBorder = true;
            this.extendedLabel11.ShouldDrawDropShadow = true;
            this.extendedLabel11.ShouldRefreshUponParentMoveResize = false;
            this.extendedLabel11.Size = new System.Drawing.Size(311, 32);
            this.extendedLabel11.StartLinearGradientBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.extendedLabel11.StartLinearGradientDropShadowBackgroundColor = System.Drawing.Color.Gray;
            stringFormat1.Alignment = System.Drawing.StringAlignment.Center;
            stringFormat1.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat1.LineAlignment = System.Drawing.StringAlignment.Center;
            stringFormat1.Trimming = System.Drawing.StringTrimming.Character;
            this.extendedLabel11.StringFormat = stringFormat1;
            this.extendedLabel11.TabIndex = 12;
            this.extendedLabel11.TabStop = false;
            this.extendedLabel11.Text = "I am a single line label.";
            this.extendedLabel11.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.extendedLabel11.VerticalTextDirection = Binarymission.WinForms.Controls.ExtendedLabel.TextDirection.BottomTop;
            // 
            // extendedLabel10
            // 
            this.extendedLabel10.BackgroundGradientFloatAngle = 0F;
            this.extendedLabel10.BorderColor = System.Drawing.Color.Black;
            this.extendedLabel10.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.extendedLabel10.BorderDrawingStyle = Binarymission.WinForms.Controls.ExtendedLabel.BorderStyle.Thin;
            this.extendedLabel10.DropShadowGradientFloatAngle = 45F;
            this.extendedLabel10.DropShadowMargin = 6;
            this.extendedLabel10.EndLinearGradientBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.extendedLabel10.EndLinearGradientDropShadowBackgroundColor = System.Drawing.Color.LightGray;
            this.extendedLabel10.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extendedLabel10.ForeColor = System.Drawing.Color.White;
            this.extendedLabel10.IsBackgroundTransparent = false;
            this.extendedLabel10.Location = new System.Drawing.Point(126, 366);
            this.extendedLabel10.Name = "extendedLabel10";
            this.extendedLabel10.Orientation = Binarymission.WinForms.Controls.ExtendedLabel.DrawingOrientation.Horizontal;
            this.extendedLabel10.ShouldDrawBorder = true;
            this.extendedLabel10.ShouldDrawDropShadow = true;
            this.extendedLabel10.ShouldRefreshUponParentMoveResize = false;
            this.extendedLabel10.Size = new System.Drawing.Size(311, 32);
            this.extendedLabel10.StartLinearGradientBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.extendedLabel10.StartLinearGradientDropShadowBackgroundColor = System.Drawing.Color.Gray;
            stringFormat2.Alignment = System.Drawing.StringAlignment.Center;
            stringFormat2.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat2.LineAlignment = System.Drawing.StringAlignment.Center;
            stringFormat2.Trimming = System.Drawing.StringTrimming.Character;
            this.extendedLabel10.StringFormat = stringFormat2;
            this.extendedLabel10.TabIndex = 11;
            this.extendedLabel10.TabStop = false;
            this.extendedLabel10.Text = "I am a single line label.";
            this.extendedLabel10.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.extendedLabel10.VerticalTextDirection = Binarymission.WinForms.Controls.ExtendedLabel.TextDirection.BottomTop;
            // 
            // extendedLabel9
            // 
            this.extendedLabel9.BackgroundGradientFloatAngle = 0F;
            this.extendedLabel9.BorderColor = System.Drawing.Color.Black;
            this.extendedLabel9.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.extendedLabel9.BorderDrawingStyle = Binarymission.WinForms.Controls.ExtendedLabel.BorderStyle.Thin;
            this.extendedLabel9.DropShadowGradientFloatAngle = 45F;
            this.extendedLabel9.DropShadowMargin = 6;
            this.extendedLabel9.EndLinearGradientBackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.extendedLabel9.EndLinearGradientDropShadowBackgroundColor = System.Drawing.Color.LightGray;
            this.extendedLabel9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extendedLabel9.ForeColor = System.Drawing.Color.White;
            this.extendedLabel9.IsBackgroundTransparent = false;
            this.extendedLabel9.Location = new System.Drawing.Point(67, 366);
            this.extendedLabel9.Name = "extendedLabel9";
            this.extendedLabel9.Orientation = Binarymission.WinForms.Controls.ExtendedLabel.DrawingOrientation.Vertical;
            this.extendedLabel9.ShouldDrawBorder = true;
            this.extendedLabel9.ShouldDrawDropShadow = true;
            this.extendedLabel9.ShouldRefreshUponParentMoveResize = false;
            this.extendedLabel9.Size = new System.Drawing.Size(40, 214);
            this.extendedLabel9.StartLinearGradientBackgroundColor = System.Drawing.Color.DodgerBlue;
            this.extendedLabel9.StartLinearGradientDropShadowBackgroundColor = System.Drawing.Color.Gray;
            stringFormat3.Alignment = System.Drawing.StringAlignment.Center;
            stringFormat3.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat3.LineAlignment = System.Drawing.StringAlignment.Center;
            stringFormat3.Trimming = System.Drawing.StringTrimming.Character;
            this.extendedLabel9.StringFormat = stringFormat3;
            this.extendedLabel9.TabIndex = 10;
            this.extendedLabel9.TabStop = false;
            this.extendedLabel9.Text = "I am a single line label.";
            this.extendedLabel9.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.extendedLabel9.VerticalTextDirection = Binarymission.WinForms.Controls.ExtendedLabel.TextDirection.BottomTop;
            // 
            // extendedLabel8
            // 
            this.extendedLabel8.BackgroundGradientFloatAngle = 0F;
            this.extendedLabel8.BorderColor = System.Drawing.Color.Black;
            this.extendedLabel8.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.extendedLabel8.BorderDrawingStyle = Binarymission.WinForms.Controls.ExtendedLabel.BorderStyle.Thin;
            this.extendedLabel8.DropShadowGradientFloatAngle = 45F;
            this.extendedLabel8.DropShadowMargin = 6;
            this.extendedLabel8.EndLinearGradientBackgroundColor = System.Drawing.SystemColors.Control;
            this.extendedLabel8.EndLinearGradientDropShadowBackgroundColor = System.Drawing.Color.LightGray;
            this.extendedLabel8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extendedLabel8.IsBackgroundTransparent = false;
            this.extendedLabel8.Location = new System.Drawing.Point(21, 366);
            this.extendedLabel8.Name = "extendedLabel8";
            this.extendedLabel8.Orientation = Binarymission.WinForms.Controls.ExtendedLabel.DrawingOrientation.Vertical;
            this.extendedLabel8.ShouldDrawBorder = true;
            this.extendedLabel8.ShouldDrawDropShadow = true;
            this.extendedLabel8.ShouldRefreshUponParentMoveResize = false;
            this.extendedLabel8.Size = new System.Drawing.Size(40, 214);
            this.extendedLabel8.StartLinearGradientBackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.extendedLabel8.StartLinearGradientDropShadowBackgroundColor = System.Drawing.Color.Gray;
            stringFormat4.Alignment = System.Drawing.StringAlignment.Center;
            stringFormat4.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat4.LineAlignment = System.Drawing.StringAlignment.Center;
            stringFormat4.Trimming = System.Drawing.StringTrimming.Character;
            this.extendedLabel8.StringFormat = stringFormat4;
            this.extendedLabel8.TabIndex = 9;
            this.extendedLabel8.TabStop = false;
            this.extendedLabel8.Text = "I am a single line label.";
            this.extendedLabel8.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.extendedLabel8.VerticalTextDirection = Binarymission.WinForms.Controls.ExtendedLabel.TextDirection.TopBottom;
            // 
            // extendedLabel7
            // 
            this.extendedLabel7.BackgroundGradientFloatAngle = 0F;
            this.extendedLabel7.BorderColor = System.Drawing.Color.Black;
            this.extendedLabel7.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.extendedLabel7.BorderDrawingStyle = Binarymission.WinForms.Controls.ExtendedLabel.BorderStyle.Thin;
            this.extendedLabel7.DropShadowGradientFloatAngle = 45F;
            this.extendedLabel7.DropShadowMargin = 6;
            this.extendedLabel7.EndLinearGradientBackgroundColor = System.Drawing.SystemColors.Control;
            this.extendedLabel7.EndLinearGradientDropShadowBackgroundColor = System.Drawing.Color.LightGray;
            this.extendedLabel7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extendedLabel7.IsBackgroundTransparent = false;
            this.extendedLabel7.Location = new System.Drawing.Point(457, 366);
            this.extendedLabel7.Name = "extendedLabel7";
            this.extendedLabel7.Orientation = Binarymission.WinForms.Controls.ExtendedLabel.DrawingOrientation.Vertical;
            this.extendedLabel7.ShouldDrawBorder = true;
            this.extendedLabel7.ShouldDrawDropShadow = true;
            this.extendedLabel7.ShouldRefreshUponParentMoveResize = false;
            this.extendedLabel7.Size = new System.Drawing.Size(286, 103);
            this.extendedLabel7.StartLinearGradientBackgroundColor = System.Drawing.Color.Salmon;
            this.extendedLabel7.StartLinearGradientDropShadowBackgroundColor = System.Drawing.Color.Gray;
            stringFormat5.Alignment = System.Drawing.StringAlignment.Center;
            stringFormat5.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat5.LineAlignment = System.Drawing.StringAlignment.Center;
            stringFormat5.Trimming = System.Drawing.StringTrimming.Character;
            this.extendedLabel7.StringFormat = stringFormat5;
            this.extendedLabel7.TabIndex = 7;
            this.extendedLabel7.TabStop = false;
            this.extendedLabel7.Text = "I can automatically display text in multiple lines, draw a drop-shadow, and orien" +
    "te Vertically and Right to Left.";
            this.extendedLabel7.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.extendedLabel7.VerticalTextDirection = Binarymission.WinForms.Controls.ExtendedLabel.TextDirection.BottomTop;
            // 
            // extendedLabel5
            // 
            this.extendedLabel5.BackgroundGradientFloatAngle = 0F;
            this.extendedLabel5.BorderColor = System.Drawing.Color.Black;
            this.extendedLabel5.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.extendedLabel5.BorderDrawingStyle = Binarymission.WinForms.Controls.ExtendedLabel.BorderStyle.Thin;
            this.extendedLabel5.DropShadowGradientFloatAngle = 45F;
            this.extendedLabel5.DropShadowMargin = 6;
            this.extendedLabel5.EndLinearGradientBackgroundColor = System.Drawing.SystemColors.Control;
            this.extendedLabel5.EndLinearGradientDropShadowBackgroundColor = System.Drawing.Color.LightGray;
            this.extendedLabel5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extendedLabel5.IsBackgroundTransparent = false;
            this.extendedLabel5.Location = new System.Drawing.Point(606, 47);
            this.extendedLabel5.Name = "extendedLabel5";
            this.extendedLabel5.Orientation = Binarymission.WinForms.Controls.ExtendedLabel.DrawingOrientation.Vertical;
            this.extendedLabel5.ShouldDrawBorder = true;
            this.extendedLabel5.ShouldDrawDropShadow = true;
            this.extendedLabel5.ShouldRefreshUponParentMoveResize = false;
            this.extendedLabel5.Size = new System.Drawing.Size(137, 196);
            this.extendedLabel5.StartLinearGradientBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.extendedLabel5.StartLinearGradientDropShadowBackgroundColor = System.Drawing.Color.Gray;
            stringFormat6.Alignment = System.Drawing.StringAlignment.Center;
            stringFormat6.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat6.LineAlignment = System.Drawing.StringAlignment.Center;
            stringFormat6.Trimming = System.Drawing.StringTrimming.Character;
            this.extendedLabel5.StringFormat = stringFormat6;
            this.extendedLabel5.TabIndex = 6;
            this.extendedLabel5.TabStop = false;
            this.extendedLabel5.Text = "I can automatically display text in multiple lines, draw a drop-shadow, and orien" +
    "te Vertically and Bottom to Top.";
            this.extendedLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.extendedLabel5.VerticalTextDirection = Binarymission.WinForms.Controls.ExtendedLabel.TextDirection.BottomTop;
            // 
            // extendedLabel6
            // 
            this.extendedLabel6.BackgroundGradientFloatAngle = 0F;
            this.extendedLabel6.BorderColor = System.Drawing.Color.Black;
            this.extendedLabel6.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.extendedLabel6.BorderDrawingStyle = Binarymission.WinForms.Controls.ExtendedLabel.BorderStyle.Thin;
            this.extendedLabel6.DropShadowGradientFloatAngle = 45F;
            this.extendedLabel6.DropShadowMargin = 6;
            this.extendedLabel6.EndLinearGradientBackgroundColor = System.Drawing.SystemColors.Control;
            this.extendedLabel6.EndLinearGradientDropShadowBackgroundColor = System.Drawing.Color.LightGray;
            this.extendedLabel6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extendedLabel6.IsBackgroundTransparent = false;
            this.extendedLabel6.Location = new System.Drawing.Point(457, 254);
            this.extendedLabel6.Name = "extendedLabel6";
            this.extendedLabel6.Orientation = Binarymission.WinForms.Controls.ExtendedLabel.DrawingOrientation.Vertical;
            this.extendedLabel6.ShouldDrawBorder = true;
            this.extendedLabel6.ShouldDrawDropShadow = true;
            this.extendedLabel6.ShouldRefreshUponParentMoveResize = false;
            this.extendedLabel6.Size = new System.Drawing.Size(286, 102);
            this.extendedLabel6.StartLinearGradientBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.extendedLabel6.StartLinearGradientDropShadowBackgroundColor = System.Drawing.Color.Gray;
            stringFormat7.Alignment = System.Drawing.StringAlignment.Center;
            stringFormat7.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat7.LineAlignment = System.Drawing.StringAlignment.Center;
            stringFormat7.Trimming = System.Drawing.StringTrimming.Character;
            this.extendedLabel6.StringFormat = stringFormat7;
            this.extendedLabel6.TabIndex = 5;
            this.extendedLabel6.TabStop = false;
            this.extendedLabel6.Text = "I can automatically display text in multiple lines, draw a drop-shadow, and orien" +
    "te Vertically and Left to Right.";
            this.extendedLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.extendedLabel6.VerticalTextDirection = Binarymission.WinForms.Controls.ExtendedLabel.TextDirection.TopBottom;
            // 
            // extendedLabel4
            // 
            this.extendedLabel4.BackgroundGradientFloatAngle = 0F;
            this.extendedLabel4.BorderColor = System.Drawing.Color.Black;
            this.extendedLabel4.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.extendedLabel4.BorderDrawingStyle = Binarymission.WinForms.Controls.ExtendedLabel.BorderStyle.Thin;
            this.extendedLabel4.DropShadowGradientFloatAngle = 45F;
            this.extendedLabel4.DropShadowMargin = 6;
            this.extendedLabel4.EndLinearGradientBackgroundColor = System.Drawing.SystemColors.Control;
            this.extendedLabel4.EndLinearGradientDropShadowBackgroundColor = System.Drawing.Color.LightGray;
            this.extendedLabel4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extendedLabel4.IsBackgroundTransparent = false;
            this.extendedLabel4.Location = new System.Drawing.Point(457, 46);
            this.extendedLabel4.Name = "extendedLabel4";
            this.extendedLabel4.Orientation = Binarymission.WinForms.Controls.ExtendedLabel.DrawingOrientation.Vertical;
            this.extendedLabel4.ShouldDrawBorder = true;
            this.extendedLabel4.ShouldDrawDropShadow = true;
            this.extendedLabel4.ShouldRefreshUponParentMoveResize = false;
            this.extendedLabel4.Size = new System.Drawing.Size(137, 196);
            this.extendedLabel4.StartLinearGradientBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.extendedLabel4.StartLinearGradientDropShadowBackgroundColor = System.Drawing.Color.Gray;
            stringFormat8.Alignment = System.Drawing.StringAlignment.Center;
            stringFormat8.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat8.LineAlignment = System.Drawing.StringAlignment.Center;
            stringFormat8.Trimming = System.Drawing.StringTrimming.Character;
            this.extendedLabel4.StringFormat = stringFormat8;
            this.extendedLabel4.TabIndex = 3;
            this.extendedLabel4.TabStop = false;
            this.extendedLabel4.Text = "I can automatically display text in multiple lines, draw a drop-shadow, and orien" +
    "te Vertically and Top to bottom.";
            this.extendedLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.extendedLabel4.VerticalTextDirection = Binarymission.WinForms.Controls.ExtendedLabel.TextDirection.TopBottom;
            // 
            // extendedLabel3
            // 
            this.extendedLabel3.BackgroundGradientFloatAngle = 0F;
            this.extendedLabel3.BorderColor = System.Drawing.Color.Black;
            this.extendedLabel3.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.extendedLabel3.BorderDrawingStyle = Binarymission.WinForms.Controls.ExtendedLabel.BorderStyle.Thin;
            this.extendedLabel3.DropShadowGradientFloatAngle = 45F;
            this.extendedLabel3.DropShadowMargin = 6;
            this.extendedLabel3.EndLinearGradientBackgroundColor = System.Drawing.SystemColors.Control;
            this.extendedLabel3.EndLinearGradientDropShadowBackgroundColor = System.Drawing.Color.LightGray;
            this.extendedLabel3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extendedLabel3.IsBackgroundTransparent = false;
            this.extendedLabel3.Location = new System.Drawing.Point(21, 250);
            this.extendedLabel3.Name = "extendedLabel3";
            this.extendedLabel3.Orientation = Binarymission.WinForms.Controls.ExtendedLabel.DrawingOrientation.Horizontal;
            this.extendedLabel3.ShouldDrawBorder = true;
            this.extendedLabel3.ShouldDrawDropShadow = true;
            this.extendedLabel3.ShouldRefreshUponParentMoveResize = false;
            this.extendedLabel3.Size = new System.Drawing.Size(416, 100);
            this.extendedLabel3.StartLinearGradientBackgroundColor = System.Drawing.SystemColors.Control;
            this.extendedLabel3.StartLinearGradientDropShadowBackgroundColor = System.Drawing.Color.Gray;
            stringFormat9.Alignment = System.Drawing.StringAlignment.Center;
            stringFormat9.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat9.LineAlignment = System.Drawing.StringAlignment.Center;
            stringFormat9.Trimming = System.Drawing.StringTrimming.Character;
            this.extendedLabel3.StringFormat = stringFormat9;
            this.extendedLabel3.TabIndex = 2;
            this.extendedLabel3.TabStop = false;
            this.extendedLabel3.Text = "I can automatically display text in multiple lines, draw a drop-shadow, and orien" +
    "ted horizontally.\r\nThere are many more options that can be set, including String" +
    " formatting, colors, and border setup.";
            this.extendedLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.extendedLabel3.VerticalTextDirection = Binarymission.WinForms.Controls.ExtendedLabel.TextDirection.TopBottom;
            // 
            // extendedLabel2
            // 
            this.extendedLabel2.BackgroundGradientFloatAngle = 0F;
            this.extendedLabel2.BorderColor = System.Drawing.Color.Black;
            this.extendedLabel2.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.extendedLabel2.BorderDrawingStyle = Binarymission.WinForms.Controls.ExtendedLabel.BorderStyle.Thin;
            this.extendedLabel2.DropShadowGradientFloatAngle = 45F;
            this.extendedLabel2.DropShadowMargin = 6;
            this.extendedLabel2.EndLinearGradientBackgroundColor = System.Drawing.Color.White;
            this.extendedLabel2.EndLinearGradientDropShadowBackgroundColor = System.Drawing.Color.LightGray;
            this.extendedLabel2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extendedLabel2.IsBackgroundTransparent = false;
            this.extendedLabel2.Location = new System.Drawing.Point(21, 147);
            this.extendedLabel2.Name = "extendedLabel2";
            this.extendedLabel2.Orientation = Binarymission.WinForms.Controls.ExtendedLabel.DrawingOrientation.Horizontal;
            this.extendedLabel2.ShouldDrawBorder = true;
            this.extendedLabel2.ShouldDrawDropShadow = true;
            this.extendedLabel2.ShouldRefreshUponParentMoveResize = false;
            this.extendedLabel2.Size = new System.Drawing.Size(416, 97);
            this.extendedLabel2.StartLinearGradientBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.extendedLabel2.StartLinearGradientDropShadowBackgroundColor = System.Drawing.Color.Gray;
            stringFormat10.Alignment = System.Drawing.StringAlignment.Center;
            stringFormat10.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat10.LineAlignment = System.Drawing.StringAlignment.Center;
            stringFormat10.Trimming = System.Drawing.StringTrimming.Character;
            this.extendedLabel2.StringFormat = stringFormat10;
            this.extendedLabel2.TabIndex = 1;
            this.extendedLabel2.TabStop = false;
            this.extendedLabel2.Text = "I can automatically display text in multiple lines, draw a drop-shadow, and orien" +
    "ted horizontally.\r\nThere are many more options that can be set, including String" +
    " formatting, colors, and border setup.";
            this.extendedLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.extendedLabel2.VerticalTextDirection = Binarymission.WinForms.Controls.ExtendedLabel.TextDirection.TopBottom;
            // 
            // extendedLabel1
            // 
            this.extendedLabel1.BackgroundGradientFloatAngle = 0F;
            this.extendedLabel1.BorderColor = System.Drawing.Color.Black;
            this.extendedLabel1.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.extendedLabel1.BorderDrawingStyle = Binarymission.WinForms.Controls.ExtendedLabel.BorderStyle.Thin;
            this.extendedLabel1.DropShadowGradientFloatAngle = 45F;
            this.extendedLabel1.DropShadowMargin = 6;
            this.extendedLabel1.EndLinearGradientBackgroundColor = System.Drawing.Color.White;
            this.extendedLabel1.EndLinearGradientDropShadowBackgroundColor = System.Drawing.Color.LightGray;
            this.extendedLabel1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extendedLabel1.IsBackgroundTransparent = false;
            this.extendedLabel1.Location = new System.Drawing.Point(21, 45);
            this.extendedLabel1.Name = "extendedLabel1";
            this.extendedLabel1.Orientation = Binarymission.WinForms.Controls.ExtendedLabel.DrawingOrientation.Horizontal;
            this.extendedLabel1.ShouldDrawBorder = true;
            this.extendedLabel1.ShouldDrawDropShadow = true;
            this.extendedLabel1.ShouldRefreshUponParentMoveResize = false;
            this.extendedLabel1.Size = new System.Drawing.Size(416, 94);
            this.extendedLabel1.StartLinearGradientBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.extendedLabel1.StartLinearGradientDropShadowBackgroundColor = System.Drawing.Color.Gray;
            stringFormat11.Alignment = System.Drawing.StringAlignment.Center;
            stringFormat11.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat11.LineAlignment = System.Drawing.StringAlignment.Center;
            stringFormat11.Trimming = System.Drawing.StringTrimming.Character;
            this.extendedLabel1.StringFormat = stringFormat11;
            this.extendedLabel1.TabIndex = 0;
            this.extendedLabel1.TabStop = false;
            this.extendedLabel1.Text = "I can automatically display text in multiple lines, draw a drop-shadow, and orien" +
    "ted horizontally.\r\nThere are many more options that can be set, including String" +
    " formatting, colors, and border setup.";
            this.extendedLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.extendedLabel1.VerticalTextDirection = Binarymission.WinForms.Controls.ExtendedLabel.TextDirection.TopBottom;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(563, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Binarymission ExtendedLabel .NET control instances in different modes, colors, et" +
    "c.:";
            // 
            // extendedLabel12
            // 
            this.extendedLabel12.BackgroundGradientFloatAngle = 0F;
            this.extendedLabel12.BorderColor = System.Drawing.Color.Black;
            this.extendedLabel12.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.extendedLabel12.BorderDrawingStyle = Binarymission.WinForms.Controls.ExtendedLabel.BorderStyle.None;
            this.extendedLabel12.DropShadowGradientFloatAngle = 45F;
            this.extendedLabel12.DropShadowMargin = 6;
            this.extendedLabel12.EndLinearGradientBackgroundColor = System.Drawing.SystemColors.Control;
            this.extendedLabel12.EndLinearGradientDropShadowBackgroundColor = System.Drawing.Color.LightGray;
            this.extendedLabel12.IsBackgroundTransparent = false;
            this.extendedLabel12.Location = new System.Drawing.Point(207, 483);
            this.extendedLabel12.Name = "extendedLabel12";
            this.extendedLabel12.Orientation = Binarymission.WinForms.Controls.ExtendedLabel.DrawingOrientation.Horizontal;
            this.extendedLabel12.ShouldDrawBorder = true;
            this.extendedLabel12.ShouldDrawDropShadow = true;
            this.extendedLabel12.ShouldRefreshUponParentMoveResize = false;
            this.extendedLabel12.Size = new System.Drawing.Size(75, 23);
            this.extendedLabel12.StartLinearGradientBackgroundColor = System.Drawing.SystemColors.Control;
            this.extendedLabel12.StartLinearGradientDropShadowBackgroundColor = System.Drawing.Color.Gray;
            stringFormat12.Alignment = System.Drawing.StringAlignment.Center;
            stringFormat12.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat12.LineAlignment = System.Drawing.StringAlignment.Center;
            stringFormat12.Trimming = System.Drawing.StringTrimming.Character;
            this.extendedLabel12.StringFormat = stringFormat12;
            this.extendedLabel12.TabIndex = 16;
            this.extendedLabel12.TabStop = false;
            this.extendedLabel12.Text = "extendedLabel12";
            this.extendedLabel12.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.extendedLabel12.VerticalTextDirection = Binarymission.WinForms.Controls.ExtendedLabel.TextDirection.TopBottom;
            // 
            // LabelOptionsDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundDisabledCloseCommandButton.Color = System.Drawing.Color.SlateGray;
            this.BackgroundDisabledMaximizeRestoreCommandButton.Color = System.Drawing.Color.SlateGray;
            this.BackgroundDisabledMinimizeCommandButton.Color = System.Drawing.Color.SlateGray;
            this.BackgroundHotCloseCommandButton.Color = System.Drawing.Color.SlateGray;
            this.BackgroundHotMaximizeRestoreCommandButton.Color = System.Drawing.Color.SlateGray;
            this.BackgroundHotMinimizeCommandButton.Color = System.Drawing.Color.SlateGray;
            this.BackgroundNormalCloseCommandButton.Color = System.Drawing.Color.SlateGray;
            this.BackgroundNormalMaximizeRestoreCommandButton.Color = System.Drawing.Color.SlateGray;
            this.BackgroundNormalMinimizeCommandButton.Color = System.Drawing.Color.SlateGray;
            this.BackgroundPressedCloseCommandButton.Color = System.Drawing.Color.SlateGray;
            this.BackgroundPressedMaximizeRestoreCommandButton.Color = System.Drawing.Color.SlateGray;
            this.BackgroundPressedMinimizeCommandButton.Color = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1065, 634);
            this.Controls.Add(this.extendedLabel12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.appExitInvoker);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.extendedLabel11);
            this.Controls.Add(this.extendedLabel10);
            this.Controls.Add(this.extendedLabel9);
            this.Controls.Add(this.extendedLabel8);
            this.Controls.Add(this.extendedLabel7);
            this.Controls.Add(this.extendedLabel5);
            this.Controls.Add(this.extendedLabel6);
            this.Controls.Add(this.extendedLabel4);
            this.Controls.Add(this.extendedLabel3);
            this.Controls.Add(this.extendedLabel2);
            this.Controls.Add(this.extendedLabel1);
            this.DefaultNormalWindowSize = new System.Drawing.Size(300, 300);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LabelOptionsDemoForm";
            this.TitlebarText = "Binarymission ExtendedLabel .NET control Demo.";
            this.WindowChromeTitleTextBrush.Color = System.Drawing.Color.SlateGray;
            this.WindowChromeTitleTextBrushWhenTitlebarBackgroundIsTransparent.Color = System.Drawing.Color.SlateGray;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Binarymission.WinForms.Controls.ExtendedLabel extendedLabel1;
        private Binarymission.WinForms.Controls.ExtendedLabel extendedLabel2;
        private Binarymission.WinForms.Controls.ExtendedLabel extendedLabel3;
        private Binarymission.WinForms.Controls.ExtendedLabel extendedLabel4;
        private Binarymission.WinForms.Controls.ExtendedLabel extendedLabel6;
        private Binarymission.WinForms.Controls.ExtendedLabel extendedLabel5;
        private Binarymission.WinForms.Controls.ExtendedLabel extendedLabel7;
        private System.Windows.Forms.CheckBox chkEnableDropShadow;
        private Binarymission.WinForms.Controls.ExtendedLabel extendedLabel8;
        private Binarymission.WinForms.Controls.ExtendedLabel extendedLabel9;
        private Binarymission.WinForms.Controls.ExtendedLabel extendedLabel10;
        private Binarymission.WinForms.Controls.ExtendedLabel extendedLabel11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button appExitInvoker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button borderColourInvoker;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DomainUpDown borderThicknessSelector;
        private System.Windows.Forms.DomainUpDown horizontalAlignmentSelector;
        private System.Windows.Forms.DomainUpDown verticalAlignmentSelector;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Binarymission.WinForms.Controls.ExtendedLabel extendedLabel12;
    }
}

