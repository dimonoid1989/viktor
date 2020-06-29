using System.Windows.Forms;

namespace ClassLibrary3
{
    public class RandomPointBall : Ball
    {
        public RandomPointBall(Form form) : base(form)
        {
            X = random.Next(0, form.ClientSize.Width - size);
            Y = random.Next(0, form.ClientSize.Height - size);
        }
    }
}
