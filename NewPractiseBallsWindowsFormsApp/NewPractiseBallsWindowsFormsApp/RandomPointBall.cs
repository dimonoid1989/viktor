using System.Drawing;

namespace NewPractiseBallsWindowsFormsApp
{
    class RandomPointBall : Ball
    {
        private int stepFromClientSize = 50;
        public RandomPointBall(MainForm form) : base(form)
        {
            x = random.Next(stepFromClientSize, form.ClientSize.Width - stepFromClientSize*2);
            y = random.Next(stepFromClientSize, form.ClientSize.Height - stepFromClientSize*2);
            //brush = Brushes.Chartreuse;
        }
    }
}
