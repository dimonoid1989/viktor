using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class BallDisapearedEventArgs : EventArgs
    {
        public FruitNinjaBall FruitNinjaBall { get; }
        public BallDisapearedEventArgs(FruitNinjaBall fruitNinjaBall)
        {
            FruitNinjaBall = fruitNinjaBall;
        }
    }
}
