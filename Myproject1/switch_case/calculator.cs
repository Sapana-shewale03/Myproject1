using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.switch_case
{
    class calculator
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" +\n -\n *\n /\n");
            Console.WriteLine("enter your operation symbol");
            string ch = Console.ReadLine();
            Console.WriteLine("enter 1st value");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter 2nd value");
            int b = Convert.ToInt32(Console.ReadLine());


            switch(ch)
            {
                case "+": Console.WriteLine("for + is  " + (a + b));
                    break;

                case "-":
                    Console.WriteLine("for - is   " + (a - b));
                    break;

                case "*":
                    Console.WriteLine("for * is   " + (a * b));
                    break;

                case "/":
                    Console.WriteLine("for / is   " + (a / b));
                    break;
                default: Console.WriteLine("enetr valid value");
                    break;


            }
        }
    }
}
