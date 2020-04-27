using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russian_Roullete_Navjit
{
    public partial class MainGame : Form
    {
        GameClass gc = new GameClass();//instance of GameClass
        Random rdNumbers = new Random();
        int nvtotalShoot = 6;//value for totalshots
        int nvgunTry = 2;//value for gun
        public MainGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Russian_Roullete_Navjit.Properties.Resources.load;//adding the image on the picturebox
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(Russian_Roullete_Navjit.Properties.Resources.Loadings);//code for sound
            soundPlayer.Play();//play sound

            button1.Enabled = false;
            gc.nvLoad = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Russian_Roullete_Navjit.Properties.Resources.spn;//adding the image on the picturebox
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(Russian_Roullete_Navjit.Properties.Resources.Loadings);//Add sound here
            soundPlayer.Play();//play sound

            button2.Enabled = false;

            gc.nvSpin = rdNumbers.Next(1, 6);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Russian_Roullete_Navjit.Properties.Resources.shoot;//add the image on the picturebox
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(Russian_Roullete_Navjit.Properties.Resources.Shot);//sound here
            soundPlayer.Play();//play sound

            if (nvtotalShoot > 0 && gc.nvSpin == 1)
            {
                MessageBox.Show("Shoot You loose");
                button4.Enabled = false;
                button3.Enabled = false;
            }
            else if (nvtotalShoot > 0 && gc.nvSpin != 1)
            {
                MessageBox.Show("Blank Fire");
                nvtotalShoot = nvtotalShoot - 1;//minus one from total
                gc.nvSpin = gc.ShootnvLoop(gc.nvSpin);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Russian_Roullete_Navjit.Properties.Resources.shoot;//Here i add the image on the picturebox
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(Russian_Roullete_Navjit.Properties.Resources.Shot);//Add sound here
            soundPlayer.Play();//play sound

            if (nvtotalShoot > 0 && gc.nvSpin == 1 && nvgunTry == 2)
            {
                MessageBox.Show("you win you score is 200");
                button4.Enabled = false;
                button3.Enabled = false;
            }
            if (nvtotalShoot > 0 && gc.nvSpin == 1 && nvgunTry == 1)
            {
                MessageBox.Show("you win you score is 100");
                button4.Enabled = false;
                button3.Enabled = false;
            }
            else if (nvtotalShoot > 0 && gc.nvSpin != 1)
            {
                MessageBox.Show("Blank Fire");
                nvtotalShoot = nvtotalShoot - 1;//minus one from total
                gc.nvSpin = gc.ShootnvLoop(gc.nvSpin);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            (new MainGame()).Show();
            this.Hide();
        }
    }
}
