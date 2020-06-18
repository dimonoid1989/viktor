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
using ClassLibrary3;

namespace Fruit_Ninja_ballApp
{
    public partial class FruitNinjaForm : Form
    {
        private FruitNinjaBall ball;
        private readonly List<FruitNinjaBall> balls = new List<FruitNinjaBall>();
        private int countBalls;
        private Random random;
        private int life = 5;
        private int ballCought;
        public event EventHandler FormIsEmpty;
        bool end;

        public FruitNinjaForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            end = false;
            AddBalls();
            FormIsEmpty += FruitNinjaForm_FormIsEmpty;
            lifesCountLabel.Text = life+"";
            ballCoughtLabel.Text = ballCought + "";
        }

        private void FruitNinjaForm_FormIsEmpty(object sender, EventArgs e)
        {
            balls.Clear();
            AddBalls();
        }
        private void AddBalls()
        {
            if (life > 0)
            {
                random = new Random();
                for (int i = 0; i <= random.Next(1, 5); i++)
                {
                    ball = new FruitNinjaBall(this);
                    balls.Add(ball);
                    ball.Show();
                    ball.Start();
                }
                countBalls = balls.Count;
                foreach (var ball in balls)
                {
                    ball.BallGoneAway += Ball_BallDisapeared;
                    ball.BallMouseCought += Ball_BallMouseCought;
                }
            }
            else
            {
                GameOver();
            }
        }

        private void GameOver()
        {
            end = true;
            FormIsEmpty -= FruitNinjaForm_FormIsEmpty;
            MessageBox.Show("Игра окончена");
            life = 1;
        }
        private void Ball_BallMouseCought(object sender, BallDisapearedEventArgs e)
        {
            if (e.FruitNinjaBall.Active == true)
            {
                countBalls -= 1;
                ballCought += 1;
                ballCoughtLabel.Text = ballCought + "";
                e.FruitNinjaBall.Active = false;
            }
            if (countBalls == 0 && end == false)
            {
                FormIsEmpty.Invoke(this, new EventArgs());
            }
        }

        private void FruitNinjaForm_MouseMove(object sender, MouseEventArgs e)
        {
            var location = e.Location;
            foreach (var ball in balls)
            {
                if (ball.ClickCheck(location) && end == false)
                {
                    ball.BallCought(ball);
                    return;
                }

            }
        }
        private void Ball_BallDisapeared(object sender, BallDisapearedEventArgs e)
        {
            if (e.FruitNinjaBall.Active == true)
            {
                countBalls -= 1;
                life -= 1;
                lifesCountLabel.Text = life + "";
                e.FruitNinjaBall.Active = false;
            }

            if (countBalls == 0 && end == false)
            {
                FormIsEmpty.Invoke(this, new EventArgs());
            }
        }
    }
}
