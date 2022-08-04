using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advancecsharp
{
    class Stackdemo
    {
        static void Main(string[] args)
        {

        Stack<string> st = new Stack<string>();
            st.Push("A");
            st.Push("B");
            st.Push("C");
            st.Push("D");
            st.Push("E");
            st.Push("F");

            st.Pop();
            //st.Clear();
            string[] arr = new string[st.Count];
            st.CopyTo(arr, 0);

            foreach(string d in arr)
                Console.WriteLine(d);
          //  foreach(string d in st)
              //  Console.WriteLine(d);

        }
    }
}
