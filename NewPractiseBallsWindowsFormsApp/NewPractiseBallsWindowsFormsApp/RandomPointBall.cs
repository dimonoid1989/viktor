using System.Drawing;

namespace NewPractiseBallsWindowsFormsApp
{
    class RandomPointBall : Ball
    {
        private int stepFromClientSize = 100;
        public RandomPointBall(MainForm form) : base(form)
        {
            x = random.Next(0, form.ClientSize.Width - stepFromClientSize);
            y = random.Next(0, form.ClientSize.Height - stepFromClientSize);
        }
    }
}
