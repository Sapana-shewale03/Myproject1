using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advancecsharp.Collections
{
    class Dictonary_demo
    {
        static void Main(string[] args)
        {
            List<Emp> ll = new List<Emp>();
            ll.Add(new Emp(1,"Deepa"));
            ll.Add(new Emp(2,"sapna"));

            //key should be unique
            Dictionary<string, int> dd = new Dictionary<string, int>();
            dd.Add("nilesh", 90);
            dd.Add("paresh", 90);
            dd.Add("rakesh", 91);
            dd.Add("suresh", 94);
            dd.Add("shailesh", 99);
            Console.WriteLine("nilesh before adding value  "+dd["nilesh"]);
            Console.WriteLine("value of suresh  "+dd["suresh"]);
            dd["nilesh"] = 98;
            Console.WriteLine("nilesh after adding value  "+dd["nilesh"]);
            dd.Remove("paresh");
           // dd.Clear();
            dd.ContainsKey("jyoti");
            dd.ContainsValue(91);
            foreach(KeyValuePair<string,int>kp in dd)
                Console.WriteLine(kp.Key+"=>"+kp.Value);
            /// making clone of dictioanry
            Dictionary<string, int> dm = new Dictionary<string, int>(dd);
            foreach (KeyValuePair<string, int> kp in dm)
                Console.WriteLine(kp.Key + "=>" + kp.Value);

        }
    }
    /////2nd  split word and get keys
   class splitdict
    {
        static void Main(string[] args)
        {
            List<string> ll = new List<string> { "red", "pink", "blue", "red", "pink", "yellow", "red" };
            Dictionary<string, int> dd = new Dictionary<string, int>();
            foreach(string color in ll)
            {
                if(dd.ContainsKey(color))
                {
                    int oldvalue = dd[color];
                    dd[color] = oldvalue + 1;
                }
                else
                {
                    dd.Add(color, 1);
                }
            }
            foreach (KeyValuePair<string, int> color in dd)
                Console.WriteLine(color.Key + "=>" + color.Value);

            Console.WriteLine();
            string s = "pratiksha";
            char[] carr = s.ToCharArray();
            Dictionary<char, int> dm = new Dictionary<char, int>();

            foreach (char m in carr)
            {
                if (dm.ContainsKey(m))
                {
                    int oldvalue = dm[m];
                    dm[m] = oldvalue + 1;
                }
                else
                {
                    dm.Add(m, 1);
                }
            }
            foreach (KeyValuePair<char, int> color in dm)
                Console.WriteLine(color.Key + "=>" + color.Value);
            Console.WriteLine();
            /// red color remove
            string colortodelete = "red";
            ll.Remove(colortodelete);
            while(true)
            {
                int idx = ll.IndexOf(colortodelete);
                if (idx != -1)
                    ll.RemoveAt(idx);
                else
                    break;
            }
            foreach(string m in ll)
                Console.WriteLine(m);
        }
    }
}
