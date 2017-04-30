using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator
{
    class MyConverter
    {
        public MyConverter() { }
        public int convert(string s)
        {
            if (s.Length == 0)
                throw new ConverterException("Empty string input");
            int result;
            try {
                result = Int32.Parse(s);
            } catch (FormatException)
            {
                throw new ConverterException("Invalid string provided");
            }
            if (result < 0)
                throw new ConverterException("Input should be a positive number");
            return result;
        }
    }
}
