using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClassLibrary3;

namespace NewPractiseBallsWindowsFormsApp
{
    public partial class MainForm : Form
    {
        List<RandomSideBall> balls;
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
            balls = new List<RandomSideBall>();
            for (int i = 0; i < 10; i++)
            {
                var ball = new RandomSideBall(this);
                ball.Show();
                balls.Add(ball);
            }
            startMoving.Enabled = true;
            
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
            foreach (var ball in balls)
            {
                ball.StopMoving();
                if (ball.OnScreen())
                { buttonCountBalls++; }
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
