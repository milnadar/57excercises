using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator
{
    class Player
    {
        public Player() { }
        public void start()
        {
            MyConverter converter = new MyConverter();
            TipCalculator calculator = new TipCalculator();
            int bill, tip;
            while (true)
            {
                try
                {
                    Console.WriteLine("What is the bill? ");
                    bill = converter.convert(Console.ReadLine());

                    Console.WriteLine("What is the tip? ");
                    tip = converter.convert(Console.ReadLine());

                }
                catch (ConverterException e)
                {
                    Console.WriteLine("Error: {0}", e.Message);
                    continue;
                }

                int res = calculator.calculate(tip, bill);
                Console.WriteLine("The tip is: {0}", res);
                Console.WriteLine("The total is: {0}\n", res + bill);
            }
        }
    }
}
