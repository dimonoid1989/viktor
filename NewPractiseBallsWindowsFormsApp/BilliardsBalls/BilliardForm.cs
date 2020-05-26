using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NewPractiseBallsWindowsFormsApp;

namespace BilliardsBalls
{
    public partial class BilliardForm : Form
    {
        List<BilliardsBall> balls;
        public BilliardForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            startMoving.Enabled = false;
            endGame.Enabled = false;

        }
        private void addBilliardBalls_Click_1(object sender, EventArgs e)
        {
            balls = new List<BilliardsBall>();
            for (int i = 0; i < 10; i++)
            {
                var ball = new BilliardsBall(this);
                ball.Show();
                balls.Add(ball);
            }
            startMoving.Enabled = true;
            upLabel.Text = "Количество отскоков ";
            downLabel.Text = "Количество отскоков ";
            leftLabel.Text = "Количество отскоков ";
            rightLabel.Text = "Количество отскоков ";
        }

        private void startBilliardMoving_Click(object sender, EventArgs e)
        {
            foreach (var ball in balls)
            {
                ball.Start();
            }
            endGame.Enabled = true;
        }

        private void endBilliardGame_Click(object sender, EventArgs e)
        {
            int upSide = 0;
            int downSide = 0;
            int leftSide = 0;
            int rightSide = 0;
            foreach (var ball in balls)
            {
                ball.StopMoving();
                if (ball.OnScreen())
                {
                    upLabel.Text = "Количество отскоков " + upSide + ball.UpSide();
                    downLabel.Text = "Количество отскоков " + downSide + ball.DownSide();
                    leftLabel.Text = "Количество отскоков " + leftSide + ball.LeftSide();
                    rightLabel.Text = "Количество отскоков " + rightSide + ball.RightSide();
                    upSide += ball.UpSide();
                    downSide += ball.DownSide();
                    leftSide += ball.LeftSide();
                    rightSide += ball.RightSide();
                }
            }
            balls.Clear();
            Invalidate();
            startMoving.Enabled = false;
            endGame.Enabled = false;
        }
    }
}

