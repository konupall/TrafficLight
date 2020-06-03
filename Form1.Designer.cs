namespace TrafficLight
{
    partial class TrafficLight
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
            this.components = new System.ComponentModel.Container();
            this.ColorRed = new System.Windows.Forms.PictureBox();
            this.ColorYlw = new System.Windows.Forms.PictureBox();
            this.ColorGrn = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RedOvr = new System.Windows.Forms.Button();
            this.YlwOvr = new System.Windows.Forms.Button();
            this.GrnOvr = new System.Windows.Forms.Button();
            this.MnlOvr = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NightMode = new System.Windows.Forms.Button();
            this.DayOperator = new System.Windows.Forms.Button();
            this.StopAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ColorRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorYlw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorGrn)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorRed
            // 
            this.ColorRed.Location = new System.Drawing.Point(141, 4);
            this.ColorRed.Name = "ColorRed";
            this.ColorRed.Size = new System.Drawing.Size(155, 155);
            this.ColorRed.TabIndex = 0;
            this.ColorRed.TabStop = false;
            // 
            // ColorYlw
            // 
            this.ColorYlw.Location = new System.Drawing.Point(141, 165);
            this.ColorYlw.Name = "ColorYlw";
            this.ColorYlw.Size = new System.Drawing.Size(155, 155);
            this.ColorYlw.TabIndex = 1;
            this.ColorYlw.TabStop = false;
            // 
            // ColorGrn
            // 
            this.ColorGrn.Location = new System.Drawing.Point(141, 326);
            this.ColorGrn.Name = "ColorGrn";
            this.ColorGrn.Size = new System.Drawing.Size(155, 155);
            this.ColorGrn.TabIndex = 2;
            this.ColorGrn.TabStop = false;
            // 
            // RedOvr
            // 
            this.RedOvr.Location = new System.Drawing.Point(461, 45);
            this.RedOvr.Name = "RedOvr";
            this.RedOvr.Size = new System.Drawing.Size(60, 60);
            this.RedOvr.TabIndex = 3;
            this.RedOvr.Text = "Red Override";
            this.RedOvr.UseVisualStyleBackColor = true;
            this.RedOvr.Click += new System.EventHandler(this.button1_Click);
            // 
            // YlwOvr
            // 
            this.YlwOvr.Location = new System.Drawing.Point(527, 45);
            this.YlwOvr.Name = "YlwOvr";
            this.YlwOvr.Size = new System.Drawing.Size(60, 60);
            this.YlwOvr.TabIndex = 4;
            this.YlwOvr.Text = "Yellow Override";
            this.YlwOvr.UseVisualStyleBackColor = true;
            this.YlwOvr.Click += new System.EventHandler(this.YlwOvr_Click);
            // 
            // GrnOvr
            // 
            this.GrnOvr.Location = new System.Drawing.Point(593, 45);
            this.GrnOvr.Name = "GrnOvr";
            this.GrnOvr.Size = new System.Drawing.Size(60, 60);
            this.GrnOvr.TabIndex = 5;
            this.GrnOvr.Text = "Green Override";
            this.GrnOvr.UseVisualStyleBackColor = true;
            this.GrnOvr.Click += new System.EventHandler(this.GrnOvr_Click);
            // 
            // MnlOvr
            // 
            this.MnlOvr.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnlOvr.Location = new System.Drawing.Point(302, 4);
            this.MnlOvr.Name = "MnlOvr";
            this.MnlOvr.Size = new System.Drawing.Size(154, 477);
            this.MnlOvr.TabIndex = 6;
            this.MnlOvr.Text = "Manual Override";
            this.MnlOvr.UseVisualStyleBackColor = true;
            this.MnlOvr.Click += new System.EventHandler(this.MnlOvr_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(461, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(192, 25);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Manual Override Control Panel";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NightMode
            // 
            this.NightMode.Location = new System.Drawing.Point(461, 111);
            this.NightMode.Name = "NightMode";
            this.NightMode.Size = new System.Drawing.Size(60, 60);
            this.NightMode.TabIndex = 8;
            this.NightMode.Text = "Night";
            this.NightMode.UseVisualStyleBackColor = true;
            this.NightMode.Click += new System.EventHandler(this.NightMode_Click);
            // 
            // DayOperator
            // 
            this.DayOperator.Location = new System.Drawing.Point(527, 111);
            this.DayOperator.Name = "DayOperator";
            this.DayOperator.Size = new System.Drawing.Size(60, 60);
            this.DayOperator.TabIndex = 9;
            this.DayOperator.Text = "Day";
            this.DayOperator.UseVisualStyleBackColor = true;
            this.DayOperator.Click += new System.EventHandler(this.DayOperator_Click);
            // 
            // StopAll
            // 
            this.StopAll.Location = new System.Drawing.Point(461, 419);
            this.StopAll.Name = "StopAll";
            this.StopAll.Size = new System.Drawing.Size(192, 60);
            this.StopAll.TabIndex = 10;
            this.StopAll.Text = "EMERGENCY STOP";
            this.StopAll.UseVisualStyleBackColor = true;
            this.StopAll.Click += new System.EventHandler(this.StopAll_Click);
            // 
            // TrafficLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 491);
            this.Controls.Add(this.StopAll);
            this.Controls.Add(this.DayOperator);
            this.Controls.Add(this.NightMode);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MnlOvr);
            this.Controls.Add(this.GrnOvr);
            this.Controls.Add(this.YlwOvr);
            this.Controls.Add(this.RedOvr);
            this.Controls.Add(this.ColorGrn);
            this.Controls.Add(this.ColorYlw);
            this.Controls.Add(this.ColorRed);
            this.Name = "TrafficLight";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ColorRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorYlw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorGrn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ColorRed;
        private System.Windows.Forms.PictureBox ColorYlw;
        private System.Windows.Forms.PictureBox ColorGrn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button RedOvr;
        private System.Windows.Forms.Button YlwOvr;
        private System.Windows.Forms.Button GrnOvr;
        private System.Windows.Forms.Button MnlOvr;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button NightMode;
        private System.Windows.Forms.Button DayOperator;
        private System.Windows.Forms.Button StopAll;
    }
}

