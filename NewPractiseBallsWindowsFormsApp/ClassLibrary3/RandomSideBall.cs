using System.Windows.Forms;
using System.Drawing;
using System;

namespace ClassLibrary3
{
    public class RandomSideBall : RandomPointBall
    {
        Random randomBrush = new Random();
        public RandomSideBall(Form form) : base(form)
        {
            vx = random.Next(-10, 10);
            vy = random.Next(-10, 10);
        }
        public RandomSideBall(Form form, int a, int b) : base(form)
        {
            vx = random.Next(-10, 10);
            vy = random.Next(-10, 10);
            x = a;
            y = b;
            size = 40;
            brush = new SolidBrush(Color.FromArgb(randomBrush.Next(255), randomBrush.Next(255), randomBrush.Next(255)));
        }
    }
}
