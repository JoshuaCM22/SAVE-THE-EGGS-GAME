using SAVE_THE_EGGS_GAME.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SAVE_THE_EGGS_GAME // Created by: Joshua C. Magoliman
{
    public partial class Form_Introduction : Form
    {
        #region Fields    
        public static bool isAudioOn;
        private static readonly string file = "ForAudio.txt";
        private CustomAudio customAudio = new CustomAudio("introduction_and_in_game.wav");
        #endregion

        #region Constructor  
        public Form_Introduction()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler Methods
        private void Form_Introduction_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lblTitle;
            CheckTheContentOfTheFile();
            CheckIfAudioIsMutedOrNot();
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            customAudio.StopPlaying();
            this.Hide();
            Form_Game nextForm = new Form_Game();
            nextForm.Show();
        }
        private void btnHighScores_Click(object sender, EventArgs e)
        {
            customAudio.StopPlaying();
            this.Hide();
            Form_HighScores nextForm = new Form_HighScores();
            nextForm.Show();
        }
        private void pbAudio_Click(object sender, EventArgs e)
        {
            if (isAudioOn == true)
            {
                isAudioOn = false;
                pbAudio.Image = new Bitmap(Resources.muted);
                customAudio.StopPlaying();
            }
            else if (isAudioOn == false)
            {
                isAudioOn = true;
                pbAudio.Image = new Bitmap(Resources.unmuted);
                customAudio.Play(true);
            }
            SavingTheContent();
        }
        private void Form_Introduction_FormClosed(object sender, FormClosedEventArgs e)
        {
            customAudio.StopPlaying();
            Application.Exit();
        }
        #endregion

        #region User Defined Methods
        private void CheckTheContentOfTheFile()
        {
            if (File.Exists(file))
            {
                StreamReader read = new StreamReader(file);
                using (read)
                {
                    string content = read.ReadLine();
                    if (content != null)
                    {
                        isAudioOn = Convert.ToBoolean(content);
                    }
                }
            }
        }
        private void CheckIfAudioIsMutedOrNot()
        {
            if (isAudioOn == true)
            {
                pbAudio.Image = new Bitmap(Resources.unmuted);
                customAudio.Play(true);
            }
            else if (isAudioOn == false)
            {
                pbAudio.Image = new Bitmap(Resources.muted);
                customAudio.StopPlaying();
            }
        }
        private void SavingTheContent()
        {
            StreamWriter write = new StreamWriter(file, false);
            using (write)
            {
                write.WriteLine(Convert.ToString(isAudioOn));
            }
        }
        #endregion
    }
}
