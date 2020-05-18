using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NewPractiseBallsWindowsFormsApp
{
    public partial class MainForm : Form
    {
        List<RandomSideBall> balls;
        int countBalls;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void startMoving_Click(object sender, EventArgs e)
        {
            foreach (var ball in balls)
            {
                ball.Start();
            }
            countBalls = 0;
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
        }
        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            var location = e.Location;
            foreach (var ball in balls)
            {
                if (ball.ClickCheck(location))
                {
                    ball.StopMoving();
                    countBalls++;
                    viewCatchedBalls.Text = "Шариков поймано " + countBalls;
                }
            }
        }
        private void stopAndCount_Click(object sender, EventArgs e)
        {
            foreach (var ball in balls)
            {
                ball.StopMoving();
                if (ball.OnScreen())
                {
                    viewCatchedBalls.Text = "Шариков поймано " + countBalls;
                }
            }
            MessageBox.Show(countBalls + " шариков удалось поймать");
        }
    }
}
