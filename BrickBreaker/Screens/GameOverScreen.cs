using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickBreaker
{
    public partial class GameOverScreen : UserControl
    {
        Ball b;
        
        
        List<Ball> explosion = new List<Ball>();
        SolidBrush ballBrush = new SolidBrush(Color.White);
        int bspeed, bsize;
        Random randGen = new Random();
        int ballcounter;
        int b1speed = 10;
        int b1size = 100;

        public GameOverScreen()
        {
            InitializeComponent();
            gameOverTimer.Enabled = true;
            b = new Ball(this.Width/2 - 50, this.Height/2 - 50, b1speed, b1speed, b1size, 0, 1);

        }

        private void gameOverTimer_Tick(object sender, EventArgs e)
        {

            //decrease in y-value, the ball is falling down
            b.GameOverMove();

            //Once the ball hits the bottom line, explode into a variety of pieces
            if (b.y > this.Height - b.size)
            {
                ExplosionBs();
                gameOverLabel.Text = "Game Over";
            }

            ballcounter++;

            if (ballcounter == 10)
            {
                ExplosionBs();

            }


            Refresh();

        }

        

        public void ExplosionBs()
        {
            ballcounter = 0;
            bspeed = randGen.Next(1, 11);
            bsize = randGen.Next(1, 51);
            Ball explosionb = new Ball(Convert.ToInt32(b.x), Convert.ToInt32(b.y), bspeed, bspeed, bsize, 0, 0);
            explosion.Add(explosionb);

            foreach (Ball b in explosion)
            {
                int dir = randGen.Next(1, 3);
                if (dir == 1)
                {
                    b.ExplosionLeft();
                }
                else if (dir == 2)
                {
                    b.ExplosionRight();
                }
                    
               
            }
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            MenuScreen ms = new MenuScreen();
            Form form = this.FindForm();

            form.Controls.Add(ms);
            form.Controls.Remove(this);

            ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);
        }

        public void GameOver_Paint(object sender, PaintEventArgs e)
        {
            // Draws ball
            e.Graphics.FillRectangle(ballBrush, (float)b.x, (float)b.y, b.size, b.size);
            foreach (Ball b in explosion)
            {
                e.Graphics.FillRectangle(ballBrush, (float)b.x, (float)b.y, b.size, b.size);
            }
        }
    }
}
