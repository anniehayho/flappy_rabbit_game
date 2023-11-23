using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyRabbitGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int gravity = 10;
        int speed = 10;
        int score = 0;

        public void setspeed(int speed)
        {
            this.speed = speed;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                timer1.Start();
            }
        }

        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            rabbit.Top += gravity;
            pipedown.Left -= speed;
            pipeup.Left -= speed;
            pipedown2.Left -= speed;
            pipeup2.Left -= speed;
            pipedown3.Left -= speed;
            pipeup3.Left -= speed;


            lbScore.Text = $"Score: {score}";
            //adding score
            if (pipedown.Left < -1 && pipeup.Left < -1)
            {
                //pipedown.Left = rnd.Next(300, 700);
                pipedown.Left = 607;
                pipeup.Left = 607;
                score++;
            }
            if (pipedown2.Left < -1 && pipeup2.Left < -1)
            {
                //pipedown.Left = rnd.Next(300, 700);
                pipedown2.Left = 607;
                pipeup2.Left = 607;
                score++;
            }
            if (pipedown3.Left < -1 && pipeup3.Left < -1)
            {
                //pipedown.Left = rnd.Next(300, 700);
                pipedown3.Left = 607;
                pipeup3.Left = 607;
                score++;
            }
            
            if (rabbit.Bounds.IntersectsWith(pipedown.Bounds) || rabbit.Bounds.IntersectsWith(pipeup.Bounds) || rabbit.Bounds.IntersectsWith(ground.Bounds) ||
                rabbit.Bounds.IntersectsWith(pipedown2.Bounds) || rabbit.Bounds.IntersectsWith(pipeup2.Bounds)||
                rabbit.Bounds.IntersectsWith(pipedown3.Bounds) || rabbit.Bounds.IntersectsWith(pipeup3.Bounds))
            {
                timer1.Stop();
                lbScore.Text += " Game over!!!";
                DialogResult dialogResult = MessageBox.Show("Game Over! Do you want to play again?", "Game Over", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Reset the game
                    gravity = 10;

                    pipedown.Left = 259;
                    pipeup.Left = 259;
                    pipedown2.Left = 459;
                    pipeup2.Left = 459;
                    pipedown3.Left = 659;
                    pipeup3.Left = 659;
                    score = 0;
                    lbScore.Text = $"Score: {score}";
                    timer1.Start();
                }
                else
                {
                    // Exit the game
                    Application.Exit();
                }
            }
        }
    }
}
