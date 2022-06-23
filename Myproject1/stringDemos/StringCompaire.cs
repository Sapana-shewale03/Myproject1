using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.stringDemos
{
    class StringCompaire
    {
        static void Main(string[] args)
        {
            string str = "hello";
            string s = "Hello";
            Console.WriteLine(str==s);
            Console.WriteLine(str.Equals(s));
            Console.WriteLine(s.CompareTo(str));
        }
    }
}
