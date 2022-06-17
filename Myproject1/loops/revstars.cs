using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.loops
{
    class revstars
    {
        public static void Main(string[] args)
        {

           for(int i = 5; i>=1;i--)
            {
                for(int j=  1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            // for n values
            Console.WriteLine("enter top number from where you want to print stars");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();

            }
            // for upper and lower limit
            Console.WriteLine("enter higher value");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter lower value");
            int p = Convert.ToInt32(Console.ReadLine());
            for (int i = m; i >= p; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();

            }
            /* *
               **
               ***
               ***
               **
               *  */


            Console.WriteLine("eneter how many step you want to print");
            int d = Convert.ToInt32(Console.ReadLine());
            int k;
            for (int i = 1; i <= d; i++)
            {

                
                for (k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            
            for (int i = d; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");

                }
                Console.WriteLine();

            }

            /*            *  
                         * *
                        * * *
                       * * * *
            */
            Console.WriteLine("enter any number");
             int g = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= g; i++)
            {


                for (k = 1; k <= (g - i); k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < i * 2; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

            }

        }
    }
}
