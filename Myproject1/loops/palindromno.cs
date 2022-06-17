using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.loops
{

    class sumofdigitsby_seperating

    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            ///sum of all digits by seperating number
            while (n != 0)
            {
                int r = n % 10;
                sum = sum + r;
                n = n / 10;
            }
            Console.WriteLine("sum of number is  " + sum);
           
        }
    }
    class palindromno
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int copy = n;
          
           ///sum of all digits by seperating number
           while(n!=0)
            {
                int r = n % 10;
                sum = sum*10 + r;
                n = n / 10;
            }
            Console.WriteLine("sum of number is  "+ sum);
            if(sum == copy)
            {
                Console.WriteLine("number is palindrom");

            }
            else
            {
                Console.WriteLine("number is not palindrom");
            }
        }
    }
}
