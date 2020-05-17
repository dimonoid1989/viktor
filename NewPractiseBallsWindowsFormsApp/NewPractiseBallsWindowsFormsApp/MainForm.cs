using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var ball in balls)
            {
                ball.Start();
            }
            countBalls = 0;
        }
        private void button2_Click(object sender, EventArgs e)
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
                { ball.StopMoving(); }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var ball in balls)
            {
                ball.StopMoving();
                if (ball.OnScreen())
                {
                    countBalls++;
                }
            }
            MessageBox.Show(countBalls + " шариков удалось поймать");
        }
    }
}
