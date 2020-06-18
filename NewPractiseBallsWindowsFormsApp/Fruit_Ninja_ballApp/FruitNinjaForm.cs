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
        FruitNinjaBall ball;
        List<FruitNinjaBall> balls = new List<FruitNinjaBall>();
        int countBalls;
        Random random;
        // int life = 5;
        public event EventHandler FormIsEmpty;

        public FruitNinjaForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            AddBalls();
            FormIsEmpty += FruitNinjaForm_FormIsEmpty;
        }
        private void FruitNinjaForm_FormIsEmpty(object sender, EventArgs e)
        {
            balls.Clear();
            AddBalls();
        }
        private void AddBalls()
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
            }
        }
        private void FruitNinjaForm_MouseMove(object sender, MouseEventArgs e)
        {
            var location = e.Location;
            foreach(var ball in balls)
            {
                if (ball.ClickCheck(location))
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
                e.FruitNinjaBall.Active = false;
            }
            
            if (countBalls == 0)
            {
                FormIsEmpty.Invoke(this, new EventArgs());
            }
        }
    }
}
