namespace Marquee
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
            this.marqueeBorder2 = new Marquee.MarqueeBorder();
            this.marqueeText3 = new Marquee.MarqueeText();
            this.marqueeBorder1 = new Marquee.MarqueeBorder();
            this.component11 = new Marquee.Component1();
            this.marqueeBorder2.SuspendLayout();
            this.SuspendLayout();
            // 
            // marqueeBorder2
            // 
            this.marqueeBorder2.Controls.Add(this.marqueeText3);
            this.marqueeBorder2.DarkColor = System.Drawing.SystemColors.Control;
            this.marqueeBorder2.Enabled = true;
            this.marqueeBorder2.LightColor = System.Drawing.SystemColors.ControlText;
            this.marqueeBorder2.LightPeriod = 3;
            this.marqueeBorder2.LightShape = Marquee.MarqueeLightShape.Square;
            this.marqueeBorder2.LightSize = 5;
            this.marqueeBorder2.LightSpacing = 1;
            this.marqueeBorder2.Location = new System.Drawing.Point(365, 147);
            this.marqueeBorder2.Name = "marqueeBorder2";
            this.marqueeBorder2.Size = new System.Drawing.Size(200, 100);
            this.marqueeBorder2.SpinDirection = Marquee.MarqueeSpinDirection.CW;
            this.marqueeBorder2.TabIndex = 4;
            this.marqueeBorder2.UpdatePeriod = 50;
            this.marqueeBorder2.Visible = true;
            // 
            // marqueeText3
            // 
            this.marqueeText3.AutoSize = true;
            this.marqueeText3.DarkColor = System.Drawing.SystemColors.Control;
            this.marqueeText3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.marqueeText3.LightColor = System.Drawing.SystemColors.ControlText;
            this.marqueeText3.Location = new System.Drawing.Point(15, 35);
            this.marqueeText3.Name = "marqueeText3";
            this.marqueeText3.Size = new System.Drawing.Size(75, 13);
            this.marqueeText3.TabIndex = 5;
            this.marqueeText3.Text = "marqueeText3";
            this.marqueeText3.UpdatePeriod = 50;
            // 
            // marqueeBorder1
            // 
            this.marqueeBorder1.DarkColor = System.Drawing.SystemColors.Control;
            this.marqueeBorder1.Enabled = true;
            this.marqueeBorder1.LightColor = System.Drawing.Color.Maroon;
            this.marqueeBorder1.LightPeriod = 6;
            this.marqueeBorder1.LightShape = Marquee.MarqueeLightShape.Circle;
            this.marqueeBorder1.LightSize = 8;
            this.marqueeBorder1.LightSpacing = 1;
            this.marqueeBorder1.Location = new System.Drawing.Point(12, 12);
            this.marqueeBorder1.Name = "marqueeBorder1";
            this.marqueeBorder1.Size = new System.Drawing.Size(395, 100);
            this.marqueeBorder1.SpinDirection = Marquee.MarqueeSpinDirection.CCW;
            this.marqueeBorder1.TabIndex = 0;
            this.marqueeBorder1.UpdatePeriod = 50;
            this.marqueeBorder1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.marqueeBorder2);
            this.Controls.Add(this.marqueeBorder1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.marqueeBorder2.ResumeLayout(false);
            this.marqueeBorder2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MarqueeBorder marqueeBorder1;
        private Component1 component11;
        private MarqueeBorder marqueeBorder2;
        private MarqueeText marqueeText3;
    }
}

