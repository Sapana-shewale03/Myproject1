using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.condition
{
    class equtriangle
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("emter side of eqvilateral triangle");
            double s = Convert.ToDouble(Console.ReadLine());
            double a;
            a = (1.73 * s * s) / 4;
            Console.WriteLine("area of equvilateral triangle is " + a);
        }
    }
}
