using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.loops
{
    class whleloops
    {
       public static void Main(string[] args)
        {
            int r =0, rev=0;
            Console.WriteLine("enter any number");
            int n = Convert.ToInt32(Console.ReadLine());
            while(n > 0)
            {
                 r = n % 10;
                rev = rev * 10 + r;
                n = n / 10;
            }
            Console.WriteLine(rev);
        }
    }
    ///prnt 1 to 10 even no as t s odd no sq
    class evenoddaq
    {
        public static void Main(string[] args)
        {
            int i = 1 ;
            while (i <=10)
            {
                int r = (i % 2 == 0) ? i : i * i;
                Console.WriteLine(r);

                i++;
            }
        }
    }

    ///////2 12 36 80
    class eseres2_12
    {
        public static void Main(string[] args)
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine((i * i) + (i * i * i));
                i++;
            }
        }
    }
    ///seres 1 3  8 15 24
     ///////2 12 36 80
    class seres1to3
    {
        public static void Main(string[] args)
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine((i * i)-1);
                i++;
            }
        }
    }



    ////seres 2,5,10,17,26...
    class series2to5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enetr any number");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            int i = 1;
            while (i <= n)
            {
                if(i%2 !=0)
                {
                    sum = sum + i;
                    Console.WriteLine(sum);

                }
                i++;
            }
        }
    }

    ////palindrom number
    class palnumber
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enetr any number");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            int copy = n;
            int i = 1,r=1,rev=0;
            while (n>0)
            {
                r = n % 10;
                rev = rev * 10 + r;
                n = n / 10;
            }
            if(rev == copy)
            {
                Console.WriteLine("number s palndrom");
            }
            else
            {
                Console.WriteLine("number s not palndrom");
            }
        }
    }
    ////armstrongnumber
    class armstngnumber
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enetr any number");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            int copy = n;
            int i = 1, r = 1, cb = 0,arms=0;
            while (n > 0)
            {
                r = n % 10;
                cb = r * r * r;
                arms = arms + cb;
                n = n / 10;
            }
            if (arms == copy)
            {
                Console.WriteLine("number s armstrong");
            }
            else
            {
                Console.WriteLine("number s not armstrong");
            }
        }
    }

    ///// spy number
    class spynumber
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
            if(addi == multp)
            {
                Console.WriteLine("number s spy");
            }
            else
            {
                Console.WriteLine("number s nt spy");
            }
        }
    }

    //////  bnary to decmal
    class bnary_decmal
    {
        public static void Main(string[] args)
        {
            int sum = 0,p = 0,r=0;
            Console.WriteLine("enetr bnary number");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                r = n % 10;
                int power = (int)(Math.Pow(2,p));
                sum = sum + (power * r);
                n = n / 10;
                p++;
            }
            Console.WriteLine(sum);
        }
    }
    ///// decmal to bnanry
    class decmal_bnary
    {
        public static void Main(string[] args)
        {
            int p = 1, r = 0;
            string result =" ";
            Console.WriteLine("enetr decmal number");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                r =n % 2;
                //Console.Write(r);
                result = Convert.ToString(r) + result;
                n = n / 2;
               // Console.Write(" n="+n);

            }
            Console.WriteLine(result);

        }
    }
    //////magc number

    class magcnumber
    {
        public static void Main(string[] args)
        {
            int r = 0, sum = 0;
            Console.WriteLine("enter any number");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                r = n % 10;
                sum = sum + r;
                n = n / 10;
            }
            if(sum == 10)
            {
                Console.WriteLine("number s magc number  " + sum);
            }
            else
            {
                Console.WriteLine("number s not magc number  "+sum);
            }
        }
    }
}
