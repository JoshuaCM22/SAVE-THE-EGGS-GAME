namespace SAVE_THE_EGGS_GAME
{
    partial class Form_HighScores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_HighScores));
            this.btnBack = new System.Windows.Forms.Button();
            this.lblRankHeaderAndContent = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDateHeaderAndContent = new System.Windows.Forms.Label();
            this.lblScoreHeaderAndContent = new System.Windows.Forms.Label();
            this.lblTop10Only = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(23, 504);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(146, 47);
            this.btnBack.TabIndex = 0;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblRankHeaderAndContent
            // 
            this.lblRankHeaderAndContent.AutoSize = true;
            this.lblRankHeaderAndContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRankHeaderAndContent.ForeColor = System.Drawing.Color.White;
            this.lblRankHeaderAndContent.Location = new System.Drawing.Point(79, 136);
            this.lblRankHeaderAndContent.Name = "lblRankHeaderAndContent";
            this.lblRankHeaderAndContent.Size = new System.Drawing.Size(62, 25);
            this.lblRankHeaderAndContent.TabIndex = 0;
            this.lblRankHeaderAndContent.Text = "Rank";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(177, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(249, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HIGH SCORES";
            // 
            // lblDateHeaderAndContent
            // 
            this.lblDateHeaderAndContent.AutoSize = true;
            this.lblDateHeaderAndContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateHeaderAndContent.ForeColor = System.Drawing.Color.White;
            this.lblDateHeaderAndContent.Location = new System.Drawing.Point(254, 136);
            this.lblDateHeaderAndContent.Name = "lblDateHeaderAndContent";
            this.lblDateHeaderAndContent.Size = new System.Drawing.Size(93, 25);
            this.lblDateHeaderAndContent.TabIndex = 0;
            this.lblDateHeaderAndContent.Text = "      Date";
            // 
            // lblScoreHeaderAndContent
            // 
            this.lblScoreHeaderAndContent.AutoSize = true;
            this.lblScoreHeaderAndContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreHeaderAndContent.ForeColor = System.Drawing.Color.White;
            this.lblScoreHeaderAndContent.Location = new System.Drawing.Point(473, 136);
            this.lblScoreHeaderAndContent.Name = "lblScoreHeaderAndContent";
            this.lblScoreHeaderAndContent.Size = new System.Drawing.Size(68, 25);
            this.lblScoreHeaderAndContent.TabIndex = 0;
            this.lblScoreHeaderAndContent.Text = "Score";
            // 
            // lblTop10Only
            // 
            this.lblTop10Only.AutoSize = true;
            this.lblTop10Only.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop10Only.ForeColor = System.Drawing.Color.White;
            this.lblTop10Only.Location = new System.Drawing.Point(233, 82);
            this.lblTop10Only.Name = "lblTop10Only";
            this.lblTop10Only.Size = new System.Drawing.Size(155, 29);
            this.lblTop10Only.TabIndex = 1;
            this.lblTop10Only.Text = "Top 10 Only";
            // 
            // Form_HighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(614, 575);
            this.Controls.Add(this.lblTop10Only);
            this.Controls.Add(this.lblScoreHeaderAndContent);
            this.Controls.Add(this.lblDateHeaderAndContent);
            this.Controls.Add(this.lblRankHeaderAndContent);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_HighScores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAVE THE EGGS GAME";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_HighScores_FormClosed);
            this.Load += new System.EventHandler(this.Form_HighScores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblRankHeaderAndContent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDateHeaderAndContent;
        private System.Windows.Forms.Label lblScoreHeaderAndContent;
        private System.Windows.Forms.Label lblTop10Only;
    }
}