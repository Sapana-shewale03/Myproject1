using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advancecsharp.sorted_list
{
    class sorted_list_demo
    {
        static void Main(string[] args)
        {
            SortedList<int, string> ss = new SortedList<int, string>();
            ss.Add(1, "ram");
            ss.Add(3, "deva");
            ss.Add(2, "dnj");

            foreach(KeyValuePair<int,string> kv in ss)
                Console.WriteLine(kv.Key+" ==>"+kv.Value);
        }
        
    }
}
