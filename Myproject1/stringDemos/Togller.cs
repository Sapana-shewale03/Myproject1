using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.stringDemos
{
    class Togller
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enetre any string");
            string str = Console.ReadLine();
            string newstr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    newstr = newstr + char.ToLower(str[i]);
                }
                else if (char.IsLower(str[i]))
                {
                    newstr = newstr + char.ToUpper(str[i]);
                }
                else
                {
                    newstr = newstr + str[i];
                }
            }
            Console.WriteLine(newstr);
        }
    }
}
