using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Advancecsharp.NonGeneric
{
    class all_list_non_generic
    {
        static void Main(string[] args)
        {
             ArrayList a = new ArrayList(10);
                 a.Add(12);
            a.Add("om");
            a.Add(true);
            a.Add(new StringBuilder("siya"));
            foreach(string data in a)
                   Console.WriteLine(data);
            for(int i=0;i<a.Count;i++)
                Console.WriteLine(a[i]);

            string s = (string)a[2];


               Hashtable ht = new Hashtable();
              ht.Add("om", 55);
               ht.Add(45, "yn");
               ht.Add("gyg", "hh");
               foreach (DictionaryEntry kv in ht) 
               Console.WriteLine(kv.Key + "==>" + kv.Value);

               SortedList s1 = new SortedList();

               Stack st = new Stack();

        }
    }
    class nongenerixex
    {
        static void Main(string[] args)
        {
           ArrayList a = new ArrayList(10);

        }
    }
}
