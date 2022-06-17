using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.condition
{
    class gnbetween3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter 3 numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
           /* int max = 0;
            if (a > b)
            {

                if (a > c)
                {

                    max = a;
                    
                }
                else if(c > a)
                {
                    max = c;
                }
            }
            
            else
            {
               if(b > c)
                { 
                    max = b;
                }
               else if(c > b)
               {
                    max = c;
               }

            }

            Console.WriteLine("greater number is " + max);*/

            if(a > b && b > c )
            {
                Console.WriteLine("greater number is " + a);
            }
            else if(b > c)
            {
                Console.WriteLine("greater number is " + b);

            }
            else
            {
                Console.WriteLine("greter number is " + c);
            }


        }
    }
}
