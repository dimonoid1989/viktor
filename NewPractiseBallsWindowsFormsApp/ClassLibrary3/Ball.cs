using System;
using System.Windows.Forms;
using System.Drawing;

namespace ClassLibrary3
{
    public class Ball
    {
        protected static Random random = new Random();
        public int X { get; protected set; } = 250;
        public int Y { get; protected set; } = 250;
        protected int vx = 10;
        protected int vy = 10;
        protected Brush brush = Brushes.Red;
        protected readonly Form form;
        protected readonly Timer timer = new Timer();
        private Rectangle rectangle;
        protected int size;
        protected readonly double radius;
       
        public Ball(Form form)
        {
            this.form = form;
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
            size = 50;
            radius = size / 2;
        }
       
        public virtual void Show()
        {
            Graphics graphics = form.CreateGraphics();
            rectangle = new Rectangle(X, Y, size, size);
            graphics.FillEllipse(brush, rectangle);
        }
        protected virtual void Go()
        {
            X += vx;
            Y += vy;
        }
        protected void Clear()
        {
            var graphics = form.CreateGraphics();
            SolidBrush solidBrush = new SolidBrush(form.BackColor);
            graphics.FillEllipse(solidBrush, rectangle);
        }
        private void Move()
        {
            Clear();
            Go();
            Show();
        }
        void Timer_Tick(object sender, EventArgs e)
        {
            Move();
        }
        public void StopMoving()
        {
            timer.Stop();
        }
        public void Start()
        {
            timer.Start();
        }
        public bool ClickCheck(Point location)
        {
            return Math.Pow(location.X - X - radius, 2) + Math.Pow(location.Y - Y - radius, 2) <= Math.Pow(size, 2);
        }
        public bool OnScreen()
        {
            return X < form.ClientSize.Width - size && Y < form.ClientSize.Height - size && X > 0 && Y > 0;
        }
        public bool IsBallActive()
        {
            return timer.Enabled;
        }
       
    }
}
