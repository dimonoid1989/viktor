using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary3
{
    public class Salute : FruitNinjaBall
    {
        private bool wasBoom { get; set; }
        public event EventHandler<BallDisapearedEventArgs> Boomed;
        public Salute(Form form) : base(form)
        {
            wasBoom = false;
            WasEvent = false;
            vx = 0;
            timerForRising.Interval = 10;
            vy = random.Next(-5, -3);
            
        }
        protected override void TimerForRising_Tick(object sender, EventArgs e)
        {
            base.TimerForRising_Tick(sender, e);
            if (IsFalling && !wasBoom)
            {
                Boomed.Invoke(this, new BallDisapearedEventArgs(this));
                wasBoom = true;
                StopMoving();
                Clear();
            }
        }
    }
}
