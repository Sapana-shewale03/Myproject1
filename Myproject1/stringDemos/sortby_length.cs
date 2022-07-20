using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.stringDemos
{
    class sortby_length
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any string");
            string s = Console.ReadLine();
            string[] str = s.Split(" ");
           // Console.WriteLine(string.Join(" ",str));
            for(int i=0;i<str.Length;i++)
            {
                for(int j=i+1;j<str.Length;j++)
                {
                    if (str[i].Length > str[j].Length)
                    {
                        string temp = str[i];
                        str[i] = str[j];
                        str[j] = temp;
                    }
                    else if(str[i].Length==str[j].Length)
                    {
                        if(str[i].CompareTo(str[j])==-1)
                        {
                            string temp = str[i];
                            str[i] = str[j];
                            str[j] = temp;
                        }
                    }
                }
            }
                    Console.WriteLine(string.Join(" ", str));

        }
    }
}
