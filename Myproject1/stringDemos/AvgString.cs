using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.stringDemos
{
    class AvgString
    {
        static void Main(string[] args)
        {
            int avg = 0;
            Console.WriteLine("enter string");
             string a = Console.ReadLine();
            int count = 0; int sum = 0;
            int n = a.Length;
                for (int i = 0; i < a.Length; i++)
                {
                    if (char.IsDigit(a[i]))
                    {
                        int m = (int)char.GetNumericValue(a[i]);
                        sum = sum + m;
                    count++;
                    avg = sum / count;
                    }
                }
                Console.WriteLine("sum " + sum);
            Console.WriteLine("avg " + avg);
            Console.WriteLine("count " + count);
            
        }
    }
    ///////no of words from string
    class CountNoString
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("enter string");
            string a = Console.ReadLine();
            for(int i =0;i<a.Length;i++)
            {
                if(char.IsDigit(a[i]))
                {
                    Console.WriteLine();
                }else
                {
                    count++;//count spaces too
                }
            }
            Console.WriteLine("no of char in string "+count);
        }
    }
    /////reverse all elemts
    class ReverseallString
    {
        public static string reverseall(string str)
        {
            string[] s = str.Split(" ");
            string revword = "";
            for(int i =0;i<s.Length;i++)
            {
                string word = s[i];
                string reverseword = "";
                for(int j=word.Length-1;j>=0;j--)
                {
                        reverseword = reverseword + word[j];
                }
                revword = revword + " " + reverseword;
            }
            return revword;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string s = Console.ReadLine();
            string rev = reverseall(s);
            Console.WriteLine(rev);
        }
    }
    /////reverse word of string ex india is my country==> india si ym country
    class ReverseMiddleString
    {
        public static string reversemiddle(string str)
        {
            string[] s = str.Split(" ");
            string revword = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (i==0 || i==s.Length-1)
                {
                    revword = revword + s[i];
                }
                else
                {
                    string word = s[i];
                    string reverseword = "";
                    for (int j = word.Length - 1; j >= 0; j--)
                    {
                        reverseword = reverseword + word[j];
                    }
                    revword = " "+revword + " " + reverseword;
                }
               // return revword;
            }
            return revword;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string s = Console.ReadLine();
            string rev = reversemiddle(s);
            Console.WriteLine(rev);
        }
    }
    /////strng in pattren form
    class StrngPattern
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a strng");
            string s = Console.ReadLine();
            string[] m = s.Split(" ");
            for (int i = 0; i < m.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" "+m[j]);
                }
                Console.WriteLine(" ");
            } 

        }
    }
 
}
