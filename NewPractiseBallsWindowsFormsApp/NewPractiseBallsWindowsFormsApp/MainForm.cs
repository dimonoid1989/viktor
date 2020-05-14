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
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
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
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var ball in balls)
            {
                ball.Move();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
    }
}
