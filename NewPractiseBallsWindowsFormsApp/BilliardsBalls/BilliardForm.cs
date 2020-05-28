using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NewPractiseBallsWindowsFormsApp;

namespace BilliardsBalls
{
    public partial class BilliardForm : Form
    {
        List<BilliardsBall> balls;
        private readonly Timer sideCountTimer = new Timer();
        
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
            startBilliardMovingButton.Enabled = false;
            endBilliardGameButton.Enabled = true;
            sideCountTimer.Tick += Timer_Tick;
            sideCountTimer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            int upSide = 0;
            int downSide = 0;
            int leftSide = 0;
            int rightSide = 0;
            foreach (var ball in balls)
            {
                upLabel.Text = "Количество отскоков " + upSide ;
                downLabel.Text = "Количество отскоков " + downSide ;
                leftLabel.Text = "Количество отскоков " + leftSide ;
                rightLabel.Text = "Количество отскоков " + rightSide ;
                upSide += ball.UpSide();
                downSide += ball.DownSide();
                leftSide += ball.LeftSide();
                rightSide += ball.RightSide();
            }
        }

        private void endBilliardGame_Click(object sender, EventArgs e)
        {
            sideCountTimer.Stop();
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

