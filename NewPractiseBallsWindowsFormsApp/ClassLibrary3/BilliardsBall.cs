using System;
using System.Windows.Forms;

namespace NewPractiseBallsWindowsFormsApp
{
    public class BilliardsBall : RandomSideBall
    {
        private int up = 0;
        private int down = 0;
        private int left = 0;
        private int right = 0;
        public delegate void BallDelegat();
        public event BallDelegat BallTouchFormSide;
        public BilliardsBall(Form form) : base(form)
        {
            vx = random.Next(-30, 30);
            vy = random.Next(-30, 30);
            timer.Tick += Timer_Tick;
            BallTouchFormSide += MoveToOtherSide;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!OnScreen())
            {
               BallTouchFormSide();
            }
        }
        public void MoveToOtherSide()
        {
            if (y <= 0)
            {
                vy *= -1;
                up++;
            }
            if (y >= (form.Height - size*2))
            {
                vy *= -1;
                down++;
            }
            if (x >= (form.Width - size*1.5))
            {
                vx *= -1;
                right++;
            }
            if (x <= 0)
            {
                vx *= -1;
                left++;
            }
        }
        public int UpSide()
        { return up; }
        public int DownSide()
        { return down; }
        public int LeftSide()
        { return left; }
        public int RightSide()
        { return right; }
    }
}
