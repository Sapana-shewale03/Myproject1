using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.loops
{
    class odd_number
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("odd numbers between 521 to 229");
            for (int i = 229; i <= 521; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    //program to show break stmt
    class breakstmt
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("odd numbers between 521 to 229");
            for (int i = 0; i <= 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
    //gcd and lcm of number
    class gcdlcms
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter any two number");
            int g = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int a, numgcd, numlcm, n, m;
            n = g;
            m = d;
            while (m != 0)
            {
                a = m;
                m = n % m;
                n = a;
            }
            numgcd = n;
            numlcm = (g * d) / numgcd;
            Console.WriteLine("lcm is" + numlcm);
            Console.WriteLine("gcd is" + numgcd);

        }
    }
    class printuptoz
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("english alphabets if ypu want to print capital them press 1 or anything for small letterrs ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n != 1)
            {
                for (char i = 'a'; i <= 'z'; i++)
                {

                    Console.WriteLine(i);
                }
            }
            else
            {
                for (char i = 'A'; i <= 'Z'; i++)
                {

                    Console.WriteLine(i);
                }
            }
        }
    }

    // SUM OF ALL EVEN NUMBERS BETWEEN 1 TO N
    class SUMEVEN
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("ENTER ANY VALUE");
            int n = Convert.ToInt32(Console.ReadLine());
            int sumeven = 0;
            int sumodd = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sumeven = sumeven + i;

                }
                else
                {
                    sumodd = sumodd + i;
                }
            }
            Console.WriteLine("sum of even numbers is  " + sumeven);
            Console.WriteLine("sum of odd numbers is  " + sumodd);
        }
    }
    class countdigit
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = 1;
            int a = n;
            int count = 1;
           for(int i=0;i<=a;i++)
            {
                m = (a % 10);
                a = a / 10;
                count++;
            }
            Console.WriteLine(count);
        }
    }
    class productofdigit
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int n = Convert.ToInt32(Console.ReadLine());
            int prod = 1;
            int a = n;

            while (n != 0)
            {
                int r = n % 10;
                prod = prod * r;
                n = n / 10;
            }
            Console.WriteLine(prod);
        }
    }

    ///prg for frequency of number

    ///prg for prime number between 300 to 400
    class primenumber
    {
        public static void Main(string[] args)
        {
            bool isPrime = true;
            Console.WriteLine();
            for (int i = 300; i <= 400; i++)
            {
                for (int j = 2; j <= 9; j++)
                {
                    if ((i % j) == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    else
                    {
                        isPrime = true;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    /// prg to write a table of given number
    /// 
    class tableofnumber
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int n = Convert.ToInt32(Console.ReadLine());
            int t = 1;
            Console.WriteLine(+n + "  table is  ");

            for (int j = 1; j <= 10; j++)
            {
                t = n * j;
                Console.WriteLine(+n+"x"+j+"=" + t);

            }
        }

    }

    ////factors with color
    class colorfact
    {
        public static void Main(string[] args)
        {
            

            for (int j = 1; j <= 50; j++)
            {
                 if (j % 3 == 0 && j % 5 == 0) 
                {
                    Console.WriteLine("red blue");
                }
                else if (j % 3 == 0) 
                {
                    Console.WriteLine("red");
                }
                else if (j % 5 == 0)
                {
                    Console.WriteLine("blue");

                }
                 else
                {
                    Console.WriteLine(j);
                }
            }
        }

    }

}
