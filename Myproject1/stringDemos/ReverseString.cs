using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.stringDemos
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string  ");
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();

            string reverse = "";
            for(int i=ch.Length-1; i>=0; i--)
            {
                reverse = reverse + ch[i];
            }
            Console.WriteLine(reverse);
        }
    }
    ///or for above loggic
    class Reversewordstring
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string  ");
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();

            string reverse = "";
            for (int i = 0;i<str.Length;i++)
            {
                reverse = str[i]+reverse;
            }
            Console.WriteLine(reverse);
        }
    }
    /////reverse each only on strng
    class Reverseeachwordstring
    {
        public static string reverseword(String str)
        {
            string[] s = str.Split(" ");
            string reverse = "";
            for (int i = 0; i < s.Length; i++)
            {
                string word = s[i];
                string rev = "";
                for(int j =word.Length-1;j<0;j++)
                {
                    rev = word[j] + rev;
                }
                reverse = reverse + " " + rev;
            }
            return reverse;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter string  ");
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();

            string reverse = "";
           
        }
    }
}
