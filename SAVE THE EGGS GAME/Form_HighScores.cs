using System;
using System.Windows.Forms;

namespace SAVE_THE_EGGS_GAME // Created by: Joshua C. Magoliman
{
    public partial class Form_HighScores : Form
    {
        #region Fields    
        private CustomAudio customAudio = new CustomAudio("introduction_and_in_game.wav");
        #endregion

        #region Constructor       
        public Form_HighScores()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler Methods
        private void Form_HighScores_Load(object sender, EventArgs e)
        {
            CheckIfAudioMutedOrNot();
            Top10Only.Show(this.lblRankHeaderAndContent, this.lblDateHeaderAndContent, this.lblScoreHeaderAndContent);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            customAudio.StopPlaying();
            this.Hide();
            Form_Introduction nextForm = new Form_Introduction();
            nextForm.Show();
        }
        private void Form_HighScores_FormClosed(object sender, FormClosedEventArgs e)
        {
            customAudio.StopPlaying();
            Application.Exit();
        }
        #endregion

        #region User Defined Methods
        private void CheckIfAudioMutedOrNot()
        {
            if (Form_Introduction.isAudioOn == true)
            {
                customAudio.Play(true);
            }
        }
        #endregion
    }
}
