using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advancecsharp.Delegate
{
    class single_delegater
    {
        public delegate void addnum(int a, int b);
        public delegate void subnum(int a, int b);
        public void sum(int a, int b)
        {
            Console.WriteLine("addition is : "+(a+b));
        }
        public void sub(int a, int b)
        {
            Console.WriteLine("substraction is : " + (a - b));
        }

        static void Main(string[] args)
        {
            single_delegater sd = new single_delegater();
            addnum de1 = new addnum(sd.sum);
            subnum de2 = new subnum(sd.sub);
            de1(100, 40);
            de2(100, 60);

        }
    }
    /// 2nd ex
    public delegate void mydele();
    public delegate void mydele2(int a,int b);
    class prg
    {
        static void Add(int a,int b)
        {
            Console.WriteLine(a +b);
        }
        static void greet()
        {
            Console.WriteLine("good evening");
        }
        static void Main(string[] args)
        {
            greet();
            
            mydele2 d2 = Add;
            d2(10, 20);

        }
    }
}
