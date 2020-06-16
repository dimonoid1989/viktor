using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary3
{
    public class FruitNinjaBall : RandomSideBall
    {
        private readonly Timer timerForRising = new Timer();
        public FruitNinjaBall(Form form) : base(form)
        {
            y = form.ClientSize.Height;
            vy = random.Next(-5, 0);
            vx = random.Next(-1, 1);
            SlowerBall();
        }
        private void SlowerBall()
        {
            timerForRising.Interval = 500;
            timerForRising.Tick += TimerForRising_Tick;
            timerForRising.Start();
        }

        private void TimerForRising_Tick(object sender, EventArgs e)
        {
            if (vy <= 2 && y < form.ClientSize.Height/2)
            {
                vy += 1;
            }
            
        }

    }
}
