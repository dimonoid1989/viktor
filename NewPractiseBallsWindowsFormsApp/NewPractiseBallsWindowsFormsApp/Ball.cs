using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Ball(MainForm form)
        {
            this.form = form;
        }
        public void Show()
        {
            Graphics graphics = form.CreateGraphics();
            graphics.FillEllipse(Brushes.MediumVioletRed,x,y, 50, 50);
        }
        private void Go()
        {
            x += vx;
            y += vy;
        }
        private void Clear()
        {
            var graphics = form.CreateGraphics();
            graphics.FillEllipse(Brushes.LightGray, x, y, 50, 50);
        }
        public void Move()
        {
            Clear();
            Go();
            Show();
        }
    }
}
