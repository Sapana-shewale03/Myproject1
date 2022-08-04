using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Advancecsharp.Thread1
{
    class tread2
    {
        public static void m1()
        {
            for (int i = 1; i <= 30; i = i + 2)
            {
                Console.WriteLine("odd" + i + Thread.CurrentThread.Name);
            }
        }
       

        static void Main(string[] args)
        {
            Thread main = Thread.CurrentThread;
            Thread t1 = new Thread(m1);
            t1.Name = "omo";
            Console.WriteLine("priority= "+t1.Priority);
            Thread t2 = new Thread(m1);
            t2.Name = "ram";
            t2.Priority = ThreadPriority.Highest;
            t1.Start();
            t2.Start();
          //  Thread t3 = new Thread(m1);
            //t3.IsBackground = true;
          //  t3.Start();
        }
    }
}
