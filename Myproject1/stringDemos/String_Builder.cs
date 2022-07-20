using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.stringDemos
{
    class String_Builder
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("hello");
            Console.WriteLine(sb);
            sb.Append(" program");
            Console.WriteLine(sb);

            StringBuilder sb2 = new StringBuilder("pune");
            Console.WriteLine(sb2);
            string s = "India";
            StringBuilder sb3 = new StringBuilder(s);
            sb3.Append(" ");
            Console.WriteLine(sb3);

            sb3.Append("country");
            Console.WriteLine(sb3);

            sb3.Insert(6, "my ");
            Console.WriteLine(sb3);
           sb3.Remove(3, 4);
            Console.WriteLine(sb3);

            StringBuilder s1 = new StringBuilder("hello");
            StringBuilder s2 = new StringBuilder("hello");
            Console.WriteLine(s1==s2);
            Console.WriteLine(s1.Equals(s2));
            string st = s1.ToString();
            Console.WriteLine(st);
        }
    }
}
