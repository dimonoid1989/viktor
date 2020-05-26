using System.Windows.Forms;
namespace NewPractiseBallsWindowsFormsApp
{
    public class RandomSideBall : RandomPointBall
    {
        public RandomSideBall(Form form) : base(form)
        {
            vx = random.Next(-10, 10);
            vy = random.Next(-10, 10);
        }
    }
}
