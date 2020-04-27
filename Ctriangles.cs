using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lab_2
{
    class Ctriangles
    {
        Ctriangle[] ctriangles;
        internal Ctriangle[] Ctriangles_ { get => ctriangles; set => ctriangles = value; }

        public Ctriangles()
        {

        }

        public Ctriangles(int N)
        {
            Ctriangles_ = new Ctriangle[N];
            Random r = new Random();

            for (int i = 0; i < Ctriangles_.Length; i++)
            {
                Ctriangles_[i] = new Ctriangle();
                Ctriangles_[i].Side1 = r.Next(10, 15);
                Ctriangles_[i].Side2 = r.Next(10, 15);
                Ctriangles_[i].Side3 = r.Next(2, 20);
            }
        }

        public void PrintCtriangles()
        {
            int i = 1;
            foreach (Ctriangle ctriangle in Ctriangles_)
                Console.WriteLine("Ctriangle" + i++ + " with sides: " + ctriangle.Side1 + ',' + ctriangle.Side2 + ',' + ctriangle.Side3); 
            
        }

        public double findMiddleSquare()
        {
            double middle = 0;

            if (Ctriangles_.Length > 0)
                for (int i = 0; i < Ctriangles_.Length; i++)
                {
                    Ctriangles_[i].GetAngle();
                    middle += Ctriangles_[i].GetSquare();
                }
            return (int)(middle / Ctriangles_.Length);
        }
    }

}
