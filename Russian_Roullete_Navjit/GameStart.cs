using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russian_Roullete_Navjit
{
    public partial class GameStart : Form
    {
        public GameStart()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 0;
            //progressBar1.PerformStep();
            for (int i = 0; i < 100; i++)//loop for running the progress bar
            {
                Thread.Sleep(50);
                progressBar1.Maximum = progressBar1.Maximum + 1;
                progressBar1.PerformStep();
            }
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;   //timer is enabled
                MainGame mg = new MainGame();    //next page instance
                mg.Show();
                this.Hide();
            }
        }

        private void GameStart_Load(object sender, EventArgs e)
        {

        }
    }
}
