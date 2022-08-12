using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Advancecsharp.Thread1
{
    class Class1
    {
        public static void calltochildTread()
        {
            Console.WriteLine("child thread");
        }
        static void Main(string[] args)
        {
            ThreadStart childref = new ThreadStart(calltochildTread);
            Console.WriteLine("i am creating child tread");
            Thread childThread = new Thread(childref);
            childThread.Start();
        }
    }

    /// 
    class Class2
    {
        public static void calltochildTread()
        {
            Console.WriteLine("child thread start");
            int sleepfor = 5000;    ////// 5000 milisecond
                Console.WriteLine("child thread pause for second "+sleepfor/1000);
            Thread.Sleep(sleepfor);
            Console.WriteLine("child thread resume");
        }
        static void Main(string[] args)
        {
            ThreadStart childref = new ThreadStart(calltochildTread);
            Console.WriteLine("in main creating child tread");
            Thread childThread = new Thread(childref);
            childThread.Start();
        }
    }
}
