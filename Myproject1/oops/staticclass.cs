using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.oops
{
    static class staticclass
    {
       public static int raddd(int x, int y)
        {
            int a = x;
            int b = y;

            int r= a + b;
            return r;
        }
        public static string A_name = "reshma";
        public static string l_name = "c#";
        public static int no = 873;

        public static void show()
        {
            Console.WriteLine("///static class demo////");
        }
    }
    class gfg
    { 
        static void Main(string[] args)
        {
            int a = 12, b = 14;
           // staticclass.raddd(2, 4);
            int c = staticclass.raddd(a, b);
            Console.WriteLine("sum is :" + c);
            staticclass.show();
            Console.WriteLine("authoe name "+ staticclass.A_name);
            Console.WriteLine("lang name "+ staticclass.l_name);
            Console.WriteLine("books "+ staticclass.no);
        }
    }
}
