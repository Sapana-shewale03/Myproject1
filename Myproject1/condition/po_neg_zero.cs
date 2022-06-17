using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.condition
{
    class po_neg_zero
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("number is even  " + a);

                if (a > 0)
                {
                    Console.WriteLine("number is positive  " + a);
                }
                else
                {
                    Console.WriteLine("number is negative  " + a);
                }
            }
                 if(a == 0)
                {
                    Console.WriteLine("number is zero");
                }
            
            else
            {
                Console.WriteLine("number is odd   " + a);
            }
        }
    }
}
