using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.condition
{
    class ternary_po_neg_zero
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int n = Convert.ToInt32(Console.ReadLine());

            string temp = (n > 0) ? "positive" : (n < 0) ? "negative" : "zero";
            Console.WriteLine(temp);
        }
    }
}
