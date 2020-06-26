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
        public Point BallPoint { get; private set; }
        public event EventHandler<BallDisapearedEventArgs> Boomed;
        public Salute(Form form) : base(form)
        {
            wasBoom = false;
            WasEvent = false;
            vx = 0;
            
        }
        protected override void TimerForRising_Tick(object sender, EventArgs e)
        {
            base.TimerForRising_Tick(sender, e);
            if (IsFalling && !wasBoom)
            {
                BallPoint = new Point(x, y);
                Boomed.Invoke(this, new BallDisapearedEventArgs(this));
                wasBoom = true;
                Clear();
            }
        }
    }
}
