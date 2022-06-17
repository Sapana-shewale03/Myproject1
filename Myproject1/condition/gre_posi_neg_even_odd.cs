using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.basic_prg
{
    class gre_posi_neg_even_odd
    {
        public static void Main(string[] args)
        { 
             int a = 45, b = 78;
        //greater number
          
              if (a > b)
              {
                Console.WriteLine(+a+ "    number is greater  than  " + b);
              }
            else
            {
                Console.WriteLine(+a+ "    number is smaller than     " + b);
                Console.ReadLine();
            }

            //positive negative number
            double d = -23;

            if (d > 0)
            {
                Console.WriteLine(+d+ "    number is positive ");
            }
            else
            {
                Console.WriteLine(+d+ "    number is negative");
                Console.ReadLine();
            }

            //even or odd

            if (a % 2 == 0)
            {
                Console.WriteLine(+a + "    number is even ");
            }
            else
            {
                Console.WriteLine(+a + "    number is odd");
                Console.ReadLine();
            }

        }
    }
}
