using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.loops
{
    class prime_number
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 2; i <= n; i++)
            {
                int k = 2; int p = 1;
                while (k < i)
                {
                    if (i % k == 0)
                    {
                        p = 0;
                        break;
                    }
                    k++;
                }
                if (p == 1)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("sum of prime number is : " + sum);
        }
    }
    ////////disarium number
    class disariumnum
    {
        static void Main(string[] args)
        {
            Console.Write("enter any number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int r = 1;int sum = 0;int disa = 0;
            int m = n;int prod = 1;int h = m;
            while (n != 0)
            {
                r = n % 10;
                sum++;
                n = n / 10;
            }
            Console.WriteLine(sum );
            for(int i = 1;i<=sum;i++)
            {
                r = m % 10;
                for (int j = 1; j <= (sum - i + 1); j++)
                {
                    prod = prod * r; 
                }
                disa = disa + prod;
                prod = 1;
                m = m / 10;
            }
            Console.WriteLine(disa);
            if(h == disa)
            {
                Console.WriteLine("number is disarium");
            }
            else
            {
                Console.WriteLine("number is not disarium");
            }
        }
    }
    //////kaprekar number
    class numkaprekar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int n = Convert.ToInt32(Console.ReadLine());
            int sq = n * n;
            Console.WriteLine("sq of "+n+" is "+sq);
           
            int sum = 0;
            while(sq!=0)
            {
                int r = sq % 100;
                sum = sum + r;
                sq = sq / 100;
            }
            Console.WriteLine("sum of sq digits is "+sum);
            if(n == sum)
            {
                Console.WriteLine("number is kaprekar  ");
            }
            else
            {
                Console.WriteLine(" number is not kaprekar");
            }

        }
    }
}
