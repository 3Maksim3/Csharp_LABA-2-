using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lab_2
{
    class Ctriangle
    {
        private double side1;
        private double side2;
        private double side3;
        double Angle1, Angle2, Angle3;

        public double Side1 { get => side1; set => side1 = (value > 0 ? value : 1); }
        public double Side2 { get => side2; set => side2 = (value > 0 ? value : 1); }
        public double Side3 { get => side3; set => side3 = (value > 0 ? value : 1); }

        public double Ctriangletrue(double Side1, double Side2, double Side3)
        { 
            if ((Side1 + Side2) > Side3)
                return Side1 + Side2 + Side3;
            return -1;
        }

        public double GetAngle()
        {
            Angle1 = Math.Cos((Math.Pow(Side1, 2) + Math.Pow(Side3, 2) - Math.Pow(Side2, 2)) / (2 * Side1 * Side3));
            Angle2 = Math.Cos((Math.Pow(Side1, 2) + Math.Pow(Side2, 2) - Math.Pow(Side3, 2)) / (2 * Side1 * Side3));
            Angle3 = Math.Cos((Math.Pow(Side2, 2) + Math.Pow(Side3, 2) - Math.Pow(Side1, 2)) / (2 * Side1 * Side3));
            return (Angle1 + ',' + Angle2 + ',' + Angle3);
        }

        public double GetPerimetr()
        {
            return Side1 + Side2 + Side3;
        }

        public double GetSquare()
        {
            return (Side1 * Side2 * Math.Sin(Angle3)) / 2;
        }

        public void PrintCtriangle()
        {
            Console.WriteLine($"Ctriangle0:side1 = {Side1}, side2 = {Side2}, side3 = {Side3} angles = {String.Format("{0:0.0}",GetAngle())} perimetr = {String.Format("{0:0.0}", GetPerimetr())} square =  {String.Format("{0:0.0}", GetSquare())}");
        }
    }
}
