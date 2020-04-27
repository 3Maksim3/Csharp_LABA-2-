using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ctriangle ctriangle = new Ctriangle();

            ctriangle.Side1 = 6;
            ctriangle.Side2 = 8;
            ctriangle.Side3 = 10;

            ctriangle.PrintCtriangle();
            Console.WriteLine();

            Ctriangles ctriangles = new Ctriangles(15);
            ctriangles.PrintCtriangles();
            Console.WriteLine();

            Console.WriteLine($"Miidle square all ctriangles: {ctriangles.findMiddleSquare()}");
        }


    }
}
