using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advancecsharp.Collections
{
    class course_student
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> dd = new Dictionary<string, string>();
            dd.Add("nilesh", "java");
            dd.Add("uma", "c#");
            dd.Add("jaya", "java");
            dd.Add("nisha", "python");
            dd.Add("nil", "c#");
            dd.Add("esh", "java");
            Dictionary<string, List<string>> d2 = new Dictionary<string, List<string>>();
            foreach (KeyValuePair<string, string> kv in dd)
            {
                string sname = kv.Key;
                string coursename = kv.Value;
                if (d2.ContainsKey(coursename))
                {
                    List<string> l2 = d2[coursename];
                    l2.Add(sname);
                    d2[coursename] = l2;
                }
                else
                {
                    List<string> lst = new List<string>();
                    lst.Add(sname);
                    d2.Add(coursename, lst);
                }
            }
                foreach(KeyValuePair<string ,List<string>> kv in d2)
                {
                string cnm = kv.Key;
                List<string> studlist = kv.Value;
                foreach (string snm in studlist)
                    Console.WriteLine(snm);
                Console.WriteLine("coursname = "+cnm);
                
                }
            
        }
    }
}
