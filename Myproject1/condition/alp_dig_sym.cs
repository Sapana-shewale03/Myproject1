using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.condition
{
    class alp_dig_sym
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter any value");
            char ch = Convert.ToChar(Console.ReadLine());

            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine("given value is alphabet");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine(" value is digit");
            }
            else
            {
                Console.WriteLine("VALUE IS SYMBOL");
            }
        }
      
    }
}
