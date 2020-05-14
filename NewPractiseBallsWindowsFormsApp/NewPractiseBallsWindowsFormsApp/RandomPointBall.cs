using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPractiseBallsWindowsFormsApp
{
    class RandomPointBall : Ball
    {
        public RandomPointBall(MainForm form) : base(form)
        {
            x = random.Next(0, form.Width);
            y = random.Next(0, form.Height);
            brysh = Brushes.Chartreuse;
        }
    }
}
