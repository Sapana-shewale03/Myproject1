using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1
{
    class examdemo
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int max = 0;
            if (a > b && a > c)
            {

                max = a;

            }
            else if (c > a)
            {
                max = c;
            }
            
            else
            {
                if (b > c)
                {
                    max = b;
                }
                else if (c > b)
                {
                    max = c;
                }

            }

            Console.WriteLine( max);
        }
    }
    ///// nterger n even odd
   class werdprg
   {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 != 0)
            {
                Console.WriteLine("Weird");
            }
            else if (n % 2 == 0)
            {
                if (n > 2 && n < 5)
                {
                    Console.WriteLine("Not Weird");
                }
                else if(n > 6 && n < 10)
                {
                    Console.WriteLine("Weird");
                }
                else if(n>20)
                {
                    Console.WriteLine("Not Weird");
                }
            }       
        }
   }
}
