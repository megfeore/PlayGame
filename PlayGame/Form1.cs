using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; //allows the use of SoundPlayer();
using System.Threading; //allows the use of Thread.Sleep() 

namespace PlayGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            backgroundLabel.BackColor = Color.Red;
            startButton.BackColor = Color.Red;
            startButton.Size = Size.Empty;
            
            //create a sound player and load the alert.wav sound, then play it 
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.sound1);

            soundPlayer.Play();
            //showing label 1 - start of the countdown
            countdownLabel1.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            countdownLabel1.Visible = false;
            //playing the sound of label 1
            SoundPlayer soundPlayer2 = new SoundPlayer(Properties.Resources.sound2);

            soundPlayer2.Play();

            //showing label 2 - the 2 in the countdown
            countdownLabel2.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            countdownLabel2.Visible = false;
            //playing sound for label 2
            SoundPlayer soundPlayer3 = new SoundPlayer(Properties.Resources.sound3);

            soundPlayer3.Play();

            //showing label 3 - 1 of countdown
            countdownLabel3.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            countdownLabel3.Visible = false;
            //playing sound for label 3
            SoundPlayer soundPlayer4 = new SoundPlayer(Properties.Resources.sound4);

            soundPlayer4.Play();    
            Thread.Sleep(1000);

            //showing the go label
            goLabel.Visible = true;

            //playing the honking noise when the screen goes green
            SoundPlayer soundPlayer5 = new SoundPlayer(Properties.Resources.sound5);


            soundPlayer5.Play();

            //screen turns from red to green
            backgroundLabel.BackColor = Color.Green; 

      


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
