using System;
using System.Drawing;
using System.Windows.Forms;

namespace SAVE_THE_EGGS_GAME // Created by: Joshua C. Magoliman
{
    public partial class Form_Game : Form
    {
        #region Fields  
        private bool isGoLeft, isGoRight;
        private int speed = 8;
        private int score = 0;
        private int missedEggs = 0;
        private Random randomNumberForXaxis = new Random();
        private Random randomNumberForYaxis = new Random();
        private PictureBox pictureBox = new PictureBox();
        private string dateToday;
        private CustomAudio inGameAudio = new CustomAudio("introduction_and_in_game.wav");
        private CustomAudio gameOverAudio = new CustomAudio("gameover.wav");
        #endregion

        #region Constructor
        public Form_Game()
        {
            InitializeComponent();
            StartGame();
        }
        #endregion

        #region Event Handler Methods
        private void timerGame_Tick(object sender, EventArgs e)
        {
            dateToday = DateTime.Now.ToString("MM/dd/yyyy");
            lblScore.Text = "Score: " + Top10Only.AddingCommasInScore(Convert.ToString(score));
            lblMissed.Text = "Missed: " + missedEggs;
            // Chicken will go to left side.
            if (isGoLeft == true && pbChicken.Left > 0)
            {
                pbChicken.Left -= 30;
                pbChicken.Image = Properties.Resources.chicken_normal2;
            }
            // Chicken will go to right side.
            if (isGoRight == true && pbChicken.Left + pbChicken.Width < this.ClientSize.Width)
            {
                pbChicken.Left += 30;
                pbChicken.Image = Properties.Resources.chicken_normal;
            }
            // Using the foreach loop to control every eggs.
            foreach (Control x in this.Controls)
            {
                // Check if there are picturebox that have a tag name of "eggs".
                if (x is PictureBox && (string)x.Tag == "eggs")
                {
                    // Add the speed of falling egg.
                    x.Top += speed;
                    // If Egg was dropped in the floor.
                    if (x.Top + x.Height > this.ClientSize.Height)
                    {
                        pictureBox.Image = Properties.Resources.splash;
                        pictureBox.Location = x.Location;
                        pictureBox.Height = 60;
                        pictureBox.Width = 60;
                        pictureBox.BackColor = Color.Transparent;
                        this.Controls.Add(pictureBox);
                        x.Top = randomNumberForYaxis.Next(80, 300) * -1;
                        x.Left = randomNumberForXaxis.Next(5, this.ClientSize.Width - x.Width);
                        missedEggs += 1;
                        pbChicken.Image = Properties.Resources.chicken_hurt;
                        CheckIfAudioMutedOrNot("missed_egg.wav");
                    }
                    // If Chicken collided of egg.
                    if (pbChicken.Bounds.IntersectsWith(x.Bounds))
                    {
                        x.Top = randomNumberForYaxis.Next(80, 300) * -1;
                        x.Left = randomNumberForXaxis.Next(5, this.ClientSize.Width - x.Width);
                        score += 1;
                        CheckIfAudioMutedOrNot("saved_egg.wav");
                    }
                }
            }
            // If the score is greater than 10.
            if (score > 10)
            {
                speed = 12; // then increase the speed.
            }
            if (missedEggs >= 10) // If missedEggs is greater than or equal to 10.
            {
                GameOver(); // Execute this user defined function called GameOver()
            }
        }
        // The user is keep pressing.
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                isGoLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                isGoRight = true;
            }
        }
        // The user releases the touch.
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                isGoLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                isGoRight = false;
            }
        }
        // This is form is closed.
        private void Form_Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            inGameAudio.StopPlaying();
            gameOverAudio.StopPlaying();
            Application.Exit();
        }
        #endregion

        #region User Defined Methods
        private void StartGame()
        {
            // Using the foreach loop to control every eggs.
            foreach (Control x in this.Controls)
            {
                // Check if there are picturebox that have a tag name of "eggs".
                if (x is PictureBox && (string)x.Tag == "eggs")
                {
                    // Generate random number to change the location of every egg.
                    x.Top = randomNumberForYaxis.Next(80, 300) * -1;
                    x.Left = randomNumberForXaxis.Next(5, this.ClientSize.Width - x.Width);
                }
            }
            pbChicken.Left = this.ClientSize.Width / 2;
            pbChicken.Image = Properties.Resources.chicken_normal;
            score = 0;
            missedEggs = 0;
            speed = 8;
            isGoLeft = false;
            isGoRight = false;
            timerGame.Start();
            dateToday = DateTime.Now.ToString("MM/dd/yyyy");
            PlayInGameAudio();
        }
        private void CheckIfAudioMutedOrNot(string param_NameOfWavFile)
        {
            if (Form_Introduction.isAudioOn == true)
            {
                CustomAudio customAudio = new CustomAudio(param_NameOfWavFile);
                customAudio.Play(false);
            }
        }
        private void GameOver()
        {
            timerGame.Stop();
            lblScore.Text = "Score: " + Top10Only.AddingCommasInScore(Convert.ToString(score));
            lblMissed.Text = "Missed: " + missedEggs;
            Top10Only.CheckResultInTop10Only(dateToday, score);
            inGameAudio.StopPlaying();
            if (Form_Introduction.isAudioOn == true)
            {
                gameOverAudio.Play(false);
            }
            DialogResult result = MessageBox.Show("Score: " + score + Environment.NewLine + "Missed: " + missedEggs + Environment.NewLine + Environment.NewLine + "Do you want to play again?", "GAME OVER", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                gameOverAudio.StopPlaying();
                StartGame();
            }
            else if (result == DialogResult.No)
            {
                gameOverAudio.StopPlaying();
                this.Hide();
                Form_Introduction nextForm = new Form_Introduction();
                nextForm.ShowDialog();
            }
        }
        private void PlayInGameAudio()
        {
            if (Form_Introduction.isAudioOn == true)
            {
                inGameAudio.Play(true);
            }
        }
        #endregion    
    }
}