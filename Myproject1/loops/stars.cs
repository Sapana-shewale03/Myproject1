using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.loops
{
    class stars
    {     
        public static void Main(string[] args)
        {
           

            for(int i = 1;i <= 4; i++)
            {
                for(int j = 1;j <= i; j++)
                {
                    Console.Write("*");
                   
                }
                Console.WriteLine();
                
            }
         /*   // for n values
             Console.WriteLine("enter top number from where you want to print stars");
              int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();

            }
            // for upper and lower limit
            Console.WriteLine("enter top number from where you want to print stars");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter top number from where you want to print stars");
            int p = Convert.ToInt32(Console.ReadLine());
            for (int i = m; i <= p; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();

            }*/

        }
    }
}

