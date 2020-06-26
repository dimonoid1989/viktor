using System.Windows.Forms;
namespace ClassLibrary3
{
    public class RandomSideBall : RandomPointBall
    {
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
        }
    }
}
