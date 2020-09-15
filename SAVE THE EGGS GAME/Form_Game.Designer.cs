namespace SAVE_THE_EGGS_GAME
{
    partial class Form_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Game));
            this.pbEgg1 = new System.Windows.Forms.PictureBox();
            this.pbEgg2 = new System.Windows.Forms.PictureBox();
            this.pbEgg3 = new System.Windows.Forms.PictureBox();
            this.pbChicken = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblMissed = new System.Windows.Forms.Label();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbEgg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEgg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEgg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChicken)).BeginInit();
            this.SuspendLayout();
            // 
            // pbEgg1
            // 
            this.pbEgg1.Image = global::SAVE_THE_EGGS_GAME.Properties.Resources.egg;
            this.pbEgg1.Location = new System.Drawing.Point(77, 80);
            this.pbEgg1.Name = "pbEgg1";
            this.pbEgg1.Size = new System.Drawing.Size(40, 50);
            this.pbEgg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEgg1.TabIndex = 0;
            this.pbEgg1.TabStop = false;
            this.pbEgg1.Tag = "eggs";
            // 
            // pbEgg2
            // 
            this.pbEgg2.Image = ((System.Drawing.Image)(resources.GetObject("pbEgg2.Image")));
            this.pbEgg2.Location = new System.Drawing.Point(248, 80);
            this.pbEgg2.Name = "pbEgg2";
            this.pbEgg2.Size = new System.Drawing.Size(40, 50);
            this.pbEgg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEgg2.TabIndex = 1;
            this.pbEgg2.TabStop = false;
            this.pbEgg2.Tag = "eggs";
            // 
            // pbEgg3
            // 
            this.pbEgg3.Image = ((System.Drawing.Image)(resources.GetObject("pbEgg3.Image")));
            this.pbEgg3.Location = new System.Drawing.Point(432, 80);
            this.pbEgg3.Name = "pbEgg3";
            this.pbEgg3.Size = new System.Drawing.Size(40, 50);
            this.pbEgg3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEgg3.TabIndex = 2;
            this.pbEgg3.TabStop = false;
            this.pbEgg3.Tag = "eggs";
            // 
            // pbChicken
            // 
            this.pbChicken.Image = global::SAVE_THE_EGGS_GAME.Properties.Resources.chicken_normal;
            this.pbChicken.Location = new System.Drawing.Point(259, 569);
            this.pbChicken.Name = "pbChicken";
            this.pbChicken.Size = new System.Drawing.Size(85, 80);
            this.pbChicken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChicken.TabIndex = 3;
            this.pbChicken.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(17, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(102, 29);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score: 0";
            // 
            // lblMissed
            // 
            this.lblMissed.AutoSize = true;
            this.lblMissed.BackColor = System.Drawing.Color.Transparent;
            this.lblMissed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissed.ForeColor = System.Drawing.Color.White;
            this.lblMissed.Location = new System.Drawing.Point(475, 9);
            this.lblMissed.Name = "lblMissed";
            this.lblMissed.Size = new System.Drawing.Size(116, 29);
            this.lblMissed.TabIndex = 5;
            this.lblMissed.Text = "Missed: 0";
            // 
            // timerGame
            // 
            this.timerGame.Enabled = true;
            this.timerGame.Interval = 20;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // Form_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(614, 661);
            this.Controls.Add(this.lblMissed);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbChicken);
            this.Controls.Add(this.pbEgg3);
            this.Controls.Add(this.pbEgg2);
            this.Controls.Add(this.pbEgg1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAVE THE EGGS GAME";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Game_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbEgg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEgg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEgg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChicken)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbEgg1;
        private System.Windows.Forms.PictureBox pbEgg2;
        private System.Windows.Forms.PictureBox pbEgg3;
        private System.Windows.Forms.PictureBox pbChicken;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblMissed;
        private System.Windows.Forms.Timer timerGame;
    }
}

