using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.condition
{
    class ternary_op_odd_eevn
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int a = Convert.ToInt32(Console.ReadLine());

            string result = a % 2 == 0 ? "Even" : "odd";
            Console.WriteLine(result);

        }
    }
}
