using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class BallDisapearedEventArgs : EventArgs
    {
        public Ball Ball { get; }
        public BallDisapearedEventArgs(Ball ball)
        {
            Ball = ball;
        }

        //Изменение ддля форка и ревью
    }
}
