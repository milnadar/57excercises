using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator
{
    class ConverterException : Exception
    {
        public ConverterException(string s)
            : base(s)
            { }
    }
}
