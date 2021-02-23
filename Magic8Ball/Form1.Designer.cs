namespace Magic8Ball
{
    partial class titleLabel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(titleLabel));
            this.eightBallButton = new System.Windows.Forms.Button();
            this.thinkLabel = new System.Windows.Forms.Label();
            this.magicBallOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eightBallButton
            // 
            this.eightBallButton.BackColor = System.Drawing.Color.Transparent;
            this.eightBallButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eightBallButton.BackgroundImage")));
            this.eightBallButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eightBallButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eightBallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eightBallButton.ForeColor = System.Drawing.Color.Transparent;
            this.eightBallButton.Location = new System.Drawing.Point(0, 0);
            this.eightBallButton.Name = "eightBallButton";
            this.eightBallButton.Size = new System.Drawing.Size(388, 450);
            this.eightBallButton.TabIndex = 0;
            this.eightBallButton.UseVisualStyleBackColor = false;
            this.eightBallButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // thinkLabel
            // 
            this.thinkLabel.AutoSize = true;
            this.thinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thinkLabel.Location = new System.Drawing.Point(95, 34);
            this.thinkLabel.Name = "thinkLabel";
            this.thinkLabel.Size = new System.Drawing.Size(192, 24);
            this.thinkLabel.TabIndex = 1;
            this.thinkLabel.Text = "Think of a Question";
            // 
            // magicBallOutput
            // 
            this.magicBallOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magicBallOutput.Location = new System.Drawing.Point(12, 400);
            this.magicBallOutput.Name = "magicBallOutput";
            this.magicBallOutput.Size = new System.Drawing.Size(364, 27);
            this.magicBallOutput.TabIndex = 2;
            this.magicBallOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(388, 450);
            this.Controls.Add(this.magicBallOutput);
            this.Controls.Add(this.thinkLabel);
            this.Controls.Add(this.eightBallButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "titleLabel";
            this.Text = "Magic 8 Ball";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button eightBallButton;
        private System.Windows.Forms.Label thinkLabel;
        private System.Windows.Forms.Label magicBallOutput;
    }
}

