using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator
{
    class TipCalculator
    {
        public TipCalculator() { }
        public int calculate(int bill, int tip)
        {
            return bill * tip / 100;
        }
    }
}
