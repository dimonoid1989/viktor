using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary3
{
    public class FruitNinjaBall : RandomSideBall
    {
        public bool Active => timer.Enabled;

        public bool wasEvent { get; private set; }
        private readonly Timer timerForRising = new Timer();
        public event EventHandler<BallDisapearedEventArgs> BallGoneAway;
        public event EventHandler<BallDisapearedEventArgs> BallMouseCought;
        private int gravity = 1;
        readonly double screenPart = random.Next(1,10) + 0.5;
        private bool IsFalling => vy >= 1;
        public FruitNinjaBall(Form form) : base(form)
        {
            y = form.ClientSize.Height;
            vy = random.Next(-5, 0);
            vx = random.Next(-1, 1);
            SlowerBall();
            wasEvent = false;
        }
        private void SlowerBall()
        {
            timerForRising.Interval = 20;
            timerForRising.Tick += TimerForRising_Tick;
            timerForRising.Start();
        }
        private void TimerForRising_Tick(object sender, EventArgs e)
        {
            if (vy <= 2 && y < form.ClientSize.Height/screenPart)
            {
                vy += gravity;
            }
            if (!OnScreen() && IsFalling ) 
            {
                BallGoneAway.Invoke(this, new BallDisapearedEventArgs(this));
                wasEvent = true;
            }
        }
        public void BallCought(FruitNinjaBall ball)
        {
            BallMouseCought.Invoke(ball, new BallDisapearedEventArgs(ball));
            wasEvent = true;
            StopMoving();
            Clear();
        }
    }
}
