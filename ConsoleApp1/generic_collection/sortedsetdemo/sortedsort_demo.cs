using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advancecsharp.sortedsetdemo
{

    class mysort:IComparer<Emp>
    {
        public int Compare(Emp e1, Emp e2)
        {
            return e1.Ename.CompareTo(e2.Ename);
        }
    }
    class sortedsort_demo
    {
        static void Main(string[] args)
        {
            //// it is in sorted order
            SortedSet<string> ss = new SortedSet<string>();
            ss.Add("rena");
            ss.Add("seema");
            ss.Add("reya");
            foreach(string k in ss)
                Console.WriteLine(k);

            SortedSet<Emp> s = new SortedSet<Emp>(new mysort());
            s.Add(new Emp(12, "ytrt"));
            s.Add(new Emp(34, "rtgd"));
            s.Add(new Emp(54, "tyg"));
            foreach (Emp k in s)
                Console.WriteLine(k);
        }
    }
}
