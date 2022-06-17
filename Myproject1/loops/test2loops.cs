using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.loops
{/// <summary>
/// prnt 1 to 1000 except 5 11 dvsbles
/// </summary>
    class test2loops
    {
        static void Main(string[] args)
        {
            int n = 100;
            for (int i = 1; i < 100; i++)
            {

                if ((i % 5 == 0) || (i % 11 == 0))
                {
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
    //////2. ERROR m of main s small
    ///3.ERROR  k is not define
    ///4.spy number
    class spynumbertest
    {
        public static void Main(string[] args)
        {
            int r = 0, addi = 0;
            Console.WriteLine("enetr any nunber");
            int n = Convert.ToInt32(Console.ReadLine());
            int multp = 1;
            while (n > 0)
            {
                r = n % 10;
                addi = addi + r;
                multp = multp * r;
                n = n / 10;
            }
            if (addi == multp)
            {
                Console.WriteLine("number s spy");
            }
            else
            {
                Console.WriteLine("number s nt spy");
            }
        }
    }
    ///5.trometrc number
    class triomorphc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int cb = n * n * n;
            int m = n;
            int r, sum = 0;
            Console.WriteLine("cube os " + m + " is " + cb);
            while (cb > 0)
            {
                r = cb % 10;
                if (r == m)
                {
                    Console.WriteLine("triomorphic number");
                }
                else
                {
                    Console.WriteLine(" Not triomorphic number");

                }
                break;
            }
        }
    }
    //////*     1
    //   2 2 2
    //    3 3 3 3 3
    // 4 4 4 4 4 4 4.


    class pyramdone
    {
        static void Main(string[] args)
        {

            int space = 5;
            int MAX = space;

            for (int i = 1; i < MAX; i++)
            {

                for (int j = 1; j < space; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }

                Console.Write("\n");
                space--;
            }
            Console.ReadLine();

        }
    }
    ////7* * * * 
    // * * * 
    //    * * * 
    //    * * 
    //     *
    class downtri
    {
        static void Main(string[] args)
        {

            int space = 5;
            int MAX = space;

            for (int i = 5; i >= 1; i--)
            {

                for (int j = 1; j < space; j++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(" * ");
                }

                Console.Write("\n");
                space++;
            }
            Console.ReadLine();

        }
    }////// 8.      1 2 3 4 5
     //              1 2 3 4
     //                1 2 3
     //                  1 2
     //                    1
    class downnum
    {
        static void Main(string[] args)
        {

            int space = 5;
            int MAX = space;

            for (int x = 5; x >= 1; x--)
            {
                for (int y = 5; y > x; y--)
                {
                    Console.Write(" ");
                }
                for (int z = 1; z <= x; z++)
                {
                    Console.Write(z);
                }

                Console.Write("\n");
                //space++;
            }
            Console.ReadLine();

        }
    }
    ////9.95\n96\n97\9\99
    ///10.  twin number
   class  twinnum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1st number:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd value:");
            int m = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if ((m - n == 2) || (n - m == 2))
            {
                Console.WriteLine("number is twin");
            }
            else
            {
                Console.WriteLine("not twin number");
            }
            for (int i = 2; i <= n; i++)
            {
                int k = 2; int p = 1;
                while (k < i);
                {
                    if (i % k == 0)
                    {
                        Console.WriteLine("prime number");
                        break;
                    }
                    k++;
                }
                for (int j = 2; j <= m; j++)
                {
                    int d = 2; int q = 1;
                    while (d < j) ;
                    {
                        if (j % d == 0)
                        {
                            Console.WriteLine(" prime number ");
                            break;
                        }
                        d++;
                    }
                }
            }
            
        }
    }
     /// 11.2 12 36 80 150 252....upto 10 terms
    class  seres
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            double result;
            for(int j = 1;j<=10;j++)
            {
                 result =Math.Pow(j,2) + Math.Pow(j,3);
                Console.Write("\t" + result);
            }
            Console.WriteLine("\n");
        }
    }
    ////12.even odd negatve sq
    class evenoddnegsq
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=50;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine("even number");
                }
                else
                {
                    int n = (-(i));
                    int sq = i * i;
                    Console.WriteLine("negatve number s "+n+"\n squre s "+sq);
                }
                Console.WriteLine();
            }
        }
    }
    ////13.ERROR infinte loop
    ///14.fibonacy serie upto 20
    class fibser
    {
        static void Main(string[] args)
        {
             int sum = 0, g = 1, prev = 0;
                for (int i = 0; i <= 20; i++)
                {
                    prev = sum + prev;
                    Console.WriteLine(prev);
                    sum = g;
                    g = prev;
                }
            Console.WriteLine();
        }
    }
    /////15.1!+2!+3!+4!...n WAP a program to find sum
    class factorsum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = 1; int sum = 0;
           for(int i=1; i<=n;i++)
            {
                result = result * i;
                sum = sum + result;
            }
            Console.WriteLine(sum);
        }
    }
}
