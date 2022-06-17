using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.loops
{
    class sqofnumber
    {
        static void Main(string[] args)
        {
            int sq = 1;
            for (int j = 1; j <= 20; j++)
            {

                sq = j * j;
                Console.WriteLine("square of " + j + " is " + sq);

            }
        }
    }

    class baseindex
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter base");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter power");
            int p = Convert.ToInt32(Console.ReadLine());

            int result = 1;
            for (int j = 1; j <= p; j++)
            {
                result = result * b;

            }
            Console.WriteLine(+b + " with power " + p + " is " + result);
        }

    }
    /// <summary>
    /// prg for factorial
    /// </summary>
    class factoralof_number
    {
        static void Main(string[] args)
        {
            
            int result = 1,r=1,sum =1;
  
                for (int j = 1; j <= 5; j++)
                {
                    result = result * j;
                    sum = sum + result;
                }
             Console.WriteLine("addition of factorials is  " + sum);
        }

    }

    //////factorial of numbers like 1! +5!+3!=153
    class krishnamurthyprg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            int sumoffact = 0;
            int m = n;
            while (n != 0)
            {
                int r = n % 10;
                result = 1;

                for (int j = 1; j <= r; j++)
                {
                    result = result * j;
                }
                Console.WriteLine("result "+result);
                sumoffact = sumoffact + result;
                n = n / 10;
            }
            Console.WriteLine(sumoffact);
            if (sumoffact == m)
            {
                Console.WriteLine("number is krishnamurthy");
            }
            else
            {
                Console.WriteLine("number is not krishanmurthy");
            }
        }
    }

    ///automorphas number
    class automorphicnumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int n = Convert.ToInt32(Console.ReadLine());
            bool automorphic = false;
            int sq = 1, h,g;
            for (int j = 1; j <= n; j++)
            {
                sq = j * j;
            }
            Console.WriteLine("sq of " + n + " is " + sq);
            while (n != 0)
            {
                h = n % 10;
                g = sq % 10;
                if(h == g)
                {
                    automorphic = true;
                }
                else
                {
                    automorphic = false;
                }
                n = h / 10;

                sq = sq / 10;
            }
            
            

            if (automorphic)
            {

                Console.WriteLine("number is  automorphic");

            }
            else
            {
                Console.WriteLine("number is not  automorphic");

            }

        }
    }

    ///harshad/niven number like 18 is divisible by 9 and 1+8 = 9
    class harshad_nivennum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int n = Convert.ToInt32(Console.ReadLine());
            int num = n;
            int sum = 0,r;
            while (n != 0)
            {
                r = n % 10;
                sum = sum + r;
                n = n / 10;
            }
            Console.WriteLine(sum);
            if(num % sum == 0)
            {
                Console.WriteLine("number is harshas/niven");
            }
            else
            {
                Console.WriteLine(" number is not harshad/niven");
            }
        }
    }
    
   
    
}

 





