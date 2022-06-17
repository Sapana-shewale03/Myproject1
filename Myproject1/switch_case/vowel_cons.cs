using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.switch_case
{
    class vowel_cons
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enetr any char");
           string ch = Console.ReadLine();

            switch(ch)
            {
                case "a": Console.WriteLine("character is vowel");
                    break;

                case "e":
                    Console.WriteLine("character is vowel");
                    break;
                case "i":
                    Console.WriteLine("character is vowel");
                    break;
                case "o":
                    Console.WriteLine("character is vowel");
                    break;
                case "u":
                    Console.WriteLine("character is vowel");
                    break;
                default : Console.WriteLine("character is consonant");
                    break;

            }
        }

    }
}
