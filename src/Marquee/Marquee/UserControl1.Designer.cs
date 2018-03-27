namespace Marquee
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.marqueeBorder1 = new Marquee.MarqueeBorder();
            this.marqueeText1 = new Marquee.MarqueeText();
            this.button1 = new System.Windows.Forms.Button();
            this.marqueeBorder1.SuspendLayout();
            this.SuspendLayout();
            // 
            // marqueeBorder1
            // 
            this.marqueeBorder1.Controls.Add(this.button1);
            this.marqueeBorder1.Controls.Add(this.marqueeText1);
            this.marqueeBorder1.DarkColor = System.Drawing.SystemColors.Control;
            this.marqueeBorder1.Enabled = true;
            this.marqueeBorder1.LightColor = System.Drawing.SystemColors.ControlText;
            this.marqueeBorder1.LightPeriod = 3;
            this.marqueeBorder1.LightShape = Marquee.MarqueeLightShape.Square;
            this.marqueeBorder1.LightSize = 5;
            this.marqueeBorder1.LightSpacing = 1;
            this.marqueeBorder1.Location = new System.Drawing.Point(146, 38);
            this.marqueeBorder1.Name = "marqueeBorder1";
            this.marqueeBorder1.Size = new System.Drawing.Size(200, 100);
            this.marqueeBorder1.SpinDirection = Marquee.MarqueeSpinDirection.CW;
            this.marqueeBorder1.TabIndex = 0;
            this.marqueeBorder1.UpdatePeriod = 50;
            this.marqueeBorder1.Visible = true;
            // 
            // marqueeText1
            // 
            this.marqueeText1.AutoSize = true;
            this.marqueeText1.DarkColor = System.Drawing.SystemColors.Control;
            this.marqueeText1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.marqueeText1.LightColor = System.Drawing.SystemColors.ControlText;
            this.marqueeText1.Location = new System.Drawing.Point(32, 26);
            this.marqueeText1.Name = "marqueeText1";
            this.marqueeText1.Size = new System.Drawing.Size(75, 13);
            this.marqueeText1.TabIndex = 0;
            this.marqueeText1.Text = "marqueeText1";
            this.marqueeText1.UpdatePeriod = 50;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.marqueeBorder1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(493, 150);
            this.marqueeBorder1.ResumeLayout(false);
            this.marqueeBorder1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MarqueeBorder marqueeBorder1;
        private MarqueeText marqueeText1;
        private System.Windows.Forms.Button button1;
    }
}
