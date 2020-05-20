using System;
using System.Windows.Forms;

namespace NewPractiseBallsWindowsFormsApp
{
    class BilliardsBall : RandomSideBall
    {
        private readonly int minSpeed = 50;
        private readonly int maxSpeed = 200;
        private int up = 0;
        private int down = 0;
        private int left = 0;
        private int right = 0;
        public BilliardsBall(MainForm form) : base(form)
        {
            timer.Interval = random.Next(minSpeed, maxSpeed);
            timer.Tick += Timer_Tick;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!OnScreen())
            {
                MoveToOtherSide();
            }
        }
        private void MoveToOtherSide()
        {
            if (y <= 0 )
            {
                vy *= -1;
                up++;
            }
            if (y >= (Form.ActiveForm.ClientSize.Height - size))
            {
                vy *= -1;
                down++;
            }
            if (x >= (Form.ActiveForm.ClientSize.Width - size))
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
