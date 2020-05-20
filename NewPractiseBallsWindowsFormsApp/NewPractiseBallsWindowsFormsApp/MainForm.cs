using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NewPractiseBallsWindowsFormsApp
{
    public partial class MainForm : Form
    {
        List<BilliardsBall> balls;
        int clickCountBalls;
        int buttonCountBalls;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startMoving.Enabled = false;
            endGame.Enabled = false;
        }
        private void startMoving_Click(object sender, EventArgs e)
        {
            foreach (var ball in balls)
            {
                ball.Start();
            }
            clickCountBalls = 0;
            buttonCountBalls = 0;
            endGame.Enabled = true;
        }
        private void addBalls_Click(object sender, EventArgs e)
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
        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            var location = e.Location;
            if (balls == null)
            {
                return;
            }
            foreach (var ball in balls)
            {
                if (ball.ClickCheck(location))
                {
                    if (ball.IsBallActive())
                    {
                        ball.StopMoving();
                        clickCountBalls++;
                        viewCatchedBalls.Text = "Шариков поймано " + clickCountBalls;
                    }
                }
            }
        }
        private void endGame_Click(object sender, EventArgs e)
        {
            int up = 0;
            int down = 0;
            int left = 0;
            int right = 0;
            foreach (var ball in balls)
            {
                ball.StopMoving();
                if (ball.OnScreen())
                { buttonCountBalls++; }
                upLabel.Text = "Количество отскоков " + up + ball.UpSide();
                downLabel.Text = "Количество отскоков " + down + ball.DownSide();
                leftLabel.Text = "Количество отскоков " + left + ball.LeftSide();
                rightLabel.Text = "Количество отскоков " + right+ ball.RightSide();
                up += ball.UpSide();
                down += ball.DownSide();
                left += ball.LeftSide();
                right += ball.RightSide();
            }
            balls.Clear();
            MessageBox.Show(buttonCountBalls + " шариков удалось поймать");
            Invalidate();
            viewCatchedBalls.Text = default;
            startMoving.Enabled = false;
            endGame.Enabled = false;
        }
    }
}
