using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.switch_case
{
    class day
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter any number of day");
            int d = Convert.ToInt32(Console.ReadLine());
            
            switch(d)
            {
                case 1:Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Munday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:Console.WriteLine("enter valid day number");
                    break;

            }
        }
             
    }
}
