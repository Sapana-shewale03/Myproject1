using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advancecsharp.sorted_list
{
    class mystringbubilder:IComparer<StringBuilder>
    {
        public int Compare(StringBuilder x, StringBuilder y)
        {
            return x.ToString().CompareTo(y.ToString());
        }
    }
    class stringbuider
    {
        static void Main(string[] args)
        {
            SortedList<StringBuilder, int> sb = new SortedList<StringBuilder, int>(new mystringbubilder());
            sb.Add(new StringBuilder("amit"), 9000);
            sb.Add(new StringBuilder("om"), 9000);
            sb.Add(new StringBuilder("priyank"), 9000);
            sb.Add(new StringBuilder("amita"), 9000);

            foreach(KeyValuePair<StringBuilder,int>kv in sb)
                Console.WriteLine(kv.Key+"===>"+kv.Value);
        }
    }
}
