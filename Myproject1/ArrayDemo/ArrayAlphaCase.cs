using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.ArrayDemo
{
    class ArrayAlphaCase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any charater");
            char[] ch = new char[1];
            string aplh = ""; string aplh1 = "";
            for (int i = 0; i < ch.Length; i++)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());
                if (ch[i] >= 'A' && ch[i] <= 'Z')
                {
                    aplh = aplh+ (char)(ch[i] + 32);
                }
                else if (ch[i] >= 'a' && ch[i] <= 'z')
                {
                    aplh1 = aplh1+(char)(ch[i] - 32);
                }
            }
            Console.WriteLine("************************");
            Console.WriteLine(aplh);
            Console.WriteLine(aplh1);

        }
    }
    //////palindrom string
    class StringPalindrom
    {
        static void Main(string[] args)
        {
            string rev = "";
            Console.WriteLine("enter any string");
            string str = Console.ReadLine();
           // string[] s = str.Split(" ");
            for (int i =str.Length-1;i>=0; i--)
            {
             //  int rev = rev % 10;
                rev = rev+ str[i];
            }
            Console.WriteLine(rev);
              if (str == rev)
              {
                Console.WriteLine("string is palindrom");
              }
            else
            {
                Console.WriteLine("strng s not palindrom");
            }
            Console.WriteLine();
        }
    }
    //////sortinng of string in ascending and descending 
    class SortString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any string");
            string str = Console.ReadLine();
            string[] s = str.Split(" ");
            //char[] ch = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length - 1; j++)
                {
                    if (s[i].CompareTo(s[j]) == -1)
                    {
                        string temp = s[i];
                        s[i] = s[j];
                        s[j] = temp;
                    }
                }
            }
            Console.WriteLine("ascending string is:");
            Console.WriteLine(string.Join(" ", s));
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length - 1; j++)
                {
                    if (s[i].CompareTo(s[j]) == 1)
                    {
                        string temp = s[i];
                        s[i] = s[j];
                        s[j] = temp;
                    }
                }
            }
            Console.WriteLine("descebnding string is:");
            Console.WriteLine(string.Join(" ", s));

        }
    }
    
  //// word sorting
  class WordStringSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string str = Console.ReadLine();
            string[] s = str.Split(" ");
            string revword = "";
            for (int i=0;i<s.Length;i++)
            {
                revword = s[i] +" "+ revword;
            }
            Console.WriteLine("acseding order"+revword);
        }
    }
    /////string type of array{'A+2','B+7','D+3','E+8'}
    class displayintno
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("ENTER ANY CHARACTER");
            string s = "A+2,B+7,D+3,E+8";
            string[] str = s.Split(",");
            string ch = Console.ReadLine();string m;
            string rev = "";
            for(int i=0; i<str.Length;i++)
            {
                    string[] str1 = str[i].Split("+");
                if (str1[0].CompareTo(ch) == 0)
                {
                    Console.WriteLine(str1[1]);
                }
                
            }
            Console.WriteLine();
        }
    }
}
