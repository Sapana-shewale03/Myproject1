using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.basic_prg
{
    class cube_square_swaping
    {
        public static void Main(string[] args)
        {
            int a = 3, b = 6, c;
            c = a * a;
            Console.WriteLine("square of number is "  + c);
            Console.ReadLine();

            // cube
            c = a * a * a;
            Console.WriteLine("cube of number is  "+a + c);
            Console.ReadLine();

            //swaping
            Console.Write("before swaping a=" +a+"b=" + b);
            c = a; 
            a = b;
            b = c;
            Console.WriteLine("after swaping  a= " +a+"b="+ b);

        }
    }
}
