using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary3;

namespace SalutWindowsFormsApp
{
    public partial class SaluteForm : Form
    {
        private Salute ball;
        private Random random = new Random();
        public SaluteForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            AddSalute();
        }

        private void AddSalute()
        {
            ball = new Salute(this);
            ball.Start();
            ball.Boomed += Ball_Boomed;
        }
        private void Ball_Boomed(object sender, BallDisapearedEventArgs e)
        {
            var list = new List<RandomSideBall> { };
            for (int i = 0; i < random.Next(5, 10); i++)
            {
                var ball = new RandomSideBall(this, e.Ball.X, e.Ball.Y);
                list.Add(ball);
                ball.Start();
            }
            AddSalute();
        }
    }
}
