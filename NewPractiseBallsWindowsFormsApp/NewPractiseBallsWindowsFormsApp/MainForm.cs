using System;
using System.Collections.Generic;
using System.Drawing;
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
            if (balls == null)
            {
                MessageBox.Show("Сначала необходимо добавить шарики!");
                return;
            }
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
                        countBalls++;
                        viewCatchedBalls.Text = "Шариков поймано " + countBalls;
                    }
                }
            }
        }
        private void endGame_Click(object sender, EventArgs e)
        {
            if (balls == null)
            {
                MessageBox.Show("Сначала необходимо добавить шарики!");
                return;
            }
            foreach (var ball in balls)
            {
                ball.StopMoving();
            }
            balls = null;
            MessageBox.Show(countBalls + " шариков удалось поймать");
            BackColor = Color.White;
            viewCatchedBalls.Text = default;
        }
    }
}
