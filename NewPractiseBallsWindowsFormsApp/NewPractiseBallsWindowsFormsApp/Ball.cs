using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewPractiseBallsWindowsFormsApp
{
    class Ball
    {
        protected static Random random = new Random();
        protected int x = 250;
        protected int y = 250;
        protected int vx = 10;
        protected int vy = 10;
        protected Brush brysh = Brushes.Red;
        private MainForm form;
        protected Timer timer = new Timer();
        private Rectangle rectangle;
        private int size;

        public Ball(MainForm form)
        {
            this.form = form;
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
        }
        public void Show()
        {
            Graphics graphics = form.CreateGraphics();
            size = 50;
            rectangle = new Rectangle(x, y, size, size);
            graphics.FillEllipse(Brushes.MediumVioletRed, rectangle);
        }
        private void Go()
        {
            x += vx;
            y += vy;
        }
        private void Clear()
        {
            var graphics = form.CreateGraphics();
            graphics.FillEllipse(Brushes.LightGray, rectangle);
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
            return Math.Pow(location.X - x-25, 2) + Math.Pow(location.Y - y-25, 2) <= Math.Pow(size, 2);
        }
        public bool OnScreen()
        {
            return x < form.Width - size && y < form.Height - size && x > 0 && y > 0;
        }
    }
}
