using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advancecsharp
{
    class Hashsetsdemo
    {
        static void Main(string[] args)
        {
            HashSet<string> hs1 = new HashSet<string> { "ram", "raja", "siya", "riya" };
            HashSet<string> hs2 = new HashSet<string> { "raja", "siya", "diya", "mahi" };
            foreach(string m in hs1)
            Console.Write(" "+m);
            Console.WriteLine();
            foreach (string m in hs2)
                Console.Write(" "+m);
            Console.WriteLine("\nunion with hs1 and hs2");
            hs1.UnionWith(hs2);
            foreach (string m in hs1)
                Console.WriteLine(m);
            Console.WriteLine("//////////intersect of hs1 and hs2\\\\\\\\\\\\\\");
                    hs1.IntersectWith(hs2);
            foreach (string m in hs1)
                Console.WriteLine(m);
                    Console.WriteLine(  "\\\\\\\\\\\\hs1 subset of hs2"); 
            hs1.IsSubsetOf(hs2);
            foreach (string m in hs1)
                Console.WriteLine(m);
            Console.WriteLine("\\\\\\\\\\\\hs1 superset of hs2");

            hs1.IsSupersetOf(hs2);
            foreach (string m in hs1)
                Console.WriteLine(m);
            HashSet<string> h3 = hs1.Intersect(hs2).ToHashSet();
            foreach (string m in h3)
                Console.WriteLine(m);
        }
    }
    /////
    ///new prg
    class hashdemo
    {
        static void Main(string[] args)
        {
            HashSet<Emp> ss = new HashSet<Emp>();
            ss.Add(new Emp(12, "rajesh"));
            ss.Add(new Emp(23, "hs"));
            foreach(Emp k in ss)
                Console.WriteLine(k);
        }
    }
}
