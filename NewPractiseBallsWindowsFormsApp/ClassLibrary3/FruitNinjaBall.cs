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
        public bool Active  => timer.Enabled;
        private readonly Timer timerForRising = new Timer();
        public event EventHandler<BallDisapearedEventArgs> BallGoneAway;
        public event EventHandler<BallDisapearedEventArgs> BallMouseCought;
        private int gravity = 1;
        private bool IsFalling => vy >= 1;
        public FruitNinjaBall(Form form) : base(form)
        {
            y = form.ClientSize.Height;
            vy = random.Next(-5, 0);
            vx = random.Next(-1, 1);
            SlowerBall();
        }
        private void SlowerBall()
        {
            timerForRising.Interval = 20;
            timerForRising.Tick += TimerForRising_Tick;
            timerForRising.Start();
        }
        private void TimerForRising_Tick(object sender, EventArgs e)
        {
            if (vy <= 2 && y < form.ClientSize.Height/2)
            {
                vy += gravity;
            }
            if (!OnScreen() && IsFalling ) //корректировка срабатывания события
            {
                BallGoneAway.Invoke(this, new BallDisapearedEventArgs(this));
                StopMoving();
                Clear();
            }
        }
        public void BallCought(FruitNinjaBall ball)
        {
            BallMouseCought.Invoke(ball, new BallDisapearedEventArgs(ball));
            StopMoving();
            Clear();
        }
    }
}
