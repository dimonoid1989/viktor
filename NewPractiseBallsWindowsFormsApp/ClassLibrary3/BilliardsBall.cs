using System;
using System.Windows.Forms;

namespace ClassLibrary3
{
    public class BilliardsBall : RandomSideBall
    {
        public event EventHandler<TouchFormEvenArgs> OnTouchSide;
        public BilliardsBall(Form form) : base(form)
        {
            vx = random.Next(-10, 10);
            vy = random.Next(-10, 10);
        }
        protected override void Go()
        {
            base.Go();
            if (Y <= 0)
            {
                vy *= -1;
                OnTouchSide.Invoke(this, new TouchFormEvenArgs(Side.up));
            }
            if (Y >= (form.ClientSize.Height - size))
            {
                vy *= -1;
                OnTouchSide.Invoke(this, new TouchFormEvenArgs(Side.down));
            }
            if (X >= (form.ClientSize.Width - size))
            {
                vx *= -1;
                OnTouchSide.Invoke(this, new TouchFormEvenArgs(Side.right));
            }
            if (X <= 0)
            {
                vx *= -1;
                OnTouchSide.Invoke(this, new TouchFormEvenArgs(Side.left));
            }
        }
    }
}
