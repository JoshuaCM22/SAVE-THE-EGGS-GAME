namespace SAVE_THE_EGGS_GAME
{
    partial class Form_Introduction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Introduction));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblInstructionsAndControls = new System.Windows.Forms.Label();
            this.btnHighScores = new System.Windows.Forms.Button();
            this.pbAudio = new System.Windows.Forms.PictureBox();
            this.pbChicken = new System.Windows.Forms.PictureBox();
            this.pbEgg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAudio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChicken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEgg)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(80, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(459, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SAVE THE EGGS GAME";
            // 
            // btnPlay
            // 
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(177, 477);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(257, 52);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.TabStop = false;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblInstructionsAndControls
            // 
            this.lblInstructionsAndControls.AutoSize = true;
            this.lblInstructionsAndControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructionsAndControls.ForeColor = System.Drawing.Color.White;
            this.lblInstructionsAndControls.Location = new System.Drawing.Point(53, 309);
            this.lblInstructionsAndControls.Name = "lblInstructionsAndControls";
            this.lblInstructionsAndControls.Size = new System.Drawing.Size(524, 125);
            this.lblInstructionsAndControls.TabIndex = 0;
            this.lblInstructionsAndControls.Text = resources.GetString("lblInstructionsAndControls.Text");
            // 
            // btnHighScores
            // 
            this.btnHighScores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHighScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighScores.Location = new System.Drawing.Point(177, 547);
            this.btnHighScores.Name = "btnHighScores";
            this.btnHighScores.Size = new System.Drawing.Size(257, 52);
            this.btnHighScores.TabIndex = 0;
            this.btnHighScores.TabStop = false;
            this.btnHighScores.Text = "HIGH SCORES";
            this.btnHighScores.UseVisualStyleBackColor = true;
            this.btnHighScores.Click += new System.EventHandler(this.btnHighScores_Click);
            // 
            // pbAudio
            // 
            this.pbAudio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAudio.Image = global::SAVE_THE_EGGS_GAME.Properties.Resources.unmuted;
            this.pbAudio.Location = new System.Drawing.Point(547, 574);
            this.pbAudio.Name = "pbAudio";
            this.pbAudio.Size = new System.Drawing.Size(57, 50);
            this.pbAudio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAudio.TabIndex = 11;
            this.pbAudio.TabStop = false;
            this.pbAudio.Tag = "";
            this.pbAudio.Click += new System.EventHandler(this.pbAudio_Click);
            // 
            // pbChicken
            // 
            this.pbChicken.Image = global::SAVE_THE_EGGS_GAME.Properties.Resources.chicken_normal;
            this.pbChicken.Location = new System.Drawing.Point(222, 190);
            this.pbChicken.Name = "pbChicken";
            this.pbChicken.Size = new System.Drawing.Size(85, 80);
            this.pbChicken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChicken.TabIndex = 7;
            this.pbChicken.TabStop = false;
            // 
            // pbEgg
            // 
            this.pbEgg.Image = ((System.Drawing.Image)(resources.GetObject("pbEgg.Image")));
            this.pbEgg.Location = new System.Drawing.Point(339, 96);
            this.pbEgg.Name = "pbEgg";
            this.pbEgg.Size = new System.Drawing.Size(40, 50);
            this.pbEgg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEgg.TabIndex = 6;
            this.pbEgg.TabStop = false;
            this.pbEgg.Tag = "";
            // 
            // Form_Introduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(614, 631);
            this.Controls.Add(this.pbAudio);
            this.Controls.Add(this.btnHighScores);
            this.Controls.Add(this.lblInstructionsAndControls);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pbChicken);
            this.Controls.Add(this.pbEgg);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Introduction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAVE THE EGGS GAME";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Introduction_FormClosed);
            this.Load += new System.EventHandler(this.Form_Introduction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAudio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChicken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEgg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbChicken;
        private System.Windows.Forms.PictureBox pbEgg;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblInstructionsAndControls;
        private System.Windows.Forms.Button btnHighScores;
        private System.Windows.Forms.PictureBox pbAudio;
    }
}