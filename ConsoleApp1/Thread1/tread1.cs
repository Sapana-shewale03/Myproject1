using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Advancecsharp.Thread1
{
    class tread1
    {//single trread
        static void m1()
        {
            for(int i=1;i<100;i++)
            Console.WriteLine(i);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("main start");
            Thread t1 = new Thread(m1);
            t1.Start();
            for (int i = 1; i < 100; i++)
                Console.WriteLine("gm");

        }
    }
    ////prh
    class testtyy
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;int t = 0;
            while(a>0)
            {
                int r = a % 10;
                sum = sum + r;
                a = a / 10;
            }
            Console.WriteLine(sum);
            while (sum > 0)
            {
                t = t* 10 + sum % 10;
               sum= sum / 10;
            }
            Console.WriteLine(t);
            if(a==(sum*t))
            {
                Console.WriteLine("magic no");
            }
            else
                Console.WriteLine(  "not magic numner");
        }
    }
}
