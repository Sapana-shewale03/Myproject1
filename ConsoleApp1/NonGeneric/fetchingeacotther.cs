using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Advancecsharp.NonGeneric
{
    class fetchingeacotther
    {
        static void Main(string[] args)
        {
             List<int> lst = new List<int>(){ 1,3,5,8,9};
            ArrayList a = new ArrayList(lst);
            a.Add(12);
            a.Add("om");
            a.Add(true);
            a.Add(new StringBuilder("siya"));
            foreach (string data in a)
                Console.WriteLine(data);
        }
    }
}
