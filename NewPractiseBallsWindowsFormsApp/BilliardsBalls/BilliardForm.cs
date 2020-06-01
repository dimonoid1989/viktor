using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClassLibrary3;

namespace BilliardsBalls
{
    public partial class BilliardForm : Form
    {
        int upSide = 0;
        int downSide = 0;
        int leftSide = 0;
        int rightSide = 0;
        List<BilliardsBall> balls;
        public BilliardForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            startBilliardMovingButton.Enabled = false;
            endBilliardGameButton.Enabled = false;
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
            startBilliardMovingButton.Enabled = true;
            addBilliardBallsButton.Enabled = false;
        }

        private void startBilliardMoving_Click(object sender, EventArgs e)
        {
            
            foreach (var ball in balls)
            {
                ball.Start();
            }
            startBilliardMovingButton.Enabled = false;
            endBilliardGameButton.Enabled = true;
        }
        private void Ball_OnTouchSide(object sender, TouchFormEvenArgs e)
        {
            switch (e.Side)
            {
                case Side.up:
                    upSide++;
                    break;
                case Side.down:
                    downSide++;
                    break;
                case Side.left:
                    leftSide++;
                    break;
                case Side.right:
                    rightSide++;
                    break;
                default:
                    break;
            }
            UpdateSideTouches();
        }
        private void UpdateSideTouches()
        {
                upLabel.Text = "Количество отскоков " + upSide;
                downLabel.Text = "Количество отскоков " + downSide;
                leftLabel.Text = "Количество отскоков " + leftSide;
                rightLabel.Text = "Количество отскоков " + rightSide;
        }
        private void endBilliardGame_Click(object sender, EventArgs e)
        {
            foreach (var ball in balls)
            {
                ball.StopMoving();
            }
            balls.Clear();
            Invalidate();
            endBilliardGameButton.Enabled = false;
            addBilliardBallsButton.Enabled = true;
        }
    }
}

