﻿namespace TrafficLight
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
            this.ColorRed = new System.Windows.Forms.PictureBox();
            this.ColorYlw = new System.Windows.Forms.PictureBox();
            this.ColorGrn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ColorRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorYlw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorGrn)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorRed
            // 
            this.ColorRed.Location = new System.Drawing.Point(12, 12);
            this.ColorRed.Name = "ColorRed";
            this.ColorRed.Size = new System.Drawing.Size(155, 155);
            this.ColorRed.TabIndex = 0;
            this.ColorRed.TabStop = false;
            // 
            // ColorYlw
            // 
            this.ColorYlw.Location = new System.Drawing.Point(12, 173);
            this.ColorYlw.Name = "ColorYlw";
            this.ColorYlw.Size = new System.Drawing.Size(155, 155);
            this.ColorYlw.TabIndex = 1;
            this.ColorYlw.TabStop = false;
            // 
            // ColorGrn
            // 
            this.ColorGrn.Location = new System.Drawing.Point(12, 334);
            this.ColorGrn.Name = "ColorGrn";
            this.ColorGrn.Size = new System.Drawing.Size(155, 155);
            this.ColorGrn.TabIndex = 2;
            this.ColorGrn.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.ColorGrn);
            this.Controls.Add(this.ColorYlw);
            this.Controls.Add(this.ColorRed);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ColorRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorYlw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorGrn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ColorRed;
        private System.Windows.Forms.PictureBox ColorYlw;
        private System.Windows.Forms.PictureBox ColorGrn;
    }
}
