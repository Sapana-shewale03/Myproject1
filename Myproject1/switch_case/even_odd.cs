using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.switch_case
{
    class even_odd
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter number");

            int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter any number");
            //int num = Convert.ToInt32(Console.ReadLine());

            

            switch(a % 2 == 0)
            {
                
                case true: Console.WriteLine("even" );
                    break;
                case false: Console.WriteLine("odd" );
                    break;
                default: Console.WriteLine("enter valid choice");
                    break;
            }
        }
    }
}
