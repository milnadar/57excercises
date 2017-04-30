using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.start();
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
