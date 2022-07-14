using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.loops
{
    class oddnu
    {
        static void Main(string[] args)
        {
            Console.WriteLine("odd numbers between ");
             for (int i = 500; i <= 600; i++)
             {
                 if(i%2 != 0)
                 {
                     Console.WriteLine("      "+i);

                 }

             }

            for(int i = 501; i<=599;i=i+2)
             {
                 if(i%2 != 0)
                 {
                     Console.WriteLine(i);
                 }
             }
            ///8=1,2,4,8
            Console.WriteLine("enter any number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("factors of " + n + " is ");

            for (int i = 1; i <= n; i++)
            {

                if (n % i==0)
                {

                    Console.WriteLine(i);
                }

            }
            
        }
    }
}
