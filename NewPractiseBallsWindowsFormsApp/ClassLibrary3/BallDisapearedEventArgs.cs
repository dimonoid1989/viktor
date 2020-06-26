using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class BallDisapearedEventArgs : EventArgs
    {
        public Salute salutBall { get; }
        public FruitNinjaBall fruitNinjaBall { get; }
        public BallDisapearedEventArgs(Salute ball)
        {
            salutBall = ball;
        }
        public BallDisapearedEventArgs(FruitNinjaBall ball)
        {
            fruitNinjaBall = ball;
        }
    }
}
