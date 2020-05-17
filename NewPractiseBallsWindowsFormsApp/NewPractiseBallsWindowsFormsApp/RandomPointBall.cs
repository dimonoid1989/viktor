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
            x = random.Next(50, form.ClientSize.Width - 100);
            y = random.Next(50, form.ClientSize.Height - 100);
            brysh = Brushes.Chartreuse;
        }
    }
}
