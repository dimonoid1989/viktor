using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class TouchFormEvenArgs : EventArgs
    {
        public Side Side { get; }
        public TouchFormEvenArgs(Side side)
        {
            Side = side;
        }
    }
}
