using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.loops
{
    class loop_basic
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("how many time you want t print message");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
//while loop
            while(i <= n)
            {
                Console.WriteLine("HELLO\n");
                i++;
            }
//for loop
            for(int j = 1;j <= n; j++)
            {
                Console.WriteLine("good morning\n");
            }

            //do_while loop
            int k = 1;
            do
            {
                Console.WriteLine("good night");
                k++;
            } while (k <= n);

        }
    }
}
