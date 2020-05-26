
namespace NewPractiseBallsWindowsFormsApp
{
    public class RandomSideBall : RandomPointBall
    {
        public RandomSideBall(MainForm form) : base(form)
        {
            vx = random.Next(-10, 10);
            vy = random.Next(-10, 10);
        }
    }
}
