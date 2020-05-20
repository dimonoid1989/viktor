using System.Drawing;

namespace NewPractiseBallsWindowsFormsApp
{
    class RandomPointBall : Ball
    {
        public RandomPointBall(MainForm form) : base(form)
        {
            x = random.Next(0, form.ClientSize.Width - size);
            y = random.Next(0, form.ClientSize.Height - size);
        }
    }
}
