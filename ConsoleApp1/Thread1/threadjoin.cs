using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.Threading;


namespace Advancecsharp.Thread1
{
    class threadjoin
    {
        static void m1()
        {
            for(int i=200;i<230;i=i+2)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("main start");
            Thread t1 = new Thread(m1);
            t1.Start();
            t1.Join();//the currently thread which is executing the methhod will wait t1 thread completed
            for (int i = 1; i < 20; i = i + 2)
            {
                Console.WriteLine("main "+i);
            }

        }
    }
}
