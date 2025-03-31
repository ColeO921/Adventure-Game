namespace Adventure_Game
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.option2Button = new System.Windows.Forms.Button();
            this.option1Button = new System.Windows.Forms.Button();
            this.option1Label = new System.Windows.Forms.Label();
            this.option2Label = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.red2 = new System.Windows.Forms.Label();
            this.option3Button = new System.Windows.Forms.Button();
            this.option3Label = new System.Windows.Forms.Label();
            this.endingLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.red1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.deco2 = new System.Windows.Forms.PictureBox();
            this.pictureOutput = new System.Windows.Forms.PictureBox();
            this.deco1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deco2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deco1)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Mongolian Baiti", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(160, 38);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(853, 90);
            this.outputLabel.TabIndex = 2;
            // 
            // option2Button
            // 
            this.option2Button.Font = new System.Drawing.Font("Mongolian Baiti", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Button.Location = new System.Drawing.Point(171, 710);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(133, 48);
            this.option2Button.TabIndex = 4;
            this.option2Button.Text = "Option 2";
            this.option2Button.UseVisualStyleBackColor = true;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option1Button
            // 
            this.option1Button.Font = new System.Drawing.Font("Mongolian Baiti", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Button.Location = new System.Drawing.Point(171, 641);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(133, 48);
            this.option1Button.TabIndex = 5;
            this.option1Button.Text = "Option 1";
            this.option1Button.UseVisualStyleBackColor = true;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // option1Label
            // 
            this.option1Label.Font = new System.Drawing.Font("Mongolian Baiti", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Label.Location = new System.Drawing.Point(334, 643);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(306, 46);
            this.option1Label.TabIndex = 6;
            // 
            // option2Label
            // 
            this.option2Label.Font = new System.Drawing.Font("Mongolian Baiti", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Label.Location = new System.Drawing.Point(334, 710);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(306, 48);
            this.option2Label.TabIndex = 7;
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Mongolian Baiti", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(320, 576);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(519, 51);
            this.questionLabel.TabIndex = 8;
            // 
            // red2
            // 
            this.red2.BackColor = System.Drawing.Color.IndianRed;
            this.red2.Location = new System.Drawing.Point(1100, 150);
            this.red2.Name = "red2";
            this.red2.Size = new System.Drawing.Size(11, 493);
            this.red2.TabIndex = 12;
            // 
            // option3Button
            // 
            this.option3Button.Font = new System.Drawing.Font("Mongolian Baiti", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3Button.Location = new System.Drawing.Point(666, 678);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(133, 48);
            this.option3Button.TabIndex = 13;
            this.option3Button.Text = "Option 3";
            this.option3Button.UseVisualStyleBackColor = true;
            this.option3Button.Click += new System.EventHandler(this.option3Button_Click);
            // 
            // option3Label
            // 
            this.option3Label.Font = new System.Drawing.Font("Mongolian Baiti", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3Label.Location = new System.Drawing.Point(805, 678);
            this.option3Label.Name = "option3Label";
            this.option3Label.Size = new System.Drawing.Size(306, 46);
            this.option3Label.TabIndex = 14;
            // 
            // endingLabel
            // 
            this.endingLabel.Font = new System.Drawing.Font("Mongolian Baiti", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endingLabel.Location = new System.Drawing.Point(919, 590);
            this.endingLabel.Name = "endingLabel";
            this.endingLabel.Size = new System.Drawing.Size(202, 37);
            this.endingLabel.TabIndex = 15;
            this.endingLabel.Text = "Ending\'s 0/13";
            // 
            // red1
            // 
            this.red1.BackColor = System.Drawing.Color.IndianRed;
            this.red1.Location = new System.Drawing.Point(60, 143);
            this.red1.Name = "red1";
            this.red1.Size = new System.Drawing.Size(11, 500);
            this.red1.TabIndex = 20;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Adventure_Game.Properties.Resources.formDeco3_removebg_preview;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(-19, 646);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(173, 134);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Adventure_Game.Properties.Resources.formDeco3_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1009, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 134);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // deco2
            // 
            this.deco2.BackgroundImage = global::Adventure_Game.Properties.Resources.formDeco1;
            this.deco2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deco2.Location = new System.Drawing.Point(1009, 656);
            this.deco2.Name = "deco2";
            this.deco2.Size = new System.Drawing.Size(173, 134);
            this.deco2.TabIndex = 19;
            this.deco2.TabStop = false;
            // 
            // pictureOutput
            // 
            this.pictureOutput.BackColor = System.Drawing.SystemColors.Control;
            this.pictureOutput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureOutput.Location = new System.Drawing.Point(160, 143);
            this.pictureOutput.Name = "pictureOutput";
            this.pictureOutput.Size = new System.Drawing.Size(876, 430);
            this.pictureOutput.TabIndex = 16;
            this.pictureOutput.TabStop = false;
            // 
            // deco1
            // 
            this.deco1.BackgroundImage = global::Adventure_Game.Properties.Resources.formDeco1;
            this.deco1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deco1.Location = new System.Drawing.Point(-19, 12);
            this.deco1.Name = "deco1";
            this.deco1.Size = new System.Drawing.Size(173, 134);
            this.deco1.TabIndex = 17;
            this.deco1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1161, 792);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.red1);
            this.Controls.Add(this.deco2);
            this.Controls.Add(this.pictureOutput);
            this.Controls.Add(this.option3Label);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.red2);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.deco1);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.endingLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deco2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deco1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label red2;
        private System.Windows.Forms.Button option3Button;
        private System.Windows.Forms.Label option3Label;
        private System.Windows.Forms.Label endingLabel;
        private System.Windows.Forms.PictureBox pictureOutput;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox deco1;
        private System.Windows.Forms.PictureBox deco2;
        private System.Windows.Forms.Label red1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

