using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.condition
{
    class leapyear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year : ");
           char n = Convert.ToChar(Console.ReadLine());
            if (n =='a'|| n=='e'|| n =='i'|| n =='o'|| n =='u'|| n =='A'|| n =='E'|| n =='I'|| n =='O'|| n =='U')
            {
                Console.WriteLine("CHAR IS VOWEL " + n);
            }
            else
            {
                Console.WriteLine("NO VOWEL");
            }
        }
    }
}
