using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.switch_case
{
    class absolute_value
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int n = Convert.ToInt32(Console.ReadLine());

             int m  = n > 0? n : -n;
            Console.WriteLine(m);
        }
    }
}
