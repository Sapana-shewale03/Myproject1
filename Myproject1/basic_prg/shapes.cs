using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.basic_prg
{
    class shapes
    {
        public static void Main(string[] args)
        {
            double PI = 3.14, r = 12.3 , a;
            a = PI * r * r;
            Console.WriteLine("area of circle  " + a);
            Console.ReadLine();

            // RECTANGLE
            float b = 23;
            a = r * b;
            Console.WriteLine("area of rectangle  " + a);
            Console.ReadLine();

            //square
            a = r * r;
            Console.WriteLine("area of squre is  " + a);
            Console.ReadLine();

            //TRIANGLE
            a = 1/ 2 * r * b;
            Console.WriteLine("area of triangle is  " + a);
            Console.ReadLine();
          
        }
    }
}
