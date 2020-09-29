namespace TransparentNonClientAreaWindowDemo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtnNoTransparency = new System.Windows.Forms.RadioButton();
            this.rdbtnTitlebarAndBorderTransparent = new System.Windows.Forms.RadioButton();
            this.rdbtnTitlebarTransparent = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnNoTransparency);
            this.groupBox1.Controls.Add(this.rdbtnTitlebarAndBorderTransparent);
            this.groupBox1.Controls.Add(this.rdbtnTitlebarTransparent);
            this.groupBox1.Location = new System.Drawing.Point(93, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Non-client area transparency options";
            // 
            // rdbtnNoTransparency
            // 
            this.rdbtnNoTransparency.AutoSize = true;
            this.rdbtnNoTransparency.Checked = true;
            this.rdbtnNoTransparency.Location = new System.Drawing.Point(21, 29);
            this.rdbtnNoTransparency.Name = "rdbtnNoTransparency";
            this.rdbtnNoTransparency.Size = new System.Drawing.Size(103, 17);
            this.rdbtnNoTransparency.TabIndex = 2;
            this.rdbtnNoTransparency.TabStop = true;
            this.rdbtnNoTransparency.Text = "No transparency";
            this.rdbtnNoTransparency.UseVisualStyleBackColor = true;
            this.rdbtnNoTransparency.CheckedChanged += new System.EventHandler(this.NoTransparencyCheckedChanged);
            // 
            // rdbtnTitlebarAndBorderTransparent
            // 
            this.rdbtnTitlebarAndBorderTransparent.AutoSize = true;
            this.rdbtnTitlebarAndBorderTransparent.Location = new System.Drawing.Point(267, 50);
            this.rdbtnTitlebarAndBorderTransparent.Name = "rdbtnTitlebarAndBorderTransparent";
            this.rdbtnTitlebarAndBorderTransparent.Size = new System.Drawing.Size(262, 17);
            this.rdbtnTitlebarAndBorderTransparent.TabIndex = 1;
            this.rdbtnTitlebarAndBorderTransparent.Text = "Make title bar and  border background transparent";
            this.rdbtnTitlebarAndBorderTransparent.UseVisualStyleBackColor = true;
            this.rdbtnTitlebarAndBorderTransparent.CheckedChanged += new System.EventHandler(this.TitlebarAndBorderTransparentCheckedChanged);
            // 
            // rdbtnTitlebarTransparent
            // 
            this.rdbtnTitlebarTransparent.AutoSize = true;
            this.rdbtnTitlebarTransparent.Location = new System.Drawing.Point(20, 50);
            this.rdbtnTitlebarTransparent.Name = "rdbtnTitlebarTransparent";
            this.rdbtnTitlebarTransparent.Size = new System.Drawing.Size(205, 17);
            this.rdbtnTitlebarTransparent.TabIndex = 0;
            this.rdbtnTitlebarTransparent.Text = "Make title bar background transparent";
            this.rdbtnTitlebarTransparent.UseVisualStyleBackColor = true;
            this.rdbtnTitlebarTransparent.CheckedChanged += new System.EventHandler(this.TitlebarTransparentCheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ChromeTitlebarHeight = 48;
            this.ClientSize = new System.Drawing.Size(742, 310);
            this.Controls.Add(this.groupBox1);
            this.DefaultNormalWindowSize = new System.Drawing.Size(300, 300);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.TitlebarText = "ModernChromeWindow Chrome Transparency features demo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtnTitlebarAndBorderTransparent;
        private System.Windows.Forms.RadioButton rdbtnTitlebarTransparent;
        private System.Windows.Forms.RadioButton rdbtnNoTransparency;
    }
}

