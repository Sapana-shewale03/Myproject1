using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.ArrayDemo
{
    class Longesdtword
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any string");
            string str = Console.ReadLine();
            string[] s = str.Split(" ");
            int maxlen = 0;
            string longword = "";
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i].Length>maxlen)
                {
                    maxlen = s[i].Length;
                }
            }
            for(int i=0;i<s.Length;i++)
            {
                if(maxlen==s[i].Length)
                {
                    Console.WriteLine(s[i]);
                }
            }
            
        }
    }
}
