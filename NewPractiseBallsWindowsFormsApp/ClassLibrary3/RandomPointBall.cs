using System.Windows.Forms;

namespace ClassLibrary3
{
    public class RandomPointBall : Ball
    {
        public RandomPointBall(Form form) : base(form)
        {
            x = random.Next(0, form.ClientSize.Width - size);
            y = random.Next(0, form.ClientSize.Height - size);
        }
    }
}
