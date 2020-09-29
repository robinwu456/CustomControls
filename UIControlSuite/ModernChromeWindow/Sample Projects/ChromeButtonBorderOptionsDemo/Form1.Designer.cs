namespace ChromeButtonBorderOptionsDemo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.numGapBetweenChromeButtons = new System.Windows.Forms.NumericUpDown();
            this.btnExitApp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkShouldDrawButtonsBorder = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numGapBetweenChromeButtons)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set the gap between chrome command buttons:";
            // 
            // numGapBetweenChromeButtons
            // 
            this.numGapBetweenChromeButtons.Location = new System.Drawing.Point(277, 24);
            this.numGapBetweenChromeButtons.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numGapBetweenChromeButtons.Name = "numGapBetweenChromeButtons";
            this.numGapBetweenChromeButtons.Size = new System.Drawing.Size(49, 20);
            this.numGapBetweenChromeButtons.TabIndex = 1;
            this.numGapBetweenChromeButtons.ValueChanged += new System.EventHandler(this.NumGapBetweenChromeButtonsValueChanged);
            // 
            // btnExitApp
            // 
            this.btnExitApp.Location = new System.Drawing.Point(595, 100);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(94, 31);
            this.btnExitApp.TabIndex = 2;
            this.btnExitApp.Text = "Exit";
            this.btnExitApp.UseVisualStyleBackColor = true;
            this.btnExitApp.Click += new System.EventHandler(this.BtnExitAppClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkShouldDrawButtonsBorder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numGapBetweenChromeButtons);
            this.groupBox1.Location = new System.Drawing.Point(19, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 60);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chrome button border options";
            // 
            // chkShouldDrawButtonsBorder
            // 
            this.chkShouldDrawButtonsBorder.AutoSize = true;
            this.chkShouldDrawButtonsBorder.Location = new System.Drawing.Point(368, 27);
            this.chkShouldDrawButtonsBorder.Name = "chkShouldDrawButtonsBorder";
            this.chkShouldDrawButtonsBorder.Size = new System.Drawing.Size(277, 17);
            this.chkShouldDrawButtonsBorder.TabIndex = 2;
            this.chkShouldDrawButtonsBorder.Text = "Should draw border for the built-in command buttons?";
            this.chkShouldDrawButtonsBorder.UseVisualStyleBackColor = true;
            this.chkShouldDrawButtonsBorder.CheckedChanged += new System.EventHandler(this.ChkShouldDrawButtonsBorderCheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 183);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExitApp);
            this.DefaultNormalWindowSize = new System.Drawing.Size(300, 300);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.TitlebarText = "ModernWindowChrome Command buttons border options demo.";
            ((System.ComponentModel.ISupportInitialize)(this.numGapBetweenChromeButtons)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numGapBetweenChromeButtons;
        private System.Windows.Forms.Button btnExitApp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkShouldDrawButtonsBorder;
    }
}

