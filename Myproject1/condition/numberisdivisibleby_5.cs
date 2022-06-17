using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.basic_prg
{
    class numberisdivisibleby_5
    {
        public static void Main(string[] args)
        {
            int a = 75;
            if(a % 5 == 0)
            {
                Console.WriteLine("number is divisible by 5  " + a);
            }
            else
            {
                Console.WriteLine("number is not divisible by 5   " + a);

            }
        }
    }
}
