namespace Football_Game
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureOutput = new System.Windows.Forms.Label();
            this.option1Button = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.option2Button = new System.Windows.Forms.Button();
            this.option3Button = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(415, 57);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Football Draft";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // pictureOutput
            // 
            this.pictureOutput.AutoSize = true;
            this.pictureOutput.Location = new System.Drawing.Point(195, 153);
            this.pictureOutput.Name = "pictureOutput";
            this.pictureOutput.Size = new System.Drawing.Size(35, 13);
            this.pictureOutput.TabIndex = 2;
            this.pictureOutput.Text = "label2";
            // 
            // option1Button
            // 
            this.option1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.option1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option1Button.ForeColor = System.Drawing.Color.White;
            this.option1Button.Location = new System.Drawing.Point(63, 411);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(310, 23);
            this.option1Button.TabIndex = 4;
            this.option1Button.Text = "Buffalo Bills";
            this.option1Button.UseVisualStyleBackColor = true;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(20, 288);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(389, 103);
            this.outputLabel.TabIndex = 6;
            this.outputLabel.Text = "\r\n";
            // 
            // option2Button
            // 
            this.option2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.option2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option2Button.ForeColor = System.Drawing.Color.White;
            this.option2Button.Location = new System.Drawing.Point(63, 451);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(310, 23);
            this.option2Button.TabIndex = 7;
            this.option2Button.Text = "Kansas City Cheifs";
            this.option2Button.UseVisualStyleBackColor = true;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option3Button
            // 
            this.option3Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.option3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option3Button.ForeColor = System.Drawing.Color.White;
            this.option3Button.Location = new System.Drawing.Point(63, 489);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(310, 23);
            this.option3Button.TabIndex = 8;
            this.option3Button.UseVisualStyleBackColor = true;
            this.option3Button.Click += new System.EventHandler(this.option3Button_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Football_Game.Properties.Resources.draftPicture;
            this.pictureBox.Location = new System.Drawing.Point(63, 79);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(310, 206);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(439, 544);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.pictureOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Football Draft";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pictureOutput;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Button option3Button;
    }
}

