using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.stringDemos
{
    class string_declartion
    {
        static void Main(string[] args)
        {
            string s = "hello";
            string str = "hellow";
            string st = new string("hello=w");
            Console.WriteLine(st == s);
            Console.WriteLine(str==st);
            Console.WriteLine(str.GetHashCode());
            str = str + " c#";
            Console.WriteLine(str.GetHashCode());
            Console.WriteLine(str);
        }
    }
    ////functions using prg
    class StringFunction
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int l = str.Length;
            Console.WriteLine(l);
            Console.WriteLine("*******************");
            string newUpper = str.ToUpper();
            Console.WriteLine(newUpper);
            Console.WriteLine("*************");
            string newLower = str.ToLower();
            Console.WriteLine(newLower);
            Console.WriteLine("*********************");
            char[] ch = str.ToCharArray();
            Console.WriteLine(string.Join(" ",ch));
            Console.WriteLine("************************");
            string substrinnew = str.Substring(3);
            Console.WriteLine(substrinnew);
            string sub2 = str.Substring(3,6);
            Console.WriteLine(sub2);
            Console.WriteLine(str[0]+" "+str[str.Length-1]);
            Console.WriteLine("***************");
            string[] word = str.Split(" ");
            foreach(string st in word)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine("*************************");
            Console.WriteLine(str.IndexOf('i'));
            Console.WriteLine(str.LastIndexOf('i'));
        }
    }
}


